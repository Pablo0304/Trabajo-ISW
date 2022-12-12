using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazine.Entities
{
    public partial class Magazine
    {
        public Magazine()
        {
            Issues = new List<Issue>();
            Areas = new List<Area>();
        }

        public Magazine(String name, User chiefEditor) : this()
        {

            this.Name = name;

            // Relaciones a 1
            ChiefEditor = chiefEditor;
        }

        public Issue gMaxNumberIssue()
        {
            return this.Issues.Last();  //como de bien etá esto mucho . ? preguntas
        }

        public void addToIssues(Issue issue) 
        {
            this.Issues.Add(issue);
        }

        public void removeFromIssues(Issue issue)
        {
            this.Issues.Remove(issue);
        }


    }
}