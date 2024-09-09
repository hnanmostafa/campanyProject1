using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using campany.data.Entity;
using campany.reprosatory.interfaces;
using campany.servies.interfaces.employee;

namespace campany.servies.services.EmployeeServies
{
	public class EmployeeServies :IEmployeeServies
	{
		private readonly IUnitOfWork _unitOfWork1;
		public EmployeeServies(IUnitOfWork unitOfWork)
		{
			_unitOfWork1 = unitOfWork;
		}

		public void Add(Employee employee)
		{
			throw new NotImplementedException();
		}

		public void Delete(Employee employee)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<Employee> Getall()
		{
			throw new NotImplementedException();
		}

		public Employee GetById(int? id)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<Employee> GetEmployeeByName(string name)
	=> _unitOfWork1.EmployeeReprosatory.GetEmployeeByName(name); 

		public void Ubdate(Employee employee)
		{
			throw new NotImplementedException();
		}
	}
}
