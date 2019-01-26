using Hipica.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hipica.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            HipicaEntities entidad = new HipicaEntities();
            var listaNivel = entidad.Nivel.ToList();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}