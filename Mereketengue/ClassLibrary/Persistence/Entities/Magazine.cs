using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazine.Entities
{
    public partial class Magazine
    {
        private int Id { get; set; } // Id

        private String Name { get; set; } // name

        private ICollection<Issue> Issues { get; set; } // lista de Issues de esa revista

        private ICollection<Area> Areas { get; set; } // lista de areas de esa revista

        private User ChiefEditor { get; set; } // Usuario editor adignado a esa revista
    }
}
