using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static IsProjesi.MyAttributes;

namespace IsProjesi.Controllers
{
    [YetkiKontrol(YetkiAdi: "Ödeme Ayarları")]
    public class OdemeAyarlariController : Controller
    {
        // GET: OdemeAyarlari
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult PosBilgileri()
        {
            return View();
        }
        public ActionResult BankaHesapBilgileri()
        {
            return View();
        }
    }
}