using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Entities
{
    public partial class Person
    {
        public Person() 
        {
            coAuthoredPapers = new List<Paper>();
        }

        public Person(int id, String name, String surname)
        {
            //Atributos
            this.id = id;
            this.name = name;
            this.surname = surname;

            //Colecciones
            coAuthoredPapers = new List<Paper>();
        }
    }
}
