using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Entities
{
    public partial class Evaluation
    {
        private Boolean accepted { get; set; } // estado

        private String coments { get; set; } // comentarios

        private DateTime date { get; set; } // fecha 

        private int id { get; set; } // Id

        private Paper paper { get; set; } // Paper al que hacer referencia la Evaluation

    }
}
