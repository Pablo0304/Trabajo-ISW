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
        ICollection<Paper> selectedPapersAux = new List<Paper>();
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
            String var = listaPapers.GetItemText(listaPapers.SelectedItem);
            selectedPaper = service.gPaper(var, actualArea);
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
                foreach (Paper p in service.getPendingPublicationPapers(actualArea))
                {
                    listaPapers.Items.Add(p.Title);
                }
           
            //listaPapers.Items.Add(service.getPendingPublicationPapers(actualArea));
        }

        private void BuildIssue_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'magazineDBDataSet.Papers' Puede moverla o quitarla según sea necesario.

        }

        private void agregarPaperClick(object sender, EventArgs e)
        {
            selectedPapersAux.Add(selectedPaper);
            selectedPapers.Items.Add(selectedPaper);
        }

        private void publicateClick(object sender, EventArgs e) 
        {
            if (service.BuildIssue(dateTimePicker.Value, selectedPapersAux)) { 
                Menu_Principal ev1 = new Menu_Principal(service);
                this.Hide();
                ev1.ShowDialog();
                this.Close();
            }
        }

        private void backClick(object sender, EventArgs e)
        {
            Menu_Principal ev1 = new Menu_Principal(service);
            this.Hide();
            ev1.ShowDialog();
            this.Close();
        }
    }
}
