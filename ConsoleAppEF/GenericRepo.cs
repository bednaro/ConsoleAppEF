using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEF
{
    interface IGenericRepo<T>
    {
        List<T> GetAll();
        T GetByID(int i);
        void Add(T t);
        void Delete(int id);
        void Update(int id, T t);

        T GetByCustom(Func<T, bool> predicate);
    }
}
