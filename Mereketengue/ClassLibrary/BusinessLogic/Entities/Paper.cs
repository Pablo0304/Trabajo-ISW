using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazine.Entities
{
    public partial class Paper
    {
        public Paper() { 
        }
        public Paper(String title, DateTime uploadDate, Area area, User user, Person coAuthors, Issue issue, Evaluation evaluacion) { 
            this.title = title;

            // Relaciones a 1
            this.user = user;
            this.uploadDate = uploadDate;
            this.area = area;
            this.coAuthors = coAuthors;
            this.issue = issue;
            this.evaluacion = evaluacion;

        }
    
    }
}
