using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Persistence.Entities
{
    public partial class Evaluation
    {
        private Boolean Accepted { get; set; } // estado

        private string coments { get; set; } // comentarios

        private DateTime date { get; set; } // fecha 

        private int Id { get; set; } // Id

        private Paper paper { get; set; } // Paper al que hacer referencia la Evaluation

    }
}
