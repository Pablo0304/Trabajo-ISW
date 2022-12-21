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
            selectorArea.Items.Add(service.listAreas());
            
        }

        private void seleccionarPaper(object sender, EventArgs e)
        {
            selectedPaper = (Paper)listaPapers.SelectedItem;
        }

        private void seleccionarArea(object sender, EventArgs e)
        {
            actualArea = (Area)selectorArea.SelectedItem;
        }

        private void buscarClick(object sender, EventArgs e)
        {
            listaPapers.Items.Clear();
            listaPapers.Items.Add(service.getPendingPublicationPapers(actualArea));
        }

        private void BuildIssue_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'magazineDBDataSet.Papers' Puede moverla o quitarla según sea necesario.
            this.papersTableAdapter.Fill(this.magazineDBDataSet.Papers);

        }

        private void agregarPaperClick(object sender, EventArgs e)
        {
            service.AddPublishedPapers(selectedPaper);
            selectedPapers.Items.Add(selectedPaper);
        }

        private void publicateClick(object sender, EventArgs e)
        {

        }
    }
}
