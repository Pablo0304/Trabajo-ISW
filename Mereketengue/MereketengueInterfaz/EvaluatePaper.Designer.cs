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
            this.TextArea.Font = new System.Drawing.Font("Nirmala UI", 14F);
            this.TextArea.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TextArea.Location = new System.Drawing.Point(44, 43);
            this.TextArea.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TextArea.Name = "TextArea";
            this.TextArea.Size = new System.Drawing.Size(417, 25);
            this.TextArea.TabIndex = 0;
            this.TextArea.Text = "Select Area where you want to evaluate a paper:";
            // 
            // comboAreas
            // 
            this.comboAreas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboAreas.Font = new System.Drawing.Font("Nirmala UI", 10F);
            this.comboAreas.FormattingEnabled = true;
            this.comboAreas.Location = new System.Drawing.Point(47, 69);
            this.comboAreas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboAreas.MaxDropDownItems = 20;
            this.comboAreas.Name = "comboAreas";
            this.comboAreas.Size = new System.Drawing.Size(381, 25);
            this.comboAreas.TabIndex = 3;
            this.comboAreas.SelectedIndexChanged += new System.EventHandler(this.SelectAreas);
            // 
            // TextPapers
            // 
            this.TextPapers.AutoSize = true;
            this.TextPapers.Font = new System.Drawing.Font("Nirmala UI", 14F);
            this.TextPapers.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TextPapers.Location = new System.Drawing.Point(44, 120);
            this.TextPapers.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TextPapers.Name = "TextPapers";
            this.TextPapers.Size = new System.Drawing.Size(402, 25);
            this.TextPapers.TabIndex = 4;
            this.TextPapers.Text = "Papers in the selected area with no evaluation:";
            // 
            // listaPapers
            // 
            this.listaPapers.Font = new System.Drawing.Font("Nirmala UI", 10F);
            this.listaPapers.FormattingEnabled = true;
            this.listaPapers.ItemHeight = 17;
            this.listaPapers.Location = new System.Drawing.Point(47, 147);
            this.listaPapers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listaPapers.Name = "listaPapers";
            this.listaPapers.Size = new System.Drawing.Size(381, 174);
            this.listaPapers.TabIndex = 5;
            this.listaPapers.SelectedIndexChanged += new System.EventHandler(this.seleccionarPaper);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Nirmala UI", 10F);
            this.button1.Location = new System.Drawing.Point(608, 607);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 30);
            this.button1.TabIndex = 7;
            this.button1.Text = "Select";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.SelectEv1);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Nirmala UI", 10F);
            this.button2.Location = new System.Drawing.Point(512, 607);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 30);
            this.button2.TabIndex = 8;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.GoBackEv1);
            // 
            // TextComm
            // 
            this.TextComm.Font = new System.Drawing.Font("Nirmala UI", 10F);
            this.TextComm.Location = new System.Drawing.Point(47, 384);
            this.TextComm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TextComm.Multiline = true;
            this.TextComm.Name = "TextComm";
            this.TextComm.Size = new System.Drawing.Size(381, 102);
            this.TextComm.TabIndex = 9;
            this.TextComm.TextChanged += new System.EventHandler(this.ChangeCommTextBox);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 14F);
            this.label1.Location = new System.Drawing.Point(46, 358);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Commentary:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 14F);
            this.label2.Location = new System.Drawing.Point(46, 499);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Decision:";
            // 
            // decision
            // 
            this.decision.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.decision.FormattingEnabled = true;
            this.decision.Location = new System.Drawing.Point(136, 502);
            this.decision.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.decision.Name = "decision";
            this.decision.Size = new System.Drawing.Size(92, 21);
            this.decision.TabIndex = 12;
            this.decision.SelectedIndexChanged += new System.EventHandler(this.decision_SelectedIndexChanged);
            // 
            // Ev1Error
            // 
            this.Ev1Error.AutoSize = true;
            this.Ev1Error.Font = new System.Drawing.Font("Nirmala UI", 10F);
            this.Ev1Error.ForeColor = System.Drawing.Color.Red;
            this.Ev1Error.Location = new System.Drawing.Point(242, 508);
            this.Ev1Error.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Ev1Error.Name = "Ev1Error";
            this.Ev1Error.Size = new System.Drawing.Size(61, 19);
            this.Ev1Error.TabIndex = 16;
            this.Ev1Error.Text = "ErrorEv1";
            // 
            // EvaluatePaper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 644);
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