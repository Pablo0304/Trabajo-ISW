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

        public ICollection<Area> gAreas()
        {
            return this.Areas;
        }

        public ICollection<Issue> gIssues()
        {
            return this.Issues;
        }

        public User gChiefEditor()
        {
            return this.ChiefEditor;
        }

        public int gMaxNumber(ICollection<Issue> lista)
        {
            int max = 0;
            foreach (Issue issue in lista)
            {
                if (issue.gNumber() > max) { max = issue.gNumber(); }

            }
            return max;
        }
    }
}