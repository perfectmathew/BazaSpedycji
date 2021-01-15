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
using System.IO;
using AESCrypto;
namespace Magazyn_Spedycji
{
  
    public partial class MagazynSpedycji : Form
    {      
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= Database\MagazynSpedycji.accdb");
        private void hideloginelement()
        {
     
            label1.Hide();
            label2.Hide();
            label3.Hide();
            loginString.Hide();
            login_register.Hide();
            register_password.Hide();
            PasswordReval.Hide();
            UserAccessL.Hide();
            LoginButton.Hide();
        }
        private void showloginelement()
        {
            label1.Show();
            label2.Show();
            label3.Show();
            loginString.Show();
            login_register.Show();
            register_password.Show();
            PasswordReval.Show();
            UserAccessL.Show();
            LoginButton.Show();
        }
        public MagazynSpedycji()
        {
            InitializeComponent();
            RegisterPanel.Hide();
            hideloginelement();
        }
        private void button1_Click(object sender, EventArgs e)
        {

           if (UserAccessL.SelectedIndex == -1)
            {
                MessageBox.Show("Wybierz poziom uprawnień!");
            }
            if (UserAccessL.SelectedIndex == 0)
            {
                con.Open();
             
                string encusr = Encyryption.Encrypt(register_password.Text);
                OleDbCommand command = new OleDbCommand();
                command.Connection = con;
                command.CommandText = "select * from Pracownicy where Login='" + login_register.Text + "' and Haslo='" + encusr + "'";
                OleDbDataReader reader = command.ExecuteReader();
                int count = 0;
                while (reader.Read())
                {
                    count = count + 1;
                }
                if (count == 1)
                {
                    OleDbCommand Admin = new OleDbCommand();
                    Admin.Connection = con;
                    Admin.CommandText = "select ID from Pracownicy where Login='" + login_register.Text + "' and Haslo='" + encusr + "'";
                    Int32 IDK = (Int32)Admin.ExecuteScalar();
                    this.Hide();
                    AdminPanel admin = new AdminPanel();
                    admin.AdminCondiciont(IDK.ToString());
                    admin.ShowDialog();
                    admin = null;
                    this.Show(); ;
                }
             else
                {
                    MessageBox.Show("Nieprawidłowy login lub hasło!");
                }
                con.Close();
            }
            if (UserAccessL.SelectedIndex == 1)
            {
                con.Open();
                string encusr = Encyryption.Encrypt(register_password.Text);
                OleDbCommand command = new OleDbCommand();
                command.Connection = con;
                command.CommandText = "select * from Klienci where Login='" + login_register.Text + "' and Haslo='" + encusr+ "'";
                OleDbDataReader reader = command.ExecuteReader();
                int count = 0;
                while (reader.Read())
                {
                    count = count + 1;
                }
                if (count == 1)
                {
                    OleDbCommand newcarrier = new OleDbCommand();
                    newcarrier.Connection = con;
                    newcarrier.CommandText = "select ID from Klienci where Login='" + login_register.Text + "' and Haslo='" + encusr + "'";
                    Int32 IDK = (Int32)newcarrier.ExecuteScalar();
                    this.Hide();
                    UserPanel user = new UserPanel();
                   user.UserCondiction(IDK.ToString());
                    user.ShowDialog();
                    user = null;
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Nieprawidłowy login lub hasło!");
                }
                con.Close();

            }
            if (UserAccessL.SelectedIndex == 2)
            {
                con.Open();
                string encusr = Encyryption.Encrypt(register_password.Text);
                OleDbCommand command = new OleDbCommand();
                command.Connection = con;
                command.CommandText = "select * from Spedytorzy where Login='" + login_register.Text + "' and Haslo='" + encusr + "'";
                OleDbDataReader reader = command.ExecuteReader();
                int count = 0;
                while (reader.Read())
                {

                    count = count + 1;

                }
                if (count == 1)
                {
                    OleDbCommand newcarrier = new OleDbCommand();
                    newcarrier.Connection = con;
                    newcarrier.CommandText = "select ID from Spedytorzy where Login='" + login_register.Text + "' and Haslo='" + encusr + "'";
                    Int32 IDK = (Int32)newcarrier.ExecuteScalar();
                    this.Hide();
                    CarrierPanel carrier = new CarrierPanel();
                    carrier.ab(IDK.ToString());
                    carrier.ShowDialog();
                    carrier = null;
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Nieprawidłowy login lub hasło!");
                }
                con.Close();
            }
        }
        private void SingInSwitch_Click(object sender, EventArgs e)
        {
            showloginelement();
            RegisterPanel.Hide();
        }
        private void SingUpSwitch_Click(object sender, EventArgs e)
        {
            hideloginelement();
            RegisterPanel.Show();
            SingUp zarejestruj = new SingUp() {Dock=DockStyle.Fill, TopLevel=false, TopMost=true};
            this.RegisterPanel.Controls.Add(zarejestruj);
            zarejestruj.Show();
        }
        private void PasswordReval_CheckedChanged(object sender, EventArgs e)
        {
            if (PasswordReval.Checked)
            {
                register_password.UseSystemPasswordChar = false;
            }
            else register_password.UseSystemPasswordChar = true;
        }
        private void Info_Click(object sender, EventArgs e)
        {
            MessageBox.Show("| Aplikacja stworzona dla Secret Shopping. |\n| Autorzy: Mateusz Wróblewski, Kacper Wojnarowski |");
        }
        private void Help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Masz pytania? Pisz do nas śmiało na kontakt@secretshopping.app!");
        }
    
    }
}
