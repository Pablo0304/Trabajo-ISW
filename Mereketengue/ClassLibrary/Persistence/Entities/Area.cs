    using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazine.Entities
{
    public partial class Area
    {
        [Key]
        public int Id { get; set; } // Id

        public String Name { get; set; } // name

        [Required]
        public virtual User Editor { get; set; } // Usuario editor de esa Area

        [Required]
        [InverseProperty("Areas")]
        public virtual Magazine Magazine { get; set; } // Revista que contiene esta Area

        public virtual ICollection<Paper> Papers { get; set; }

        public virtual ICollection<Paper> EvaluationPending { get; set; }

        public virtual ICollection<Paper> PublicationPending { get; set; }

    }
}
