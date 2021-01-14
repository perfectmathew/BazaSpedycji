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
namespace Magazyn_Spedycji
{
    public partial class DodawaniePracownika : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= Database\MagazynSpedycji.accdb");
        public DodawaniePracownika()
        {
            InitializeComponent();
        }
        bool poprawnoc_hasla;
        public void sprawdz_haslo()
        {
            Regex r_haslo = new Regex("^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9]).{8,15}$");
            if (r_haslo.IsMatch(prac_haslo.Text))
            {
                poprawnoc_hasla = true;
            }
        }
        private void dodaj_pracownika_Click(object sender, EventArgs e)  
        {
            sprawdz_haslo();
            Regex r_prac_kodp = new Regex("^[0-9]{2}-[0-9]{3}$");
            Regex r_prac_tele = new Regex("^[1-9]{3}-[0-9]{3}-[0-9]{3}$");
            if (!r_prac_kodp.IsMatch(prac_kodpocz.Text)|| !r_prac_tele.IsMatch(prac_tele.Text) ||prac_login.Text==""||prac_imie.Text == ""||prac_nazw.Text == ""||prac_tele.Text == ""||prac_miasto.Text == ""|| prac_kodpocz.Text == ""|| prac_haslo.Text == ""|| prac_email.Text==""|| prac_adres.Text=="" || prac_woje.Text == "")
            {
                MessageBox.Show("Brak kompletu informacji!");
            }
            else if (poprawnoc_hasla == false)
            {
                MessageBox.Show("Hasło musi składac się z conajmniej z 8 znakow, 1 dużej litery i cyfry");
            }
            else
            {
                con.Open();
                OleDbCommand check = new OleDbCommand();
                check.Connection = con;
                check.CommandText = "select * from Pracownicy where Login='" + prac_login.Text + "'";
                OleDbDataReader reader = check.ExecuteReader();
                int count = 0;
                while (reader.Read())
                {
                    count = count + 1;
                }
                if (count == 0)
                {
                    string encusr = Encyryption.Encrypt(prac_haslo.Text);
                    OleDbCommand polacz = new OleDbCommand();
                    polacz.Connection = con;
                    string queryDodajPracownika = "insert into Pracownicy(Imie, Nazwisko, Email, Telefon, Adres, Miasto, Wojewodztwo, KodPocztowy, Login, Haslo, Rola) values('" + prac_imie.Text + "','" + prac_nazw.Text + "','" + prac_email.Text + "','" + prac_tele.Text + "','" + prac_adres.Text + "','" + prac_miasto.Text + "','" + prac_woje.Text + "','" + prac_kodpocz.Text + "','" + prac_login.Text + "','" + encusr + "', "+1+")";
                    polacz.CommandText = queryDodajPracownika;
                    polacz.ExecuteNonQuery();
                    MessageBox.Show("Dodano nowego pracownika");
                    this.Close();
                }
                else { MessageBox.Show("Użytkownik o podanym loginie już istnieje!");  }
                con.Close();
            }
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                prac_haslo.UseSystemPasswordChar = false;
            }
            else if (checkBox1.Checked == false)
            {
                prac_haslo.UseSystemPasswordChar = true;
            }
         
        }
        private void DodawaniePracownika_Load(object sender, EventArgs e)
        {
            prac_haslo.UseSystemPasswordChar = true;
            poprawnoc_hasla = false;
        }
    }
}
