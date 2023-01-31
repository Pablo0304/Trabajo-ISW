namespace MereketengueInterfaz
{
    partial class ventanaprincipalNueva
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
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonSingUp = new System.Windows.Forms.Button();
            this.buttonSeeIssues = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.Lavender;
            this.buttonLogin.FlatAppearance.BorderColor = System.Drawing.Color.Lavender;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("Nirmala UI", 25F);
            this.buttonLogin.Location = new System.Drawing.Point(15, 15);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(15);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(341, 248);
            this.buttonLogin.TabIndex = 0;
            this.buttonLogin.Text = " Login";
            this.buttonLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.button1_Click);
            this.buttonLogin.MouseEnter += new System.EventHandler(this.enterLogin);
            this.buttonLogin.MouseLeave += new System.EventHandler(this.leaveLogin);
            // 
            // buttonSingUp
            // 
            this.buttonSingUp.BackColor = System.Drawing.Color.Lavender;
            this.buttonSingUp.FlatAppearance.BorderColor = System.Drawing.Color.Lavender;
            this.buttonSingUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSingUp.Font = new System.Drawing.Font("Nirmala UI", 25F);
            this.buttonSingUp.Location = new System.Drawing.Point(386, 15);
            this.buttonSingUp.Margin = new System.Windows.Forms.Padding(15);
            this.buttonSingUp.Name = "buttonSingUp";
            this.buttonSingUp.Size = new System.Drawing.Size(342, 248);
            this.buttonSingUp.TabIndex = 1;
            this.buttonSingUp.Text = " Sign Up";
            this.buttonSingUp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSingUp.UseVisualStyleBackColor = false;
            this.buttonSingUp.Click += new System.EventHandler(this.button2_Click);
            this.buttonSingUp.MouseEnter += new System.EventHandler(this.enterSingUp);
            this.buttonSingUp.MouseLeave += new System.EventHandler(this.leaveSingUp);
            // 
            // buttonSeeIssues
            // 
            this.buttonSeeIssues.BackColor = System.Drawing.Color.Lavender;
            this.buttonSeeIssues.FlatAppearance.BorderColor = System.Drawing.Color.Lavender;
            this.buttonSeeIssues.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSeeIssues.Font = new System.Drawing.Font("Nirmala UI", 25F);
            this.buttonSeeIssues.Location = new System.Drawing.Point(758, 15);
            this.buttonSeeIssues.Margin = new System.Windows.Forms.Padding(15);
            this.buttonSeeIssues.Name = "buttonSeeIssues";
            this.buttonSeeIssues.Size = new System.Drawing.Size(340, 248);
            this.buttonSeeIssues.TabIndex = 2;
            this.buttonSeeIssues.Text = " See Issues";
            this.buttonSeeIssues.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSeeIssues.UseVisualStyleBackColor = false;
            this.buttonSeeIssues.Click += new System.EventHandler(this.button3_Click);
            this.buttonSeeIssues.MouseEnter += new System.EventHandler(this.Enterissues);
            this.buttonSeeIssues.MouseLeave += new System.EventHandler(this.leaveIssues);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Lavender;
            this.flowLayoutPanel1.Controls.Add(this.buttonLogin);
            this.flowLayoutPanel1.Controls.Add(this.buttonSingUp);
            this.flowLayoutPanel1.Controls.Add(this.buttonSeeIssues);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 202);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1115, 414);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.Color.SlateBlue;
            this.label1.Location = new System.Drawing.Point(245, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(678, 128);
            this.label1.TabIndex = 4;
            this.label1.Text = "MagazineAPP";
            // 
            // ventanaprincipalNueva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1141, 628);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "ventanaprincipalNueva";
            this.Text = "ventanaprincipalNueva";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonSingUp;
        private System.Windows.Forms.Button buttonSeeIssues;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
    }
}