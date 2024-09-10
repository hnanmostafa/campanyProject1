using campany.data.Entity;
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
			ViewBag.Massage = "Hello From Employee Index";
			IEnumerable<Employee> employees1 = new List<Employee>();

			if (string.IsNullOrEmpty(searchInp))
			{
				employees1 = _employeeServies1.Getall();
				return View(employees1);
			}
			else
			{
				employees1 = _employeeServies1.GetEmployeeByName(searchInp);
				return View(employees1);
			}



		}
		[HttpGet]
		public IActionResult Create()
		{
			var employee = _employeeServies1.Getall();

			return View(employee);

		}
		[HttpPost]
		public IActionResult Create(Employee employee)
		{
			try
			{
				if (ModelState.IsValid)
				{
					_employeeServies1.Add(employee);
					return RedirectToAction(nameof(Index));
				}



				return View(employee);
			}
			catch (Exception ex)
			{

				return View(employee);
			}
		}

		public void
	}
}
