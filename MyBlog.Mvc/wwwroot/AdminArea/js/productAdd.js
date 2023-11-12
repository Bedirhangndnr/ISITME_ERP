$(document).ready(function () {


    var paymentTypesList = document.getElementById("paymentTypesList");
    // İkinci select elementini seçiyoruz
    var associatedInstitutionsList = document.getElementById("associatedInstitutionsList");
    var subModelsList = document.getElementById("subModelsList");
    var serialNumber = document.getElementById("serialNumber");
    const isAdd = document.getElementById("isAdd").value;
    if (isAdd == "true") {
        serialNumber.value = "";
    }
    // İlk select elementinin değeri değiştiğinde tetiklenecek olan fonksiyonu tanımlıyoruz
    paymentTypesList.addEventListener("change", function () {
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
                url: '/Admin/Product/LoadModels',
                type: "GET",
                data: { brandId: selectedPaymentTypeId },
                success: function (result) {
                    associatedInstitutionsList.innerHTML = result; // associatedInstitutionsList'i güncelle
                }
            });
        }
    });
    associatedInstitutionsList.addEventListener("change", function () {
        var selectedAssociatedInstitutionId = parseInt(associatedInstitutionsList.value);
        var selectedAssociatedInstitutionText = associatedInstitutionsList.options[associatedInstitutionsList.selectedIndex].text;

        subModelsList.innerHTML = ""; // associatedInstitutionsList'i temizle

        $.ajax({
            url: '/Admin/Product/LoadSubModels',
            type: "GET",
            data: { selectedModelId: selectedAssociatedInstitutionId },
            success: function (result) {
                subModelsList.innerHTML = result; // associatedInstitutionsList'i güncelle
            }
        });
    });

    $(document).on('click',
        '.btn-delete',
        function (event) {
            event.preventDefault();
            const id = $(this).attr('data-id');
            const tableType = $(this).attr('data-tableType');
            const tableRow = $(`[name="${id}"]`);
            const inUpdate = $(this).attr('data-inUpdate');

            const ProductFirsName = tableRow.find('td:eq(1)').text(); // table datadan 2. indexdeki değeri aldık.
            const ProductLastName = tableRow.find('td:eq(2)').text(); // table datadan 2. indexdeki değeri aldık.
            Swal.fire({
                title: tableType === 'DeletedTables' ? 'Kalıcı olarak silmek istediğinize emin misiniz?' : 'Silmek istediğinize emin misiniz?',
                text: `${ProductFirsName} Adlı Ürün ${tableType === 'DeletedTables' ? 'kalıcı olarak ' : ''} Silinecektir!`,
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
                        data: { ProductId: id, tableType: tableType },
                        url: '/Admin/Product/Delete/',
                        success: function (data) {
                            const ProductResult = jQuery.parseJSON(data);
                            if (ProductResult.ResultStatus === 0) {
                                if (tableType === 'DeletedTables') {
                                    Swal.fire(
                                        'Tamamen Silindi!',
                                        `${ProductResult.Message}`,
                                        'success'
                                    );
                                    window.location.href = "/Admin/Product/Index?tableType=" + tableType;
                                }
                                else {
                                    Swal.fire(
                                        'Silindi!',
                                        `${ProductResult.Message}`,
                                        'success'
                                    );
                                    window.location.href = "/Admin/Product/Index?tableType=" + tableType;
                                }
                                if (inUpdate === '1') {
                                    //update controller içindeyiz, sil butonuna tıklandığında şu adrese git
                                    var url_ = '/Admin/Product/Index?tableType=' + tableType;
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
                                    text: `${ProductResult.Message}`,
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

            const ProductFirsName = tableRow.find('td:eq(1)').text();
            const ProductLastName = tableRow.find('td:eq(2)').text();
            Swal.fire({
                title: tableType === 'DeletedTables' ? 'Silinen Ürün Geri Getirilsin Mi??' : 'Silmek istediğinize emin misiniz?',
                text: `${ProductFirsName} Adlı Ürün Geri Getirilecektir!`,
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
                        data: { ProductId: id, tableType: tableType },
                        url: '/Admin/Product/UndoDelete/',
                        success: function (data) {
                            const ProductResult = jQuery.parseJSON(data);
                            if (ProductResult.ResultStatus === 0) {
                                Swal.fire(
                                    'Geri Getirildi!',
                                    `${ProductResult.Message}`,
                                    'success'
                                );

                                if (inUpdate === '1') {
                                    //update controller içindeyiz, sil butonuna tıklandığında şu adrese git
                                    var url_ = '/Admin/Product/Index?tableType=' + tableType;
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
                                    text: `${ProductResult.Message}`,
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