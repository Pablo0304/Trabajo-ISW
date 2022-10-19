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

        private String Name { get; set; } // Name

        private String Surname { get; set; } // Surname

        private List<Paper> CoAuthoredPapers { get; set; } // Paper del que se encarngan
    }
}
