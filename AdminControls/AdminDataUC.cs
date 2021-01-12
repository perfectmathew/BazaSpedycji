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
namespace Magazyn_Spedycji.AdminControls
{
    public partial class edit_data : Form
    {
        bool poprawne = false;
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\Users\Perfectamthew\Documents\GitHub\BazaSpedycji\Database\MagazynSpedycji.accdb");
        string AdminValue;
        string imieKlienta;
        string nazwiskoKlienta;
        string EmailKlienta;
        string telefonKlienta;
        string adresKlienta;
        string miastoKlienta;
        string wojewodztwoKlienta;
        string kodpocztowyKlienta;
        string loginKlienta;
        string hasloKlienta;
        public edit_data()
        {
            InitializeComponent();
        }
        public void AdminCon(string value)
        {
            AdminValue = value.ToString();
        }
        private void CheckData()
        {
            Regex phone = new Regex(@"^[1-9]{3}-[0-9]{3}-[0-9]{3}$");
            Regex email = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Regex Postal = new Regex(@"^[0-9]{2}-[0-9]{3}$");
            if (!phone.IsMatch(TelefonBox.Text) || !email.IsMatch(EmailBox.Text) || !Postal.IsMatch(KodBox.Text) || ImieBox.Text == "" || NazwiskoBox.Text == "" || EmailBox.Text == "" || TelefonBox.Text == "" || AdresBox.Text == "" || MiastoBox.Text == "" || WojewodztwoBox.Text == "" || KodBox.Text == "" || LoginBox.Text == "" || hasloBox.Text == "")
            {
                MessageBox.Show("Błąd kompletu informacji!");
                poprawne = false;
            }
            else { poprawne = true; }
        }
        private void GetData()
        {
            con.Open();
            OleDbCommand getImie = new OleDbCommand();
            getImie.Connection = con;
            getImie.CommandText = "Select Imie FROM Pracownicy WHERE ID=" + AdminValue;
            imieKlienta = getImie.ExecuteScalar().ToString();
            OleDbCommand getNazwisko = new OleDbCommand();
            getNazwisko.Connection = con;
            getNazwisko.CommandText = "Select Nazwisko FROM Pracownicy WHERE ID=" + AdminValue;
            nazwiskoKlienta = getNazwisko.ExecuteScalar().ToString();
            OleDbCommand getEmail = new OleDbCommand();
            getEmail.Connection = con;
            getEmail.CommandText = "Select Email FROM Pracownicy WHERE ID=" + AdminValue;
            EmailKlienta = getEmail.ExecuteScalar().ToString();
            OleDbCommand getTelefon = new OleDbCommand();
            getTelefon.Connection = con;
            getTelefon.CommandText = "Select Telefon FROM Pracownicy WHERE ID=" + AdminValue;
            telefonKlienta = getTelefon.ExecuteScalar().ToString();
            OleDbCommand getAdres = new OleDbCommand();
            getAdres.Connection = con;
            getAdres.CommandText = "Select Adres FROM Pracownicy WHERE ID=" + AdminValue;
            adresKlienta = getAdres.ExecuteScalar().ToString();
            OleDbCommand getMiasto = new OleDbCommand();
            getMiasto.Connection = con;
            getMiasto.CommandText = "Select Miasto FROM Pracownicy WHERE ID=" + AdminValue;
            miastoKlienta = getMiasto.ExecuteScalar().ToString();
            OleDbCommand getWoj = new OleDbCommand();
            getWoj.Connection = con;
            getWoj.CommandText = "Select Wojewodztwo FROM Pracownicy WHERE ID=" + AdminValue;
            wojewodztwoKlienta = getWoj.ExecuteScalar().ToString();
            OleDbCommand getPostal = new OleDbCommand();
            getPostal.Connection = con;
            getPostal.CommandText = "Select KodPocztowy FROM Pracownicy WHERE ID=" + AdminValue;
            kodpocztowyKlienta = getPostal.ExecuteScalar().ToString();
            OleDbCommand getLogin = new OleDbCommand();
            getLogin.Connection = con;
            getLogin.CommandText = "Select Login FROM Pracownicy WHERE ID=" + AdminValue;
            loginKlienta = getLogin.ExecuteScalar().ToString();
            OleDbCommand getHaslo = new OleDbCommand();
            getHaslo.Connection = con;
            getHaslo.CommandText = "Select Haslo FROM Pracownicy WHERE ID=" + AdminValue;
            hasloKlienta = getHaslo.ExecuteScalar().ToString().Trim();
            con.Close();
            ImieBox.Text = imieKlienta;
            NazwiskoBox.Text = nazwiskoKlienta;
            EmailBox.Text = EmailKlienta;
            TelefonBox.Text = telefonKlienta;
            AdresBox.Text = adresKlienta;
            MiastoBox.Text = miastoKlienta;
            WojewodztwoBox.Text = wojewodztwoKlienta;
            KodBox.Text = kodpocztowyKlienta;
            LoginBox.Text = loginKlienta;
            string decusr = Encyryption.Decrypt(hasloKlienta);
            hasloBox.Text = decusr;
        }
        private void EditData_Click(object sender, EventArgs e)
        {
            CheckData();
            if (poprawne == true)
            {
                con.Open();
                OleDbCommand check = new OleDbCommand();
                check.Connection = con;
                check.CommandText = "SELECT Login FROM Pracownicy WHERE ID=" + AdminValue;
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
                    string queryEdycja = "update Pracownicy set Imie='" + ImieBox.Text + "', Nazwisko='" + NazwiskoBox.Text + "', Telefon='" + TelefonBox.Text + "', Adres='" + AdresBox.Text + "', Miasto='" + MiastoBox.Text + "', Wojewodztwo='" + WojewodztwoBox.Text + "', KodPocztowy='" + KodBox.Text + "', Login='" + LoginBox.Text + "', Haslo='" + encusr + "' where ID=" + AdminValue;
                    editUser.CommandText = queryEdycja;
                    editUser.ExecuteNonQuery();
                    MessageBox.Show("Pomyślnie zmieniono dane!");
                }
                else if (count == 1)
                {
                    OleDbCommand checkr = new OleDbCommand();
                    checkr.Connection = con;
                    checkr.CommandText = "SELECT Login FROM Pracownicy WHERE ID=" + AdminValue;
                    string tmpLogin = checkr.ExecuteScalar().ToString();
                    if (tmpLogin == LoginBox.Text)
                    {
                        OleDbCommand editUser = new OleDbCommand();
                        editUser.Connection = con;
                        string queryEdycja = "update Pracownicy set Imie='" + ImieBox.Text + "', Nazwisko='" + NazwiskoBox.Text + "', Telefon='" + TelefonBox.Text + "', Adres='" + AdresBox.Text + "', Miasto='" + MiastoBox.Text + "', Wojewodztwo='" + WojewodztwoBox.Text + "', KodPocztowy='" + KodBox.Text + "', Login='" + LoginBox.Text + "', Haslo='" + encusr + "' where ID=" + AdminValue;
                        editUser.CommandText = queryEdycja;
                        editUser.ExecuteNonQuery();
                        MessageBox.Show("Pomyślnie zmieniono dane!");
                    }
                    else MessageBox.Show("Istnieje już Użytkownik o podanym loginie w naszej bazie!");
                }
          
                else MessageBox.Show("Istnieje już Użytkownik o podanym loginie w naszej bazie!");
 
                con.Close();
                GetData();
                this.Close();
            }
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                hasloBox.UseSystemPasswordChar = false;
            } else if (checkBox1.Checked == false) { hasloBox.UseSystemPasswordChar = true; }
        }
        private void edit_data_Load(object sender, EventArgs e)
        {
            GetData();
        }
    }
}
