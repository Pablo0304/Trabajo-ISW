using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazine.Entities
{
    public partial class Paper
    {
        private int Id { get; set; } // Id

        private string Title { get; set; } // título

        private DateTime UploadDate { get; set; } // fecha de subida

        private Area EvaluationPendingArea { get; set; } 

        private Area BelongingArea { get; set; } 

        private Area PublicationPendingArea { get; set; } 

        private User Resposible { get; set; } // responsable

        private Person CoAuthors { get; set; } // autores

        private Issue Issue { get; set; } // Issue a la que pertenece

        private Evaluation Evaluation { get; set; } // evaluacion del Paper
    }
}
