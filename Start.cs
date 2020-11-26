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
     
        private AdminPanel adminPanel;
        private CarrierPanel carrierPanel;
        private UserPanel userPanel;
        private SingUp SingUp;
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\Users\Perfectamthew\Documents\MagazynSpedycji.accdb");
        public MagazynSpedycji()
        {
            InitializeComponent();
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
                MessageBox.Show("Please select a user permission level.");
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
                    
                    MessageBox.Show("Welcome to Administration Panel!");
                    this.Hide();

                    AdminPanel adminPanel = new AdminPanel();
                    adminPanel.ShowDialog();
                    adminPanel = null;
                    this.Show();

                }
             else
                {
                    MessageBox.Show("Invalid Login or Password!");
                }
                con.Close();
            }
            if (UserAccessL.SelectedIndex == 1)
            {
                this.Hide();
                var CarrierPanel = new CarrierPanel();
                CarrierPanel.Closed += (s, args) => this.Close();
                CarrierPanel.Show();
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
                command.CommandText = "select * from Klienci where Login='" + login_register.Text + "' and Haslo='" + register_password.Text + "'";
                OleDbDataReader reader = command.ExecuteReader();
                int count = 0;
                while (reader.Read())
                {

                    count = count + 1;

                }
                if (count == 1)
                {
                    this.Hide();

                    UserPanel user = new UserPanel();
                    user.ShowDialog();
                    user = null;
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Invalid Login or Password!");
                }
                con.Close();
            }
        
        }

        private void SingInSwitch_Click(object sender, EventArgs e)
        {
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
