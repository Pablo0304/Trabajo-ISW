using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazine.Entities
{
    public partial class Evaluation
    {
        public Boolean Accepted { get; set; } // estado

        public String Comments { get; set; } // comentarios

        public DateTime Date { get; set; } // fecha 

        public int Id { get; set; } // Id

        public virtual Paper Paper { get; set; } // Paper al que hacer referencia la Evaluation

    }
}
