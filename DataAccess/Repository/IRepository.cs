using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IRepository<T>
    {
        IEnumerable<T> GetList();
        T GetById(int id);
        void Insert(T item);
        void Delete(T item);
        void Update(T item);
    }
}
