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
    
    public partial class Form2 : Form
    {
        static readonly string chaine = "@Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:Users//Hp//Documents//EXAM.accdb";

            static OleDbConnection cnx = new OleDbConnection(chaine);
            static OleDbCommand cmd = new OleDbCommand();
            static OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
        DB d = new DB();
            public Form2()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            // Create a new DateTimePicker control and initialize it.
             DateTimePicker dateTimePicker1 = new DateTimePicker(); 
            //et the MinDate and MaxDate.
                dateTimePicker1.MinDate = new DateTime();
            dateTimePicker1.MaxDate = DateTime.Today; 
          //Set the CustomFormat string.
                dateTimePicker1.CustomFormat = "MMMM dd, yyyy - dddd";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            // Show the CheckBox and display the control as an up-down control.
             dateTimePicker1.ShowCheckBox = true; dateTimePicker1.ShowUpDown = true;
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            // Create a new DateTimePicker control and initialize it.
            DateTimePicker dateTimePicker1 = new DateTimePicker();
            //et the MinDate and MaxDate.
            dateTimePicker1.MinDate = new DateTime();
            dateTimePicker1.MaxDate = DateTime.Today;
            //Set the CustomFormat string.
            dateTimePicker1.CustomFormat = "MMMM dd, yyyy - dddd";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            // Show the CheckBox and display the control as an up-down control.
            dateTimePicker1.ShowCheckBox = true; dateTimePicker1.ShowUpDown = true;
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            
                d.bc = new OleDbCommandBuilder(d.dap);
            d.dap.Update(d.ds, "EXAM");
                MessageBox.Show("les donnes enregister avec succes");
         
        }

        private void btnSuivant_Click(object sender, EventArgs e)
        {

            cnx.Open();
            cmd.Connection = cnx;
            cmd.CommandText = "insert into Examen(Date Debut , Date Fin,)values('" + txtDateDebut.Text + "','" + txtDateFin.Text + "','"+ txttentetive.Text +"','"+ txttypeexam.Text+"');

            if (checkedListBox2.CheckedItems.Count == 1)
            {
                var Form2 = new Form3();
                Form2.ShowDialog();
            }
            else
            {
                var Form2 = new Form4();
                Form2.ShowDialog();
            }
        }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
