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
    public partial class BuyIssue : Form
    {
        private IMagazineISWService service;
        private Magazine.Entities.Magazine magazine;
        private Issue selectedIssue;
        private User controluser;
        private ICollection<Issue> issuesListacompra;
        public BuyIssue(IMagazineISWService service)
        {
            InitializeComponent();
            this.service = service;
            buttonaddcart.Image = Resources.flecha_correcta;
            buttonborrar.Image = Resources.flecha_correct33233;
        }

        private void elegirIssue(object sender, EventArgs e)
        {
            int numberIssue = (int)issuesPublicadas.SelectedItem;
            selectedIssue = service.searchIssue(numberIssue);
        }

        private void buttonaddcart_Click(object sender, EventArgs e)
        {
            //añadir a la lista
            if (selectedIssue != null)
            {
                issuesListacompra.Add(selectedIssue);
                listacompra.Items.Add(selectedIssue.Number);
            }
            //calcular price
            if (controluser.MagazineSubscriber)
            {
                String aux = "";
                foreach (Issue issue in issuesListacompra)
                {
                    aux += (issue.Price * issue.Discount);
                }
                labelprecio.Text = aux + " €";
            }
            else 
            {
                String aux = "";
                foreach (Issue issue in issuesListacompra)
                {
                    aux += issue.Price;
                }
                labelprecio.Text = aux + " €";
            }
        }

        private void buttonborrar_Click(object sender, EventArgs e)
        {
            //eliminar de la lista
            if(listacompra.SelectedItem != null)
            {
                int numberIssue = (int)listacompra.SelectedItem;
                listacompra.Items.Remove(listacompra.SelectedItem);
                Issue aux = service.searchIssue(numberIssue);
                issuesListacompra.Remove(aux);
            }
        }

        private void load(object sender, EventArgs e)
        {
            controluser = service.getLoggedUser();
            magazine = service.getMagazine();
            foreach(Issue i in magazine.Issues)
            {
                if(i.PublicationDate < DateTime.Now)
                {
                    issuesPublicadas.Items.Add(i.Number);
                    
                }
            }
        }

        private void Buybutton_Click(object sender, EventArgs e)
        {
            DialogResult coauthors = MessageBox.Show(this, // Owner
                       "", // Message
                       "Buy Issues", // Title
                       MessageBoxButtons.OKCancel, // Buttons included
                       MessageBoxIcon.Question); // Icon
            if (coauthors == DialogResult.OK)
            {
                Menu_Principal mp = new Menu_Principal(service);
                this.Hide();
                mp.ShowDialog();
                this.Close();
            }
        }
    }

}
