using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Magazine.Entities
{
    public partial class Person
    {
        [Key]
        public String Id { get; set; } // Id 

        public String Name { get; set; } // Name

        public String Surname { get; set; } // Surname

        public virtual ICollection<Paper> CoAuthoredPapers { get; set; } // Paper del que se encarngan
    }
}
