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

namespace MereketengueInterfaz
{
    public partial class ListPapers : Form
    {
        private IMagazineISWService service;
        public ListPapers(IMagazineISWService service)
        {
            foreach (Area a in service.listAreas()) {
                foreach (Paper p in a.Papers) {
                    String autores = "";
                    foreach (Person per in p.CoAuthors) { 
                        autores += per.Name + " ";
                    }
                    String state = "";
                    if (p.EvaluationPendingArea != null) { state = "Pending evaluation"; }
                    else if (p.PublicationPendingArea != null) { state = "Pending publication"; }
                    else if (p.Issue != null) { state = "Published"; }
                    else { state = "Rejected"; }
                    listaPapers.Items.Add("Title: " + p.Title + " | Authors: " + autores + "| State: " + state);
                }
            }
            InitializeComponent();
        }

        private void ListPapers_Load(object sender, EventArgs e)
        {

        }

        private void buscadorClick(object sender, EventArgs e)
        {
            listaPapers.Items.Clear();
            foreach (Issue i in service.getAllIssues()) {
                if (i.Number.ToString() == buscadorBox.Text) {
                    foreach (Paper p in i.PublishedPapers)
                    {
                        String autores = "";
                        foreach (Person per in p.CoAuthors)
                        {
                            autores += per.Name + " ";
                        }
                        listaPapers.Items.Add("Title: " + p.Title + " | Authors: " + autores + "| State: Published");
                    }
                }
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Menu_Principal ev1 = new Menu_Principal(service);
            this.Hide();
            ev1.ShowDialog();
            this.Close();
        }
    }
}
