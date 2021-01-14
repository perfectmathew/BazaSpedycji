using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.OleDb;
using AESCrypto;
namespace Magazyn_Spedycji
{
    public partial class DodawanieSpedytora : Form
    {

        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= Database\MagazynSpedycji.accdb");
        bool poprawne=false;
        public DodawanieSpedytora()
        {
            InitializeComponent();
        }    
        public void sprawdz_poprawnosc()
        {

            Regex r_spedy_tele = new Regex("^[1-9]{3}-[0-9]{3}-[0-9]{3}$");
            Regex email = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            if (imie_spedy.Text == "" || firma_spedy.Text == "" || nazwi_spedy.Text == "" || email_spedy.Text == "" || login_spedy.Text == "" || haslo_spedy.Text == "")
            {
                MessageBox.Show("Brak kompletu informacji!");

            }
            else if (!r_spedy_tele.IsMatch(tele_spedy.Text) || !email.IsMatch(email_spedy.Text))
            {
                MessageBox.Show("Niewlasciwe dane w polu!");
            }
            else
            {
                poprawne = true;
            }

        }  
        private void dodaj_spedy_Click(object sender, EventArgs e)
        {
            sprawdz_poprawnosc();
            if (poprawne == true)
        {
                
                con.Open();
                OleDbCommand checker = new OleDbCommand();
                checker.Connection = con;
                checker.CommandText = "SELECT ID FROM Spedytorzy WHERE Login='" + login_spedy.Text + "'";
                OleDbDataReader reader = checker.ExecuteReader();
                int count = 0;
                while (reader.Read())
                {
                    count = count + 1;
                }
                if (count == 1)
                {
                    MessageBox.Show("Spedytor o podanym loginie już istnieje!");
                }
                else
                {
                    string encusr = Encyryption.Encrypt(haslo_spedy.Text);
                    OleDbCommand laczenie = new OleDbCommand();
                    laczenie.Connection = con;
                    string queryDodaj = "insert into Spedytorzy(Firma, Imie, Nazwisko, Email, Telefon, Login, Haslo) values('" + firma_spedy.Text + "','" + imie_spedy.Text + "','" + nazwi_spedy.Text + "','" + email_spedy.Text + "','" + tele_spedy.Text + "','" + login_spedy.Text + "','" + encusr + "')";
                    laczenie.CommandText = queryDodaj;
                    laczenie.ExecuteNonQuery();
                    MessageBox.Show("Dodano nowego spedytora!");
                    con.Close();
                    this.Close();
                } 
            }
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                haslo_spedy.UseSystemPasswordChar = false;
            }
            else if (checkBox1.Checked == false)
            {
                haslo_spedy.UseSystemPasswordChar = true;
            }
        }
    }
}
