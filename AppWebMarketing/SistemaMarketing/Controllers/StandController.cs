using AutoMapper;
using Marketing.Servicios.Campanas;
using Marketing.Servicios.Campanas.Dtos;
using SistemaMarketing.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SistemaMarketing.Controllers
{
    public class StandController : Controller
    {
        private ServicioCampanas servicioCampanas;
        public StandController()
        {
            servicioCampanas = new ServicioCampanas();
        }
        // GET: Stand
        public ActionResult Nuevo()
        {
            var modelCampanas = Mapper.Map<IList<CampanaDto>, IList<CampanaViewModel>>(servicioCampanas.Buscar(String.Empty));
            var model = new StandViewModel {
                Campaña = new SelectList(modelCampanas, "Id", "Nombre")
            };
            return View(model);
        }
    }
}