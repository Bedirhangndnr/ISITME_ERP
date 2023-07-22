$(document).ready(function () {
    const tableType = document.getElementById("tableType").value;

    /* DataTables start here. */

    const dataTable = $('#outPaymentDetailsTable').DataTable({
        dom:
            "<'row'<'col-sm-3'l><'col-sm-6 text-center'B><'col-sm-3'f>>" +
            "<'row'<'col-sm-12'tr>>" +
            "<'row'<'col-sm-5'i><'col-sm-7'p>>",
        buttons: [
            {
                text: 'Ekle',
                attr: {
                    id: "btnAdd",
                },
                className: 'btn btn-success',
                action: function (e, dt, node, config) {
                    var outPaymentId = document.getElementById('outPaymentId').value;


                    // Modal açma işlemleri
                    const url = '/Admin/OutPaymentDetail/Add/';
                    const placeHolderDiv = $('#modalPlaceHolder');
                    $.get(url, { outPaymentId: outPaymentId }).done(function (data) {
                        placeHolderDiv.html(data);
                        placeHolderDiv.find(".modal").modal('show');
                    }).fail(function (xhr, status, error) {
                        console.log(xhr.responseText);
                        console.log(status);
                        console.log(error);
                        toastr.error("Bir hata oluştu.");
                    });
                }
            }
,
            {
                text: 'Yenile',
                className: 'btn btn-warning',
                action: function (e, dt, node, config) {
                    $.ajax({
                        type: 'GET',
                        data: { tableType: tableType },
                        url: '/Admin/OutPaymentDetail/GetAllOutPaymentDetails/',
                        contentType: "application/json",
                        beforeSend: function () {
                            $('#outPaymentDetailsTable').hide();
                            $('.spinner-border').show();
                        },
                        success: function (data) {
                            const outPaymentDetailListDto = jQuery.parseJSON(data);
                            dataTable.clear();
                            console.log(outPaymentDetailListDto);
                            if (outPaymentDetailListDto.Data.ResultStatus === 0) {
                                $.each(outPaymentDetailListDto.Data.OutPaymentDetails.$values,
                                    function (index, outPaymentDetail) {
                                        const newTableRow = dataTable.row.add([
                                            outPaymentDetail.Id,
                                            outPaymentDetail.AmountPaid,
                                            outPaymentDetail.Description,
                                            `
                                                <div class="form-group row justify-content-center">
                                                ${tableType === 'NonDeletedTables' ? '<button title="Güncelle" class="btn btn-primary btn-sm btn-update" data-id=' + outPaymentDetail.Id + '><span class="fas fa-edit"></span></button>' : ''}
                                                <button title="Sil" class="btn btn-danger btn-sm btn-delete" data-id=${outPaymentDetail.Id} data-tableType=${tableType}><span class="fas fa-minus-circle"></span></button>
                                                ${tableType === 'DeletedTables' ? '<a class="btn btn-warning btn-sm btn-undo" data-id="' + outPaymentDetail.Id + '"><span class="fas fa-undo"></span></a>' : ''}
                                                </div>
                                                    `
                                        ]).node();
                                        const jqueryTableRow = $(newTableRow);
                                        jqueryTableRow.attr('name', `${outPaymentDetail.Id}`);
                                    });
                                dataTable.draw();
                                $('.spinner-border').hide();
                                $('#outPaymentDetailsTable').fadeIn(1400);
                            } else {
                                $('.spinner-border').hide();
                                $('#outPaymentDetailsTable').fadeIn(1000);
                                toastr.error(`${outPaymentDetailListDto.Data.Message}`, 'İşlem Başarısız!');
                            }
                        },
                        error: function (err) {
                            console.log(err);
                            $('.spinner-border').hide();
                            $('#customerTypesTable').fadeIn(1000);
                            toastr.error(`${err.responseText}`, 'Hata !');
                        }
                    });
                }
            }
        ],
        language: {
            "sDecimal": ",",
            "sEmptyTable": "Tabloda herhangi bir veri mevcut değil",
            "sInfo": "_TOTAL_ kayıttan _START_ - _END_ arasındaki kayıtlar gösteriliyor",
            "sInfoEmpty": "Kayıt yok",
            "sInfoFiltered": "(_MAX_ kayıt içerisinden bulunan)",
            "sInfoPostFix": "",
            "sInfoThousands": ".",
            "sLengthMenu": "Sayfada _MENU_ kayıt göster",
            "sLoadingRecords": "Yükleniyor...",
            "sProcessing": "İşleniyor...",
            "sSearch": "Ara:",
            "sZeroRecords": "Eşleşen kayıt bulunamadı",
            "oPaginate": {
                "sFirst": "İlk",
                "sLast": "Son",
                "sNext": "Sonraki",
                "sPrevious": "Önceki"
            },
            "oAria": {
                "sSortAscending": ": artan sütun sıralamasını aktifleştir",
                "sSortDescending": ": azalan sütun sıralamasını aktifleştir"
            },
            "select": {
                "rows": {
                    "_": "%d kayıt seçildi",
                    "0": "",
                    "1": "1 kayıt seçildi"
                }
            }
        }
    });
    if (tableType === "DeletedTables") {
        $('.dt-buttons #btnAdd').remove(); // Düğmeyi kaldır
    }

    /* DataTables end here */

    /* Ajax POST / Deleting a User starts from here */

    $(document).on('click',
        '.btn-delete-detail',
        function (event) {
            event.preventDefault();
            const id = $(this).attr('data-id');
            const tableType = $(this).attr('data-tableType');
            const tableRow = $(`[name="${id}"]`);
            const outPaymentDetailTitle = tableRow.find('td:eq(2)').text(); // table datadan 2. indexdeki değeri aldık.
            Swal.fire({
                title: tableType === 'DeletedTables' ? 'Kalıcı olarak silmek istediğinize emin misiniz?' : 'Silmek istediğinize emin misiniz?',
                text: `${outPaymentDetailTitle} Başlıklı Ürün Alt Grubu ${tableType === 'DeletedTables' ? 'kalıcı olarak ' : ''} Silinecektir!`,
                icon: 'warning',
                showCancelButton: true,
                confirmButtonColor: '#3085d6',
                cancelButtonColor: '#d33',
                confirmButtonText: 'Evet, silmek istiyorum.',
                cancelButtonText: 'Hayır, silmek istemiyorum.'
            }).then((result) => {
                if (result.isConfirmed) {
                    $.ajax({
                        type: 'POST',
                        dataType: 'json',
                        data: { Id: id, tableType: tableType },
                        url: '/Admin/OutPaymentDetail/Delete/',
                        success: function (data) {
                            const outPaymentDetailResult = jQuery.parseJSON(data);
                            if (outPaymentDetailResult.ResultStatus === 0) {
                                if (tableType === 'DeletedTables') {
                                    Swal.fire(
                                        'Tamamen Silindi!',
                                        `${outPaymentDetailResult.Message}`,
                                        'success'
                                    );
                                }
                                else {
                                    Swal.fire(
                                        'Silindi!',
                                        `${outPaymentDetailResult.Message}`,
                                        'success'
                                    );
                                }
                                // index controller içindeyiz, sil butonuna tıklandığında şu adrese git
                                tableRow.fadeOut(2000, function () {
                                    dataTable.row($(this)).remove().draw();
                                });
                            } else {
                                Swal.fire({
                                    icon: 'error',
                                    title: 'Başarısız İşlem!',
                                    text: `${outPaymentDetailResult.Message}`,
                                });
                            }
                        },
                        error: function (err) {
                            console.log(err);
                            toastr.error(`${err.responseText}`, "Hata!");
                        }
                    });
                }
            });
        });




  

    $(function () {
        const url = '/Admin/OutPaymentDetail/Add/';
        const placeHolderDiv = $('#modalPlaceHolder');

        placeHolderDiv.on('click', '#btnSave', function (event) {
            event.preventDefault();
            const form = $('#form-outPaymentDetail-add');
            const actionUrl = form.attr('action');
            const dataToSend = form.serialize();
            $.post(actionUrl, dataToSend).done(function () {
                location.reload(); // Sayfayı yenile
            });
        });
    });


    /* Ajax POST / Posting the FormData as OutPaymentDetailAddDto ends here. */

    /* Ajax POST / Deleting a OutPaymentDetail starts from here */

    /* Ajax GET / Getting the _outPaymentDetailUpdatePartial as Modal Form starts from here. */

    $(function () {
        const url = '/Admin/OutPaymentDetail/Update/';
        const placeHolderDiv = $('#modalPlaceHolder');
        $(document).on('click', '.btn-update', function (event) {
            event.preventDefault();
            const tableType = document.getElementById("tableType").value;
            const id = $(this).attr('data-id');
            const isSpecificPage = true; // Spesifik sayfadan gelindiğini belirten değer
            $.get(url, { Id: id, tableType: tableType, isSpecificPage: isSpecificPage }).done(function (data) {
                placeHolderDiv.html(data);
                placeHolderDiv.find('.modal').modal('show');
            }).fail(function (xhr, status, error) {
                console.log(xhr.responseText);
                console.log(status);
                console.log(error);
                toastr.error("Bir hata oluştu.");
            });
        });

        /* Ajax POST / Updating a Customer starts from here */

        placeHolderDiv.on('click',
            '#btnUpdate',
            function (event) {
                event.preventDefault();

                const form = $('#form-outPaymentDetail-update');
                const actionUrl = form.attr('action');
                const dataToSend = `${form.serialize()}&tableType=${tableType}`;
                $.post(actionUrl, dataToSend).done(function (data) {
                    const outPaymentDetailTypeUpdateAjaxViewModel = jQuery.parseJSON(data);
                    console.log(outPaymentDetailTypeUpdateAjaxViewModel);
                    const newFormBody = $('.modal-body', outPaymentDetailTypeUpdateAjaxViewModel.outPaymentDetailUpdatePartial);
                    placeHolderDiv.find('.modal-body').replaceWith(newFormBody);
                    const isValid = newFormBody.find('[name="IsValid"]').val() === 'True';
                    if (isValid) {
                        const outPaymentDetail = outPaymentDetailTypeUpdateAjaxViewModel.OutPaymentDetailDto.OutPaymentDetail
                        const id = outPaymentDetail.Id;
                        const tableRow = $(`[name="${id}"]`);
                        placeHolderDiv.find('.modal').modal('hide');
                        dataTable.row(tableRow).data([
                            outPaymentDetail.Id,
                            outPaymentDetail.AmountPaid,
                            outPaymentDetail.Description,
                            `
                            <div class="form-group row justify-content-center">
                                  ${document.getElementById("tableType").value === 'NonDeletedTables' ? '<button title="Güncelle" class="btn btn-primary btn-sm btn-update" data-id=' + outPaymentDetail.Id + '><span class="fas fa-edit"></span></button>' : ''}
                                  <button title="Sil" class="btn btn-danger btn-sm btn-delete" data-id=${outPaymentDetail.Id} data-tableType=${tableType}><span class="fas fa-minus-circle"></span></button>
                                  ${document.getElementById("tableType").value === 'DeletedTables' ? '<a class="btn btn-warning btn-sm btn-undo" data-id="' + outPaymentDetail.Id + '"><span class="fas fa-undo"></span></a>' : ''}
                                </div>
                            `
                        ]);
                        tableRow.attr("name", `${id}`);
                        dataTable.row(tableRow).invalidate();
                        toastr.success(`${outPaymentDetailTypeUpdateAjaxViewModel.OutPaymentDetailDto.Message}`, "Başarılı İşlem!");
                    } else {
                        let summaryText = "";
                        $('#validation-summary > ul > li').each(function () {
                            let text = $(this).text();
                            summaryText = `*${text}\n`;
                        });
                        toastr.warning(summaryText);
                    }
                }).fail(function (response) {
                    console.log(response);
                });
            });

    });
    $(document).on('click',
        '.btn-undo-detail',
        function (event) {
            event.preventDefault();
            const id = $(this).attr('data-id');
            const tableRow = $(`[name="${id}"]`);
            const outPaymentDetailFirsName = tableRow.find('td:eq(1)').text();
            const outPaymentDetailLastName = tableRow.find('td:eq(2)').text();
            Swal.fire({
                title: tableType === 'DeletedTables' ? 'Silinen Ürün Alt Grubu Geri Getirilsin Mi??' : 'Silmek istediğinize emin misiniz?',
                text: `${outPaymentDetailFirsName} Adlı Ürün Alt Grubu Geri Getirilecektir!`,
                icon: 'warning',
                showCancelButton: true,
                confirmButtonColor: '#3085d6',
                cancelButtonColor: '#d33',
                confirmButtonText: 'Evet, geri getirmek istiyorum.',
                cancelButtonText: 'Hayır, geri getirmek istemiyorum.'
            }).then((result) => {
                if (result.isConfirmed) {
                    $.ajax({
                        type: 'POST',
                        dataType: 'json',
                        data: { Id: id },
                        url: '/Admin/outPaymentDetail/UndoDelete/',
                        success: function (data) {
                            const outPaymentDetailResult = jQuery.parseJSON(data);
                            if (outPaymentDetailResult.ResultStatus === 0) {
                                Swal.fire(
                                    'Geri Getirildi!',
                                    `${outPaymentDetailResult.Message}`,
                                    'success'
                                );
                                tableRow.fadeOut(2000, function () {
                                    dataTable.row($(this)).remove().draw();
                                });

                            } else {
                                Swal.fire({
                                    icon: 'error',
                                    title: 'Başarısız İşlem!',
                                    text: `${outPaymentDetailResult.Message}`,
                                });
                            }
                        },
                        error: function (err) {
                            console.log(err);
                            toastr.error(`${err.responseText}`, "Hata!");
                        }
                    });
                }
            });
        });
});