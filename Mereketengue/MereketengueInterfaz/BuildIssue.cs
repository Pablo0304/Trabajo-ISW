using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Magazine.Entities;
using Magazine.Persistence;
using Magazine.Services;

namespace MereketengueInterfaz
{
    public partial class BuildIssue : Form
    {
        private IMagazineISWService service;

        Area actualArea = null;
        Paper selectedPaper = null;
        public BuildIssue(IMagazineISWService service)
        {
            InitializeComponent();
            this.service = service;
            foreach (Area a in service.listAreas()) {
                selectorArea.Items.Add(a.Name);
            }
            Issue lastIssue = service.getLastIssue();
            if (service.pendingPublication(lastIssue))
            {
                numberLabel.Text = lastIssue.Number.ToString() + " (editar):";
                dateTimePicker.Text = lastIssue.PublicationDate.ToString();
                foreach (Paper p in lastIssue.PublishedPapers)
                {
                    selectedPapers.Items.Add(p.Title);
                }
            }
            else {
                numberLabel.Text = lastIssue.Number+1.ToString() + " (editar):";
            }
            //selectorArea.Items.Add(service.listAreas());
            
        }

        private void seleccionarPaper(object sender, EventArgs e)
        {
            selectedPaper = (Paper)listaPapers.SelectedItem;
        }

        private void seleccionarArea(object sender, EventArgs e)
        {
            foreach (Area a in service.listAreas()) {
                if ((String)selectorArea.SelectedItem == a.Name) { actualArea = a;  }
            }
        }

        private void buscarClick(object sender, EventArgs e)
        {
            
                listaPapers.Items.Clear();
                try
            {
                foreach (Paper p in service.getPendingPublicationPapers(actualArea))
                {
                    listaPapers.Items.Add(p.Title);
                }
            }
            catch (Exception ex) {
                DialogResult answer = MessageBox.Show(this, // Owner
                "Unable to create DB", // Message
                "Error", // Title
                MessageBoxButtons.OK, // Buttons included
                MessageBoxIcon.Exclamation); // Icon
            }
            //listaPapers.Items.Add(service.getPendingPublicationPapers(actualArea));
        }

        private void BuildIssue_Load(object sender, EventArgs e)
        {

        }

        private void agregarPaperClick(object sender, EventArgs e)
        {
            service.AddPublishedPapers(selectedPaper);
            selectedPapers.Items.Add(selectedPaper);
        }

        private void publicateClick(object sender, EventArgs e)
        {
            service.BuildIssue(dateTimePicker.Value);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Menu_Principal mp = new Menu_Principal(service);
            this.Hide();
            mp.ShowDialog();
            this.Close();
        }
    }
}
