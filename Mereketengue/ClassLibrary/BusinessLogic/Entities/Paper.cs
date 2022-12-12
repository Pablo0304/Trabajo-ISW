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
        
        public void deleteCoauthor(Person person)
        {
            CoAuthors.Remove(person);
        }

        public void addCoauthor(Person person)
        {
            CoAuthors.Add(person);
        }

        public int gCoAuthorsCount() 
        { 
            return CoAuthors.Count; 
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
    }
}
