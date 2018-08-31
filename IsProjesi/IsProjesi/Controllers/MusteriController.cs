using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static IsProjesi.MyAttributes;

namespace IsProjesi.Controllers
{
    [YetkiKontrol(YetkiAdi: "Müşteri")]
    public class MusteriController : Controller
    {
        // GET: Musteri
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult IletisimBilgi()
        {
            return View();
        }
        public ActionResult Talep()
        {
            return View();
        }
        public ActionResult Teklif()
        {
            return View();
        }
        public ActionResult Satis()
        {
            return View();
        }
        public ActionResult Is()
        {
            return View();
        }
        public ActionResult Fatura()
        {
            return View();
        }

        public ActionResult Odeme()
        {
            return View();
        }
        public ActionResult Evrak()
        {
            return View();
        }
        public ActionResult Destek()
        {
            return View();
        }
        public ActionResult Not()
        {
            return View();
        }

    }
}