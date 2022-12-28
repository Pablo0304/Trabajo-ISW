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
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
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
            this.ButtonPaperSubmission.Location = new System.Drawing.Point(3, 3);
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
            this.buttonListPapers.Location = new System.Drawing.Point(301, 3);
            this.buttonListPapers.Name = "buttonListPapers";
            this.buttonListPapers.Size = new System.Drawing.Size(243, 197);
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
            this.buttonEvPaper.Location = new System.Drawing.Point(870, 3);
            this.buttonEvPaper.Name = "buttonEvPaper";
            this.buttonEvPaper.Size = new System.Drawing.Size(242, 197);
            this.buttonEvPaper.TabIndex = 2;
            this.buttonEvPaper.Text = "Evaluate Paper";
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
            this.buttonBuilsIssue.Location = new System.Drawing.Point(585, 3);
            this.buttonBuilsIssue.Name = "buttonBuilsIssue";
            this.buttonBuilsIssue.Size = new System.Drawing.Size(243, 197);
            this.buttonBuilsIssue.TabIndex = 3;
            this.buttonBuilsIssue.Text = "Build Issue";
            this.buttonBuilsIssue.UseVisualStyleBackColor = false;
            this.buttonBuilsIssue.Click += new System.EventHandler(this.buttonBuilsIssue_Click);
            this.buttonBuilsIssue.MouseEnter += new System.EventHandler(this.AnimacionEnterBuildIssue);
            this.buttonBuilsIssue.MouseLeave += new System.EventHandler(this.AnimacionLeaveBuidIssue);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Lavender;
            this.button5.Cursor = System.Windows.Forms.Cursors.No;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Nirmala UI", 20F);
            this.button5.Location = new System.Drawing.Point(3, 206);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(253, 197);
            this.button5.TabIndex = 4;
            this.button5.Text = "Edit Paper";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Lavender;
            this.button6.Cursor = System.Windows.Forms.Cursors.No;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Nirmala UI", 20F);
            this.button6.Location = new System.Drawing.Point(301, 206);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(243, 197);
            this.button6.TabIndex = 5;
            this.button6.Text = "My Papers";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Lavender;
            this.button7.Cursor = System.Windows.Forms.Cursors.No;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Nirmala UI", 20F);
            this.button7.Location = new System.Drawing.Point(585, 206);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(243, 197);
            this.button7.TabIndex = 6;
            this.button7.Text = "Create Area";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Lavender;
            this.button8.Cursor = System.Windows.Forms.Cursors.No;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Nirmala UI", 20F);
            this.button8.Location = new System.Drawing.Point(870, 206);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(243, 197);
            this.button8.TabIndex = 7;
            this.button8.Text = "Edit Profile";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.47826F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.42315F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.48201F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.7446F));
            this.tableLayoutPanel1.Controls.Add(this.button7, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.button8, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonBuilsIssue, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.button6, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonEvPaper, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.button5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.ButtonPaperSubmission, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonListPapers, 1, 0);
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 12);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1271, 406);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // Menu_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 775);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Menu_Principal";
            this.Text = "Menu_Principal";
            this.Load += new System.EventHandler(this.Menu_Principal_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonPaperSubmission;
        private System.Windows.Forms.Button buttonListPapers;
        private System.Windows.Forms.Button buttonEvPaper;
        private System.Windows.Forms.Button buttonBuilsIssue;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}