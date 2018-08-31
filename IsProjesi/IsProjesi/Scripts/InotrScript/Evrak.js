
function CariEvrakListe() {

    $.ajax({

        type: "GET",
        url: "/api/ApiEvrak/CariEvrakListe",
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
                                 '<li onclick="EvrakSil(' + item.ID + ')"><a href="#"><i class="btn btn-danger"></i>Sil</a></li> ' +

                             '</ul> ' +
                         '</li> ' +
                     '</ul> ' +
                '</td> ' +
                '<td></td>'
                html += '</tr>';
            });
            $('#EvrakListele').html(html);
        }
    });
}

function FirmaEvrakListe() {

    $.ajax({

        type: "GET",
        url: "/api/ApiEvrak/CariEvrakListe",
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
                                 '<li onclick="EvrakSil(' + item.ID + ')"><a href="#"><i class="btn btn-danger"></i>Sil</a></li> ' +

                             '</ul> ' +
                         '</li> ' +
                     '</ul> ' +
                '</td> ' +
                '<td></td>'
                html += '</tr>';
            });
            $('#EvrakListele').html(html);
        }
    });
}

function MusteriEvrakListe() {

    $.ajax({

        type: "GET",
        url: "/api/ApiEvrak/CariEvrakListe",
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
                                 '<li onclick="EvrakSil(' + item.ID + ')"><a href="#"><i class="btn btn-danger"></i>Sil</a></li> ' +

                             '</ul> ' +
                         '</li> ' +
                     '</ul> ' +
                '</td> ' +
                '<td></td>'
                html += '</tr>';
            });
            $('#EvrakListele').html(html);
        }
    });
}




function EvrakSil(silinecekID) {
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
            url: "/Api/ApiEvrak/EvrakSil/" + silinecekID,
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
                EvrakListe();
            }
        });
    });
}



function GuncelleSayfasiniAc(ID) {


    $.ajax({
        url: "/Evrak/EkleGuncelle/" + ID,
        type: 'GET',
        datatype: "JSON",
        data: { ID: ID },
        success: function (response) {
            alert("Sayfayı açma başarılı");
            window.location.href = "/Evrak/EkleGuncelle/" + ID;

        },
        error: function () {
            alert("Olmadı :(");
        }
    });

}

//function EvrakEkleGuncelle(ID) {
//    var formData = new FormData();
//    formData.append("evrakDosya", $("#file").val());
//    $.ajax({
//        type: 'POST',
//        url: "/Evrak/EkleGuncelle/" + ID,
//        contentType: false,
//        data: { formData: formData ,ID:ID},
//        success: function (response) {
//            swal({
//                text: "Güncelleme İşleminiz başarıyla gerçekleşmiştir",
//                icon: "success",
//            });
//           // window.location.href = "/Evrak/";
//        },
//    });
//}



$(function EvrakEkleGuncelle() {
    $("#form1").submit(function () {
        /*You can also inject values to suitable named hidden fields*/
        /*You can also inject the whole hidden filed to form dynamically*/

        var formData = new FormData($(this)[0]);
        formData.append(Adi, $("#ad").val());
        formData.append(EvrakTurID, $("#evrakTur").val());
        formData.append(ID, $("#ID").val());
        $.ajax({
            url: "/Evrak/EkleGuncelle/",
            type: "POST",
            data: formData,
            async: false,
            success: function (response) {
                alert(data)
            },
            error: function () {
                alert('error');
            },
            cache: false,
            contentType: false,
            processData: false
        });
        return false;
    });
});


function filtrele(ID) {
    if (ID == 1) {
        if ($('.1').is(':hidden')) {
            $(".1").show();
        } else {
            $(".1").hide();
        }


    } else if (ID == 2) {
        if ($('.2').is(':hidden')) {
            $(".2").show();
        } else {
            $(".2").hide();
        }

    } else if (ID == 3) {
        if ($('.3').is(':hidden')) {
            $(".3").show();
        } else {
            $(".3").hide();
        }

    }

};

