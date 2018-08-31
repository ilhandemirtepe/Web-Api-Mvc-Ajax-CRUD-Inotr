using IsProjesi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static IsProjesi.MyAttributes;

namespace IsProjesi.Controllers
{
    [YetkiKontrol(YetkiAdi: "Kullanıcı")]
    public class KullaniciController : Controller
    {

        // GET: KullaniciIslemleri
        KullaniciBLL _kullaniciBLL = new KullaniciBLL();
        Kullanici _kullanici = new Kullanici();
        YetkiBLL yetkiBLL = new YetkiBLL();
        KullaniciYetkiBLL kullaniciYetkiBLL = new KullaniciYetkiBLL();
        KullaniciYetki kullaniciyetki = new KullaniciYetki();

        public ActionResult Index()
        {
            return View();
        }


        public ActionResult EkleGuncelle(int ID = 0)
        {

            _kullanici = _kullaniciBLL.GetById(ID);
            ViewBag.kontrol = kullaniciYetkiBLL.Get(x => x.KullaniciID == _kullanici.ID).ToList();
            return View(_kullanici);
        }

        [HttpPost]
        public ActionResult EkleGuncelle(string Adi, string Soyadi, string Parola, string Email, int[] chkIds, int ID = 0)
        {
            if (ID != 0)
            {
                _kullanici = _kullaniciBLL.GetById(ID);
                ViewBag.kontrol = kullaniciYetkiBLL.Get(x => x.KullaniciID == _kullanici.ID).ToList();

                foreach (var item in _kullanici.KullaniciYetki)
                {
                    KullaniciYetki yenikullaniciYetki = new KullaniciYetki();
                    yenikullaniciYetki = kullaniciYetkiBLL.GetById(item.ID);
                    kullaniciYetkiBLL.Delete(yenikullaniciYetki);
                }

               
                foreach (var item in chkIds)
                {

                    KullaniciYetki yenikullaniciYetki = new KullaniciYetki();
                    yenikullaniciYetki.KullaniciID = _kullanici.ID;
                    yenikullaniciYetki.YetkiID = item;
                    kullaniciYetkiBLL.Insert(yenikullaniciYetki);

                }
                _kullanici.Adi = Adi;
                _kullanici.Soyadi = Soyadi;
                _kullanici.Tarih = DateTime.Now;
                _kullaniciBLL.InsertOrUpdate(_kullanici, ID);
                ViewBag.kontrol = kullaniciYetkiBLL.Get(x => x.KullaniciID == _kullanici.ID).ToList();
                return View(_kullanici);

            }
            else
            {
                _kullanici.Adi = Adi;
                _kullanici.Soyadi = Soyadi;
                _kullanici.Parola = Parola;
                _kullanici.Email = Email;
                _kullaniciBLL.InsertOrUpdate(_kullanici, ID);

                foreach (var item in chkIds)
                {

                    KullaniciYetki yenikullaniciYetki = new KullaniciYetki();
                    yenikullaniciYetki.KullaniciID = _kullanici.ID;
                    yenikullaniciYetki.YetkiID = item;
                    kullaniciYetkiBLL.Insert(yenikullaniciYetki);
                   
                }
                ViewBag.kontrol = kullaniciYetkiBLL.Get(x => x.KullaniciID == _kullanici.ID).ToList();
                return View(_kullanici);
            }


        }




    }
}