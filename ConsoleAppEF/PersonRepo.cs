using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEF
{
    class PersonRepo : IRepository
    {
        public void GetByCustom(Func<Person, bool> fun)
        {
            
        }

        public void InsertToDatabase(List<Person> PersonList)
        {
            PersonDBContext ctx = new PersonDBContext();
            
                foreach (var item in PersonList)
                {
                    ctx.Persons.Add(item);
                }

                ctx.SaveChanges();
            
        }

    }
}
