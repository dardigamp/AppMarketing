using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SistemaMarketing.Models;
using Marketing.Servicios.Campanas;
using Marketing.Servicios.Campanas.Dtos;
using AutoMapper;

namespace SistemaMarketing.Controllers
{
    //[Authorize(Roles = "Admin, Empleado")]
    public class CampanasController : Controller
    {
        //private ApplicationDbContext db = new ApplicationDbContext();
        private ServicioCampanas servicioCampanas;

        public CampanasController()
        {
            servicioCampanas = new ServicioCampanas();
        }

        // GET: Campanas
        public ActionResult Index(string busqueda)
        {
            busqueda = string.IsNullOrEmpty(busqueda) ? string.Empty : busqueda;
            var model = Mapper.Map<IList<CampanaDto>, IList<CampanaViewModel>>(servicioCampanas.Buscar(busqueda));
            return View(new BuscaCampanasViewModel() { Campanas = model });
            //return View(db.CampanaViewModels.ToList());
        }

        public ActionResult Nuevo()
        {
            return View(new CampanaViewModel());
        }

        [HttpPost]
        public ActionResult Nuevo(CampanaViewModel campana)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    // Debemos codificar la reserva
                    CampanaDto campanaDto =
                        Mapper.Map<CampanaViewModel, CampanaDto>(campana);
                    servicioCampanas.Nuevo(campanaDto);                    
                    return RedirectToAction("Index", "Campanas", new { area = "" });
                }
                // reconstruir el objeto anterior <ReservaViewModel>
                ModelState.AddModelError("", "Hubo Error en el Modelo");
                return View(campana);
            }
            //catch (ErrorCreandoCampana ex)
            //{
            //    ModelState.AddModelError("", ex.Message);
            //    return View(campana);
            //}
            catch (Exception)
            {
                throw;
            }
        }

        public ActionResult Editar(int id)
        {
            CampanaDto campana = servicioCampanas.TraerPorId(id);
            if (campana.EsNulo())
                RedirectToAction("NoEncontrado", "Errores", new { area = "" });

            return View(Mapper.Map<CampanaDto, CampanaViewModel>(campana));
        }

        [HttpPost]
        public ActionResult Editar(CampanaViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var campana = Mapper.Map<CampanaViewModel, CampanaDto>(model);
                    servicioCampanas.Actualizar(campana);
                    return RedirectToAction("Index", "Campanas", new { area = "" });
                }
                ModelState.AddModelError("", "Hubo Error en el Modelo");
                return View(model);
            }
            catch (Exception)
            {
                ModelState.AddModelError("", "Hubo Error en el Modelo");
                return View(model);
            }
        }

        //// GET: Campanas/Details/5
        //public ActionResult Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    CampanaViewModel campanaViewModel = db.CampanaViewModels.Find(id);
        //    if (campanaViewModel == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(campanaViewModel);
        //}

        //// GET: Campanas/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: Campanas/Create
        //// Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        //// más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create([Bind(Include = "Id,Nombre,Descripcion,FechaInicio,FechaFin,Estado")] CampanaViewModel campanaViewModel)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.CampanaViewModels.Add(campanaViewModel);
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }

        //    return View(campanaViewModel);
        //}

        //// GET: Campanas/Edit/5
        //public ActionResult Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    CampanaViewModel campanaViewModel = db.CampanaViewModels.Find(id);
        //    if (campanaViewModel == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(campanaViewModel);
        //}

        //// POST: Campanas/Edit/5
        //// Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        //// más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit([Bind(Include = "Id,Nombre,Descripcion,FechaInicio,FechaFin,Estado")] CampanaViewModel campanaViewModel)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Entry(campanaViewModel).State = EntityState.Modified;
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    return View(campanaViewModel);
        //}

        //// GET: Campanas/Delete/5
        //public ActionResult Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    CampanaViewModel campanaViewModel = db.CampanaViewModels.Find(id);
        //    if (campanaViewModel == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(campanaViewModel);
        //}

        //// POST: Campanas/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public ActionResult DeleteConfirmed(int id)
        //{
        //    CampanaViewModel campanaViewModel = db.CampanaViewModels.Find(id);
        //    db.CampanaViewModels.Remove(campanaViewModel);
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        db.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}
    }
}
