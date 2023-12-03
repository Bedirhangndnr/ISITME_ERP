$(document).ready(function () {

    // Trumbowyg

   

    // Trumbowyg

    // Select2

    $('#categoryList').select2({
        theme: 'bootstrap4',
        placeholder: "Lütfen bir kategori seçiniz...",
        allowClear: true
    });
    $('#customerTypeList').select2({
        theme: 'bootstrap4',
        placeholder: "Hasta Kategorisi Seçiniz...",
        allowClear: true
    });
    $('#employeeList').select2({
        theme: 'bootstrap4',
        placeholder: "Bir Personel Seçiniz...",
        allowClear: true
    });
    $('#customerList').select2({
        theme: 'bootstrap4',
        placeholder: "Hasta Seçiniz...",
        allowClear: true
    });
    $('#saleStatusesList').select2({
        theme: 'bootstrap4',
        placeholder: "Bir Personel Seçiniz...",
        allowClear: true
    });
    $('#saleTypesList').select2({
        theme: 'bootstrap4',
        placeholder: "Bir Personel Seçiniz...",
        allowClear: true
    });
    $('#productsList').select2({
        theme: 'bootstrap4',
        placeholder: "Bir Personel Seçiniz...",
        allowClear: true
    });
    $('#brandsList').select2({
        theme: 'bootstrap4',
        placeholder: "Bir Geliştiriciye Mesaj Seçiniz...",
        allowClear: true
    });
    $('#productSubGroupsList').select2({
        theme: 'bootstrap4',
        placeholder: "Bir Alt Grup Seçiniz...",
        allowClear: true
    });
    $('#customersList').select2({
        theme: 'bootstrap4',
        placeholder: "Bir Hasta Seçiniz...",
        allowClear: true
    });
    $('#appointmentTypeList').select2({
        theme: 'bootstrap4',
        placeholder: "Bir Alt Grup Seçiniz...",
        allowClear: true
    });
    $('#employeeTypeList').select2({
        theme: 'bootstrap4',
        placeholder: "Bir Personel Tipi Seçiniz...",
        allowClear: true
    });

    // Select2


    // jQuery UI - DatePicker

    $(function () {
        $("#datepicker").datepicker({
            closeText: "kapat",
            prevText: "&#x3C;geri",
            nextText: "ileri&#x3e",
            currentText: "bugün",
            monthNames: ["Ocak", "Şubat", "Mart", "Nisan", "Mayıs", "Haziran",
                "Temmuz", "Ağustos", "Eylül", "Ekim", "Kasım", "Aralık"],
            monthNamesShort: ["Oca", "Şub", "Mar", "Nis", "May", "Haz",
                "Tem", "Ağu", "Eyl", "Eki", "Kas", "Ara"],
            dayNames: ["Pazar", "Pazartesi", "Salı", "Çarşamba", "Perşembe", "Cuma", "Cumartesi"],
            dayNamesShort: ["Pz", "Pt", "Sa", "Ça", "Pe", "Cu", "Ct"],
            dayNamesMin: ["Pz", "Pt", "Sa", "Ça", "Pe", "Cu", "Ct"],
            weekHeader: "Hf",
            dateFormat: "dd.mm.yy",
            firstDay: 1,
            isRTL: false,
            showMonthAfterYear: false,
            yearSuffix: "",
            duration: 100,
            showAnim: "drop",
            showOptions:{direction:"down"},
        });
    });


    // jQuery UI - DatePicker
});