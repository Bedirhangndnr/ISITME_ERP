﻿$(document).ready(function () {
    

    const dataTable = $('#expensesTable').DataTable({
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
        },
        order: [[4, 'desc']]
    });



















    // Area Chart Example
    var ctx = document.getElementById("myAreaChart");

    $.get("/Admin/Expense/GetChartIncomeAndOutcomeData", function (data) {
        var incomeData_ = data.IncomeData;
        var outcomeData_ = data.OutcomeData;
        console.log(incomeData_);
        console.log(outcomeData_);
        var currentDate = new Date(); // Get the current date
        var labels = []; // Etiketleri depolamak için bir dizi oluştur

        // Son 30 gün için etiketleri oluştur
        for (var i = 29; i >= 0; i--) {
            var date = new Date(currentDate.getTime() - i * 24 * 60 * 60 * 1000); // Geçerli tarihten i günü çıkar
            var monthIndex = date.getMonth(); // Ayın indeksini al
            var day = date.getDate(); // Ayın gününü al

            var monthNames = ["Oca", "Şub", "Mar", "Nis", "May", "Haz", "Tem", "Ağu", "Eyl", "Eki", "Kas", "Ara"];
            var month = monthNames[monthIndex]; // Ayın adını al

            var label = month + " " + day; // Etiketi "AA GG" şeklinde biçimlendir
            labels.push(label);
        }
        var myLineChart = new Chart(ctx, {
            type: 'line',
            data: {
                labels: labels,
                datasets: [
                    {
                        label: "Gelir",
                        lineTension: 0.3,
                        backgroundColor: "rgba(2,117,216,0.2)",
                        borderColor: "rgba(2,117,216,1)",
                        pointRadius: 5,
                        pointBackgroundColor: "rgba(2,117,216,1)",
                        pointBorderColor: "rgba(255,255,255,0.8)",
                        pointHoverRadius: 5,
                        pointHoverBackgroundColor: "rgba(2,117,216,1)",
                        pointHitRadius: 50,
                        pointBorderWidth: 2,
                        data: incomeData_,
                    },
                    {
                        label: "Gider",
                        lineTension: 0.3,
                        backgroundColor: "rgba(255,0,0,0.2)",
                        borderColor: "rgba(255,0,0,1)",
                        pointRadius: 5,
                        pointBackgroundColor: "rgba(255,0,0,1)",
                        pointBorderColor: "rgba(255,255,255,0.8)",
                        pointHoverRadius: 5,
                        pointHoverBackgroundColor: "rgba(255,0,0,1)",
                        pointHitRadius: 50,
                        pointBorderWidth: 2,
                        data: outcomeData_,
                    }
                ],
            },
            options: {
                scales: {
                    xAxes: [{
                        time: {
                            unit: 'date'
                        },
                        gridLines: {
                            display: false
                        },
                        ticks: {
                            maxTicksLimit: 7
                        }
                    }],
                    yAxes: [{
                        ticks: {
                            min: 0,
                            max: 40000,
                            maxTicksLimit: 5
                        },
                        gridLines: {
                            color: "rgba(0, 0, 0, .125)",
                        }
                    }],
                },
                legend: {
                    display: true
                }
            }
        });
    });
});




