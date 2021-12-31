using Rehber.Models.Context;
using Rehber.Models.Entities;
using Rehber.Models.KisiModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Rehber.Controllers
{
    public class KişiController : Controller
    {
        MvcRehberContext db = new MvcRehberContext();
        // GET: Kişi
        public ActionResult Index()
        {
            var kisiler = db.Kisiler.ToList();
            return View(kisiler);
        }
        // sayfayı açmak ıcın kullanılır
        [HttpGet]
        public ActionResult Ekle()
        {
            var model = new KisiEkleVİewModel
            {

                Kisi = new Kişi(),
                Sehirler= db.Sehirler.ToList()
            
            };
            return View(model);
        }

        [HttpPost]
        public ActionResult Ekle(Kişi kisi)
        {
            db.Kisiler.Add(kisi);
            db.SaveChanges();



            return RedirectToAction("Index");
        }
    }
}