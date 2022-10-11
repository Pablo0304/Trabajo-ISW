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

        private String name { get; set; } // Name

        private String surname { get; set; } // Surname

        private List<Paper> coAuthoredPapers { get; set; } // Paper del que se encarngan
    }
}
