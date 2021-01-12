using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Data.OleDb;
using AESCrypto;
namespace Magazyn_Spedycji.USerControls
{
  
    public partial class CarrierUC : Form
    {
     
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\Users\Perfectamthew\Documents\GitHub\BazaSpedycji\Database\MagazynSpedycji.accdb");
        string CarrierValue;
        string imieSpedytora;
        string nazwiskoSpedytora;
        string EmailSpedytora;
        string TelefonSpedytora;
        string LoginSpedytora;
        string HasloSpedytora; 
        public void getData()
        {
            con.Open();
            OleDbCommand getImie = new OleDbCommand();
            getImie.Connection = con;
            getImie.CommandText = "Select Imie FROM Spedytorzy WHERE ID=" + CarrierValue;
            imieSpedytora = (string)getImie.ExecuteScalar();
            OleDbCommand getNazwisko = new OleDbCommand();
            getNazwisko.Connection = con;
            getNazwisko.CommandText = "Select Nazwisko FROM Spedytorzy WHERE ID=" + CarrierValue;
            nazwiskoSpedytora = (string)getNazwisko.ExecuteScalar();
            OleDbCommand getEmail = new OleDbCommand();
            getEmail.Connection = con;
            getEmail.CommandText = "Select Email FROM Spedytorzy WHERE ID=" + CarrierValue;
            EmailSpedytora = (string)getEmail.ExecuteScalar();
            OleDbCommand getTelefon = new OleDbCommand();
            getTelefon.Connection = con;
            getTelefon.CommandText = "Select Telefon FROM Spedytorzy WHERE ID=" + CarrierValue;
            TelefonSpedytora = (string)getTelefon.ExecuteScalar();
            OleDbCommand getLogin = new OleDbCommand();
            getLogin.Connection = con;
            getLogin.CommandText = "Select Login FROM Spedytorzy WHERE ID=" + CarrierValue;
            LoginSpedytora = (string)getLogin.ExecuteScalar();
            OleDbCommand getHaslo = new OleDbCommand();
            getHaslo.Connection = con;
            getHaslo.CommandText = "Select Haslo FROM Spedytorzy WHERE ID=" + CarrierValue;
            HasloSpedytora = (string)getHaslo.ExecuteScalar();
            con.Close();
            NameText.Text = imieSpedytora;
            SurrnameText.Text = nazwiskoSpedytora;
            EmailText.Text = EmailSpedytora;
            PhoneText.Text = TelefonSpedytora;
            LoginText.Text = LoginSpedytora;
            string decusr = Encyryption.Decrypt(HasloSpedytora);
            PassText.Text = decusr;
        }
        public CarrierUC()
        {
            InitializeComponent();
        }
        public void next(string LoginValue)
        {
            CarrierValue = LoginValue.ToString();
        }
        private void UpdateCarrirerData_Click(object sender, EventArgs e)
        {
            Regex phone = new Regex(@"^[0-9]{3}-[0-9]{3}-[0-9]{3}$");
            Regex email = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            if (!email.IsMatch(EmailText.Text) || !phone.IsMatch(PhoneText.Text) || NameText.Text=="" || SurrnameText.Text=="" || EmailText.Text=="" || PhoneText.Text=="" || LoginText.Text=="" || PassText.Text=="")
            {
                MessageBox.Show("Podałeś niepoprawne dane!");
            }else
            {
                con.Open();
                OleDbCommand check = new OleDbCommand();
                check.Connection = con;
                check.CommandText = "SELECT Login FROM Spedytorzy WHERE ID=" + CarrierValue;
                OleDbDataReader reader = check.ExecuteReader();
                int count = 0;
                while (reader.Read())
                {
                    count = count + 1;
                }
                string encusr = Encyryption.Encrypt(PassText.Text);
                if (count == 0)
                {
                    OleDbCommand updater = new OleDbCommand();
                    updater.Connection = con;
                    string query = "UPDATE Spedytorzy SET Imie='" + NameText.Text + "', Nazwisko='" + SurrnameText.Text + "', Email='" + EmailText.Text + "', Telefon='" + PhoneText.Text + "', Login='" + LoginText.Text + "', Haslo='" + encusr + "' WHERE ID=" + CarrierValue;
                    updater.CommandText = query;
                    updater.ExecuteNonQuery();
                    MessageBox.Show("Pomyślnie zaktualizowano dane!");
                }
                else if (count == 1)
                {
                    OleDbCommand checkr = new OleDbCommand();
                    checkr.Connection = con;
                    checkr.CommandText = "SELECT Login FROM Spedytorzy WHERE ID=" + CarrierValue;
                    string tmpLogin = checkr.ExecuteScalar().ToString();
                    if (tmpLogin == LoginText.Text)
                    {
                        OleDbCommand editUser = new OleDbCommand();
                        editUser.Connection = con;
                        string query = "UPDATE Spedytorzy SET Imie='" + NameText.Text + "', Nazwisko='" + SurrnameText.Text + "', Email='" + EmailText.Text + "', Telefon='" + PhoneText.Text + "', Login='" + LoginText.Text + "', Haslo='" + encusr + "' WHERE ID=" + CarrierValue;
                        editUser.CommandText = query;
                        editUser.ExecuteNonQuery();
                        MessageBox.Show("Pomyślnie zmieniono dane!");
                    }
                    else MessageBox.Show("Istnieje już Użytkownik o podanym loginie w naszej bazie!");
                }
                else MessageBox.Show("Istnieje już Użytkownik o podanym loginie w naszej bazie!");
                con.Close();
         
                getData();
            }
        }
        private void CarrierUC_Load(object sender, EventArgs e)
        {
            getData();
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false) PassText.UseSystemPasswordChar = true;
            else if (checkBox1.Checked == true) PassText.UseSystemPasswordChar = false;
        }
    }
}
