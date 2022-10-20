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

        public Evaluation(Boolean accepted, String comments, DateTime date, Paper paper)
        {
            this.Accepted = accepted;
            this.Comments = comments;
            this.Date = date;

            // Relaciones a 1
            Paper = paper;
        }
    }
}
