using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static IsProjesi.MyAttributes;

namespace IsProjesi.Controllers
{
    [YetkiKontrol(YetkiAdi: "Sistem Ayarları")]
    public class SistemAyarlariController : Controller
    {
        // GET: SistemAyarlari
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ProjeAyarlari_Index()
        {
            return View();
        }
        public ActionResult Sistemiletisimi_Index()
        {
            return View();
        }
        public ActionResult Sistemiletisimi_OtomatikIletisim()
        {
            return View();
        }
        public ActionResult Sistemiletisimi_IletisimHareketleri()
        {
            return View();
        }
    }
}