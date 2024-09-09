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
        private readonly IUnitOfWork _unitOfWork1;
        public DepartmentServies(IUnitOfWork unitOfWork)
        {
            _unitOfWork1 = unitOfWork;
        }
        public void Add(Department department)
        {
            var mappedDepartment = new Department()
            {
                code = department.code,
                name = department.name,
                creatAt = DateTime.Now

            };
            _unitOfWork1.DepartmentReprosatory.Add(mappedDepartment);
            _unitOfWork1.Complete();
        }

        public void Delete(Department department)
        {
			_unitOfWork1.DepartmentReprosatory.Delete(department);
			_unitOfWork1.Complete();
		}

        public IEnumerable<Department> Getall()
        {
            var departments = _unitOfWork1.DepartmentReprosatory.Getall();

            return departments;
        }

        public Department GetById(int? id)
        {
            if (id is null)
            {
                return null;
            }
            var department = _unitOfWork1.DepartmentReprosatory.GetById(id.Value);
            if (department is null)
            {
                return null;
            }
            return department;
        }

        public void Ubdate(Department department)
        {
			_unitOfWork1.DepartmentReprosatory.Ubdate(department);
			_unitOfWork1.Complete();
		}
        }
    }

