using Magazine.Entities;
using Magazine.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
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
        private String decisionText = null;
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
            Ev1Error.Text = "";
        }

        private void SelectEv1(object sender, EventArgs e)
        {
            Ev1Error.Text = "";
            try
            {
                if (actualArea != null)
                {
                    if (selectedPaper != null)
                    {
                        if (TextComm.Text != "")
                        {
                            if (decisionText != null)
                            {
                                service.EvaluatePaper(actualArea, selectedPaper, d, TextComm.Text);
                                DialogResult error = MessageBox.Show(this, // Owner
                                "Sending...", // Message
                                "Correctly Evaluated", // Title
                                MessageBoxButtons.OK, // Buttons included
                                MessageBoxIcon.Information); // Icon
                                Menu_Principal mp = new Menu_Principal(service);
                                this.Hide();
                                mp.ShowDialog();
                                this.Close();
                            }
                            else { Ev1Error.Text = "There is no decision..."; }
                        }
                        else { Ev1Error.Text = "Empty Comment..."; }
                    }
                    else { Ev1Error.Text = "Paper is not selected..."; }
                }
                else { Ev1Error.Text = "Area is not selected..."; }
  
               
            } 
            catch (ServiceException se) 
            {
                DialogResult error= MessageBox.Show(this, // Owner
                se.Message, // Message
                "Unable to Evaluate Paper!!", // Title
                MessageBoxButtons.OK, // Buttons included
                MessageBoxIcon.Exclamation); // Icon  
            }
            
            
            
        }

        private void GoBackEv1(object sender, EventArgs e)
        {
            Menu_Principal mp = new Menu_Principal(service);
            this.Hide();
            mp.ShowDialog();
            this.Close();
        }

        private void seleccionarPaper(object sender, EventArgs e)
        {
            Ev1Error.Text = "";
            try 
            {
                if (listaPapers.SelectedItem != null)
                {
                    String namePaper = listaPapers.SelectedItem.ToString();
                    selectedPaper = service.SearchPaper(namePaper, actualArea);
                }
                else {
                    Ev1Error.Text = "Paper is not selected...";
                }
            } catch(ServiceException se) { Ev1Error.Text = "Paper doesn't exists..."; }
        }

        private void decision_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ev1Error.Text = "";
            if (decision.SelectedItem.Equals("Accept"))
            {
                decisionText = "-u-";
                d = true;
            }
            else {
                decisionText = "-.-";
                d = false;
            }
        }

        private void ChangeCommTextBox(object sender, EventArgs e)
        {
            Ev1Error.Text = "";
        }

        private void SelectAreas(object sender, EventArgs e)
        {
            listaPapers.Items.Clear();
            selectedPaper = null;
            Ev1Error.Text = "";
            String nameArea = comboAreas.GetItemText(comboAreas.SelectedItem);
            actualArea = service.SearchArea(nameArea);

            foreach (Paper p in actualArea.EvaluationPending)
            {
                listaPapers.Items.Add(p.Title);
            }
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
