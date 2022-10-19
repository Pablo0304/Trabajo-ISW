using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazine.Entities
{
    public partial class Magazine
    {
        public Magazine() { 
            issues = new List<Issue>();
            areas = new List<Area>();
        }
        public Magazine(String name, User user) { 
            this.name = name;

            // Relaciones a 1
            this.user = user;

            // Colecciones
            this.issues = new List<Issue>();
            this.areas = new List<Area>();
        }
    }
}
