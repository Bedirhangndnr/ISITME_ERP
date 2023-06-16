$(document).ready(function () {
    const tableType = document.getElementById("tableType").value;
    /* DataTables start here. */

    const dataTable = $('#customersTable').DataTable({
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
                        url: '/Admin/Customer/GetAllCustomers/',
                        contentType: "application/json",
                        beforeSend: function () {
                            $('#customersTable').hide();
                            $('.spinner-border').show();
                        },
                        success: function (data) {

                            if (data === null) {
                                $('.spinner-border').hide();
                                $('#customersTable').fadeIn(1400);
                            }
                            else {
                                const customerListDto = jQuery.parseJSON(data);
                                dataTable.clear();
                                console.log(customerListDto);
                                if (customerListDto.Data.ResultStatus === 0) {
                                    $.each(customerListDto.Data.CustomersListWithRelatedTables.$values,
                                        function (index, customer) {
                                            const newTableRow = dataTable.row.add([
                                                customer.Id,
                                                customer.FirstName,
                                                customer.LastName,
                                                customer.Phone,
                                                customer.Email,
                                                customer.Note == null ? "Hakkında Kısmı Eklenmemiş" : (customer.Note.length > 100 ? customer.Note.substring(0, 100) : customer.Note),
                                                `<img src="/img/${customer.Picture}" alt="${customer.UserName}" class="my-image-table" />`,
                                                customer.CustomerTypeId + " " + customer.CustomerTypeTitle,
                                                `
                                                <div class="form-group row justify-content-center">
                                                <a title="Tricks Site" class="btn btn-primary btn-sm btn-update" href="/Admin/Customer/Update?customerId=${customer.Id}&tableType=${tableType}"><span class="fas fa-edit"></span></a>
                                                <button class="btn btn-danger btn-sm btn-delete" data-id="${customer.Id}" data-tableType=${tableType}><span class="fas fa-minus-circle"></span></button>
                                                ${tableType === 'DeletedTables' ? '<a class="btn btn-warning btn-sm btn-undo" data-id="' + customer.Id + '"><span class="fas fa-undo"></span></a>' : ''}
                                                </div>
                                            `
                                            ]).node();
                                            const jqueryTableRow = $(newTableRow);
                                            jqueryTableRow.attr('name', `${customer.Id}`);
                                        });
                                    dataTable.draw();
                                    $('.spinner-border').hide();
                                    $('#customersTable').fadeIn(1400);
                                } else {
                                    toastr.error(`${customerListDto.Data.Message}`, 'İşlem Başarısız!');
                                    $('.spinner-border').hide();
                                    $('#customersTable').fadeIn(1400);
                                }
                            }
                        },
                        error: function (err) {
                            console.log(err);
                            $('.spinner-border').hide();
                            $('#customersTable').fadeIn(1000);
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
    $(document).on('click',
        '.btn-deneme',
        function (event) {
            var url = '/Admin/Customer/Index?tableType=NonDeletedTables';
            window.location.href = url;
        });
   
    $(document).on('click',
        '.btn-delete',
        function (event) {
            event.preventDefault();
            const id = $(this).attr('data-id');
            const tableType = $(this).attr('data-tableType');
            const tableRow = $(`[name="${id}"]`);
            const inUpdate = $(this).attr('data-inUpdate');

            const customerFirsName = tableRow.find('td:eq(1)').text(); // table datadan 2. indexdeki değeri aldık.
            const customerLastName = tableRow.find('td:eq(2)').text(); // table datadan 2. indexdeki değeri aldık.
            Swal.fire({
                title: tableType === 'DeletedTables' ? 'Kalıcı olarak silmek istediğinize emin misiniz?' : 'Silmek istediğinize emin misiniz?',
                text: `${customerFirsName} Adlı Çalışam ${tableType === 'DeletedTables' ? 'kalıcı olarak ' : ''} Silinecektir!`,
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
                        data: { customerId: id, tableType: tableType },
                        url: '/Admin/Customer/Delete/',
                        success: function (data) {
                            const customerResult = jQuery.parseJSON(data);
                            if (customerResult.ResultStatus === 0) {
                                if (tableType === 'DeletedTables') {
                                    Swal.fire(
                                        'Tamamen Silindi!',
                                        `${customerResult.Message}`,
                                        'success'
                                    );
                                }
                                else {
                                    Swal.fire(
                                        'Silindi!',
                                        `${customerResult.Message}`,
                                        'success'
                                    );
                                }
                                if (inUpdate === '1') {
                                    //update controller içindeyiz, sil butonuna tıklandığında şu adrese git
                                    var url_ = '/Admin/Customer/Index?tableType=' + tableType;
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
                                    text: `${customerResult.Message}`,
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
    $('.btn-delete').click(function () {
        var customerId = $(this).attr('data-id');
        var tableType = $(this).attr('data-tableType');
        $.ajax({
            url: '/Admin/Customer/DeleteFromUpdatePage',
            type: 'DELETE',
            data: {
                customerId: customerId,
                tableType: tableType
            },
            success: function (result) {
                // İşlem başarılıysa yapılacak işlemler
            },
            error: function () {
                // Hata durumunda yapılacak işlemler
            }
        });
    });
    $(document).on('click',
        '.btn-undo',
        function (event) {
            event.preventDefault();
            const id = $(this).attr('data-id');
            const tableType = $(this).attr('data-tableType');
            const tableRow = $(`[name="${id}"]`);
            const inUpdate = $(this).attr('data-inUpdate');

            const customerFirsName = tableRow.find('td:eq(1)').text(); 
            const customerLastName = tableRow.find('td:eq(2)').text(); 
            Swal.fire({
                title: tableType === 'DeletedTables' ? 'Silinen Personel Geri Getirilsin Mi??' : 'Silmek istediğinize emin misiniz?',
                text: `${customerFirsName} Adlı Personel Geri Getirilecektir!`,
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
                        data: { customerId: id, tableType: tableType },
                        url: '/Admin/Customer/UndoDelete/',
                        success: function (data) {
                            const customerResult = jQuery.parseJSON(data);
                            if (customerResult.ResultStatus === 0) {
                                    Swal.fire(
                                        'Geri Getirildi!',
                                        `${customerResult.Message}`,
                                        'success'
                                    );
                             
                                if (inUpdate === '1') {
                                    //update controller içindeyiz, sil butonuna tıklandığında şu adrese git
                                    var url_ = '/Admin/Customer/Index?tableType=' + tableType;
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
                                    text: `${customerResult.Message}`,
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