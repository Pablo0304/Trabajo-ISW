using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Persistence.Entities
{
    internal class Paper
    {
        private int id { get; set; } // Id

        private string Title { get; set; } // título

        private DateTime UploadDate { get; set; } // fecha de subida

        private Area area { get; set; } // area a la que pertenece

        private User user { get; set; } // responsable

        private Person CoAuthors { get; set; } // autores

        private Issue Issue { get; set; } // Issue a la que pertenece

        private Evaluation evaluacion { get; set; } // evaluacion del Paper
    }
}
