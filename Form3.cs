using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windowsform
{
    public partial class Form3 : Form
    {
        DB d = new DB();    
        public Form3()
        {
            InitializeComponent();
            btnprop1.Checked = true;
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            d.bc = new OleDbCommandBuilder(d.dap);
            d.dap.Update(d.ds, "QSM");
            MessageBox.Show("les donnes enregister avec succes");

            if (btnprop1.Checked == true)
            {
                MessageBox.Show("vous avez selectionner la proposition 1!!");
                return;
            }
            else if(btnprop2.Checked == true)
            {
                MessageBox.Show("vous avez selectionner la proposition 2!");
                return;
            }
            else if (btnprop3.Checked == true)
            {
                MessageBox.Show("vous avez selectionner la proposition 3!");
                return;
            }
            else 
            {
                MessageBox.Show("vous avez selectionner la proposition 4!");
                return;
            }
        }

        private void btnSuivant_Click(object sender, EventArgs e)
        {
            cnx.Open();
            cmd.Connection = cnx;
            cmd.CommandText = "insert into QCM( Question) values('" + txtQuestion.Text + ") ";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "insert into Proposition( Proposition1) values('" + txtProposition1.Text + ") ";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "insert into Proposition( Proposition2) values('" + txtProposition2.Text + ") ";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "insert into Proposition( Proposition2) values('" + txtProposition3.Text + ") ";
            cmd.ExecuteNonQuery();
            cnx.Close();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            cnx.Close();
        }
    }
}
