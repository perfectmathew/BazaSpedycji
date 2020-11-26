using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
namespace Magazyn_Spedycji
{
    public partial class SingUp : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\Users\Perfectamthew\Documents\MagazynSpedycji.accdb");
        public SingUp()
        {
            InitializeComponent();
        }

        private void SingUpButton_Click(object sender, EventArgs e)
        {

            if (FirstName.Text == "" || SurrName.Text == "" || mail.Text == "" || Login.Text == "" || Pass.Text == "")
            {
                MessageBox.Show("Fill all fields to add the user!");
            }
            else
            {
                OleDbCommand chcek = new OleDbCommand();
                try
                {
                    con.Open();
                    OleDbCommand check = new OleDbCommand();
                    check.Connection = con;
                    check.CommandText ="select * from Klienci where Login='"+Login.Text+"'";
                    OleDbDataReader reader = check.ExecuteReader();
                    int count = 0;
                    while (reader.Read())
                    {
                        count = count + 1;
                    }
                    if (count == 0)
                    {
                        OleDbCommand cmd = new OleDbCommand();
                        cmd.Connection = con;
                        cmd.CommandText = "INSERT INTO Klienci(Imie,Nazwisko,Email,Login,Haslo) values('" + FirstName.Text + "','" + SurrName.Text + "','" + mail.Text + "','" + Login.Text + "','" + Pass.Text + "') ";
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("User added successful!");
                        this.Hide();
                    }
                    else MessageBox.Show("Error! User is already in our database!");
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unexcpected Error: " + ex);
                }
            }
          
           

        }

        private void PassSwitch_CheckedChanged(object sender, EventArgs e)
        {
            if (PassSwitch.Checked)
            {
                Pass.UseSystemPasswordChar = false;
            }
            else Pass.UseSystemPasswordChar = true;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
