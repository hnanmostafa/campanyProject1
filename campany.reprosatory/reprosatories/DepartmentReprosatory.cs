using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using campany.data.context;
using campany.data.Entity;
using campany.reprosatory.interfaces;
using Microsoft.EntityFrameworkCore;

namespace campany.reprosatory.reprosatories
{
    public class DepartmentReprosatory :GenericReposatory<Department>, IDepartmentReprosatory
    {
        private readonly campanyDbContext _context;
        public DepartmentReprosatory(campanyDbContext context) : base(context)
        {
            _context = context;
        }
       
    }
}
