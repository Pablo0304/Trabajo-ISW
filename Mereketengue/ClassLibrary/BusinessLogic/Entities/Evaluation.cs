using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazine.Entities
{
    public partial class Evaluation
    {
        public Evaluation()
        {
        }

        public Evaluation(Boolean accepted, String coments, DateTime date, Paper paper)
        {
            this.accepted = accepted;
            this.coments = coments;
            this.date = date;

            // Relaciones a 1
            this.paper = paper;
        }
    }
}
