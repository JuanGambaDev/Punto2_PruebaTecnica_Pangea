using Punto2.Data;
using Punto2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Punto2.Controllers
{
    public class EtiquetasController : Controller
    {

        EtiquetasAdmin admin = new EtiquetasAdmin();

        // GET: Etiquetas
        public ActionResult Index()
        {
            IEnumerable<Etiquetas> lista = admin.Consultar();
            ViewBag.mensaje = "";
            return View(lista);
        }

        public ActionResult Guardar()
        {
            ViewBag.mensaje = "";
            return View();
        }

        public ActionResult Nuevo(Etiquetas modelo)
        {
            admin.Guardar(modelo);
            ViewBag.mensaje = "Etiqueta guardada";
            return View("Guardar", modelo);
        }

        public ActionResult Detalle(int id=0)
        {
            Etiquetas modelo = admin.Consultar(id);
            return View(modelo);
        }

        public ActionResult Modificar(int id=0)
        {
            ViewBag.mensaje = "";
            Etiquetas modelo = admin.Consultar(id);
            return View(modelo);
        }

        public ActionResult Actualizar(Etiquetas modelo)
        {
            admin.Modificar(modelo);
            ViewBag.mensaje = "Etiqueta modificada.";
            return View("Modificar", modelo);
        }

        public ActionResult Eliminar (int id=0)
        {
            Etiquetas modelo = new Etiquetas()
            {
                Id = id
            };
            admin.Eliminar(modelo);
            IEnumerable<Etiquetas> lista = admin.Consultar();
            ViewBag.mensaje = "Etiqueta eliminada.";
            return View("Index", lista);  
        }
    }
}