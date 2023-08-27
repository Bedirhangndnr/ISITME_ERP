$(document).ready(function () {
    const tableType = document.getElementById("tableType").value;

    function asetRowColors() {
        var totalIncome = 0;
        var totalExpense = 0;
        var dailyTotalIncome = 0;
        var dailyTotalExpense = 0;

        $("tbody tr").each(function () {

            var isIncome = $(this).find("td:nth-child(6)").text().trim() === "Gelir";

            if (isIncome) {
                $(this).removeClass("expense-row").addClass("income-row");
            } else {
                $(this).removeClass("income-row").addClass("expense-row");
            }
            var amount = parseFloat($(this).find("td:nth-child(5)").text().replace(",", ""));
            var isDaily = $(this).find("td:nth-child(7)").text().trim() === "Günlük";

            if (isIncome) {
                totalIncome += amount;
                if (isDaily) {
                    dailyTotalIncome += amount;
                }
            } else {
                totalExpense += amount;
                if (isDaily) {
                    dailyTotalExpense += amount;
                }
            }
        });
        var overallIncome = totalIncome - dailyTotalIncome;
        var overallExpense = totalExpense - dailyTotalExpense;
        $("#overallTotalIncome").text((overallIncome || 0).toLocaleString("tr-TR") + " TL");
        $("#overallTotalExpense").text((overallExpense || 0).toLocaleString("tr-TR") + " TL");
        $("#totalIncome").text((totalIncome || 0).toLocaleString("tr-TR") + " TL");
        $("#totalExpense").text((totalExpense || 0).toLocaleString("tr-TR") + " TL");
        $("#dailyTotalIncome").text((dailyTotalIncome || 0).toLocaleString("tr-TR") + " TL");
        $("#dailyTotalExpense").text((dailyTotalExpense || 0).toLocaleString("tr-TR") + " TL");

    }
  
    asetRowColors(); 
    function formatDate(date) {
        var day = date.getDate().toString();
        var month = String(date.getMonth() + 1).padStart(2, '0');
        var year = date.getFullYear();
        var formattedDay = (day.startsWith('0') ? day.substring(1) : day);
        var formattedDate = formattedDay + '.' + month + '.' + year;

        return formattedDate;
    }
    const dataTable = $('#expensesTable').DataTable({
        paging: false,
        dom:
            "<'row'<'col-sm-3'l><'col-sm-7 text-center'B><'col-sm-3'f>>" +
            "<'row'<'col-sm-12'tr>>" +
            "<'row'<'col-sm-6'i><'col-sm-7'p>>",
        buttons: [
            {
                text: 'Bugün',
                className: 'btn btn-outline-secondary',
                action: function (e, dt, node, config) {
                    var today = new Date();
                    var formattedToday = today.toLocaleDateString("tr-TR");
                    var formattedTodayWithoutLeadingZero = formattedToday.replace(/^0+/, '');

                    dt.column(1).search(formattedTodayWithoutLeadingZero).draw();
                    asetRowColors();
                }

            },
            {
                text: '1 Hafta',
                className: 'btn btn-outline-primary',
                action: function (e, dt, node, config) {
                    var today = new Date();
                    var formattedToday = formatDate(today);

                    var endDate = new Date();
                    endDate.setHours(23, 59, 59, 999); // Günün son saati ve dakikası
                    endDate.setDate(today.getDate() - 7);
                    var formattedEndDate = formatDate(endDate);

                    var dateRange = '^(' + formattedToday;
                    var currentDate = new Date(today);
                    while (endDate<= currentDate ) {
                        endDate.setDate(endDate.getDate() + 1);
                        var formattedNextDate = formatDate(endDate);
                        dateRange += '|' + formattedNextDate;

                        if (endDate.getDate() === 1 && endDate.getMonth() !== currentDate.getMonth()) {
                            break;
                        }
                    }
                    dateRange += ')';

                    dt.columns(1).search(dateRange, true, false).draw();
                    asetRowColors();
                }
            },
            {
                text: 'Son 1 Ay',
                className: 'btn btn-outline-primary',
                action: function (e, dt, node, config) {
                    var today = new Date();
                    var formattedToday = formatDate(today);

                    var endDate = new Date();
                    endDate.setHours(23, 59, 59, 999); // Günün son saati ve dakikası
                    endDate.setDate(today.getDate() - 30);
                    var formattedEndDate = formatDate(endDate);

                    var dateRange = '^(' + formattedToday;
                    var currentDate = new Date(today);
                    while (endDate <= currentDate) {
                        endDate.setDate(endDate.getDate() + 1);
                        var formattedNextDate = formatDate(endDate);
                        dateRange += '|' + formattedNextDate;

                        if (endDate.getDate() === 1 && endDate.getMonth() !== currentDate.getMonth()) {
                            break;
                        }
                    }
                    dateRange += ')';

                    dt.columns(1).search(dateRange, true, false).draw();
                }
            },
            {
                    text: 'Tümünü Listele',
                    className: 'btn btn-outline-danger',
                    action: function (e, dt, node, config) {
                        dt.columns(1).search('').draw();
                    }
                },
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
                extend: 'excelHtml5',
                text: 'İndir | Excel',
                filename: 'Gelir Gider Tablosu',
                className: 'btn btn-outline-secondary'
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
    dataTable.on('draw.dt', function () {
        asetRowColors(); // DataTables çizildiğinde asetRowColors() fonksiyonunu çağırma
    });
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
                text: `${expenseTitle} Başlıklı Geliştiriciye Mesaj ${tableType === 'DeletedTables' ? 'kalıcı olarak ' : ''} Silinecektir!`,
                icon: 'warning',
                showCancelButton: true,
                confirmButtonColor: '#3086d7',
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
                    const SaleTypeAddAjaxModel = jQuery.parseJSON(data);
                    console.log(SaleTypeAddAjaxModel);
                    const newFormBody = $('.modal-body', SaleTypeAddAjaxModel.SaleTypeAddPartial);
                    placeHolderDiv.find('.modal-body').replaceWith(newFormBody);
                    const isValid = newFormBody.find('[name="IsValid"]').val() === 'True';
                    if (isValid) {
                        placeHolderDiv.find('.modal').modal('hide');
                        const expense = SaleTypeAddAjaxModel.SaleTypeDto.SaleType;
                        const tarih = new Date(expense.CreatedDate).toLocaleDateString("tr-TR");
                        const gun = new Date(expense.CreatedDate).toLocaleTimeString("tr-TR", { hour: "2-digit", minute: "2-digit" });
                        const newTableRow = dataTable.row.add([
                            expense.Id,
                            tarih,
                            gun,
                            expense.CreatedByName,
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
                        jqueryTableRow.attr('name', `${SaleTypeAddAjaxModel.SaleTypeDto.SaleType.Id}`);
                        dataTable.draw();
                        toastr.success(`${SaleTypeAddAjaxModel.SaleTypeDto.Message}`, 'Başarılı İşlem!');
                    }
                    else {
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
                        const tarih = new Date(expense.CreatedDate).toLocaleDateString("tr-TR");
                        const gun = new Date(expense.CreatedDate).toLocaleTimeString("tr-TR", { hour: "2-digit", minute: "2-digit" });
                        const id = expense.Id;
                        const tableRow = $(`[name="${id}"]`);
                        placeHolderDiv.find('.modal').modal('hide');
                        dataTable.row(tableRow).data([
                            expense.Id,
                            tarih,
                            gun,
                            expense.CreatedByName,
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
                title: tableType === 'DeletedTables' ? 'Silinen Geliştiriciye Mesaj Geri Getirilsin Mi??' : 'Silmek istediğinize emin misiniz?',
                text: `${expenseFirsName} Adlı Geliştiriciye Mesaj Geri Getirilecektir!`,
                icon: 'warning',
                showCancelButton: true,
                confirmButtonColor: '#3086d7',
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