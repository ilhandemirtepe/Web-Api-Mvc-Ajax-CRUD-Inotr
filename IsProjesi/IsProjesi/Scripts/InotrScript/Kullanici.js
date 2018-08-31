KullaniciListe();

function KullaniciListe() {


    $.ajax({
      
        type: "GET",
        url: "/api/ApiKullanici/KullaniciListe",
        dataType: "json",
        contentType: "application/json; charset=utf-8",
        success: function (response) {
            var html = '';
            $.each(response, function (key, item) {
                html += '<tr>';
                html += '<td>' + item.Adi + '</td>';
                html += '<td>' + item.Soyadi + '</td>';
                html += '<td>' + item.Email + '</td>';
                html += '<td>' + item.Tarih + '</td>';
                html +=
                 '<td class="text-center">' +
                     '<ul class="icons-list"> ' +
                         '<li class="dropdown"> ' +
                             '<a href="#" class="dropdown-toggle" data-toggle="dropdown"> ' +
                                ' <i class="icon-menu9"></i> ' +
                            ' </a> ' +
                             '<ul class="dropdown-menu dropdown-menu-right"> ' +
                                 '<li onclick="GuncelleSayfasiniAc(' + item.ID + ')"><a href="#"><i class="btn btn-primary"></i>Düzenle</a></li> ' +
                                 '<li onclick="KullaniciSil(' + item.ID + ')"><a href="#"><i class="btn btn-danger"></i>Sil</a></li> ' +

                             '</ul> ' +
                         '</li> ' +
                     '</ul> ' +
                '</td> ' +
                '<td></td>'
                html += '</tr>';
            });
            $('#KullaniciListele').html(html);
        }
    });
}




function KullaniciSil(silinecekID) {
    swal({
        title: "Silmek istediğinizden eminmisiniz ?",
        text: "Seçtiğiniz Kayıt Silinecektir.Bu İşlemi Onaylıyormusunuz!!",
        type: "warning",
        showCancelButton: true,
        confirmButtonClass: "btn-danger",
        confirmButtonText: "Evet!",
        closeOnConfirm: false
    }).then(function () {
        $.ajax({
            url: "/Api/ApiKullanici/KullaniciSil/" + silinecekID,
            type: 'DELETE',
            contentType: "application/json;charset=UTF-8",
            dataType: 'json',
            success: function () {
                swal
                (
                     'İşlem Başarılı',
                     'Silme İşleminiz Başarıyla Gerçekleştirilmiştir',
                     'success'
                )
                YetkiListe();
            },
            error: function () {
                swal
                (
                      'İşlem Başarısız',
                      'Silme işlemi sırasında hata oluştu .Lütfen tekrar deneyiniz',
                      'error'
                )
                KullaniciListe();
            }
        });
    });
}




function GuncelleSayfasiniAc(ID) {
    $.ajax({
        url: "/Kullanici/EkleGuncelle/" + ID,
        type: 'GET',
        datatype: "JSON",
        data: { ID: ID },
        success: function (response) {
            alert("Sayfayı açma başarılı");
            window.location.href = "/Kullanici/EkleGuncelle/" + ID;

        },
        error: function () {
            alert("Olmadı :(");
        }
    });

}

function KullaniciGuncelle(ID) {
    alert("gidiyor");
    $.ajax({
        url: "/Kullanici/EkleGuncelle/" + ID,
        type: 'POST',
        data: $("#formKullanici").serialize(),
        success: function (response) {
            alert("Başarılı !!!");
            swal({
                text: "Güncelleme İşleminiz başarıyla gerçekleşmiştir",
                type: "success",
            });
            window.location.href = "/Kullanici/";
        },
        error: function (error) {

            alert("olmadı!");
        }
    });



}



//function KullaniciGuncelle(ID) {
//    var kullanici = {
//        Adi: $("#ad").val(),
//        Soyadi: $("#soyad").val(),
//        Email: $("#e-posta").val(),
//        Parola: $("#parola").val(),
//        ID: ID,
//    }
//    $.ajax({
//        url: "/api/ApiKullanici/Guncelle/" + ID,
//        contentType: "application/json",
//        type: 'PUT',
//        data: JSON.stringify(kullanici),
//        success: function (response) {
//            swal({
//                text: "Güncelleme İşleminiz başarıyla gerçekleşmiştir",
//                type: "success",
//            });
//            window.location.href = "/Kullanici/";
//        },
//    });


   
//}

//function KullaniciEkle() {
//    var kullanici = {
//        Adi: $("#ad").val(),
//        Soyadi: $("#soyad").val(),
//        Email: $("#e-posta").val(),
//        Parola: $("#parola").val(),
//    }

//    $.ajax({

//        url: "/api/ApiKullanici/Ekle/",
//        contentType: "application/json",
//        type: 'POST',
//        data: JSON.stringify(kullanici),
//        success: function (response) {
//            swal({
//                text: "Ekleme İşleminiz başarıyla gerçekleşmiştir",
//                type: "success",
//            });
//            window.location.href = "/Kullanici/";
//        },
//    });
//}



