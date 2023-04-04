$(document).ready(function () {
    const tableType = document.getElementById("tableType").value;

    /* DataTables start here. */

    const dataTable = $('#employeeTypesTable').DataTable({
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
                    const addButton = dataTable.buttons()[1];

                    if (tableType === "DeletedTable") {
                        addButton.remove();
                    }
                }
            },
            {
                text: 'Yenile',
                className: 'btn btn-warning',
                action: function (e, dt, node, config) {
                    $.ajax({
                        type: 'GET',
                        data: { tableType: tableType },
                        url: '/Admin/EmployeeType/GetAllEmployeeTypes/',
                        contentType: "application/json",
                        beforeSend: function () {
                            $('#employeeTypesTable').hide();
                            $('.spinner-border').show();
                        },
                        success: function (data) {
                            if (data === null) {
                                $('.spinner-border').hide();
                                $('#employeesTable').fadeIn(1400);
                            }
                            else {
                                const employeeTypeListDto = jQuery.parseJSON(data);
                                dataTable.clear();
                                console.log(employeeTypeListDto);
                                if (employeeTypeListDto.Data.ResultStatus === 0) {
                                    $.each(employeeTypeListDto.Data.EmployeeTypes.$values,
                                        function (index, employeeType) {
                                            const newTableRow = dataTable.row.add([
                                                employeeType.Id,
                                                employeeType.Title,
                                                employeeType.Description,
                                                `
                                                <button title="Güncelle" class="btn btn-primary btn-sm btn-update" data-id=${employeeType.Id}><span class="fas fa-edit"></span></button>
                                                <button title="Sil" class="btn btn-danger btn-sm btn-delete" data-id=${employeeType.Id} data-tableType=${tableType}><span class="fas fa-minus-circle"></span></button>

  
                                                    `
                                            ]).node();
                                            const jqueryTableRow = $(newTableRow);
                                            jqueryTableRow.attr('name', `${employeeType.Id}`);
                                            // Check if tableType is DeletedTables
                                            if (tableType == 'DeletedTables') {
                                                // Append undo button
                                                jqueryTableRow.find('td:last').append('<a class="btn btn-warning btn-sm btn-undo" data-id="' + employeeType.Id + '"><span class="fas fa-undo"></span></a>');
                                            }
                                        });
                                    dataTable.draw();
                                    $('.spinner-border').hide();
                                    $('#employeeTypesTable').fadeIn(1000);
                                } else {
                                    $('.spinner-border').hide();
                                    $('#employeeTypesTable').fadeIn(1000);
                                    toastr.error(`${employeeTypeListDto.Data.Message}`, 'İşlem Başarısız!');
                                }
                            }

                        },
                        error: function (err) {
                            console.log(err);
                            $('.spinner-border').hide();
                            $('#employeeTypesTable').fadeIn(1000);
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
        },
        initComplete: function () {
            if (tableType === "DeletedTables") {
                $('#btnAdd').remove();
            }
        }
    });


    /* DataTables end here */

    /* Ajax POST / Deleting a User starts from here */
    $(function () {
        $("#btnDelete").click(function () {
            var url = $(this).data("url");

            $.ajax({
                url: url,
                type: "POST",
                success: function () {
                    alert("Silme işlemi başarılı.");
                    location.reload();
                },
                error: function () {
                    alert("Silme işlemi başarısız.");
                }
            });
        });
    });
    $(document).on('click',
        '.btn-delete',
        function (event) {
            event.preventDefault();
            const id = $(this).attr('data-id');
            const tableType = $(this).attr('data-tableType');
            const inUpdate = $(this).attr('data-inUpdate');

            const tableRow = $(`[name="${id}"]`);
            const employeeTypeTitle = tableRow.find('td:eq(2)').text(); // table datadan 2. indexdeki değeri aldık.
            Swal.fire({
                title: tableType === 'DeletedTables' ? 'Kalıcı olarak silmek istediğinize emin misiniz?' : 'Silmek istediğinize emin misiniz?',
                text: `${employeeTypeTitle} Başlıklı Çalışan Tipi ${tableType === 'DeletedTables' ? 'kalıcı olarak ' : ''} Silinecektir!`,
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
                        data: { employeeTypeId: id, tableType: tableType },
                        url: '/Admin/employeeType/Delete/',
                        success: function (data) {
                            const employeeTypeResult = jQuery.parseJSON(data);
                            if (employeeTypeResult.ResultStatus === 0) {
                                if (tableType === 'DeletedTables') {
                                    Swal.fire(
                                        'Tamamen Silindi!',
                                        `${employeeTypeResult.Message}`,
                                        'success'
                                    );
                                }
                                else {
                                    Swal.fire(
                                        'Silindi!',
                                        `${employeeTypeResult.Message}`,
                                        'success'
                                    );
                                }
                                if (inUpdate === '1') {
                                    //update controller içindeyiz, sil butonuna tıklandığında şu adrese git
                                    var url_ = '/Admin/Employee/Index?tableType=' + tableType;
                                    window.location.href = url_;
                                } else {
                                    // index controller içindeyiz, sil butonuna tıklandığında şu adrese git
                                    tableRow.fadeOut(2000, function () {
                                        dataTable.row($(this)).remove().draw();
                                    });
                                }
                            } else {
                                Swal.fire({
                                    icon: 'error',
                                    title: 'Başarısız İşlem!',
                                    text: `${employeeTypeResult.Message}`,
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
        const url = '/Admin/EmployeeType/Add/';
        const placeHolderDiv = $('#modalPlaceHolder');
        $('#btnAdd').click(function () {
            $.get(url).done(function (data) {
                placeHolderDiv.html(data);
                placeHolderDiv.find(".modal").modal('show');
            });
        });

        /* Ajax GET / Getting the _EmployeeTypeAddPartial as Modal Form ends here. */

        /* Ajax POST / Posting the FormData as EmployeeTypeAddDto starts from here. */

        placeHolderDiv.on('click',
            '#btnSave',
            function (event) {
                event.preventDefault();
                const form = $('#form-employeeType-add');
                const actionUrl = form.attr('action');
                const dataToSend = form.serialize();
                $.post(actionUrl, dataToSend).done(function (data) {
                    console.log(data);
                    const EmployeeTypeAddAjaxModel = jQuery.parseJSON(data);
                    console.log(EmployeeTypeAddAjaxModel);
                    const newFormBody = $('.modal-body', EmployeeTypeAddAjaxModel.EmployeeTypeAddPartial);
                    placeHolderDiv.find('.modal-body').replaceWith(newFormBody);
                    const isValid = newFormBody.find('[name="IsValid"]').val() === 'True';
                    if (isValid) {
                        placeHolderDiv.find('.modal').modal('hide');
                        const newTableRow = dataTable.row.add([
                            EmployeeTypeAddAjaxModel.EmployeeTypeDto.EmployeeType.Id,
                            EmployeeTypeAddAjaxModel.EmployeeTypeDto.EmployeeType.Title,
                            EmployeeTypeAddAjaxModel.EmployeeTypeDto.EmployeeType.Description,
                            `
                                <button class="btn btn-primary btn-sm btn-update" data-id="${EmployeeTypeAddAjaxModel.EmployeeTypeDto.EmployeeType.Id}"><span class="fas fa-edit"></span></button>
                                <button class="btn btn-danger btn-sm btn-delete" data-id="${EmployeeTypeAddAjaxModel.EmployeeTypeDto.EmployeeType.Id}"><span class="fas fa-minus-circle"></span></button>
                                            `
                        ]).node();
                        const jqueryTableRow = $(newTableRow);
                        jqueryTableRow.attr('name', `${EmployeeTypeAddAjaxModel.EmployeeTypeDto.EmployeeType.Id}`);
                        dataTable.draw();
                        toastr.success(`${EmployeeTypeAddAjaxModel.EmployeeTypeDto.Message}`, 'Başarılı İşlem!');
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

    /* Ajax POST / Posting the FormData as EmployeeTypeAddDto ends here. */

    /* Ajax POST / Deleting a EmployeeType starts from here */

    /* Ajax GET / Getting the _employeeTypeUpdatePartial as Modal Form starts from here. */

    $(function () {
        const url = '/Admin/EmployeeType/Update/';
        const placeHolderDiv = $('#modalPlaceHolder');
        $(document).on('click',
            '.btn-update',
            function (event) {
                event.preventDefault();
                const id = $(this).attr('data-id');
                const tableType = document.getElementById("tableType").value;
                $.get(url, { employeeTypeId: id, tableType: tableType }).done(function (data) {
                    placeHolderDiv.html(data);
                    placeHolderDiv.find('.modal').modal('show');
                    type = "hidden";
                }).fail(function (err) {
                    console.log(err);
                    toastr.error("Bir hata oluştu.");
                });
            });

        /* Ajax POST / Updating a Employee starts from here */

        placeHolderDiv.on('click',
            '#btnUpdate',
            function (event) {
                event.preventDefault();
                const form = $('#form-employeeType-update');
                const actionUrl = form.attr('action');
                const tableType = $(this).attr('data-tableType');
                const dataToSend = `${form.serialize()}&tableType=${tableType}`;
                $.post(actionUrl, dataToSend).done(function (data) {
                    const employeeTypeUpdateAjaxModel = jQuery.parseJSON(data);
                    console.log(employeeTypeUpdateAjaxModel);
                    const newFormBody = $('.modal-body', employeeTypeUpdateAjaxModel.employeeTypeUpdatePartial);
                    placeHolderDiv.find('.modal-body').replaceWith(newFormBody);
                    const isValid = newFormBody.find('[name="IsValid"]').val() === 'True';
                    if (isValid) {
                        const employeeType = employeeTypeUpdateAjaxModel.EmployeeTypeDto.EmployeeType
                        const id = employeeType.Id;
                        const tableRow = $(`[name="${id}"]`);
                        placeHolderDiv.find('.modal').modal('hide');
                        dataTable.row(tableRow).data([
                            employeeType.Id,
                            employeeType.Title,
                            employeeType.Description,
                            `
                                                    <button title="Güncelle" class="btn btn-primary btn-sm btn-update" data-id=${employeeType.Id}><span class="fas fa-edit"></span></button>

                                                                                <button title="Sil" class="btn btn-danger btn-sm btn-delete" data-id=${employeeType.Id} data-tableType=${document.getElementById("tableType").value}><span class="fas fa-minus-circle"></span></button>

                        ${(document.getElementById("tableType").value == 'DeletedTables') ? '<a class="btn btn-warning btn-sm btn-undo" data-id="' + employeeType.Id + '"><span class="fas fa-undo"></span></a>' : ''}
                                            `
                        ]);
                        dataTable.row(tableRow).invalidate();
                        toastr.success(`${employeeTypeUpdateAjaxModel.EmployeeTypeDto.Message}`, "Başarılı İşlem!");
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
            const inUpdate = $(this).attr('data-inUpdate');

            const employeeFirsName = tableRow.find('td:eq(1)').text();
            const employeeLastName = tableRow.find('td:eq(2)').text();
            Swal.fire({
                title: tableType === 'DeletedTables' ? 'Silinen Personel Geri Getirilsin Mi??' : 'Silmek istediğinize emin misiniz?',
                text: `${employeeFirsName} Adlı Personel Geri Getirilecektir!`,
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
                        data: { employeeId: id },
                        url: '/Admin/Employee/UndoDelete/',
                        success: function (data) {
                            const employeeResult = jQuery.parseJSON(data);
                            if (employeeResult.ResultStatus === 0) {
                                Swal.fire(
                                    'Geri Getirildi!',
                                    `${employeeResult.Message}`,
                                    'success'
                                );
                                tableRow.fadeOut(2000, function () {
                                    dataTable.row($(this)).remove().draw();
                                });

                            } else {
                                Swal.fire({
                                    icon: 'error',
                                    title: 'Başarısız İşlem!',
                                    text: `${employeeResult.Message}`,
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