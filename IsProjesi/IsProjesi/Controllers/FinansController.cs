using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static IsProjesi.MyAttributes;
using IsProjesi.Models;

namespace IsProjesi.Controllers
{
    [YetkiKontrol(YetkiAdi: "Finans")]
    public class FinansController : Controller
    {
        KasaBLL KasaBLL = new KasaBLL();
        KasaHareketleriBLL kasaHareketleriBLL = new KasaHareketleriBLL();
        KasaHareketleri kasaHareketleri = new KasaHareketleri();

        // GET: Finans
        public ActionResult Index()
        {
            return View();
        }
        //----     -----//

        public ActionResult Kasa()
        {
            List<KasaHareketleri> kasaHareketListesi = kasaHareketleriBLL.GetAll().ToList();
            return View(kasaHareketListesi);
        }




        public ActionResult KasaHareketEkleGuncelle()
        {
            List<KasaHareketleri> kasaHareketListesi = kasaHareketleriBLL.GetAll().ToList();
            return View(kasaHareketListesi);
        }


        //[HttpPost]
        //public ActionResult KasaHareketEkleGuncelle()
        //{
        //    List<KasaHareketleri> kasaHareketListesi = kasaHareketleriBLL.GetAll().ToList();
        //    return View(kasaHareketListesi);

        //}






        public ActionResult Gider()
        {
            return View();
        }
        public ActionResult Gider_Cari()
        {
            return View();
        }
        public ActionResult Gider_Fatura()
        {
            return View();
        }
        public ActionResult Gider_Odeme()
        {
            return View();
        }
        public ActionResult Gelir()
        {
            return View();
        }
        public ActionResult Gelir_Kasa()
        {
            return View();
        }

        public ActionResult Gelir_Faturalar()
        {
            return View();
        }

        public ActionResult Gelir_Odemeler()
        {
            return View();
        }
    }
}