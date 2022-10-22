using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazine.Entities
{
    public partial class Person
    {
        public Person() 
        {
            CoAuthoredPapers = new List<Paper>();
        }

        public Person(String id, String Name, String Surname) : this()
        {   
            this.Id = id;
            this.Name = Name;
            this.Surname = Surname;

            //Colecciones
            CoAuthoredPapers = new List<Paper>();
        }
    }
}
