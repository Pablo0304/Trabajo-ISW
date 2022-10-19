using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazine.Entities
{
    public partial class Area
    {
        public Area()
        {
            // Colecciones
            paperList = new List<Paper>();
        }

        public Area(string name, User user, Magazine revista)
        {
            // No se le da valor a Id porque lo hará EF
            this.name = name;

            // Relaciones a 1
            this.user = user;
            this.revista = revista;

            // Colecciones
            this.paperList = new List<Paper>();
        }
    }
}
