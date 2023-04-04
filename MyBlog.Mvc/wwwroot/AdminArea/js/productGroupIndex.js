$(document).ready(function () {

    /* DataTables start here. */

    const dataTable = $('#productGroupsTable').DataTable({
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
                        url: '/Admin/ProductGroup/GetAllProductGroups/',
                        contentType: "application/json",
                        beforeSend: function () {
                            $('#productGroupsTable').hide();
                            $('.spinner-border').show();
                        },
                        success: function (data) {
                            const productGroupListDto = jQuery.parseJSON(data);
                            dataTable.clear();
                            console.log(productGroupListDto);
                            if (productGroupListDto.Data.ResultStatus === 0) {
                                $.each(productGroupListDto.Data.ProductGroups.$values,
                                    function (index, productGroup) {
                                        const newTableRow = dataTable.row.add([
                                            productGroup.Id,
                                            productGroup.Title,
                                            productGroup.Description,
                                            `
                                <button class="btn btn-primary btn-sm btn-update" data-id="${productGroup.Id}"><span class="fas fa-edit"></span></button>
                                <button class="btn btn-danger btn-sm btn-delete" data-id="${productGroup.Id}"><span class="fas fa-minus-circle"></span></button>
                                            `
                                        ]).node();
                                        const jqueryTableRow = $(newTableRow);
                                        jqueryTableRow.attr('name', `${productGroup.Id}`);
                                    });
                                dataTable.draw();
                                $('.spinner-border').hide();
                                $('#productGroupsTable').fadeIn(1400);
                            } else {
                                toastr.error(`${productGroupListDto.Data.Message}`, 'İşlem Başarısız!');
                            }
                        },
                        error: function (err) {
                            console.log(err);
                            $('.spinner-border').hide();
                            $('#productGroupsTable').fadeIn(1000);
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
            const productGroupTitle = tableRow.find('td:eq(2)').text(); // table datadan 2. indexdeki değeri aldık.
            Swal.fire({
                title: 'Silmek istediğinize emin misiniz?',
                text: `${productGroupTitle} başlıklı makale silinicektir!`,
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
                        data: { productGroupId: id },
                        url: '/Admin/ProductGroup/Delete/',
                        success: function (data) {
                            const productGroupResult = jQuery.parseJSON(data);
                            if (productGroupResult.ResultStatus === 0) {
                                Swal.fire(
                                    'Silindi!',
                                    `${productGroupResult.ProductGroup.Title}`,
                                    'success'
                                );

                                dataTable.row(tableRow).remove().draw();
                            } else {
                                Swal.fire({
                                    icon: 'error',
                                    title: 'Başarısız İşlem!',
                                    text: `${productGroupResult.Message}`,
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
        const url = '/Admin/ProductGroup/Add/';
        const placeHolderDiv = $('#modalPlaceHolder');
        $('#btnAdd').click(function () {
            $.get(url).done(function (data) {
                placeHolderDiv.html(data);
                placeHolderDiv.find(".modal").modal('show');
            });
        });

        /* Ajax GET / Getting the _ProductGroupAddPartial as Modal Form ends here. */

        /* Ajax POST / Posting the FormData as ProductGroupAddDto starts from here. */

        placeHolderDiv.on('click',
            '#btnSave',
            function (event) {
                event.preventDefault();
                const form = $('#form-productGroup-add');
                const actionUrl = form.attr('action');
                const dataToSend = form.serialize();
                $.post(actionUrl, dataToSend).done(function (data) {
                    console.log(data);
                    const ProductGroupAddAjaxModel = jQuery.parseJSON(data);
                    console.log(ProductGroupAddAjaxModel);
                    const newFormBody = $('.modal-body', ProductGroupAddAjaxModel.ProductGroupAddPartial);
                    placeHolderDiv.find('.modal-body').replaceWith(newFormBody);
                    const isValid = newFormBody.find('[name="IsValid"]').val() === 'True';
                    if (isValid) {
                        placeHolderDiv.find('.modal').modal('hide');
                        const newTableRow = dataTable.row.add([
                            ProductGroupAddAjaxModel.ProductGroupDto.ProductGroup.Id,
                            ProductGroupAddAjaxModel.ProductGroupDto.ProductGroup.Title,
                            ProductGroupAddAjaxModel.ProductGroupDto.ProductGroup.Description,
                            `
                                <button class="btn btn-primary btn-sm btn-update" data-id="${ProductGroupAddAjaxModel.ProductGroupDto.ProductGroup.Id}"><span class="fas fa-edit"></span></button>
                                <button class="btn btn-danger btn-sm btn-delete" data-id="${ProductGroupAddAjaxModel.ProductGroupDto.ProductGroup.Id}"><span class="fas fa-minus-circle"></span></button>
                                            `
                        ]).node();
                        const jqueryTableRow = $(newTableRow);
                        jqueryTableRow.attr('name', `${ProductGroupAddAjaxModel.ProductGroupDto.ProductGroup.Id}`);
                        dataTable.draw();
                        toastr.success(`${ProductGroupAddAjaxModel.ProductGroupDto.Message}`, 'Başarılı İşlem!');
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

    /* Ajax POST / Posting the FormData as ProductGroupAddDto ends here. */

    /* Ajax POST / Deleting a ProductGroup starts from here */

    /* Ajax GET / Getting the _productGroupUpdatePartial as Modal Form starts from here. */

    $(function () {
        const url = '/Admin/ProductGroup/Update/';
        const placeHolderDiv = $('#modalPlaceHolder');
        $(document).on('click',
            '.btn-update',
            function (event) {
                event.preventDefault();
                const id = $(this).attr('data-id');
                $.get(url, { ProductGroupId: id }).done(function (data) {
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

                const form = $('#form-productGroup-update');
                const actionUrl = form.attr('action');
                const dataToSend = form.serialize();
                $.post(actionUrl, dataToSend).done(function (data) {
                    const productGroupTypeUpdateAjaxViewModel = jQuery.parseJSON(data);
                    console.log(productGroupTypeUpdateAjaxViewModel);
                    const newFormBody = $('.modal-body', productGroupTypeUpdateAjaxViewModel.productGroupUpdatePartial);
                    placeHolderDiv.find('.modal-body').replaceWith(newFormBody);
                    const isValid = newFormBody.find('[name="IsValid"]').val() === 'True';
                    if (isValid) {
                        const productGroup = productGroupTypeUpdateAjaxViewModel.ProductGroupDto.ProductGroup
                        const id = productGroup.Id;
                        const tableRow = $(`[name="${id}"]`);
                        placeHolderDiv.find('.modal').modal('hide');
                        dataTable.row(tableRow).data([
                            productGroup.Id,
                            productGroup.Title,
                            productGroup.Description,
                            `
                                       <button class="btn btn-primary btn-sm btn-update" data-id="${productGroup.Id}"><span class="fas fa-edit"></span></button>
                                <button class="btn btn-danger btn-sm btn-delete" data-id="${productGroup.Id}"><span class="fas fa-minus-circle"></span></button>
                                            `
                        ]);
                        tableRow.attr("name", `${id}`);
                        dataTable.row(tableRow).invalidate();
                        toastr.success(`${productGroupTypeUpdateAjaxViewModel.ProductGroupDto.Message}`, "Başarılı İşlem!");
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