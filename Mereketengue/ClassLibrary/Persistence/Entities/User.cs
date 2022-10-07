using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Persistence.Entities
{
    partial class User : Person
    {
        private bool Alerted { get; set; } // Alerteds

        private string AreasOFInterest { get; set; } // AreasDeInteres

        private string Email { get; set; } // Email 

        private string Login { get; set; } // Login

        private string Password { get; set; } // Password

        private Area area { get; set; } // Area de la que es editor este user

        private Magazine magazine { get; set; } // Magazine de la que es editor este user

        private Paper paper { get; set; } // Paper del que se encarga este User


    }
}
