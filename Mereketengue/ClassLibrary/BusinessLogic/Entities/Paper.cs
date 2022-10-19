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
        public Paper(int id, String title, DateTime uploadDate, Area evaluationPendingArea, Area belongingArea,
            Area publicationPendingArea, User resposible, Person coAuthors, Issue issue, Evaluation evaluation) { 
            this.Id = id;
            this.Title = title;
            this.UploadDate = uploadDate;

            // Relaciones a 1
            EvaluationPendingArea = evaluationPendingArea;
            BelongingArea = belongingArea;
            PublicationPendingArea = publicationPendingArea;
            Resposible = resposible;
            CoAuthors = coAuthors;
            Issue = issue;
            Evaluation = evaluation;

        }
    
    }
}
