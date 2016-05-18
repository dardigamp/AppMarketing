﻿using AutoMapper;
using Marketing.Servicios.Campanas;
using Marketing.Servicios.Campanas.Dtos;
using Marketing.Servicios.Clientes;
using Marketing.Servicios.Clientes.Dtos;
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
        private ServicioClientes servicioClientes;
        public StandController()
        {
            servicioCampanas = new ServicioCampanas();
            servicioClientes = new ServicioClientes();
        }
        // GET: Stand
        public ActionResult Nuevo()
        {
            var modelCampanas = Mapper.Map<IList<CampanaDto>, IList<CampanaViewModel>>(servicioCampanas.Buscar(String.Empty));
            var modelClientes = Mapper.Map<IList<ClienteDto>, IList<ClienteViewModel>>(servicioClientes.Buscar(String.Empty));
            var model = new StandViewModel {
                Campaña = new SelectList(modelCampanas, "Id", "Nombre"),
                Cliente = new SelectList(modelClientes, "Id", "RazonSocial")
            };
            return View(model);
        }
    }
}