using IsProjesi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static IsProjesi.MyAttributes;

namespace IsProjesi.Controllers
{
   // [YetkiKontrol(YetkiAdi: "Login")]
    public class LoginController : Controller
    {
        // GET: Login
        KullaniciBLL _kullanici = new KullaniciBLL();


        [AllowAnonymous]
        public ActionResult Index()
        {
            if (Session["Kullanici"] != null)
            {
                return RedirectToAction("Index", "Home");
            }
            //Session["GuvenlikKodu"] = YardimciClass.GuvenlikResmi(HttpContext.Request.PhysicalApplicationPath + "/images/");
            return View();
        }
        
        
        [HttpPost]
        public ActionResult Index(string Adi, string Parola)
        {
            if (Adi == "" || Parola == "")
            {
                return Json("Lütfen boşlukları doldurunuz.", JsonRequestBehavior.AllowGet);
            }
            //else if (GuvenlikKodu != Session["GuvenlikKodu"].ToString())
            //{
            //    return Json("Güvenlik kodunu yanlış girdin.", JsonRequestBehavior.AllowGet);
            //}
            else
            {
                var kontrol = _kullanici.GetFirstOrDefault(g => g.Adi == Adi && g.Parola == Parola);
                if (kontrol != null)
                {

                    
                    _kullanici.Update(kontrol);
                    Session["Kullanici"] = kontrol;
                    return Json("OK", JsonRequestBehavior.AllowGet);
                }
                else
                {
                    return Json("Kullanıcı bilgisine ulaşılamadı.", JsonRequestBehavior.AllowGet);
                }
            }
        }

       


        public ActionResult Cikis()
        {
            Session["GuvenlikKodu"] = null;
            Session["Kullanici"] = null;
            return RedirectToAction("Index", "Login");
        }

    }
}