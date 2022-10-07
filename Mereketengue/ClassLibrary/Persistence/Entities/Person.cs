using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Entities
{
    public partial class Person
    {
        private int Id { get; set; } // Id

        private string Name { get; set; } // Name

        private string Surname { get; set; } // Surname

        private Paper paper { get; set; } // Paper del que se encarngan
    }
}
