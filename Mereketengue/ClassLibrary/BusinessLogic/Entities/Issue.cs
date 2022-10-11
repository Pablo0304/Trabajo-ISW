using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Entities
{
    public partial class Issue
    {
        public Issue() { 
            // Colecciones
            paperList = new List<Paper>();
        }

        public Issue(DateTime? publicationDate, Magazine magazine)
        {
            this.publicationDate = publicationDate;

            // Relaciones a 1
            this.magazine = magazine;

            // Colecciones
            this.paperList = new List<Paper>();
        }

    }

    // Se usa más adelante
    /// DateTime? EndDate = null;
    /// if (EndDate.HasValue)
    ///  Console.WriteLine(EndDate.Value);
    ///  else
    ///  Console.WriteLine("La data de cancel.lació no té valor.");
}
