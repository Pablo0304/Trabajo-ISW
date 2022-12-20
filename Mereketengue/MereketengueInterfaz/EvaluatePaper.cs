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
        public EvaluatePaper()
        {
            InitializeComponent();
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

        private void button2_Click(object sender, EventArgs e)
        {
            EvaluatePaper2 ev2 = new EvaluatePaper2();
            EvaluatePaper ev1 = new EvaluatePaper();
            ev1.Show();
            ev2.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EvaluatePaper2 ev2 = new EvaluatePaper2();
            EvaluatePaper ev1 = new EvaluatePaper();
            ev2.Show();
            ev1.Close();
        }
    }
}
