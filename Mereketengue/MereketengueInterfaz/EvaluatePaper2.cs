﻿using System;
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
    public partial class EvaluatePaper2 : Form
    {
        public EvaluatePaper2()
        {
            InitializeComponent();
        }

        private void Send(object sender, EventArgs e)
        {
            Menu_Principal mp = new Menu_Principal(service);
            this.Hide();
            mp.ShowDialog();
            this.Show();
        }

        private void GoBackEv2(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
