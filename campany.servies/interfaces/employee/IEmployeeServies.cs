using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using campany.data.Entity;

namespace campany.servies.interfaces.employee
{
	public interface IEmployeeServies
	{
		
			Employee GetById(int? id);
			IEnumerable<Employee> Getall();

			void Add(Employee employee);
			void Ubdate(Employee employee);
		void Delete(Employee employee);
		IEnumerable<Employee> GetEmployeeByName(string name);

	}
}
