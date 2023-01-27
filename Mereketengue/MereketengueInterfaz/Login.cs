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
    public partial class Login : Form
    {
        private IMagazineISWService service;

        public Login(IMagazineISWService service)
        {
            InitializeComponent();
            this.service = service;
            this.checkBox2.Checked = false;
            this.checkBox2.Checked = true;
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void next_Click(object sender, EventArgs e) //QUITA ESTO CUANDO VAYAS A HACER PUSH ME CAGOENSATANAS
        {
            if (user.Text == "" || pssw.Text == "" || !service.Login(user.Text, pssw.Text))
            {
                DialogResult answer = MessageBox.Show(this, // Owner
                "Invalid Credentials", // Message
                "Unable to Login", // Title
                MessageBoxButtons.OK, // Buttons included
                MessageBoxIcon.Exclamation); // Icon
            }
            else {
                Menu_Principal ev1 = new Menu_Principal(service);
                this.Hide();
                ev1.ShowDialog();
                this.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void signup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp ev1 = new SignUp(service);
            this.Hide();
            ev1.ShowDialog();
            this.Close();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox2.Checked)
            {
                pssw.PasswordChar = '\0';
            }
            else {
                pssw.PasswordChar = '*';
            }
        
        }
    }
}
