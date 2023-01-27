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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuildIssue));
            this.ButtonAccept = new System.Windows.Forms.Button();
            this.selectorAreaCombo = new System.Windows.Forms.ComboBox();
            this.listaPapers = new System.Windows.Forms.ListBox();
            this.busacarButton = new System.Windows.Forms.Button();
            this.magazineDBDataSet = new MereketengueInterfaz.MagazineDBDataSet();
            this.papersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.papersTableAdapter = new MereketengueInterfaz.MagazineDBDataSetTableAdapters.PapersTableAdapter();
            this.agregarPaper = new System.Windows.Forms.Button();
            this.selectedPapers = new System.Windows.Forms.ListBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.publicationDate = new System.Windows.Forms.Label();
            this.ErrorArea = new System.Windows.Forms.Label();
            this.ErrorAgregar = new System.Windows.Forms.Label();
            this.ErrorCrear = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxnumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxdiscount = new System.Windows.Forms.TextBox();
            this.textBoxprice = new System.Windows.Forms.TextBox();
            this.TextoOpcionNueva = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.Button();
            this.ErrorNumber = new System.Windows.Forms.Label();
            this.ErrorDiscount = new System.Windows.Forms.Label();
            this.ErrorPrice = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.o = new System.Windows.Forms.Label();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.selectorIssueComboTextoOpcionEditar = new System.Windows.Forms.ComboBox();
            this.paneltapamelotodo = new System.Windows.Forms.Panel();
            this.errordate = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.magazineDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.papersBindingSource)).BeginInit();
            this.panelInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonAccept
            // 
            this.ButtonAccept.BackColor = System.Drawing.Color.Transparent;
            this.ButtonAccept.Font = new System.Drawing.Font("Nirmala UI", 10F);
            this.ButtonAccept.Location = new System.Drawing.Point(883, 595);
            this.ButtonAccept.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonAccept.Name = "ButtonAccept";
            this.ButtonAccept.Size = new System.Drawing.Size(93, 36);
            this.ButtonAccept.TabIndex = 0;
            this.ButtonAccept.Text = "Accept";
            this.ButtonAccept.UseVisualStyleBackColor = false;
            this.ButtonAccept.Click += new System.EventHandler(this.AcceptClick);
            // 
            // selectorAreaCombo
            // 
            this.selectorAreaCombo.Font = new System.Drawing.Font("Nirmala UI", 10F);
            this.selectorAreaCombo.FormattingEnabled = true;
            this.selectorAreaCombo.Location = new System.Drawing.Point(162, 192);
            this.selectorAreaCombo.Margin = new System.Windows.Forms.Padding(2);
            this.selectorAreaCombo.Name = "selectorAreaCombo";
            this.selectorAreaCombo.Size = new System.Drawing.Size(180, 25);
            this.selectorAreaCombo.TabIndex = 3;
            this.selectorAreaCombo.SelectedIndexChanged += new System.EventHandler(this.seleccionarArea);
            this.selectorAreaCombo.Click += new System.EventHandler(this.cargarAreasCombo);
            // 
            // listaPapers
            // 
            this.listaPapers.Font = new System.Drawing.Font("Nirmala UI", 10F);
            this.listaPapers.FormattingEnabled = true;
            this.listaPapers.ItemHeight = 17;
            this.listaPapers.Location = new System.Drawing.Point(23, 261);
            this.listaPapers.Margin = new System.Windows.Forms.Padding(2);
            this.listaPapers.Name = "listaPapers";
            this.listaPapers.Size = new System.Drawing.Size(176, 276);
            this.listaPapers.TabIndex = 4;
            this.listaPapers.SelectedIndexChanged += new System.EventHandler(this.seleccionarPaper);
            // 
            // busacarButton
            // 
            this.busacarButton.Font = new System.Drawing.Font("Nirmala UI", 10F);
            this.busacarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.busacarButton.Location = new System.Drawing.Point(380, 186);
            this.busacarButton.Margin = new System.Windows.Forms.Padding(2);
            this.busacarButton.Name = "busacarButton";
            this.busacarButton.Size = new System.Drawing.Size(111, 51);
            this.busacarButton.TabIndex = 5;
            this.busacarButton.Text = "Search";
            this.busacarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
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
            this.agregarPaper.Font = new System.Drawing.Font("Nirmala UI", 10F);
            this.agregarPaper.Location = new System.Drawing.Point(203, 355);
            this.agregarPaper.Margin = new System.Windows.Forms.Padding(2);
            this.agregarPaper.Name = "agregarPaper";
            this.agregarPaper.Size = new System.Drawing.Size(108, 77);
            this.agregarPaper.TabIndex = 6;
            this.agregarPaper.Text = "Add paper";
            this.agregarPaper.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.agregarPaper.UseVisualStyleBackColor = true;
            this.agregarPaper.Click += new System.EventHandler(this.agregarPaperClick);
            // 
            // selectedPapers
            // 
            this.selectedPapers.Font = new System.Drawing.Font("Nirmala UI", 10F);
            this.selectedPapers.FormattingEnabled = true;
            this.selectedPapers.ItemHeight = 17;
            this.selectedPapers.Location = new System.Drawing.Point(315, 261);
            this.selectedPapers.Margin = new System.Windows.Forms.Padding(2);
            this.selectedPapers.Name = "selectedPapers";
            this.selectedPapers.Size = new System.Drawing.Size(176, 276);
            this.selectedPapers.TabIndex = 7;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.dateTimePicker.Location = new System.Drawing.Point(549, 236);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(300, 29);
            this.dateTimePicker.TabIndex = 8;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.cambiarfecha);
            // 
            // publicationDate
            // 
            this.publicationDate.AutoSize = true;
            this.publicationDate.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.publicationDate.Location = new System.Drawing.Point(546, 210);
            this.publicationDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.publicationDate.Name = "publicationDate";
            this.publicationDate.Size = new System.Drawing.Size(124, 21);
            this.publicationDate.TabIndex = 9;
            this.publicationDate.Text = "Publication date:";
            // 
            // ErrorArea
            // 
            this.ErrorArea.AutoSize = true;
            this.ErrorArea.Font = new System.Drawing.Font("Nirmala UI", 10F);
            this.ErrorArea.ForeColor = System.Drawing.Color.Red;
            this.ErrorArea.Location = new System.Drawing.Point(19, 222);
            this.ErrorArea.Name = "ErrorArea";
            this.ErrorArea.Size = new System.Drawing.Size(45, 19);
            this.ErrorArea.TabIndex = 11;
            this.ErrorArea.Text = "label2";
            // 
            // ErrorAgregar
            // 
            this.ErrorAgregar.AutoSize = true;
            this.ErrorAgregar.Font = new System.Drawing.Font("Nirmala UI", 10F);
            this.ErrorAgregar.ForeColor = System.Drawing.Color.Red;
            this.ErrorAgregar.Location = new System.Drawing.Point(19, 554);
            this.ErrorAgregar.Name = "ErrorAgregar";
            this.ErrorAgregar.Size = new System.Drawing.Size(45, 19);
            this.ErrorAgregar.TabIndex = 12;
            this.ErrorAgregar.Text = "label2";
            // 
            // ErrorCrear
            // 
            this.ErrorCrear.AutoSize = true;
            this.ErrorCrear.Font = new System.Drawing.Font("Nirmala UI", 10F);
            this.ErrorCrear.ForeColor = System.Drawing.Color.Red;
            this.ErrorCrear.Location = new System.Drawing.Point(523, 554);
            this.ErrorCrear.Name = "ErrorCrear";
            this.ErrorCrear.Size = new System.Drawing.Size(45, 19);
            this.ErrorCrear.TabIndex = 14;
            this.ErrorCrear.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 15F);
            this.label1.Location = new System.Drawing.Point(16, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 28);
            this.label1.TabIndex = 15;
            this.label1.Text = "Select an area";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.label2.Location = new System.Drawing.Point(546, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 21);
            this.label2.TabIndex = 16;
            this.label2.Text = "Number";
            // 
            // textBoxnumber
            // 
            this.textBoxnumber.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.textBoxnumber.Location = new System.Drawing.Point(550, 309);
            this.textBoxnumber.Name = "textBoxnumber";
            this.textBoxnumber.Size = new System.Drawing.Size(73, 29);
            this.textBoxnumber.TabIndex = 17;
            this.textBoxnumber.TextChanged += new System.EventHandler(this.cambiarnumber);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.label3.Location = new System.Drawing.Point(546, 368);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 21);
            this.label3.TabIndex = 18;
            this.label3.Text = "Discount";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.label4.Location = new System.Drawing.Point(546, 445);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 21);
            this.label4.TabIndex = 19;
            this.label4.Text = "Price";
            // 
            // textBoxdiscount
            // 
            this.textBoxdiscount.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.textBoxdiscount.Location = new System.Drawing.Point(550, 392);
            this.textBoxdiscount.Name = "textBoxdiscount";
            this.textBoxdiscount.Size = new System.Drawing.Size(73, 29);
            this.textBoxdiscount.TabIndex = 20;
            this.textBoxdiscount.TextChanged += new System.EventHandler(this.cambiardiscount);
            // 
            // textBoxprice
            // 
            this.textBoxprice.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.textBoxprice.Location = new System.Drawing.Point(550, 465);
            this.textBoxprice.Name = "textBoxprice";
            this.textBoxprice.Size = new System.Drawing.Size(73, 29);
            this.textBoxprice.TabIndex = 21;
            this.textBoxprice.TextChanged += new System.EventHandler(this.cambiarprice);
            // 
            // TextoOpcionNueva
            // 
            this.TextoOpcionNueva.AutoSize = true;
            this.TextoOpcionNueva.BackColor = System.Drawing.Color.Lavender;
            this.TextoOpcionNueva.Font = new System.Drawing.Font("Nirmala UI", 20F);
            this.TextoOpcionNueva.ForeColor = System.Drawing.Color.Black;
            this.TextoOpcionNueva.Location = new System.Drawing.Point(543, 48);
            this.TextoOpcionNueva.Name = "TextoOpcionNueva";
            this.TextoOpcionNueva.Size = new System.Drawing.Size(383, 37);
            this.TextoOpcionNueva.TabIndex = 22;
            this.TextoOpcionNueva.Text = "Insert data to create a new one";
            this.TextoOpcionNueva.Click += new System.EventHandler(this.clickNueva);
            this.TextoOpcionNueva.MouseEnter += new System.EventHandler(this.enterpanelnueva);
            this.TextoOpcionNueva.MouseLeave += new System.EventHandler(this.leavepanelnueva);
            // 
            // Back
            // 
            this.Back.Font = new System.Drawing.Font("Nirmala UI", 10F);
            this.Back.Location = new System.Drawing.Point(11, 595);
            this.Back.Margin = new System.Windows.Forms.Padding(2);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(93, 36);
            this.Back.TabIndex = 23;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // ErrorNumber
            // 
            this.ErrorNumber.AutoSize = true;
            this.ErrorNumber.BackColor = System.Drawing.Color.Transparent;
            this.ErrorNumber.Font = new System.Drawing.Font("Nirmala UI", 10F);
            this.ErrorNumber.ForeColor = System.Drawing.Color.Red;
            this.ErrorNumber.Location = new System.Drawing.Point(127, 127);
            this.ErrorNumber.Name = "ErrorNumber";
            this.ErrorNumber.Size = new System.Drawing.Size(45, 19);
            this.ErrorNumber.TabIndex = 24;
            this.ErrorNumber.Text = "label2";
            // 
            // ErrorDiscount
            // 
            this.ErrorDiscount.AutoSize = true;
            this.ErrorDiscount.BackColor = System.Drawing.Color.Transparent;
            this.ErrorDiscount.Font = new System.Drawing.Font("Nirmala UI", 10F);
            this.ErrorDiscount.ForeColor = System.Drawing.Color.Red;
            this.ErrorDiscount.Location = new System.Drawing.Point(127, 210);
            this.ErrorDiscount.Name = "ErrorDiscount";
            this.ErrorDiscount.Size = new System.Drawing.Size(45, 19);
            this.ErrorDiscount.TabIndex = 25;
            this.ErrorDiscount.Text = "label2";
            // 
            // ErrorPrice
            // 
            this.ErrorPrice.AutoSize = true;
            this.ErrorPrice.BackColor = System.Drawing.Color.Transparent;
            this.ErrorPrice.Font = new System.Drawing.Font("Nirmala UI", 10F);
            this.ErrorPrice.ForeColor = System.Drawing.Color.Red;
            this.ErrorPrice.Location = new System.Drawing.Point(127, 283);
            this.ErrorPrice.Name = "ErrorPrice";
            this.ErrorPrice.Size = new System.Drawing.Size(45, 19);
            this.ErrorPrice.TabIndex = 26;
            this.ErrorPrice.Text = "label2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(964, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = resources.GetString("label7.Text");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 20F);
            this.label5.Location = new System.Drawing.Point(16, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(360, 37);
            this.label5.TabIndex = 29;
            this.label5.Text = "Creating the Issue\'s paper list";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 20F);
            this.label6.Location = new System.Drawing.Point(520, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(262, 37);
            this.label6.TabIndex = 32;
            this.label6.Text = "Issue\'s aditional data";
            // 
            // o
            // 
            this.o.AutoSize = true;
            this.o.Font = new System.Drawing.Font("Nirmala UI", 20F);
            this.o.Location = new System.Drawing.Point(449, 53);
            this.o.Name = "o";
            this.o.Size = new System.Drawing.Size(42, 37);
            this.o.TabIndex = 33;
            this.o.Text = "or";
            // 
            // panelInfo
            // 
            this.panelInfo.BackColor = System.Drawing.Color.White;
            this.panelInfo.Controls.Add(this.label9);
            this.panelInfo.Controls.Add(this.label8);
            this.panelInfo.Controls.Add(this.errordate);
            this.panelInfo.Controls.Add(this.ErrorNumber);
            this.panelInfo.Controls.Add(this.ErrorDiscount);
            this.panelInfo.Controls.Add(this.ErrorPrice);
            this.panelInfo.Location = new System.Drawing.Point(527, 192);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(352, 345);
            this.panelInfo.TabIndex = 34;
            // 
            // selectorIssueComboTextoOpcionEditar
            // 
            this.selectorIssueComboTextoOpcionEditar.BackColor = System.Drawing.Color.Lavender;
            this.selectorIssueComboTextoOpcionEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectorIssueComboTextoOpcionEditar.Font = new System.Drawing.Font("Nirmala UI", 20F);
            this.selectorIssueComboTextoOpcionEditar.ForeColor = System.Drawing.Color.Black;
            this.selectorIssueComboTextoOpcionEditar.FormattingEnabled = true;
            this.selectorIssueComboTextoOpcionEditar.Location = new System.Drawing.Point(90, 45);
            this.selectorIssueComboTextoOpcionEditar.Margin = new System.Windows.Forms.Padding(2);
            this.selectorIssueComboTextoOpcionEditar.Name = "selectorIssueComboTextoOpcionEditar";
            this.selectorIssueComboTextoOpcionEditar.Size = new System.Drawing.Size(305, 45);
            this.selectorIssueComboTextoOpcionEditar.TabIndex = 28;
            this.selectorIssueComboTextoOpcionEditar.Text = "Select Issue to edit";
            this.selectorIssueComboTextoOpcionEditar.SelectedIndexChanged += new System.EventHandler(this.cambiarIssue);
            this.selectorIssueComboTextoOpcionEditar.Click += new System.EventHandler(this.clickeditar);
            this.selectorIssueComboTextoOpcionEditar.MouseEnter += new System.EventHandler(this.enterpaneleditar);
            this.selectorIssueComboTextoOpcionEditar.MouseLeave += new System.EventHandler(this.leavepaneleditar);
            // 
            // paneltapamelotodo
            // 
            this.paneltapamelotodo.Location = new System.Drawing.Point(11, 126);
            this.paneltapamelotodo.Name = "paneltapamelotodo";
            this.paneltapamelotodo.Size = new System.Drawing.Size(935, 464);
            this.paneltapamelotodo.TabIndex = 36;
            // 
            // errordate
            // 
            this.errordate.AutoSize = true;
            this.errordate.BackColor = System.Drawing.Color.Transparent;
            this.errordate.Font = new System.Drawing.Font("Nirmala UI", 10F);
            this.errordate.ForeColor = System.Drawing.Color.Red;
            this.errordate.Location = new System.Drawing.Point(148, 18);
            this.errordate.Name = "errordate";
            this.errordate.Size = new System.Drawing.Size(45, 19);
            this.errordate.TabIndex = 37;
            this.errordate.Text = "label2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Nirmala UI", 15F);
            this.label8.Location = new System.Drawing.Point(101, 200);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 28);
            this.label8.TabIndex = 38;
            this.label8.Text = "%";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Nirmala UI", 15F);
            this.label9.Location = new System.Drawing.Point(102, 274);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 28);
            this.label9.TabIndex = 39;
            this.label9.Text = "€";
            // 
            // BuildIssue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 642);
            this.Controls.Add(this.paneltapamelotodo);
            this.Controls.Add(this.TextoOpcionNueva);
            this.Controls.Add(this.selectorIssueComboTextoOpcionEditar);
            this.Controls.Add(this.o);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.busacarButton);
            this.Controls.Add(this.ButtonAccept);
            this.Controls.Add(this.ErrorArea);
            this.Controls.Add(this.agregarPaper);
            this.Controls.Add(this.listaPapers);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.selectedPapers);
            this.Controls.Add(this.selectorAreaCombo);
            this.Controls.Add(this.ErrorCrear);
            this.Controls.Add(this.textBoxprice);
            this.Controls.Add(this.ErrorAgregar);
            this.Controls.Add(this.textBoxdiscount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxnumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.publicationDate);
            this.Controls.Add(this.panelInfo);
            this.Name = "BuildIssue";
            this.Text = "--";
            this.Load += new System.EventHandler(this.BuildIssue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.magazineDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.papersBindingSource)).EndInit();
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonAccept;
        private System.Windows.Forms.ComboBox selectorAreaCombo;
        private System.Windows.Forms.ListBox listaPapers;
        private System.Windows.Forms.Button busacarButton;
        private MagazineDBDataSet magazineDBDataSet;
        private System.Windows.Forms.BindingSource papersBindingSource;
        private MagazineDBDataSetTableAdapters.PapersTableAdapter papersTableAdapter;
        private System.Windows.Forms.Button agregarPaper;
        private System.Windows.Forms.ListBox selectedPapers;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label publicationDate;
        private System.Windows.Forms.Label ErrorArea;
        private System.Windows.Forms.Label ErrorAgregar;
        private System.Windows.Forms.Label ErrorCrear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxnumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxdiscount;
        private System.Windows.Forms.TextBox textBoxprice;
        private System.Windows.Forms.Label TextoOpcionNueva;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Label ErrorNumber;
        private System.Windows.Forms.Label ErrorDiscount;
        private System.Windows.Forms.Label ErrorPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label o;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.ComboBox selectorIssueComboTextoOpcionEditar;
        private System.Windows.Forms.Panel paneltapamelotodo;
        private System.Windows.Forms.Label errordate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
    }
}