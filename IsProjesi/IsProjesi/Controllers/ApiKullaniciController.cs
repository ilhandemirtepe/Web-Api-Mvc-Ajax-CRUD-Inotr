using IsProjesi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace IsProjesi.Controllers
{
    public class ApiKullaniciController : ApiController
    {
        Kullanici _kullanici = new Kullanici();
        KullaniciBLL kullaniciBLL = new KullaniciBLL();
        YetkiBLL yetkiBBL = new YetkiBLL();
        [Route("api/ApiKullanici/KullaniciListe")]
        [HttpGet]
        public List<Kullanici> KullaniciListe()
        {
            var kullanici = kullaniciBLL.GetAll().ToList();
            return kullanici;
        }

        

        [Route("api/ApiKullanici/KullaniciSil/{silinecekID}")]
        [HttpDelete]
        public Kullanici KullaniciSil(int silinecekID)
        {
            

            var kullaniciSil = kullaniciBLL.GetFirstOrDefault(x => x.ID == silinecekID);
         
            if (kullaniciSil != null)
            {
                kullaniciBLL.Delete(kullaniciSil);
            }
            return kullaniciSil;

        }




        [Route("api/ApiKullanici/Guncelle/{ID}")]
        [HttpPut]
        public Kullanici Guncelle([FromBody]Kullanici kullanici,int ID)
        {
            kullanici.Tarih = DateTime.Now;
            kullaniciBLL.Update(kullanici);
           
            
            return kullanici;
        }


        
        [Route("api/ApiKullanici/Ekle/")]
        [HttpPost]
        public void Ekle([FromBody]Kullanici kullanici)
        {
            kullanici.Tarih = DateTime.Now;
            kullaniciBLL.Insert(kullanici);
            
        }

    }
}
