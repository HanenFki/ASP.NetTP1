using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using tp1_2.Models.Repositories;
using tp1_2.Models;

namespace tp1_2.Controllers
{
    public class EmployeeController : Controller
    {
        readonly IRepository<Employe> employeRepository;
        //injection de dépendance
        public EmployeeController(IRepository<Employe> empRepository)
        {
            employeRepository = empRepository;
        }
        // GET: EmployeeController
        public ActionResult Index()
        {
            var employees = employeRepository.GetAll();
            return View(employees);
        }

        // GET: EmployeeController/Details/5
        public ActionResult Details(int id)
        {
            var employee = employeRepository.FindByID(id);
            return View(employee);
        }

        // GET: EmployeeController/Create
        public ActionResult Create()
        {
            

            return View();
        }

        // POST: EmployeeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection,Employe e)
        {
            try
            {
                employeRepository.Add(e);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmployeeController/Edit/5
        public ActionResult Edit(int id)
        {

            return View(employeRepository.FindByID(id));
        }

        // POST: EmployeeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection,Employe e)
        {
            try
            {
                employeRepository.Update(id, e);
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
            return View(employeRepository.FindByID(id));
        }

        // POST: EmployeeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Employe e)
        {
            try
            {
                employeRepository.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
