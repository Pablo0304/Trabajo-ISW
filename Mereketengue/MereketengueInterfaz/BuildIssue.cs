using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Magazine.Entities;
using Magazine.Persistence;
using Magazine.Services;
using MereketengueInterfaz.Properties;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MereketengueInterfaz
{
    public partial class BuildIssue : Form
    {
        private IMagazineISWService service;
        Area actualArea = null;
        Paper selectedPaper = null;
        Issue selectedIssue = null;
        private List<int> lista;
        private int selected = 0;
        ICollection<Paper> papersParaEliminar = new List<Paper>();
        ICollection<Paper> selectedPapersAux = new List<Paper>();
        Magazine.Entities.Magazine magazine;
        public BuildIssue(IMagazineISWService service)
        {
            InitializeComponent();
            ErrorArea.Text = "";
            ErrorAgregar.Text = "";
            ErrorCrear.Text = "";
            ErrorNumber.Text = "";
            ErrorDiscount.Text = "";
            ErrorPrice.Text = "";
            errordate.Text = "";
            this.agregarPaper.Image = Resources.flecha_correcta;
            this.busacarButton.Image = Resources.lupa;
            this.service = service;

            /*Issue lastIssue = service.getLastIssue();

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
            }*/
            //selectorArea.Items.Add(service.listAreas());

        }

        private void seleccionarPaper(object sender, EventArgs e)
        {
            if (listaPapers.SelectedItem != null)
            {
                String var = listaPapers.GetItemText(listaPapers.SelectedItem);
                selectedPaper = service.SearchPaper(var, actualArea);
            }
            
        }

        private void seleccionarArea(object sender, EventArgs e)
        {
            listaPapers.Items.Clear();
            selectedPaper = null;
            String nameArea = selectorAreaCombo.GetItemText(selectorAreaCombo.SelectedItem);
            actualArea = service.SearchArea(nameArea);

        }

        private void buscarClick(object sender, EventArgs e)
        {
            if (actualArea != null)
            {
                listaPapers.Items.Clear();
                foreach (Paper p in service.getPendingPublicationPapers(actualArea))
                {
                    listaPapers.Items.Add(p.Title.ToString());
                }
            }
            else { ErrorArea.Text = "Select an area"; }

            //listaPapers.Items.Add(service.getPendingPublicationPapers(actualArea));
        }

        private void BuildIssue_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'magazineDBDataSet.Papers' Puede moverla o quitarla según sea necesario.

        }

        private void agregarPaperClick(object sender, EventArgs e)
        {
            if (actualArea != null)
            {
                if (selectedPaper != null)
                {
                    selectedPapersAux.Add(selectedPaper);
                    if (!selectedPapers.Items.Contains(selectedPaper.Title))
                    {
                        selectedPapers.Items.Add(selectedPaper.Title);
                    }
                }
                else { ErrorAgregar.Text = "Select paper"; }
            }
            else { ErrorArea.Text = "Select an area"; }
        }

        protected override void OnClosed(EventArgs e)
        {
            Menu_Principal mp4 = new Menu_Principal(service);
            this.Hide();
            mp4.ShowDialog();
            this.Close();
        }

        private void cargarAreasCombo(object sender, EventArgs e)
        {
            selectorAreaCombo.Items.Clear();
            foreach (Area a in service.listAreas())
            {
                selectorAreaCombo.Items.Add(a.Name.ToString());
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Menu_Principal mp4 = new Menu_Principal(service);
            this.Hide();
            mp4.ShowDialog();
            this.Close();
        }

        private void AcceptClick(object sender, EventArgs e)
        {
            magazine = service.getMagazine();
            lista = magazine.getallnumbers();
            ErrorCrear.Text = "";
            //ErrorAgregar.Text = selected.ToString();

            if (selected == 2)
            {
                if (textBoxnumber.Text != "")
                {
                    if (textBoxdiscount.Text != "")
                    {
                        if (textBoxprice.Text != "")
                        {
                            try
                            {
                                float price = float.Parse(textBoxprice.Text);
                                float discount = float.Parse(textBoxdiscount.Text);
                                if (discount >= 0 && discount <= 100)
                                {
                                    if (!lista.Contains(int.Parse(textBoxnumber.Text)))
                                    {
                                        service.BuildIssue(int.Parse(textBoxnumber.Text), dateTimePicker.Value, selectedPapersAux,price,discount);
                                        Menu_Principal ev1 = new Menu_Principal(service);
                                        this.Hide();
                                        ev1.ShowDialog();
                                        this.Close();
                                    }
                                    else { ErrorCrear.Text = "There is already an Issue with that number, You can edit it if you want"; }
                                }
                                else { ErrorDiscount.Text = "Insert a valid discount 0%-100%"; }
                            }
                            catch (FormatException)
                            {
                                ErrorNumber.Text = "Thats not a valid number.";
                            }
                            catch (OverflowException)
                            {
                                ErrorNumber.Text = "That number is too big or too small, idk.";
                            }
                        }
                        else { ErrorPrice.Text = "Insert Price"; }
                    }
                    else { ErrorDiscount.Text = "Insert Discount"; }
                }
                else { ErrorNumber.Text = "Insert Number"; }

            }
            else if (selected == 1)
            {
                if (selectedIssue != null)
                {
                    if (textBoxdiscount.Text != "")
                    {
                        if (textBoxprice.Text != "")
                        {
                            if (dateTimePicker.Value > DateTime.Now)
                            {
                                try
                                {
                                    float price = float.Parse(textBoxprice.Text);
                                    float discount = float.Parse(textBoxdiscount.Text);
                                    if (discount >= 0 && discount <= 100)
                                    {
                                        service.eliminarPublishedpapers(papersParaEliminar);
                                        service.EditIssue(selectedIssue, selectedPapersAux, dateTimePicker.Value, discount, price);
                                        Menu_Principal ev1 = new Menu_Principal(service);
                                        this.Hide();
                                        ev1.ShowDialog();
                                        this.Close();
                                    }
                                    else { ErrorDiscount.Text = "Insert a valid discount 0%-100%"; }
                                }
                                catch (FormatException)
                                {
                                    ErrorDiscount.Text = "Price and discount must bee a positive decimal value.";
                                    ErrorPrice.Text = "Price and discount must bee a positive decimal value.";
                                }
                                catch (OverflowException)
                                {
                                    ErrorDiscount.Text = "That number is too big or too small, idk.";
                                    ErrorPrice.Text = "That number is too big or too small, idk.";
                                }
                            }
                            else { errordate.Text = "date must be in the future"; }
                        }
                        else { ErrorPrice.Text = "Insert Price"; }
                    }
                    else { ErrorDiscount.Text = "Insert Discount"; }
                }
                else { ErrorCrear.Text = "Select an issue for edit it"; }
            }   
            
        }
        
        private void clickeditar(object sender, EventArgs e)
        {
            ErrorNumber.Text = "";
            ErrorDiscount.Text = "";
            ErrorPrice.Text = "";
            paneltapamelotodo.Visible = false;
            magazine = service.getMagazine();
            this.selectorIssueComboTextoOpcionEditar.ForeColor = Color.White;
            this.selectorIssueComboTextoOpcionEditar.BackColor = Color.SlateBlue;
            this.TextoOpcionNueva.ForeColor = Color.Black;
            this.TextoOpcionNueva.BackColor = Color.Lavender;
            selected = 1;
            selectorIssueComboTextoOpcionEditar.Items.Clear();
            foreach (Issue i in magazine.Issues)
            {
                if (i.PublicationDate > DateTime.Now)
                {
                    int aux = i.Number;
                    selectorIssueComboTextoOpcionEditar.Items.Add(aux);
                }
            }

        }

        private void clickNueva(object sender, EventArgs e)
        {
            selectedIssue = null;
            selected = 2;
            selectorIssueComboTextoOpcionEditar.Text = "Select Issue to edit";
            paneltapamelotodo.Visible = false;
            dateTimePicker.Value = DateTime.Now;
            textBoxnumber.Enabled = true;
            textBoxnumber.Text = "";
            textBoxdiscount.Text = "";
            textBoxprice.Text = "";
            ErrorNumber.Text = "";
            ErrorDiscount.Text = "";
            ErrorPrice.Text = "";
            this.TextoOpcionNueva.ForeColor = Color.White;
            this.TextoOpcionNueva.BackColor = Color.SlateBlue;
            this.selectorIssueComboTextoOpcionEditar.ForeColor = Color.Black;
            this.selectorIssueComboTextoOpcionEditar.BackColor = Color.White;
            
        }

        private void leavepaneleditar(object sender, EventArgs e)
        {
            if (selected == 0)
            {
                this.selectorIssueComboTextoOpcionEditar.ForeColor = Color.Black;
                this.selectorIssueComboTextoOpcionEditar.BackColor = Color.Lavender;
            }
        }

        private void enterpaneleditar(object sender, EventArgs e)
        {
            if (selected == 0)
            {
                this.selectorIssueComboTextoOpcionEditar.ForeColor = Color.White;
                this.selectorIssueComboTextoOpcionEditar.BackColor = Color.SlateBlue;
            }
        }

        private void leavepanelnueva(object sender, EventArgs e)
        {
            if (selected == 0)
            {
                this.TextoOpcionNueva.ForeColor = Color.Black;
                this.TextoOpcionNueva.BackColor = Color.Lavender;
            }
        }

        private void enterpanelnueva(object sender, EventArgs e)
        {
            if (selected == 0)
            {
                this.TextoOpcionNueva.ForeColor = Color.White;
                this.TextoOpcionNueva.BackColor = Color.SlateBlue;
            }
        }

        private void cambiarIssue(object sender, EventArgs e)
        {
            selectedPapers.Items.Clear();
            listaPapers.Items.Clear();
            selectedIssue = null;
            int numberIssue = (int)selectorIssueComboTextoOpcionEditar.SelectedItem;
            selectedIssue = service.searchIssue(numberIssue);

            papersParaEliminar = selectedIssue.PublishedPapers;
            dateTimePicker.Value = (DateTime)selectedIssue.PublicationDate;
            textBoxnumber.Text = selectedIssue.Number + "";
            textBoxnumber.Enabled = false;
            textBoxdiscount.Text = selectedIssue.Discount + "";
            textBoxprice.Text = selectedIssue.Price + "" ;
        }

        private void cambiarnumber(object sender, EventArgs e)
        {
            ErrorCrear.Text = "";
            errordate.Text = "";
            ErrorDiscount.Text = "";
            ErrorPrice.Text = "";
        }

        private void cambiardiscount(object sender, EventArgs e)
        {
            ErrorCrear.Text = "";
            errordate.Text = "";
            ErrorDiscount.Text = "";
            ErrorPrice.Text = "";
        }

        private void cambiarprice(object sender, EventArgs e)
        {
            ErrorCrear.Text = "";
            errordate.Text = "";
            ErrorDiscount.Text = "";
            ErrorPrice.Text = "";
        }

        private void cambiarfecha(object sender, EventArgs e)
        {
            ErrorCrear.Text = "";
            errordate.Text = "";
            ErrorDiscount.Text = "";
            ErrorPrice.Text = "";
        }
    }
}
