using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazine.Entities
{
    public partial class Issue
    {
        public Issue() {
            // Colecciones
            PublishedPapers = new List<Paper>();
        }

        public Issue(DateTime? publicationDate, Magazine magazine)
        {
            this.PublicationDate = publicationDate;
            // Relaciones a 1
            Magazine = magazine;

            // Colecciones
            PublishedPapers = new List<Paper>();
        }

    }

    // Se usa más adelante
    /// DateTime? EndDate = null;
    /// if (EndDate.HasValue)
    ///  Console.WriteLine(EndDate.Value);
    ///  else
    ///  Console.WriteLine("La data de cancel.lació no té valor.");
}
