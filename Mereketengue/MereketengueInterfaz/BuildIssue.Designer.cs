namespace MereketengueInterfaz
{
    partial class BuildIssue
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.selectorArea = new System.Windows.Forms.ComboBox();
            this.listaPapers = new System.Windows.Forms.ListBox();
            this.busacarButton = new System.Windows.Forms.Button();
            this.magazineDBDataSet = new MereketengueInterfaz.MagazineDBDataSet();
            this.papersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.papersTableAdapter = new MereketengueInterfaz.MagazineDBDataSetTableAdapters.PapersTableAdapter();
            this.agregarPaper = new System.Windows.Forms.Button();
            this.selectedPapers = new System.Windows.Forms.ListBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.publicationDate = new System.Windows.Forms.Label();
            this.numberLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.magazineDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.papersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(941, 498);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 44);
            this.button1.TabIndex = 0;
            this.button1.Text = "Publicate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.publicateClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(820, 498);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 44);
            this.button2.TabIndex = 1;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 46);
            this.label1.TabIndex = 2;
            this.label1.Text = "Magazine";
            // 
            // selectorArea
            // 
            this.selectorArea.FormattingEnabled = true;
            this.selectorArea.Location = new System.Drawing.Point(20, 96);
            this.selectorArea.Name = "selectorArea";
            this.selectorArea.Size = new System.Drawing.Size(200, 24);
            this.selectorArea.TabIndex = 3;
            this.selectorArea.SelectedIndexChanged += new System.EventHandler(this.seleccionarArea);
            // 
            // listaPapers
            // 
            this.listaPapers.FormattingEnabled = true;
            this.listaPapers.ItemHeight = 16;
            this.listaPapers.Location = new System.Drawing.Point(20, 126);
            this.listaPapers.Name = "listaPapers";
            this.listaPapers.Size = new System.Drawing.Size(381, 340);
            this.listaPapers.TabIndex = 4;
            this.listaPapers.SelectedIndexChanged += new System.EventHandler(this.seleccionarPaper);
            // 
            // busacarButton
            // 
            this.busacarButton.Location = new System.Drawing.Point(246, 96);
            this.busacarButton.Name = "busacarButton";
            this.busacarButton.Size = new System.Drawing.Size(75, 23);
            this.busacarButton.TabIndex = 5;
            this.busacarButton.Text = "Buscar";
            this.busacarButton.UseVisualStyleBackColor = true;
            this.busacarButton.Click += new System.EventHandler(this.buscarClick);
            // 
            // magazineDBDataSet
            // 
            this.magazineDBDataSet.DataSetName = "MagazineDBDataSet";
            this.magazineDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // papersBindingSource
            // 
            this.papersBindingSource.DataMember = "Papers";
            this.papersBindingSource.DataSource = this.magazineDBDataSet;
            // 
            // papersTableAdapter
            // 
            this.papersTableAdapter.ClearBeforeFill = true;
            // 
            // agregarPaper
            // 
            this.agregarPaper.Location = new System.Drawing.Point(427, 257);
            this.agregarPaper.Name = "agregarPaper";
            this.agregarPaper.Size = new System.Drawing.Size(84, 58);
            this.agregarPaper.TabIndex = 6;
            this.agregarPaper.Text = "Agregar paper";
            this.agregarPaper.UseVisualStyleBackColor = true;
            this.agregarPaper.Click += new System.EventHandler(this.agregarPaperClick);
            // 
            // selectedPapers
            // 
            this.selectedPapers.FormattingEnabled = true;
            this.selectedPapers.ItemHeight = 16;
            this.selectedPapers.Location = new System.Drawing.Point(609, 122);
            this.selectedPapers.Name = "selectedPapers";
            this.selectedPapers.Size = new System.Drawing.Size(309, 340);
            this.selectedPapers.TabIndex = 7;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(718, 88);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker.TabIndex = 8;
            // 
            // publicationDate
            // 
            this.publicationDate.AutoSize = true;
            this.publicationDate.Location = new System.Drawing.Point(606, 94);
            this.publicationDate.Name = "publicationDate";
            this.publicationDate.Size = new System.Drawing.Size(106, 16);
            this.publicationDate.TabIndex = 9;
            this.publicationDate.Text = "Publication date:";
            // 
            // numberLabel
            // 
            this.numberLabel.AutoSize = true;
            this.numberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.numberLabel.Location = new System.Drawing.Point(210, 35);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(192, 46);
            this.numberLabel.TabIndex = 10;
            this.numberLabel.Text = "(numero):";
            // 
            // BuildIssue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.numberLabel);
            this.Controls.Add(this.publicationDate);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.selectedPapers);
            this.Controls.Add(this.agregarPaper);
            this.Controls.Add(this.busacarButton);
            this.Controls.Add(this.listaPapers);
            this.Controls.Add(this.selectorArea);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BuildIssue";
            this.Text = "Build Issue";
            this.Load += new System.EventHandler(this.BuildIssue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.magazineDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.papersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox selectorArea;
        private System.Windows.Forms.ListBox listaPapers;
        private System.Windows.Forms.Button busacarButton;
        private MagazineDBDataSet magazineDBDataSet;
        private System.Windows.Forms.BindingSource papersBindingSource;
        private MagazineDBDataSetTableAdapters.PapersTableAdapter papersTableAdapter;
        private System.Windows.Forms.Button agregarPaper;
        private System.Windows.Forms.ListBox selectedPapers;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label publicationDate;
        private System.Windows.Forms.Label numberLabel;
    }
}