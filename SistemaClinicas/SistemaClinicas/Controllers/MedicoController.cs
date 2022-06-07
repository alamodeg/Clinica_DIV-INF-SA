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
            List<Medico> ListadoMedicos = new List<Medico>();

            Medico med1 = new Medico("Jose", 19923, "Ginecologo");
            Medico med2 = new Medico("Javier", 32123, "Cirujano");

            ListadoMedicos.Add(med1);
            ListadoMedicos.Add(med2);

            return View(ListadoMedicos);
        }

        // GET: MedicoController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MedicoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MedicoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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
