using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Entities
{
    public partial class Magazine
    {
        public Magazine() { 
            Issues = new List<Issue>();
            Areas = new List<Area>();
        }
        public Magazine(String name, User usuario) { 
            this.Name = Name;

            // Relaciones a 1
            User = Usuario;

            // Colecciones
            this.Issues = new List<Issue>();
            this.Areas = new List<Area>();
        }
    }
}
