$(document).ready(function () {
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
        placeholder: "Bir Alt Grup Seçiniz...",
        allowClear: true,
        dropdownParent: $('#employeeList').parent()
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
        placeholder: "Bir Marka Seçiniz...",
        allowClear: true
    });
    $('#productSubGroupsList').select2({
        theme: 'bootstrap4',
        placeholder: "Bir Alt Grup Seçiniz...",
        allowClear: true
    });
    $('#customersList').select2({
        theme: 'bootstrap4',
        placeholder: "Bir Alt Grup Seçiniz...",
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
});