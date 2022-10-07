using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Entities
{
    public partial class Area
    {
        public Area()
        {
            // Colecciones
            PaperList = new List<Paper>();
        }

        public Area(string name, User usuario, Magazine revista)
        {
            // No se le da valor a Id porque lo hará EF
            this.Name = name;

            // Relaciones a 1
            User = usuario;
            Revista = revista;

            // Colecciones
            this.PaperList = new List<Paper>();
        }
    }
}
