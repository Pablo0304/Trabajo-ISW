using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Entities
{
    public partial class Paper
    {
        private int id { get; set; } // Id

        private string title { get; set; } // título

        private DateTime uploadDate { get; set; } // fecha de subida

        private Area area { get; set; } // area a la que pertenece

        private User user { get; set; } // responsable

        private Person coAuthors { get; set; } // autores

        private Issue issue { get; set; } // Issue a la que pertenece

        private Evaluation evaluacion { get; set; } // evaluacion del Paper
    }
}
