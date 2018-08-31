using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static IsProjesi.MyAttributes;

namespace IsProjesi.Controllers
{
    [YetkiKontrol(YetkiAdi: "İşler")]
    public class IslerController : Controller
    {
        // GET: isler
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult UrunHizmet()
        {
            return View();
        }
    }
}