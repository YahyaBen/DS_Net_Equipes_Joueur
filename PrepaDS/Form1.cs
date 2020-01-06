using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrepaDS
{
    public partial class Application : Form
    {
        public Application()
        {
            InitializeComponent();
        }
        SQL_Raccourcis A = new SQL_Raccourcis(); // Creation Object de connexion Base de donnees

        private void Application_Load(object sender, EventArgs e)
        {
            A.CONNECTER();
            DGV_Equipe_Load();
            CB_Equipe_Load();
            //DGV_Joueur_Load();
        }

        public void DGV_Equipe_Load() // Chargement du DGV
        {
            if (A.DT_1.Rows != null)// Pour ne pas ecraser les anciens donnees
            {
                A.DT_1.Clear();
            }
            A.Comm.CommandText = "Select * from Equipe";
            A.Comm.Connection = A.Connex;
            A.Rd = A.Comm.ExecuteReader();
            A.DT_1.Load(A.Rd);
            DGV_1.DataSource = A.DT_1;
            A.Rd.Close();
            Txt_NumeroEquipe.Text = EquipeCount().ToString();
        }
        public void DGV_Joueur_Load() // Chargement du DGV
        {
            if (A.DT_2.Rows != null)// Pour ne pas ecraser les anciens donnees
            {
                A.DT_2.Clear();
            }
            A.Comm.CommandText = "Select * from Joueur Where Joueur.NoEquipe='" + DGV_1.CurrentCell.Value.ToString() + "';";
            A.Comm.Connection = A.Connex;
            A.Rd = A.Comm.ExecuteReader();
            A.DT_2.Load(A.Rd);
            DGV_2.DataSource = A.DT_2;
            A.Rd.Close();
        }

        public void CB_Equipe_Load()
        {
            if (CB_Equipe.Items.Count != 0)
            {
                CB_Equipe.Items.Clear();
            }
            A.Comm.CommandText = "select NoEquipe from Equipe";
            A.Comm.Connection = A.Connex;
            A.Rd = A.Comm.ExecuteReader();
            while (A.Rd.Read())
            {
                CB_Equipe.Items.Add(A.Rd[0]);
            }
            A.Rd.Close();
        }
        public static bool IsNumeric(string s)  // Fonction pour verifier si input est numerique, tres utile pour les precedent Tp's aussi
        {
            float F;
            return float.TryParse(s, out F);
        }
        public int EquipeCount() // Fonction pour affiche le dernier ID enregistrer
        {
            int B;
            A.Comm.CommandText = "Select Max(NoEquipe) from Equipe ";
            A.Comm.Connection = A.Connex;
            B = (int)A.Comm.ExecuteScalar();
            return B;
        }
        public int JoueurCount() // Fonction pour affiche le dernier ID enregistrer
        {
            int B;
            A.Comm.CommandText = "Select count(NoJoueur) from Joueur Where Joueur.NoEquipe='"+DGV_1.CurrentCell.Value.ToString()+"';";
            A.Comm.Connection = A.Connex;
            B = (int)A.Comm.ExecuteScalar();
            return B;

        }

        private void Btn_EquipeAjouter_Click(object sender, EventArgs e)
        {
            if (Txt_NomEquipe.Text == "")
            {
                MessageBox.Show("Merci de Remplir tous les champs !", "Erreur Saisie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                A.Comm.CommandText = "insert into Equipe values('" + Txt_NomEquipe.Text + "');";
                A.Comm.Connection = A.Connex;
                A.Comm.ExecuteNonQuery();
                DGV_Equipe_Load();// Mise a jour de l'affichage DGV
                CB_Equipe_Load();
            }
        }

        private void Btn_EquipeModifier_Click(object sender, EventArgs e)
        {
            if (DGV_1.CurrentCell.Value is int)// Verifier que la cellule choisie du DGv et bien ID = int
            {
                if (MessageBox.Show("Etes-vous sur de le Modifier ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    A.Comm.CommandText = "update Equipe set NomEquipe='" + Txt_NomEquipe.Text + "' where NoEquipe ='" + DGV_1.CurrentCell.Value.ToString() + "'";
                    A.Comm.Connection = A.Connex;
                    A.Comm.ExecuteNonQuery();
                    DGV_Equipe_Load();// Mise a jour de l'affichage DGV
                    CB_Equipe_Load();
                }
            }
            else MessageBox.Show("Merci choisir Cellule 'NoEquipe' a Modifier !", "Erreur Saisie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void Btn_EquipeSupprimer_Click(object sender, EventArgs e)
        {
            try
            { // le seul solution sans perturber ma base de donnees, delete cascade a revoir bien sur
                if (DGV_1.CurrentCell.Value is int)
                {
                    if (MessageBox.Show("Etes-vous sur de supprimer ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        A.Comm.CommandText = "delete from Equipe where NoEquipe ='" + DGV_1.CurrentCell.Value.ToString() + "'";
                        A.Comm.Connection = A.Connex;
                        A.Comm.ExecuteNonQuery();
                        DGV_Equipe_Load();
                        CB_Equipe_Load();
                    }
                }
                else MessageBox.Show("Merci choisir la Cellule 'NoEquipe'  et pas 'NomEquipe' !", "Erreur Saisie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception)
            {
                MessageBox.Show("Des Joueurs sont lier a cette Equipe, impossile de supprimer !", "Erreur Suppression", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Btn_PremierEquipe_Click(object sender, EventArgs e)
        {
            DGV_1.CurrentCell = DGV_1.Rows[0].Cells[DGV_1.CurrentCell.ColumnIndex];
        }

        private void Btn_PrecedentEquipe_Click(object sender, EventArgs e)
        {
            try
            {
                int A = DGV_1.CurrentRow.Index - 1;
                DGV_1.CurrentCell = DGV_1.Rows[A].Cells[DGV_1.CurrentCell.ColumnIndex];
            }
            catch (Exception)
            {
                MessageBox.Show("Max Atteint", "Stop !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Btn_NextEquipe_Click(object sender, EventArgs e)
        {
            try
            {
                int A = DGV_1.CurrentRow.Index + 1;
                DGV_1.CurrentCell = DGV_1.Rows[A].Cells[DGV_1.CurrentCell.ColumnIndex];
            }
            catch (Exception)
            {
                MessageBox.Show("Max Atteint", "Stop !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Btn_LastEquipe_Click(object sender, EventArgs e)
        {
            int A = DGV_1.Rows.Count - 1;
            DGV_1.CurrentCell = DGV_1.Rows[A].Cells[DGV_1.CurrentCell.ColumnIndex];
        }

        private void DGV_1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Txt_NbrJoueur.Text = JoueurCount().ToString();
            DGV_Joueur_Load();
        }

        private void Btn_JoueurAjouter_Click(object sender, EventArgs e)
        {
            if (Txt_NomJoueur.Text == "" && Txt_NumeroJoueur.Text == "" && Txt_Sexe.Text == "" )
            {
                MessageBox.Show("Merci de Remplir tous les champs !", "Erreur Saisie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                A.Comm.CommandText = "insert into Joueur(NoJoueur,NomJoueur,Sexe,NoEquipe) values('" 
                    + Txt_NumeroJoueur.Text +"','"
                    + Txt_NomJoueur.Text+ "','"
                    + Txt_Sexe.Text+"',@NoEquipe);";
                A.Comm.Parameters.AddWithValue("@NoEquipe", CB_Equipe.SelectedItem);
                A.Comm.Connection = A.Connex;
                A.Comm.ExecuteNonQuery();
                DGV_Equipe_Load();// Mise a jour de l'affichage DGV
                CB_Equipe_Load();
            }
        }
    

        private void Btn_JoueurModifier_Click(object sender, EventArgs e)
        {
            {
                if (DGV_1.CurrentCell.Value is int)// Verifier que la cellule choisie du DGv et bien ID = int
                {
                    if (MessageBox.Show("Etes-vous sur de le Modifier ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        A.Comm.CommandText = "update Joueur set NomJoueur='" + Txt_NomJoueur.Text + "',Sexe ='"
                    + Txt_Sexe.Text + "',NoEquipe=@NoEquipe where NoJoueur ='" +Txt_NumeroJoueur.Text+ "'";
                        A.Comm.Parameters.AddWithValue("@NoEquipe", CB_Equipe.SelectedItem);
                        A.Comm.Connection = A.Connex;
                        A.Comm.ExecuteNonQuery();
                        DGV_Equipe_Load();// Mise a jour de l'affichage DGV
                        CB_Equipe_Load();
                    }
                }
                else MessageBox.Show("Merci choisir Cellule 'NoEquipe' a Modifier !", "Erreur Saisie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Btn_JoueurSupprimer_Click(object sender, EventArgs e)
        {
            try
            { // le seul solution sans perturber ma base de donnees, delete cascade a revoir bien sur
                if (DGV_1.CurrentCell.Value is int)
                {
                    if (MessageBox.Show("Etes-vous sur de supprimer ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        A.Comm.CommandText = "delete from Joueur where NoJoueur ='" + Txt_NumeroJoueur.Text + "'";
                        A.Comm.Connection = A.Connex;
                        A.Comm.ExecuteNonQuery();
                        DGV_Equipe_Load();
                        CB_Equipe_Load();
                    }
                }
                else MessageBox.Show("Merci choisir la Cellule 'NoEquipe'  et pas 'NomEquipe' !", "Erreur Saisie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception)
            {
                MessageBox.Show("Des Joueurs sont lier a cette Equipe, impossile de supprimer !", "Erreur Suppression", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Fermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
