using campany.reprosatory.interfaces;
using campany.servies.interfaces.department;
using campany.servies.interfaces.employee;
using Microsoft.AspNetCore.Mvc;

namespace campany.web.Controllers
{
	public class EmployeeController1 : Controller
	{
		private readonly IEmployeeServies _employeeServies1;
		public EmployeeController1(IEmployeeServies employeeServies)
		{
			_employeeServies1 = employeeServies;
		}
		public IActionResult Index(string searchInp)
		{
			if (string.IsNullOrEmpty(searchInp))
			{
				var employee = _employeeServies1.Getall();
				return View(employee);
			}
			else
			{
				var employees = _employeeServies1.GetEmployeeByName(searchInp);
				return View(employees);
			}



		}
		[HttpGet]
		public IActionResult Create()
		{
			return View();
		}
		[HttpPost]
		public IActionResult Create()
		{
			return View();
		}
	}
}
