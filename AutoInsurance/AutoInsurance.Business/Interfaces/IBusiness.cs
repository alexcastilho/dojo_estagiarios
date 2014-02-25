using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoInsurance.Business.Interfaces
{
    public interface IBusiness<T>
    {
        void Insert(T obj);
        void Update(T obj);
        void Delete(int id);
        T Find(int id);
        List<T> FindAll();
    }
}
