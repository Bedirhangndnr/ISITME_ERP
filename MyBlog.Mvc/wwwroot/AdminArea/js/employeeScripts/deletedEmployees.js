$(document).ready(function () {

    /* DataTables start here. */

   const dataTable = $('#deletedEmployeesTable').DataTable({
        dom:
            "<'row'<'col-sm-3'l><'col-sm-6 text-center'B><'col-sm-3'f>>" +
            "<'row'<'col-sm-12'tr>>" +
            "<'row'<'col-sm-5'i><'col-sm-7'p>>",
        buttons: [
            {
                text: 'Yenile',
                className: 'btn btn-warning',
                action: function (e, dt, node, config) {
                    $.ajax({
                        type: 'GET',
                        url: '/Admin/Employee/GetAllDeletedEmployees/',
                        contentType: "application/json",
                        beforeSend: function () {
                            $('#deletedEmployeesTable').hide();
                            $('.spinner-border').show();
                        },
                        success: function (data) {
                            const employeeResult = jQuery.parseJSON(data);
                            dataTable.clear();
                            console.log(employeeResult);
                            if (employeeResult.Data.ResultStatus === 0) {
                                let categoriesArray = [];
                                $.each(employeeResult.Data.EmployeeListWithRelatedTables.$values,
                                    function (index, employee) {
                                        const newEmployee = getJsonNetObject(employee, employeeResult.Data.EmployeeListWithRelatedTables.$values);
                                        const newTableRow = dataTable.row.add([
                                            newEmployee.Id,
                                            newEmployee.FirstName,
                                            newEmployee.LastName,
                                            newEmployee.Phone,
                                            newEmployee.Email,
                                            newEmployee.About == null ? "Hakkında Kısmı Eklenmemiş" : (newEmployee.About.length > 100 ? newEmployee.About.substring(0, 100) : newEmployee.About),
                                            `<img src="/img/${newEmployee.Picture}" alt="${newEmployee.UserName}" class="my-image-table" />`,
                                            newEmployee.EmployeeTypeId + " " + newEmployee.EmployeeTypeTitle,
                                            `
                                    <a title="Tricks Site" class="btn btn-primary btn-sm btn-update" href="/Admin/Employee/Update?employeeId=${newEmployee.Id}"><span class="fas fa-edit"></span></a>
                                    <button class="btn btn-danger btn-sm btn-delete" data-id="${newEmployee.Id}"><span class="fas fa-minus-circle"></span></button>
                                    <a class="btn btn-warning btn-sm btn-undo" data-id="${newEmployee.Id}"><span class="fas fa-undo"></span></a>

    
                                            `
                                        ]).node();
                                        const jqueryTableRow = $(newTableRow);
                                        jqueryTableRow.attr('name', `${newEmployee.Id}`);
                                    });
                                dataTable.draw();
                                $('.spinner-border').hide();
                                $('#deletedEmployeesTable').fadeIn(1400);
                            } else {
                                toastr.error(`${employeeResult.Data.Message}`, 'İşlem Başarısız!');
                            }
                        },
                        error: function (err) {
                            console.log(err);
                            $('.spinner-border').hide();
                            $('#deletedEmployeesTable').fadeIn(1000);
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

    /* Ajax POST / HardDeleting a Employee starts from here */

    $(document).on('click',
        '.btn-delete',
        function (event) {
            event.preventDefault();
            const id = $(this).attr('data-id');
            const deleteType = $(this).attr('data-deleteType');

            const tableRow = $(`[name="${id}"]`);
            const employeeTitle = tableRow.find('td:eq(2)').text();
            Swal.fire({
                title: 'Kalıcı olarak silmek istediğinize emin misiniz?',
                text: `${employeeTitle} başlıklı makale kalıcı olarak silinicektir!`,
                icon: 'warning',
                showCancelButton: true,
                confirmButtonColor: '#3085d6',
                cancelButtonColor: '#d33',
                confirmButtonText: 'Evet, kalıcı olarak silmek istiyorum.',
                cancelButtonText: 'Hayır, istemiyorum.'
            }).then((result) => {
                if (result.isConfirmed) {
                    $.ajax({
                        type: 'POST',
                        dataType: 'json',
                        data: { employeeId: id, dataType: dataType },
                        url: '/Admin/Employee/HardDelete/',
                        success: function (data) {
                            const employeeResult = jQuery.parseJSON(data);
                            if (employeeResult.ResultStatus === 0) {
                                Swal.fire(
                                    'Silindi!',
                                    `${employeeResult.Message}`,
                                    'success'
                                );

                                dataTable.row(tableRow).remove().draw();
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

    /* Ajax POST / HardDeleting a Employee ends here */

    /* Ajax POST / UndoDeleting a Employee starts from here */

    $(document).on('click',
        '.btn-undo',
        function (event) {
            event.preventDefault();
            const id = $(this).attr('data-id');
            const tableRow = $(`[name="${id}"]`);
            let employeeTitle = tableRow.find('td:eq(2)').text();
            Swal.fire({
                title: 'Arşivden geri getirmek istediğinize emin misiniz?',
                text: `${employeeTitle} başlıklı makale arşivden geri getirilecektir!`,
                icon: 'question',
                showCancelButton: true,
                confirmButtonColor: '#3085d6',
                cancelButtonColor: '#d33',
                confirmButtonText: 'Evet, arşivden geri getirmek istiyorum.',
                cancelButtonText: 'Hayır, istemiyorum.'
            }).then((result) => {
                if (result.isConfirmed) {
                    $.ajax({
                        type: 'POST',
                        dataType: 'json',
                        data: { employeeId: id },
                        url: '/Admin/Employee/UndoDelete/',
                        success: function (data) {
                            const employeeUndoDeleteResult = jQuery.parseJSON(data);
                            console.log(employeeUndoDeleteResult);
                            if (employeeUndoDeleteResult.Data.ResultStatus === 0) {
                                Swal.fire(
                                    'Arşivden Geri Getirildi!',
                                    `${employeeUndoDeleteResult.Data.Message}`,
                                    'success'
                                );

                                dataTable.row(tableRow).remove().draw();
                            } else {
                                Swal.fire({
                                    icon: 'error',
                                    title: 'Başarısız İşlem!',
                                    text: `${employeeUndoDeleteResult.Data.Message}`,
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
/* Ajax POST / UndoDeleting a Employee ends here */

});