using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Entities
{
    public partial class Magazine
    {
        private int id { get; set; } // Id

        private string name { get; set; } // name

        private List<Issue> issues { get; set; } // lista de Issues de esa revista

        private List<Area> areas { get; set; } // lista de areas de esa revista

        private User user { get; set; } // Usuario editor adignado a esa revista
    }
}
