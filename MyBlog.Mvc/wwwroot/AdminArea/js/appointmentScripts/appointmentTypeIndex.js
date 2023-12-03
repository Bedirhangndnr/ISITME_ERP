
$(document).ready(function () {
    const tableType = document.getElementById("tableType").value;

    /* DataTables start here. */

    const dataTable = $('#appointmentTypesTable').DataTable({
        dom: 
            "<'row'<'col-sm-3'l><'col-sm-6 text-center'B><'col-sm-3'f>>" +
            "<'row'<'col-sm-12'tr>>" +
            "<'row'<'col-sm-5'i><'col-sm-7'p>>",
        buttons: [
            {
                text: 'Ekle',
                name: '0',
                attr: {
                    id: "btnAdd",
                },
                className: 'btn btn-success',
            },
            
            {
                text: 'Yenile',
                className: 'btn btn-warning',
                action: function (e, dt, node, config) {
                    $.ajax({
                        type: 'GET',
                        data: { tableType: tableType },
                        url: '/Admin/AppointmentType/GetAllAppointmentTypes/',
                        contentType: "application/json",
                        beforeSend: function () {
                            $('#appointmentTypesTable').hide();
                            $('.spinner-border').show();
                        },
                        success: function (data) {
                            if (data === null) {
                                $('.spinner-border').hide();
                                $('#appointmentsTable').fadeIn(1400);
                            }
                            else {
                                const appointmentTypeListDto = jQuery.parseJSON(data);
                                dataTable.clear();
                                console.log(appointmentTypeListDto);
                                if (appointmentTypeListDto.Data.ResultStatus === 0) {
                                    $.each(appointmentTypeListDto.Data.AppointmentTypes.$values,
                                        function (index, appointmentType) {
                                            const newTableRow = dataTable.row.add([
                                                appointmentType.Id,
                                                appointmentType.Title,
                                                appointmentType.Description,
                                                `
                                                <div class="form-group row justify-content-center">
                                                ${tableType === 'NonDeletedTables' ? '<button title="Güncelle" class="btn btn-primary btn-sm btn-update" data-id=' + appointmentType.Id + '><span class="fas fa-edit"></span></button>' : ''}
                                                <button title="Sil" class="btn btn-danger btn-sm btn-delete" data-id=${appointmentType.Id} data-tableType=${tableType}><span class="fas fa-minus-circle"></span></button>
                                                ${tableType === 'DeletedTables' ? '<a class="btn btn-warning btn-sm btn-undo" data-id="' + appointmentType.Id + '"><span class="fas fa-undo"></span></a>' : ''}
                                                </div>
                                                    `

                                            ]).node();
                                            const jqueryTableRow = $(newTableRow);
                                            jqueryTableRow.attr('name', `${appointmentType.Id}`);

                                        });
                                    dataTable.draw();
                                    $('.spinner-border').hide();
                                    $('#appointmentTypesTable').fadeIn(1000);
                                } else {
                                    $('.spinner-border').hide();
                                    $('#appointmentTypesTable').fadeIn(1000);
                                    toastr.error(`${appointmentTypeListDto.Data.Message}`, 'İşlem Başarısız!');
                                }
                            }

                        },
                        error: function (err) {
                            console.log(err);
                            $('.spinner-border').hide();
                            $('#appointmentTypesTable').fadeIn(1000);
                            toastr.error(`${err.responseText}`, 'Hata !');
                        }
                    });
                }
            }
        ],
        language: {
            "sDecimal": ",",
            "sEmptyTable": "Tabloda herhangi bir veri mevcut değil",
            "sInfo": "_TOTAL_ kayıttan _START_ - _ENtD_ arasındaki kayıtlar gösteriliyor",
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
        '.btn-delete',
        function (event) {
            event.preventDefault();
            const id = $(this).attr('data-id');
            const tableType = $(this).attr('data-tableType');
            const inUpdate = $(this).attr('data-inUpdate');
            const tableRow = $(`[name="${id}"]`);
            const appointmentTypeTitle = tableRow.find('td:eq(2)').text(); // table datadan 2. indexdeki değeri aldık.
            Swal.fire({
                title: tableType === 'DeletedTables' ? 'Kalıcı olarak silmek istediğinize emin misiniz?' : 'Silmek istediğinize emin misiniz?',
                text: `${appointmentTypeTitle} Başlıklı Randevu Tipi ${tableType === 'DeletedTables' ? 'kalıcı olarak ' : ''} Silinecektir!`,
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
                        data: { appointmentTypeId: id, tableType: tableType },
                        url: '/Admin/AppointmentType/Delete/',
                        success: function (data) {
                            const appointmentTypeResult = jQuery.parseJSON(data);
                            if (appointmentTypeResult.ResultStatus === 0) {
                                if (tableType === 'DeletedTables') {
                                    Swal.fire(
                                        'Tamamen Silindi!',
                                        `${appointmentTypeResult.Message}`,
                                        'success'
                                    );
                                }
                                else {
                                    Swal.fire(
                                        'Silindi!',
                                        `${appointmentTypeResult.Message}`,
                                        'success'
                                    );
                                }
                                if (inUpdate === '1') {
                                    //update controller içindeyiz, sil butonuna tıklandığında şu adrese git
                                    var url_ = '/Admin/AppointmentType/Index?tableType=' + tableType;
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
                                    text: `${appointmentTypeResult.Message}`,
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
        const url = '/Admin/AppointmentType/Add/';
        const placeHolderDiv = $('#modalPlaceHolder');
        $('#btnAdd').click(function () {
            $.get(url).done(function (data) {
                placeHolderDiv.html(data);
                placeHolderDiv.find(".modal").modal('show');
            });
        });

        /* Ajax GET / Getting the _AppointmentTypeAddPartial as Modal Form ends here. */

        /* Ajax POST / Posting the FormData as AppointmentTypeAddDto starts from here. */

        placeHolderDiv.on('click',
            '#btnSave',
            function (event) {
                event.preventDefault();
                const form = $('#form-appointmentType-add');
                const actionUrl = form.attr('action');
                const dataToSend = form.serialize();
                $.post(actionUrl, dataToSend).done(function (data) {
                    console.log(data);
                    const AppointmentTypeAddAjaxModel = jQuery.parseJSON(data);
                    console.log(AppointmentTypeAddAjaxModel);
                    const newFormBody = $('.modal-body', AppointmentTypeAddAjaxModel.AppointmentTypeAddPartial);
                    placeHolderDiv.find('.modal-body').replaceWith(newFormBody);
                    const isValid = newFormBody.find('[name="IsValid"]').val() === 'True';
                    if (isValid) {
                        placeHolderDiv.find('.modal').modal('hide');
                        const appointmentType = AppointmentTypeAddAjaxModel.AppointmentTypeDto.AppointmentType;

                        const newTableRow = dataTable.row.add([
                            appointmentType.Id,
                            appointmentType.Title,
                            appointmentType.Description,
                            `
                                <div class="form-group row justify-content-center">
                                ${tableType === 'NonDeletedTables' ? '<button title="Güncelle" class="btn btn-primary btn-sm btn-update" data-id=' + appointmentType.Id + '><span class="fas fa-edit"></span></button>' : ''}
                                <button title="Sil" class="btn btn-danger btn-sm btn-delete" data-id=${appointmentType.Id} data-tableType=${tableType}><span class="fas fa-minus-circle"></span></button>
                                ${tableType === 'DeletedTables' ? '<a class="btn btn-warning btn-sm btn-undo" data-id="' + appointmentType.Id + '"><span class="fas fa-undo"></span></a>' : ''}
                                </div>
                                    `
                        ]).node();
                        const jqueryTableRow = $(newTableRow);
                        jqueryTableRow.attr('name', `${AppointmentTypeAddAjaxModel.AppointmentTypeDto.AppointmentType.Id}`);
                        dataTable.draw();
                        toastr.success(`${AppointmentTypeAddAjaxModel.AppointmentTypeDto.Message}`, 'Başarılı İşlem!');
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

    /* Ajax POST / Posting the FormData as AppointmentTypeAddDto ends here. */

    /* Ajax POST / Deleting a AppointmentType starts from here */

    /* Ajax GET / Getting the _appointmentTypeUpdatePartial as Modal Form starts from here. */

    $(function () {
        const url = '/Admin/AppointmentType/Update/';
        const placeHolderDiv = $('#modalPlaceHolder');
        $(document).on('click',
            '.btn-update',
            function (event) {
                event.preventDefault();
                const id = $(this).attr('data-id');
                const tableType = document.getElementById("tableType").value;
                $.get(url, { AppointmentTypeId: id, tableType: tableType }).done(function (data) {
                    placeHolderDiv.html(data);
                    placeHolderDiv.find('.modal').modal('show');
                }).fail(function () {
                    console.log(err);
                    toastr.error("Bir hata oluştu.");
                });
            });

        /* Ajax POST / Updating a Customer starts from here */

        placeHolderDiv.on('click',
            '#btnUpdate',
            function (event) {
                event.preventDefault();

                const form = $('#form-appointmentType-update');
                const actionUrl = form.attr('action');
                const dataToSend = `${form.serialize()}&tableType=${tableType}`;
                $.post(actionUrl, dataToSend).done(function (data) {
                    const appointmentTypeUpdateAjaxViewModel = jQuery.parseJSON(data);
                    console.log(appointmentTypeUpdateAjaxViewModel);
                    const newFormBody = $('.modal-body', appointmentTypeUpdateAjaxViewModel.appointmentTypeUpdatePartial);
                    placeHolderDiv.find('.modal-body').replaceWith(newFormBody);
                    const isValid = newFormBody.find('[name="IsValid"]').val() === 'True';
                    if (isValid) {
                        const appointmentType = appointmentTypeUpdateAjaxViewModel.AppointmentTypeDto.AppointmentType
                        const id = appointmentType.Id;
                        const tableRow = $(`[name="${id}"]`);
                        placeHolderDiv.find('.modal').modal('hide');
                        dataTable.row(tableRow).data([
                            appointmentType.Id,
                            appointmentType.Title,
                            appointmentType.Description,
                            `
                                                ${document.getElementById("tableType").value === 'NonDeletedTables' ? '<button title="Güncelle" class="btn btn-primary btn-sm btn-update" data-id=' + appointmentType.Id + '><span class="fas fa-edit"></span></button>' : ''}
                                                <button title="Sil" class="btn btn-danger btn-sm btn-delete" data-id=${appointmentType.Id} data-tableType=${tableType}><span class="fas fa-minus-circle"></span></button>
                                                ${document.getElementById("tableType").value === 'DeletedTables' ? '<a class="btn btn-warning btn-sm btn-undo" data-id="' + appointmentType.Id + '"><span class="fas fa-undo"></span></a>' : ''}

                                            `
                        ]);
                        tableRow.attr("name", `${id}`);
                        dataTable.row(tableRow).invalidate();
                        toastr.success(`${appointmentTypeUpdateAjaxViewModel.AppointmentTypeDto.Message}`, "Başarılı İşlem!");
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
            const appointmentTypeFirsName = tableRow.find('td:eq(1)').text();
            const appointmentTypeLastName = tableRow.find('td:eq(2)').text();
            Swal.fire({
                title: tableType === 'DeletedTables' ? 'Silinen Randevu Tipi Geri Getirilsin Mi??' : 'Silmek istediğinize emin misiniz?',
                text: `${appointmentTypeFirsName} Adlı Randevu Tipi Geri Getirilecektir!`,
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
                        data: { appointmentTypeId: id },
                        url: '/Admin/appointmentType/UndoDelete/',
                        success: function (data) {
                            const appointmentTypeResult = jQuery.parseJSON(data);
                            if (appointmentTypeResult.ResultStatus === 0) {
                                Swal.fire(
                                    'Geri Getirildi!',
                                    `${appointmentTypeResult.Message}`,
                                    'success'
                                );
                                tableRow.fadeOut(2000, function () {
                                    dataTable.row($(this)).remove().draw();
                                });

                            } else {
                                Swal.fire({
                                    icon: 'error',
                                    title: 'Başarısız İşlem!',
                                    text: `${appointmentTypeResult.Message}`,
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