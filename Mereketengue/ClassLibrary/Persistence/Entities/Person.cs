using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Magazine.Entities
{
    public partial class Person
    {
        public String Id { get; set; } // Id

        public String Name { get; set; } // Name

        public String Surname { get; set; } // Surname

        // public int Count { get; set; }

        public virtual ICollection<Paper> CoAuthoredPapers { get; set; } // Paper del que se encarngan
    }
}
