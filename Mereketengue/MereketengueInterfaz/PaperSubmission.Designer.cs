namespace MereketengueInterfaz
{
    partial class PaperSubmission
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
            this.comboBoxAreas = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PaperTitlebox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonSend = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ButtonAddCoauthor = new System.Windows.Forms.Button();
            this.Selectedarea = new System.Windows.Forms.Label();
            this.errorId = new System.Windows.Forms.Label();
            this.ErrorName = new System.Windows.Forms.Label();
            this.ErrorSurname = new System.Windows.Forms.Label();
            this.ErrorlistCoauthor = new System.Windows.Forms.Label();
            this.ListCoauthors = new System.Windows.Forms.ListBox();
            this.labelCoauthor = new System.Windows.Forms.Label();
            this.Error4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select an area:";
            // 
            // comboBoxAreas
            // 
            this.comboBoxAreas.FormattingEnabled = true;
            this.comboBoxAreas.Location = new System.Drawing.Point(153, 13);
            this.comboBoxAreas.Name = "comboBoxAreas";
            this.comboBoxAreas.Size = new System.Drawing.Size(121, 21);
            this.comboBoxAreas.TabIndex = 3;
            this.comboBoxAreas.SelectedIndexChanged += new System.EventHandler(this.cambiarSelectArea);
            this.comboBoxAreas.Click += new System.EventHandler(this.LlenarAreas);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(13, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Insert the paper\'s title:";
            // 
            // PaperTitlebox
            // 
            this.PaperTitlebox.Location = new System.Drawing.Point(216, 70);
            this.PaperTitlebox.Name = "PaperTitlebox";
            this.PaperTitlebox.Size = new System.Drawing.Size(161, 20);
            this.PaperTitlebox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(727, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "_________________________________________________________________________________" +
    "_______________________________________";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label4.Location = new System.Drawing.Point(11, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 26);
            this.label4.TabIndex = 7;
            this.label4.Text = "(Optional)";
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(397, 68);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(67, 23);
            this.buttonSend.TabIndex = 8;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.Send);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label5.Location = new System.Drawing.Point(544, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(194, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "Added Coauthors\' List";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(16, 212);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(59, 20);
            this.textBoxID.TabIndex = 11;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(16, 266);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(97, 20);
            this.textBoxName.TabIndex = 12;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(17, 331);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(126, 20);
            this.textBoxSurname.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 250);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 315);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Surname";
            // 
            // ButtonAddCoauthor
            // 
            this.ButtonAddCoauthor.Location = new System.Drawing.Point(426, 198);
            this.ButtonAddCoauthor.Name = "ButtonAddCoauthor";
            this.ButtonAddCoauthor.Size = new System.Drawing.Size(86, 34);
            this.ButtonAddCoauthor.TabIndex = 17;
            this.ButtonAddCoauthor.Text = "Add Coauthor";
            this.ButtonAddCoauthor.UseVisualStyleBackColor = true;
            this.ButtonAddCoauthor.Click += new System.EventHandler(this.AddCoauthor);
            // 
            // Selectedarea
            // 
            this.Selectedarea.AutoSize = true;
            this.Selectedarea.Location = new System.Drawing.Point(290, 16);
            this.Selectedarea.Name = "Selectedarea";
            this.Selectedarea.Size = new System.Drawing.Size(74, 13);
            this.Selectedarea.TabIndex = 19;
            this.Selectedarea.Text = "Selected Area";
            // 
            // errorId
            // 
            this.errorId.AutoSize = true;
            this.errorId.Location = new System.Drawing.Point(96, 212);
            this.errorId.Name = "errorId";
            this.errorId.Size = new System.Drawing.Size(0, 13);
            this.errorId.TabIndex = 20;
            // 
            // ErrorName
            // 
            this.ErrorName.AutoSize = true;
            this.ErrorName.Location = new System.Drawing.Point(128, 266);
            this.ErrorName.Name = "ErrorName";
            this.ErrorName.Size = new System.Drawing.Size(0, 13);
            this.ErrorName.TabIndex = 21;
            // 
            // ErrorSurname
            // 
            this.ErrorSurname.AutoSize = true;
            this.ErrorSurname.Location = new System.Drawing.Point(150, 331);
            this.ErrorSurname.Name = "ErrorSurname";
            this.ErrorSurname.Size = new System.Drawing.Size(0, 13);
            this.ErrorSurname.TabIndex = 22;
            // 
            // ErrorlistCoauthor
            // 
            this.ErrorlistCoauthor.AutoSize = true;
            this.ErrorlistCoauthor.Location = new System.Drawing.Point(548, 385);
            this.ErrorlistCoauthor.Name = "ErrorlistCoauthor";
            this.ErrorlistCoauthor.Size = new System.Drawing.Size(0, 13);
            this.ErrorlistCoauthor.TabIndex = 23;
            // 
            // ListCoauthors
            // 
            this.ListCoauthors.FormattingEnabled = true;
            this.ListCoauthors.Location = new System.Drawing.Point(551, 189);
            this.ListCoauthors.Name = "ListCoauthors";
            this.ListCoauthors.Size = new System.Drawing.Size(187, 186);
            this.ListCoauthors.TabIndex = 24;
            // 
            // labelCoauthor
            // 
            this.labelCoauthor.AutoSize = true;
            this.labelCoauthor.Location = new System.Drawing.Point(555, 384);
            this.labelCoauthor.Name = "labelCoauthor";
            this.labelCoauthor.Size = new System.Drawing.Size(0, 13);
            this.labelCoauthor.TabIndex = 25;
            // 
            // Error4
            // 
            this.Error4.AutoSize = true;
            this.Error4.Location = new System.Drawing.Point(555, 385);
            this.Error4.Name = "Error4";
            this.Error4.Size = new System.Drawing.Size(0, 13);
            this.Error4.TabIndex = 26;
            // 
            // PaperSubmission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Error4);
            this.Controls.Add(this.labelCoauthor);
            this.Controls.Add(this.ListCoauthors);
            this.Controls.Add(this.ErrorlistCoauthor);
            this.Controls.Add(this.ErrorSurname);
            this.Controls.Add(this.ErrorName);
            this.Controls.Add(this.errorId);
            this.Controls.Add(this.Selectedarea);
            this.Controls.Add(this.ButtonAddCoauthor);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PaperTitlebox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxAreas);
            this.Controls.Add(this.label1);
            this.Name = "PaperSubmission";
            this.Text = "PaperSubmission";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxAreas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PaperTitlebox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button ButtonAddCoauthor;
        private System.Windows.Forms.Label Selectedarea;
        private System.Windows.Forms.Label errorId;
        private System.Windows.Forms.Label ErrorName;
        private System.Windows.Forms.Label ErrorSurname;
        private System.Windows.Forms.Label ErrorlistCoauthor;
        private System.Windows.Forms.ListBox ListCoauthors;
        private System.Windows.Forms.Label labelCoauthor;
        private System.Windows.Forms.Label Error4;
    }
}