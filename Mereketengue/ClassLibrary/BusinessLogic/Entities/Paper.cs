using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Entities
{
    public partial class Paper
    {
        public Paper() { 
        }
        public Paper(String title, DateTime uploadDate, Area area, User user, Person coAuthors, Issue issue, Evaluation evaluacion) { 
            this.title = title;

            // Relaciones a 1
            user = usuario;
            uploadDate = uploadDate;
            area = area;
            coAuthors = coAuthors;
            issue = issue;
            evaluacion = evaluacion;

        }
    
    }
}
