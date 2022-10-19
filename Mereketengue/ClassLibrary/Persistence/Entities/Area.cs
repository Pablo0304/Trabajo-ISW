    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Entities
{
    public partial class Area
    {
        private int Id { get; set; } // Id

        private String Name { get; set; } // name

        private User Editor { get; set; } // Usuario editor de esa Area

        private Magazine Magazine { get; set; } // Revista que contiene esta Area

        private List<Paper> Papers { get; set; } 

        private List<Paper> EvaluationPending { get; set; }

        private List<Paper> PublicationPending { get; set; }

    }
}
