using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Entities
{
    public partial class Person
    {
        private int id { get; set; } // Id

        private string name { get; set; } // Name

        private string surname { get; set; } // Surname

        private Paper paper { get; set; } // Paper del que se encarngan
    }
}
