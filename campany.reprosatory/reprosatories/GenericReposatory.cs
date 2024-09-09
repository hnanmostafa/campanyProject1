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
    public class GenericReposatory<T> : IGenericReposatory<T> where T : BaseEntity
    {
        private readonly campanyDbContext _context;
        public GenericReposatory(campanyDbContext context) {
            _context = context;
        }

        public void Add(T entity)
       
           => _context.Set<T>().Add(entity);
        

        public void Delete(T entity)
        
          =>  _context.Set<T>().Remove(entity);
        

        public IEnumerable<T> Getall()
        => _context.Set<T>().ToList();


        public T GetById(int id)
        => _context.Set<T>().Find(id);

        public void Ubdate(T entity)
        
          =>  _context.Set<T>().Update(entity);
        
    }
}
