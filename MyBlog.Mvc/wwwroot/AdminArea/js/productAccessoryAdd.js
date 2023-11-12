$(document).ready(function () {

    var paymentTypesList = document.getElementById("paymentTypesList");
    // İkinci select elementini seçiyoruz
    var associatedInstitutionsList = document.getElementById("associatedInstitutionsList");

    // İlk select elementinin değeri değiştiğinde tetiklenecek olan fonksiyonu tanımlıyoruz
    paymentTypesList.addEventListener("click", function () {
        var selectedPaymentTypeId = parseInt(paymentTypesList.value);
        var selectedPaymentTypeText = paymentTypesList.options[paymentTypesList.selectedIndex].text;

        associatedInstitutionsList.innerHTML = ""; // associatedInstitutionsList'i temizle

        if (selectedPaymentTypeText === "Peşin") {
            var option = document.createElement("option");
            option.value = "yok";
            option.text = "Yok";
            option.selected = true; // Seçili olarak işaretle
            associatedInstitutionsList.appendChild(option);
        } else {
            $.ajax({
                url: '/Admin/ProductAccessory/LoadModels',
                type: "GET",
                data: { brandId: selectedPaymentTypeId },
                success: function (result) {
                    associatedInstitutionsList.innerHTML = result; // associatedInstitutionsList'i güncelle
                }
            });
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

            const ProductAccessoryFirsName = tableRow.find('td:eq(1)').text(); // table datadan 2. indexdeki değeri aldık.
            const ProductAccessoryLastName = tableRow.find('td:eq(2)').text(); // table datadan 2. indexdeki değeri aldık.
            Swal.fire({
                title: tableType === 'DeletedTables' ? 'Kalıcı olarak silmek istediğinize emin misiniz?' : 'Silmek istediğinize emin misiniz?',
                text: `${ProductAccessoryFirsName} Adlı Ürün ${tableType === 'DeletedTables' ? 'kalıcı olarak ' : ''} Silinecektir!`,
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
                        data: { ProductAccessoryId: id, tableType: tableType },
                        url: '/Admin/ProductAccessory/Delete/',
                        success: function (data) {
                            const ProductAccessoryResult = jQuery.parseJSON(data);
                            if (ProductAccessoryResult.ResultStatus === 0) {
                                if (tableType === 'DeletedTables') {
                                    Swal.fire(
                                        'Tamamen Silindi!',
                                        `${ProductAccessoryResult.Message}`,
                                        'success'
                                    );
                                    window.location.href = "/Admin/ProductAccessory/Index?tableType=" + tableType;
                                }
                                else {
                                    Swal.fire(
                                        'Silindi!',
                                        `${ProductAccessoryResult.Message}`,
                                        'success'
                                    );
                                    window.location.href = "/Admin/ProductAccessory/Index?tableType=" + tableType;
                                }
                                if (inUpdate === '1') {
                                    //update controller içindeyiz, sil butonuna tıklandığında şu adrese git
                                    var url_ = '/Admin/ProductAccessory/Index?tableType=' + tableType;
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
                                    text: `${ProductAccessoryResult.Message}`,
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

            const ProductAccessoryFirsName = tableRow.find('td:eq(1)').text();
            const ProductAccessoryLastName = tableRow.find('td:eq(2)').text();
            Swal.fire({
                title: tableType === 'DeletedTables' ? 'Silinen Ürün Geri Getirilsin Mi??' : 'Silmek istediğinize emin misiniz?',
                text: `${ProductAccessoryFirsName} Adlı Ürün Geri Getirilecektir!`,
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
                        data: { ProductAccessoryId: id, tableType: tableType },
                        url: '/Admin/ProductAccessory/UndoDelete/',
                        success: function (data) {
                            const ProductAccessoryResult = jQuery.parseJSON(data);
                            if (ProductAccessoryResult.ResultStatus === 0) {
                                Swal.fire(
                                    'Geri Getirildi!',
                                    `${ProductAccessoryResult.Message}`,
                                    'success'
                                );

                                if (inUpdate === '1') {
                                    //update controller içindeyiz, sil butonuna tıklandığında şu adrese git
                                    var url_ = '/Admin/ProductAccessory/Index?tableType=' + tableType;
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
                                    text: `${ProductAccessoryResult.Message}`,
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
    // jQuery UI - DatePicker
});