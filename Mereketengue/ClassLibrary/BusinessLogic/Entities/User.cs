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

        public User(String id, String name, String surname, Boolean alerted, String areasOfInterest, String email, String login, String password ) : base(id, name, surname) {
            
            //Atributos
            this.Alerted = alerted; 
            this.AreasOfInterest = areasOfInterest;
            this.Email = email;
            this.Login = login; 
            this.Password = password;


            //Colecciones
            MainAuthoredPapers = new List<Paper>();
        }

    }
}
