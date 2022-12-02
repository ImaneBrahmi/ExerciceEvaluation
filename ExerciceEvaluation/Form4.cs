using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace windowsform
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (qst.Text == "" || reponse.Text == "" || note.Text == "")
            {
                MessageBox.Show("votre questionnaire crees avec succes");
                return;
            }
            else
            {
                SqlConnection conn = new SqlConnection("Data Source = desktop - c75hheu\\sqlexpress; Initial Catalog = exam; Integrated Security = True");
                conn.Open();
                SqlCommand commande = new SqlCommand("insert into question(question,reponse,note) values('" + qst.Text + "','" + reponse.Text + "','" + note.Text + "')  ", conn);
                commande.ExecuteNonQuery();
                MessageBox.Show("votre questionnaire crees avec succes");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
