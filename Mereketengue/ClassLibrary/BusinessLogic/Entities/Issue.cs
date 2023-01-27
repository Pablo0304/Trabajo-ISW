using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Magazine.Entities
{
    public partial class Issue
    {
        public Issue() {
            // Colecciones
            PublishedPapers = new List<Paper>();
        }

        public Issue(int Number, Magazine magazine, float discount, float price) : this() // espera el parametro number (int)
        {
            this.Number = Number;
            this.Discount = discount;
            this.Price = price;

            //this.PublicationDate = fecha;
            
            // Relaciones a 1
            Magazine = magazine;

        }

        public bool IssuePendientePub(DateTime datetime)
        {
           int aux = DateTime.Compare(datetime, DateTime.Now);
            return aux < 0;
        }

        public void addToPublishedPapers(Paper paper)
        {
            this.PublishedPapers.Add(paper);
        }

        public void deleteFromPublishedPapers(Paper paper)
        {
            this.PublishedPapers.Remove(paper); 
        }

        public void clearPublishedpapers()
        {
            this.PublishedPapers.Clear();
        }

        public bool comprobarNumberIssue(int number)
        {
            return this.Number.Equals(number);
        }

    }

    // Se usa más adelante
    /// DateTime? EndDate = null;
    /// if (EndDate.HasValue)
    ///  Console.WriteLine(EndDate.Value);
    ///  else
    ///  Console.WriteLine("La data de cancel.lació no té valor.");
}
