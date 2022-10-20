    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazine.Entities
{
    public partial class Area
    {
        public int Id { get; set; } // Id

        public String Name { get; set; } // name

        public virtual User Editor { get; set; } // Usuario editor de esa Area

        public virtual Magazine Magazine { get; set; } // Revista que contiene esta Area

        public virtual ICollection<Paper> Papers { get; set; }

        public virtual ICollection<Paper> EvaluationPending { get; set; }

        public virtual ICollection<Paper> PublicationPending { get; set; }

    }
}
