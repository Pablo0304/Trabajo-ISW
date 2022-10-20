using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Magazine.Entities
{
    public partial class Area
    {
        public Area()
        {
            // Colecciones
            Papers = new List<Paper>();
            EvaluationPending = new List<Paper>();
            PublicationPending = new List<Paper>();
        }

        public Area(String name, User editor, Magazine magazine)
        {
            // No se le da valor a Id porque lo hará EF
            this.Name = name;
            this.Editor = editor;

            // Relaciones a 1
            Magazine = magazine;

            // Colecciones
            Papers = new List<Paper>();
            EvaluationPending = new List<Paper>();
            PublicationPending = new List<Paper>();
        }
    }
}
