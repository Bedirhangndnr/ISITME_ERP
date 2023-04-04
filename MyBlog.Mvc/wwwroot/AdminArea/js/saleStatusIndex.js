$(document).ready(function () {

    /* DataTables start here. */

    const dataTable = $('#saleStatusesTable').DataTable({
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

                }
            },
            {
                text: 'Yenile',
                className: 'btn btn-warning',
                action: function (e, dt, node, config) {
                    $.ajax({
                        type: 'GET',
                        url: '/Admin/SaleStatus/GetAllSaleStatuses/',
                        contentType: "application/json",
                        beforeSend: function () {
                            $('#saleStatusesTable').hide();
                            $('.spinner-border').show();
                        },
                        success: function (data) {
                            const saleStatusListDto = jQuery.parseJSON(data);
                            dataTable.clear();
                            console.log(saleStatusListDto);
                            if (saleStatusListDto.Data.ResultStatus === 0) {
                                $.each(saleStatusListDto.Data.SaleStatuses.$values,
                                    function (index, saleStatus) {
                                        const newTableRow = dataTable.row.add([
                                            saleStatus.Id,
                                            saleStatus.Title,
                                            saleStatus.Description,
                                            `
                                <button class="btn btn-primary btn-sm btn-update" data-id="${saleStatus.Id}"><span class="fas fa-edit"></span></button>
                                <button class="btn btn-danger btn-sm btn-delete" data-id="${saleStatus.Id}"><span class="fas fa-minus-circle"></span></button>
                                            `
                                        ]).node();
                                        const jqueryTableRow = $(newTableRow);
                                        jqueryTableRow.attr('name', `${saleStatus.Id}`);
                                    });
                                dataTable.draw();
                                $('.spinner-border').hide();
                                $('#saleStatusesTable').fadeIn(1400);
                            } else {
                                toastr.error(`${saleStatusListDto.Data.Message}`, 'İşlem Başarısız!');
                            }
                        },
                        error: function (err) {
                            console.log(err);
                            $('.spinner-border').hide();
                            $('#saleStatusesTable').fadeIn(1000);
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

    /* DataTables end here */

    /* Ajax POST / Deleting a User starts from here */

    $(document).on('click',
        '.btn-delete',
        function (event) {
            event.preventDefault();
            const id = $(this).attr('data-id');
            const tableRow = $(`[name="${id}"]`);
            const saleStatusTitle = tableRow.find('td:eq(2)').text(); // table datadan 2. indexdeki değeri aldık.
            Swal.fire({
                title: 'Silmek istediğinize emin misiniz?',
                text: `${saleStatusTitle} başlıklı makale silinicektir!`,
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
                        data: { saleStatusId: id },
                        url: '/Admin/SaleStatus/Delete/',
                        success: function (data) {
                            const saleStatusResult = jQuery.parseJSON(data);
                            if (saleStatusResult.ResultStatus === 0) {
                                Swal.fire(
                                    'Silindi!',
                                    `${saleStatusResult.SaleStatus.Title}`,
                                    'success'
                                );

                                dataTable.row(tableRow).remove().draw();
                            } else {
                                Swal.fire({
                                    icon: 'error',
                                    title: 'Başarısız İşlem!',
                                    text: `${saleStatusResult.Message}`,
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
        const url = '/Admin/SaleStatus/Add/';
        const placeHolderDiv = $('#modalPlaceHolder');
        $('#btnAdd').click(function () {
            $.get(url).done(function (data) {
                placeHolderDiv.html(data);
                placeHolderDiv.find(".modal").modal('show');
            });
        });

        /* Ajax GET / Getting the _SaleStatusAddPartial as Modal Form ends here. */

        /* Ajax POST / Posting the FormData as SaleStatusAddDto starts from here. */

        placeHolderDiv.on('click',
            '#btnSave',
            function (event) {
                event.preventDefault();
                const form = $('#form-saleStatus-add');
                const actionUrl = form.attr('action');
                const dataToSend = form.serialize();
                $.post(actionUrl, dataToSend).done(function (data) {
                    console.log(data);
                    const SaleStatusAddAjaxModel = jQuery.parseJSON(data);
                    console.log(SaleStatusAddAjaxModel);
                    const newFormBody = $('.modal-body', SaleStatusAddAjaxModel.SaleStatusAddPartial);
                    placeHolderDiv.find('.modal-body').replaceWith(newFormBody);
                    const isValid = newFormBody.find('[name="IsValid"]').val() === 'True';
                    if (isValid) {
                        placeHolderDiv.find('.modal').modal('hide');
                        const newTableRow = dataTable.row.add([
                            SaleStatusAddAjaxModel.SaleStatusDto.SaleStatus.Id,
                            SaleStatusAddAjaxModel.SaleStatusDto.SaleStatus.Title,
                            SaleStatusAddAjaxModel.SaleStatusDto.SaleStatus.Description,
                            `
                                <button class="btn btn-primary btn-sm btn-update" data-id="${SaleStatusAddAjaxModel.SaleStatusDto.SaleStatus.Id}"><span class="fas fa-edit"></span></button>
                                <button class="btn btn-danger btn-sm btn-delete" data-id="${SaleStatusAddAjaxModel.SaleStatusDto.SaleStatus.Id}"><span class="fas fa-minus-circle"></span></button>
                                            `
                        ]).node();
                        const jqueryTableRow = $(newTableRow);
                        jqueryTableRow.attr('name', `${SaleStatusAddAjaxModel.SaleStatusDto.SaleStatus.Id}`);
                        dataTable.draw();
                        toastr.success(`${SaleStatusAddAjaxModel.SaleStatusDto.Message}`, 'Başarılı İşlem!');
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

    /* Ajax POST / Posting the FormData as SaleStatusAddDto ends here. */

    /* Ajax POST / Deleting a SaleStatus starts from here */

    /* Ajax GET / Getting the _saleStatusUpdatePartial as Modal Form starts from here. */

    $(function () {
        const url = '/Admin/SaleStatus/Update/';
        const placeHolderDiv = $('#modalPlaceHolder');
        $(document).on('click',
            '.btn-update',
            function (event) {
                event.preventDefault();
                const id = $(this).attr('data-id');
                $.get(url, { SaleStatusId: id }).done(function (data) {
                    placeHolderDiv.html(data);
                    placeHolderDiv.find('.modal').modal('show');
                }).fail(function () {
                    toastr.error("Bir hata oluştu.");
                });
            });

        /* Ajax POST / Updating a Customer starts from here */

        placeHolderDiv.on('click',
            '#btnUpdate',
            function (event) {
                event.preventDefault();

                const form = $('#form-saleStatus-update');
                const actionUrl = form.attr('action');
                const dataToSend = form.serialize();
                $.post(actionUrl, dataToSend).done(function (data) {
                    const saleStatusTypeUpdateAjaxViewModel = jQuery.parseJSON(data);
                    console.log(saleStatusTypeUpdateAjaxViewModel);
                    const newFormBody = $('.modal-body', saleStatusTypeUpdateAjaxViewModel.saleStatusUpdatePartial);
                    placeHolderDiv.find('.modal-body').replaceWith(newFormBody);
                    const isValid = newFormBody.find('[name="IsValid"]').val() === 'True';
                    if (isValid) {
                        const saleStatus = saleStatusTypeUpdateAjaxViewModel.SaleStatusDto.SaleStatus
                        const id = saleStatus.Id;
                        const tableRow = $(`[name="${id}"]`);
                        placeHolderDiv.find('.modal').modal('hide');
                        dataTable.row(tableRow).data([
                            saleStatus.Id,
                            saleStatus.Title,
                            saleStatus.Description,
                            `
                                       <button class="btn btn-primary btn-sm btn-update" data-id="${saleStatus.Id}"><span class="fas fa-edit"></span></button>
                                <button class="btn btn-danger btn-sm btn-delete" data-id="${saleStatus.Id}"><span class="fas fa-minus-circle"></span></button>
                                            `
                        ]);
                        tableRow.attr("name", `${id}`);
                        dataTable.row(tableRow).invalidate();
                        toastr.success(`${saleStatusTypeUpdateAjaxViewModel.SaleStatusDto.Message}`, "Başarılı İşlem!");
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

});