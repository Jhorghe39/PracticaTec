using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using PruebaTecnica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaTecnica.Controllers
{
    public class HabilidadController : Controller
    {
        private EmpleadoContext _context;
        // GET: EmpleadoController
        public ActionResult Index()
        {
            var areas = new List<Habilidad>();
            areas = _context.Habilidades.Where(emp => emp.Id > 0).ToList();

            return View(areas);
        }

        // GET: EmpleadoController/Details/5
        public ActionResult Details(int id)
        {
            var habilidad = new Habilidad();
            habilidad = _context.Habilidades.First(emp => emp.Id == id);

            return View(habilidad);
        }

        // GET: EmpleadoController/Create
        public ActionResult Create()
        {
            var emp = new List<Empleado>();
            emp = _context.Empleados.Where(e => e.Id > 0).ToList();
            ViewBag.Emp = new SelectList(emp, "Id", "NombreCompleto");
            return View();
        }

        // POST: EmpleadoController/Create
        [HttpPost]
        public ActionResult Create(Habilidad habilidad, int Idemp)
        {
            try
            {
                habilidad.IdEmpleado = Idemp;
                _context.Habilidades.Add(habilidad);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmpleadoController/Edit/5
        public ActionResult Edit(int id)
        {
            var emp = new List<Empleado>();
            emp = _context.Empleados.Where(e => e.Id > 0).ToList();
            ViewBag.Emp = new SelectList(emp, "Id", "NombreCompleto");


            var habilidad = new Habilidad();
            habilidad = _context.Habilidades.First(emp => emp.Id == id);
            return View(habilidad);
        }

        // POST: AreaController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Habilidad habilidad)
        {
            try
            {
                _context.Habilidades.Update(habilidad);
                _context.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AreaController/Delete/5
        public ActionResult Delete(int id)
        {
            var habilidad = new Habilidad();
            habilidad = _context.Habilidades.First(emp => emp.Id == id);

            return View(habilidad);
        }

        // POST: AreaController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                var habilidad = new Habilidad();
                habilidad = _context.Habilidades.First(emp => emp.Id == id);

                _context.Habilidades.Remove(habilidad);
                _context.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        public HabilidadController(EmpleadoContext context)
        {
            _context = context;
        }
    }
}
