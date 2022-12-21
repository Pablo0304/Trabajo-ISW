using Magazine.Entities;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MereketengueInterfaz
{
    public partial class EvaluatePaper : Form
    {
        private IMagazineISWService service;
        Area actualArea;
        Paper selectedPaper;
        Boolean d = false;
        public EvaluatePaper(IMagazineISWService service)
        {
            InitializeComponent();
            this.service = service;
            foreach (Area a in service.listAreas())
            {
                comboAreas.Items.Add(a.Name);
            }
            decision.Items.Add("Accept");
            decision.Items.Add("Denied");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SelectEv1(object sender, EventArgs e)
        {
            if (comboAreas.Text == "") {
                DialogResult answer = MessageBox.Show(this, // Owner
                "Area is not selected!!", // Message
                "ERROR!!", // Title
                MessageBoxButtons.OK, // Buttons included
                MessageBoxIcon.Exclamation); // Icon
            }
            if (listaPapers.Text == "")
            {
                DialogResult answer = MessageBox.Show(this, // Owner
                "Paper is not selected!!", // Message
                "ERROR!!", // Title
                MessageBoxButtons.OK, // Buttons included
                MessageBoxIcon.Exclamation); // Icon
            }
            if (textBox1.Text == "")
            {
                DialogResult answer = MessageBox.Show(this, // Owner
                "Missing Commentary...", // Message
                "ERROR!!", // Title
                MessageBoxButtons.OK, // Buttons included
                MessageBoxIcon.Exclamation); // Icon
            }
            if (decision.Text == "")
            {
                DialogResult answer = MessageBox.Show(this, // Owner
                "Missing Decision...", // Message
                "ERROR!!", // Title
                MessageBoxButtons.OK, // Buttons included
                MessageBoxIcon.Exclamation); // Icon
            }
            
            //if (decision.Text.Equals("true")) { d=true}
            service.EvaluatePaper(actualArea, selectedPaper, d, textBox1.Text);

            Menu_Principal mp = new Menu_Principal(service);
            this.Hide();
            mp.ShowDialog();
            this.Close();
        }

        private void GoBackEv1(object sender, EventArgs e)
        {
            Menu_Principal mp = new Menu_Principal(service);
            this.Hide();
            mp.ShowDialog();
            this.Close();
        }

        private void ComboBoxAreas(object sender, EventArgs e)
        {
            foreach (Area a in service.listAreas())
            {
                if (comboAreas.SelectedItem.Equals(a.Name)) { actualArea = a; }
            }
            listaPapers.Items.Clear();
            foreach (Paper p in service.getPendingEvaluationPapers(actualArea))
            {
                listaPapers.Items.Add(p.Title);
            }
        }

        private void seleccionarPaper(object sender, EventArgs e)
        {
            foreach (Paper p in service.getPendingEvaluationPapers(actualArea)) {
                if (listaPapers.SelectedItem.Equals(p.Title)) { selectedPaper = p;  }
            }
        }

        private void decision_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (decision.SelectedItem.Equals("Accept"))
            {
                d = true;
            }
            else {
                d = false;
            }
        }
    }
}
