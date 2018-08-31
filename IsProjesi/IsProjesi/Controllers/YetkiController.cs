using IsProjesi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static IsProjesi.MyAttributes;

namespace IsProjesi.Controllers
{
    [YetkiKontrol(YetkiAdi: "Yetki")]
    public class YetkiController : Controller
    {
        YetkiBLL yetkiBLL = new YetkiBLL();
        
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult EkleGuncelle(int ID=0)
        {
            Yetki yetki = new Yetki();
            yetki = yetkiBLL.GetById(ID);
            return View(yetki);
        }

        //[HttpPost]
        //public ActionResult EkleGuncelle()
        //{

        //    return View();
        //}


        [AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = true)]
        public class SwitchableAuthorizationAttribute : AuthorizeAttribute
        {
            protected override bool AuthorizeCore(HttpContextBase httpContext)
            {
                bool disableAuthentication = false;

#if DEBUG
                disableAuthentication = true;
#endif

                if (disableAuthentication)
                    return true;

                return base.AuthorizeCore(httpContext);
            }
        }

    

    }
}