using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Entities
{
    public partial class User{

        public User() {
            //Colecciones
            paperUser = new List<Paper>();
        }

        public User(bool alerted, String areasOfInterest, String email, String login, String password,
                    Area area, Magazine magazine) {
            
            //Atributos
            this.alerted = alerted; 
            this.areasOFInterest = areasOfInterest;
            this.email = email;
            this.login = login; 
            this.password = password;

            //Relaciones a 1
            this.area = area;   
            this.magazine = magazine;

            //Colecciones
            paperUser = new List<Paper>();
        }

    }
}
