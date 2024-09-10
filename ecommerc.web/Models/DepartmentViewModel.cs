using campany.data.Entity;

namespace campany.web.Models
{
	public class DepartmentViewModel
	{
		public int id { get; set; }
		public string name { get; set; }
		public string code { get; set; }
		public DateTime creatAt { get; set; }
		public ICollection<EmployeeViewModel> Employees { get; set; } = new List<EmployeeViewModel>();
	}
}
