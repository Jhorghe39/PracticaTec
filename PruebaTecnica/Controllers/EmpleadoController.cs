using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using PruebaTecnica.Models;
using System.Collections.Generic;
using System.Linq;

namespace PruebaTecnica.Controllers
{
    public class EmpleadoController : Controller
    {
        private EmpleadoContext _context;
        // GET: EmpleadoController
        public ActionResult Index()
        {
            var empleados = new List<Empleado>();
            empleados = _context.Empleados.Where(emp => emp.Id > 0).ToList();

            return View(empleados);
        }

        // GET: EmpleadoController/Details/5
        public ActionResult Details(int id)
        {
            var empleado = new Empleado();
            empleado = _context.Empleados.First(emp => emp.Id == id);

            return View(empleado);
        }

        // GET: EmpleadoController/Create
        public ActionResult Create()
        {          
            var areas = new List<Area>();
            areas = _context.Areas.Where(ar => ar.Id > 0).ToList();
            ViewBag.Area = new SelectList(areas, "Id", "Nombre");

            var jefes = new List<Empleado>();
            jefes = _context.Empleados.Where(je => je.Id > 0).ToList();
            ViewBag.Jefe = new SelectList(jefes, "Id", "NombreCompleto");
            return View();
        }

        // POST: EmpleadoController/Create
        [HttpPost]
        public ActionResult Create(Empleado empleado, int IdJefe, int IdArea)
        {
            try
            {                
                _context.Empleados.Add(empleado);
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
            var areas = new List<Area>();
            areas = _context.Areas.Where(ar => ar.Id > 0).ToList();
            ViewBag.Area = new SelectList(areas, "Id", "Nombre");

            var jefes = new List<Empleado>();
            jefes = _context.Empleados.Where(je => je.Id > 0).ToList();
            ViewBag.Jefe = new SelectList(jefes, "Id", "NombreCompleto");
            

            var empleado = new Empleado();
            empleado = _context.Empleados.First(emp => emp.Id == id);
            return View(empleado);
        }

        // POST: EmpleadoController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Empleado empleado)
        {
            try
            {
                _context.Empleados.Update(empleado);
                _context.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmpleadoController/Delete/5
        public ActionResult Delete(int id)
        {
            var empleado = new Empleado();
            empleado = _context.Empleados.First(emp => emp.Id == id);

            return View(empleado);
        }

        // POST: EmpleadoController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                var empleado = new Empleado();
                empleado = _context.Empleados.First(emp => emp.Id == id);

                _context.Empleados.Remove(empleado);
                _context.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        public EmpleadoController(EmpleadoContext context)
        {
            _context = context;
        }
    }
}
