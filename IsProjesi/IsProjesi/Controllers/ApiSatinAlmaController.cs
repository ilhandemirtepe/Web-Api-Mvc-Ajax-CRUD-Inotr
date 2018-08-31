using IsProjesi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace IsProjesi.Controllers
{
    public class ApiSatinAlmaController : ApiController
    {

        TedarikciTurBLL tedarikciTurBLL = new TedarikciTurBLL();
        TedarikciBLL tedarikciBLL = new TedarikciBLL();



        SatinAlmaTeklifBLL satinAlmaTeklifBLL = new SatinAlmaTeklifBLL();


        [Route("api/ApiSatinAlma/TedarikListele")]
        [HttpGet]

        public List<Tedarikci> TedarikListele()
        {

            var tedarikci = tedarikciBLL.GetAll().ToList();
            return tedarikci;
        }


        [Route("api/ApiSatinAlma/TedarikciGuncelle/{ID}")]
        [HttpPut]
        public void TedarikciGuncelle([FromBody] Tedarikci tedarikci, int ID)
        {
            tedarikci.Tarih = DateTime.Now;
            tedarikciBLL.InsertOrUpdate(tedarikci, ID);
        }

        [Route("api/ApiSatinAlma/TedarikTurListele")]
        [HttpGet]
        public List<TedarikciTur> TedarikTurListele()
        {
            var tadarikciTur = tedarikciTurBLL.GetAll().ToList();
            return tadarikciTur;
        }


        [Route("api/ApiSatinAlma/TedarikciEkle")]
        [HttpPost]
        public void TedarikciEkle([FromBody] Tedarikci tedarikci)
        {
            tedarikci.Tarih = DateTime.Now;
            tedarikciBLL.Insert(tedarikci);
        }


        [Route("api/ApiSatinAlma/TedarikciTurEkle")]
        [HttpPost]
        public void TedarikciTurEkle([FromBody] TedarikciTur tedarikciTur)
        {

            tedarikciTurBLL.Insert(tedarikciTur);
        }


        [Route("api/ApiSatinAlma/TedarikciTurGuncelle/{ID}")]
        [HttpPut]
        public void TedarikciTurGuncelle([FromBody] TedarikciTur tedarikciTur, int ID)
        {
            tedarikciTurBLL.InsertOrUpdate(tedarikciTur, ID);
        }

        [Route("Api/ApiSatinAlma/TedarikTurSil/{silinecekID}")]
        [HttpDelete]
        public int TedarikTurSil(int silinecekID)
        {
            var tedarikTurSil = tedarikciTurBLL.GetFirstOrDefault(x => x.ID == silinecekID);
            if (tedarikTurSil.Tedarikci.Count>0) //kategori altında tedarik varsa silinmesin
            {

                return 0;
            }
            else  //kategori altında tedarik yoksa silinsin
            {

                if (tedarikTurSil != null)
                {
                    tedarikciTurBLL.Delete(tedarikTurSil);
                }
            }

            return 1;

        }



        //TeklifGuncelle












    }
}
