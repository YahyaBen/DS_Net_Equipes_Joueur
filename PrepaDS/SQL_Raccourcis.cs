using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrepaDS
{
    class SQL_Raccourcis
    {
        // Declaration
        public SqlConnection Connex = new SqlConnection();
        public SqlCommand Comm = new SqlCommand();
        public SqlDataReader Rd;

        public DataTable DT = new DataTable();

        // Declaration methode connecter 
        public void CONNECTER()
        {
            if (Connex.State == ConnectionState.Closed || Connex.State == ConnectionState.Broken)
            {
                Connex.ConnectionString = "Data Source=HYRKUL;Initial Catalog=Prepa_DS;Integrated Security=True";
                Connex.Open();
            }
        }
        // Declaration methode Deconnecter
        public void DECONNECTER()
        {
            if (Connex.State == ConnectionState.Open)
            {
                Connex.Close();
            }
        }
    }
}
