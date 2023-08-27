$(document).ready(function () {

    const tableType = document.getElementById("tableType").value;
    /* DataTables start here. */

    const dataTable = $('#paymentsTable').DataTable({
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
                        url: '/Admin/Payment/GetAllPayments/',
                        contentType: "application/json",
                        beforeSend: function () {
                            $('#paymentsTable').hide();
                            $('.spinner-border').show();
                        },
                        success: function (data) {
                            const paymentListWithNamesDto = jQuery.parseJSON(data);
                            dataTable.clear();
                            console.log(paymentListWithNamesDto);
                            if (paymentListWithNamesDto.Data.ResultStatus === 0) {
                                $.each(paymentListWithNamesDto.Data.PaymentListWithRelatedTables.$values,
                                    function (index, payment) {
                                        const paymentDate = new Date(payment.Date);
                                        const newTableRow = dataTable.row.add([
                                            payment.Id,
                                            payment.AmountPaid,
                                            payment.EmployeeId+"|"+ payment.EmployeeName,
                                            payment.CustomerId + "|" + payment.CustomerName,
                                            payment.PaymentTypeTitle,
                                            "özellk kalkacak.",
                                            "özellk kalkacak.",
                                            payment.Description == null ? "Not Eklenmemiş" : (payment.Description.length > 75 ? payment.Description.substring(0, 75) : payment.Description),
                                            `
                                                <div class="form-group row justify-content-center">
                                                <button class="btn btn-danger btn-sm btn-delete" data-id="${payment.Id}" data-tableType=${tableType}><span class="fas fa-minus-circle"></span></button>
                                                ${tableType === 'DeletedTables' ? '<a class="btn btn-warning btn-sm btn-undo" data-id="' + payment.Id + '"><span class="fas fa-undo"></span></a>' : ''}
                                                 <a title="Tricks Site" class="btn btn-primary btn-sm btn-update" data-id="${payment.Id}" href="/Admin/Payment/Update/${payment.Id}?tableType=${tableType}"><span class="fas fa-edit"></span></a>
                                                </div>
                                            `
                                        ]).node();
                                        const jqueryTableRow = $(newTableRow);
                                        jqueryTableRow.attr('name', `${payment.Id}`);
                                    });
                                dataTable.draw();
                                $('.spinner-border').hide();
                                $('#paymentsTable').fadeIn(1400);
                            } else {
                                toastr.error(`${paymentListWithNamesDto.Data.Message}`, 'İşlem Başarısız!');
                            }
                        },
                        error: function (err) {
                            console.log(err);
                            $('.spinner-border').hide();
                            $('#paymentsTable').fadeIn(1000);
                            toastr.error(`${err.responseText}`, 'Hata!');
                        }
                    });
                }
            },
            {
                extend: 'excelHtml5',
                text: 'İndir | Excel',
                filename: 'Ödemeler',
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

    /* DataTables end here */

    /* Ajax POST / Deleting a User starts from here */

    $(document).on('click',
        '.btn-delete',
        function (event) {
            event.preventDefault();
            const id = $(this).attr('data-id');
            const tableType = $(this).attr('data-tableType');
            const tableRow = $(`[name="${id}"]`);
            const inUpdate = $(this).attr('data-inUpdate');

            const paymentFirsName = tableRow.find('td:eq(1)').text(); // table datadan 2. indexdeki değeri aldık.
            const paymentLastName = tableRow.find('td:eq(2)').text(); // table datadan 2. indexdeki değeri aldık.
            Swal.fire({
                title: tableType === 'DeletedTables' ? 'Kalıcı olarak silmek istediğinize emin misiniz?' : 'Silmek istediğinize emin misiniz?',
                text: `${paymentFirsName} Adlı Çalışam ${tableType === 'DeletedTables' ? 'kalıcı olarak ' : ''} Silinecektir!`,
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
                        data: { paymentId: id, tableType: tableType },
                        url: '/Admin/Payment/Delete/',
                        success: function (data) {
                            const paymentResult = jQuery.parseJSON(data);
                            if (paymentResult.ResultStatus === 0) {
                                if (tableType === 'DeletedTables') {
                                    Swal.fire(
                                        'Tamamen Silindi!',
                                        `${paymentResult.Message}`,
                                        'success'
                                    );
                                }
                                else {
                                    Swal.fire(
                                        'Silindi!',
                                        `${paymentResult.Message}`,
                                        'success'
                                    );
                                }
                                if (inUpdate === '1') {
                                    //update controller içindeyiz, sil butonuna tıklandığında şu adrese git
                                    var url_ = '/Admin/Payment/Index?tableType=' + tableType;
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
                                    text: `${paymentResult.Message}`,
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
    $('.btn-delete-from-update-page').click(function () {
        var paymentId = $(this).attr('data-id');
        var tableType = $(this).attr('data-tableType');
        $.ajax({
            url: '/Admin/Payment/DeleteFromUpdatePage',
            type: 'DELETE',
            data: {
                paymentId: paymentId,
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

            const paymentFirsName = tableRow.find('td:eq(1)').text();
            const paymentLastName = tableRow.find('td:eq(2)').text();
            Swal.fire({
                title: tableType === 'DeletedTables' ? 'Silinen Personel Geri Getirilsin Mi??' : 'Silmek istediğinize emin misiniz?',
                text: `${paymentFirsName} Adlı Personel Geri Getirilecektir!`,
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
                        data: { paymentId: id, tableType: tableType },
                        url: '/Admin/Payment/UndoDelete/',
                        success: function (data) {
                            const paymentResult = jQuery.parseJSON(data);
                            if (paymentResult.ResultStatus === 0) {
                                Swal.fire(
                                    'Geri Getirildi!',
                                    `${paymentResult.Message}`,
                                    'success'
                                );

                                if (inUpdate === '1') {
                                    //update controller içindeyiz, sil butonuna tıklandığında şu adrese git
                                    var url_ = '/Admin/Payment/Index?tableType=' + tableType;
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
                                    text: `${paymentResult.Message}`,
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
    var paymentTypesList = document.getElementById("paymentTypesList");
    // İkinci select elementini seçiyoruz
    var associatedInstitutionsList = document.getElementById("associatedInstitutionsList");

    // İlk select elementinin değeri değiştiğinde tetiklenecek olan fonksiyonu tanımlıyoruz
    paymentTypesList.addEventListener("change", function () {
        // İlk select elementinin seçili değerini alıyoruz
        var selectedPaymentTypeId = paymentTypesList.value;

        // İkinci select elementinin options'larını güncelliyoruz
        associatedInstitutionsList.innerHTML = "";
        var selectedPaymentTypeId = $(this).val(); // Seçilen PaymentTypeId değerini al

        // AssociatedInstitutionsId select listesini güncelle
        $.ajax({
            url: '/Admin/Payment/LoadAssociatedInstitutions',
            type: "GET",
            data: { paymentTypeId: selectedPaymentTypeId },
            success: function (result) {
                $("#associatedInstitutionsList").html(result); // Yeni seçenekleri yükle    
            }
        });
    });

});