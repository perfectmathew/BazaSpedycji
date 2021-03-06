﻿using System;
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


   
    public partial class KlientEdycja : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= Database\MagazynSpedycji.accdb");
        int kolumna = 0;
        bool poprawne = false;
        public KlientEdycja()
        {
            InitializeComponent();
        }
        public void sprawdz_poprawnosc()
        {
            Regex r_klie_kodp = new Regex("^[0-9]{2}-[0-9]{3}$");
            Regex r_klie_tele = new Regex("^[1-9]{3}-[0-9]{3}-[0-9]{3}$");
            if (imie_klie.Text == "" || nazw_klie.Text == "" || adres_klie.Text == "" || miasto_klie.Text == "" || woje_klie.Text == "" || kraj_klie.Text == "" || login_klie.Text == "" || haslo_klie.Text == "")
            {
                MessageBox.Show("Brak kompletu informacji!");

            }
            else if (!r_klie_kodp.IsMatch(kodp_klie.Text)||!r_klie_tele.IsMatch(telefon_klie.Text))
            {
                MessageBox.Show("Niewlasciwe dane w polu!");
            }
            else
            {
                poprawne = true;
            }
        }
        public void odswiez_gridview()
        {
            OleDbCommand createKlienci = new OleDbCommand();
            createKlienci.Connection = con;
            string queryKlienci = "SELECT Klienci.Login, Klienci.Imie, Klienci.Nazwisko, Klienci.Email, Klienci.Telefon, Klienci.Adres, Klienci.Miasto, Klienci.Wojewodztwo, Klienci.KodPocztowy, Klienci.Kraj, Klienci.Haslo FROM Klienci";
            createKlienci.CommandText = queryKlienci;
            OleDbDataAdapter klienci = new OleDbDataAdapter(createKlienci);
            DataTable tabelaKlienci = new DataTable();
            klienci.Fill(tabelaKlienci);
            dataGridView1.DataSource = tabelaKlienci;
        }
        private void KlientEdycja_Load(object sender, EventArgs e)
        {   
            dataGridView1.Show();
            OleDbCommand createKlienci = new OleDbCommand();
            createKlienci.Connection = con;
            string queryKlienci = "SELECT Klienci.Login, Klienci.Imie, Klienci.Nazwisko, Klienci.Email, Klienci.Telefon, Klienci.Adres, Klienci.Miasto, Klienci.Wojewodztwo, Klienci.KodPocztowy, Klienci.Kraj, Klienci.Haslo FROM Klienci";
            createKlienci.CommandText = queryKlienci;
            OleDbDataAdapter klienci = new OleDbDataAdapter(createKlienci);
            DataTable tabelaKlienci = new DataTable();
            klienci.Fill(tabelaKlienci);
            dataGridView1.DataSource = tabelaKlienci;
            con.Close();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            kolumna = e.RowIndex;
            if (kolumna < 0) MessageBox.Show("Wybierz użytkownika!");
            else
            {
                DataGridViewRow kol = dataGridView1.Rows[kolumna];
                login_klie.Text = kol.Cells[0].Value.ToString();
                imie_klie.Text = kol.Cells[1].Value.ToString();
                nazw_klie.Text = kol.Cells[2].Value.ToString();
                email_klie.Text = kol.Cells[3].Value.ToString();
                telefon_klie.Text = kol.Cells[4].Value.ToString();
                adres_klie.Text = kol.Cells[5].Value.ToString();
                miasto_klie.Text = kol.Cells[6].Value.ToString();
                woje_klie.Text = kol.Cells[7].Value.ToString();
                kodp_klie.Text = kol.Cells[8].Value.ToString();
                kraj_klie.Text = kol.Cells[9].Value.ToString();
                string tmp= kol.Cells[10].Value.ToString();
                string decusr = Encyryption.Decrypt(tmp);
                haslo_klie.Text = decusr;
            }
        }
        private void edycja_rdk_klie_Click(object sender, EventArgs e)
        {
            sprawdz_poprawnosc();

           if (poprawne == true)
            {
                string decpass = Encyryption.Encrypt(haslo_klie.Text);
                con.Open();
                OleDbCommand laczenie = new OleDbCommand();
                laczenie.Connection = con;
                string queryEdycja = "update Klienci set Imie='" + imie_klie.Text + "', Nazwisko='" + nazw_klie.Text + "', Email='" + email_klie.Text + "', Telefon='" + telefon_klie.Text + "', Adres='" + adres_klie.Text + "', Miasto='" + miasto_klie.Text + "', Wojewodztwo='" + woje_klie.Text + "', KodPocztowy='" + kodp_klie.Text + "', Kraj='" + kraj_klie.Text + "', Login='" + login_klie.Text + "', Haslo='" + decpass + "' where ID=";
                laczenie.CommandText = queryEdycja;
                laczenie.ExecuteNonQuery();
                MessageBox.Show("Pomyślnie zaktualizowano użytkownika!");
                con.Close();
            }
            odswiez_gridview();
        }
        private void usun_klienta_Click(object sender, EventArgs e)
        {
                DialogResult result = MessageBox.Show("Czy na pewno chcesz usunąć ten produkt?", "Uwaga!", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    kolumna = dataGridView1.CurrentCell.RowIndex;
                    con.Open();
                    OleDbCommand laczenie = new OleDbCommand();
                    laczenie.Connection = con;
                    string queryUsun = "Delete * FROM Klienci where ID=" + kolumna;
                    laczenie.CommandText = queryUsun;
                    laczenie.ExecuteNonQuery();
                    con.Close();
                    odswiez_gridview();
                }
                else if (result == DialogResult.No)
                {

                }   
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                haslo_klie.UseSystemPasswordChar = false;
            }else if (checkBox1.Checked == false)
            {
                haslo_klie.UseSystemPasswordChar = true;
            }
        }
    }
}
