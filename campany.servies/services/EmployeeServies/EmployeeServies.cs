using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
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
			Employee employee1 = new Employee()
			{
				address = employee.address,
				age = employee.age,
				departmentId = employee.departmentId,
				email = employee.email,
				hiringdate = employee.hiringdate,
				imageUrl = employee.imageUrl,
				name = employee.name,
				phoneNumber = employee.phoneNumber,
				salary = employee.salary

			};
			_unitOfWork1.DepartmentReprosatory.Add(employee);
			_unitOfWork1.Complete();
		}

		public void Delete(Employee employee)
		{
			Employee employee1 = new Employee()
			{
				address = employee.address,
				age = employee.age,
				departmentId = employee.departmentId,
				email = employee.email,
				hiringdate = employee.hiringdate,
				imageUrl = employee.imageUrl,
				name = employee.name,
				phoneNumber = employee.phoneNumber,
				salary = employee.salary

			};
			_unitOfWork1.DepartmentReprosatory.Delete(employee);
			_unitOfWork1.Complete();
		}

		public IEnumerable<Employee> Getall()
		{
			var employees = _unitOfWork1.EmployeeReprosatory.Getall();
			var mappedEmployees = employees.Select(x => new Employee()
			{
departmentId= x.departmentId,
email=x.email,
hiringdate=x.hiringdate,
imageUrl=x.phoneNumber,
name=x.name,
phoneNumber=x.phoneNumber,
salary=x.salary,
id=x.id,
address=x.address,
age=x.age, creatAt=x.creatAt


			});

			return mappedEmployees;
		}

		public Employee GetById(int? id)
		{
			if (id is null)
			{
				return null;
			}
			var employee = _unitOfWork1.EmployeeReprosatory.GetById(id.Value);
			if (employee is null)
			{
				return null;
			}
			Employee employee1 = new Employee()
			{
				address = employee.address,
				age = employee.age,
				departmentId = employee.departmentId,
				email = employee.email,
				hiringdate = employee.hiringdate,
				imageUrl = employee.imageUrl,
				name = employee.name,
				phoneNumber = employee.phoneNumber,
				salary = employee.salary,
				id = employee.id,
				creatAt = employee.creatAt

			};
			return employee1;
			
		}

		public IEnumerable<Employee> GetEmployeeByName(string name)
		{
			var employees = _unitOfWork1.EmployeeReprosatory.GetEmployeeByName(name);


			var mappedEmployees = employees.Select(x => new Employee()
			{
				departmentId = x.departmentId,
				email = x.email,
				hiringdate = x.hiringdate,
				imageUrl = x.phoneNumber,
				name = x.name,
				phoneNumber = x.phoneNumber,
				salary = x.salary,
				id = x.id,
				address = x.address,
				age = x.age,
				creatAt = x.creatAt


			});

			return mappedEmployees;
		}
			public void Ubdate(Employee employee)
		{
			_unitOfWork1.EmployeeReprosatory.Ubdate(employee);
			_unitOfWork1.Complete();


		}
	}
}
