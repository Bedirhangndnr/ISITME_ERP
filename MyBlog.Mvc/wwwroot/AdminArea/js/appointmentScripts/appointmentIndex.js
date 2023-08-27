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


    const dataTable = $('#appointmentsTable').DataTable({

        order: [[1, 'asc'], [3, 'asc']],

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
                    var formattedToday = formatDate(today);

                    dt.columns(1).search('^' + formattedToday, true, false).draw();
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
                    endDate.setDate(today.getDate() + 7);
                    var formattedEndDate = formatDate(endDate);

                    var dateRange = '^(' + formattedToday;
                    var currentDate = new Date(today);
                    while (currentDate <= endDate) {
                        currentDate.setDate(currentDate.getDate() + 1);
                        var formattedNextDate = formatDate(currentDate);
                        dateRange += '|' + formattedNextDate;

                        if (currentDate.getDate() === 1 && currentDate.getMonth() !== endDate.getMonth()) {
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
                        url: '/Admin/Appointment/GetAllAppointments/',
                        contentType: "application/json",
                        beforeSend: function () {
                            $('#appointmentsTable').hide();
                            $('.spinner-border').show();
                        },
                        success: function (data) {
                            const appointmentListWithNamesDto = jQuery.parseJSON(data);
                            dataTable.clear();
                            console.log(appointmentListWithNamesDto);
                            if (appointmentListWithNamesDto.Data.ResultStatus === 0) {
                                $.each(appointmentListWithNamesDto.Data.AppointmentListWithRelatedTables.$values,
                                    function (index, appointment) {
                                        const appointmentDate = new Date(appointment.Date);
                                        const formattedDate = appointmentDate.toLocaleDateString();
                                        const formattedTime = appointmentDate.toLocaleTimeString([], { hour: '2-digit', minute: '2-digit' });

                                        const newTableRow = dataTable.row.add([
                                            appointment.Id,
                                            formattedDate,
                                            formattedTime,
                                            appointment.CustomerName,
                                            appointment.EmployeeName,
                                            appointment.AppointmentTypeTitle,
                                            appointment.Description,
                                            appointment.IsMade ? "Evet" : "Hayır",
                                            `
                                                <div class="form-group row justify-content-center">
                                                <button class="btn btn-danger btn-sm btn-delete" data-id="${appointment.Id}" data-tableType=${tableType}><span class="fas fa-minus-circle"></span></button>
                                                ${tableType === 'DeletedTables' ? '<a class="btn btn-warning btn-sm btn-undo" data-id="' + appointment.Id + '"><span class="fas fa-undo"></span></a>' : ''}
                                                 <a title="Tricks Site" class="btn btn-primary btn-sm btn-update" data-id="${appointment.Id}" href="/Admin/Appointment/Update/${appointment.Id}?tableType=${tableType}"><span class="fas fa-edit"></span></a>
                                                </div>
                                            `
                                        ]).node();
                                        const jqueryTableRow = $(newTableRow);
                                        jqueryTableRow.attr('name', `${appointment.Id}`);
                                    });
                                dataTable.draw();
                                $('.spinner-border').hide();
                                $('#appointmentsTable').fadeIn(1400);
                                setRowColors();
                            } else {
                                toastr.error(`${appointmentListWithNamesDto.Data.Message}`, 'İşlem Başarısız!');
                            }
                        },
                        error: function (err) {
                            console.log(err);
                            $('.spinner-border').hide();
                            $('#appointmentsTable').fadeIn(1000);
                            toastr.error(`${err.responseText}`, 'Hata!');
                        }
                    });
                }
            },
            {
                extend: 'excelHtml5',
                text: 'İndir | Excel',
                filename: 'Randevular Tablosu',
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
            },
        },
    });
    new $.fn.dataTable.Buttons(dataTable, {
        buttons: [
            {
                extend: 'excelHtml5',
                text: 'Excel\'e Aktar',
                className: 'btn btn-success',
                filename: 'musteriler', // Excel dosyasının adı
            }
        ]
    });

    // Butonu DataTables araç çubuğuna ekleme
    dataTable.buttons().container()
        .appendTo('#appointmentsTable_wrapper .col-sm-6:eq(0)');

    function setRowColors() {
        const table = $('#appointmentsTable').DataTable();
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
            const appointmentDate = formatAppointmentDate(date); // Tarihi formatlayarak al
            const parts = appointmentDate.split(".");
            const appointmentDay = parseInt(parts[2]);
            const appointmentMonth = parseInt(parts[1]);
            const appointmentYear = parseInt(parts[0]);
            const rowNode = this.node();
            const todayAppointment = new Date(todayYear, todayMonth - 1, todayDay); // today ve appointment tarihlerini birleştir

            const appointmentDateTime = new Date(appointmentYear, appointmentMonth - 1, appointmentDay); // Appointment tarihini oluştur

            if (appointmentDateTime.getTime() === todayAppointment.getTime()) {
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
    function formatAppointmentDate(date) {
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

            const appointmentFirsName = tableRow.find('td:eq(1)').text(); // table datadan 2. indexdeki değeri aldık.
            const appointmentLastName = tableRow.find('td:eq(2)').text(); // table datadan 2. indexdeki değeri aldık.
            Swal.fire({
                title: tableType === 'DeletedTables' ? 'Kalıcı olarak silmek istediğinize emin misiniz?' : 'Silmek istediğinize emin misiniz?',
                text: `${appointmentFirsName} Adlı Çalışam ${tableType === 'DeletedTables' ? 'kalıcı olarak ' : ''} Silinecektir!`,
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
                        data: { appointmentId: id, tableType: tableType },
                        url: '/Admin/Appointment/Delete/',
                        success: function (data) {
                            const appointmentResult = jQuery.parseJSON(data);
                            if (appointmentResult.ResultStatus === 0) {
                                if (tableType === 'DeletedTables') {
                                    Swal.fire(
                                        'Tamamen Silindi!',
                                        `${appointmentResult.Message}`,
                                        'success'
                                    );
                                }
                                else {
                                    Swal.fire(
                                        'Silindi!',
                                        `${appointmentResult.Message}`,
                                        'success'
                                    );
                                }
                                if (inUpdate === '1') {
                                    //update controller içindeyiz, sil butonuna tıklandığında şu adrese git
                                    var url_ = '/Admin/Appointment/Index?tableType=' + tableType;
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
                                    text: `${appointmentResult.Message}`,
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
        var appointmentId = $(this).attr('data-id');
        var tableType = $(this).attr('data-tableType');
        $.ajax({
            url: '/Admin/Appointment/DeleteFromUpdatePage',
            type: 'DELETE',
            data: {
                appointmentId: appointmentId,
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

            const appointmentFirsName = tableRow.find('td:eq(1)').text();
            const appointmentLastName = tableRow.find('td:eq(2)').text();
            Swal.fire({
                title: tableType === 'DeletedTables' ? 'Silinen Personel Geri Getirilsin Mi??' : 'Silmek istediğinize emin misiniz?',
                text: `${appointmentFirsName} Adlı Personel Geri Getirilecektir!`,
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
                        data: { appointmentId: id, tableType: tableType },
                        url: '/Admin/Appointment/UndoDelete/',
                        success: function (data) {
                            const appointmentResult = jQuery.parseJSON(data);
                            if (appointmentResult.ResultStatus === 0) {
                                Swal.fire(
                                    'Geri Getirildi!',
                                    `${appointmentResult.Message}`,
                                    'success'
                                );

                                if (inUpdate === '1') {
                                    //update controller içindeyiz, sil butonuna tıklandığında şu adrese git
                                    var url_ = '/Admin/Appointment/Index?tableType=' + tableType;
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
                                    text: `${appointmentResult.Message}`,
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