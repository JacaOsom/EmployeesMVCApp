using EmployeesMVCApp.Models;
using EmployeesMVCApp.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeesMVCApp.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeesRepository _employeesRepository;

        public EmployeeController(IEmployeesRepository employeesRepository)
        {
            _employeesRepository = employeesRepository;
        }


        // GET: EmployeeController
        public ActionResult Index()
        {
            return View(_employeesRepository.GetEmployees());
        }

        // GET: EmployeeController/Details/5
        public ActionResult Details(int id)
        {
            return View(_employeesRepository.Get(id));
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
            _employeesRepository.Add(employee);

            return RedirectToAction(nameof(Index));
        }

        // GET: EmployeeController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(_employeesRepository.Get(id));
        }

        // POST: EmployeeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, EmployeeModel employeeModel)
        {
            _employeesRepository.Update(id, employeeModel);

            return RedirectToAction(nameof(Index));
        }

        // GET: EmployeeController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(_employeesRepository.Get(id));
        }

        // POST: EmployeeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, EmployeeModel employeeModel)
        {
            _employeesRepository.Delete(id);

            return RedirectToAction(nameof(Index));

        }
    }
}
