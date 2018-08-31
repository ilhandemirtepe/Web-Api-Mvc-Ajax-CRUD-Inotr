using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IsProjesi.Models;

namespace IsProjesi
{
    public class MyAttributes
    {
        public class EncryptedActionParameterAttribute : ActionFilterAttribute
        {
            public override void OnActionExecuting(ActionExecutingContext filterContext)
            {
                if (filterContext.ActionParameters["_Id"] != null && filterContext.ActionParameters["Id"] != null)
                {
                   filterContext.ActionParameters["Id"] = EncryptionUtility.DecryptString(filterContext.ActionParameters["_Id"].ToString(), true);
                }
            }
        }

        public class SessionKontrol : ActionFilterAttribute
        {
            public override void OnActionExecuting(ActionExecutingContext filterContext)
            {
                if (HttpContext.Current.Session["Kullanici"] == null)
                {
                    filterContext.Result = new RedirectResult("~/Login");
                }
            }
        }

        public class YetkiKontrol : ActionFilterAttribute
        {
            private int YetkiId { get; set; }
            inotr_sistemEntities db = new inotr_sistemEntities();

            public YetkiKontrol(string YetkiAdi)
            {
                var result = db.Yetki.FirstOrDefault(x => x.Adi == YetkiAdi);
                this.YetkiId = db.Yetki.FirstOrDefault(x => x.Adi == YetkiAdi).ID;
            }

            public override void OnActionExecuting(ActionExecutingContext filterContext)
            {
                Kullanici model = HttpContext.Current.Session["Kullanici"] as Kullanici;
                //int uid;
                //if (HttpContext.Current.User.Identity.Name=="")
                //{
                //    uid = 0;
                //}
                //else
                //{
                //    uid = Convert.ToInt32(HttpContext.Current.User.Identity.Name);
                //}
                
                KullaniciBLL _kullanici = new KullaniciBLL();

                if (!model.KullaniciYetki.Any(x => x.YetkiID == YetkiId))
                {
                    filterContext.Result = new RedirectResult("/Home/YetkisizErisim");
                }
            }
        }

  

        public class GirisKontrol : ActionFilterAttribute
        {
            public override void OnActionExecuting(ActionExecutingContext filterContext)
            {

                if (HttpContext.Current.Session["Uye"] == null)
                {
                    filterContext.Result = new RedirectResult("/Login");
                }

            }
        }



    }
}