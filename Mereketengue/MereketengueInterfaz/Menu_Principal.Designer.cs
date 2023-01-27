using System;
using System.Reflection;

namespace MereketengueInterfaz
{
    partial class Menu_Principal
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
            this.ButtonPaperSubmission = new System.Windows.Forms.Button();
            this.buttonListPapers = new System.Windows.Forms.Button();
            this.buttonEvPaper = new System.Windows.Forms.Button();
            this.buttonBuilsIssue = new System.Windows.Forms.Button();
            this.BuyIssueButton = new System.Windows.Forms.Button();
            this.MyPapersButon = new System.Windows.Forms.Button();
            this.CreateAreaButton = new System.Windows.Forms.Button();
            this.EditProfileButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonPaperSubmission
            // 
            this.ButtonPaperSubmission.BackColor = System.Drawing.Color.Lavender;
            this.ButtonPaperSubmission.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonPaperSubmission.FlatAppearance.BorderSize = 0;
            this.ButtonPaperSubmission.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonPaperSubmission.Font = new System.Drawing.Font("Nirmala UI", 20F);
            this.ButtonPaperSubmission.ForeColor = System.Drawing.Color.Black;
            this.ButtonPaperSubmission.Location = new System.Drawing.Point(20, 20);
            this.ButtonPaperSubmission.Margin = new System.Windows.Forms.Padding(10);
            this.ButtonPaperSubmission.Name = "ButtonPaperSubmission";
            this.ButtonPaperSubmission.Size = new System.Drawing.Size(253, 197);
            this.ButtonPaperSubmission.TabIndex = 0;
            this.ButtonPaperSubmission.Text = "Paper Submission";
            this.ButtonPaperSubmission.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonPaperSubmission.UseVisualStyleBackColor = false;
            this.ButtonPaperSubmission.Click += new System.EventHandler(this.ButtonPaperSubmission_Click);
            this.ButtonPaperSubmission.MouseEnter += new System.EventHandler(this.animationEnterPaperSubmission);
            this.ButtonPaperSubmission.MouseLeave += new System.EventHandler(this.animationLeavePaperSubmission);
            // 
            // buttonListPapers
            // 
            this.buttonListPapers.BackColor = System.Drawing.Color.Lavender;
            this.buttonListPapers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonListPapers.FlatAppearance.BorderSize = 0;
            this.buttonListPapers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonListPapers.Font = new System.Drawing.Font("Nirmala UI", 20F);
            this.buttonListPapers.Location = new System.Drawing.Point(293, 20);
            this.buttonListPapers.Margin = new System.Windows.Forms.Padding(10);
            this.buttonListPapers.Name = "buttonListPapers";
            this.buttonListPapers.Size = new System.Drawing.Size(253, 197);
            this.buttonListPapers.TabIndex = 1;
            this.buttonListPapers.Text = "List Papers";
            this.buttonListPapers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonListPapers.UseVisualStyleBackColor = false;
            this.buttonListPapers.Click += new System.EventHandler(this.buttonListPapers_Click);
            this.buttonListPapers.MouseEnter += new System.EventHandler(this.AnimacionEnterListPapers);
            this.buttonListPapers.MouseLeave += new System.EventHandler(this.AnimacionLeaveListPapers);
            // 
            // buttonEvPaper
            // 
            this.buttonEvPaper.BackColor = System.Drawing.Color.Lavender;
            this.buttonEvPaper.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEvPaper.FlatAppearance.BorderSize = 0;
            this.buttonEvPaper.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEvPaper.Font = new System.Drawing.Font("Nirmala UI", 20F);
            this.buttonEvPaper.Location = new System.Drawing.Point(566, 20);
            this.buttonEvPaper.Margin = new System.Windows.Forms.Padding(10);
            this.buttonEvPaper.Name = "buttonEvPaper";
            this.buttonEvPaper.Size = new System.Drawing.Size(253, 197);
            this.buttonEvPaper.TabIndex = 2;
            this.buttonEvPaper.Text = "Evaluate Paper";
            this.buttonEvPaper.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonEvPaper.UseVisualStyleBackColor = false;
            this.buttonEvPaper.Click += new System.EventHandler(this.buttonEvPaper_Click);
            this.buttonEvPaper.MouseEnter += new System.EventHandler(this.AnimacionEnterEvaluatePaper);
            this.buttonEvPaper.MouseLeave += new System.EventHandler(this.AnimacionLeaveEvaluatePaper);
            // 
            // buttonBuilsIssue
            // 
            this.buttonBuilsIssue.BackColor = System.Drawing.Color.Lavender;
            this.buttonBuilsIssue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBuilsIssue.FlatAppearance.BorderSize = 0;
            this.buttonBuilsIssue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuilsIssue.Font = new System.Drawing.Font("Nirmala UI", 20F);
            this.buttonBuilsIssue.Location = new System.Drawing.Point(839, 20);
            this.buttonBuilsIssue.Margin = new System.Windows.Forms.Padding(10);
            this.buttonBuilsIssue.Name = "buttonBuilsIssue";
            this.buttonBuilsIssue.Size = new System.Drawing.Size(253, 197);
            this.buttonBuilsIssue.TabIndex = 3;
            this.buttonBuilsIssue.Text = "Build Issue";
            this.buttonBuilsIssue.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonBuilsIssue.UseVisualStyleBackColor = false;
            this.buttonBuilsIssue.Click += new System.EventHandler(this.buttonBuilsIssue_Click);
            this.buttonBuilsIssue.MouseEnter += new System.EventHandler(this.AnimacionEnterBuildIssue);
            this.buttonBuilsIssue.MouseLeave += new System.EventHandler(this.AnimacionLeaveBuidIssue);
            // 
            // BuyIssueButton
            // 
            this.BuyIssueButton.BackColor = System.Drawing.Color.Lavender;
            this.BuyIssueButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BuyIssueButton.FlatAppearance.BorderSize = 0;
            this.BuyIssueButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BuyIssueButton.Font = new System.Drawing.Font("Nirmala UI", 20F);
            this.BuyIssueButton.Location = new System.Drawing.Point(20, 237);
            this.BuyIssueButton.Margin = new System.Windows.Forms.Padding(10);
            this.BuyIssueButton.Name = "BuyIssueButton";
            this.BuyIssueButton.Size = new System.Drawing.Size(253, 197);
            this.BuyIssueButton.TabIndex = 4;
            this.BuyIssueButton.Text = "Buy Issue";
            this.BuyIssueButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BuyIssueButton.UseVisualStyleBackColor = false;
            this.BuyIssueButton.Click += new System.EventHandler(this.BuyIssue_Click);
            this.BuyIssueButton.MouseEnter += new System.EventHandler(this.animacionEnterBuyIssue);
            this.BuyIssueButton.MouseLeave += new System.EventHandler(this.animacionLeaveBuyIssue);
            // 
            // MyPapersButon
            // 
            this.MyPapersButon.BackColor = System.Drawing.Color.Lavender;
            this.MyPapersButon.Cursor = System.Windows.Forms.Cursors.No;
            this.MyPapersButon.FlatAppearance.BorderSize = 0;
            this.MyPapersButon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MyPapersButon.Font = new System.Drawing.Font("Nirmala UI", 20F);
            this.MyPapersButon.Location = new System.Drawing.Point(293, 237);
            this.MyPapersButon.Margin = new System.Windows.Forms.Padding(10);
            this.MyPapersButon.Name = "MyPapersButon";
            this.MyPapersButon.Size = new System.Drawing.Size(253, 197);
            this.MyPapersButon.TabIndex = 5;
            this.MyPapersButon.Text = "My Papers";
            this.MyPapersButon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.MyPapersButon.UseVisualStyleBackColor = false;
            this.MyPapersButon.Click += new System.EventHandler(this.button6_Click);
            // 
            // CreateAreaButton
            // 
            this.CreateAreaButton.BackColor = System.Drawing.Color.Lavender;
            this.CreateAreaButton.Cursor = System.Windows.Forms.Cursors.No;
            this.CreateAreaButton.FlatAppearance.BorderSize = 0;
            this.CreateAreaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateAreaButton.Font = new System.Drawing.Font("Nirmala UI", 20F);
            this.CreateAreaButton.Location = new System.Drawing.Point(566, 237);
            this.CreateAreaButton.Margin = new System.Windows.Forms.Padding(10);
            this.CreateAreaButton.Name = "CreateAreaButton";
            this.CreateAreaButton.Size = new System.Drawing.Size(253, 197);
            this.CreateAreaButton.TabIndex = 6;
            this.CreateAreaButton.Text = "Create Area";
            this.CreateAreaButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CreateAreaButton.UseVisualStyleBackColor = false;
            this.CreateAreaButton.Click += new System.EventHandler(this.button7_Click);
            // 
            // EditProfileButton
            // 
            this.EditProfileButton.BackColor = System.Drawing.Color.Lavender;
            this.EditProfileButton.Cursor = System.Windows.Forms.Cursors.No;
            this.EditProfileButton.FlatAppearance.BorderSize = 0;
            this.EditProfileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditProfileButton.Font = new System.Drawing.Font("Nirmala UI", 20F);
            this.EditProfileButton.Location = new System.Drawing.Point(839, 237);
            this.EditProfileButton.Margin = new System.Windows.Forms.Padding(10);
            this.EditProfileButton.Name = "EditProfileButton";
            this.EditProfileButton.Size = new System.Drawing.Size(253, 197);
            this.EditProfileButton.TabIndex = 7;
            this.EditProfileButton.Text = "Edit Profile";
            this.EditProfileButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.EditProfileButton.UseVisualStyleBackColor = false;
            this.EditProfileButton.Click += new System.EventHandler(this.button8_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.ButtonPaperSubmission);
            this.flowLayoutPanel1.Controls.Add(this.buttonListPapers);
            this.flowLayoutPanel1.Controls.Add(this.buttonEvPaper);
            this.flowLayoutPanel1.Controls.Add(this.buttonBuilsIssue);
            this.flowLayoutPanel1.Controls.Add(this.BuyIssueButton);
            this.flowLayoutPanel1.Controls.Add(this.MyPapersButon);
            this.flowLayoutPanel1.Controls.Add(this.CreateAreaButton);
            this.flowLayoutPanel1.Controls.Add(this.EditProfileButton);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(25, 10);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1117, 632);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // Menu_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1161, 663);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Menu_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu_Principal";
            this.Load += new System.EventHandler(this.Menu_Principal_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonListPapers;
        private System.Windows.Forms.Button buttonEvPaper;
        private System.Windows.Forms.Button buttonBuilsIssue;
        private System.Windows.Forms.Button BuyIssueButton;
        private System.Windows.Forms.Button MyPapersButon;
        private System.Windows.Forms.Button CreateAreaButton;
        private System.Windows.Forms.Button EditProfileButton;
        private System.Windows.Forms.Button ButtonPaperSubmission;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}