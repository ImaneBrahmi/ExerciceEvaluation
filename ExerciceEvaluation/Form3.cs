using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace windowsform
{
    public partial class Form3 : Form
    {
        SqlConnection conn = new SqlConnection("Data Source = desktop - c75hheu\\sqlexpress; Initial Catalog = exam; Integrated Security = True");
        SqlCommand cmd;
        public Form3()
        {
            InitializeComponent();
            
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
           
        }

        private void btnSuivant_Click(object sender, EventArgs e)
        {
            if (qst.Text == "" || prpo1.Text == "" || propo2.Text == "" || propo3.Text == "" || propo4.Text == "" || reponse.Text == "" || note.Text == "")
            {
                MessageBox.Show("votre questionnaire crees avec succes");
                return;
            }
            else
            {
                SqlConnection conn = new SqlConnection("Data Source = desktop - c75hheu\\sqlexpress; Initial Catalog = exam; Integrated Security = True");
                conn.Open();
                SqlCommand commande = new SqlCommand("insert into qsm(question,propo1,propo2,propo3,propo4,repionse,note) values('" + qst.Text + "','" + prpo1.Text + "','" + propo2.Text + "','" + propo3.Text + "','" + propo4.Text + "','" + reponse.Text + "','" + note.Text + "')  ", conn);
                commande.ExecuteNonQuery();
                MessageBox.Show("votre questionnaire crees avec succes");
            }
           
           
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            var Form3 = new Form2();
            Form3.Show();
        }
    }
}
