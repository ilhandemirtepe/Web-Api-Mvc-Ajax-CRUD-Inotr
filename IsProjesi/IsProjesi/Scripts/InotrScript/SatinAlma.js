TedarikciListe();
TedarikciTurListe();
TeklifListe();

function TedarikciTurListe() {
    $.ajax({
        type: "GET",
        url: "/api/ApiSatinAlma/TedarikTurListele",
        dataType: "json",
        contentType: "application/json; charset=utf-8",
        success: function (response) {


            var html = '';
            $.each(response, function (key, item) {
                html += '<tr>';
                html += '<td>' + item.Adi + '</td>';

                html +=
                 '<td class="text-center">' +
                     '<ul class="icons-list"> ' +
                         '<li class="dropdown"> ' +
                             '<a href="#" class="dropdown-toggle" data-toggle="dropdown"> ' +
                                '<i class="icon-menu9"></i> ' +
                            ' </a>' +
                             '<ul class="dropdown-menu dropdown-menu-right"> ' +
                                 '<li onclick="GuncelleSayfasiniAc(' + item.ID + ')"><a href="#"><i class="btn btn-primary"></i>Düzenle</a></li> ' +
                                 '<li onclick="TedarikTurSil(' + item.ID + ')"><a ><i class="btn btn-danger"></i>Sil</a></li> ' +
                             '</ul> ' +
                         '</li> ' +
                     '</ul> ' +
                '</td> ' +
                '<td></td>'
                html += '</tr>';
            });
            $('#KategoriTedarikci').html(html);
        }
    });
}

function GuncelleSayfasiniAc(ID) {
    $.ajax({
        url: "/SatinAlma/TedarikciTurEkleGuncelle/" + ID,
        type: 'GET',
        datatype: "JSON",
        data: { ID: ID },
        success: function (response) {

            window.location.href = "/SatinAlma/TedarikciTurEkleGuncelle/" + ID;

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

function TedarikKategoriTurEkle() {
    var tedarikTur = {
        Adi: $("#Adi").val(),

    }

    $.ajax({

        url: "/api/ApiSatinAlma/TedarikciTurEkle",
        contentType: "application/json",
        type: 'POST',
        data: JSON.stringify(tedarikTur),
        success: function (response) {

            swal({
                text: "Ekleme İşleminiz başarıyla gerçekleşmiştir",
                type: "success",
            });
            window.location.href = "/SatinAlma/Kategori/";


        },
    });

}


function TedarikKategoriTurGuncelle(ID) {
    var tedarikTur = {
        Adi: $("#Adi").val(),
        ID: ID,
    }
    $.ajax({

        url: "/api/ApiSatinAlma/TedarikciTurGuncelle/" + ID,
        contentType: "application/json",
        type: 'PUT',
        data: JSON.stringify(tedarikTur),
        success: function (response) {

            swal({
                text: "Güncelleme İşleminiz başarıyla gerçekleşmiştir",
                type: "success",
            });
            window.location.href = "/SatinAlma/Kategori/";
        },
    });
}



function TedarikTurSil(silinecekID) {
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
            url: "/Api/ApiSatinAlma/TedarikTurSil/" + silinecekID,
            type: 'DELETE',
            contentType: "application/json;charset=UTF-8",
            dataType: 'json',
            success: function (response) {


                if (response == 1) {
                    swal
                  (
                       'İşlem Başarılı',
                       'Silme İşleminiz Başarıyla Gerçekleştirilmiştir',
                       'success'
                  )
                }
                else {

                    swal
                  (
                       'İşlem Başarısız',
                       'Seçilen kategori silinmedi.Çünkü altında tedarikler vardır.',
                       'error'
                  )

                }
                TedarikciTurListe();
            },
            error: function () {
                swal
                (
                      'İşlem Başarısız',
                      'Silme işlemi sırasında hata oluştu .Lütfen tekrar deneyiniz',
                      'error'
                )
                TedarikciTurListe();
            }
        });
    });
}



function TedarikciListe() {

    $.post('/SatinAlma/Tedarikci', null, function (data) { });

}




function TedarikGuncelleSayfasiniAc(ID) {
    $.ajax({
        url: "/SatinAlma/TedarikciEkleGuncelle/" + ID,
        type: 'GET',
        datatype: "JSON",
        data: { ID: ID },
        success: function (response) {
            window.location.href = "/SatinAlma/TedarikciEkleGuncelle/" + ID;

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


$(document).ready(function () {
    $('#illerID').change(function () {

        $.post('/SatinAlma/illereGoreilceleriGetir', { Idil: $('#illerID').val() }, function (data) {
            var ilceler = "";
            for (var i = 0; i < data.length; i++) {
                ilceler = ilceler + '<option value=' + data[i].Value + '>' + data[i].Text + '</option>';
            }

            $('#ilceListesiID').html(ilceler);
        });
    });

    $(".add-more").click(function () {
        var html = $(".copy-fields").html();
        $(".after-add-more").after(html);
    });

    $("body").on("click", ".remove", function () {
        $(this).parents(".control-group").remove();
    });
    //IndirimDegistir();

});




function TedarikGuncelle(ID) {
    var tedarik = {
        FirmaAdi: $("#FirmaAdi").val(),

        Email: $("#Email").val(),
        Telefon: $("#Telefon").val(),
        Fax: $("#Fax").val(),
        CepTel: $("#CepTel").val(),
        Yetkili: $("#Yetkili").val(),
        FaturaUnvan: $("#FaturaUnvan").val(),
        VergiNumarası: $("#VergiNumarası").val(),
        VergiDairesi: $("#VergiDairesi").val(),
        ilID: $("#illerID").val(),
        ilceID: $("#ilceListesiID").val(),
        TedarikTurID: $("#tedarikTurListe").val(),
        Adres: $("#Adres").val(),
        Durumu: $("#Durumu").val(),
        ID: ID
    };
    $.ajax({
        url: "/api/ApiSatinAlma/TedarikciGuncelle/" + ID,
        contentType: "application/json",
        type: 'PUT',
        data: JSON.stringify(tedarik),
        success: function (response) {

            swal({
                text: "Güncelleme İşleminiz başarıyla gerçekleşmiştir",
                type: "success",
            });
            window.location.href = "/SatinAlma/Tedarikci";
        },
    });
}

function TedarikEkle() {

    var tedarik = {
        FirmaAdi: $("#FirmaAdi").val(),
        Email: $("#Email").val(),
        Telefon: $("#Telefon").val(),
        Fax: $("#Fax").val(),
        CepTel: $("#CepTel").val(),
        Yetkili: $("#Yetkili").val(),
        FaturaUnvan: $("#FaturaUnvan").val(),
        VergiNumarası: $("#VergiNumarası").val(),
        VergiDairesi: $("#VergiDairesi").val(),
        ilID: $("#illerID").val(),
        ilceID: $("#ilceListesiID").val(),
        TedarikTurID: $("#tedarikTurListe").val(),
        Adres: $("#Adres").val(),
        Durumu: $("#Durumu").val()
    };
    $.ajax({
        url: "/api/ApiSatinAlma/TedarikciEkle/",
        contentType: "application/json",
        type: 'POST',
        data: JSON.stringify(tedarik),
        success: function (response) {

            swal({
                text: "Ekleme işlemi başarıyla gerçekleştirilmiştir",
                type: "success",
            });
            window.location.href = "/SatinAlma/Tedarikci";
        },
    });
}

function TeklifListe() {
    $.get("/SatinAlma/Teklif", null, function (data) {


    });

}

function TeklifGuncelleSayfasiniAc(ID) 
{
  
    $.ajax({
        url: "/SatinAlma/TeklifEkleGuncelle/" + ID,
        type: 'GET',
        datatype: "JSON",
        data: { ID: ID },
        success: function (response) {
            window.location.href = "/SatinAlma/TeklifEkleGuncelle/" + ID;
          
        },
        error: function () {
            swal
              (
                    'İşlem Başarısız1',
                    'Sayfa açılırken hata oluştu lutfen  tekrar deneyiniz..',
                    'error'
              )
        }
    });
}




//function Getir(ID) {


//    $.ajax({
//        url: "/SatinAlma/TeklifVeDetaylar/" + ID,
//        type: 'GET',
//        datatype: "JSON",
//        data: { ID: ID },
//        success: function (response) {
//            alert(response);
//            //$("#naci").html(response);
//            $(".naci").html("deneme");
//        },
//        error: function () {
//            swal
//              (
//                    'İşlem hatalı',
//                    'Sayfa açılırken hata oluştu lutfen  tekrar deneyiniz..',
//                    'error'
//              )
//        }
//    });

    //$.get("/SatinAlma/TeklifVeDetaylar", { ID: ID }, function (data) {

    //    alert(data);
    //    console.log(data);

    //});

//}





//$("#ToplamIndirim").val() 
//alert($("#ToplamIndirim").val());





//$("#kdvUygulansinmiUygulanmasinmi").change(function () {
//    if ($(this).prop("checked") == true) //KDV Uygulanacak
//    {
//        alert("KDV uygulanacek");
//    }
//    else         //KDV Uygulanmayacak
//    {

//        alert("KDV uygulanmayacak");

//    }
//});



// alert("geldim ben controlden ");
// console.log(data);


// var BirimFiyat = $("#BirimFiyat").val();
// var Adet = $("#Adet").val();
// var Indirim = $("#Indirim").val();
// var ToplamIndirim = 0;

// for (var i = 0; i <data.length; i++) {

//     console.log(data);
//    // ToplamIndirim+=data[i]
// }

//// ToplamIndirim = Number(BirimFiyat) * Number(Adet) * Number(Indirim);
// $("#ToplamIndirim").val(ToplamIndirim);
//$.ajax({
//    url: "/SatinAlma/TekliflerinDetayListesi/" + ID,
//    type: 'POST',
//    datatype: "json",
//    data: { ID: ID },

//    success: function (response) {


//        alert("başarılı");

//    },
//    error: function () {
//        alert("hata var");
//    }
//});
//function TeklifGuncelle(ID) {

//    var teklif = {
//        TedarikciID: $("#tedarikListe").val(),
//        Durum: $("#Durum").val(),
//        Tutar: $("#Tutar").val(),
//        KdvOran: $("#KdvOran").val(),
//        Indirim: $("#Indirim").val(),

//        TeklifTarih: $("#TeklifTarih").val(),
//        OdemeTuru: $("#OdemeTuru").val(),
//        Vade: $("#Vade").val(),
//        TeklifDetay: CKEDITOR.instances['TeklifDetay'].getData(),
//        ID: ID
//    };
//    $.ajax({
//        url: "/SatinAlma/TeklifGuncelle",
//        type: 'PUT',
//        datatype: "JSON",
//        data: { teklif: teklif, ID: ID },
//        success: function (response) {


//            if (response.teklifTutarDurum == 1)
//            {
//                swal
//                 (
//                  'İşlem Başarılı',
//                  'Güncelleme işlemi başarıyla yapılmıştır',
//                  'success'
//                 )
//                window.location.href = "/SatinAlma/Teklif/";
//            }
//            else
//            {
//                swal
//                (
//                 'İşlem Başarısız',
//                 'Girdiğiniz değerler Toplam Tutarı olumsuz etkiliyor..Lütfen değerleri tekrar giriniz',
//                 'error'
//                )

//            }

//        },
//        error: function () {

//            swal
//            (
//                  'İşlem Başarısız',
//                  'Güncelleme işlemi sırasında hata oluştu',
//                  'error'
//            )


//            window.location.href = "/SatinAlma/Teklif/";
//        }
//    });
//}

//function TeklifEkle() {



//    var teklif = {
//        TedarikciID: $("#tedarikListe").val(),
//        Durum: $("#Durum").val(),
//        Tutar: $("#Tutar").val(),
//        KdvOran: $("#KdvOran").val(),
//        Indirim: $("#Indirim").val(),

//        TeklifTarih: $("#TeklifTarih").val(),
//        OdemeTuru: $("#OdemeTuru").val(),
//        Vade: $("#Vade").val(),
//        TeklifDetay: CKEDITOR.instances['TeklifDetay'].getData(),
//    };



//    $.ajax({
//        url: "/SatinAlma/TeklifEkle",
//        type: 'POST',
//        datatype: "JSON",
//        data: { teklif: teklif },
//        success: function (response) {



//            if (response.teklifTutarDurum == 1) {
//                swal
//                 (
//                  'İşlem Başarılı',
//                  'Teklif ekleme  işlemi başarıyla yapılmıştır',
//                  'success'
//                 )
//                window.location.href = "/SatinAlma/Teklif/";
//            }
//            else {
//                swal
//                (
//                 'İşlem Başarısız',
//                 'Girdiğiniz değerler Toplam Tutarı olumsuz etkiliyor.Lütfen değerleri tekrar giriniz',
//                 'error'
//                )

//            }
//        },
//        error: function () {
//            swal
//            (
//                  'İşlem Başarısız',
//                  'Teklif ekleme işlemi  sırasında hata oluştu.Lütfen daha sonra tekrar deneyiniz',
//                  'error'
//            )
//            window.location.href = "/SatinAlma/Teklif/";

//        }
//    });

//}


