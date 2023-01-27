using Magazine.Entities;
using Magazine.Services;
using MereketengueInterfaz.Properties;
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
    public partial class ventanaprincipalNueva : Form
    {
        private IMagazineISWService service;
        private User userControl;
        private Magazine.Entities.Magazine magazine;

        public ventanaprincipalNueva(IMagazineISWService service)
        {
            InitializeComponent();
            this.service = service;
            userControl = service.getLoggedUser();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login ventana = new Login(service);
            this.Hide();
            ventana.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SignUp ventana = new SignUp(service);
            this.Hide();
            ventana.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ConsultarIssueNOReg ventana = new ConsultarIssueNOReg(service);
            this.Hide();
            ventana.ShowDialog();
            this.Close();
        }
    }
}
