using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static IsProjesi.MyAttributes;

namespace IsProjesi.Controllers
{
    [YetkiKontrol(YetkiAdi: "Tasarım Ayarları")]
    public class TasarimAyarlariController : Controller
    {
        // GET: TasarimAyarlari
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GenelTasarim()
        {
            return View();
        }
        public ActionResult FaturaAltBilgi()
        {
            return View();
        }
        public ActionResult SiparisAltBilgi()
        {
            return View();
        }
        public ActionResult SiparisUstBilgi()
        {
            return View();
        }
        public ActionResult EPostaTasarimi()
        {
            return View();
        }
        public ActionResult FaturaYazdırma()
        {
            return View();
        }

    }
}