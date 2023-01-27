using Magazine.Entities;
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
        private User userControl;
        private Magazine.Entities.Magazine magazine;

        public Menu_Principal(IMagazineISWService service)
        {
            InitializeComponent();
            this.service = service;
            buttonBuilsIssue.Image = Resources.periodismo;
            ButtonPaperSubmission.Image = Resources.avion;
            buttonListPapers.Image = Resources.portapapeles;
            buttonEvPaper.Image = Resources.sello;
            BuyIssueButton.Image = Resources.dar_dinero__1_;
            userControl = service.getLoggedUser();
            
        }

        private void Menu_Principal_Load(object sender, EventArgs e)
        {
            userControl = service.getLoggedUser();
            magazine = service.getMagazine();
           
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

        private void animationEnterPaperSubmission(object sender, EventArgs e)
        {
            this.ButtonPaperSubmission.BackColor = System.Drawing.Color.SlateBlue;
            this.ButtonPaperSubmission.ForeColor = System.Drawing.Color.White;
            this.ButtonPaperSubmission.Image = Resources.avion_modified;
        }

        private void animationLeavePaperSubmission(object sender, EventArgs e)
        {
            this.ButtonPaperSubmission.BackColor = System.Drawing.Color.Lavender;
            this.ButtonPaperSubmission.ForeColor = System.Drawing.Color.Black;
            this.ButtonPaperSubmission.Image = Resources.avion;
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
            if (magazine.ChiefEditor != userControl)
            {

                DialogResult error = MessageBox.Show(this, // Owner
                "Only chiefEditor can BuildIssue", // Message
                "Unable to Build Issue!!", // Title
                MessageBoxButtons.OK, // Buttons included
                MessageBoxIcon.Exclamation); // Icon
            }
            else
            {
                BuildIssue ev2 = new BuildIssue(service);
                this.Hide();
                ev2.ShowDialog();
                this.Close();
            }
        }

        private void buttonListPapers_Click(object sender, EventArgs e)
        {
            if (magazine.ChiefEditor != userControl)
            {

                DialogResult error = MessageBox.Show(this, // Owner
                "Only chiefEditor can listPapers", // Message
                "Unable to Evaluate Paper!!", // Title
                MessageBoxButtons.OK, // Buttons included
                MessageBoxIcon.Exclamation); // Icon
            }
            else
            {
                ListPapers ev2 = new ListPapers(service);
                this.Hide();
                ev2.ShowDialog();
                this.Close();
            }
        }

        private void ButtonPaperSubmission_Click(object sender, EventArgs e)
        {
            PaperSubmission ventana = new PaperSubmission(service);
            this.Hide();
            ventana.ShowDialog();
            this.Close();
        }

        private void AnimacionEnterListPapers(object sender, EventArgs e)
        {
            this.buttonListPapers.BackColor = System.Drawing.Color.SlateBlue;
            this.buttonListPapers.ForeColor = System.Drawing.Color.White;
            this.buttonListPapers.Image = Resources.portapapeles_modified;
        }

        private void AnimacionLeaveListPapers(object sender, EventArgs e)
        {
            this.buttonListPapers.BackColor = System.Drawing.Color.Lavender;
            this.buttonListPapers.ForeColor = System.Drawing.Color.Black;
            this.buttonListPapers.Image = Resources.portapapeles;
        }

        private void AnimacionEnterBuildIssue(object sender, EventArgs e)
        {

            this.buttonBuilsIssue.BackColor = System.Drawing.Color.SlateBlue;
            this.buttonBuilsIssue.ForeColor = System.Drawing.Color.White;
            this.buttonBuilsIssue.Image = Resources.periodismo_modified;

        }

        private void AnimacionLeaveBuidIssue(object sender, EventArgs e)
        {
            this.buttonBuilsIssue.BackColor = System.Drawing.Color.Lavender;
            this.buttonBuilsIssue.ForeColor = System.Drawing.Color.Black;
            this.buttonBuilsIssue.Image = Resources.periodismo;

        }

        private void AnimacionEnterEvaluatePaper(object sender, EventArgs e)
        {

            this.buttonEvPaper.BackColor = System.Drawing.Color.SlateBlue;
            this.buttonEvPaper.ForeColor = System.Drawing.Color.White;
            this.buttonEvPaper.Image = Resources.sello_modified;
        }

        private void AnimacionLeaveEvaluatePaper(object sender, EventArgs e)
        {
            this.buttonEvPaper.BackColor = System.Drawing.Color.Lavender;
            this.buttonEvPaper.ForeColor = System.Drawing.Color.Black;
            this.buttonEvPaper.Image = Resources.sello;

        }

        private void Close(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void BuyIssue_Click(object sender, EventArgs e)
        {
            
            BuyIssue b = new BuyIssue(service);
            this.Hide();
            b.ShowDialog();
            this.Close();
        }

        private void animacionLeaveBuyIssue(object sender, EventArgs e)
        {
            this.BuyIssueButton.BackColor = System.Drawing.Color.Lavender;
            this.BuyIssueButton.ForeColor = System.Drawing.Color.Black;
            this.BuyIssueButton.Image = Resources.dar_dinero__1_;
        }

        private void animacionEnterBuyIssue(object sender, EventArgs e)
        {
            this.BuyIssueButton.BackColor = System.Drawing.Color.SlateBlue;
            this.BuyIssueButton.ForeColor = System.Drawing.Color.White;
            this.BuyIssueButton.Image = Resources.image;
        }
    }
}
