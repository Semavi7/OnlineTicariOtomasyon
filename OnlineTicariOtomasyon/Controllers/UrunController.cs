using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineTicariOtomasyon.Models.Siniflar;

namespace OnlineTicariOtomasyon.Controllers
{
    public class UrunController : Controller
    {
        Context c = new Context();
        // GET: Urun
        public ActionResult Index()
        {
            var urunler = c.Uruns.Where(x => x.Durum == true).ToList();
            return View(urunler);
        }

        [HttpGet]
        public ActionResult YeniUrun()
        {
            List<SelectListItem> deger1 = (from x in c.Kategoris.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.KategorAd,
                                               Value = x.Kategoriid.ToString()
                                           }).ToList();
            ViewBag.dgr1 = deger1;
            return View();
        }

        [HttpPost]
        public ActionResult YeniUrun(Urun p)
        {
            c.Uruns.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        
        public ActionResult UrunSil(int id)
        {
            var deger = c.Uruns.Find(id);
            deger.Durum = false;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        
        public ActionResult UrunGetir(int id)
        {
            List<SelectListItem> deger1 = (from x in c.Kategoris.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.KategorAd,
                                               Value = x.Kategoriid.ToString()
                                           }).ToList();
            ViewBag.dgr1 = deger1;
            var urundeger = c.Uruns.Find(id);
            return View("UrunGetir", urundeger);
        }

        public ActionResult UrunGuncelle (Urun p)
        {
            var urn = c.Uruns.Find(p.Urunid);
            urn.Urunid = p.Urunid;
            urn.UrunAd = p.UrunAd;
            urn.Marka = p.Marka;
            urn.Stok = p.Stok;
            urn.AlisFiyat = p.AlisFiyat;
            urn.SatisFiyat = p.SatisFiyat;
            urn.Durum = p.Durum;
            urn.UrunGörsel = p.UrunGörsel;
            urn.KategoriId = p.KategoriId;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}