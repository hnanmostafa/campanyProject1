using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using campany.data.Entity;

namespace campany.servies.interfaces.department
{
    public interface IDepartmentServes
    {
        Department GetById(int? id);
        IEnumerable<Department> Getall();

        void Add(Department department);
        void Ubdate(Department department);
        void Delete(Department department);
    }
}
