﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineTicariOtomasyon.Models.Siniflar;

namespace OnlineTicariOtomasyon.Controllers
{
    public class GaleriController : Controller
    { 
        Context c = new Context();
        // GET: Galeri
        public ActionResult Index()
        {
            var degerler = c.Uruns.ToList();
            return View(degerler);
        }
    }
}