using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEF
{
    interface IRepository
    {
        void InsertToDatabase(List<Person> PersonList);
        void GetByCustom(Func<Person, bool> fun);
        
    }
}
