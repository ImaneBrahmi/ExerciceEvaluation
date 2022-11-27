using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace windowsform
{
    class DB
    {
        public OleDbConnection conn = new OleDbConnection();
        public OleDbCommand cmd = new OleDbCommand();
        public OleDbDataAdapter dap = new OleDbDataAdapter();
        public OleDbDataReader dr;
        public DataTable dt = new DataTable();
        public DataSet ds = new DataSet();
        public DataRow ligne;
        public OleDbCommandBuilder bc;
        public DataGridView dataGridView1 = new DataGridView();
        //methode connecter
        public void CONNECTER()
        {
            if (conn.State == ConnectionState.Closed || conn.State == ConnectionState.Broken)
            {
                conn.ConnectionString = "Data Source = C:\\Users\\Hp\\Documents\\EXAMdb";
                conn.Open();
            }
        }
        // deconnecter
        public void deconnecter()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }
    }
}
