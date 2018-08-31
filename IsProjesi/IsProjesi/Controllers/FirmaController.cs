using IsProjesi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static IsProjesi.MyAttributes;

namespace IsProjesi.Controllers
{
    [YetkiKontrol(YetkiAdi: "Firma")]
    public class FirmaController : Controller
    {
        FirmaBLL firmaBLL = new FirmaBLL();
        Firma firma = new Firma();
        ilBLL ilBLL = new ilBLL();
        FirmaFaturaBilgiBLL firmaFaturaBilgiBLL = new FirmaFaturaBilgiBLL();
        FirmaFaturaBilgi firmaFaturaBilgi = new FirmaFaturaBilgi();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Bilgiler()
        {
            return View();
        }
        public ActionResult Bilgiler_iletisim()
        {

            var iller = ilBLL.GetAll().ToList();
            ViewBag.illerID = new SelectList(iller, "ID", "Adi");
            firma = firmaBLL.FirstOrDefault();
            return View(firma);
        }
        public ActionResult illereGoreilceleriGetir(int Idil)
        {
            List<SelectListItem> ilceAdlari = new List<SelectListItem>();
            if (Idil != 0)
            {    
                var ilceler = YardimciClass.ilceleriListele(Idil);
                ilceler.ForEach(x =>
                {
                    ilceAdlari.Add(new SelectListItem { Text = x.IlceAdi, Value = x.ID.ToString()});
                });
            }
            return Json(ilceAdlari, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Bilgiler_Fatura()
        {
            firmaFaturaBilgi = firmaFaturaBilgiBLL.FirstOrDefault();

            return View(firmaFaturaBilgi);
        }
        public ActionResult KullanicilarYetkiler()
        {
          
            return View();
        }
      
    }
}