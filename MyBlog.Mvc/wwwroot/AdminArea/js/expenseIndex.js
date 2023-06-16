$(document).ready(function () {
    const tableType = document.getElementById("tableType").value;

    /* DataTables start here. */
    function setRowColors() {
        $(".dataTable tbody tr").each(function () {
            var isIncome = $(this).find("td:nth-child(3)").text().trim() === "Gelir";
            if (isIncome) {
                $(this).addClass("income-row");
            } else {
                $(this).addClass("expense-row");
            }
        });

    }
    function asetRowColors() {
        $("tbody tr").each(function () {
            var isIncome = $(this).find("td:nth-child(3)").text().trim() === "Gelir";

            if (isIncome) {
                $(this).removeClass("expense-row").addClass("income-row");
            } else {
                $(this).removeClass("income-row").addClass("expense-row");
            }
        });
    }
    asetRowColors(); 
    const dataTable = $('#expensesTable').DataTable({
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
                        data: { tableType: tableType },
                        url: '/Admin/Expense/GetAllExpenses/',
                        contentType: "application/json",
                        beforeSend: function () {
                            $('#expensesTable').hide();
                            $('.spinner-border').show();
                        },
                        success: function (data) {
                            const expenseListDto = jQuery.parseJSON(data);
                            dataTable.clear();
                            console.log(expenseListDto);
                            if (expenseListDto.Data.ResultStatus === 0) {
                                $.each(expenseListDto.Data.Expenses.$values,
                                    function (index, expense) {
                                        const newTableRow = dataTable.row.add([
                                            expense.Id,
                                            expense.Amount,
                                            expense.IsIncome ? "Gelir" : "Gider",
                                            expense.IsDaily ? "Günlük" : "Genel",
                                            `
                                                <div class="form-group row justify-content-center">
                                                ${tableType === 'NonDeletedTables' ? '<button title="Güncelle" class="btn btn-primary btn-sm btn-update" data-id=' + expense.Id + '><span class="fas fa-edit"></span></button>' : ''}
                                                <button title="Sil" class="btn btn-danger btn-sm btn-delete" data-id=${expense.Id} data-tableType=${tableType}><span class="fas fa-minus-circle"></span></button>
                                                ${tableType === 'DeletedTables' ? '<a class="btn btn-warning btn-sm btn-undo" data-id="' + expense.Id + '"><span class="fas fa-undo"></span></a>' : ''}
                                                </div>
                                                    `
                                        ]).node();
                                        const jqueryTableRow = $(newTableRow);
                                        jqueryTableRow.attr('name', `${expense.Id}`);
                                    });
                                dataTable.draw();
                                asetRowColors();
                                $('.spinner-border').hide();
                                $('#expensesTable').fadeIn(1400);
                            } else {
                                $('.spinner-border').hide();
                                $('#expensesTable').fadeIn(1000);
                                toastr.error(`${expenseListDto.Data.Message}`, 'İşlem Başarısız!');
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
        '.btn-delete',
        function (event) {
            event.preventDefault();
            const id = $(this).attr('data-id');
            const tableType = $(this).attr('data-tableType');
            const tableRow = $(`[name="${id}"]`);
            const expenseTitle = tableRow.find('td:eq(2)').text(); // table datadan 2. indexdeki değeri aldık.
            Swal.fire({
                title: tableType === 'DeletedTables' ? 'Kalıcı olarak silmek istediğinize emin misiniz?' : 'Silmek istediğinize emin misiniz?',
                text: `${expenseTitle} Başlıklı Marka ${tableType === 'DeletedTables' ? 'kalıcı olarak ' : ''} Silinecektir!`,
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
                        data: { expenseId: id, tableType: tableType },
                        url: '/Admin/Expense/Delete/',
                        success: function (data) {
                            const expenseResult = jQuery.parseJSON(data);
                            if (expenseResult.ResultStatus === 0) {
                                if (tableType === 'DeletedTables') {
                                    Swal.fire(
                                        'Tamamen Silindi!',
                                        `${expenseResult.Message}`,
                                        'success'
                                    );
                                }
                                else {
                                    Swal.fire(
                                        'Silindi!',
                                        `${expenseResult.Message}`,
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
                                    text: `${expenseResult.Message}`,
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
        const url = '/Admin/Expense/Add/';
        const placeHolderDiv = $('#modalPlaceHolder');
        $('#btnAdd').click(function () {
            $.get(url).done(function (data) {
                placeHolderDiv.html(data);
                placeHolderDiv.find(".modal").modal('show');
            });
        });

        /* Ajax GET / Getting the _ExpenseAddPartial as Modal Form ends here. */

        /* Ajax POST / Posting the FormData as ExpenseAddDto starts from here. */

        placeHolderDiv.on('click',
            '#btnSave',
            function (event) {
                event.preventDefault();
                const form = $('#form-expense-add');
                const actionUrl = form.attr('action');
                const dataToSend = form.serialize();
                $.post(actionUrl, dataToSend).done(function (data) {
                    console.log(data);
                    const ExpenseAddAjaxModel = jQuery.parseJSON(data);
                    console.log(ExpenseAddAjaxModel);
                    const newFormBody = $('.modal-body', ExpenseAddAjaxModel.ExpenseAddPartial);
                    placeHolderDiv.find('.modal-body').replaceWith(newFormBody);
                    const isValid = newFormBody.find('[name="IsValid"]').val() === 'True';
                    if (isValid) {
                        placeHolderDiv.find('.modal').modal('hide');
                        const expense = ExpenseAddAjaxModel.ExpenseDto.Expense;
                        const newTableRow = dataTable.row.add([
                            expense.Id,
                            expense.Amount,
                            expense.IsIncome ? "Gelir" : "Gider",
                            expense.IsDaily ? "Günlük" : "Genel",
                            `
                                <div class="form-group row justify-content-center">
                                ${tableType === 'NonDeletedTables' ? '<button title="Güncelle" class="btn btn-primary btn-sm btn-update" data-id=' + expense.Id + '><span class="fas fa-edit"></span></button>' : ''}
                                <button title="Sil" class="btn btn-danger btn-sm btn-delete" data-id=${expense.Id} data-tableType=${tableType}><span class="fas fa-minus-circle"></span></button>
                                ${tableType === 'DeletedTables' ? '<a class="btn btn-warning btn-sm btn-undo" data-id="' + expense.Id + '"><span class="fas fa-undo"></span></a>' : ''}
                                </div>
                                    `
                        ]).node();
                        const jqueryTableRow = $(newTableRow);
                        jqueryTableRow.attr('name', `${ExpenseAddAjaxModel.ExpenseDto.Expense.Id}`);
                        dataTable.draw();
                        toastr.success(`${ExpenseAddAjaxModel.ExpenseDto.Message}`, 'Başarılı İşlem!');
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

    /* Ajax POST / Posting the FormData as ExpenseAddDto ends here. */

    /* Ajax POST / Deleting a Expense starts from here */

    /* Ajax GET / Getting the _expenseUpdatePartial as Modal Form starts from here. */

    $(function () {
        const url = '/Admin/Expense/Update/';
        const placeHolderDiv = $('#modalPlaceHolder');
        $(document).on('click',
            '.btn-update',
            function (event) {
                event.preventDefault();
                const tableType = document.getElementById("tableType").value;
                const id = $(this).attr('data-id');
                $.get(url, { expenseId: id, tableType: tableType }).done(function (data) {
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

                const form = $('#form-expense-update');
                const actionUrl = form.attr('action');
                const dataToSend = `${form.serialize()}&tableType=${tableType}`;
                $.post(actionUrl, dataToSend).done(function (data) {
                    const expenseTypeUpdateAjaxViewModel = jQuery.parseJSON(data);
                    console.log(expenseTypeUpdateAjaxViewModel);
                    const newFormBody = $('.modal-body', expenseTypeUpdateAjaxViewModel.expenseUpdatePartial);
                    placeHolderDiv.find('.modal-body').replaceWith(newFormBody);
                    const isValid = newFormBody.find('[name="IsValid"]').val() === 'True';
                    if (isValid) {
                        const expense = expenseTypeUpdateAjaxViewModel.ExpenseDto.Expense
                        const id = expense.Id;
                        const tableRow = $(`[name="${id}"]`);
                        placeHolderDiv.find('.modal').modal('hide');
                        dataTable.row(tableRow).data([
                            expense.Id,
                            expense.Amount,
                            expense.IsIncome ? "Gelir" : "Gider",
                            expense.IsDaily ? "Günlük" : "Genel",
                            `
                            <div class="form-group row justify-content-center">
                                  ${document.getElementById("tableType").value === 'NonDeletedTables' ? '<button title="Güncelle" class="btn btn-primary btn-sm btn-update" data-id=' + expense.Id + '><span class="fas fa-edit"></span></button>' : ''}
                                  <button title="Sil" class="btn btn-danger btn-sm btn-delete" data-id=${expense.Id} data-tableType=${tableType}><span class="fas fa-minus-circle"></span></button>
                                  ${document.getElementById("tableType").value === 'DeletedTables' ? '<a class="btn btn-warning btn-sm btn-undo" data-id="' + expense.Id + '"><span class="fas fa-undo"></span></a>' : ''}
                                </div>
                            `
                        ]);
                        tableRow.attr("name", `${id}`);
                        dataTable.row(tableRow).invalidate();
                        asetRowColors();
                        toastr.success(`${expenseTypeUpdateAjaxViewModel.ExpenseDto.Message}`, "Başarılı İşlem!");
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
            const expenseFirsName = tableRow.find('td:eq(1)').text();
            const expenseLastName = tableRow.find('td:eq(2)').text();
            Swal.fire({
                title: tableType === 'DeletedTables' ? 'Silinen Marka Geri Getirilsin Mi??' : 'Silmek istediğinize emin misiniz?',
                text: `${expenseFirsName} Adlı Marka Geri Getirilecektir!`,
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
                        data: { expenseId: id },
                        url: '/Admin/expense/UndoDelete/',
                        success: function (data) {
                            const expenseResult = jQuery.parseJSON(data);
                            if (expenseResult.ResultStatus === 0) {
                                Swal.fire(
                                    'Geri Getirildi!',
                                    `${expenseResult.Message}`,
                                    'success'
                                );
                                tableRow.fadeOut(2000, function () {
                                    dataTable.row($(this)).remove().draw();
                                });

                            } else {
                                Swal.fire({
                                    icon: 'error',
                                    title: 'Başarısız İşlem!',
                                    text: `${expenseResult.Message}`,
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