using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrepaDS
{
    public partial class Rechercher : Form
    {
        public Rechercher()
        {
            InitializeComponent();
        }
        SQL_Raccourcis A = new SQL_Raccourcis(); 
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Rechercher_Load(object sender, EventArgs e)
        {
            A.CONNECTER();
        }

        private void Btn_Recherche_Click(object sender, EventArgs e)
        {
            if (Txt_NomEquipeR.Text != "")
            {
                A.Comm.CommandText = "Select NoJoueur,NomJoueur,Sexe from Joueur inner join Equipe on Equipe.NoEquipe = Joueur.NoEquipe where Equipe.NomEquipe='" + Txt_NomEquipeR.Text + "';";
                A.Comm.Connection = A.Connex;
                A.Rd = A.Comm.ExecuteReader();
                A.DT_3.Load(A.Rd);
                DGV_Recherche.DataSource = A.DT_3;
                A.Rd.Close();
            }
            else MessageBox.Show("Merci de Rechercher par Nom!", "Erreur Saisie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        // ------------------------------------------------
        //
        //
        //
        private void Btn_Print_Click(object sender, EventArgs e)
        {
            PrintDialog B =new PrintDialog();
            B.Document = printDoc;
            B.UseEXDialog = true;
            if (DialogResult.OK == B.ShowDialog())
            {
                printDoc.Print();
            }

        }

        private void printDoc_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap A = new Bitmap(this.DGV_Recherche.Width, this.DGV_Recherche.Height);
            DGV_Recherche.DrawToBitmap(A, new Rectangle(0, 0, this.DGV_Recherche.Width, this.DGV_Recherche.Height));
            e.Graphics.DrawImage(A, 10, 10);

        }
    }
}
