using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using IsProjesi.Models;
using static IsProjesi.MyAttributes;


namespace IsProjesi.Controllers
{
    [YetkiKontrol(YetkiAdi: "Satın Alma")]
    public class SatinAlmaController : Controller
    {
        // GET: SatinAlma





        TedarikciTurBLL tedarikciTurBLL = new TedarikciTurBLL();
        TedarikciTur tedarikciTur = new TedarikciTur();

        TedarikciBLL tedarikciBLL = new TedarikciBLL();
        Tedarikci tedarikci = new Tedarikci();


        SatinAlmaTeklifBLL satinAlmaTeklifBLL = new SatinAlmaTeklifBLL();
        SatinAlmaTeklif satinAlmaTeklif = new SatinAlmaTeklif();


        SatinAlmaTeklif_DetayBLL satinAlmaTeklif_DetayBLL = new SatinAlmaTeklif_DetayBLL();



        public ActionResult Index()
        {
            return View();
        }
        //tedarikçi turdur 
        public ActionResult Kategori()
        {
            return View();
        }

        public ActionResult TedarikciTurEkleGuncelle(int ID = 0)
        {

            tedarikciTur = tedarikciTurBLL.GetById(ID);
            return View(tedarikciTur);
        }
        public ActionResult Tedarikci()
        {
            List<Tedarikci> tedarikciList = tedarikciBLL.GetAll().ToList();
            return View(tedarikciList);
        }
        public ActionResult TedarikciEkleGuncelle(int ID = 0)
        {
            tedarikci = tedarikciBLL.GetById(ID);
            return View(tedarikci);
        }
        public ActionResult illereGoreilceleriGetir(int Idil)
        {
            List<SelectListItem> ilceAdlari = new List<SelectListItem>();
            if (Idil != 0)
            {
                var ilceler = YardimciClass.ilceleriListele(Idil);
                ilceler.ForEach(x =>
                {
                    ilceAdlari.Add(new SelectListItem { Text = x.IlceAdi, Value = x.ID.ToString() });
                });
            }
            return Json(ilceAdlari, JsonRequestBehavior.AllowGet);
        }


        public ActionResult Teklif()
        {

            var satinAlmaTeklifList = satinAlmaTeklifBLL.GetAll().ToList();

            return View(satinAlmaTeklifList);
        }

        public ActionResult TeklifEkleGuncelle(int ID = 0)
        {
            satinAlmaTeklif = satinAlmaTeklifBLL.GetById(ID);



            return View(satinAlmaTeklif);
        }

        public ActionResult TeklifVeDetaylar(int ID)
        {
            satinAlmaTeklif = satinAlmaTeklifBLL.GetById(ID);
            List<SatinAlmaTeklif_Detay> list = satinAlmaTeklif_DetayBLL.GetLazyLoading(x => x.SatinAlmaTeklifID == satinAlmaTeklif.ID).ToList();

            return PartialView(list);

            //satinAlmaTeklif = satinAlmaTeklifBLL.GetById(ID);
            //List<SatinAlmaTeklif_Detay> list = satinAlmaTeklif_DetayBLL.GetLazyLoading(x => x.SatinAlmaTeklifID == satinAlmaTeklif.ID).ToList();

            //return Json(list.Select(s => s.KalemAdi), JsonRequestBehavior.AllowGet);

        }
        //var satinAlmaTeklif_DetayListesi = new List<SatinAlmaTeklif_Detay>();
        //satinAlmaTeklif = satinAlmaTeklifBLL.GetById(ID);
        //foreach (var item in satinAlmaTeklif.SatinAlmaTeklif_Detay)
        //{
        //    satinAlmaTeklif_DetayListesi.Add(item);
        //}
        //return Json(satinAlmaTeklif_DetayListesi.ToList(),JsonRequestBehavior.AllowGet);

        //public JsonResult TekliflerinDetayListesi(int ID)
        //{

        //    return Json(GetArticlesByCategory(ID));
        //}
        //public IQueryable<ArticleTitle> GetArticlesByCategory(int id)
        //{
        //    inotr_sistemEntities de = new inotr_sistemEntities();
        //    return (de.SatinAlmaTeklif_Detay.Where(a => a.SatinAlmaTeklif.ID == id)

        //      .Select(a => new ArticleTitle
        //      {
        //          Aciklama = a.Aciklama,
        //          Head = a.KalemAdi,
        //      }))
        //      .AsQueryable();
        //}

        //public class ArticleTitle
        //{
        //    public string Aciklama { get; set; }
        //    public string Head { get; set; }
        //}







        //inotr_sistemEntities entity = new inotr_sistemEntities();
        //var result = from c in entity.SatinAlmaTeklif.Include("SatinAlmaTeklif_Detay")
        //             where c.ID == ID
        //             select new
        //             {
        //                 c.GenelToplamTutar,
        //                 c.SatinAlmaTeklif_Detay.Count,
        //             };


        //    return Json(result.ToList(), JsonRequestBehavior.AllowGet);

        //var satinAlmaTeklif_DetayListesi = new List<SatinAlmaTeklif_Detay>();
        //satinAlmaTeklif = satinAlmaTeklifBLL.GetById(ID);
        //foreach (var item in satinAlmaTeklif.SatinAlmaTeklif_Detay)
        //{
        //    satinAlmaTeklif_DetayListesi.Add(item);
        //}
        //return Json(satinAlmaTeklif_DetayListesi.ToList(),JsonRequestBehavior.AllowGet);

        //[HttpPut]
        //public JsonResult TeklifGuncelle(SatinAlmaTeklif teklif,int ID)
        //{

        //    teklif.Tarih = DateTime.Now;
        //    var teklifTutarDurum = 0;
        //    if (teklif.Tutar>0)
        //    {
        //        if (teklif.KdvOran==1)
        //        {
        //            teklif.ToplamTutar = teklif.Tutar - teklif.Indirim ;
        //        }
        //        else
        //        {
        //            teklif.ToplamTutar = teklif.Tutar - teklif.Indirim - (teklif.Tutar * teklif.KdvOran)/100;
        //        }  
        //    }

        //    if (teklif.ToplamTutar>0)
        //    {
        //        satinAlmaTeklifBLL.InsertOrUpdate(teklif, ID);
        //        teklifTutarDurum = 1;
        //    }

        //    return Json(teklifTutarDurum, JsonRequestBehavior.AllowGet);
        //}
        //[HttpPost]
        //public JsonResult TeklifEkle(SatinAlmaTeklif teklif)
        //{
        //    teklif.Tarih = DateTime.Now;
        //    var teklifTutarDurum = 0;
        //    if (teklif.Tutar > 0)
        //    {
        //        if (teklif.KdvOran == 1)
        //        {
        //            teklif.ToplamTutar = teklif.Tutar - teklif.Indirim;
        //        }
        //        else
        //        {
        //            teklif.ToplamTutar = teklif.Tutar - teklif.Indirim - (teklif.Tutar * teklif.KdvOran) / 100;
        //        }
        //    }
        //    if (teklif.ToplamTutar>0)
        //    {
        //        satinAlmaTeklifBLL.Insert(teklif);
        //        teklifTutarDurum = 1;
        //    }        
        //    return Json(teklifTutarDurum,JsonRequestBehavior.AllowGet);
        //}

        public ActionResult Siparis()
        {
            return View();
        }
    }
}