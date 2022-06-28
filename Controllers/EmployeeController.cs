using EmployeesMVCApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeesMVCApp.Controllers
{
    public class EmployeeController : Controller
    {
        private static IList<EmployeeModel> employees = new List<EmployeeModel>()
        {
            new EmployeeModel(){ EmployeeId = 1, Name = "Jacek", Lastname = "Filipski", Age = 27, DateOfHired = new DateTime(2019, 04, 11), JobPosition = "CEO", PhoneNumber = "721066887", 
                Email = "jckfksi@email.com", City = "Gdańsk", ZIPCode = "80-174", Street = "Potęgowska", BuildingNumber = "20", ApartmentNumber = "4"},
            new EmployeeModel(){ EmployeeId = 2, Name = "Bartek", Lastname = "Nadolny", Age = 22, DateOfHired = new DateTime(2020, 03, 01), JobPosition = "Assistant", PhoneNumber = "758458963",
                Email = "bartasgsist@email.com", City = "Gdańsk", ZIPCode = "80-180", Street = "Kolorowa", BuildingNumber = "4", ApartmentNumber = null}
        };
        // GET: EmployeeController
        public ActionResult Index()
        {
            return View(employees);
        }

        // GET: EmployeeController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: EmployeeController/Create
        public ActionResult Create()
        {
            return View(new EmployeeModel());
        }

        // POST: EmployeeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(EmployeeModel employee)
        {
            employee.EmployeeId = employees.Count + 1;
            employees.Add(employee);

            return RedirectToAction(nameof(Index));
        }

        // GET: EmployeeController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: EmployeeController/Edit/5
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

        // GET: EmployeeController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EmployeeController/Delete/5
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
