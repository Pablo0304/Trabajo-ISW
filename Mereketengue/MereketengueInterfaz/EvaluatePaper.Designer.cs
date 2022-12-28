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
            this.comboAreas = new System.Windows.Forms.ComboBox();
            this.TextPapers = new System.Windows.Forms.Label();
            this.listaPapers = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.TextComm = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.decision = new System.Windows.Forms.ComboBox();
            this.Ev1Error = new System.Windows.Forms.Label();
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
            // comboAreas
            // 
            this.comboAreas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboAreas.FormattingEnabled = true;
            this.comboAreas.Location = new System.Drawing.Point(63, 85);
            this.comboAreas.MaxDropDownItems = 20;
            this.comboAreas.Name = "comboAreas";
            this.comboAreas.Size = new System.Drawing.Size(507, 24);
            this.comboAreas.TabIndex = 3;
            this.comboAreas.SelectedIndexChanged += new System.EventHandler(this.SelectAreas);
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
            this.listaPapers.SelectedIndexChanged += new System.EventHandler(this.seleccionarPaper);
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
            // TextComm
            // 
            this.TextComm.Location = new System.Drawing.Point(63, 473);
            this.TextComm.Multiline = true;
            this.TextComm.Name = "TextComm";
            this.TextComm.Size = new System.Drawing.Size(507, 125);
            this.TextComm.TabIndex = 9;
            this.TextComm.TextChanged += new System.EventHandler(this.ChangeCommTextBox);
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
            // decision
            // 
            this.decision.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.decision.FormattingEnabled = true;
            this.decision.Location = new System.Drawing.Point(181, 618);
            this.decision.Name = "decision";
            this.decision.Size = new System.Drawing.Size(121, 24);
            this.decision.TabIndex = 12;
            this.decision.SelectedIndexChanged += new System.EventHandler(this.decision_SelectedIndexChanged);
            // 
            // Ev1Error
            // 
            this.Ev1Error.AutoSize = true;
            this.Ev1Error.ForeColor = System.Drawing.Color.Red;
            this.Ev1Error.Location = new System.Drawing.Point(322, 625);
            this.Ev1Error.Name = "Ev1Error";
            this.Ev1Error.Size = new System.Drawing.Size(59, 16);
            this.Ev1Error.TabIndex = 16;
            this.Ev1Error.Text = "ErrorEv1";
            // 
            // EvaluatePaper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 792);
            this.Controls.Add(this.Ev1Error);
            this.Controls.Add(this.decision);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextComm);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listaPapers);
            this.Controls.Add(this.TextPapers);
            this.Controls.Add(this.comboAreas);
            this.Controls.Add(this.TextArea);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EvaluatePaper";
            this.Text = "Evaluate Paper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TextArea;
        private System.Windows.Forms.ComboBox comboAreas;
        private System.Windows.Forms.Label TextPapers;
        private System.Windows.Forms.ListBox listaPapers;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox TextComm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox decision;
        private System.Windows.Forms.Label Ev1Error;
    }
}