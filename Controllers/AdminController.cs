using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CapaPresentacion.Models;
using System.Web.Mvc;

namespace CapaPresentacion.Controllers
{
    public class AdminController : Controller
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
        public ActionResult Index(string nom, string ced, string dir, string tel, string tipo, string contactoname, string telcontacto)
        {
            if (soc.Agregar(nom, ced, dir, tel, tipo, contactoname, telcontacto))
            {
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
        [HttpGet]
        public ActionResult Editar(int id)
        {
            ViewBag.alerta = "info";
            ViewBag.res = "Editar Socio";
            return View(soc.un_registro(id));

        }

        [HttpPost]

        public ActionResult Editar(int id, string nom, string ced, string dir, string tel, string tipo, string contactoname, string telcontacto)
        {
            if (soc.Editar(id, nom, ced, dir, tel, tipo, contactoname, telcontacto))
            {
                ViewBag.alerta = "Success";
                ViewBag.res = "Socio editado";
            }
            else
            {
                ViewBag.alerta = "danger";
                ViewBag.res = "Socio no actualizada";
            }

            return View(soc.un_registro(id));
        }
        public ActionResult Eliminar(int id)
        {
            if (soc.Eliminar(id))
            {
                return RedirectToAction("Index", "Admin");
            }
            else
            {
                ViewBag.alerta = "danger";
                ViewBag.res = "Socio no eliminado";
                return View(soc.un_registro(id));
            }
        }

        // POST: Admin/Create
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

        // GET: Admin/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Admin/Edit/5
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

        // GET: Admin/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Admin/Delete/5
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

        public ActionResult Login()
        {
            return View();
        }
    }
}
