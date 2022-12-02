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

namespace windowsform
{
    
    public partial class Form2 : Form
    {
        SqlConnection conn=new SqlConnection("Data Source = desktop - c75hheu\\sqlexpress; Initial Catalog = exam; Integrated Security = True");
        SqlCommand commande = new SqlCommand();
        public Form2()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            
        }

       

        private void btnSuivant_Click(object sender, EventArgs e)

        {
           // SqlConnection conn = new SqlConnection("Data Source = desktop - c75hheu\\sqlexpress; Initial Catalog = exam; Integrated Security = True");
            //conn.Open();
            string bt = "";
            if (rbqsm.Checked == true)
            {
                bt = rbqsm.Text;
                var Form2 = new Form3();
                Form2.Show();
            }
            else
            {
                bt = rbquestion.Text;
                var Form2 = new Form4();
                Form2.Show();

            }
            //SqlCommand commande = new SqlCommand("insert into exam(date-debut,datefin,tentative,nbr-etudiant,type-exame) values('" + datedebut.Text + "','" + datefin.Text + "','" + tentative.Text + "','" + nbretudiant.Text + "','" + bt + "')  ", conn);
            //commande.ExecuteNonQuery();


        }


        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
          
        }

        private void rbqsm_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void rbquestion_CheckedChanged(object sender, EventArgs e)
        {
           
        }
    }
}
