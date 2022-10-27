using Magazine.Entities;
using Magazine.Persistence;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBTest
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            IDAL dal = new EntityFrameworkDAL(new MagazineDbContext());

            // Remove all data from DB
            dal.RemoveAllData();

            Console.WriteLine("Creant les dades i emmagatzemant en la BD");
            Console.WriteLine("===========================================");
            Console.WriteLine("\n// CREACIÓ D’UNA REVISTA i EL SEU EDITOR EN JEFE");
            User u1 = new User("1234", "Pepe", "TheBoss", false, "ninguna", "pgarcia@gmail.com", "theboss", "1234");
            dal.Insert<User>(u1);
            Magazine.Entities.Magazine m = new Magazine.Entities.Magazine("Revista Universitaria", u1);

            User u2 = new User("2345", "Aitor", "Tilla", false, "ninguna", "AitorTilla@gmail.com", "HayTortillla", "contrasena");
            dal.Insert<User>(u2);
            Console.WriteLine("Ya hay tortilla");
            Magazine.Entities.Magazine n = new Magazine.Entities.Magazine("Revista Universitaria", u2);

            User u3 = new User("4321", "Cindy", "Nero", false, "ninguna", "Sindinero@gmail.com", "MoreMoneyMoreProblems", "añesartnoc");
            dal.Insert<User>(u3);
            Console.WriteLine("Cindy creada");
            Magazine.Entities.Magazine o = new Magazine.Entities.Magazine("Revista Universitaria", u3);
            dal.Commit();

            u1.Magazine = m;
            u2.Magazine = n;
            u3.Magazine = o;

            dal.Insert<Magazine.Entities.Magazine>(m);
            dal.Insert<Magazine.Entities.Magazine>(n);
            dal.Insert<Magazine.Entities.Magazine>(o);
            dal.Commit();
            Console.WriteLine("Nom de la revista: " + m.Name);
            Console.WriteLine(" Editor de la revista: " + m.ChiefEditor.Name + " " + m.ChiefEditor.Surname);

            Console.ReadKey();
            // Populate here the rest of the database with data
            
        }

        
        

    }
}
