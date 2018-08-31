


function UrunHizmetKategoriSil(silinecekID) {
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
            url: "/Api/ApiUrunHizmet/UrunHizmetKategoriSil/" + silinecekID,
            type: 'DELETE',
            contentType: "application/json;charset=UTF-8",
            dataType: 'json',
            success: function (response) {
                console.log(response);
                if (response == 1) {
                    swal
                   (
                     'İşlem Başarılı',
                     'Silme işlemi başarıyla gerçekleştirilmiştir',
                     'success'
                   )
                }
                else {
                    swal
                    (
                          'İşlem Başarısız',
                          'Silmek istediğiniz kategori altında başka kategori veya ürünler vardır .Lütfen tekrar deneyiniz',
                          'error'
                    )
                }
                window.location.href = "/UrunHizmet/Kategoriler/"
            },
            error: function () {
                swal
                (
                      'İşlem Başarısız',
                      'Silme işlemi sırasında hata oluştu .Lütfen tekrar deneyiniz',
                      'error'
                )
            }
        });
    });
}


UrunGuncellemeSayfasiniAc



function UrunGuncellemeSayfasiniAc(ID) {


    $.ajax({
        url: "/UrunHizmet/UrunEkleGuncelle/" + ID,
        type: 'GET',
        datatype: "JSON",
        data: { ID: ID },
        success: function (response) {
            window.location.href = "/UrunHizmet/UrunEkleGuncelle/" + ID;

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


function KategoriGuncellemeSayfasiniAc(ID) {


    $.ajax({
        url: "/UrunHizmet/KategoriEkleGuncelle/" + ID,
        type: 'GET',
        datatype: "JSON",
        data: { ID: ID },
        success: function (response) {
            window.location.href = "/UrunHizmet/KategoriEkleGuncelle/" + ID;

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





function KategoriEkle() {


    var urunHizmetKategori = {
        Ad: $("#Ad").val(),
        UstID: $("#UstID").val(),
    };

    $.post('/UrunHizmet/KategoriEkle', { urunHizmetKategori: urunHizmetKategori }, function (response) {
        if (!response.IsErr) {


            swal
              (
                   'İşlem Başarılı',
                   'İşleminiz Başarıyla Gerçekleştirilmiştir',
                   'success'
               )



        }
        else {

            swal
           (
                'İşlem Başarısız',
                'İşlem sırasında hata oluştu.Dlütfen daha sonra tekrar deneyiniz',
                'error'
            )

        }
        window.location.href = "/UrunHizmet/Kategoriler/";
    });
}


function KategoriGuncelle(ID) {


    var urunHizmetKategori = {
        Ad: $("#Ad").val(),
        UstID: $("#UstID").val(),
        ID:ID,
    };

    $.post('/UrunHizmet/KategoriGuncelle', { urunHizmetKategori: urunHizmetKategori}, function (response) {
        if (!response.IsErr)
        {
                swal
            (
                 'İşlem Başarılı',
                 'İşleminiz Başarıyla Gerçekleştirilmiştir',
                 'success'
             )
        }
        else {

            swal
           (
                'İşlem Başarısız',
                'İşlem sırasında hata oluştu.Dlütfen daha sonra tekrar deneyiniz',
                'error'
            )

        }
        window.location.href = "/UrunHizmet/Kategoriler/";
    });
}


