namespace MereketengueInterfaz
{
    partial class ListPapers
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
            this.buscadorBox = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.buscador = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listaPapers = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buscadorBox
            // 
            this.buscadorBox.Location = new System.Drawing.Point(599, 17);
            this.buscadorBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buscadorBox.Name = "buscadorBox";
            this.buscadorBox.Size = new System.Drawing.Size(132, 22);
            this.buscadorBox.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // buscador
            // 
            this.buscador.Location = new System.Drawing.Point(739, 15);
            this.buscador.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buscador.Name = "buscador";
            this.buscador.Size = new System.Drawing.Size(85, 25);
            this.buscador.TabIndex = 2;
            this.buscador.Text = "Buscar";
            this.buscador.UseVisualStyleBackColor = true;
            this.buscador.Click += new System.EventHandler(this.buscadorClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(767, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "---------------------------------------------------------------------------------" +
    "--------------------------------------------------------------------------------" +
    "-----------------------------";
            // 
            // listaPapers
            // 
            this.listaPapers.HideSelection = false;
            this.listaPapers.Location = new System.Drawing.Point(44, 71);
            this.listaPapers.Name = "listaPapers";
            this.listaPapers.Size = new System.Drawing.Size(753, 327);
            this.listaPapers.TabIndex = 4;
            this.listaPapers.UseCompatibleStateImageBehavior = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(499, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Number issue:";
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(722, 404);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 6;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // ListPapers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 437);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listaPapers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buscador);
            this.Controls.Add(this.buscadorBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ListPapers";
            this.Text = "List Papers";
            this.Load += new System.EventHandler(this.ListPapers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox buscadorBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button buscador;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listaPapers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button backButton;
    }
}