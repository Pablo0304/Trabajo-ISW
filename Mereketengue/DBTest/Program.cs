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
            dal.Commit();


            User u2 = new User("user", "Aitor", "Tilla", false, "ninguna", "AitorTilla@gmail.com", "HayTortillla", "contrasena");
            dal.Insert<User>(u2);
            Console.WriteLine("Ya hay tortilla");
            dal.Commit();

            User u3 = new User("4321", "Cindy", "Nero", false, "ninguna", "Sindinero@gmail.com", "MoreMoneyMoreProblems", "añesartnoc");
            dal.Insert<User>(u3);
            dal.Commit();
            Console.WriteLine("Cindy creada");
            
            Magazine.Entities.Magazine m1 = new Magazine.Entities.Magazine("Revista Universitaria", u1);
            u1.Magazine = m1;
            dal.Insert<Magazine.Entities.Magazine>(m1);
            dal.Commit();

            Area a1 = new Area("Deportes", u1, m1);
            m1.Areas.Add(a1);
            u1.Area = a1;   
            dal.Insert<Area>(a1);
            dal.Commit();

            Paper p1 = new Paper("Jua Carlos", Convert.ToDateTime("01/03/2004"), a1, u2);
            a1.Papers.Add(p1);
            u3.MainAuthoredPapers.Add(p1);
            u2.CoAuthoredPapers.Add(p1);
            dal.Insert<Paper>(p1);
            dal.Commit();

            Evaluation e1 = new Evaluation(true, "ninguno", Convert.ToDateTime("01/06/2011"));
            p1.Evaluation = e1;
            dal.Insert<Evaluation>(e1);
            dal.Commit();

            Issue i1 = new Issue(12, m1);
            p1.Issue = i1;
            i1.PublishedPapers.Add(p1);
            dal.Insert<Paper>(p1);
            dal.Commit();

            Area a2 = new Area("Coches", u2, m1);
            m1.Areas.Add(a1);
            u2.Area = a1;
            dal.Insert<Area>(a1);
            dal.Commit();


            Console.ReadKey();
            // Populate here the rest of the database with data
            
        }

        
        

    }
}
