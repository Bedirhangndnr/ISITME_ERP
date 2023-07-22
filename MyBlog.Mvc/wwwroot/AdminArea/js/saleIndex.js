$(document).ready(function () {

    const tableType = document.getElementById("tableType").value;
    /* DataTables start here. */

    const dataTable = $('#salesTable').DataTable({
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
                        url: '/Admin/Sale/GetAllSales/',
                        contentType: "application/json",
                        beforeSend: function () {
                            $('#salesTable').hide();
                            $('.spinner-border').show();
                        },
                        success: function (data) {
                            const saleListWithNamesDto = jQuery.parseJSON(data);
                            dataTable.clear();
                            console.log(saleListWithNamesDto);
                            if (saleListWithNamesDto.Data.ResultStatus === 0) {
                                $.each(saleListWithNamesDto.Data.SaleListWithRelatedTables.$values,
                                    function (index, sale) {
                                        const saleDate = new Date(sale.Date);
                                        const newTableRow = dataTable.row.add([
                                            sale.Id,
                                            sale.EmployeeFirstName,
                                            sale.CustomerFirstName,
                                            sale.SaleTypeName,
                                            sale.SaleStatusName,
                                            sale.ProductName,
                                            sale.Amount,
                                            //sale.Note == null ? "Not Eklenmemiş" : (sale.Note.length > 75 ? sale.Note.substring(0, 75) : sale.Note),
                                            `
                                                <div class="form-group row justify-content-center">
                                                <button class="btn btn-danger btn-sm btn-delete" data-id="${sale.Id}" data-tableType=${tableType}><span class="fas fa-minus-circle"></span></button>
                                                ${tableType === 'DeletedTables' ? '<a class="btn btn-warning btn-sm btn-undo" data-id="' + sale.Id + '"><span class="fas fa-undo"></span></a>' : ''}
                                                 <a title="Tricks Site" class="btn btn-primary btn-sm btn-update" data-id="${sale.Id}" href="/Admin/Sale/Update/${sale.Id}?tableType=${tableType}"><span class="fas fa-edit"></span></a>
                                                </div>
                                            `
                                        ]).node();
                                        const jqueryTableRow = $(newTableRow);
                                        jqueryTableRow.attr('name', `${sale.Id}`);
                                    });
                                dataTable.draw();
                                $('.spinner-border').hide();
                                $('#salesTable').fadeIn(1400);
                            } else {
                                toastr.error(`${saleListWithNamesDto.Data.Message}`, 'İşlem Başarısız!');
                            }
                        },
                        error: function (err) {
                            console.log(err);
                            $('.spinner-border').hide();
                            $('#salesTable').fadeIn(1000);
                            toastr.error(`${err.responseText}`, 'Hata!');
                        }
                    });
                }
            },
            {
                extend: 'excelHtml5',
                text: 'Export to Excel',
                filename: 'Satışlar',
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

            const saleFirsName = tableRow.find('td:eq(1)').text(); // table datadan 2. indexdeki değeri aldık.
            const saleLastName = tableRow.find('td:eq(2)').text(); // table datadan 2. indexdeki değeri aldık.
            Swal.fire({
                title: tableType === 'DeletedTables' ? 'Kalıcı olarak silmek istediğinize emin misiniz?' : 'Silmek istediğinize emin misiniz?',
                text: `${saleFirsName} Adlı Çalışam ${tableType === 'DeletedTables' ? 'kalıcı olarak ' : ''} Silinecektir!`,
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
                        data: { saleId: id, tableType: tableType },
                        url: '/Admin/Sale/Delete/',
                        success: function (data) {
                            const saleResult = jQuery.parseJSON(data);
                            if (saleResult.ResultStatus === 0) {
                                if (tableType === 'DeletedTables') {
                                    Swal.fire(
                                        'Tamamen Silindi!',
                                        `${saleResult.Message}`,
                                        'success'
                                    );
                                }
                                else {
                                    // Silme işlemi tamamlandıktan sonra başarılı mesajı ve IsSold değerini güncelleme sorusunu işle
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
                                    text: `${saleResult.Message}`,
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
        var saleId = $(this).attr('data-id');
        var tableType = $(this).attr('data-tableType');
        $.ajax({
            url: '/Admin/Sale/DeleteFromUpdatePage',
            type: 'DELETE',
            data: {
                saleId: saleId,
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

            const saleFirsName = tableRow.find('td:eq(1)').text();
            const saleLastName = tableRow.find('td:eq(2)').text();
            Swal.fire({
                title: tableType === 'DeletedTables' ? 'Silinen Personel Geri Getirilsin Mi??' : 'Silmek istediğinize emin misiniz?',
                text: `${saleFirsName} Adlı Personel Geri Getirilecektir!`,
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
                        data: { saleId: id, tableType: tableType },
                        url: '/Admin/Sale/UndoDelete/',
                        success: function (data) {
                            const saleResult = jQuery.parseJSON(data);
                            if (saleResult.ResultStatus === 0) {
                                Swal.fire(
                                    'Geri Getirildi!',
                                    `${saleResult.Message}`,
                                    'success'
                                );

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
                                    text: `${saleResult.Message}`,
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