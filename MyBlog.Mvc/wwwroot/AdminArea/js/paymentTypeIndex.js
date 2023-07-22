$(document).ready(function () {

    /* DataTables start here. */

    const dataTable = $('#paymentTypesTable').DataTable({
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
                        url: '/Admin/PaymentType/GetAllPaymentTypes/',
                        contentType: "application/json",
                        beforeSend: function () {
                            $('#paymentTypesTable').hide();
                            $('.spinner-border').show();
                        },
                        success: function (data) {
                            const paymentTypeListDto = jQuery.parseJSON(data);
                            dataTable.clear();
                            console.log(paymentTypeListDto);
                            if (paymentTypeListDto.Data.ResultStatus === 0) {
                                $.each(paymentTypeListDto.Data.PaymentTypes.$values,
                                    function (index, paymentType) {
                                        const newTableRow = dataTable.row.add([
                                            paymentType.Id,
                                            paymentType.Title,
                                            `
                                <button class="btn btn-primary btn-sm btn-update" data-id="${paymentType.Id}"><span class="fas fa-edit"></span></button>
                                <button class="btn btn-danger btn-sm btn-delete" data-id="${paymentType.Id}"><span class="fas fa-minus-circle"></span></button>
                                            `
                                        ]).node();
                                        const jqueryTableRow = $(newTableRow);
                                        jqueryTableRow.attr('name', `${paymentType.Id}`);
                                    });
                                dataTable.draw();
                                $('.spinner-border').hide();
                                $('#paymentTypesTable').fadeIn(1400);
                            } else {
                                toastr.error(`${paymentTypeListDto.Data.Message}`, 'İşlem Başarısız!');
                            }
                        },
                        error: function (err) {
                            console.log(err);
                            $('.spinner-border').hide();
                            $('#paymentTypesTable').fadeIn(1000);
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
            const paymentTypeTitle = tableRow.find('td:eq(2)').text(); // table datadan 2. indexdeki değeri aldık.
            Swal.fire({
                title: 'Silmek istediğinize emin misiniz?',
                text: `${paymentTypeTitle} başlıklı makale silinicektir!`,
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
                        data: { paymentTypeId: id },
                        url: '/Admin/PaymentType/Delete/',
                        success: function (data) {
                            const paymentTypeResult = jQuery.parseJSON(data);
                            if (paymentTypeResult.ResultStatus === 0) {
                                Swal.fire(
                                    'Silindi!',
                                    `${paymentTypeResult.PaymentType.Title}`,
                                    'success'
                                );

                                dataTable.row(tableRow).remove().draw();
                            } else {
                                Swal.fire({
                                    icon: 'error',
                                    title: 'Başarısız İşlem!',
                                    text: `${paymentTypeResult.Message}`,
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
        const url = '/Admin/PaymentType/Add/';
        const placeHolderDiv = $('#modalPlaceHolder');
        $('#btnAdd').click(function () {
            $.get(url).done(function (data) {
                placeHolderDiv.html(data);
                placeHolderDiv.find(".modal").modal('show');
            });
        });

        /* Ajax GET / Getting the _PaymentTypeAddPartial as Modal Form ends here. */

        /* Ajax POST / Posting the FormData as PaymentTypeAddDto starts from here. */

        placeHolderDiv.on('click',
            '#btnSave',
            function (event) {
                event.preventDefault();
                const form = $('#form-paymentType-add');
                const actionUrl = form.attr('action');
                const dataToSend = form.serialize();
                $.post(actionUrl, dataToSend).done(function (data) {
                    console.log(data);
                    const PaymentTypeAddAjaxModel = jQuery.parseJSON(data);
                    console.log(PaymentTypeAddAjaxModel);
                    const newFormBody = $('.modal-body', PaymentTypeAddAjaxModel.PaymentTypeAddPartial);
                    placeHolderDiv.find('.modal-body').replaceWith(newFormBody);
                    const isValid = newFormBody.find('[name="IsValid"]').val() === 'True';
                    if (isValid) {
                        placeHolderDiv.find('.modal').modal('hide');
                        const newTableRow = dataTable.row.add([
                            PaymentTypeAddAjaxModel.PaymentTypeDto.PaymentType.Id,
                            PaymentTypeAddAjaxModel.PaymentTypeDto.PaymentType.Title,
                            `
                            <div style="text-align:center">
                                <button class="btn btn-primary btn-sm btn-update" data-id="${PaymentTypeAddAjaxModel.PaymentTypeDto.PaymentType.Id}"><span class="fas fa-edit"></span></button>
                                <button class="btn btn-danger btn-sm btn-delete" data-id="${PaymentTypeAddAjaxModel.PaymentTypeDto.PaymentType.Id}"><span class="fas fa-minus-circle"></span></button>
                                   </div>         `
                        ]).node();
                        const jqueryTableRow = $(newTableRow);
                        jqueryTableRow.attr('name', `${PaymentTypeAddAjaxModel.PaymentTypeDto.PaymentType.Id}`);
                        dataTable.draw();
                        toastr.success(`${PaymentTypeAddAjaxModel.PaymentTypeDto.Message}`, 'Başarılı İşlem!');
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

    /* Ajax POST / Posting the FormData as PaymentTypeAddDto ends here. */

    /* Ajax POST / Deleting a PaymentType starts from here */

    /* Ajax GET / Getting the _paymentTypeUpdatePartial as Modal Form starts from here. */

    $(function () {
        const url = '/Admin/PaymentType/Update/';
        const placeHolderDiv = $('#modalPlaceHolder');
        $(document).on('click',
            '.btn-update',
            function (event) {
                event.preventDefault();
                const id = $(this).attr('data-id');
                $.get(url, { PaymentTypeId: id }).done(function (data) {
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

                const form = $('#form-paymentType-update');
                const actionUrl = form.attr('action');
                const dataToSend = form.serialize();
                $.post(actionUrl, dataToSend).done(function (data) {
                    const paymentTypeTypeUpdateAjaxViewModel = jQuery.parseJSON(data);
                    console.log(paymentTypeTypeUpdateAjaxViewModel);
                    const newFormBody = $('.modal-body', paymentTypeTypeUpdateAjaxViewModel.paymentTypeUpdatePartial);
                    placeHolderDiv.find('.modal-body').replaceWith(newFormBody);
                    const isValid = newFormBody.find('[name="IsValid"]').val() === 'True';
                    if (isValid) {
                        const paymentType = paymentTypeTypeUpdateAjaxViewModel.PaymentTypeDto.PaymentType
                        const id = paymentType.Id;
                        const tableRow = $(`[name="${id}"]`);
                        placeHolderDiv.find('.modal').modal('hide');
                        dataTable.row(tableRow).data([
                            paymentType.Id,
                            paymentType.Title,
                            `
                                       <button class="btn btn-primary btn-sm btn-update" data-id="${paymentType.Id}"><span class="fas fa-edit"></span></button>
                                <button class="btn btn-danger btn-sm btn-delete" data-id="${paymentType.Id}"><span class="fas fa-minus-circle"></span></button>
                                            `
                        ]);
                        tableRow.attr("name", `${id}`);
                        dataTable.row(tableRow).invalidate();
                        toastr.success(`${paymentTypeTypeUpdateAjaxViewModel.PaymentTypeDto.Message}`, "Başarılı İşlem!");
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