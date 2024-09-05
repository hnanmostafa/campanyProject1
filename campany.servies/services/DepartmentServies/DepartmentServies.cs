using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using campany.data.Entity;
using campany.reprosatory.interfaces;
using campany.reprosatory.reprosatories;
using campany.servies.interfaces.department;

namespace campany.servies.services.DepartmentServies
{
    public class DepartmentServies : IDepartmentServes
    {
        private readonly IDepartmentReprosatory _departmentReprosatory1;
        public DepartmentServies(IDepartmentReprosatory departmentReprosatory)
        {
            _departmentReprosatory1 = departmentReprosatory;
        }
        public void Add(Department department)
        {
            var mappedDepartment = new Department()
            {
                code = department.code,
                name = department.name,
                creatAt = DateTime.Now

            };
            _departmentReprosatory1.Add(mappedDepartment);
        }

        public void Delete(Department department)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Department> Getall()
        {
            var departments = _departmentReprosatory1.Getall();

            return departments;
        }

        public Department GetById(int? id)
        {
            if (id is null)
            {
                return null;
            }
            var department = _departmentReprosatory1.GetById(id.Value);
            if (department is null)
            {
                return null;
            }
            return department;
        }

        public void Ubdate(Department department)
        {
            var dept = GetById(department.id);
            if(dept.name!= department.name)
            {
                if (Getall().Any(x => x.name == department.name
                ))
                {
                    throw new Exception("DuplicateDepartmentName");
                }
                dept.name = department.name;
                dept.code = department.code;
                _departmentReprosatory1.Ubdate(department);
            }
        }
    }
}
