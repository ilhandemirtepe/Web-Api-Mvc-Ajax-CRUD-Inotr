using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static IsProjesi.MyAttributes;


namespace IsProjesi.Controllers
{

    [YetkiKontrol(YetkiAdi: "Destek")]
    public class DestekController : Controller
    {
        // GET: Destek
        
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Bildirim()
        {
            return View();
        }
        public ActionResult Kategori()
        {
            return View();
        }
    }
}