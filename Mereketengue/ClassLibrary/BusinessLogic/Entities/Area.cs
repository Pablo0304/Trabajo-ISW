using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Magazine.Entities
{
    public partial class Area
    {
        public Area()
        {
            // Colecciones
            Papers = new List<Paper>();
            EvaluationPending = new List<Paper> ();
            PublicationPending = new List<Paper> ();
        }

        public Area(String name, User editor, Magazine magazine) : this()
        {
            // No se le da valor  Id porque lo hará EF
            this.Name = name;
            this.Editor = editor;

            // Relaciones a 1
            Magazine = magazine;

        }

        public ICollection<Paper> EvaluationPendingPapers() //para que sirve EvaluationPending, no hace falta ? pregunta
        {
            return EvaluationPending;
        }

        public void AddToPublicationPendingPapers(Paper paper) 
        {
            PublicationPending.Add(paper);
        }

        public void DeleteFromPublicationPendingPapers(Paper paper)
        {
            PublicationPending.Remove(paper);
        }

        public void AddToEvaluationPendingPapers(Paper paper)
        {
            EvaluationPending.Add(paper);
        }

        public void DeleteFromEvaluatePendingPaper(Paper paper) 
        {
            EvaluationPending.Remove(paper);
        }
        
        public void addToPapers(Paper paper)
        {
            this.Papers.Add(paper);
        }

        public ICollection<Paper> gPapers() 
        {
            return this.Papers;
        }
        public User gEditor() 
        { 
            return (User)this.Editor;
        }
    }
}
