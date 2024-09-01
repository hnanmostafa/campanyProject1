using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using campany.data.Entity;

namespace campany.reprosatory.interfaces
{
    public interface IEmployeeReprosatory :IGenericReposatory <Employee>
    {
        Employee GetEmployeeByName(string name);
        IEnumerable<Employee> GetEmployeeByAddress(string address);
    }
}
