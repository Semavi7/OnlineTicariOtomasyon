using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Web;
using System.Web.Mvc;
using OnlineTicariOtomasyon.Models.Siniflar;

namespace OnlineTicariOtomasyon.Content
{
    public class SatisController : Controller
    { 
        Context c = new Context();
        // GET: Satis
        public ActionResult Index()
        {
            var degerler = c.SatisHarekets.ToList();
            return View(degerler);
        }

        [HttpGet]
        public ActionResult YeniSatis()
        {
            List<SelectListItem> deger1 = (from x in c.Uruns.ToList() 
                                           select new SelectListItem 
                                           {
                                               Text = x.UrunAd,
                                               Value = x.Urunid.ToString()
                                           }).ToList();
            List<SelectListItem> deger2 = (from x in c.Carilers.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.CariAd + " " + x.CariSoyad,
                                               Value = x.Cariid.ToString()
                                           }).ToList();
            List<SelectListItem> deger3 = (from x in c.Personels.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.PersonelAd + " " + x.PersonelSoyad,
                                               Value = x.Personelid.ToString()
                                           }).ToList();
            ViewBag.dgr1 = deger1;
            ViewBag.dgr2 = deger2;
            ViewBag.dgr3 = deger3;
            int urunId = int.Parse(deger1.First().Value);
            decimal satisFiyat = c.Uruns.Where(u => u.Urunid == urunId).Select(u => u.SatisFiyat).FirstOrDefault();
            ViewBag.dgr4 = satisFiyat;
            return View();
        }

        [HttpPost]
        public ActionResult YeniSatis(SatisHareket s)
        {
            s.Tarih = DateTime.Parse(DateTime.Now.ToShortDateString());
            c.SatisHarekets.Add(s);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult SatisGetir(int id)
        {
            List<SelectListItem> deger1 = (from x in c.Uruns.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.UrunAd,
                                               Value = x.Urunid.ToString()
                                           }).ToList();
            List<SelectListItem> deger2 = (from x in c.Carilers.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.CariAd + " " + x.CariSoyad,
                                               Value = x.Cariid.ToString()
                                           }).ToList();
            List<SelectListItem> deger3 = (from x in c.Personels.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.PersonelAd + " " + x.PersonelSoyad,
                                               Value = x.Personelid.ToString()
                                           }).ToList();
            ViewBag.dgr1 = deger1;
            ViewBag.dgr2 = deger2;
            ViewBag.dgr3 = deger3;
            var deger = c.SatisHarekets.Find(id);
            return View("SatisGetir", deger);
        }

        public JsonResult GetUrunFiyat(int urunId)
        {
            var fiyat = c.Uruns.Where(u => u.Urunid == urunId).Select(u => u.SatisFiyat).FirstOrDefault();
            return Json(fiyat, JsonRequestBehavior.AllowGet);
        }


        public ActionResult SatisGüncelle(SatisHareket s)
        {
            var degerler = c.SatisHarekets.Find(s.Satisid);
            degerler.CariId = s.CariId;
            degerler.Adet = s.Adet;
            degerler.PersonelId = s.PersonelId;
            degerler.Tarih = s.Tarih;
            degerler.Fiyat = s.Fiyat;
            degerler.ToplamTutar = s.ToplamTutar;
            degerler.UrunId = s.UrunId;
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult SatisDetay(int id)
        {
            var degerler = c.SatisHarekets.Where(x => x.Satisid == id).ToList();
            return View(degerler);
        }
    }
}