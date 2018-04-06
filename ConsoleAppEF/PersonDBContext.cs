using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEF
{
    class PersonDBContext : DbContext
    {
        public PersonDBContext() : base("MojeDB")
        {

        }
        public DbSet<Person> Persons { get; set; }
    }
}
