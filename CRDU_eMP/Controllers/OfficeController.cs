using CRDU_eMP.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CRDU_eMP.Controllers
{
    public class OfficeController : Controller
    {
        private readonly EFContext _context;

        public OfficeController(EFContext context)
        {
            _context = context;
        }

        public ActionResult Index()
        {
            List<Office> offices = _context.Offices.ToList();
            return View(offices);
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var office = _context.Offices.FirstOrDefault(o => o.Id == id);
            if (office == null)
            {
                return NotFound();
            }

            return View(office);
        }

        // GET: Office/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Office/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Office office)
        {
            try
            {
                _context.Add(office);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return Content($"Something went wrong\n {ex}");
            }

            return View(office);
        }

        // GET: Office/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var office = _context.Offices.FirstOrDefault(o => o.Id == id);
            if (office == null)
            {
                return NotFound();
            }

            return View(office);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Office office)
        {
            Office oldOffice = _context.Offices.SingleOrDefault(o => o.Id == office.Id);

            if (id != office.Id)
            {
                return NotFound();
            }

            try
            {
                oldOffice.Name = office.Name;
                oldOffice.Location = office.Location;

                _context.Update(oldOffice);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return Content($"Something went wrong\n {ex}");
            }

            return View(office);
        }

        // GET: Office/Delete/5
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var office = _context.Offices.FirstOrDefault(o => o.Id == id);
            if (office == null)
            {
                return NotFound();
            }

            return View(office);
        }

        // POST: Office/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var office = _context.Offices.FirstOrDefault(o => o.Id == id);
            if (office == null)
            {
                return NotFound();
            }

            _context.Offices.Remove(office);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
