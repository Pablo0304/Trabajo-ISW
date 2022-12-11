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

        public Issue(int Number, Magazine magazine) : this() // espera el parametro number (int)
        {
            this.Number = Number;
            //this.PublicationDate = fecha;
            
            // Relaciones a 1
            Magazine = magazine;

        }

        public bool IssuePendientePub(DateTime datetime)
        {
           int aux = DateTime.Compare(datetime, DateTime.Now);
            return aux < 0;
        }
    }

    // Se usa más adelante
    /// DateTime? EndDate = null;
    /// if (EndDate.HasValue)
    ///  Console.WriteLine(EndDate.Value);
    ///  else
    ///  Console.WriteLine("La data de cancel.lació no té valor.");
}
