using IsProjesi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace IsProjesi.Controllers
{
    public class ApiEvrakController : ApiController
    {
        
        EvrakBLL evrakBLL = new EvrakBLL();
        [Route("api/ApiEvrak/CariEvrakListe")]
        [HttpGet]
        public List<Evrak> CariEvrakListe()
        {
            var evrak = evrakBLL.Get(x=> x.EvrakTurID==1).ToList();
            return evrak;
        }



        [Route("api/ApiEvrak/MusteriEvrakListe")]
        [HttpGet]
        public List<Evrak> MusteriEvrakListe()
        {
            var evrak = evrakBLL.Get(x => x.EvrakTurID==2).ToList();
            return evrak;
        }


        [Route("api/ApiEvrak/FirmaEvrakListe")]
        [HttpGet]
        public List<Evrak> FirmaEvrakListe()
        {
            var evrak = evrakBLL.Get(x => x.EvrakTurID==3).ToList();
            return evrak;
        }



        [Route("api/ApiEvrak/EvrakSil/{silinecekID}")]
        [HttpDelete]
        public void EvrakSil(int silinecekID)
        {
            var evrakSil = evrakBLL.GetFirstOrDefault(x => x.ID == silinecekID);
            if (evrakSil != null)
            {
                evrakBLL.Delete(evrakSil);
            }
           
        }


        [Route("api/ApiEvrak/Guncelle/{ID}")]
        [HttpPut]
        public void Guncelle([FromBody]Evrak evrak, int ID)
        {
            evrak.Tarih = DateTime.Now;
            evrakBLL.Update(evrak);


        }


        [Route("api/ApiEvrak/Ekle/")]
        [HttpPost]
        public void Ekle([FromBody]Evrak evrak)
        {
            evrak.Tarih = DateTime.Now;
            evrakBLL.Insert(evrak);

        }

    }
}
