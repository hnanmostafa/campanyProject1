using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using campany.data.Entity;

namespace campany.reprosatory.interfaces
{
    public interface IGenericReposatory<T> where T : BaseEntity
    {
        T GetById(int id);
        IEnumerable<T> Getall();

        void Add(T entity);
        void Ubdate(T entity);
        void Delete(T entity);
    }
}
