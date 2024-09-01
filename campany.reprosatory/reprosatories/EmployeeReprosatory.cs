using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using campany.data.context;
using campany.data.Entity;
using campany.reprosatory.interfaces;

namespace campany.reprosatory.reprosatories
{
    public class EmployeeReprosatory : GenericReposatory<Employee>, IEmployeeReprosatory
    {
        private readonly campanyDbContext _context;
        public EmployeeReprosatory(campanyDbContext context): base(context)
        {
            _context = context;
        }

        public IEnumerable<Employee> GetEmployeeByAddress(string address)
        {
            throw new NotImplementedException();
        }

        public Employee GetEmployeeByName(string name)
        {
            throw new NotImplementedException();
        }
    }
}
