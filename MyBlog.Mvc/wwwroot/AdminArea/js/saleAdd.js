$(document).ready(function () {
    var urunler = [];
    $(document).ready(function () {
        $('#productsList1').select2();
        $('#customersList1').select2();
        $('#saleTypesList1').select2();
        $('#EmployeeList1').select2();
        $('#saleStatusesList1').select2();
        $('#Amount').change(function () {
            // Amount alanının değerini al
            var amountValue = parseFloat($(this).val()) || 0;

            // Eğer Amount değeri 0 veya boş ise
            if (amountValue <= 0) {
                // satildiMi checkbox'ını devre dışı bırak ve işaretini kaldır
                $('#checkBox').prop('disabled', true).prop('checked', false);
            } else {
                // Aksi halde, satildiMi checkbox'ını etkinleştir
                $('#checkBox').prop('disabled', false);
            }
        });

        // Sayfa yüklendiğinde ilk kontrolü yapmak için
        $('#Amount').trigger('change');
    });
    $(document).ready(function () {
        var toplamTutar = 0;
        var toplamSGKTutari = 0;
        var kaporaTutari = 0;
        $('#btnUrunEkle').prop('disabled', true);
        //$('#btnTumunuEkle').prop('disabled', true);
        function checkUrunEkleButonu() {
            var urunId = $('#productsList1').val();
            var urunAdi = $('#productsList1 option:selected').text();
            var fiyat = $('#Amount').val();
            var sgkAmount = $('#sgkListList1').val();
            var sgk = $('#Amount').val();
            var miktar = $('#Quantity').val();
            var customerId = $('#customersList1').val();
            var saleTypeId = $('#saleTypesList1').val();
            var saleStatusId = $('#saleStatusesList1').val();
            var employeeId = $('#EmployeeList1').val();
            var description = $('#Description').val();
            var downPayment = $('#DownPayment').val(); // Açıklama


            if ((customerId && saleStatusId && employeeId) && (sgkAmount > 0 || fiyat > 0 || downPayment > 0)) {
                $('#btnUrunEkle').prop('disabled', false);
            } else {
                $('#btnUrunEkle').prop('disabled', true);
            }
        }
        $('#productsList1, #Amount, #Quantity, #customersList1, #saleTypesList1, #saleStatusesList1, #EmployeeList1, #Description, #DownPayment').change(checkUrunEkleButonu);
        $('#btnUrunEkle').click(function () {
            var girilenKapora = parseFloat($('#DownPayment').val());


            checkUrunEkleButonu();

            var urunId = $('#productsList1').val(); // Ürün ID'si
            var urunAdi = $('#productsList1 option:selected').text();
            var miktar = $('#Quantity').val(); // Miktar
            var description = $('#Description').val(); // Açıklama
            var downPayment = parseFloat($('#DownPayment').val()) || 0; // Açıklama
            var isDelivered = $('#checkBox').is(':checked'); // Boolean değer olduğu için dönüşüm gerekmez
            var sgkAmount = parseInt($('#sgkListList1').val()) || 0; // SGK miktarını integer'a çevir, değer yoksa 0 ata
            var sgkId = $('#sgkListList1').val(); // SGK miktarını integer'a çevir, değer yoksa 0 ata
            var fiyat = parseFloat($('#Amount').val()) || 0; // Fiyatı integer'a çevir, değer yoksa 0 ata
            var customerId = parseInt($('#customersList1').val()); // Müşteri ID'sini integer'a çevir
            var saleTypeId = parseInt($('#saleTypesList1').val()); // Satış Tipi ID'sini integer'a çevir
            var saleStatusId = parseInt($('#saleStatusesList1').val()); // Satış Durumu ID'sini integer'a çevir
            var employeeId = parseInt($('#EmployeeList1').val()); // Personel ID'sini integer'a çevir
            var deliveryDateString = $('#datetimepicker').val();
            let deliveryDate = null; // JavaScript'te değişken tanımlama

            if (deliveryDateString) { // deliveryDateString doluysa
                let parts = deliveryDateString.split(' ');
                let dateParts = parts[0].split('.');
                let timeParts = parts[1].split(':');
                // JavaScript Date objesi, ayı 0'dan başlayarak saydığı için dateParts[1] - 1 yapılır
                deliveryDate = new Date(dateParts[2], dateParts[1] - 1, dateParts[0], timeParts[0], timeParts[1]);
            }


            // Yeni bir Date nesnesi oluşturuyoruz.
            // JavaScript'in Date constructor'ı ayı "0" ile başlayarak alır, bu yüzden ay değerinden 1 çıkarıyoruz.
         
            if (!(urunId > 0)) {
                urunId = -1;
            }

            var satis = {
                IsDelivered: isDelivered,
                SgkAmount: sgkAmount,
                DownPayment: downPayment,
                SgkId: sgkId,
                AmountOfSgk: sgkAmount,
                SgkId: sgkAmount,
                ProductName: urunAdi,
                ProductId: urunId, // Ürün ID'si zaten uygun formatta alınmış olmalı, gerekirse parseInt(urunId) kullanın
                Amount: fiyat,
                CustomerId: customerId,
                SaleTypeId: saleTypeId,
                SaleStatusId: saleStatusId,
                EmployeeId: employeeId,
                Note: description,
                DeliveryDate: deliveryDate
            };
            urunler.push(satis);
            var isProduct = $('#productsList1 option:selected').data('isproduct'); // Bu değer sunucudan gelmelidir
            if (isProduct) {
                $('#productsList1 option[value=' + urunId + ']').remove();
            }
            urunListesiniGuncelle();
            checkUrunEkleButonu();

        });

        // Ürün listesini güncelleme fonksiyonu
        function urunListesiniGuncelle() {
            var listeHtml = '';
            toplamTutar = 0;
            urunler.forEach(function (urun, index) {
                // Eğer urun.Amount null ise 0 olarak kabul et, değilse parseFloat ile dönüştür
                var amount = urun.Amount == "" ? 0 : parseFloat(urun.Amount);
                toplamTutar += amount;
                if (amount > 0) {
                    listeHtml += '<div class="urun-listesi-item">' +
                        (index + 1) + '. ' + urun.ProductName + ' ürününe ait ' + toplamTutar + ' TL\'lik satış eklendi. ' +
                        '<button class="urun-cikar-buton" onclick="urunSil(' + index + ')">Çıkar</button>' +
                        '</div>';
                }
                else if (kaporaTutari >= 0) {
                    listeHtml += '<div class="urun-listesi-item">' +
                        (index + 1) + '. ' + kaporaTutari + ' TL\ kaporanın alındığı ön satış eklendi. ' +
                        '<button class="urun-cikar-buton" onclick="urunSil(' + index + ')">Çıkar</button>' +
                        '</div>';
                }


            });
            if (urunler.length !== 0) {
                var girilenKapora = parseFloat($('#DownPayment').val()) || 0;
                if (girilenKapora > 0 && kaporaTutari === 0) {
                    kaporaTutari = girilenKapora; // Kapora tutarını sakla
                    $('#DownPayment').prop('disabled', true); // Kapora alanını devre dışı bırak
                    $('#DownPayment').val(""); // Kapora alanını sıfırla
                }
            }
            if (urunler.length === 0) {
                $('#DownPayment').prop('disabled', false);
                $('#DownPayment').val("");
            }
            $('#urunListesi').html(listeHtml);
            $('#toplamTutar').text('Toplam Satış Tutarı: ' + toplamTutar + ' TL');
            checkUrunEkleButonu();
            checkTumunuEkleButonu();
        }


        // Ürün silme fonksiyonu
        // Ürün silme fonksiyonu
        window.urunSil = function (index) {
            var silinenUrun = urunler[index];
            urunler.splice(index, 1);
            urunListesiniGuncelle();

            // Silinen ürünü select listesine geri ekle
            $('#productsList1').append(new Option(silinenUrun.ProductName, silinenUrun.ProductId));
        };

        if (kaporaTutari > 0) {
            $('#DownPayment').val(kaporaTutari).prop('disabled', true); // Kapora tutarını göster ve devre dışı bırak
        }
        // Tüm ürünleri ekleme fonksiyonu

        $('#btnTumunuEkle').click(function () {
            var data = {
                SaleAddViewModelList: urunler,
                TableType: 'NonDeletedTables',
            };
            $.ajax({
                url: '/Admin/Sale/Add/', // Sunucu URL'sini doğru şekilde belirtin
                type: 'POST',
                contentType: 'application/json',
                data: JSON.stringify(data),
                success: function (response) {

                    Swal.fire(
                        'Başarılı!',
                        `Satış Ekleme İşlemi Başarılı`,
                        'success'
                    );
                    window.location.href = "/Admin/Sale/Index?tableType=" + 'NonDeletedTables';
                },
                error: function (err) {
                    Swal.fire({
                        title: "Hata!",
                        text: "Satış ekleme işlemi sırasında bir hata oluştu. Değerleri Kontrol edin.",
                        icon: "error"
                    });
                }
            });
        });
        var urunler = []; // Ürün listesini tutacak dizi

        // "Tümünü Ekle" butonunu kontrol eden fonksiyon
        function checkTumunuEkleButonu() {
            if (urunler.length > 0) {
                $('#btnTumunuEkle').prop('disabled', false);
            } else {
                $('#btnTumunuEkle').prop('disabled', true);
            }
        }

        // Ürün listesini güncelleme fonksiyonu (örnek)


        // Ürün ekleme veya silme gibi işlemler sonrası bu fonksiyonu çağırın
        urunListesiniGuncelle();

        // Başlangıçta "Tümünü Ekle" butonunu kontrol et
        checkTumunuEkleButonu();
    });
    var saleStatusId = parseInt($('#saleStatusesList1').val()); // Satış Durumu ID'sini integer'a çevir


    $(document).on('click',
        '.btn-delete',
        function (event) {
            event.preventDefault(); cccccccccccc
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

$(document).ready(function () {
    flatpickr("#datetimepicker", {
        locale: "tr",
        enableTime: true,
        dateFormat: "d.m.Y H:i",
        time_24hr: true,
        noCalendar: false,
        firstDayOfWeek: 1,
        weekNumbers: true,
        onReady: function (selectedDates, dateStr, instance) {
            const todayButton = document.createElement("button");
            todayButton.type = "button";
            todayButton.innerHTML = "Bugün";
            todayButton.className = "flatpickr-today-button";
            todayButton.addEventListener("click", function () {
                instance.setDate(new Date().setHours(12, 0, 0, 0), true);
            });

            const clearButton = document.createElement("button");
            clearButton.type = "button";
            clearButton.innerHTML = "Temizle";
            clearButton.className = "flatpickr-clear-button";
            clearButton.addEventListener("click", function () {
                instance.clear();
            });

            instance.calendarContainer.appendChild(todayButton);
            instance.calendarContainer.appendChild(clearButton);
        },
        locale: {
            weekdays: {
                shorthand: ["Paz", "Pzt", "Sal", "Çar", "Per", "Cum", "Cmt"],
                longhand: ["Pazar", "Pazartesi", "Salı", "Çarşamba", "Perşembe", "Cuma", "Cumartesi"]
            },
            months: {
                shorthand: ["Oca", "Şub", "Mar", "Nis", "May", "Haz", "Tem", "Ağu", "Eyl", "Eki", "Kas", "Ara"],
                longhand: ["Ocak", "Şubat", "Mart", "Nisan", "Mayıs", "Haziran", "Temmuz", "Ağustos", "Eylül", "Ekim", "Kasım", "Aralık"]
            },
            rangeSeparator: " - "
        }
        // diğer seçenekleri buraya ekleyin
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
});