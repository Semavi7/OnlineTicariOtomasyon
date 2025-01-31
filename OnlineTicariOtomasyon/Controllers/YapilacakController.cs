using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineTicariOtomasyon.Models.Siniflar;

namespace OnlineTicariOtomasyon.Controllers
{
    public class YapilacakController : Controller
    {
        Context c = new Context();
        // GET: Yapilacak
        public ActionResult Index()
        {
            var deger1 = c.Carilers.Count().ToString();
            ViewBag.d1 = deger1;
            var deger2 = c.Uruns.Count().ToString();
            ViewBag.d2 = deger2;
            var deger3 = c.Personels.Count().ToString();
            ViewBag.d3 = deger3;
            var deger4 = (from x in c.Carilers select x.CariSehir).Distinct().Count().ToString();
            ViewBag.d4 = deger4;

            var yapilacaklar = c.Yapilacaks.ToList();
            return View(yapilacaklar);
        }

        [HttpPost]
        public ActionResult YapildiMiGuncelle(int Id)
        {
            var yapilacak = c.Yapilacaks.Where(x => x.Yapilacakid == Id).FirstOrDefault();

            if (yapilacak.Durum) yapilacak.Durum = false;
            else yapilacak.Durum = true;
            c.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult YapilacakEkle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult YapilacakEkle(Yapilacak p)
        {
            c.Yapilacaks.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult YapilacakGetir(int id)
        {
            var prs = c.Yapilacaks.Find(id);
            return View("YapilacakGetir", prs);
        }

        public ActionResult YapilacakGuncelle(Yapilacak p)
        {
            var prsn = c.Yapilacaks.Find(p.Yapilacakid);
            prsn.Baslik = p.Baslik;
            prsn.Tarih = p.Tarih;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}