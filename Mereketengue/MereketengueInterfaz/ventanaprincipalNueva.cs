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
            buttonLogin.Image = Resources.usuario1;
            buttonSingUp.Image = Resources.usuariosingup;
            buttonSeeIssues.Image = Resources.lista__1_;
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

        private void enterLogin(object sender, EventArgs e)
        {
            this.buttonLogin.BackColor = System.Drawing.Color.SlateBlue;
            this.buttonLogin.ForeColor = System.Drawing.Color.White;
            this.buttonLogin.Image = Resources.logincolor;
        }

        private void leaveLogin(object sender, EventArgs e)
        {
            this.buttonLogin.BackColor = System.Drawing.Color.Lavender;
            this.buttonLogin.ForeColor = System.Drawing.Color.Black;
            this.buttonLogin.Image = Resources.usuario1;
        }

        private void enterSingUp(object sender, EventArgs e)
        {
            this.buttonSingUp.BackColor = System.Drawing.Color.SlateBlue;
            this.buttonSingUp.ForeColor = System.Drawing.Color.White;
            this.buttonSingUp.Image = Resources.sinfupcolor;
        }

        private void leaveSingUp(object sender, EventArgs e)
        {
            this.buttonSingUp.BackColor = System.Drawing.Color.Lavender;
            this.buttonSingUp.ForeColor = System.Drawing.Color.Black;
            this.buttonSingUp.Image = Resources.usuariosingup;
        }

        private void Enterissues(object sender, EventArgs e)
        {
            this.buttonSeeIssues.BackColor = System.Drawing.Color.SlateBlue;
            this.buttonSeeIssues.ForeColor = System.Drawing.Color.White;
            this.buttonSeeIssues.Image = Resources.listacolor;
        }

        private void leaveIssues(object sender, EventArgs e)
        {
            this.buttonSeeIssues.BackColor = System.Drawing.Color.Lavender;
            this.buttonSeeIssues.ForeColor = System.Drawing.Color.Black;
            this.buttonSeeIssues.Image = Resources.lista__1_;
        }
    }
}
