using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OGRENCİMVCNOT.Controllers
{
    public class HesapMakinesiController : Controller
    {
        // GET: HesapMakinesi
        public ActionResult Index(double sayi1 = 0, double sayi2 = 0)
        {
            double sonuctoplam = sayi1 + sayi2;
            double sonuccıkarım = sayi1 - sayi2;
            double sonuccarpım = sayi1 * sayi2;
            double sonucbolum = sayi1 / sayi2;



            ViewBag.tpl = sonuctoplam;
            ViewBag.ckr = sonuccıkarım;
            ViewBag.crp = sonuccarpım;
            ViewBag.blm = sonucbolum;
            ViewBag.sayi1=sayi1;
            ViewBag.sayi2 = sayi2;

            return View();
        }
        
        
    }
    
}