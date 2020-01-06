namespace PrepaDS
{
    partial class Rechercher
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
            this.Btn_Recherche = new System.Windows.Forms.Button();
            this.Txt_NomEquipeR = new System.Windows.Forms.TextBox();
            this.DGV_Recherche = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.Btn_Print = new System.Windows.Forms.Button();
            this.printDoc = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Recherche)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Recherche
            // 
            this.Btn_Recherche.Location = new System.Drawing.Point(229, 37);
            this.Btn_Recherche.Name = "Btn_Recherche";
            this.Btn_Recherche.Size = new System.Drawing.Size(125, 23);
            this.Btn_Recherche.TabIndex = 0;
            this.Btn_Recherche.Text = "Rechercher";
            this.Btn_Recherche.UseVisualStyleBackColor = true;
            this.Btn_Recherche.Click += new System.EventHandler(this.Btn_Recherche_Click);
            // 
            // Txt_NomEquipeR
            // 
            this.Txt_NomEquipeR.Location = new System.Drawing.Point(55, 40);
            this.Txt_NomEquipeR.Name = "Txt_NomEquipeR";
            this.Txt_NomEquipeR.Size = new System.Drawing.Size(140, 20);
            this.Txt_NomEquipeR.TabIndex = 1;
            // 
            // DGV_Recherche
            // 
            this.DGV_Recherche.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_Recherche.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Recherche.Location = new System.Drawing.Point(55, 88);
            this.DGV_Recherche.Name = "DGV_Recherche";
            this.DGV_Recherche.Size = new System.Drawing.Size(299, 195);
            this.DGV_Recherche.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(229, 289);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 34);
            this.button2.TabIndex = 3;
            this.button2.Text = "Fermer";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Btn_Print
            // 
            this.Btn_Print.Location = new System.Drawing.Point(55, 295);
            this.Btn_Print.Name = "Btn_Print";
            this.Btn_Print.Size = new System.Drawing.Size(73, 23);
            this.Btn_Print.TabIndex = 4;
            this.Btn_Print.Text = "Print";
            this.Btn_Print.UseVisualStyleBackColor = true;
            this.Btn_Print.Click += new System.EventHandler(this.Btn_Print_Click);
            // 
            // printDoc
            // 
            this.printDoc.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDoc_PrintPage);
            // 
            // Rechercher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 335);
            this.Controls.Add(this.Btn_Print);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.DGV_Recherche);
            this.Controls.Add(this.Txt_NomEquipeR);
            this.Controls.Add(this.Btn_Recherche);
            this.Name = "Rechercher";
            this.Text = "Rechercher";
            this.Load += new System.EventHandler(this.Rechercher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Recherche)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Recherche;
        private System.Windows.Forms.TextBox Txt_NomEquipeR;
        private System.Windows.Forms.DataGridView DGV_Recherche;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Btn_Print;
        private System.Drawing.Printing.PrintDocument printDoc;
    }
}