using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Entities
{
    public partial class User : Person
    {
        private bool alerted { get; set; } // Alerteds

        private string areasOFInterest { get; set; } // AreasDeInteres

        private string email { get; set; } // Email 

        private string login { get; set; } // Login

        private string password { get; set; } // Password

        private Area area { get; set; } // Area de la que es editor este user

        private Magazine magazine { get; set; } // Magazine de la que es editor este user

        private Paper paper { get; set; } // Paper del que se encarga este User


    }
}
