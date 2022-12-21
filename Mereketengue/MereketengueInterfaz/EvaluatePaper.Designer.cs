namespace MereketengueInterfaz
{
    partial class EvaluatePaper
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
            this.TextArea = new System.Windows.Forms.Label();
            this.ErrorSelectedArea = new System.Windows.Forms.Label();
            this.comboAreas = new System.Windows.Forms.ComboBox();
            this.TextPapers = new System.Windows.Forms.Label();
            this.listaPapers = new System.Windows.Forms.ListBox();
            this.ErrorSelectedPaper = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TextArea
            // 
            this.TextArea.AutoSize = true;
            this.TextArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.TextArea.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TextArea.Location = new System.Drawing.Point(58, 53);
            this.TextArea.Name = "TextArea";
            this.TextArea.Size = new System.Drawing.Size(557, 29);
            this.TextArea.TabIndex = 0;
            this.TextArea.Text = "Select Area where you want to evaluate a paper:";
            // 
            // ErrorSelectedArea
            // 
            this.ErrorSelectedArea.AutoSize = true;
            this.ErrorSelectedArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ErrorSelectedArea.ForeColor = System.Drawing.Color.Red;
            this.ErrorSelectedArea.Location = new System.Drawing.Point(621, 61);
            this.ErrorSelectedArea.Name = "ErrorSelectedArea";
            this.ErrorSelectedArea.Size = new System.Drawing.Size(206, 20);
            this.ErrorSelectedArea.TabIndex = 2;
            this.ErrorSelectedArea.Text = "Error: Area is not selected";
            this.ErrorSelectedArea.Visible = false;
            // 
            // comboAreas
            // 
            this.comboAreas.FormattingEnabled = true;
            this.comboAreas.Location = new System.Drawing.Point(63, 85);
            this.comboAreas.Name = "comboAreas";
            this.comboAreas.Size = new System.Drawing.Size(507, 24);
            this.comboAreas.TabIndex = 3;
            this.comboAreas.SelectedIndexChanged += new System.EventHandler(this.ComboBoxAreas);
            // 
            // TextPapers
            // 
            this.TextPapers.AutoSize = true;
            this.TextPapers.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.TextPapers.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TextPapers.Location = new System.Drawing.Point(58, 148);
            this.TextPapers.Name = "TextPapers";
            this.TextPapers.Size = new System.Drawing.Size(538, 29);
            this.TextPapers.TabIndex = 4;
            this.TextPapers.Text = "Papers in the selected area with no evaluation:";
            // 
            // listaPapers
            // 
            this.listaPapers.FormattingEnabled = true;
            this.listaPapers.ItemHeight = 16;
            this.listaPapers.Location = new System.Drawing.Point(63, 181);
            this.listaPapers.Name = "listaPapers";
            this.listaPapers.Size = new System.Drawing.Size(507, 228);
            this.listaPapers.TabIndex = 5;
            this.listaPapers.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // ErrorSelectedPaper
            // 
            this.ErrorSelectedPaper.AutoSize = true;
            this.ErrorSelectedPaper.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ErrorSelectedPaper.ForeColor = System.Drawing.Color.Red;
            this.ErrorSelectedPaper.Location = new System.Drawing.Point(621, 156);
            this.ErrorSelectedPaper.Name = "ErrorSelectedPaper";
            this.ErrorSelectedPaper.Size = new System.Drawing.Size(215, 20);
            this.ErrorSelectedPaper.TabIndex = 6;
            this.ErrorSelectedPaper.Text = "Error: Paper is not selected";
            this.ErrorSelectedPaper.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(810, 747);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 37);
            this.button1.TabIndex = 7;
            this.button1.Text = "Select";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.SelectEv1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(682, 747);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 37);
            this.button2.TabIndex = 8;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.GoBackEv1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(63, 473);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(507, 125);
            this.textBox1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(61, 441);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 29);
            this.label1.TabIndex = 10;
            this.label1.Text = "Commentary:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(61, 614);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 29);
            this.label2.TabIndex = 11;
            this.label2.Text = "Decision:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(66, 646);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(504, 75);
            this.textBox2.TabIndex = 12;
            // 
            // EvaluatePaper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 792);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ErrorSelectedPaper);
            this.Controls.Add(this.listaPapers);
            this.Controls.Add(this.TextPapers);
            this.Controls.Add(this.comboAreas);
            this.Controls.Add(this.ErrorSelectedArea);
            this.Controls.Add(this.TextArea);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EvaluatePaper";
            this.Text = "Evaluate Paper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TextArea;
        private System.Windows.Forms.Label ErrorSelectedArea;
        private System.Windows.Forms.ComboBox comboAreas;
        private System.Windows.Forms.Label TextPapers;
        private System.Windows.Forms.ListBox listaPapers;
        private System.Windows.Forms.Label ErrorSelectedPaper;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
    }
}