namespace MereketengueInterfaz
{
    partial class ListPapers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListPapers));
            this.buscadorBox = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.buscador = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ListaPapers = new System.Windows.Forms.ListBox();
            this.ErrorArea = new System.Windows.Forms.Label();
            this.IssueNumberError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buscadorBox
            // 
            this.buscadorBox.Location = new System.Drawing.Point(529, 10);
            this.buscadorBox.Name = "buscadorBox";
            this.buscadorBox.Size = new System.Drawing.Size(36, 20);
            this.buscadorBox.TabIndex = 0;
            this.buscadorBox.TextChanged += new System.EventHandler(this.cambiaNumberIssue);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // buscador
            // 
            this.buscador.Font = new System.Drawing.Font("Nirmala UI", 10F);
            this.buscador.Location = new System.Drawing.Point(869, 10);
            this.buscador.Name = "buscador";
            this.buscador.Size = new System.Drawing.Size(50, 50);
            this.buscador.TabIndex = 2;
            this.buscador.UseVisualStyleBackColor = true;
            this.buscador.Click += new System.EventHandler(this.buscadorClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(889, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 14F);
            this.label2.Location = new System.Drawing.Point(396, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Number issue";
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Nirmala UI", 14F);
            this.backButton.Location = new System.Drawing.Point(33, 499);
            this.backButton.Margin = new System.Windows.Forms.Padding(2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(80, 38);
            this.backButton.TabIndex = 6;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(100, 10);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(112, 21);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.cambiarArea);
            this.comboBox1.Click += new System.EventHandler(this.LlenarAreas);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 14F);
            this.label3.Location = new System.Drawing.Point(43, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Area";
            // 
            // ListaPapers
            // 
            this.ListaPapers.Font = new System.Drawing.Font("Nirmala UI", 14F);
            this.ListaPapers.FormattingEnabled = true;
            this.ListaPapers.ItemHeight = 25;
            this.ListaPapers.Location = new System.Drawing.Point(33, 91);
            this.ListaPapers.Name = "ListaPapers";
            this.ListaPapers.Size = new System.Drawing.Size(895, 379);
            this.ListaPapers.TabIndex = 9;
            // 
            // ErrorArea
            // 
            this.ErrorArea.AutoSize = true;
            this.ErrorArea.Font = new System.Drawing.Font("Nirmala UI", 10F);
            this.ErrorArea.ForeColor = System.Drawing.Color.Red;
            this.ErrorArea.Location = new System.Drawing.Point(44, 41);
            this.ErrorArea.Name = "ErrorArea";
            this.ErrorArea.Size = new System.Drawing.Size(45, 19);
            this.ErrorArea.TabIndex = 10;
            this.ErrorArea.Text = "label4";
            // 
            // IssueNumberError
            // 
            this.IssueNumberError.AutoSize = true;
            this.IssueNumberError.Font = new System.Drawing.Font("Nirmala UI", 10F);
            this.IssueNumberError.ForeColor = System.Drawing.Color.Red;
            this.IssueNumberError.Location = new System.Drawing.Point(397, 41);
            this.IssueNumberError.Name = "IssueNumberError";
            this.IssueNumberError.Size = new System.Drawing.Size(45, 19);
            this.IssueNumberError.TabIndex = 11;
            this.IssueNumberError.Text = "label5";
            // 
            // ListPapers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 564);
            this.Controls.Add(this.IssueNumberError);
            this.Controls.Add(this.ErrorArea);
            this.Controls.Add(this.ListaPapers);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buscador);
            this.Controls.Add(this.buscadorBox);
            this.Name = "ListPapers";
            this.Text = "List Papers";
            this.Load += new System.EventHandler(this.ListPapers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox buscadorBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button buscador;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox ListaPapers;
        private System.Windows.Forms.Label ErrorArea;
        private System.Windows.Forms.Label IssueNumberError;
    }
}