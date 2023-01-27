using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazine.Entities
{
    public partial class User : Person
    {
        public bool Alerted { get; set; } // Alerteds

        public String AreasOfInterest { get; set; } // AreasDeInteres

        public String Email { get; set; } // Email 

        public String Login { get; set; } // Login

        public String Password { get; set; } // Password

        public bool MagazineSubscriber { get; set; }

        public virtual Area Area{ get; set; } // Area de la que es editor este user

        public virtual Magazine Magazine { get; set; } // Magazine de la que es editor este user

        public virtual ICollection<Paper> MainAuthoredPapers { get; set; } // Paper del que se encarga este User

    }   
}
