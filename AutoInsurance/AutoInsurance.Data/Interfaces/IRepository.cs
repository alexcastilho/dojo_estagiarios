using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoInsurance.Data.Interfaces
{
    public interface IRepository<T>
    {
        void Insert(T obj);
        void Delete(int id);
        void Update(T obj);
        T Find(int id);
        List<T> FindAll();
    }
}
