using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazine.Entities
{
    public partial class User{

        public User() {
            //Colecciones
            MainAuthoredPapers = new List<Paper>();
        }

        public User(String Name, String Surname, Boolean alerted, String areasOfInterest, String email, String login, String password, Area area, Magazine magazine ) :base(Name, Surname) {
            
            //Atributos
            this.Alerted = alerted; 
            this.AreasOfInterest = areasOfInterest;
            this.Email = email;
            this.Login = login; 
            this.Password = password;

            //Relaciones a 1
            Area = area;   
            Magazine = magazine;

            //Colecciones
            MainAuthoredPapers = new List<Paper>();
        }

    }
}
