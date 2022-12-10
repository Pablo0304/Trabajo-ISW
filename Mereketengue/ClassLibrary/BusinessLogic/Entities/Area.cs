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

            foreach (Paper p in Papers)
            {
                if (!p.hasEvaluation())
                {
                    EvaluationPending.Add(p);
                }
            }
            return EvaluationPending;
        }

        public void AddToPublicationPendingPapers(Paper paper) 
        {
            PublicationPending.Add(paper);
        }

        public void DeleteFromEvaluatePendingPaper(Paper paper) 
        {
            EvaluationPending.Remove(paper);
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
