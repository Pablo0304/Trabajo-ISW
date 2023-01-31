namespace MereketengueInterfaz
{
    partial class ConsultarIssueNOReg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarIssueNOReg));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buscadorBox = new System.Windows.Forms.TextBox();
            this.buscador = new System.Windows.Forms.Button();
            this.ListaPapers = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.IssueNumberError = new System.Windows.Forms.Label();
            this.priceText = new System.Windows.Forms.Label();
            this.meterPrice = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 14F);
            this.label1.Location = new System.Drawing.Point(14, 87);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number issue:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 24F);
            this.label2.Location = new System.Drawing.Point(11, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(378, 45);
            this.label2.TabIndex = 3;
            this.label2.Text = "Consult published issues:";
            // 
            // buscadorBox
            // 
            this.buscadorBox.Location = new System.Drawing.Point(151, 92);
            this.buscadorBox.Name = "buscadorBox";
            this.buscadorBox.Size = new System.Drawing.Size(74, 20);
            this.buscadorBox.TabIndex = 4;
            this.buscadorBox.TextChanged += new System.EventHandler(this.tocarTexto);
            // 
            // buscador
            // 
            this.buscador.Font = new System.Drawing.Font("Nirmala UI", 10F);
            this.buscador.Location = new System.Drawing.Point(303, 92);
            this.buscador.Name = "buscador";
            this.buscador.Size = new System.Drawing.Size(50, 50);
            this.buscador.TabIndex = 5;
            this.buscador.UseVisualStyleBackColor = true;
            this.buscador.Click += new System.EventHandler(this.cluckBuscador);
            // 
            // ListaPapers
            // 
            this.ListaPapers.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.ListaPapers.FormattingEnabled = true;
            this.ListaPapers.ItemHeight = 21;
            this.ListaPapers.Location = new System.Drawing.Point(16, 172);
            this.ListaPapers.Name = "ListaPapers";
            this.ListaPapers.Size = new System.Drawing.Size(727, 277);
            this.ListaPapers.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(718, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // IssueNumberError
            // 
            this.IssueNumberError.AutoSize = true;
            this.IssueNumberError.Font = new System.Drawing.Font("Nirmala UI", 10F);
            this.IssueNumberError.ForeColor = System.Drawing.Color.Red;
            this.IssueNumberError.Location = new System.Drawing.Point(30, 118);
            this.IssueNumberError.Name = "IssueNumberError";
            this.IssueNumberError.Size = new System.Drawing.Size(173, 19);
            this.IssueNumberError.TabIndex = 12;
            this.IssueNumberError.Text = "Insert a valid number issue";
            this.IssueNumberError.Click += new System.EventHandler(this.IssueNumberError_Click);
            // 
            // priceText
            // 
            this.priceText.AutoSize = true;
            this.priceText.Font = new System.Drawing.Font("Nirmala UI", 14F);
            this.priceText.Location = new System.Drawing.Point(503, 92);
            this.priceText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.priceText.Name = "priceText";
            this.priceText.Size = new System.Drawing.Size(105, 25);
            this.priceText.TabIndex = 13;
            this.priceText.Text = "Issue price:";
            // 
            // meterPrice
            // 
            this.meterPrice.AutoSize = true;
            this.meterPrice.Font = new System.Drawing.Font("Nirmala UI", 14F);
            this.meterPrice.Location = new System.Drawing.Point(612, 92);
            this.meterPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.meterPrice.Name = "meterPrice";
            this.meterPrice.Size = new System.Drawing.Size(67, 25);
            this.meterPrice.TabIndex = 14;
            this.meterPrice.Text = "\"price\"";
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Nirmala UI", 10F);
            this.backButton.Location = new System.Drawing.Point(672, 468);
            this.backButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(72, 30);
            this.backButton.TabIndex = 15;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backClick);
            // 
            // ConsultarIssueNOReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 509);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.meterPrice);
            this.Controls.Add(this.priceText);
            this.Controls.Add(this.IssueNumberError);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ListaPapers);
            this.Controls.Add(this.buscador);
            this.Controls.Add(this.buscadorBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ConsultarIssueNOReg";
            this.Text = "ConsultarIssueNOReg";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox buscadorBox;
        private System.Windows.Forms.Button buscador;
        private System.Windows.Forms.ListBox ListaPapers;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label IssueNumberError;
        private System.Windows.Forms.Label priceText;
        private System.Windows.Forms.Label meterPrice;
        private System.Windows.Forms.Button backButton;
    }
}