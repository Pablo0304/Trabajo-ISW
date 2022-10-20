using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazine.Entities
{
    public partial class Paper
    {
        public int Id { get; set; } // Id

        public String Title { get; set; } // título

        public DateTime UploadDate { get; set; } // fecha de subida

        public Area EvaluationPendingArea { get; set; }

        public Area BelongingArea { get; set; }

        public Area PublicationPendingArea { get; set; }

        public User Resposible { get; set; } // responsable

        public Person CoAuthors { get; set; } // autores

        public Issue Issue { get; set; } // Issue a la que pertenece

        public Evaluation Evaluation { get; set; } // evaluacion del Paper
    }
}
