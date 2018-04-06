using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEF
{
    class Program
    {
        static void Main(string[] args)
        {
            /* OsobaDBContext db = new OsobaDBContext();
             Osoba os = new Osoba() { Imie = "stefan"};
             // 
             db.Osoby.Add(os);
             db.SaveChanges();*/

            List<Person> per = new List<Person>();
            per.Add(new Person(){ Id = 1, Name = "Geroge", Surname = "Lucas", Age = 71 });
            per.Add(new Person() { Id = 2, Name = "Kyle", Surname = "Broflovsky", Age = 8 });
            //per ;
            PersonRepo Crud = new PersonRepo();
            Crud.InsertToDatabase(per);

            generic<int> gen = new generic<int>();
            
        }
    }
    class generic<T>
    {
        public T GetData(T i)
        {
            return i;
        }
    }
}
