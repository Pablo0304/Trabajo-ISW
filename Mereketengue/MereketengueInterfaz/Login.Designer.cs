namespace MereketengueInterfaz
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            this.user = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pssw = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.signup = new System.Windows.Forms.LinkLabel();
            this.next = new System.Windows.Forms.Button();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // user
            // 
            this.user.Font = new System.Drawing.Font("Nirmala UI", 14F);
            this.user.Location = new System.Drawing.Point(461, 229);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(152, 32);
            this.user.TabIndex = 0;
            this.user.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // pssw
            // 
            this.pssw.Font = new System.Drawing.Font("Nirmala UI", 14F);
            this.pssw.Location = new System.Drawing.Point(461, 305);
            this.pssw.Name = "pssw";
            this.pssw.Size = new System.Drawing.Size(152, 32);
            this.pssw.TabIndex = 2;
            this.pssw.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 14F);
            this.label1.Location = new System.Drawing.Point(400, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "User:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 14F);
            this.label2.Location = new System.Drawing.Point(360, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 14F);
            this.label3.Location = new System.Drawing.Point(456, 596);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "¿Not Registered?";
            // 
            // signup
            // 
            this.signup.AutoSize = true;
            this.signup.Font = new System.Drawing.Font("Nirmala UI", 14F);
            this.signup.Location = new System.Drawing.Point(466, 621);
            this.signup.Name = "signup";
            this.signup.Size = new System.Drawing.Size(129, 25);
            this.signup.TabIndex = 7;
            this.signup.TabStop = true;
            this.signup.Text = "Sign up here!!";
            this.signup.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.signup_LinkClicked);
            // 
            // next
            // 
            this.next.Font = new System.Drawing.Font("Nirmala UI", 14F);
            this.next.Location = new System.Drawing.Point(998, 681);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(85, 44);
            this.next.TabIndex = 8;
            this.next.Text = "Next";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Nirmala UI", 14F);
            this.checkBox2.Location = new System.Drawing.Point(637, 308);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(194, 29);
            this.checkBox2.TabIndex = 10;
            this.checkBox2.Text = "Ocultar Contraseña";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 737);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.next);
            this.Controls.Add(this.signup);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pssw);
            this.Controls.Add(this.user);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox user;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox pssw;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel signup;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.CheckBox checkBox2;
    }
}