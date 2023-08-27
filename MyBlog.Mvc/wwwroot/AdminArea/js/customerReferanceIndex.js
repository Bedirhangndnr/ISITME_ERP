$(document).ready(function () {

    const tableType = document.getElementById("tableType").value;
    /* DataTables start here. */

    const dataTable = $('#messageToDevelopersTable').DataTable({
        dom:
            "<'row'<'col-sm-3'l><'col-sm-6 text-center'B><'col-sm-3'f>>" +
            "<'row'<'col-sm-12'tr>>" +
            "<'row'<'col-sm-5'i><'col-sm-7'p>>",
        "order": [[6, "desc"]],
        buttons: [
            {
                text: 'Ekle',
                attr: {
                    id: "btnAddMessage",
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
                        url: '/Admin/MessageToDeveloper/GetAllMessageToDevelopers/',
                        contentType: "application/json",
                        beforeSend: function () {
                            $('#messageToDevelopersTable').hide();
                            $('.spinner-border').show();
                        },
                        success: function (data) {
                            const MessageToDeveloperListDto = jQuery.parseJSON(data);
                            dataTable.clear();
                            console.log(MessageToDeveloperListDto);
                            if (MessageToDeveloperListDto.Data.ResultStatus === 0) {
                                $.each(MessageToDeveloperListDto.Data.MessageToDevelopers.$values,
                                    function (index, messageToDeveloper) {
                                        const newTableRow = dataTable.row.add([
                                            messageToDeveloper.Id,
                                            messageToDeveloper.Title,
                                            (messageToDeveloper.Message.length > 50) ? (messageToDeveloper.Message.slice(0, 50) + "...") : messageToDeveloper.Message,
                                            `
                            <div class="form-group row justify-content-center">
                                  ${document.getElementById("tableType").value === 'NonDeletedTables' ? '<button title="Güncelle" class="btn btn-primary btn-sm btn-update" data-id=' + messageToDeveloper.Id + '><span class="fas fa-edit"></span></button>' : ''}
                                  <button title="Sil" class="btn btn-danger btn-sm btn-delete" data-id=${messageToDeveloper.Id} data-tableType=${tableType}><span class="fas fa-minus-circle"></span></button>
                                  ${document.getElementById("tableType").value === 'DeletedTables' ? '<a class="btn btn-warning btn-sm btn-undo" data-id="' + messageToDeveloper.Id + '"><span class="fas fa-undo"></span></a>' : ''}
                            </div>
                            `
                                        ]).node();
                                        const jqueryTableRow = $(newTableRow);
                                        jqueryTableRow.attr('name', `${messageToDeveloper.Id}`);
                                    });
                                dataTable.draw();
                                $('.spinner-border').hide();
                                $('#messageToDevelopersTable').fadeIn(1400);
                            } else {
                                $('.spinner-border').hide();
                                $('#messageToDevelopersTable').fadeIn(1000);
                                toastr.error(`${messageToDeveloperListDto.Data.Message}`, 'İşlem Başarısız!');
                            }
                        },
                        error: function (err) {
                            console.log(err);
                            $('.spinner-border').hide();
                            $('#messageToDevelopersTable').fadeIn(1000);
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

    /* Ajax GET / Getting the _MessageToDeveloperAddPartial as Modal Form starts from here. */

    $(function () {
        const url = '/Admin/MessageToDeveloper/Add/';
        const placeHolderDiv = $('#modalPlaceHolder');
        $('#btnAddMessage').click(function () {
            $.get(url).done(function (data) {
                placeHolderDiv.html(data);
                placeHolderDiv.find(".modal").modal('show');
            });
        });

        /* Ajax GET / Getting the _MessageToDeveloperAddPartial as Modal Form ends here. */

        /* Ajax POST / Posting the FormData as MessageToDeveloperAddDto starts from here. */

        placeHolderDiv.on('click',
            '#btnSave',
            function (event) {
                event.preventDefault();
                const form = $('#form-messageToDeveloper-add');
                const actionUrl = form.attr('action');
                const dataToSend = form.serialize();
                $.post(actionUrl, dataToSend).done(function (data) {
                    console.log(data);
                    const MessageToDeveloperAddAjaxModel = jQuery.parseJSON(data);
                    console.log(MessageToDeveloperAddAjaxModel);
                    const newFormBody = $('.modal-body', MessageToDeveloperAddAjaxModel.MessageToDeveloperAddPartial);
                    placeHolderDiv.find('.modal-body').replaceWith(newFormBody);
                    const isValid = newFormBody.find('[name="IsValid"]').val() === 'True';
                    if (isValid) {
                        placeHolderDiv.find('.modal').modal('hide');
                        messageToDeveloper = MessageToDeveloperAddAjaxModel.MessageToDeveloperDto.MessageToDeveloper;
                        const newTableRow = dataTable.row.add([
                            messageToDeveloper.Id,
                            messageToDeveloper.Title,
                            (messageToDeveloper.Message.length > 50) ? (messageToDeveloper.Message.slice(0, 50) + "...") : messageToDeveloper.Message,
                            `
                            <div class="form-group row justify-content-center">
                                  ${document.getElementById("tableType").value === 'NonDeletedTables' ? '<button title="Güncelle" class="btn btn-primary btn-sm btn-update" data-id=' + messageToDeveloper.Id + '><span class="fas fa-edit"></span></button>' : ''}
                                  <button title="Sil" class="btn btn-danger btn-sm btn-delete" data-id=${messageToDeveloper.Id} data-tableType=${tableType}><span class="fas fa-minus-circle"></span></button>
                                  ${document.getElementById("tableType").value === 'DeletedTables' ? '<a class="btn btn-warning btn-sm btn-undo" data-id="' + messageToDeveloper.Id + '"><span class="fas fa-undo"></span></a>' : ''}
                            </div>
                            `
                        ]).node();
                        const jqueryTableRow = $(newTableRow);
                        jqueryTableRow.attr('name', `${messageToDeveloper.Id}`);
                        dataTable.draw();
                        toastr.success(`${MessageToDeveloperAddAjaxModel.MessageToDeveloperDto.Message}`, 'Başarılı İşlem!');
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

    /* Ajax POST / Posting the FormData as MessageToDeveloperAddDto ends here. */

    /* Ajax POST / Deleting a MessageToDeveloper starts from here */

    $(document).on('click',
        '.btn-delete',
        function (event) {
            event.preventDefault();
            const id = $(this).attr('data-id');
            const tableType = $(this).attr('data-tableType');
            const tableRow = $(`[name="${id}"]`);
            const messageToDeveloperName = tableRow.find('td:eq(1)').text();
            Swal.fire({
                title: tableType === 'DeletedTables' ? 'Kalıcı olarak silmek istediğinize emin misiniz?' : 'Silmek istediğinize emin misiniz?',
                text: `${messageToDeveloperName} Başlıklı Brand ${tableType === 'DeletedTables' ? 'kalıcı olarak ' : ''} Silinecektir!`,
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
                        data: { messageToDeveloperId: id, tableType: tableType },
                        url: '/Admin/MessageToDeveloper/Delete/',
                        success: function (data) {
                            const messageToDeveloperResult = jQuery.parseJSON(data);
                            if (messageToDeveloperResult.ResultStatus === 0) {
                                if (tableType === 'DeletedTables') {
                                    Swal.fire(
                                        'Tamamen Silindi!',
                                        `${messageToDeveloperResult.Message}`,
                                        'success'
                                    );
                                }
                                else {
                                    Swal.fire(
                                        'Silindi!',
                                        `${messageToDeveloperResult.Message}`,
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
                                    text: `${messageToDeveloperResult.Message}`,
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

    /* Ajax GET / Getting the _MessageToDeveloperUpdatePartial as Modal Form starts from here. */

    $(function () {
        const url = '/Admin/MessageToDeveloper/Update/';
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

        /* Ajax POST / Updating a MessageToDeveloper starts from here */

        placeHolderDiv.on('click',
            '#btnUpdate',
            function (event) {
                event.preventDefault();

                const form = $('#form-MessageToDeveloper-update');
                const actionUrl = form.attr('action');
                const dataToSend = `${form.serialize()}&tableType=${tableType}`;
                $.post(actionUrl, dataToSend).done(function (data) {
                    const MessageToDeveloperUpdateAjaxModel = jQuery.parseJSON(data);
                    console.log(MessageToDeveloperUpdateAjaxModel);
                    const newFormBody = $('.modal-body', MessageToDeveloperUpdateAjaxModel.MessageToDeveloperUpdatePartial);
                    placeHolderDiv.find('.modal-body').replaceWith(newFormBody);
                    const isValid = newFormBody.find('[name="IsValid"]').val() === 'True';
                    if (isValid) {
                        const messageToDeveloper = MessageToDeveloperUpdateAjaxModel.MessageToDeveloperDto.MessageToDeveloper
                        const id = messageToDeveloper.Id;
                        const tableRow = $(`[name="${id}"]`);
                        placeHolderDiv.find('.modal').modal('hide');
                        dataTable.row(tableRow).data([
                            messageToDeveloper.Id,
                            messageToDeveloper.Title,
                            (messageToDeveloper.Message.length > 50) ? (messageToDeveloper.Message.slice(0, 50) + "...") : messageToDeveloper.Message,
                            `
                            <div class="form-group row justify-content-center">
                                  ${document.getElementById("tableType").value === 'NonDeletedTables' ? '<button title="Güncelle" class="btn btn-primary btn-sm btn-update" data-id=' + messageToDeveloper.Id + '><span class="fas fa-edit"></span></button>' : ''}
                                  <button title="Sil" class="btn btn-danger btn-sm btn-delete" data-id=${messageToDeveloper.Id} data-tableType=${tableType}><span class="fas fa-minus-circle"></span></button>
                                  ${document.getElementById("tableType").value === 'DeletedTables' ? '<a class="btn btn-warning btn-sm btn-undo" data-id="' + messageToDeveloper.Id + '"><span class="fas fa-undo"></span></a>' : ''}
                            </div>
                            `
                        ]);
                        tableRow.attr("name", `${id}`);
                        dataTable.row(tableRow).invalidate();
                        toastr.success(`${MessageToDeveloperUpdateAjaxModel.MessageToDeveloperDto.Message}`, "Başarılı İşlem!");
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
            const messageToDeveloperFirsName = tableRow.find('td:eq(1)').text();
            const messageToDeveloperLastName = tableRow.find('td:eq(2)').text();
            Swal.fire({
                title: tableType === 'DeletedTables' ? 'Silinen Brand Geri Getirilsin Mi??' : 'Silmek istediğinize emin misiniz?',
                text: `${messageToDeveloperFirsName} Adlı Brand Geri Getirilecektir!`,
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
                        data: { messageToDeveloperId: id },
                        url: '/Admin/messageToDeveloper/UndoDelete/',
                        success: function (data) {
                            const messageToDeveloperResult = jQuery.parseJSON(data);
                            if (messageToDeveloperResult.ResultStatus === 0) {
                                Swal.fire(
                                    'Geri Getirildi!',
                                    `${messageToDeveloperResult.Message}`,
                                    'success'
                                );
                                tableRow.fadeOut(2000, function () {
                                    dataTable.row($(this)).remove().draw();
                                });

                            } else {
                                Swal.fire({
                                    icon: 'error',
                                    title: 'Başarısız İşlem!',
                                    text: `${messageToDeveloperResult.Message}`,
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