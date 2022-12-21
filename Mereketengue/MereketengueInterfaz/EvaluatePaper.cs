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
    public partial class EvaluatePaper : Form
    {
        private IMagazineISWService service;
        public EvaluatePaper(IMagazineISWService service)
        {
            InitializeComponent();
            this.service = service;
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SelectEv1(object sender, EventArgs e)
        {
            EvaluatePaper2 ev2 = new EvaluatePaper2();
            this.Hide();
            ev2.ShowDialog();
            this.Show();
        }

        private void GoBackEv1(object sender, EventArgs e)
        {
            /*
            this.Hide();
            MenuPrincipal.ShowDialog();
            this.Show();
            */
        }

        private void ComboBoxAreas(object sender, EventArgs e)
        {
            
        }
    }
}
