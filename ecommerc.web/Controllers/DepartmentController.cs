using campany.reprosatory.interfaces;
using Microsoft.AspNetCore.Mvc;

namespace campany.web.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly IDepartmentReprosatory _departmentReprosatory;
        public DepartmentController(IDepartmentReprosatory departmentReprosatory)
        {
            _departmentReprosatory = departmentReprosatory;
        }
        public IActionResult Index()
        {
            var departments = _departmentReprosatory.Getall();

            return View(departments);
        }
    }
}
