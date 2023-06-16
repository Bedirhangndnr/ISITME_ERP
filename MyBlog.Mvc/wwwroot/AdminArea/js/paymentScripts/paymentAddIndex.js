$(document).ready(function () {
    // İlk select elementini seçiyoruz
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
    $('#text-editor').trumbowyg({
        lang: 'tr',
        btns: [
            ['viewHTML'],
            ['undo', 'redo'], // Only supported in Blink browsers
            ['formatting'],
            ['strong', 'em', 'del'],
            ['superscript', 'subscript'],
            ['link'],
            ['insertImage'],
            ['justifyLeft', 'justifyCenter', 'justifyRight', 'justifyFull'],
            ['unorderedList', 'orderedList'],
            ['horizontalRule'],
            ['removeformat'],
            ['fullscreen'],
            ['foreColor', 'backColor'],
            ['emoji'],
            ['fontfamily'],
            ['fontsize']
        ],
        plugins: {
            colors: {
                foreColorList: [
                    'ff0000', '00ff00', '0000ff', '54e346'
                ],
                backColorList: [
                    '000', '333', '555'
                ],
                displayAsList: false
            }
        }
    });

    $(document).on('click',
        '.btn-delete',
        function (event) {
            event.preventDefault();
            const id = $(this).attr('data-id');
            const tableType = $(this).attr('data-tableType');
            const tableRow = $(`[name="${id}"]`);
            const inUpdate = $(this).attr('data-inUpdate');

            const PaymentFirsName = tableRow.find('td:eq(1)').text(); // table datadan 2. indexdeki değeri aldık.
            const PaymentLastName = tableRow.find('td:eq(2)').text(); // table datadan 2. indexdeki değeri aldık.
            Swal.fire({
                title: tableType === 'DeletedTables' ? 'Kalıcı olarak silmek istediğinize emin misiniz?' : 'Silmek istediğinize emin misiniz?',
                text: `${PaymentFirsName} Adlı Çalışam ${tableType === 'DeletedTables' ? 'kalıcı olarak ' : ''} Silinecektir!`,
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
                            const PaymentResult = jQuery.parseJSON(data);
                            if (PaymentResult.ResultStatus === 0) {
                                if (tableType === 'DeletedTables') {
                                    Swal.fire(
                                        'Tamamen Silindi!',
                                        `${PaymentResult.Message}`,
                                        'success'
                                    );
                                    window.location.href = "/Admin/Payment/Index?tableType=" + tableType;
                                }
                                else {
                                    Swal.fire(
                                        'Silindi!',
                                        `${PaymentResult.Message}`,
                                        'success'
                                    );
                                    window.location.href = "/Admin/Payment/Index?tableType=" + tableType;
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
                                    text: `${PaymentResult.Message}`,
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
    $(document).on('click',
        '.btn-undo',
        function (event) {
            event.preventDefault();
            const id = $(this).attr('data-id');
            const tableType = $(this).attr('data-tableType');
            const tableRow = $(`[name="${id}"]`);
            const inUpdate = $(this).attr('data-inUpdate');

            const PaymentFirsName = tableRow.find('td:eq(1)').text();
            const PaymentLastName = tableRow.find('td:eq(2)').text();
            Swal.fire({
                title: tableType === 'DeletedTables' ? 'Silinen Randevu Geri Getirilsin Mi??' : 'Silmek istediğinize emin misiniz?',
                text: `${PaymentFirsName} Adlı Randevu Geri Getirilecektir!`,
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
                            const PaymentResult = jQuery.parseJSON(data);
                            if (PaymentResult.ResultStatus === 0) {
                                Swal.fire(
                                    'Geri Getirildi!',
                                    `${PaymentResult.Message}`,
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
                                    text: `${PaymentResult.Message}`,
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

    //document.getElementById('paymentTypesList').addEventListener('change', function () {
    //    // Seçenek değiştiğinde yapılacak işlemleri buraya yazabilirsiniz
    //    // Örneğin, seçilen değeri almak için:
    //    var selectedValue = this.value;

    //    // İşlemlerinizi burada gerçekleştirin
    //});

});