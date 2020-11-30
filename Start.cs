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
  
    public partial class MagazynSpedycji : Form
    {
     //   string LoginValue;
        private AdminPanel adminPanel;
        private CarrierPanel carrierPanel;
        private UserPanel userPanel;
        private SingUp SingUp;
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\Users\Perfectamthew\Documents\MagazynSpedycji.accdb");
        public MagazynSpedycji()
        {
            InitializeComponent();
            label1.Hide();
            label2.Hide();
            label3.Hide();
            loginString.Hide();
            login_register.Hide();
            register_password.Hide();
            UserAccessL.Hide();
            LoginButton.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        
            //SingUp.Hide();
            if (UserAccessL.SelectedIndex == -1)
            {
                MessageBox.Show("Wybierz poziom uprawnień!");
            }
            if (UserAccessL.SelectedIndex == 0)
            {
                //kod na wejście do innych formularzy 
                con.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = con;
                command.CommandText = "select * from Pracownicy where Login='" + login_register.Text + "' and Haslo='" + register_password.Text + "'";
                OleDbDataReader reader = command.ExecuteReader();
                int count = 0;
                while (reader.Read())
                {
                    count = count + 1;
                }
                if (count == 1)
                {
                    
                    MessageBox.Show("Witamy w panelu administracyjnym!");
                    this.Hide();

                    AdminPanel adminPanel = new AdminPanel();
                    adminPanel.ShowDialog();
                    adminPanel = null;
                    this.Show();

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
                OleDbCommand command = new OleDbCommand();
                command.Connection = con;
                command.CommandText = "select * from Spedytorzy where Login='" + login_register.Text + "' and Haslo='" + register_password.Text + "'";
                OleDbDataReader reader = command.ExecuteReader();
                int count = 0;
                while (reader.Read())
                {

                    count = count + 1;

                }
                if (count == 1)
                {
                   // LoginValue = login_register.Text;
                    this.Hide();
                    CarrierPanel carrierPanel = new CarrierPanel();
                  //  carrierPanel.ab(LoginValue.ToString());
                    carrierPanel.ShowDialog();
                   
                    carrierPanel = null;
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
                /*  this.Hide();
                  var UserPanel = new UserPanel();
                  UserPanel.Closed += (s, args) => this.Close();
                  UserPanel.Show();*/
               
                con.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = con;
                command.CommandText = "select ID from Klienci where Login='" + login_register.Text + "' and Haslo='" + register_password.Text + "'";
                OleDbDataReader reader = command.ExecuteReader();
      
             

                int count = 0;
                while (reader.Read())
                {
                    
                    count = count + 1;

                }
                if (count == 1)
                {
                    OleDbCommand newclient = new OleDbCommand();
                    newclient.Connection = con;
                    newclient.CommandText = "select ID from Klienci where Login='" + login_register.Text + "' and Haslo='" + register_password.Text + "'";
                    Int32 IDK = (Int32)newclient.ExecuteScalar();
                    this.Hide();

         
                    UserPanel user = new UserPanel();
                  user.ab(IDK.ToString());
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
        
        }

        private void SingInSwitch_Click(object sender, EventArgs e)
        {
            label1.Show();
            label2.Show();
            label3.Show();
            loginString.Show();
            login_register.Show();
            register_password.Show();
            UserAccessL.Show();
            LoginButton.Show();
        }

        private void SingUpSwitch_Click(object sender, EventArgs e)
        {

            this.Hide();

            SingUp singUp = new SingUp();
            singUp.ShowDialog();
            singUp = null;
            this.Show();
        }

        private void MagazynSpedycji_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'magazynSpedycjiDataSet.Klienci' . Możesz go przenieść lub usunąć.
       

        }

        private void DevButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            AdminPanel adminPanel = new AdminPanel();
            adminPanel.ShowDialog();
            adminPanel = null;
            this.Show();
        }
    }
}
