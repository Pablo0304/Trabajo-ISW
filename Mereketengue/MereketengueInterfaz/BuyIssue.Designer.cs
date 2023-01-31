namespace MereketengueInterfaz
{
    partial class BuyIssue
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
            this.issuesPublicadas = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listacompra = new System.Windows.Forms.ListBox();
            this.Buybutton = new System.Windows.Forms.Button();
            this.LabelPrice = new System.Windows.Forms.Label();
            this.buttonaddcart = new System.Windows.Forms.Button();
            this.buttonborrar = new System.Windows.Forms.Button();
            this.labelprecio = new System.Windows.Forms.Label();
            this.buttonback = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // issuesPublicadas
            // 
            this.issuesPublicadas.Font = new System.Drawing.Font("Nirmala UI", 14F);
            this.issuesPublicadas.FormattingEnabled = true;
            this.issuesPublicadas.ItemHeight = 25;
            this.issuesPublicadas.Location = new System.Drawing.Point(48, 110);
            this.issuesPublicadas.Name = "issuesPublicadas";
            this.issuesPublicadas.Size = new System.Drawing.Size(387, 379);
            this.issuesPublicadas.TabIndex = 0;
            this.issuesPublicadas.SelectedIndexChanged += new System.EventHandler(this.elegirIssue);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 30F);
            this.label1.Location = new System.Drawing.Point(39, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 54);
            this.label1.TabIndex = 1;
            this.label1.Text = "Publicated Issues";
            // 
            // listacompra
            // 
            this.listacompra.Font = new System.Drawing.Font("Nirmala UI", 14F);
            this.listacompra.FormattingEnabled = true;
            this.listacompra.ItemHeight = 25;
            this.listacompra.Location = new System.Drawing.Point(654, 110);
            this.listacompra.Name = "listacompra";
            this.listacompra.Size = new System.Drawing.Size(342, 379);
            this.listacompra.TabIndex = 2;
            // 
            // Buybutton
            // 
            this.Buybutton.Font = new System.Drawing.Font("Nirmala UI", 14F);
            this.Buybutton.Location = new System.Drawing.Point(911, 521);
            this.Buybutton.Name = "Buybutton";
            this.Buybutton.Size = new System.Drawing.Size(85, 48);
            this.Buybutton.TabIndex = 3;
            this.Buybutton.Text = "Buy";
            this.Buybutton.UseVisualStyleBackColor = true;
            this.Buybutton.Click += new System.EventHandler(this.Buybutton_Click);
            // 
            // LabelPrice
            // 
            this.LabelPrice.AutoSize = true;
            this.LabelPrice.Font = new System.Drawing.Font("Nirmala UI", 20F);
            this.LabelPrice.Location = new System.Drawing.Point(647, 532);
            this.LabelPrice.Name = "LabelPrice";
            this.LabelPrice.Size = new System.Drawing.Size(145, 37);
            this.LabelPrice.TabIndex = 4;
            this.LabelPrice.Text = "Total price:";
            // 
            // buttonaddcart
            // 
            this.buttonaddcart.Font = new System.Drawing.Font("Nirmala UI", 14F);
            this.buttonaddcart.Location = new System.Drawing.Point(469, 166);
            this.buttonaddcart.Name = "buttonaddcart";
            this.buttonaddcart.Size = new System.Drawing.Size(143, 116);
            this.buttonaddcart.TabIndex = 5;
            this.buttonaddcart.Text = "Add to shopping cart";
            this.buttonaddcart.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.buttonaddcart.UseVisualStyleBackColor = true;
            this.buttonaddcart.Click += new System.EventHandler(this.buttonaddcart_Click);
            // 
            // buttonborrar
            // 
            this.buttonborrar.Font = new System.Drawing.Font("Nirmala UI", 14F);
            this.buttonborrar.Location = new System.Drawing.Point(469, 319);
            this.buttonborrar.Name = "buttonborrar";
            this.buttonborrar.Size = new System.Drawing.Size(143, 116);
            this.buttonborrar.TabIndex = 6;
            this.buttonborrar.Text = "Delete from shopping cart";
            this.buttonborrar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.buttonborrar.UseVisualStyleBackColor = true;
            this.buttonborrar.Click += new System.EventHandler(this.buttonborrar_Click);
            // 
            // labelprecio
            // 
            this.labelprecio.AutoSize = true;
            this.labelprecio.Font = new System.Drawing.Font("Nirmala UI", 20F);
            this.labelprecio.Location = new System.Drawing.Point(798, 532);
            this.labelprecio.Name = "labelprecio";
            this.labelprecio.Size = new System.Drawing.Size(47, 37);
            this.labelprecio.TabIndex = 7;
            this.labelprecio.Text = "0€";
            // 
            // buttonback
            // 
            this.buttonback.Font = new System.Drawing.Font("Nirmala UI", 14F);
            this.buttonback.Location = new System.Drawing.Point(48, 542);
            this.buttonback.Name = "buttonback";
            this.buttonback.Size = new System.Drawing.Size(85, 48);
            this.buttonback.TabIndex = 8;
            this.buttonback.Text = "Back";
            this.buttonback.UseVisualStyleBackColor = true;
            this.buttonback.Click += new System.EventHandler(this.buttonback_Click);
            // 
            // BuyIssue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 616);
            this.Controls.Add(this.buttonback);
            this.Controls.Add(this.labelprecio);
            this.Controls.Add(this.buttonborrar);
            this.Controls.Add(this.buttonaddcart);
            this.Controls.Add(this.LabelPrice);
            this.Controls.Add(this.Buybutton);
            this.Controls.Add(this.listacompra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.issuesPublicadas);
            this.Name = "BuyIssue";
            this.Text = "BuyIssue";
            this.Load += new System.EventHandler(this.load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox issuesPublicadas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listacompra;
        private System.Windows.Forms.Button Buybutton;
        private System.Windows.Forms.Label LabelPrice;
        private System.Windows.Forms.Button buttonaddcart;
        private System.Windows.Forms.Button buttonborrar;
        private System.Windows.Forms.Label labelprecio;
        private System.Windows.Forms.Button buttonback;
    }
}