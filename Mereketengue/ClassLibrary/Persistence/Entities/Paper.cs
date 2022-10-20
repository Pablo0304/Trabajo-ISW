﻿using System;
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

        public virtual Area EvaluationPendingArea { get; set; }

        public virtual Area BelongingArea { get; set; }

        public virtual Area PublicationPendingArea { get; set; }

        public virtual User Resposible { get; set; } // responsable

        public virtual Person CoAuthors { get; set; } // autores

        public virtual Issue Issue { get; set; } // Issue a la que pertenece

        public virtual Evaluation Evaluation { get; set; } // evaluacion del Paper
    }
}
