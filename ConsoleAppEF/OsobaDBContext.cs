using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;

namespace ConsoleAppEF
{
    class OsobaDBContext : DbContext
    {
        public OsobaDBContext() : base("MojeDB")
        {
            
        }
        public DbSet<Osoba> Osoby { get; set; } //odpowiednik tabeli 

    }
    
}
