namespace PrepaDS
{
    partial class Application
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
            this.DGV_1 = new System.Windows.Forms.DataGridView();
            this.DGV_2 = new System.Windows.Forms.DataGridView();
            this.NumeroEquipe = new System.Windows.Forms.Label();
            this.NomEquipe = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Lbl_NbrJoueur = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Btn_EquipeAjouter = new System.Windows.Forms.Button();
            this.Btn_EquipeModifier = new System.Windows.Forms.Button();
            this.Btn_EquipeSupprimer = new System.Windows.Forms.Button();
            this.Btn_PremierEquipe = new System.Windows.Forms.Button();
            this.Btn_PrecedentEquipe = new System.Windows.Forms.Button();
            this.Btn_LastEquipe = new System.Windows.Forms.Button();
            this.Btn_NextEquipe = new System.Windows.Forms.Button();
            this.Txt_NumeroEquipe = new System.Windows.Forms.TextBox();
            this.Txt_NomEquipe = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Txt_NbrJoueur = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGV_1
            // 
            this.DGV_1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_1.Location = new System.Drawing.Point(453, 22);
            this.DGV_1.Name = "DGV_1";
            this.DGV_1.Size = new System.Drawing.Size(323, 171);
            this.DGV_1.TabIndex = 0;
            this.DGV_1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_1_CellClick);
            // 
            // DGV_2
            // 
            this.DGV_2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_2.Location = new System.Drawing.Point(453, 256);
            this.DGV_2.Name = "DGV_2";
            this.DGV_2.Size = new System.Drawing.Size(323, 171);
            this.DGV_2.TabIndex = 1;
            // 
            // NumeroEquipe
            // 
            this.NumeroEquipe.AutoSize = true;
            this.NumeroEquipe.Location = new System.Drawing.Point(14, 34);
            this.NumeroEquipe.Name = "NumeroEquipe";
            this.NumeroEquipe.Size = new System.Drawing.Size(86, 13);
            this.NumeroEquipe.TabIndex = 2;
            this.NumeroEquipe.Text = "Nombre Equipe :";
            // 
            // NomEquipe
            // 
            this.NomEquipe.AutoSize = true;
            this.NomEquipe.Location = new System.Drawing.Point(14, 73);
            this.NomEquipe.Name = "NomEquipe";
            this.NomEquipe.Size = new System.Drawing.Size(71, 13);
            this.NomEquipe.TabIndex = 3;
            this.NomEquipe.Text = "Nom Equipe :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "label3";
            // 
            // Lbl_NbrJoueur
            // 
            this.Lbl_NbrJoueur.AutoSize = true;
            this.Lbl_NbrJoueur.Location = new System.Drawing.Point(14, 132);
            this.Lbl_NbrJoueur.Name = "Lbl_NbrJoueur";
            this.Lbl_NbrJoueur.Size = new System.Drawing.Size(159, 13);
            this.Lbl_NbrJoueur.TabIndex = 5;
            this.Lbl_NbrJoueur.Text = "Nombre joueur de cette equipe :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "label5";
            // 
            // Btn_EquipeAjouter
            // 
            this.Btn_EquipeAjouter.Location = new System.Drawing.Point(325, 29);
            this.Btn_EquipeAjouter.Name = "Btn_EquipeAjouter";
            this.Btn_EquipeAjouter.Size = new System.Drawing.Size(75, 23);
            this.Btn_EquipeAjouter.TabIndex = 7;
            this.Btn_EquipeAjouter.Text = "Ajouter";
            this.Btn_EquipeAjouter.UseVisualStyleBackColor = true;
            this.Btn_EquipeAjouter.Click += new System.EventHandler(this.Btn_EquipeAjouter_Click);
            // 
            // Btn_EquipeModifier
            // 
            this.Btn_EquipeModifier.Location = new System.Drawing.Point(325, 58);
            this.Btn_EquipeModifier.Name = "Btn_EquipeModifier";
            this.Btn_EquipeModifier.Size = new System.Drawing.Size(75, 23);
            this.Btn_EquipeModifier.TabIndex = 8;
            this.Btn_EquipeModifier.Text = "Modifier";
            this.Btn_EquipeModifier.UseVisualStyleBackColor = true;
            this.Btn_EquipeModifier.Click += new System.EventHandler(this.Btn_EquipeModifier_Click);
            // 
            // Btn_EquipeSupprimer
            // 
            this.Btn_EquipeSupprimer.Location = new System.Drawing.Point(325, 87);
            this.Btn_EquipeSupprimer.Name = "Btn_EquipeSupprimer";
            this.Btn_EquipeSupprimer.Size = new System.Drawing.Size(75, 23);
            this.Btn_EquipeSupprimer.TabIndex = 9;
            this.Btn_EquipeSupprimer.Text = "Supprimer";
            this.Btn_EquipeSupprimer.UseVisualStyleBackColor = true;
            this.Btn_EquipeSupprimer.Click += new System.EventHandler(this.Btn_EquipeSupprimer_Click);
            // 
            // Btn_PremierEquipe
            // 
            this.Btn_PremierEquipe.Location = new System.Drawing.Point(453, 206);
            this.Btn_PremierEquipe.Name = "Btn_PremierEquipe";
            this.Btn_PremierEquipe.Size = new System.Drawing.Size(29, 23);
            this.Btn_PremierEquipe.TabIndex = 10;
            this.Btn_PremierEquipe.Text = "<<";
            this.Btn_PremierEquipe.UseVisualStyleBackColor = true;
            this.Btn_PremierEquipe.Click += new System.EventHandler(this.Btn_PremierEquipe_Click);
            // 
            // Btn_PrecedentEquipe
            // 
            this.Btn_PrecedentEquipe.Location = new System.Drawing.Point(480, 206);
            this.Btn_PrecedentEquipe.Name = "Btn_PrecedentEquipe";
            this.Btn_PrecedentEquipe.Size = new System.Drawing.Size(21, 23);
            this.Btn_PrecedentEquipe.TabIndex = 11;
            this.Btn_PrecedentEquipe.Text = "<";
            this.Btn_PrecedentEquipe.UseVisualStyleBackColor = true;
            this.Btn_PrecedentEquipe.Click += new System.EventHandler(this.Btn_PrecedentEquipe_Click);
            // 
            // Btn_LastEquipe
            // 
            this.Btn_LastEquipe.Location = new System.Drawing.Point(745, 206);
            this.Btn_LastEquipe.Name = "Btn_LastEquipe";
            this.Btn_LastEquipe.Size = new System.Drawing.Size(31, 23);
            this.Btn_LastEquipe.TabIndex = 12;
            this.Btn_LastEquipe.Text = ">>";
            this.Btn_LastEquipe.UseVisualStyleBackColor = true;
            this.Btn_LastEquipe.Click += new System.EventHandler(this.Btn_LastEquipe_Click);
            // 
            // Btn_NextEquipe
            // 
            this.Btn_NextEquipe.Location = new System.Drawing.Point(728, 206);
            this.Btn_NextEquipe.Name = "Btn_NextEquipe";
            this.Btn_NextEquipe.Size = new System.Drawing.Size(21, 23);
            this.Btn_NextEquipe.TabIndex = 13;
            this.Btn_NextEquipe.Text = ">";
            this.Btn_NextEquipe.UseVisualStyleBackColor = true;
            this.Btn_NextEquipe.Click += new System.EventHandler(this.Btn_NextEquipe_Click);
            // 
            // Txt_NumeroEquipe
            // 
            this.Txt_NumeroEquipe.Enabled = false;
            this.Txt_NumeroEquipe.Location = new System.Drawing.Point(113, 32);
            this.Txt_NumeroEquipe.Name = "Txt_NumeroEquipe";
            this.Txt_NumeroEquipe.Size = new System.Drawing.Size(167, 20);
            this.Txt_NumeroEquipe.TabIndex = 14;
            // 
            // Txt_NomEquipe
            // 
            this.Txt_NomEquipe.Location = new System.Drawing.Point(113, 66);
            this.Txt_NomEquipe.Name = "Txt_NomEquipe";
            this.Txt_NomEquipe.Size = new System.Drawing.Size(167, 20);
            this.Txt_NomEquipe.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Txt_NbrJoueur);
            this.groupBox1.Controls.Add(this.Txt_NomEquipe);
            this.groupBox1.Controls.Add(this.NumeroEquipe);
            this.groupBox1.Controls.Add(this.Txt_NumeroEquipe);
            this.groupBox1.Controls.Add(this.NomEquipe);
            this.groupBox1.Controls.Add(this.Btn_EquipeAjouter);
            this.groupBox1.Controls.Add(this.Btn_EquipeModifier);
            this.groupBox1.Controls.Add(this.Lbl_NbrJoueur);
            this.groupBox1.Controls.Add(this.Btn_EquipeSupprimer);
            this.groupBox1.Location = new System.Drawing.Point(15, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(432, 171);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Equipes :";
            // 
            // Txt_NbrJoueur
            // 
            this.Txt_NbrJoueur.Enabled = false;
            this.Txt_NbrJoueur.Location = new System.Drawing.Point(200, 125);
            this.Txt_NbrJoueur.Name = "Txt_NbrJoueur";
            this.Txt_NbrJoueur.Size = new System.Drawing.Size(111, 20);
            this.Txt_NbrJoueur.TabIndex = 16;
            // 
            // Application
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Btn_NextEquipe);
            this.Controls.Add(this.Btn_LastEquipe);
            this.Controls.Add(this.Btn_PrecedentEquipe);
            this.Controls.Add(this.Btn_PremierEquipe);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DGV_2);
            this.Controls.Add(this.DGV_1);
            this.Name = "Application";
            this.Text = "Application";
            this.Load += new System.EventHandler(this.Application_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_1;
        private System.Windows.Forms.DataGridView DGV_2;
        private System.Windows.Forms.Label NumeroEquipe;
        private System.Windows.Forms.Label NomEquipe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Lbl_NbrJoueur;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Btn_EquipeAjouter;
        private System.Windows.Forms.Button Btn_EquipeModifier;
        private System.Windows.Forms.Button Btn_EquipeSupprimer;
        private System.Windows.Forms.Button Btn_PremierEquipe;
        private System.Windows.Forms.Button Btn_PrecedentEquipe;
        private System.Windows.Forms.Button Btn_LastEquipe;
        private System.Windows.Forms.Button Btn_NextEquipe;
        private System.Windows.Forms.TextBox Txt_NumeroEquipe;
        private System.Windows.Forms.TextBox Txt_NomEquipe;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Txt_NbrJoueur;
    }
}

