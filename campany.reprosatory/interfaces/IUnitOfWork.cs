using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace campany.reprosatory.interfaces
{
	public interface IUnitOfWork
	{
		
		public IDepartmentReprosatory DepartmentReprosatory { get; set; }
		public IEmployeeReprosatory EmployeeReprosatory { get; set; }
		int Complete();
	}
}
