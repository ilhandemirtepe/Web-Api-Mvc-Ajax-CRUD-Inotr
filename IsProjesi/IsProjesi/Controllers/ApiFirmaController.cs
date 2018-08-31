using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using IsProjesi.Models;
namespace IsProjesi.Controllers
{
    public class ApiFirmaController : ApiController
    {

        FirmaBLL firmaBLL = new FirmaBLL();
        FirmaFaturaBilgiBLL firmaFaturaBilgiBLL = new FirmaFaturaBilgiBLL();

        [Route("api/ApiFirma/Guncelle/{ID}")]
        [HttpPut]

        public Firma  Guncelle([FromBody] Firma  firma,int ID)
        {

            firmaBLL.InsertOrUpdate(firma, ID);

            return firma;
        }


        [Route("api/ApiFirma/FirmaFaturaBilgisiDuzenle/{ID}")]
        [HttpPut]
        public FirmaFaturaBilgi FirmaFaturaBilgisiDuzenle([FromBody] FirmaFaturaBilgi firmaFaturaBilgi,int ID)
        {
            firmaFaturaBilgi.Tarih = DateTime.Now;
            firmaFaturaBilgiBLL.InsertOrUpdate(firmaFaturaBilgi,ID);
            return firmaFaturaBilgi;

        }
      





    }
}
