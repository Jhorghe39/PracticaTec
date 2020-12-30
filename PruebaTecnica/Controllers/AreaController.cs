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
    public class AreaController : Controller
    {
        private EmpleadoContext _context;
        // GET: EmpleadoController
        public ActionResult Index()
        {
            var areas = new List<Area>();
            areas = _context.Areas.Where(emp => emp.Id > 0).ToList();

            return View(areas);
        }

        // GET: EmpleadoController/Details/5
        public ActionResult Details(int id)
        {
            var area = new Area();
            area = _context.Areas.First(emp => emp.Id == id);

            return View(area);
        }

        // GET: EmpleadoController/Create
        public ActionResult Create()
        {
            var areas = new List<Area>();
            areas = _context.Areas.Where(ar => ar.Id > 0).ToList();
            ViewBag.Area = new SelectList(areas, "Id", "Nombre");

            var jefes = new List<Area>();
            jefes = _context.Areas.Where(je => je.Id > 0).ToList();
            ViewBag.Jefe = new SelectList(jefes, "Id", "NombreCompleto");
            return View();
        }

        // POST: EmpleadoController/Create
        [HttpPost]
        public ActionResult Create(Area area, int IdJefe, int IdArea)
        {
            try
            {
                _context.Areas.Add(area);
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

            var jefes = new List<Area>();
            jefes = _context.Areas.Where(je => je.Id > 0).ToList();
            ViewBag.Jefe = new SelectList(jefes, "Id", "NombreCompleto");


            var area = new Area();
            area = _context.Areas.First(emp => emp.Id == id);
            return View(area);
        }

        // POST: AreaController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Area area)
        {
            try
            {
                _context.Areas.Update(area);
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
            var area = new Area();
            area = _context.Areas.First(emp => emp.Id == id);

            return View(area);
        }

        // POST: AreaController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                var area = new Area();
                area = _context.Areas.First(emp => emp.Id == id);

                _context.Areas.Remove(area);
                _context.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        public AreaController(EmpleadoContext context)
        {
            _context = context;
        }
    }
}
