using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazine.Entities
{
    public partial class Magazine
    {
        public int Id { get; set; } // Id

        public String Name { get; set; } // name

        public virtual ICollection<Issue> Issues { get; set; } // lista de Issues de esa revista

        public virtual ICollection<Area> Areas { get; set; } // lista de areas de esa revista

        [Required]
        public virtual User ChiefEditor { get; set; } // Usuario editor adignado a esa revista
    }
}
