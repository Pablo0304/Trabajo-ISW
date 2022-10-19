using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Entities
{
    public partial class Evaluation
    {
        private Boolean Accepted { get; set; } // estado

        private String Comments { get; set; } // comentarios

        private DateTime Date { get; set; } // fecha 

        private int Id { get; set; } // Id

        private Paper Paper { get; set; } // Paper al que hacer referencia la Evaluation

    }
}
