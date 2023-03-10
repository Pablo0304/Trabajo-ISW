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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MereketengueInterfaz
{
    public partial class ConsultarIssueNOReg : Form
    {
        private IMagazineISWService service;
        private Magazine.Entities.Magazine magazine;
        private Area area;
        private int valor;
        private User usercontrol;
        public ConsultarIssueNOReg(IMagazineISWService service)
        {
            InitializeComponent();
            this.buscador.Image = Resources.lupa;
            this.service = service;
            this.IssueNumberError.Text = "";
            this.meterPrice.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void IssueNumberError_Click(object sender, EventArgs e)
        {

        }

        private void cluckBuscador(object sender, EventArgs e)
        {
            meterPrice.Text = "";
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
            ListaPapers.Items.Clear();
            IssueNumberError.Text = "";
            foreach (Issue i in service.getAllIssues())
            {
                if (i.Number == valor)
                {
                    if (i.Number >= 0)
                    {
                        if (i.PublicationDate < DateTime.Now)
                        {
                            meterPrice.Text = i.Price + "€";
                            foreach (Paper p in i.PublishedPapers)
                            {
                                String autores = "";
                                foreach (Person per in p.CoAuthors)
                                {
                                    autores += per.Name.ToString() + ", ";
                                }
                                ListaPapers.Items.Add("Title: " + p.Title + " | Authors: " + autores);
                            }
                        }
                        else { ListaPapers.Items.Add("This issue is not published yet"); }
                    }
                }
            }
            
        }

        private void backClick(object sender, EventArgs e)
        {
            ventanaprincipalNueva ev1 = new ventanaprincipalNueva(service);
            this.Hide();
            ev1.ShowDialog();
            this.Close();
        }

        private void tocarTexto(object sender, EventArgs e)
        {
            meterPrice.Text = "";
            ListaPapers.Items.Clear();
        }
        protected override void OnClosed(EventArgs e)
        {
            ventanaprincipalNueva ev1 = new ventanaprincipalNueva(service);
            this.Hide();
            ev1.ShowDialog();
            this.Close();
        }
    }
}
