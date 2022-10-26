using Magazine.Entities;
using Magazine.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }

        private void createSampleDB(IDAL dal)
        {
            // Remove all data from DB
            dal.RemoveAllData();

            Console.WriteLine("Creant les dades i emmagatzemant en la BD");
            Console.WriteLine("===========================================");
            Console.WriteLine("\n// CREACIÓ D’UNA REVISTA i EL SEU EDITOR EN JEFE");
            User u1 = new User("1234", "Pepe", "TheBoss", false, "ninguna",
           "pgarcia@gmail.com", "theboss", "1234");
            dal.Insert<User>(u1);
            dal.Commit();
            Magazine.Entities.Magazine m = new Magazine.Entities.Magazine("Revista Universitaria", u1);


            u1.Magazine = m;

            dal.Insert<Magazine.Entities.Magazine>(m);
            dal.Commit();
            Console.WriteLine("Nom de la revista: " + m.Name);
            Console.WriteLine(" Editor de la revista: " + m.ChiefEditor.Name + " " +
           m.ChiefEditor.Surname);

            Console.ReadKey();
            // Populate here the rest of the database with data
        }
    }
}
