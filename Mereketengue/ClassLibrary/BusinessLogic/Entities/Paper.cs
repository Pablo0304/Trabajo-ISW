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
            //Coleccions
            CoAuthors = new List<Person>();
        }
        public Paper(String title, DateTime uploadDate, Area belongingArea, User responsible) : this() { 

            Title = title;
            this.UploadDate = uploadDate;

            // Relaciones a 1
            BelongingArea = belongingArea;
            Responsible = responsible;

            //Coleccions
            CoAuthors.Add(responsible); //? preguntar

        }

        public ICollection<Person> gCoAuthors() 
        {
            return this.CoAuthors;
        }

        public bool hasEvaluation() 
        {
            if (this.Evaluation.Equals(null)) 
            { 
                return false; 
            }
            else 
            { 
                return true; 
            }
        }

        public bool gEvaluationDecision() 
        {
            return this.Evaluation.Accepted;    
        }

        public void setEvaluation(Evaluation evaluation) 
        {
            this.Evaluation = evaluation;      
        }
        public void removeEvaluation()
        {
            this.Evaluation = null;
        }

        public Area getPaperArea() 
        {
            return this.BelongingArea;
        }
        
        public User gResponsible()
        {
            return this.Responsible;
        }

        public void setEvaluationPendingArea(Area area) 
        {
            this.EvaluationPendingArea = area;
        }
        
        public void removeEvaluationPendingArea()
        {
            this.EvaluationPendingArea = null;
        }

        public void setPublicationPendingArea(Area area) 
        {
            this.PublicationPendingArea = area;
        }

        public void removePublicationnPendingArea()
        {
            this.PublicationPendingArea = null;
        }

    }
}
