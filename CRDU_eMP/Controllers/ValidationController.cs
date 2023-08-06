using CRDU_eMP.Models;
using CRDU_eMP.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CRDU_eMP.Controllers
{
    public class ValidationController : Controller
    {
        EFContext _context;
        public ValidationController(EFContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult add()
        {
            AddEmpView addEmpView = new AddEmpView() { Offices = new SelectList(_context.Offices.ToList(), "Id", "Name") };

            return View(addEmpView);
        }
        [HttpPost]
        public IActionResult add( AddEmpView addEmpView)
        {
            if (ModelState.IsValid)
            {
                Employee employee = new Employee();
                employee.Id = addEmpView.Id;
                employee.Name = addEmpView.Name;
                employee.Salary = addEmpView.Salary;
                employee.Age = addEmpView.Age;
                employee.Email = addEmpView.Email;
                employee.Password = addEmpView.Password;
                employee.OfficeId = addEmpView.Off_Id;
                _context.Employees.Add(employee);
                _context.SaveChanges();
                return RedirectToAction("Index", "Employee");
            }
            else
            {
                addEmpView.Offices = new SelectList(_context.Offices.ToList(), "Id", "Name");
                return View(addEmpView);
            }
        }






    }
}







