using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using IsProjesi.Models;

namespace IsProjesi.Controllers
{
    public class ApiYetkiController : ApiController
    {
        
        YetkiBLL yetkiBll = new YetkiBLL();
        [Route("api/ApiYetki/YetkiListe")]
        [HttpGet]
        public List<Yetki> YetkiListe()
        {
            var yetki = yetkiBll.GetAll().ToList();
            return yetki;
        }



        [Route("api/ApiYetki/Ekle/")]
        [HttpPost]
        public void Ekle([FromBody]Yetki yetki)
        {
            yetki.Tarih = DateTime.Now;
            yetkiBll.Insert(yetki);

        }


        [Route("api/ApiYetki/YetkiSil/{silinecekID}")]
        [HttpDelete]
        public Yetki YetkiSil(int silinecekID)
        {
            var yetkiSil = yetkiBll.GetFirstOrDefault(x=>x.ID==silinecekID);
            foreach (var item in yetkiSil.KullaniciYetki.ToList())   
            {
                item.YetkiID =null;
            }

            foreach (var item in yetkiSil.Musteri.ToList())
            {
                item.YetkiID =null;
            }



            if (yetkiSil!=null)
            {
                yetkiBll.Delete(yetkiSil);
            }
            return yetkiSil;

        }



        [Route("api/ApiYetki/Guncelle/{ID}")]
        [HttpPut]
        public Yetki Guncelle([FromBody]Yetki yetki, int ID)
        {
            yetki.Tarih = DateTime.Now;
            yetkiBll.InsertOrUpdate(yetki, ID);
         
            return yetki;
        }


    }
}
