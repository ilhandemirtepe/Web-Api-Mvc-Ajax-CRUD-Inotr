function GuncelleSayfasiniAc(ID) {


    $.ajax({
        url: "/Finans/KasaHareketEkleGuncelle/" + ID,
        type: 'GET',
        datatype: "JSON",
        data: { ID: ID },
        success: function (response) {
            window.location.href = "/Finans/KasaHareketEkleGuncelle/" + ID;

        },
        error: function () {
            alert("Olmadı :(");
        }
    });

}

function KasaHareketGuncelle(ID) {
    $.ajax({
        url: "/Kullanici/EkleGuncelle/" + ID,
        type: 'POST',
        data: $("#KasHarekForm").serialize(),
        success: function (response) {
            swal({
                text: "Güncelleme İşleminiz başarıyla gerçekleşmiştir",
                type: "success",
            });
            window.location.href = "/Kasa/";
        },
        error: function (error) {
            swal({
                text: "Bir sorun oluştu !",
                type: "danger",
            });
        }
    });



}
