using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using IsProjesi.Models;
namespace IsProjesi.Controllers
{ 

    public class ApiUrunHizmetController : ApiController
    {



        UrunHizmetKategoriBLL urunHizmetKategoriBLL = new UrunHizmetKategoriBLL();
        UrunHizmetKategori urunHizmetKategori = new UrunHizmetKategori();


        public List<UrunHizmetKategori> UrunHizmetKategoriList(int id)  
        {

            var query = urunHizmetKategoriBLL.GetLazyLoading(x => x.UstID == id).ToList();

            return query;

        }

        [Route("Api/ApiUrunHizmet/UrunHizmetKategoriSil/{silinecekID}")]
        [HttpDelete]
        public int UrunHizmetKategoriSil(int silinecekID)
        {



            var Kontrol = UrunHizmetKategoriList(silinecekID);

   
            if (Kontrol.Count > 0)                    //silmek istenen kategori  başka kategorilerin UstID si tutar...O yüzden silinmemesi lazım
            {
                return -1;
            }
            var kategoriSil = urunHizmetKategoriBLL.GetFirstOrDefault(x => x.ID == silinecekID);
            if (kategoriSil.UrunHizmet.Count > 0)     //kategori altında ürün  varsa silinmesin kategori
            {

                return -1;
            }

            else                                    //kategori altında ürün yoksa silinsin kategori
            {
                if (kategoriSil != null)
                {


                    urunHizmetKategoriBLL.Delete(kategoriSil);

                }
            }

            return 1;

        }





        //[HttpGet]
        //public List<UrunHizmetKategori> UrunHizmetKategoriListele()

        //{

        //    var urunler = db.UrunHizmetKategori.ToList();

        //    return urunler;


        //}


    }
}
