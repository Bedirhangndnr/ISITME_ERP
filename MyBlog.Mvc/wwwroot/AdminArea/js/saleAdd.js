$(document).ready(function () {


    $(document).on('click',
        '.btn-delete',
        function (event) {
            event.preventDefault();
            const id = $(this).attr('data-id');
            const tableType = $(this).attr('data-tableType');
            const tableRow = $(`[name="${id}"]`);
            const inUpdate = $(this).attr('data-inUpdate');

            const SaleFirsName = tableRow.find('td:eq(1)').text(); // table datadan 2. indexdeki değeri aldık.
            const SaleLastName = tableRow.find('td:eq(2)').text(); // table datadan 2. indexdeki değeri aldık.
            Swal.fire({
                title: tableType === 'DeletedTables' ? 'Kalıcı olarak silmek istediğinize emin misiniz?' : 'Silmek istediğinize emin misiniz?',
                text: `${SaleFirsName} Adlı Satış ${tableType === 'DeletedTables' ? 'kalıcı olarak ' : ''} Silinecektir!`,
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
                        data: { SaleId: id, tableType: tableType },
                        url: '/Admin/Sale/Delete/',
                        success: function (data) {
                            const SaleResult = jQuery.parseJSON(data);
                            if (SaleResult.ResultStatus === 0) {
                                if (tableType === 'DeletedTables') {
                                    Swal.fire(
                                        'Tamamen Silindi!',
                                        `${SaleResult.Message}`,
                                        'success'
                                    );
                                    window.location.href = "/Admin/Sale/Index?tableType=" + tableType;
                                }
                                else {
                                    Swal.fire(
                                        'Silindi!',
                                        `${SaleResult.Message}`,
                                        'success'
                                    );
                                    window.location.href = "/Admin/Sale/Index?tableType=" + tableType;
                                }
                                if (inUpdate === '1') {
                                    //update controller içindeyiz, sil butonuna tıklandığında şu adrese git
                                    var url_ = '/Admin/Sale/Index?tableType=' + tableType;
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
                                    text: `${SaleResult.Message}`,
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

            const SaleFirsName = tableRow.find('td:eq(1)').text();
            const SaleLastName = tableRow.find('td:eq(2)').text();
            Swal.fire({
                title: tableType === 'DeletedTables' ? 'Silinen Satış Geri Getirilsin Mi??' : 'Silmek istediğinize emin misiniz?',
                text: `${SaleFirsName} Adlı Satış Geri Getirilecektir!`,
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
                        data: { SaleId: id, tableType: tableType },
                        url: '/Admin/Sale/UndoDelete/',
                        success: function (data) {
                            const SaleResult = jQuery.parseJSON(data);
                            if (SaleResult.ResultStatus === 0) {
                                Swal.fire(
                                    'Geri Getirildi!',
                                    `${SaleResult.Message}`,
                                    'success'
                                );
                                swal.fire({
                                    title: "Silme işlemi başarılı!",
                                    text: "Ürün Tekrar Satışa Çıkarılsın mı?",
                                    icon: "success",
                                    showCancelButton: true,
                                    confirmButtonColor: "#3085d6",
                                    cancelButtonColor: "#d33",
                                    confirmButtonText: "Evet, güncellemek istiyorum.",
                                    cancelButtonText: "Hayır, güncelleme yapmak istemiyorum."
                                }).then((result) => {
                                    if (result.isConfirmed) {
                                        // Kullanıcı güncelleme yapmayı kabul ettiğinde yapılacak işlemler
                                        // IsSold değerini false olarak güncelle
                                        $.ajax({
                                            url: "/Admin/Sale/UpdateIsSold",
                                            type: "POST",
                                            data: { saleId: id, isSold: !result.value },
                                            success: function (response) {
                                                // Güncelleme işlemi başarılı oldu
                                                Swal.fire({
                                                    title: "Güncelleme işlemi tamamlandı!",
                                                    text: response,
                                                    icon: "success"
                                                });
                                            },
                                            error: function (error) {
                                                // Güncelleme işlemi sırasında bir hata oluştu
                                                Swal.fire({
                                                    title: "Hata!",
                                                    text: "Güncelleme işlemi sırasında bir hata oluştu.",
                                                    icon: "error"
                                                });
                                            }
                                        });
                                    }

                                });

                                if (inUpdate === '1') {
                                    //update controller içindeyiz, sil butonuna tıklandığında şu adrese git
                                    var url_ = '/Admin/Sale/Index?tableType=' + tableType;
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
                                    text: `${SaleResult.Message}`,
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