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
using System.Text.RegularExpressions;
using AESCrypto;
namespace Magazyn_Spedycji.USerControls
{
 
    public partial class UserUC : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= Database\MagazynSpedycji.accdb");
        string UserValue;
        string imieKlienta;
        string nazwiskoKlienta;
        string EmailKlienta;
        string telefonKlienta;
        string adresKlienta;
        string miastoKlienta;
        string wojewodztwoKlienta;
        string kodpocztowyKlienta;
        string krajKlienta;
        string loginKlienta;
        string hasloKlienta;
        public UserUC()
        {
            InitializeComponent();
        }
        private void CloseProgram()
        {
            this.Close();  
        }
        public void ab(string LoginValue)
        {
            UserValue = LoginValue.ToString();
        }
        private void getUserData()
        {
            con.Open();
            OleDbCommand getImie = new OleDbCommand();
            getImie.Connection = con;
            getImie.CommandText = "Select Imie FROM Klienci WHERE ID=" + UserValue;
            imieKlienta = getImie.ExecuteScalar().ToString();
            OleDbCommand getNazwisko = new OleDbCommand();
            getNazwisko.Connection = con;
            getNazwisko.CommandText = "Select Nazwisko FROM Klienci WHERE ID=" + UserValue;
            nazwiskoKlienta = getNazwisko.ExecuteScalar().ToString();
            OleDbCommand getEmail = new OleDbCommand();
            getEmail.Connection = con;
            getEmail.CommandText = "Select Email FROM Klienci WHERE ID=" + UserValue;
            EmailKlienta = getEmail.ExecuteScalar().ToString();
            OleDbCommand getTelefon = new OleDbCommand();
            getTelefon.Connection = con;
            getTelefon.CommandText = "Select Telefon FROM Klienci WHERE ID=" + UserValue;
            telefonKlienta = getTelefon.ExecuteScalar().ToString();
            OleDbCommand getAdres = new OleDbCommand();
            getAdres.Connection = con;
            getAdres.CommandText = "Select Adres FROM Klienci WHERE ID=" + UserValue;
            adresKlienta = getAdres.ExecuteScalar().ToString();
            OleDbCommand getMiasto = new OleDbCommand();
            getMiasto.Connection = con;
            getMiasto.CommandText = "Select Miasto FROM Klienci WHERE ID=" + UserValue;
            miastoKlienta = getMiasto.ExecuteScalar().ToString();
            OleDbCommand getWoj = new OleDbCommand();
            getWoj.Connection = con;
            getWoj.CommandText = "Select Wojewodztwo FROM Klienci WHERE ID=" + UserValue;
            wojewodztwoKlienta = getWoj.ExecuteScalar().ToString();
            OleDbCommand getPostal = new OleDbCommand();
            getPostal.Connection = con;
            getPostal.CommandText = "Select KodPocztowy FROM Klienci WHERE ID=" + UserValue;
            kodpocztowyKlienta = getPostal.ExecuteScalar().ToString();
            OleDbCommand getKraj = new OleDbCommand();
            getKraj.Connection = con;
            getKraj.CommandText = "Select Kraj FROM Klienci WHERE ID=" + UserValue;
            krajKlienta = getKraj.ExecuteScalar().ToString();
            OleDbCommand getLogin = new OleDbCommand();
            getLogin.Connection = con;
            getLogin.CommandText = "Select Login FROM Klienci WHERE ID=" + UserValue;
            loginKlienta = getLogin.ExecuteScalar().ToString();
            OleDbCommand getHaslo = new OleDbCommand();
            getHaslo.Connection = con;
            getHaslo.CommandText = "Select Haslo FROM Klienci WHERE ID=" + UserValue;
            hasloKlienta = getHaslo.ExecuteScalar().ToString();
            con.Close();
            ImieBox.Text = imieKlienta;
            NazwiskoBox.Text = nazwiskoKlienta;
            EmailBox.Text = EmailKlienta;
            TelefonBox.Text = telefonKlienta;
            AdresBox.Text = adresKlienta;
            MiastoBox.Text = miastoKlienta;
            WojewodztwoBox.Text = wojewodztwoKlienta;
            KodBox.Text = kodpocztowyKlienta;
            KrajBox.Text = krajKlienta;
            LoginBox.Text = loginKlienta;
            string decusr = Encyryption.Decrypt(hasloKlienta);
            hasloBox.Text = decusr;
            label3.Text = "Witaj, " + imieKlienta + "!";
        }
        bool poprawne = false;
        private void CheckUserData()
        {
            Regex phone = new Regex(@"^[0-9]{3}-[0-9]{3}-[0-9]{3}$");
            Regex email = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Regex Postal = new Regex(@"^[0-9]{2}-[0-9]{3}$");
            if (!phone.IsMatch(TelefonBox.Text) || !email.IsMatch(EmailBox.Text) || !Postal.IsMatch(KodBox.Text) || ImieBox.Text=="" || NazwiskoBox.Text==""|| EmailBox.Text=="" || TelefonBox.Text == "" || AdresBox.Text=="" || MiastoBox.Text=="" || WojewodztwoBox.Text==""|| KodBox.Text=="" || KrajBox.Text=="" || LoginBox.Text=="" || hasloBox.Text=="")
            {
                MessageBox.Show("Błąd kompletu informacji!");
                poprawne = false;
            }
            else { poprawne = true; }
        }
        private void changeUserData_Click(object sender, EventArgs e)
        {
            CheckUserData();
            if (poprawne == true)
            {
                con.Open();
                OleDbCommand check = new OleDbCommand();
                check.Connection = con;
                check.CommandText = "SELECT Login FROM Klienci WHERE ID=" + UserValue;
                OleDbDataReader reader = check.ExecuteReader();
                int count = 0;
                while (reader.Read())
                {
                    count = count + 1;
                }
                string encusr = Encyryption.Encrypt(hasloBox.Text);
                if (count == 0)
                {
                    OleDbCommand editUser = new OleDbCommand();
                    editUser.Connection = con;
                    string queryEdycja = "update Klienci set Imie='" + ImieBox.Text + "', Nazwisko='" + NazwiskoBox.Text + "', Telefon='" + TelefonBox.Text + "', Adres='" + AdresBox.Text + "', Miasto='" + MiastoBox.Text + "', Wojewodztwo='" + WojewodztwoBox.Text + "', KodPocztowy='" + KodBox.Text + "', Kraj='" + KrajBox.Text + "', Login='" + LoginBox.Text + "', Haslo='" + encusr + "' where ID=" + UserValue;
                    editUser.CommandText = queryEdycja;
                    editUser.ExecuteNonQuery();
                    MessageBox.Show("Pomyślnie zmieniono dane!");
                }
                else if (count == 1)
                {
                    OleDbCommand checkr = new OleDbCommand();
                    checkr.Connection = con;
                    checkr.CommandText = "SELECT Login FROM Klienci WHERE ID=" + UserValue;
                    string tmpLogin = checkr.ExecuteScalar().ToString();
                    if (tmpLogin == LoginBox.Text)
                    {
                        OleDbCommand editUser = new OleDbCommand();
                        editUser.Connection = con;
                        string queryEdycja = "update Klienci set Imie='" + ImieBox.Text + "', Nazwisko='" + NazwiskoBox.Text + "', Telefon='" + TelefonBox.Text + "', Adres='" + AdresBox.Text + "', Miasto='" + MiastoBox.Text + "', Wojewodztwo='" + WojewodztwoBox.Text + "', KodPocztowy='" + KodBox.Text + "', Kraj='" + KrajBox.Text + "', Login='" + LoginBox.Text + "', Haslo='" + encusr + "' where ID=" + UserValue;
                        editUser.CommandText = queryEdycja;
                        editUser.ExecuteNonQuery();
                        MessageBox.Show("Pomyślnie zmieniono dane!");
                    }
                    else MessageBox.Show("Istnieje już Użytkownik o podanym loginie w naszej bazie!");
                }
                else MessageBox.Show("Istnieje już Użytkownik o podanym loginie w naszej bazie!"); 

                con.Close();
                getUserData();
            }
            else
            {

            }   
        }
        private void UserUC_Load(object sender, EventArgs e)
        {
            getUserData();
        }
        private void Delete_Account_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Czy napewno chcesz usunąć wszystkie dane z naszej aplikacji? !UWAGA! Usunie to wszystkie twoje dane oraz zamówienia, oraz odbierze cie mozliwość ponownego zalogowania do aplikacji!", "Potwierdzenie", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                con.Open();
                OleDbCommand checker = new OleDbCommand();
                checker.Connection = con;
                checker.CommandText = "SELECT IdZamowienia FROM SzczegolyZamowienia WHERE IdKlienta=" + UserValue + "";
                OleDbDataReader reader = checker.ExecuteReader();
                int count = 0;
                while (reader.Read())
                {
                    count = count + 1;
                } reader.Close();
                if (count >= 1)
                {
                    OleDbCommand DeleteSZZamowienia = new OleDbCommand();
                    DeleteSZZamowienia.Connection = con;
                    string querySZ = "DELETE * FROM SzczegolyZamowienia WHERE IdKlienta=" + UserValue + "";
                    DeleteSZZamowienia.CommandText = querySZ;
                    DeleteSZZamowienia.ExecuteNonQuery();
                    OleDbCommand DeleteZamowienia = new OleDbCommand();
                    DeleteZamowienia.Connection = con;
                    string queryD = "DELETE * FROM Zamowienia WHERE IdKlienta=" + UserValue + "";
                    DeleteZamowienia.CommandText = queryD;
                    DeleteZamowienia.ExecuteNonQuery();
                    OleDbCommand DeleteUser = new OleDbCommand();
                    DeleteUser.Connection = con;
                    string queryDU = "DELETE * FROM Klienci WHERE ID=" + UserValue + "";
                    DeleteUser.CommandText = queryDU;
                    DeleteUser.ExecuteNonQuery();
                }
                else { MessageBox.Show("ERROR"); }
                con.Close();
                CloseProgram();
                
            }
            else if (result == DialogResult.No)
            {
             
            }
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                hasloBox.UseSystemPasswordChar = false;
            }
            else if (checkBox1.Checked == false)
            {
                hasloBox.UseSystemPasswordChar = true;
            }
        }
    }
}
