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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buscadorBox = new System.Windows.Forms.TextBox();
            this.buscador = new System.Windows.Forms.Button();
            this.ListaPapers = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.IssueNumberError = new System.Windows.Forms.Label();
            this.priceText = new System.Windows.Forms.Label();
            this.meterPrice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 14F);
            this.label1.Location = new System.Drawing.Point(64, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number issue:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 24F);
            this.label2.Location = new System.Drawing.Point(12, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(470, 54);
            this.label2.TabIndex = 3;
            this.label2.Text = "Consult published issues:";
            // 
            // buscadorBox
            // 
            this.buscadorBox.Location = new System.Drawing.Point(238, 109);
            this.buscadorBox.Margin = new System.Windows.Forms.Padding(4);
            this.buscadorBox.Name = "buscadorBox";
            this.buscadorBox.Size = new System.Drawing.Size(47, 22);
            this.buscadorBox.TabIndex = 4;
            // 
            // buscador
            // 
            this.buscador.Font = new System.Drawing.Font("Nirmala UI", 10F);
            this.buscador.Location = new System.Drawing.Point(386, 100);
            this.buscador.Margin = new System.Windows.Forms.Padding(4);
            this.buscador.Name = "buscador";
            this.buscador.Size = new System.Drawing.Size(67, 62);
            this.buscador.TabIndex = 5;
            this.buscador.UseVisualStyleBackColor = true;
            this.buscador.Click += new System.EventHandler(this.cluckBuscador);
            // 
            // ListaPapers
            // 
            this.ListaPapers.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.ListaPapers.FormattingEnabled = true;
            this.ListaPapers.ItemHeight = 28;
            this.ListaPapers.Location = new System.Drawing.Point(21, 212);
            this.ListaPapers.Margin = new System.Windows.Forms.Padding(4);
            this.ListaPapers.Name = "ListaPapers";
            this.ListaPapers.Size = new System.Drawing.Size(753, 256);
            this.ListaPapers.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 173);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(767, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "---------------------------------------------------------------------------------" +
    "--------------------------------------------------------------------------------" +
    "-----------------------------";
            // 
            // IssueNumberError
            // 
            this.IssueNumberError.AutoSize = true;
            this.IssueNumberError.Font = new System.Drawing.Font("Nirmala UI", 10F);
            this.IssueNumberError.ForeColor = System.Drawing.Color.Red;
            this.IssueNumberError.Location = new System.Drawing.Point(71, 132);
            this.IssueNumberError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IssueNumberError.Name = "IssueNumberError";
            this.IssueNumberError.Size = new System.Drawing.Size(214, 23);
            this.IssueNumberError.TabIndex = 12;
            this.IssueNumberError.Text = "Insert a valid number issue";
            this.IssueNumberError.Click += new System.EventHandler(this.IssueNumberError_Click);
            // 
            // priceText
            // 
            this.priceText.AutoSize = true;
            this.priceText.Font = new System.Drawing.Font("Nirmala UI", 14F);
            this.priceText.Location = new System.Drawing.Point(527, 113);
            this.priceText.Name = "priceText";
            this.priceText.Size = new System.Drawing.Size(131, 32);
            this.priceText.TabIndex = 13;
            this.priceText.Text = "Issue price:";
            // 
            // meterPrice
            // 
            this.meterPrice.AutoSize = true;
            this.meterPrice.Font = new System.Drawing.Font("Nirmala UI", 14F);
            this.meterPrice.Location = new System.Drawing.Point(653, 113);
            this.meterPrice.Name = "meterPrice";
            this.meterPrice.Size = new System.Drawing.Size(83, 32);
            this.meterPrice.TabIndex = 14;
            this.meterPrice.Text = "\"price\"";
            // 
            // ConsultarIssueNOReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 495);
            this.Controls.Add(this.meterPrice);
            this.Controls.Add(this.priceText);
            this.Controls.Add(this.IssueNumberError);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ListaPapers);
            this.Controls.Add(this.buscador);
            this.Controls.Add(this.buscadorBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
    }
}