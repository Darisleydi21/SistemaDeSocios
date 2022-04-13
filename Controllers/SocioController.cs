using System;
using CapaPresentacion.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CapaPresentacion.Controllers
{
    public class SocioController : Controller
    {
        private Socios soc = new Socios();
        [HttpGet]
        public ActionResult Index()
        {
            ViewBag.alerta = "info";
            ViewBag.res = "REGISTRO DE SOCIOS";
            return View(soc.Listado());
        }
        [HttpPost]
        public ActionResult Index(string nom, string ced,  string dir, string tel, string tipo, string contactoname, string telcontacto)
        {
            if (soc.Agregar(nom, ced, dir, tel, tipo, contactoname, telcontacto)){
                ViewBag.alerta = "success";
                ViewBag.res = "REGISTRO EXITOSO";
            }
            else
            {
                ViewBag.alerta = "success";
                ViewBag.res = "REGISTRO EXITOSO";
            }
            return View(soc.Listado());
        }
        // GET: Socio/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Socio/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Socio/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Socio/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Socio/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Socio/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Socio/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
