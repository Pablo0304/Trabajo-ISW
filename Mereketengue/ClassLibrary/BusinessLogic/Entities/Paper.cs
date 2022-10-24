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
        public Paper(String title, DateTime uploadDate, Area belongingArea, User resposible) { 

            Title = title;
            this.UploadDate = uploadDate;

            // Relaciones a 1
            BelongingArea = belongingArea;
            Resposible = resposible;

            //Coleccions
            CoAuthors = new List<Person>();
            CoAuthors.Add(resposible);

        }
    
    }
}
