using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static IsProjesi.MyAttributes;

namespace IsProjesi.Controllers
{
    [YetkiKontrol(YetkiAdi: "Satış")]
    public class SatisController : Controller
    {
        // GET: Satis
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Talep()
        {
            return View();
        }
        public ActionResult Talep_Talep()
        {
            return View();
        }
        public ActionResult Talep_MusteriAday()
        {
            return View();
        }
        public ActionResult Teklif()
        {
            return View();
        }
        public ActionResult Siparis()
        {
            return View();
        }



    }
}