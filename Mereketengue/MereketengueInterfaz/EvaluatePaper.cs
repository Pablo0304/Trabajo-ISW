using Magazine.Entities;
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
        Area actualArea;
        public EvaluatePaper(IMagazineISWService service)
        {
            InitializeComponent();
            this.service = service;
            foreach (Area a in service.listAreas())
            {
                comboAreas.Items.Add(a.Name);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SelectEv1(object sender, EventArgs e)
        {
            Menu_Principal mp = new Menu_Principal(service);
            this.Hide();
            mp.ShowDialog();
            this.Close();
        }

        private void GoBackEv1(object sender, EventArgs e)
        {
            Menu_Principal mp = new Menu_Principal(service);
            this.Hide();
            mp.ShowDialog();
            this.Close();
        }

        private void ComboBoxAreas(object sender, EventArgs e)
        {
            foreach (Area a in service.listAreas())
            {
                if ((String)comboAreas.SelectedItem == a.Name) { actualArea = a; }
            }
            listaPapers.Items.Clear();
            foreach (Paper p in service.getPendingEvaluationPapers(actualArea))
            {
                listaPapers.Items.Add(p.Title);
            }
        }
    }
}
