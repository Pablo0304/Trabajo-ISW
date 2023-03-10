using Magazine.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MereketengueInterfaz
{
    public partial class SignUp : Form
    {
        private IMagazineISWService service;
        public SignUp(IMagazineISWService service)
        {
            InitializeComponent();
            this.service = service;
            this.checkBox2.Checked = false;
            this.checkBox2.Checked = true;

    }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login ev1 = new Login(service);
            this.Hide();
            ev1.ShowDialog();
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pssw_TextChanged(object sender, EventArgs e)
        {

        }

        private void user_TextChanged(object sender, EventArgs e)
        {
            if (!checkBox2.Checked)
            {
                pssw.PasswordChar = '\0';
            }
            else
            {
                pssw.PasswordChar = '*';
            }
        }

        private void next_Click(object sender, EventArgs e)
        {
            if (textBoxId.Text == ""|| user.Text == "" || pssw.Text == "" || email.Text == "" || fieldsOfInterest.Text == "" || name.Text == "" || surname.Text == "" || !service.SignUp(textBoxId.Text, name.Text, surname.Text, checkBox1.Checked, checkBox2.Checked, fieldsOfInterest.Text, email.Text, user.Text, pssw.Text))
            {
                DialogResult answer = MessageBox.Show(this, // Owner
                "Invalid Credentials or Non-Existent User", // Message
                "Unable to Sign Up", // Title
                MessageBoxButtons.OK, // Buttons included
                MessageBoxIcon.Exclamation); // Icon
            }
            else {
                Login ev1 = new Login(service);
                this.Hide();
                ev1.ShowDialog();
                this.Close();
            }
        }

        private void check(object sender, EventArgs e)
        {
            if (!checkBox2.Checked)
            {
                pssw.PasswordChar = '\0';
            }
            else
            {
                pssw.PasswordChar = '*';
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }
        protected override void OnClosed(EventArgs e)
        {
            ventanaprincipalNueva ev1 = new ventanaprincipalNueva(service);
            this.Hide();
            ev1.ShowDialog();
            this.Close();
        }
    }
}
