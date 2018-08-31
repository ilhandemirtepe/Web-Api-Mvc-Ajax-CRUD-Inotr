YetkiListe();

function YetkiListe() {
    $.ajax({
        type: "GET",
        url: "/api/ApiYetki/YetkiListe",
        dataType: "json",
        contentType: "application/json; charset=utf-8",
        success: function (response) {
            var html = '';
            $.each(response, function (key, item) {
                html += '<tr>';
                html += '<td>' + item.Adi + '</td>';
                html += '<td>' + item.Tarih + '</td>';
                html +=
                 '<td class="text-center">' +
                     '<ul class="icons-list"> ' +
                         '<li class="dropdown"> ' +
                             '<a href="#" class="dropdown-toggle" data-toggle="dropdown"> ' +
                                '<i class="icon-menu9"></i> ' +
                            ' </a>'+
                             '<ul class="dropdown-menu dropdown-menu-right"> ' +
                                 '<li onclick="GuncelleSayfasiniAc(' + item.ID + ')"><a href="#"><i class="btn btn-primary"></i>Düzenle</a></li> ' +
                                 '<li onclick="YetkiSil(' + item.ID + ')"><a ><i class="btn btn-danger"></i>Sil</a></li> ' +
                             '</ul> ' +
                         '</li> ' +
                     '</ul> ' +
                '</td> ' +
                '<td></td>'
                html += '</tr>';
            });
            $('#YetkiListele').html(html);
        }
    });
}








function YetkiSil(silinecekID) {
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
            url: "/Api/ApiYetki/YetkiSil/" + silinecekID,
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
                YetkiListe();
            }
        });
    });
}

function GuncelleSayfasiniAc(ID) {
    $.ajax({
        url: "/Yetki/EkleGuncelle/" + ID,
        type: 'GET',
        datatype: "JSON",
        data: { ID: ID },
        success: function (response) {
           
          
            window.location.href = "/Yetki/EkleGuncelle/" + ID;

        },
        error: function () {
            swal
              (
                    'İşlem Başarısız',
                    'Sayfa açılırken hata oluştu lutfen  tekrar deneyiniz..',
                    'error'
              )
        }
    });

}




function YetkiGuncelle(ID) {
        var yetki = {
            Adi: $("#Adi").val(),        
            ID:ID,
        }

        $.ajax({
            url: "/api/ApiYetki/Guncelle/"+ID,
            contentType: "application/json",
            type: 'PUT',
            data: JSON.stringify(yetki),
            success: function (response) {
               
                $("#Adi").val(response.Adi);
               
                swal
               (
                     'İşlem Başarılı',
                     'Kaydetme işlemi başarılı',
                     'success'
               )
                window.location.href = "/Yetki/Index/" + ID;

              

            }
        });
}



function YetkiEkle() {
   
    var yetki = {
        Adi: $("#Adi").val(),
       
    }

    $.ajax({

        url: "/api/ApiYetki/Ekle/",
        contentType: "application/json",
        type: 'POST',
        data: JSON.stringify(yetki),
        success: function (response) {
            swal({
                text: "Ekleme İşleminiz başarıyla gerçekleşmiştir",
                type: "success",
            });
            window.location.href = "/Yetki/Index/";
        },
    });
}











































































//var ideditOrAdd = "";
//function GetSelected(id) {
//    $.getJSON("/Calisanlars/GetSelected", { recordid: id }, function (response) {
//        ideditOrAdd = response.id;
//        $("#Aditxt").val(response.Ad);
//        $("#Emailtxt").val(response.Email);
//        $("#TecrubeTxt").val(response.Tecrube);
//        $("#Telefontxt").val(response.Telefon);

//    });
//}
//function Add() {
//    var calisanlar =
//    {
//        Ad: $("#Aditxt").val(),
//        Email: $("#Emailtxt").val(),
//        Telefon: $("#Telefontxt").val(),
//        Tecrube: $("#TecrubeTxt").val(),
//    };

//    $.post('Calisanlars/AddOrSave', { calisanlar: calisanlar, ideditOrAdd: ideditOrAdd }, function (response) {
//        if (!response.IsErr) {

//            Reset();
//            swal
//              (
//                   'İşlem Başarılı',
//                   'İşleminiz Başarıyla Gerçekleştirilmiştir',
//                   'success'
//               )
//            Listele();
//        }
//    });
//}