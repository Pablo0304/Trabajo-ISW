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
            Issues = new List<Issue>();
            Areas = new List<Area>();
        }
        public Magazine(String name, User chiefEditor) {

            this.Name = name;

            // Relaciones a 1
            ChiefEditor = chiefEditor;

            // Colecciones
            Issues = new List<Issue>();
            Areas = new List<Area>();
        }
    }
}
