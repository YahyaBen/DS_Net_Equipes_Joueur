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
            DGV_Joueur_Load();
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
        }
        public void DGV_Joueur_Load() // Chargement du DGV
        {
            if (A.DT_2.Rows != null)// Pour ne pas ecraser les anciens donnees
            {
                A.DT_2.Clear();
            }
            A.Comm.CommandText = "Select * from Joueur";
            A.Comm.Connection = A.Connex;
            A.Rd = A.Comm.ExecuteReader();
            A.DT_2.Load(A.Rd);
            DGV_2.DataSource = A.DT_2;
            A.Rd.Close();
        }
        public static bool IsNumeric(string s)  // Fonction pour verifier si input est numerique, tres utile pour les precedent Tp's aussi
        {
            float F;
            return float.TryParse(s, out F);
        }
        private void Btn_EquipeAjouter_Click(object sender, EventArgs e)
        {
            if (Txt_NomEquipe.Text == "")
            {
                MessageBox.Show("Merci de Remplir tous les champs !", "Erreur Saisie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else { 
            A.Comm.CommandText = "insert into Equipe values('"+ Txt_NomEquipe.Text+"');";
            A.Comm.Connection = A.Connex;
            A.Comm.ExecuteNonQuery();
            DGV_Equipe_Load();// Mise a jour de l'affichage DGV
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
    }
}
