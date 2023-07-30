$(document).ready(function () {

    const tableType = document.getElementById("tableType").value;
    /* DataTables start here. */

    const dataTable = $('#customerReferancesTable').DataTable({
        dom:
            "<'row'<'col-sm-3'l><'col-sm-6 text-center'B><'col-sm-3'f>>" +
            "<'row'<'col-sm-12'tr>>" +
            "<'row'<'col-sm-5'i><'col-sm-7'p>>",
        "order": [[6, "desc"]],
        buttons: [
            {
                text: 'Ekle',
                attr: {
                    id: "btnAdd",
                },
                className: 'btn btn-success',
                action: function (e, dt, node, config) {
                }
            },
            {
                text: 'Yenile',
                className: 'btn btn-warning',
                action: function (e, dt, node, config) {
                    $.ajax({
                        type: 'GET',
                        data: { tableType: tableType },
                        url: '/Admin/CustomerReferance/GetAllCustomerReferances/',
                        contentType: "application/json",
                        beforeSend: function () {
                            $('#customerReferancesTable').hide();
                            $('.spinner-border').show();
                        },
                        success: function (data) {
                            const CustomerReferanceListDto = jQuery.parseJSON(data);
                            dataTable.clear();
                            console.log(CustomerReferanceListDto);
                            if (CustomerReferanceListDto.Data.ResultStatus === 0) {
                                $.each(CustomerReferanceListDto.Data.CustomerReferances.$values,
                                    function (index, customerReferance) {
                                        const newTableRow = dataTable.row.add([
                                            customerReferance.Id,
                                            customerReferance.FirstName,
                                            customerReferance.LastName,
                                            customerReferance.Phone,
                                            customerReferance.Description,
                                            customerReferance.Note,
                                            `
                                                <div class="form-group row justify-content-center">
                                                ${tableType === 'NonDeletedTables' ? '<button title="Güncelle" class="btn btn-primary btn-sm btn-update" data-id=' + customerReferance.Id + '><span class="fas fa-edit"></span></button>' : ''}
                                                <button title="Sil" class="btn btn-danger btn-sm btn-delete" data-id=${customerReferance.Id} data-tableType=${tableType}><span class="fas fa-minus-circle"></span></button>
                                                ${tableType === 'DeletedTables' ? '<a class="btn btn-warning btn-sm btn-undo" data-id="' + customerReferance.Id + '"><span class="fas fa-undo"></span></a>' : ''}
                                                </div>
                                                    `
                                        ]).node();
                                        const jqueryTableRow = $(newTableRow);
                                        jqueryTableRow.attr('name', `${customerReferance.Id}`);
                                    });
                                dataTable.draw();
                                $('.spinner-border').hide();
                                $('#customerReferancesTable').fadeIn(1400);
                            } else {
                                $('.spinner-border').hide();
                                $('#customerReferancesTable').fadeIn(1000);
                                toastr.error(`${customerReferanceListDto.Data.Message}`, 'İşlem Başarısız!');
                            }
                        },
                        error: function (err) {
                            console.log(err);
                            $('.spinner-border').hide();
                            $('#customerReferancesTable').fadeIn(1000);
                            toastr.error(`${err.responseText}`, 'Hata!');
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

    /* DataTables end here */

    /* Ajax GET / Getting the _CustomerReferanceAddPartial as Modal Form starts from here. */

    $(function () {
        const url = '/Admin/CustomerReferance/Add/';
        const placeHolderDiv = $('#modalPlaceHolder');
        $('#btnAdd').click(function () {
            $.get(url).done(function (data) {
                placeHolderDiv.html(data);
                placeHolderDiv.find(".modal").modal('show');
            });
        });

        /* Ajax GET / Getting the _CustomerReferanceAddPartial as Modal Form ends here. */

        /* Ajax POST / Posting the FormData as CustomerReferanceAddDto starts from here. */

        placeHolderDiv.on('click',
            '#btnSave',
            function (event) {
                event.preventDefault();
                const form = $('#form-customerReferance-add');
                const actionUrl = form.attr('action');
                const dataToSend = form.serialize();
                $.post(actionUrl, dataToSend).done(function (data) {
                    console.log(data);
                    const CustomerReferanceAddAjaxModel = jQuery.parseJSON(data);
                    console.log(CustomerReferanceAddAjaxModel);
                    const newFormBody = $('.modal-body', CustomerReferanceAddAjaxModel.CustomerReferanceAddPartial);
                    placeHolderDiv.find('.modal-body').replaceWith(newFormBody);
                    const isValid = newFormBody.find('[name="IsValid"]').val() === 'True';
                    if (isValid) {
                        placeHolderDiv.find('.modal').modal('hide');
                        customerReferance = CustomerReferanceAddAjaxModel.CustomerReferanceDto.CustomerReferance;
                        const newTableRow = dataTable.row.add([
                            customerReferance.Id,
                            customerReferance.FirstName,
                            customerReferance.LastName,
                            customerReferance.Phone,
                            customerReferance.Description,
                            customerReferance.Note,
                            `
                                                <div class="form-group row justify-content-center">
                                                ${tableType === 'NonDeletedTables' ? '<button title="Güncelle" class="btn btn-primary btn-sm btn-update" data-id=' + customerReferance.Id + '><span class="fas fa-edit"></span></button>' : ''}
                                                <button title="Sil" class="btn btn-danger btn-sm btn-delete" data-id=${customerReferance.Id} data-tableType=${tableType}><span class="fas fa-minus-circle"></span></button>
                                                ${tableType === 'DeletedTables' ? '<a class="btn btn-warning btn-sm btn-undo" data-id="' + customerReferance.Id + '"><span class="fas fa-undo"></span></a>' : ''}
                                                </div>
                                                    `
                        ]).node();
                        const jqueryTableRow = $(newTableRow);
                        jqueryTableRow.attr('name', `${customerReferance.Id}`);
                        dataTable.draw();
                        toastr.success(`${CustomerReferanceAddAjaxModel.CustomerReferanceDto.Message}`, 'Başarılı İşlem!');
                    } else {
                        let summaryText = "";
                        $('#validation-summary > ul > li').each(function () {
                            let text = $(this).text();
                            summaryText = `*${text}\n`;
                        });
                        toastr.warning(summaryText);
                    }
                });
            });
    });

    /* Ajax POST / Posting the FormData as CustomerReferanceAddDto ends here. */

    /* Ajax POST / Deleting a CustomerReferance starts from here */

    $(document).on('click',
        '.btn-delete',
        function (event) {
            event.preventDefault();
            const id = $(this).attr('data-id');
            const tableType = $(this).attr('data-tableType');
            const tableRow = $(`[name="${id}"]`);
            const customerReferanceName = tableRow.find('td:eq(1)').text();
            Swal.fire({
                title: tableType === 'DeletedTables' ? 'Kalıcı olarak silmek istediğinize emin misiniz?' : 'Silmek istediğinize emin misiniz?',
                text: `${customerReferanceName} Başlıklı Marka ${tableType === 'DeletedTables' ? 'kalıcı olarak ' : ''} Silinecektir!`,
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
                        data: { customerReferanceId: id, tableType: tableType },
                        url: '/Admin/CustomerReferance/Delete/',
                        success: function (data) {
                            const customerReferanceResult = jQuery.parseJSON(data);
                            if (customerReferanceResult.ResultStatus === 0) {
                                if (tableType === 'DeletedTables') {
                                    Swal.fire(
                                        'Tamamen Silindi!',
                                        `${customerReferanceResult.Message}`,
                                        'success'
                                    );
                                }
                                else {
                                    Swal.fire(
                                        'Silindi!',
                                        `${customerReferanceResult.Message}`,
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
                                    text: `${customerReferanceResult.Message}`,
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

    /* Ajax GET / Getting the _CustomerReferanceUpdatePartial as Modal Form starts from here. */

    $(function () {
        const url = '/Admin/CustomerReferance/Update/';
        const placeHolderDiv = $('#modalPlaceHolder');
        $(document).on('click',
            '.btn-update',
            function (event) {
                event.preventDefault();
                const tableType = document.getElementById("tableType").value;
                const id = $(this).attr('data-id');
                $.get(url, { Id: id, tableType: tableType }).done(function (data) {
                    placeHolderDiv.html(data);
                    placeHolderDiv.find('.modal').modal('show');
                }).fail(function () {
                    toastr.error("Bir hata oluştu.");
                });
            });

        /* Ajax POST / Updating a CustomerReferance starts from here */

        placeHolderDiv.on('click',
            '#btnUpdate',
            function (event) {
                event.preventDefault();

                const form = $('#form-CustomerReferance-update');
                const actionUrl = form.attr('action');
                const dataToSend = `${form.serialize()}&tableType=${tableType}`;
                $.post(actionUrl, dataToSend).done(function (data) {
                    const CustomerReferanceUpdateAjaxModel = jQuery.parseJSON(data);
                    console.log(CustomerReferanceUpdateAjaxModel);
                    const newFormBody = $('.modal-body', CustomerReferanceUpdateAjaxModel.CustomerReferanceUpdatePartial);
                    placeHolderDiv.find('.modal-body').replaceWith(newFormBody);
                    const isValid = newFormBody.find('[name="IsValid"]').val() === 'True';
                    if (isValid) {
                        const customerReferance = CustomerReferanceUpdateAjaxModel.CustomerReferanceDto.CustomerReferance
                        const id = customerReferance.Id;
                        const tableRow = $(`[name="${id}"]`);
                        placeHolderDiv.find('.modal').modal('hide');
                        dataTable.row(tableRow).data([
                            customerReferance.Id,
                            customerReferance.FirstName,
                            customerReferance.LastName,
                            customerReferance.Phone,
                            customerReferance.Description == null ? "Not Eklenmemiş" : (customerReferance.Description.length > 75 ? customerReferance.Description.substring(0, 75) : customerReferance.Description),
                            customerReferance.Note == null ? "Not Eklenmemiş" : (customerReferance.Note.length > 75 ? customerReferance.Note.substring(0, 75) : customerReferance.Note),
                            `
                                                <div class="form-group row justify-content-center">
                                                ${tableType === 'NonDeletedTables' ? '<button title="Güncelle" class="btn btn-primary btn-sm btn-update" data-id=' + customerReferance.Id + '><span class="fas fa-edit"></span></button>' : ''}
                                                <button title="Sil" class="btn btn-danger btn-sm btn-delete" data-id=${customerReferance.Id} data-tableType=${tableType}><span class="fas fa-minus-circle"></span></button>
                                                ${tableType === 'DeletedTables' ? '<a class="btn btn-warning btn-sm btn-undo" data-id="' + customerReferance.Id + '"><span class="fas fa-undo"></span></a>' : ''}
                                                </div>
                                                    `

                        ]);
                        tableRow.attr("name", `${id}`);
                        dataTable.row(tableRow).invalidate();
                        toastr.success(`${CustomerReferanceUpdateAjaxModel.CustomerReferanceDto.Message}`, "Başarılı İşlem!");
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
        '.btn-undo',
        function (event) {
            event.preventDefault();
            const id = $(this).attr('data-id');
            const tableRow = $(`[name="${id}"]`);
            const customerReferanceFirsName = tableRow.find('td:eq(1)').text();
            const customerReferanceLastName = tableRow.find('td:eq(2)').text();
            Swal.fire({
                title: tableType === 'DeletedTables' ? 'Silinen Marka Geri Getirilsin Mi??' : 'Silmek istediğinize emin misiniz?',
                text: `${customerReferanceFirsName} Adlı Marka Geri Getirilecektir!`,
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
                        data: { customerReferanceId: id },
                        url: '/Admin/customerReferance/UndoDelete/',
                        success: function (data) {
                            const customerReferanceResult = jQuery.parseJSON(data);
                            if (customerReferanceResult.ResultStatus === 0) {
                                Swal.fire(
                                    'Geri Getirildi!',
                                    `${customerReferanceResult.Message}`,
                                    'success'
                                );
                                tableRow.fadeOut(2000, function () {
                                    dataTable.row($(this)).remove().draw();
                                });

                            } else {
                                Swal.fire({
                                    icon: 'error',
                                    title: 'Başarısız İşlem!',
                                    text: `${customerReferanceResult.Message}`,
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