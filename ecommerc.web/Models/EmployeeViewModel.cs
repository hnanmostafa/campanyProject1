using campany.data.Entity;

namespace campany.web.Models
{
	public class EmployeeViewModel
	{
		public string name { get; set; }
		public int age { get; set; }
		public string address { get; set; }
		public decimal salary { get; set; }
		public string email { get; set; }
		public string phoneNumber { get; set; }
		public DateTime hiringdate { get; set; }
		public string imageUrl { get; set; }
		public DepartmentViewModel department { get; set; }
		public int? departmentId { get; set; }

	}
}
