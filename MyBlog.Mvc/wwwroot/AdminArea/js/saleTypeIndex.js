$(document).ready(function () {

    /* DataTables start here. */

    const dataTable = $('#saleTypesTable').DataTable({
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
                        url: '/Admin/SaleType/GetAllSaleTypes/',
                        contentType: "application/json",
                        beforeSend: function () {
                            $('#saleTypesTable').hide();
                            $('.spinner-border').show();
                        },
                        success: function (data) {
                            const saleTypeListDto = jQuery.parseJSON(data);
                            dataTable.clear();
                            console.log(saleTypeListDto);
                            if (saleTypeListDto.Data.ResultStatus === 0) {
                                $.each(saleTypeListDto.Data.SaleTypes.$values,
                                    function (index, saleType) {
                                        const newTableRow = dataTable.row.add([
                                            saleType.Id,
                                            saleType.Title,
                                            saleType.Description,
                                            `
                                <button class="btn btn-primary btn-sm btn-update" data-id="${saleType.Id}"><span class="fas fa-edit"></span></button>
                                <button class="btn btn-danger btn-sm btn-delete" data-id="${saleType.Id}"><span class="fas fa-minus-circle"></span></button>
                                            `
                                        ]).node();
                                        const jqueryTableRow = $(newTableRow);
                                        jqueryTableRow.attr('name', `${saleType.Id}`);
                                    });
                                dataTable.draw();
                                $('.spinner-border').hide();
                                $('#saleTypesTable').fadeIn(1400);
                            } else {
                                toastr.error(`${saleTypeListDto.Data.Message}`, 'İşlem Başarısız!');
                            }
                        },
                        error: function (err) {
                            console.log(err);
                            $('.spinner-border').hide();
                            $('#saleTypesTable').fadeIn(1000);
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
            const saleTypeTitle = tableRow.find('td:eq(2)').text(); // table datadan 2. indexdeki değeri aldık.
            Swal.fire({
                title: 'Silmek istediğinize emin misiniz?',
                text: `${saleTypeTitle} başlıklı makale silinicektir!`,
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
                        data: { saleTypeId: id },
                        url: '/Admin/SaleType/Delete/',
                        success: function (data) {
                            const saleTypeResult = jQuery.parseJSON(data);
                            if (saleTypeResult.ResultStatus === 0) {
                                Swal.fire(
                                    'Silindi!',
                                    `${saleTypeResult.SaleType.Title}`,
                                    'success'
                                );

                                dataTable.row(tableRow).remove().draw();
                            } else {
                                Swal.fire({
                                    icon: 'error',
                                    title: 'Başarısız İşlem!',
                                    text: `${saleTypeResult.Message}`,
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
        const url = '/Admin/SaleType/Add/';
        const placeHolderDiv = $('#modalPlaceHolder');
        $('#btnAdd').click(function () {
            $.get(url).done(function (data) {
                placeHolderDiv.html(data);
                placeHolderDiv.find(".modal").modal('show');
            });
        });

        /* Ajax GET / Getting the _SaleTypeAddPartial as Modal Form ends here. */

        /* Ajax POST / Posting the FormData as SaleTypeAddDto starts from here. */

        placeHolderDiv.on('click',
            '#btnSave',
            function (event) {
                event.preventDefault();
                const form = $('#form-saleType-add');
                const actionUrl = form.attr('action');
                const dataToSend = form.serialize();
                $.post(actionUrl, dataToSend).done(function (data) {
                    console.log(data);
                    const SaleTypeAddAjaxModel = jQuery.parseJSON(data);
                    console.log(SaleTypeAddAjaxModel);
                    const newFormBody = $('.modal-body', SaleTypeAddAjaxModel.SaleTypeAddPartial);
                    placeHolderDiv.find('.modal-body').replaceWith(newFormBody);
                    const isValid = newFormBody.find('[name="IsValid"]').val() === 'True';
                    if (isValid) {
                        placeHolderDiv.find('.modal').modal('hide');
                        const newTableRow = dataTable.row.add([
                            SaleTypeAddAjaxModel.SaleTypeDto.SaleType.Id,
                            SaleTypeAddAjaxModel.SaleTypeDto.SaleType.Title,
                            SaleTypeAddAjaxModel.SaleTypeDto.SaleType.Description,
                            `
                            <div style="text-align:center">
                                <button class="btn btn-primary btn-sm btn-update" data-id="${SaleTypeAddAjaxModel.SaleTypeDto.SaleType.Id}"><span class="fas fa-edit"></span></button>
                                <button class="btn btn-danger btn-sm btn-delete" data-id="${SaleTypeAddAjaxModel.SaleTypeDto.SaleType.Id}"><span class="fas fa-minus-circle"></span></button>
                                           </div> `
                        ]).node();
                        const jqueryTableRow = $(newTableRow);
                        jqueryTableRow.attr('name', `${SaleTypeAddAjaxModel.SaleTypeDto.SaleType.Id}`);
                        dataTable.draw();
                        toastr.success(`${SaleTypeAddAjaxModel.SaleTypeDto.Message}`, 'Başarılı İşlem!');
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

    /* Ajax POST / Posting the FormData as SaleTypeAddDto ends here. */

    /* Ajax POST / Deleting a SaleType starts from here */

    /* Ajax GET / Getting the _saleTypeUpdatePartial as Modal Form starts from here. */

    $(function () {
        const url = '/Admin/SaleType/Update/';
        const placeHolderDiv = $('#modalPlaceHolder');
        $(document).on('click',
            '.btn-update',
            function (event) {
                event.preventDefault();
                const id = $(this).attr('data-id');
                $.get(url, { SaleTypeId: id }).done(function (data) {
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

                const form = $('#form-saleType-update');
                const actionUrl = form.attr('action');
                const dataToSend = form.serialize();
                $.post(actionUrl, dataToSend).done(function (data) {
                    const saleTypeTypeUpdateAjaxViewModel = jQuery.parseJSON(data);
                    console.log(saleTypeTypeUpdateAjaxViewModel);
                    const newFormBody = $('.modal-body', saleTypeTypeUpdateAjaxViewModel.saleTypeUpdatePartial);
                    placeHolderDiv.find('.modal-body').replaceWith(newFormBody);
                    const isValid = newFormBody.find('[name="IsValid"]').val() === 'True';
                    if (isValid) {
                        const saleType = saleTypeTypeUpdateAjaxViewModel.SaleTypeDto.SaleType
                        const id = saleType.Id;
                        const tableRow = $(`[name="${id}"]`);
                        placeHolderDiv.find('.modal').modal('hide');
                        dataTable.row(tableRow).data([
                            saleType.Id,
                            saleType.Title,
                            saleType.Description,
                            `
                                       <button class="btn btn-primary btn-sm btn-update" data-id="${saleType.Id}"><span class="fas fa-edit"></span></button>
                                <button class="btn btn-danger btn-sm btn-delete" data-id="${saleType.Id}"><span class="fas fa-minus-circle"></span></button>
                                            `
                        ]);
                        tableRow.attr("name", `${id}`);
                        dataTable.row(tableRow).invalidate();
                        toastr.success(`${saleTypeTypeUpdateAjaxViewModel.SaleTypeDto.Message}`, "Başarılı İşlem!");
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