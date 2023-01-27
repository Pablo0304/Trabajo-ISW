namespace MereketengueInterfaz
{
    partial class SignUp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.next = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.surname = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.fieldsOfInterest = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pssw = new System.Windows.Forms.TextBox();
            this.user = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.ffff = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // next
            // 
            this.next.Location = new System.Drawing.Point(701, 499);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(75, 23);
            this.next.TabIndex = 15;
            this.next.Text = "Next";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(375, 467);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(63, 13);
            this.linkLabel1.TabIndex = 14;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Login here!!";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(344, 454);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "¿Alredy have an account?";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(288, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Surname:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(288, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Name:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // surname
            // 
            this.surname.Location = new System.Drawing.Point(347, 108);
            this.surname.Name = "surname";
            this.surname.Size = new System.Drawing.Size(152, 20);
            this.surname.TabIndex = 10;
            this.surname.TextChanged += new System.EventHandler(this.pssw_TextChanged);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(347, 66);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(152, 20);
            this.name.TabIndex = 9;
            this.name.TextChanged += new System.EventHandler(this.user_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(255, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Fields of interest:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(288, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Email:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // fieldsOfInterest
            // 
            this.fieldsOfInterest.Location = new System.Drawing.Point(347, 189);
            this.fieldsOfInterest.Multiline = true;
            this.fieldsOfInterest.Name = "fieldsOfInterest";
            this.fieldsOfInterest.Size = new System.Drawing.Size(214, 79);
            this.fieldsOfInterest.TabIndex = 17;
            this.fieldsOfInterest.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(347, 147);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(214, 20);
            this.email.TabIndex = 16;
            this.email.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(288, 332);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Password:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(293, 290);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "User:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // pssw
            // 
            this.pssw.Location = new System.Drawing.Point(347, 329);
            this.pssw.Name = "pssw";
            this.pssw.Size = new System.Drawing.Size(152, 20);
            this.pssw.TabIndex = 21;
            this.pssw.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // user
            // 
            this.user.Location = new System.Drawing.Point(347, 287);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(152, 20);
            this.user.TabIndex = 20;
            this.user.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(258, 408);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(316, 17);
            this.checkBox1.TabIndex = 24;
            this.checkBox1.Text = "I want to receive an email each time a new issue is published.";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(308, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "id:";
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(347, 38);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(100, 20);
            this.textBoxId.TabIndex = 26;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Location = new System.Drawing.Point(510, 331);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(118, 17);
            this.checkBox2.TabIndex = 27;
            this.checkBox2.Text = "Mostrar Contraseña";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckStateChanged += new System.EventHandler(this.check);
            // 
            // ffff
            // 
            this.ffff.AutoSize = true;
            this.ffff.Location = new System.Drawing.Point(258, 385);
            this.ffff.Name = "ffff";
            this.ffff.Size = new System.Drawing.Size(148, 17);
            this.ffff.TabIndex = 28;
            this.ffff.Text = "I want to monthly suscribe";
            this.ffff.UseVisualStyleBackColor = true;
            this.ffff.CheckedChanged += new System.EventHandler(this.label2_Click);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 545);
            this.Controls.Add(this.ffff);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pssw);
            this.Controls.Add(this.user);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.fieldsOfInterest);
            this.Controls.Add(this.email);
            this.Controls.Add(this.next);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.surname);
            this.Controls.Add(this.name);
            this.Name = "SignUp";
            this.Text = "SignUp";
            this.Load += new System.EventHandler(this.SignUp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button next;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox surname;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox fieldsOfInterest;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox pssw;
        private System.Windows.Forms.TextBox user;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox ffff;
    }
}