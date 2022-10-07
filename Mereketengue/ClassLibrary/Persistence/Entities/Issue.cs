using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Persistence.Entities
{
    public partial class Issue
    {
        private int Id { get; set; } // Id

        private int Number { get; set; } // number

        private DateTime? PublicationDate { get; set; } // fecha de publicación

        private List<Paper> papers { get; set; } // lista con Paper de una Issue en concreto

        private Magazine magazine { get; set; } // Magazine a la que hace referencia el Issue

    }
}
