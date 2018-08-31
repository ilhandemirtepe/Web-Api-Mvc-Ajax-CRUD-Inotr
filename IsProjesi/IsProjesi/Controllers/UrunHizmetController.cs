using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IsProjesi.Models;
using static IsProjesi.MyAttributes;

namespace IsProjesi.Controllers
{
    //[YetkiKontrol(YetkiAdi: "Ürün ve Hizmetler")]
    public class UrunHizmetController : Controller
    {


        UrunHizmetKategoriBLL urunHizmetKategoriBLL = new UrunHizmetKategoriBLL();
        UrunHizmetBLL urunHizmetBLL = new UrunHizmetBLL();
        //UrunHizmetKategori urunHizmetKategori = new UrunHizmetKategori();




        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Kategoriler()
        {
          
            List<UrunHizmetKategori> UrunHizmetKategoriList = urunHizmetKategoriBLL.GetAll().ToList();
            return View(UrunHizmetKategoriList);
     
        }

        public ActionResult KategoriEkleGuncelle(int ID=0)
        {
          var kategori= urunHizmetKategoriBLL.GetById(ID);
            return View(kategori);
        }


        public ActionResult UrunEkleGuncelle(int ID)
        {
            var urun = urunHizmetBLL.GetById(ID);
            return View(urun);
        }
        public ActionResult KategoriEkle(UrunHizmetKategori urunHizmetKategori)
        {

         
                urunHizmetKategori.Tarih = DateTime.Now;
                urunHizmetKategoriBLL.Insert(urunHizmetKategori);
               
         

            return Json(0);
        }
        public ActionResult KategoriGuncelle(UrunHizmetKategori urunHizmetKategori)
        {

            urunHizmetKategori.Tarih = DateTime.Now;
            urunHizmetKategoriBLL.Update(urunHizmetKategori);
            return Json(0);

        }


        public ActionResult Urunler()
        {
            List<UrunHizmet> urunHizmetList = urunHizmetBLL.GetAll().ToList();

            return View(urunHizmetList);
        }
        public ActionResult StokHareketleri()
        {
            return View();
        }
    }
}