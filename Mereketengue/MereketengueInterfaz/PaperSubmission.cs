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
        private Person selectedCoauthor;
        private List<Person> Coauthors;

        public PaperSubmission(IMagazineISWService service)
        {
            InitializeComponent();
            this.service = service;
            /*listaAreas.Items.Clear();

            foreach (Area a in service.listAreas())
            {
                listaAreas.Items.Add(a.Name.ToString());
            }*/
        }

        private void AddCoauthor(object sender, EventArgs e)
        {
            if (ListCoauthors.Items.Count < 4)
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
            else
            {
                Error4.Enabled = true;
                Error4.Text = "There is already 4 coauthors";
            }
        } 

        private void Send(object sender, EventArgs e)
        {
            if (PaperTitlebox.Text != null && PaperTitlebox.Text != "" && area != null)
            {
                papel = service.EnviarPaper(area, PaperTitlebox.Text);
                DialogResult answer = MessageBox.Show(this, // Owner
                "Corectly Added to de DB", // Message
                "Paper Created", // Title
                MessageBoxButtons.OK, // Buttons included
                MessageBoxIcon.Information); // Icon
                buttonSend.Enabled = false;
                ListCoauthors.Items.Add(service.gLoggedUser().Name.ToString());
                
            }
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
            Selectedarea.Text = area.Name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu_Principal mp = new Menu_Principal(service);
            this.Hide();
            mp.ShowDialog();
            this.Close();
        }
    }
}
