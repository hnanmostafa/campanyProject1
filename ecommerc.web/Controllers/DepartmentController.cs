using campany.data.Entity;
using campany.reprosatory.interfaces;
using campany.servies.interfaces.department;
using Microsoft.AspNetCore.Mvc;

namespace campany.web.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly IDepartmentServes _departmentServes1;
        public DepartmentController(IDepartmentServes departmentServes)
        {
            _departmentServes1 = departmentServes;
        }
        public IActionResult Index()
        {
            var departments = _departmentServes1.Getall();

            return View(departments);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Create(Department department)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _departmentServes1.Add(department);
                    return RedirectToAction(nameof(Index));
                }
                ModelState.AddModelError("DepartmentError", " ValidationErrors");


                return View(department);
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("DepartmentError", ex.Message);
                return View(department);
            }
        }
        [HttpGet]
        public IActionResult Details(int? id, string viewName = "Details")
        {
            var department = _departmentServes1.GetById(id);
            if (department is null)
            {
                return NotFound();
            }
            return View(viewName, department);
        }
        [HttpPost]
        public IActionResult Update(int? id)
        {
            return Details(id, "Update");
        }
        [HttpPost]
        public IActionResult Update(int? id, Department department)
        {
            if (department.id != id.Value)
            {
                return NotFound();
            }
            _departmentServes1.Ubdate(department);
            return RedirectToAction(nameof(Index));
        }
       
        public IActionResult Delete(int id)
        {
			var department = _departmentServes1.GetById(id);
            if (department is null)
            {
                return NotFound();
            }
            _departmentServes1.Delete(department);
            return RedirectToAction(nameof(Index));
        }

    }


}
