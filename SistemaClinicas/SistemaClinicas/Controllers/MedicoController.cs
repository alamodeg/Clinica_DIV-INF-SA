using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaClinicas.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaClinicas.Controllers
{
    public class MedicoController : Controller
    {
        // GET: MedicoController
        public ActionResult MostrarMedicos()
        {
            //Mock temporal
            List<Medico> ListadoMedicos = new List<Medico>();

            Medico mimedico1 = new Medico()
            {
                Nombre = "Jose",
                Matricula = 1231233,
                Especialidad = "Cirujano"
            };

            Medico mimedico2 = new Medico()
            {
                Nombre = "Musi",
                Matricula = 9123,
                Especialidad = "Cardiologo"
            };

            ListadoMedicos.Add(mimedico1);
            ListadoMedicos.Add(mimedico2);

            return View(ListadoMedicos);
        }

        // GET: MedicoController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MedicoController/Create
        public ActionResult CreateMedic()
        {
            return View(new Medico());
        }

        // POST: MedicoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Medico MiMedico)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MedicoController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MedicoController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MedicoController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MedicoController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
