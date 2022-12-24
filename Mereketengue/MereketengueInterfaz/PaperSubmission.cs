using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Magazine.Services;
using Magazine.Entities;
using Magazine.Persistence;
using System.Runtime.ConstrainedExecution;
using System.Collections;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MereketengueInterfaz
{
    public partial class PaperSubmission : Form
    {
        private IMagazineISWService service;
        private Area area;
        private Paper papel;
        private Person person;
        private Person SelectedCoauthor;
        private String item;

        public PaperSubmission(IMagazineISWService service)
        {
            InitializeComponent();
            this.service = service;
            ErrorSend.Text = "";
            ErrorlistCoauthor.Text = "";
            ErrorName.Text = "";
            ErrorSurname.Text = "";
            errorId.Text = "";
            ErrorArea.Text = "";
        }

        private void AddCoauthor(object sender, EventArgs e)
        {
            ErrorlistCoauthor.Text = "";
            ErrorSurname.Text = "";
            ErrorName.Text = "";
            errorId.Text = "";
            try
            {
                if (textBoxID.Text != null && textBoxID.Text != "")
                {
                    if (textBoxName.Text != null && textBoxName.Text != "")
                    {
                        if (textBoxSurname.Text != null && textBoxSurname.Text != "")
                        {
                            if (papel != null)
                            {
                                
                                person = service.addCoauthor(textBoxID.Text, textBoxName.Text, textBoxSurname.Text, papel);
                                String persona = person.Id.ToString();
                                ListCoauthors.Items.Add(persona + " " + person.Name.ToString());
                                textBoxID.Text = "";
                                textBoxName.Text = "";
                                textBoxSurname.Text = "";
                            }
                        } else { ErrorSurname.Text = "Insert surname"; }
                    } else { ErrorName.Text = "Insert name"; }
                } else{ errorId.Text = "Insert id";} 
            }
            catch (ServiceException ex)  { ErrorlistCoauthor.Text = ex.Message; }
        } 

        private void Send(object sender, EventArgs e)
        {
            try {
                if (area != null)
                {
                    
                    if (PaperTitlebox.Text != null && PaperTitlebox.Text != "")
                    {
                        papel = service.EnviarPaper(area, PaperTitlebox.Text);

                        DialogResult coauthors = MessageBox.Show(this, // Owner
                        "Would you like to add some Coauthors?", // Message
                        "Paper Created", // Title
                        MessageBoxButtons.OKCancel, // Buttons included
                        MessageBoxIcon.Question); // Icon
                        if (coauthors == DialogResult.OK)
                        {
                            paneltrampa.SendToBack();
                            buttonSend.Enabled = false;
                            ListCoauthors.Items.Clear();
                            String actualUser = service.gLoggedUser().Id.ToString();
                            ListCoauthors.Items.Add(actualUser + " " + service.gLoggedUser().Name.ToString());
                            item = actualUser + " " + service.gLoggedUser().Name.ToString();
                        }
                        else
                        {
                            Menu_Principal mp = new Menu_Principal(service);
                            this.Hide();
                            mp.ShowDialog();
                            this.Close();
                        }
                    }
                    else { ErrorSend.Text = "Insert paper's title."; }
                }
               
                else { ErrorArea.Text = "Area is not selected."; }
            }
            catch (ServiceException ex) 
            {
                DialogResult coauthors = MessageBox.Show(this, // Owner
                ex.Message, // Message
                "Error", // Title
                MessageBoxButtons.OK, // Buttons included
                MessageBoxIcon.Error); // Icon 
            }
        }

        private void LlenarAreas(object sender, EventArgs e)
        {
            ErrorArea.Text = "";
            ErrorSend.Text = "";
            comboBoxAreas.Items.Clear();
            List<Area> lista = (List<Area>)service.listAreas();
            foreach (Area a in lista)
            {
                comboBoxAreas.Items.Add(a.Name.ToString());
            }
        }

        private void cambiarSelectArea(object sender, EventArgs e)
        {
            String nombre = comboBoxAreas.GetItemText(comboBoxAreas.SelectedItem);
            area = service.SearchArea(nombre);
        }

        private void ConfirmameEsta(object sender, EventArgs e)
        {
            if (area != null)
            {
                if (PaperTitlebox.Text != "")
                {
                    if (papel.CoAuthors.Count < 4)
                    {
                        DialogResult coauthors = MessageBox.Show(this, // Owner
                        "You could add " + (4 - papel.CoAuthors.Count) + " more", // Message
                        "Dont want to add more Coauthors?", // Title
                        MessageBoxButtons.YesNo, // Buttons included
                        MessageBoxIcon.Question); // Icon
                        if (coauthors == DialogResult.Yes)
                        {
                            DialogResult Sending = MessageBox.Show(this, // Owner
                            "Sending... ", // Message
                            "Saving the paper " + papel.Title + " in BD", // Title
                            MessageBoxButtons.OK, // Buttons included
                            MessageBoxIcon.Information); // Icon
                            Menu_Principal mp = new Menu_Principal(service);
                            this.Hide();
                            mp.ShowDialog();
                            this.Close();
                        }
                    }
                    else
                    {
                        DialogResult Sending2 = MessageBox.Show(this, // Owner
                        "Sending... ", // Message
                        "Saving the paper " + papel.Title + " in BD", // Title
                        MessageBoxButtons.OK, // Buttons included
                        MessageBoxIcon.Information); // Icon
                        Menu_Principal mp2 = new Menu_Principal(service);
                        this.Hide();
                        mp2.ShowDialog();
                        this.Close();
                    }
                }
                else { ErrorSend.Text = "Insert paper's title."; }
            }
            else { ErrorArea.Text = "Insert area."; }
        }

        private void ButtonDeleteCoauthor_Click(object sender, EventArgs e)
        {
            try
            {
                if (!SelectedCoauthor.Equals(papel.Responsible))
                {
                    service.deleteCoauthor(SelectedCoauthor, papel);
                    ListCoauthors.Items.Remove(ListCoauthors.SelectedItem);
                    ListCoauthors.SelectedItem = item;
                }
                else { ErrorlistCoauthor.Text = "You cant remove the paper's responsible"; }

            }
            catch (ServiceException ex) { ErrorlistCoauthor.Text = ex.Message; }
        }

        private void SeleccionarCoauthor(object sender, EventArgs e)
        {
            ErrorlistCoauthor.Text = "";
            try
            {
                if (ListCoauthors.SelectedItem != null)
                {
                    String IDyNombre = ListCoauthors.SelectedItem.ToString();
                    int posicion = IDyNombre.IndexOf(" ");
                    String soloId = IDyNombre.Substring(0, posicion);
                    SelectedCoauthor = service.SearchPerson(soloId);
                    if (SelectedCoauthor.Equals(null)) { SelectedCoauthor = service.SearchUser(soloId); }
                }
                else { ErrorlistCoauthor.Text = "Select a Coauthor"; }
            }
            catch (ServiceException ex) 
            {
                DialogResult Sending = MessageBox.Show(this, // Owner
                ex.Message + "", // Message
                "Error", // Title
                MessageBoxButtons.OK, // Buttons included
                MessageBoxIcon.Information); // Icon
            }
        }

        private void escribe(object sender, EventArgs e)
        {
            ErrorSend.Text = "";
        }
    }
}
