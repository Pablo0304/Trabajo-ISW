using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Entities
{
    public partial class Area
    {
        private int Id { get; set; } // Id

        private string Name { get; set; } // name

        private User User { get; set; } // Usuario editor de esa Area

        private Magazine Revista { get; set; } // Revista que contiene esta Area

        private List<Paper> PaperList { get; set; } // Papers que pertenecen a esa Area
    }
}
