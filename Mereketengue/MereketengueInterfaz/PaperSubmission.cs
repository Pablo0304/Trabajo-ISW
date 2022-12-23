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

namespace MereketengueInterfaz
{
    public partial class PaperSubmission : Form
    {
        private IMagazineISWService service;
        private Area area;
        private Paper papel;
        private Person person;

        public PaperSubmission(IMagazineISWService service)
        {
            InitializeComponent();
            this.service = service;
            ErrorSend.Text = "";
            Error4.Text = "";
            ErrorlistCoauthor.Text = "";
            ErrorName.Text = "";
            ErrorSurname.Text = "";
            errorId.Text = "";
            labelCoauthor.Text = "";
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
                                person = service.addCoauthor(textBoxID.Text, textBoxName.Text, textBoxSurname.Text, papel);
                                ErrorSurname.Enabled = false;
                                ErrorName.Enabled = false;
                                errorId.Enabled = false;
                                ListCoauthors.Items.Add(person.Name.ToString());
                            }
                        }
                        else
                        {
                            ErrorSurname.Enabled = true;
                            ErrorSurname.Text = "Insert surname";
                        }

                    }
                    else
                    {
                        ErrorName.Enabled = true;
                        ErrorName.Text = "Insert name";
                    }

                }
                else
                {
                    errorId.Enabled = true;
                    errorId.Text = "Insert id";
                }
                
            }
            catch (ServiceException) 
            {
                Error4.Text = "There is already 4 coauthors";
            }
        } 

        private void Send(object sender, EventArgs e)
        {
            try {
                if (PaperTitlebox.Text != null && PaperTitlebox.Text != "")
                {
                    if (area != null)
                    {
                        papel = service.EnviarPaper(area, PaperTitlebox.Text);
                        DialogResult Añadido = MessageBox.Show(this, // Owner
                        "Corectly Added to de DB", // Message
                        "Paper Created", // Title
                        MessageBoxButtons.OK, // Buttons included
                        MessageBoxIcon.Information); // Icon

                        DialogResult coauthors = MessageBox.Show(this, // Owner
                        "Would you like to add some Coauthors?", // Message
                        "Optional", // Title
                        MessageBoxButtons.OKCancel, // Buttons included
                        MessageBoxIcon.Information); // Icon
                        if (coauthors == DialogResult.OK)
                        {
                            paneltrampa.SendToBack();
                            buttonSend.Enabled = false;
                            ListCoauthors.Items.Clear();
                            ListCoauthors.Items.Add(service.gLoggedUser().Name.ToString());
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
            catch (ServiceException) { ErrorSend.Text = "There is already a paper with the same Title in this area."; }
        }

        private void LlenarAreas(object sender, EventArgs e)
        {
            comboBoxAreas.Items.Clear();
            List<Area> lista = (List<Area>)service.listAreas();
            foreach (Area a in lista)
            {
                comboBoxAreas.Items.Add(a.Name.ToString());
            }
        }

        private void cambiarSelectArea(object sender, EventArgs e)
        {
            String item = comboBoxAreas.GetItemText(comboBoxAreas.SelectedItem);
            area = service.gArea(item);
        }

        private void ConfirmameEsta(object sender, EventArgs e)
        {
            Menu_Principal mp = new Menu_Principal(service);
            this.Hide();
            mp.ShowDialog();
            this.Close();
        }
    }
}
