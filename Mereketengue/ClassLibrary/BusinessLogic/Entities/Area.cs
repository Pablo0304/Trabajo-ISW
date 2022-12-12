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

        public void AddToPublPendPapers(Paper paper) 
        {
            PublicationPending.Add(paper);
        }

        public void DeleteFromPublPendPapers(Paper paper)
        {
            PublicationPending.Remove(paper);
        }

        public void AddToEvalPendPapers(Paper paper)
        {
            EvaluationPending.Add(paper);
        }

        public void DeleteFromEvalPendPapers(Paper paper) 
        {
            EvaluationPending.Remove(paper);
        }
        
        public void addToPapers(Paper paper)
        {
            this.Papers.Add(paper);
        }
    }
}
