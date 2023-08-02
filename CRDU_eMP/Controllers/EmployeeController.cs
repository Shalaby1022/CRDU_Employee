using CRDU_eMP.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CRDU_eMP.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly EFContext _context;

        public EmployeeController(EFContext context)
        {
            _context = context;
        }

        public ActionResult Index()
        {
            List<Employee> employees = _context.Employees.ToList();
            return View(employees);

            
        }
        public IActionResult Details(int? id)
        {

            if (id == null)
            {
                return NotFound();
            }

            var employee = _context.Employees.FirstOrDefault(e => e.Id == id);
            if (employee == null)
            {
                return NotFound();
            }

            return View(employee);
        }

        // GET: Employee/Create
        public IActionResult Create()
        {
            var offices = _context.Offices.ToList();
            ViewBag.Offices = offices;
            return View();
        }

        // POST: Employee/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
                _context.Add(employee);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            // If the model state is not valid, we need to repopulate the ViewBag with the list of offices again.
            var offices = _context.Offices.ToList();
            ViewBag.Offices = offices;

            return View(employee);
        }


        // GET: Employee/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employee = _context.Employees.FirstOrDefault(e => e.Id == id);
            if (employee == null)
            {
                return NotFound();
            }

            // Retrieve the list of offices from the database
            var offices = _context.Offices.ToList();
            ViewBag.Offices = offices;

            return View(employee);
        }

        // POST: Employee/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("Id,Name,Age,Salary,Email,Password,OfficeId")] Employee employee)
        {
            if (id != employee.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _context.Update(employee);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            // If the model state is not valid, we need to repopulate the ViewBag with the list of offices again.
            var offices = _context.Offices.ToList();
            ViewBag.Offices = offices;

            return View(employee);
        }



        // GET: Employee/Delete/5
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            // Use eager loading to include the Office navigation property
            var employee = _context.Employees.Include(e => e.Office).FirstOrDefault(e => e.Id == id);
            if (employee == null)
            {
                return NotFound();
            }

            return View(employee);
        }

        // POST: Employee/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var employee = _context.Employees.FirstOrDefault(e => e.Id == id);
            if (employee == null)
            {
                return NotFound();
            }

            _context.Employees.Remove(employee);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }






    }
}
