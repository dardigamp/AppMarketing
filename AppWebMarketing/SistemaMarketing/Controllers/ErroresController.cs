using SistemaMarketing.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SistemaMarketing.Controllers
{
    public class ErroresController : Controller
    {
        // GET: Errores
        public ActionResult NoEncontrado()
        {
            Response.StatusCode = 404;
            var model = new ErrorViewModel
            {
                Encabezado = "HTTP Status: 404 - Not Found",
                IrAlHome = "Regresar",
                Mensaje = "La página no fue encontrada"
            };
            return View(model);
        }

        public ActionResult NoAutorizado()
        {
            Response.StatusCode = 403;
            var model = new ErrorViewModel
            {
                Encabezado = "HTTP Status: 403 - Forbidden",
                IrAlHome = "Ingresa...",
                Mensaje = "Ud. No tiene acceso",
                Controller = "Account",
                Action = "Login"
            };

            return View(model);
        }
    }
}