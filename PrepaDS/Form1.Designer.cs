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
            this.Btn_EquipeAjouter = new System.Windows.Forms.Button();
            this.Btn_EquipeModifier = new System.Windows.Forms.Button();
            this.Btn_EquipeSupprimer = new System.Windows.Forms.Button();
            this.Btn_PremierEquipe = new System.Windows.Forms.Button();
            this.Btn_PrecedentEquipe = new System.Windows.Forms.Button();
            this.Btn_LastEquipe = new System.Windows.Forms.Button();
            this.Btn_NextEquipe = new System.Windows.Forms.Button();
            this.Txt_NumeroEquipe = new System.Windows.Forms.TextBox();
            this.Txt_NomEquipe = new System.Windows.Forms.TextBox();
            this.Equipe = new System.Windows.Forms.GroupBox();
            this.Txt_NbrJoueur = new System.Windows.Forms.TextBox();
            this.Joueur = new System.Windows.Forms.GroupBox();
            this.Txt_NomJoueur = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_NumeroJoueur = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_JoueurAjouter = new System.Windows.Forms.Button();
            this.Btn_JoueurModifier = new System.Windows.Forms.Button();
            this.Btn_JoueurSupprimer = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_Sexe = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CB_Equipe = new System.Windows.Forms.ComboBox();
            this.Fermer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_2)).BeginInit();
            this.Equipe.SuspendLayout();
            this.Joueur.SuspendLayout();
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
            this.DGV_2.Location = new System.Drawing.Point(453, 228);
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
            this.Btn_PremierEquipe.Location = new System.Drawing.Point(453, 199);
            this.Btn_PremierEquipe.Name = "Btn_PremierEquipe";
            this.Btn_PremierEquipe.Size = new System.Drawing.Size(29, 23);
            this.Btn_PremierEquipe.TabIndex = 10;
            this.Btn_PremierEquipe.Text = "<<";
            this.Btn_PremierEquipe.UseVisualStyleBackColor = true;
            this.Btn_PremierEquipe.Click += new System.EventHandler(this.Btn_PremierEquipe_Click);
            // 
            // Btn_PrecedentEquipe
            // 
            this.Btn_PrecedentEquipe.Location = new System.Drawing.Point(480, 199);
            this.Btn_PrecedentEquipe.Name = "Btn_PrecedentEquipe";
            this.Btn_PrecedentEquipe.Size = new System.Drawing.Size(21, 23);
            this.Btn_PrecedentEquipe.TabIndex = 11;
            this.Btn_PrecedentEquipe.Text = "<";
            this.Btn_PrecedentEquipe.UseVisualStyleBackColor = true;
            this.Btn_PrecedentEquipe.Click += new System.EventHandler(this.Btn_PrecedentEquipe_Click);
            // 
            // Btn_LastEquipe
            // 
            this.Btn_LastEquipe.Location = new System.Drawing.Point(745, 199);
            this.Btn_LastEquipe.Name = "Btn_LastEquipe";
            this.Btn_LastEquipe.Size = new System.Drawing.Size(31, 23);
            this.Btn_LastEquipe.TabIndex = 12;
            this.Btn_LastEquipe.Text = ">>";
            this.Btn_LastEquipe.UseVisualStyleBackColor = true;
            this.Btn_LastEquipe.Click += new System.EventHandler(this.Btn_LastEquipe_Click);
            // 
            // Btn_NextEquipe
            // 
            this.Btn_NextEquipe.Location = new System.Drawing.Point(728, 199);
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
            // Equipe
            // 
            this.Equipe.Controls.Add(this.Txt_NbrJoueur);
            this.Equipe.Controls.Add(this.Txt_NomEquipe);
            this.Equipe.Controls.Add(this.NumeroEquipe);
            this.Equipe.Controls.Add(this.Txt_NumeroEquipe);
            this.Equipe.Controls.Add(this.NomEquipe);
            this.Equipe.Controls.Add(this.Btn_EquipeAjouter);
            this.Equipe.Controls.Add(this.Btn_EquipeModifier);
            this.Equipe.Controls.Add(this.Lbl_NbrJoueur);
            this.Equipe.Controls.Add(this.Btn_EquipeSupprimer);
            this.Equipe.Location = new System.Drawing.Point(15, 22);
            this.Equipe.Name = "Equipe";
            this.Equipe.Size = new System.Drawing.Size(432, 171);
            this.Equipe.TabIndex = 16;
            this.Equipe.TabStop = false;
            this.Equipe.Text = "Equipes :";
            // 
            // Txt_NbrJoueur
            // 
            this.Txt_NbrJoueur.Enabled = false;
            this.Txt_NbrJoueur.Location = new System.Drawing.Point(179, 125);
            this.Txt_NbrJoueur.Name = "Txt_NbrJoueur";
            this.Txt_NbrJoueur.Size = new System.Drawing.Size(26, 20);
            this.Txt_NbrJoueur.TabIndex = 16;
            // 
            // Joueur
            // 
            this.Joueur.Controls.Add(this.CB_Equipe);
            this.Joueur.Controls.Add(this.label3);
            this.Joueur.Controls.Add(this.Txt_Sexe);
            this.Joueur.Controls.Add(this.label5);
            this.Joueur.Controls.Add(this.Txt_NomJoueur);
            this.Joueur.Controls.Add(this.label1);
            this.Joueur.Controls.Add(this.Txt_NumeroJoueur);
            this.Joueur.Controls.Add(this.label2);
            this.Joueur.Controls.Add(this.Btn_JoueurAjouter);
            this.Joueur.Controls.Add(this.Btn_JoueurModifier);
            this.Joueur.Controls.Add(this.Btn_JoueurSupprimer);
            this.Joueur.Location = new System.Drawing.Point(12, 217);
            this.Joueur.Name = "Joueur";
            this.Joueur.Size = new System.Drawing.Size(432, 171);
            this.Joueur.TabIndex = 17;
            this.Joueur.TabStop = false;
            this.Joueur.Text = "Joueurs :";
            // 
            // Txt_NomJoueur
            // 
            this.Txt_NomJoueur.Location = new System.Drawing.Point(113, 66);
            this.Txt_NomJoueur.Name = "Txt_NomJoueur";
            this.Txt_NomJoueur.Size = new System.Drawing.Size(167, 20);
            this.Txt_NomJoueur.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Numero Joueur :";
            // 
            // Txt_NumeroJoueur
            // 
            this.Txt_NumeroJoueur.Location = new System.Drawing.Point(113, 32);
            this.Txt_NumeroJoueur.Name = "Txt_NumeroJoueur";
            this.Txt_NumeroJoueur.Size = new System.Drawing.Size(167, 20);
            this.Txt_NumeroJoueur.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nom Joueur :";
            // 
            // Btn_JoueurAjouter
            // 
            this.Btn_JoueurAjouter.Location = new System.Drawing.Point(325, 29);
            this.Btn_JoueurAjouter.Name = "Btn_JoueurAjouter";
            this.Btn_JoueurAjouter.Size = new System.Drawing.Size(75, 23);
            this.Btn_JoueurAjouter.TabIndex = 7;
            this.Btn_JoueurAjouter.Text = "Ajouter";
            this.Btn_JoueurAjouter.UseVisualStyleBackColor = true;
            this.Btn_JoueurAjouter.Click += new System.EventHandler(this.Btn_JoueurAjouter_Click);
            // 
            // Btn_JoueurModifier
            // 
            this.Btn_JoueurModifier.Location = new System.Drawing.Point(325, 71);
            this.Btn_JoueurModifier.Name = "Btn_JoueurModifier";
            this.Btn_JoueurModifier.Size = new System.Drawing.Size(75, 23);
            this.Btn_JoueurModifier.TabIndex = 8;
            this.Btn_JoueurModifier.Text = "Modifier";
            this.Btn_JoueurModifier.UseVisualStyleBackColor = true;
            this.Btn_JoueurModifier.Click += new System.EventHandler(this.Btn_JoueurModifier_Click);
            // 
            // Btn_JoueurSupprimer
            // 
            this.Btn_JoueurSupprimer.Location = new System.Drawing.Point(325, 112);
            this.Btn_JoueurSupprimer.Name = "Btn_JoueurSupprimer";
            this.Btn_JoueurSupprimer.Size = new System.Drawing.Size(75, 23);
            this.Btn_JoueurSupprimer.TabIndex = 9;
            this.Btn_JoueurSupprimer.Text = "Supprimer";
            this.Btn_JoueurSupprimer.UseVisualStyleBackColor = true;
            this.Btn_JoueurSupprimer.Click += new System.EventHandler(this.Btn_JoueurSupprimer_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Sexe Joueur :";
            // 
            // Txt_Sexe
            // 
            this.Txt_Sexe.Location = new System.Drawing.Point(113, 98);
            this.Txt_Sexe.Name = "Txt_Sexe";
            this.Txt_Sexe.Size = new System.Drawing.Size(167, 20);
            this.Txt_Sexe.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Numero Equipe :";
            // 
            // CB_Equipe
            // 
            this.CB_Equipe.FormattingEnabled = true;
            this.CB_Equipe.Location = new System.Drawing.Point(113, 126);
            this.CB_Equipe.Name = "CB_Equipe";
            this.CB_Equipe.Size = new System.Drawing.Size(167, 21);
            this.CB_Equipe.TabIndex = 19;
            // 
            // Fermer
            // 
            this.Fermer.Location = new System.Drawing.Point(340, 394);
            this.Fermer.Name = "Fermer";
            this.Fermer.Size = new System.Drawing.Size(75, 23);
            this.Fermer.TabIndex = 20;
            this.Fermer.Text = "Fermer";
            this.Fermer.UseVisualStyleBackColor = true;
            this.Fermer.Click += new System.EventHandler(this.Fermer_Click);
            // 
            // Application
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Fermer);
            this.Controls.Add(this.Joueur);
            this.Controls.Add(this.Equipe);
            this.Controls.Add(this.Btn_NextEquipe);
            this.Controls.Add(this.Btn_LastEquipe);
            this.Controls.Add(this.Btn_PrecedentEquipe);
            this.Controls.Add(this.Btn_PremierEquipe);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DGV_2);
            this.Controls.Add(this.DGV_1);
            this.Name = "Application";
            this.Text = "Application";
            this.Load += new System.EventHandler(this.Application_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_2)).EndInit();
            this.Equipe.ResumeLayout(false);
            this.Equipe.PerformLayout();
            this.Joueur.ResumeLayout(false);
            this.Joueur.PerformLayout();
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
        private System.Windows.Forms.Button Btn_EquipeAjouter;
        private System.Windows.Forms.Button Btn_EquipeModifier;
        private System.Windows.Forms.Button Btn_EquipeSupprimer;
        private System.Windows.Forms.Button Btn_PremierEquipe;
        private System.Windows.Forms.Button Btn_PrecedentEquipe;
        private System.Windows.Forms.Button Btn_LastEquipe;
        private System.Windows.Forms.Button Btn_NextEquipe;
        private System.Windows.Forms.TextBox Txt_NumeroEquipe;
        private System.Windows.Forms.TextBox Txt_NomEquipe;
        private System.Windows.Forms.GroupBox Equipe;
        private System.Windows.Forms.TextBox Txt_NbrJoueur;
        private System.Windows.Forms.GroupBox Joueur;
        private System.Windows.Forms.TextBox Txt_NomJoueur;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_NumeroJoueur;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_JoueurAjouter;
        private System.Windows.Forms.Button Btn_JoueurModifier;
        private System.Windows.Forms.Button Btn_JoueurSupprimer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_Sexe;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CB_Equipe;
        private System.Windows.Forms.Button Fermer;
    }
}

