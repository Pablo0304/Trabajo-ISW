using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazine.Entities
{
    public partial class User : Person
    {
        private bool Alerted { get; set; } // Alerteds

        private String AreasOfInterest { get; set; } // AreasDeInteres

        private String Email { get; set; } // Email 

        private String Login { get; set; } // Login

        private String Password { get; set; } // Password

        private Area Area { get; set; } // Area de la que es editor este user

        private Magazine Magazine { get; set; } // Magazine de la que es editor este user

        private List<Paper> MainAuthoredPapers { get; set; } // Paper del que se encarga este User


    }
}
