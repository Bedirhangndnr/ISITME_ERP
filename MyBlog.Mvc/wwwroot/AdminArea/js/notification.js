$(document).ready(function () {

    function formatDate(date) {
        var day = date.getDate().toString();
        var month = String(date.getMonth() + 1).padStart(2, '0');
        var year = date.getFullYear();
        var formattedDay = (day.startsWith('0') ? day.substring(1) : day);
        var formattedDate = formattedDay + '.' + month + '.' + year;

        return formattedDate;
    }

    function getNextWeek() {
        var today = new Date();
        var nextWeek = new Date(today.getTime() + (7 * 24 * 60 * 60 * 1000));
        var formattedToday = formatDate(today);
        var formattedNextWeek = formatDate(nextWeek);

        return '^' + formattedToday + '.*' + formattedNextWeek + '$';
    }
    const tableType = document.getElementById("tableType").value;
    /* DataTables start here. */

    const dataTable = $('#notificationsTable').DataTable({

        order: [[1, 'desc'], [2, 'desc']],

        dom:
            "<'row'<'col-sm-3'l><'col-sm-6 text-center'B><'col-sm-3'f>>" +
            "<'row'<'col-sm-12'tr>>" +
            "<'row'<'col-sm-5'i><'col-sm-7'p>>",
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
            },
        },
    });
    function setRowColors() {
        const table = $('#NotificationsTable').DataTable();
        const today = new Date();
        const formattedToday = formatDate(today);
        const parts = formattedToday.split(".");
        const todayDay = parseInt(parts[0]);
        const todayMonth = parseInt(parts[1]);
        const todayYear = parseInt(parts[2]);
        const currentHour = today.getHours();
        const currentMinute = today.getMinutes();
        const currentTime = `${currentHour}:${currentMinute}`;

        table.rows().every(function () {
            const rowData = this.data();
            const date = rowData[1]; // Tarih sütununun indeksi
            const time = rowData[2]; // Saat sütununun indeksi
            const NotificationDate = formatNotificationDate(date); // Tarihi formatlayarak al
            const parts = NotificationDate.split(".");
            const NotificationDay = parseInt(parts[2]);
            const NotificationMonth = parseInt(parts[1]);
            const NotificationYear = parseInt(parts[0]);
            const rowNode = this.node();
            const todayNotification = new Date(todayYear, todayMonth - 1, todayDay); // today ve Notification tarihlerini birleştir

            const NotificationDateTime = new Date(NotificationYear, NotificationMonth - 1, NotificationDay); // Notification tarihini oluştur

            if (NotificationDateTime.getTime() === todayNotification.getTime()) {
                if (time <= currentTime) { // bugün ama randevu saati geçmiş
                    $(rowNode).find('td:eq(1)').addClass('text-warning'); // Tarih sütununun rengini koyu turuncu yapmak için 'text-dark' sınıfını ekle
                    $(rowNode).find('td:eq(2)').addClass('text-warning'); // Saat sütununun rengini koyu turuncu yapmak için 'text-dark' sınıfını ekle
                } else { //bugün ve randevu saati geçmemiş
                    $(rowNode).find('td:eq(1)').addClass('text-success'); // Tarih sütununun rengini mavi yapmak için 'text-primary' sınıfını ekle
                    $(rowNode).find('td:eq(2)').addClass('text-success'); // Saat sütununun rengini mavi yapmak için 'text-primary' sınıfını ekle
                }
            } else if (compareDates(date, formattedToday) < 0) { //geçmiş günler
                $(rowNode).find('td:eq(1)').addClass('text-danger'); // Tarih sütununun rengini kırmızı yapmak için 'text-danger' sınıfını ekle
                $(rowNode).find('td:eq(2)').addClass('text-danger'); // Saat sütununun rengini kırmızı yapmak için 'text-danger' sınıfını ekle
            } else { //gelecek günler 
                $(rowNode).find('td:eq(1)').addClass('text-primary'); // Tarih sütununun rengini mavi yapmak için 'text-primary' sınıfını ekle
                $(rowNode).find('td:eq(2)').addClass('text-primary'); // Saat sütununun rengini mavi yapmak için 'text-primary' sınıfını ekle
            }
        });
    }

    // İki tarihi karşılaştırmak için işlev
    function compareDates(date1, date2) {
        const [day1, month1, year1] = date1.split('.');
        const [day2, month2, year2] = date2.split('.');
        return new Date(`${year1}-${month1}-${day1}`) - new Date(`${year2}-${month2}-${day2}`);
    }

    // Tarihi "yyyy.mm.dd" formatına dönüştürmek için işlev
    function formatNotificationDate(date) {
        const [day, month, year] = date.split('.');
        return `${year}.${month}.${day}`;
    }

    // Bir saat dizgisinden saat ve dakika değerlerini elde etmek için işlev
    function getTimeFromString(timeString) {
        const [hour, minute] = timeString.split(':');
        return { hour: parseInt(hour), minute: parseInt(minute) };
    }

    // Bir saat değerinin geçmiş bir saat olup olmadığını kontrol etmek için işlev
    function isPastTime(time, date) {
        const currentTime = { hour: date.getHours(), minute: date.getMinutes() };
        return (
            time.hour < currentTime.hour ||
            (time.hour === currentTime.hour && time.minute < currentTime.minute)
        );
    }

    // Renkleri ayarla işlevini çağır
    setRowColors();








    $(document).on('click',
        '.btn-delete',
        function (event) {
            event.preventDefault();
            const id = $(this).attr('data-id');
            const tableType = $(this).attr('data-tableType');
            const tableRow = $(`[name="${id}"]`);
            const inUpdate = $(this).attr('data-inUpdate');

            const NotificationFirsName = tableRow.find('td:eq(1)').text(); // table datadan 2. indexdeki değeri aldık.
            const NotificationLastName = tableRow.find('td:eq(2)').text(); // table datadan 2. indexdeki değeri aldık.
            
                    $.ajax({
                        type: 'POST',
                        dataType: 'json',
                        data: { NotificationId: id, tableType: "DeletedTables" },
                        url: '/Admin/Notification/Delete/',
                        success: function (data) {
                            const NotificationResult = jQuery.parseJSON(data);
                            if (NotificationResult.ResultStatus === 0) {
                                if (tableType === 'DeletedTables') {
                                    Swal.fire(
                                        'Tamamen Silindi!',
                                        `${NotificationResult.Message}`,
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
                                    text: `${NotificationResult.Message}`,
                                });
                            }
                        },
                        error: function (err) {
                            console.log(err);
                            toastr.error(`${err.responseText}`, "Hata!");
                        }
                    });
        });
    $('.btn-delete-from-update-page').click(function () {
        var NotificationId = $(this).attr('data-id');
        var tableType = $(this).attr('data-tableType');
        $.ajax({
            url: '/Admin/Notification/DeleteFromUpdatePage',
            type: 'DELETE',
            data: {
                NotificationId: NotificationId,
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

            const NotificationFirsName = tableRow.find('td:eq(1)').text();
            const NotificationLastName = tableRow.find('td:eq(2)').text();
            Swal.fire({
                title: tableType === 'DeletedTables' ? 'Silinen Personel Geri Getirilsin Mi??' : 'Silmek istediğinize emin misiniz?',
                text: `${NotificationFirsName} Adlı Personel Geri Getirilecektir!`,
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
                        data: { NotificationId: id, tableType: tableType },
                        url: '/Admin/Notification/UndoDelete/',
                        success: function (data) {
                            const NotificationResult = jQuery.parseJSON(data);
                            if (NotificationResult.ResultStatus === 0) {
                                Swal.fire(
                                    'Geri Getirildi!',
                                    `${NotificationResult.Message}`,
                                    'success'
                                );

                                if (inUpdate === '1') {
                                    //update controller içindeyiz, sil butonuna tıklandığında şu adrese git
                                    var url_ = '/Admin/Notification/Index?tableType=' + tableType;
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
                                    text: `${NotificationResult.Message}`,
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