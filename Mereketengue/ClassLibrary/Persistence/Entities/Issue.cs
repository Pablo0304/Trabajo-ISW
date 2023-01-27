using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazine.Entities
{
    public partial class Issue
    {
        public int Id { get; set; } // Id

        public int Number { get; set; } // number

        public float Price { get; set; }

        public float Discount { get; set; }

        public DateTime? PublicationDate { get; set; } // fecha de publicación

        public virtual ICollection<Paper> PublishedPapers { get; set; } // lista con Paper de una Issue en concreto

        [Required]
        public virtual Magazine Magazine { get; set; } // Magazine a la que hace referencia el Issue

    }
}
