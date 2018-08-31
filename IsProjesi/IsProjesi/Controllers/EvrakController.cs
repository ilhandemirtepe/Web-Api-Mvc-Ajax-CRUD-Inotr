using IsProjesi.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static IsProjesi.MyAttributes;

namespace IsProjesi.Controllers
{
    [YetkiKontrol(YetkiAdi: "Evrak")]
    public class EvrakController : Controller
    {

        EvrakBLL _evrakBLL = new EvrakBLL();
        Evrak _evrak = new Evrak();

        // GET: Evrak
        public ActionResult Index()
        {
            var cariEvrakListe = _evrakBLL.GetAll().ToList();
            return View(cariEvrakListe);
        }

        public ActionResult FirmaEvraklari()
        {
            return View();
        }

        public ActionResult CariEvraklar()
        {
            var cariEvrakListe = _evrakBLL.GetAll().ToList();
            return View(cariEvrakListe);
        }

        public ActionResult MusteriEvraklari()
        {
            return View();
        }

        
        public ActionResult EkleGuncelle(int ID = 0)
        {
            
            return View(_evrakBLL.GetById(ID));
        }

        
        [HttpPost]
        public ActionResult EkleGuncelle(HttpPostedFileBase file1, int EvrakTurID, string Adi, int ID=0)
        {
            
            if (ID > 0)
            {
                Evrak guncellenecekEvrak = _evrakBLL.GetById(ID);
                if (file1.ContentLength >0)
                {
                    string _FileName = Path.GetFileName(file1.FileName);
                    string _path = Path.Combine(Server.MapPath("~/UploadedFiles/Evraklar/"), _FileName);
                    file1.SaveAs(_path);
                    string dbdekiPath = "/UploadedFiles/Evraklar/" + _FileName;
                    guncellenecekEvrak.Yolu = dbdekiPath;
                }
                
                guncellenecekEvrak.Adi = Adi;
                guncellenecekEvrak.EvrakTurID = EvrakTurID;
                _evrakBLL.Update(guncellenecekEvrak);
                
            }
            else
            {
                Evrak guncellenecekEvrak = _evrakBLL.GetById(ID);
                string _FileName = Path.GetFileName(file1.FileName);
                string _path = Path.Combine(Server.MapPath("~/UploadedFiles/Evraklar"), _FileName);
                file1.SaveAs(_path);
                string dbdekiPath = "/UploadedFiles/Evraklar/" + _FileName;
                _evrak.Yolu = dbdekiPath;
                _evrak.Adi = Adi;
                _evrak.EvrakTurID = EvrakTurID;
                _evrakBLL.Insert(_evrak);

            }
        
         
            return Json("OK" , JsonRequestBehavior.AllowGet);
        }
    }

}
