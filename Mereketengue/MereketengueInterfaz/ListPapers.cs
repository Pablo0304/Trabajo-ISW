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
    public partial class ListPapers : Form
    {
        private IMagazineISWService service;
        private Magazine.Entities.Magazine magazine;
        private Area area;
        private int valor;
        private User usercontrol;
        public ListPapers(IMagazineISWService service)
        {
            InitializeComponent();
            this.buscador.Image = Resources.lupa;
            this.service = service;
            this.ErrorArea.Text = "";
            this.IssueNumberError.Text = "";
        }

        private void ListPapers_Load(object sender, EventArgs e)
        {

        }

        private void buscadorClick(object sender, EventArgs e)
        {
            try
            {
                IssueNumberError.Text = "";
                valor = int.Parse(buscadorBox.Text);
            }
            catch (FormatException)
            {
                IssueNumberError.Text = "Thats not a valid number.";
                buscador.Text = "";
            }
            catch (OverflowException)
            {
                IssueNumberError.Text = "That number is too big or too small, idk.";
                buscador.Text = "";
            }
            comboBox1.Enabled = true;
            ListaPapers.Items.Clear();
            ErrorArea.Text = "";
            IssueNumberError.Text = "";
            if (buscadorBox.Text.Length == 0)
            {
                if (area == null) { ErrorArea.Text = "Select an area"; }
                else
                {
                    foreach (Paper p in area.Papers)
                    {
                        String autores = "";
                        foreach (Person per in p.CoAuthors)
                        {
                            autores += per.Name + " ";
                        }
                        String state = "";
                        if (p.EvaluationPendingArea != null) { state = "Pending evaluation"; }
                        else if (p.PublicationPendingArea != null) { state = "Pending publication"; }
                        else if (p.Issue != null) { state = "Published"; }
                        else { state = "Rejected"; }
                        String aux;
                        if (p.Issue != null)
                        {
                            aux = "Title: " + p.Title.ToString() + " | Authors: " + autores.ToString()
                            + "| State: " + state + " | Issue: " + p.Issue.Number.ToString();
                        }
                        else
                        {
                            aux = "Title: " + p.Title.ToString() + " | Authors: " + autores.ToString()
                            + "| State: " + state;
                        }
                        ListaPapers.Items.Add(aux.ToString());

                    }
                }
            }
            else
            {
                foreach (Issue i in service.getAllIssues())
                {
                    if (i.Number == valor)
                    {
                        if (i.Number >= 0)
                        {
                            foreach (Paper p in i.PublishedPapers)
                            {
                                String autores = "";
                                foreach (Person per in p.CoAuthors)
                                {
                                    autores += per.Name.ToString();
                                }
                                ListaPapers.Items.Add("Area: " + p.BelongingArea.Name.ToString() + " | Title: " + p.Title + " | Authors: " + autores + "| State: Published");
                            }
                        }
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

        private void LlenarAreas(object sender, EventArgs e)
        {
            ListaPapers.Items.Clear();
            //ErrorArea.Text = "";
            // ErrorSend.Text = "";
            comboBox1.Items.Clear();
            List<Area> lista = (List<Area>)service.listAreas();
            foreach (Area a in lista)
            {
                comboBox1.Items.Add(a.Name.ToString());
            }
            
        }

        private void cambiarArea(object sender, EventArgs e)
        {
            ErrorArea.Text = "";
            buscadorBox.Text = "";
            String nombre = comboBox1.GetItemText(comboBox1.SelectedItem);
            area = service.SearchArea(nombre);
        }

        private void cambiaNumberIssue(object sender, EventArgs e)
        {
            ListaPapers.Items.Clear();
        }
        protected override void OnClosed(EventArgs e)
        {
            Menu_Principal mp4 = new Menu_Principal(service);
            this.Hide();
            mp4.ShowDialog();
            this.Close();
        }

    }
}
