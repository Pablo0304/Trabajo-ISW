using Magazine.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MereketengueInterfaz
{
    public partial class Mereketengue : Form
    {
        private IMagazineISWService service;
        public Mereketengue(IMagazineISWService service)
        {
            InitializeComponent();
            this.service = service;
        }
    }
}
