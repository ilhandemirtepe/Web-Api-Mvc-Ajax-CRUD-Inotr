


FirmaListe();

function FirmaListe() {
    $.ajax({
        type: "GET",
        url: "Firma/FirmaListe",
        dataType: "json",
        contentType: "application/json; charset=utf-8",
        success: function (response) {


        }
    });
}
$(document).ready(function () {
    $('#illerID').change(function () {

        $.post('/Firma/illereGoreilceleriGetir', { Idil: $('#illerID').val() }, function (data) {
            var ilceler = "";
            for (var i = 0; i < data.length; i++) {
                ilceler = ilceler + '<option value=' + data[i].Value + '>' + data[i].Text + '</option>';
            }
            console.log(data);
            $('#ilceListesiID').html(ilceler);
        });
    });
});




function FirmaBilgisiDuzenle(ID) {
    var firma = {
        Adi: $("#Adi").val(),
        Email: $("#Email").val(),
        Telefon: $("#Telefon").val(),
        Fax: $("#Fax").val(),
        Yetkili: $("#Yetkili").val(),
        Gsm: $("#Gsm").val(),
        Adres: $("#Adres").val(),
        ilceID: $("#ilceListesiID").val(),
        ilID: $("#illerID").val(),
        ID: ID,
    }

    $.ajax({
        url: "/api/ApiFirma/Guncelle/" + ID,
        contentType: "application/json",
        type: 'PUT',
        data: JSON.stringify(firma),
        success: function (response) {
            if (!response.IsErr)
            {

                swal
                (
                  'İşlem Başarılı',
                  'Kaydetme işlemi başarılı',
                  'success'
                )
            }
            else
            {
                swal
              (
                'İşlem Başarısız',
                'Kaydetme işlemi sırasında hata oluştu',
                'error'
              )

            }
        }
    });
}


Bilgiler_Fatura();
function Bilgiler_Fatura() {
    $.post('/Firma/Bilgiler_Fatura', null, function (data) {

    });
}


function FirmaFaturaBilgisiDuzenle(ID) {

    var firmaFaturaBilgi = {
        Unvan: $("#Unvan").val(),
        VergiDairesi: $("#VergiDairesi").val(),
        VergiNumarasi: $("#VergiNumarasi").val(),
        Logo: $("#Logo").val(),
        Adres: $("#Adres").val(),
        ID: ID,
    }

    $.ajax({
        url: "/api/ApiFirma/FirmaFaturaBilgisiDuzenle/" + ID,
        contentType: "application/json",
        type: 'PUT',
        data: JSON.stringify(firmaFaturaBilgi),
        success: function (response)
        {
            if (!response.IsErr) {

                swal
                (
                  'İşlem Başarılı',
                  'Kaydetme işlemi başarılı',
                  'success'
                )
            }
            else
            {
                swal
              (
                'İşlem Başarısız',
                'Kaydetme işlemi sırasında hata oluştu',
                'error'
              )

            }
        }
    });


}
