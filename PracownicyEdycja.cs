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

namespace Magazyn_Spedycji
{
    public partial class PracownicyEdycja : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\Users\Perfectamthew\Documents\GitHub\BazaSpedycji\Database\MagazynSpedycji.accdb");
        int kolumna = 0;
        bool poprawne = false;
        public PracownicyEdycja()
        {
            InitializeComponent();
        }
        public void odswiez_gridview()
        {
            OleDbCommand createPracownicy = new OleDbCommand();
            createPracownicy.Connection = con;
            string queryPracownicy = "SELECT Uprawnienia.Rola, Pracownicy.Imie, Pracownicy.Nazwisko, Pracownicy.Email, Pracownicy.Telefon, Pracownicy.Adres, Pracownicy.Miasto, Pracownicy.Wojewodztwo, Pracownicy.KodPocztowy, Pracownicy.Login, Pracownicy.Haslo FROM Uprawnienia INNER JOIN Pracownicy ON Uprawnienia.ID = Pracownicy.Rola";
            createPracownicy.CommandText = queryPracownicy;
            OleDbDataAdapter pracownik = new OleDbDataAdapter(createPracownicy);
            DataTable tabelaPracownicy = new DataTable();
            pracownik.Fill(tabelaPracownicy);
            Pracownicy.DataSource = tabelaPracownicy;
        }
        private void PracownicyEdycja_Load(object sender, EventArgs e)
        {
            Pracownicy.Show();
            OleDbCommand createPracownicy = new OleDbCommand();
            createPracownicy.Connection = con;
            string queryPracownicy = "SELECT Uprawnienia.Rola, Pracownicy.Imie, Pracownicy.Nazwisko, Pracownicy.Email, Pracownicy.Telefon, Pracownicy.Adres, Pracownicy.Miasto, Pracownicy.Wojewodztwo, Pracownicy.KodPocztowy, Pracownicy.Login, Pracownicy.Haslo FROM Uprawnienia INNER JOIN Pracownicy ON Uprawnienia.ID = Pracownicy.Rola";
            createPracownicy.CommandText = queryPracownicy;
            OleDbDataAdapter pracownik = new OleDbDataAdapter(createPracownicy);
            DataTable tabelaPracownicy = new DataTable();
            pracownik.Fill(tabelaPracownicy);
            Pracownicy.DataSource = tabelaPracownicy;
            con.Close();


        }
        public void sprawdz_poprawnosc()
        {

            Regex r_prac_kodp = new Regex("^[0-9]{2}-[0-9]{3}$");
            Regex r_prac_tele = new Regex("^[1-9]{3}-[0-9]{3}-[0-9]{3}$");


            if (imie_prac.Text == "" || nazw_prac.Text == "" || adres_prac.Text == "" || miasto_prac.Text == "" || woje_prac.Text == "" || login_prac.Text == "" || haslo_prac.Text == "")
            {
                MessageBox.Show("Brak kompletu informacji!");

            }

            else if (!r_prac_kodp.IsMatch(kodp_prac.Text)||!r_prac_tele.IsMatch(tele_prac.Text))
            {
                MessageBox.Show("Niewlasciwe dane w polu!");
            }
            else
            {
                poprawne = true;
            }
        }
        private void Pracownicy_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            kolumna = e.RowIndex;
            if (kolumna < 0 ) MessageBox.Show("Wybierz produkt!");
            else
            {
                DataGridViewRow kol = Pracownicy.Rows[kolumna];
    
                imie_prac.Text = kol.Cells[1].Value.ToString();
                nazw_prac.Text = kol.Cells[2].Value.ToString();
                email_prac.Text = kol.Cells[3].Value.ToString();
                tele_prac.Text = kol.Cells[4].Value.ToString();
                adres_prac.Text = kol.Cells[5].Value.ToString();
                miasto_prac.Text = kol.Cells[6].Value.ToString();
                woje_prac.Text = kol.Cells[7].Value.ToString();
                kodp_prac.Text = kol.Cells[8].Value.ToString();
                login_prac.Text = kol.Cells[9].Value.ToString();
                haslo_prac.Text = kol.Cells[10].Value.ToString();
            }
        }
        private void edytuj_prac_Click(object sender, EventArgs e)
        {
            sprawdz_poprawnosc();
            if (poprawne == true)
            {
                con.Open();
                OleDbCommand laczenie = new OleDbCommand();
                laczenie.Connection = con;
                string queryEdycja = "UPDATE Pracownicy SET Imie='" + imie_prac.Text + "', Nazwisko='" + nazw_prac.Text + "', Email='" + email_prac.Text + "', Telefon='" + tele_prac.Text + "', Adres='" + adres_prac.Text + "', Miasto='" + miasto_prac.Text + "', Wojewodztwo='" + woje_prac.Text + "', KodPocztowy='" + kodp_prac.Text + "', Login='"+login_prac.Text+"', Haslo='" + haslo_prac.Text + "', Rola="+1+" WHERE Login='"+login_prac.Text+"'";
                laczenie.CommandText = queryEdycja;
                laczenie.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Pomyślnie zaktualizowano dane pracownika");
            }
            odswiez_gridview();
        }
        private void usun_prac_Click(object sender, EventArgs e)
        {
            if (login_prac.Text == "")
            {
                MessageBox.Show("Najpierw wybierz pracownika!");
            }
            else
            {
                DialogResult result = MessageBox.Show("Czy na pewno chcesz usunąć tego pracownika?", "Uwaga!", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    con.Open();
                    OleDbCommand laczenie = new OleDbCommand();
                    laczenie.Connection = con;
                    string queryUsun = "Delete FROM Pracownicy WHERE Login='" + login_prac.Text + "'";
                    laczenie.CommandText = queryUsun;
                    laczenie.ExecuteNonQuery();
                    con.Close();
                }
                else if (result == DialogResult.No)
                {

                }
                odswiez_gridview();
            }
        }
        private void promote_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Czy na pewno chcesz promować tego pracownika? Będzie miał on dostęp do takich samych danych co ty!", "Uwaga!", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                con.Open();
                OleDbCommand laczenie = new OleDbCommand();
                laczenie.Connection = con;
                string queryEdycja = "UPDATE Pracownicy SET Rola="+2+ " WHERE Login='" + login_prac.Text + "'";
                laczenie.CommandText = queryEdycja;
                laczenie.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Pomyślnie Promowano pracownika!");
            }
            else if (result == DialogResult.No)
            {

            }
            odswiez_gridview();
        }
        private void AddWorker_Click(object sender, EventArgs e)
        {
            this.Hide();
            DodawaniePracownika pracownikdodaj = new DodawaniePracownika();
            pracownikdodaj.ShowDialog();
            pracownikdodaj = null;
            this.Show();
        }
    }
}
