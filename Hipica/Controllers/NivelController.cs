using Hipica.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hipica.Controllers
{
    public class NivelController : Controller
    {
        private HipicaEntities _conexion;
        // GET: Nivel
        public ActionResult Index()
        {
            List<Nivel> listaNiveles = new List<Nivel>();
            using (_conexion = new HipicaEntities())
            {
                listaNiveles = _conexion.Nivel.ToList();
            }
            // Where es para filtar. En este caso queremos obtener aquellos Niveles que tengan un Id menor que 2.
            //listaNiveles = _conexion.Nivel.Where(x => x.Id < 2).ToList();
            return View(listaNiveles);
        }

        public ActionResult Prueba(int idNivel)
        {
            var prueba = "s";

            return View();
        }
    }
}