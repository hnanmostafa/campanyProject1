using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using campany.data.context;
using campany.reprosatory.interfaces;

namespace campany.reprosatory.reprosatories
{
	public class UnitOfWork : IUnitOfWork
	{
		private readonly campanyDbContext _context;
		public UnitOfWork(campanyDbContext context)

		{
			_context = context;
			DepartmentReprosatory = new DepartmentReprosatory(context);
			EmployeeReprosatory = new EmployeeReprosatory(context);
		}

		public IDepartmentReprosatory DepartmentReprosatory { get; set ; }
		public IEmployeeReprosatory EmployeeReprosatory { get; set; }

		public int Complete()
		=> _context.SaveChanges();
	}
}
