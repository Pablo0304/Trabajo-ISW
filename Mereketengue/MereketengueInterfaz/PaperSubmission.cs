using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Magazine.Services;
using Magazine.Entities;
using Magazine.Persistence;
using System.Runtime.ConstrainedExecution;

namespace MereketengueInterfaz
{
    public partial class PaperSubmission : Form
    {
       
        public PaperSubmission(IMagazineISWService service)
        {
            InitializeComponent();
            
        }

    }
}
