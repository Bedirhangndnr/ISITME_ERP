$(document).ready(function () {

    /* DataTables start here. */

    const dataTable = $('#productSubGroupsTable').DataTable({
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
                        url: '/Admin/ProductSubGroup/GetAllProductSubGroups/',
                        contentType: "application/json",
                        beforeSend: function () {
                            $('#productSubGroupsTable').hide();
                            $('.spinner-border').show();
                        },
                        success: function (data) {
                            const productSubGroupListDto = jQuery.parseJSON(data);
                            dataTable.clear();
                            console.log(productSubGroupListDto);
                            if (productSubGroupListDto.Data.ResultStatus === 0) {
                                $.each(productSubGroupListDto.Data.ProductSubGroups.$values,
                                    function (index, productSubGroup) {
                                        const newTableRow = dataTable.row.add([
                                            productSubGroup.Id,
                                            productSubGroup.Title,
                                            productSubGroup.Description,
                                            `
                                <button class="btn btn-primary btn-sm btn-update" data-id="${productSubGroup.Id}"><span class="fas fa-edit"></span></button>
                                <button class="btn btn-danger btn-sm btn-delete" data-id="${productSubGroup.Id}"><span class="fas fa-minus-circle"></span></button>
                                            `
                                        ]).node();
                                        const jqueryTableRow = $(newTableRow);
                                        jqueryTableRow.attr('name', `${productSubGroup.Id}`);
                                    });
                                dataTable.draw();
                                $('.spinner-border').hide();
                                $('#productSubGroupsTable').fadeIn(1400);
                            } else {
                                toastr.error(`${productSubGroupListDto.Data.Message}`, 'İşlem Başarısız!');
                            }
                        },
                        error: function (err) {
                            console.log(err);
                            $('.spinner-border').hide();
                            $('#productSubGroupsTable').fadeIn(1000);
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
            const productSubGroupTitle = tableRow.find('td:eq(2)').text(); // table datadan 2. indexdeki değeri aldık.
            Swal.fire({
                title: 'Silmek istediğinize emin misiniz?',
                text: `${productSubGroupTitle} başlıklı makale silinicektir!`,
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
                        data: { productSubGroupId: id },
                        url: '/Admin/ProductSubGroup/Delete/',
                        success: function (data) {
                            const productSubGroupResult = jQuery.parseJSON(data);
                            if (productSubGroupResult.ResultStatus === 0) {
                                Swal.fire(
                                    'Silindi!',
                                    `${productSubGroupResult.ProductSubGroup.Title}`,
                                    'success'
                                );

                                dataTable.row(tableRow).remove().draw();
                            } else {
                                Swal.fire({
                                    icon: 'error',
                                    title: 'Başarısız İşlem!',
                                    text: `${productSubGroupResult.Message}`,
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
        const url = '/Admin/ProductSubGroup/Add/';
        const placeHolderDiv = $('#modalPlaceHolder');
        $('#btnAdd').click(function () {
            $.get(url).done(function (data) {
                placeHolderDiv.html(data);
                placeHolderDiv.find(".modal").modal('show');
            });
        });

        /* Ajax GET / Getting the _ProductSubGroupAddPartial as Modal Form ends here. */

        /* Ajax POST / Posting the FormData as ProductSubGroupAddDto starts from here. */

        placeHolderDiv.on('click',
            '#btnSave',
            function (event) {
                event.preventDefault();
                const form = $('#form-productSubGroup-add');
                const actionUrl = form.attr('action');
                const dataToSend = form.serialize();
                $.post(actionUrl, dataToSend).done(function (data) {
                    console.log(data);
                    const ProductSubGroupAddAjaxModel = jQuery.parseJSON(data);
                    console.log(ProductSubGroupAddAjaxModel);
                    const newFormBody = $('.modal-body', ProductSubGroupAddAjaxModel.ProductSubGroupAddPartial);
                    placeHolderDiv.find('.modal-body').replaceWith(newFormBody);
                    const isValid = newFormBody.find('[name="IsValid"]').val() === 'True';
                    if (isValid) {
                        placeHolderDiv.find('.modal').modal('hide');
                        const newTableRow = dataTable.row.add([
                            ProductSubGroupAddAjaxModel.ProductSubGroupDto.ProductSubGroup.Id,
                            ProductSubGroupAddAjaxModel.ProductSubGroupDto.ProductSubGroup.Title,
                            ProductSubGroupAddAjaxModel.ProductSubGroupDto.ProductSubGroup.Description,
                            `
                                <button class="btn btn-primary btn-sm btn-update" data-id="${ProductSubGroupAddAjaxModel.ProductSubGroupDto.ProductSubGroup.Id}"><span class="fas fa-edit"></span></button>
                                <button class="btn btn-danger btn-sm btn-delete" data-id="${ProductSubGroupAddAjaxModel.ProductSubGroupDto.ProductSubGroup.Id}"><span class="fas fa-minus-circle"></span></button>
                                            `
                        ]).node();
                        const jqueryTableRow = $(newTableRow);
                        jqueryTableRow.attr('name', `${ProductSubGroupAddAjaxModel.ProductSubGroupDto.ProductSubGroup.Id}`);
                        dataTable.draw();
                        toastr.success(`${ProductSubGroupAddAjaxModel.ProductSubGroupDto.Message}`, 'Başarılı İşlem!');
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

    /* Ajax POST / Posting the FormData as ProductSubGroupAddDto ends here. */

    /* Ajax POST / Deleting a ProductSubGroup starts from here */

    /* Ajax GET / Getting the _productSubGroupUpdatePartial as Modal Form starts from here. */

    $(function () {
        const url = '/Admin/ProductSubGroup/Update/';
        const placeHolderDiv = $('#modalPlaceHolder');
        $(document).on('click',
            '.btn-update',
            function (event) {
                event.preventDefault();
                const id = $(this).attr('data-id');
                $.get(url, { ProductSubGroupId: id }).done(function (data) {
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

                const form = $('#form-productSubGroup-update');
                const actionUrl = form.attr('action');
                const dataToSend = form.serialize();
                $.post(actionUrl, dataToSend).done(function (data) {
                    const productSubGroupTypeUpdateAjaxViewModel = jQuery.parseJSON(data);
                    console.log(productSubGroupTypeUpdateAjaxViewModel);
                    const newFormBody = $('.modal-body', productSubGroupTypeUpdateAjaxViewModel.productSubGroupUpdatePartial);
                    placeHolderDiv.find('.modal-body').replaceWith(newFormBody);
                    const isValid = newFormBody.find('[name="IsValid"]').val() === 'True';
                    if (isValid) {
                        const productSubGroup = productSubGroupTypeUpdateAjaxViewModel.ProductSubGroupDto.ProductSubGroup
                        const id = productSubGroup.Id;
                        const tableRow = $(`[name="${id}"]`);
                        placeHolderDiv.find('.modal').modal('hide');
                        dataTable.row(tableRow).data([
                            productSubGroup.Id,
                            productSubGroup.Title,
                            productSubGroup.Description,
                            `
                                       <button class="btn btn-primary btn-sm btn-update" data-id="${productSubGroup.Id}"><span class="fas fa-edit"></span></button>
                                <button class="btn btn-danger btn-sm btn-delete" data-id="${productSubGroup.Id}"><span class="fas fa-minus-circle"></span></button>
                                            `
                        ]);
                        tableRow.attr("name", `${id}`);
                        dataTable.row(tableRow).invalidate();
                        toastr.success(`${productSubGroupTypeUpdateAjaxViewModel.ProductSubGroupDto.Message}`, "Başarılı İşlem!");
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