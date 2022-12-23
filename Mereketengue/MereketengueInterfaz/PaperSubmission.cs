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
                                ErrorSurname.Text = "";
                                ErrorName.Text = "";
                                errorId.Text = "";
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
            catch (ServiceException)  { ErrorlistCoauthor.Text = "There is already 4 coauthors"; }
        } 

        private void Send(object sender, EventArgs e)
        {
            try {
                if (PaperTitlebox.Text != null && PaperTitlebox.Text != "")
                {
                    if (area != null)
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
                        }
                        else
                        {
                            Menu_Principal mp = new Menu_Principal(service);
                            this.Hide();
                            mp.ShowDialog();
                            this.Close();
                        }
                    }
                    else { ErrorArea.Text = "Area is not selected."; }
                }
                else { ErrorSend.Text = "Insert paper's title."; }
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

            DialogResult coauthors = MessageBox.Show(this, // Owner
            "Sure you dont want to add more Coauthors?", // Message
            "Lets send the paper", // Title
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

        private void ButtonDeleteCoauthor_Click(object sender, EventArgs e)
        {
            service.deleteCoauthor(SelectedCoauthor, papel);
        }

        private void SeleccionarCoauthor(object sender, EventArgs e)
        {
            try
            {
                String IDyNombre = ListCoauthors.SelectedItem.ToString();
                int posicion = IDyNombre.IndexOf(" ");
                String soloId = IDyNombre.Substring(0, posicion);
                SelectedCoauthor = service.SearchPerson(soloId);
                if (SelectedCoauthor.Equals(null)) { SelectedCoauthor = service.SearchUser(soloId); }
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
    }
}
