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
            CoAuthors.Add(responsible); // 3

        }

        public bool comprobarTitle(String Title)
        {
            if (this.Title.Equals(Title)) { return true; }
            return false;
        }
        
        public void deleteCoauthor(Person person)
        {
            this.CoAuthors.Remove(person);
        }

        public void addCoauthor(Person person)
        {
            this.CoAuthors.Add(person);
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
