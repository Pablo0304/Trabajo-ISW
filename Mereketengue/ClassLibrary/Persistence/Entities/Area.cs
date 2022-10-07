using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Persistence.Entities
{
    internal class Area
    {
        private int id { get; set; } // Id

        private string name { get; set; } // name

        private User usuario { get; set; } // Usuario editor de esa Area

        private Magazine revista { get; set; } // Revista que contiene esta Area

        private List<Paper> paperList { get; set; } // Papers que pertenecen a esa Area
    }
}
