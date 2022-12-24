using Magazine.Services;
using MereketengueInterfaz.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MereketengueInterfaz
{
    public partial class Menu_Principal : Form
    {
        private IMagazineISWService service;

        public Menu_Principal(IMagazineISWService service)
        {
            InitializeComponent();
            this.service = service;
        }

        private void Menu_Principal_Load(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
             
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void animationEnterPaperSubmission(object sender, EventArgs e)
        {
            this.ButtonPaperSubmission.BackColor = System.Drawing.Color.SlateBlue;
            this.ButtonPaperSubmission.ForeColor = System.Drawing.Color.White;
        }

        private void animationLeavePaperSubmission(object sender, EventArgs e)
        {
            this.ButtonPaperSubmission.BackColor = System.Drawing.Color.Lavender;
            this.ButtonPaperSubmission.ForeColor = System.Drawing.Color.Black;
        }

        private void buttonEvPaper_Click(object sender, EventArgs e)
        {
            EvaluatePaper ev1 = new EvaluatePaper(service);
            this.Hide();
            ev1.ShowDialog();
            this.Close();
        }

        private void buttonBuilsIssue_Click(object sender, EventArgs e)
        {
            BuildIssue ev2 = new BuildIssue(service);
            this.Hide();
            ev2.ShowDialog();
            this.Close();
        }

        private void buttonListPapers_Click(object sender, EventArgs e)
        {
            ListPapers ev2 = new ListPapers(service);
            this.Hide();
            ev2.ShowDialog();
            this.Close();
        }

        private void ButtonPaperSubmission_Click(object sender, EventArgs e)
        {
            PaperSubmission ventana = new PaperSubmission(service);
            this.Hide();
            ventana.ShowDialog();
            this.Close();
        }
    }
}
