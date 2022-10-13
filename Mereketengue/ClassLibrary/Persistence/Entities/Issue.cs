using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Entities
{
    public partial class Issue
    {
        private int id { get; set; } // Id

        private int number { get; set; } // number

        private DateTime? publicationDate { get; set; } // fecha de publicación

        private List<Paper> paperList { get; set; } // lista con Paper de una Issue en concreto

        private Magazine magazine { get; set; } // Magazine a la que hace referencia el Issue

    }
}
