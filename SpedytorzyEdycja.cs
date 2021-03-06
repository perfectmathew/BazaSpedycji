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
    public partial class SpedytorzyEdycja : Form
    {
        int kolumna = 0;
        bool poprawne = false;
        int permLVL = 1;
        string AdminValue;
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= Database\MagazynSpedycji.accdb");
        public SpedytorzyEdycja()
        {
            InitializeComponent();
        }
        public void odswiez_gridview()
        {
            OleDbCommand createSpedytorzy = new OleDbCommand();
            createSpedytorzy.Connection = con;
            string querySpedytorzy = "SELECT Spedytorzy.Login, Spedytorzy.Firma, Spedytorzy.Imie, Spedytorzy.Nazwisko, Spedytorzy.Email, Spedytorzy.Telefon, Spedytorzy.Haslo FROM Spedytorzy";
            createSpedytorzy.CommandText = querySpedytorzy;
            OleDbDataAdapter spedytor = new OleDbDataAdapter(createSpedytorzy);
            DataTable tabelaSpedytorzy = new DataTable();
            spedytor.Fill(tabelaSpedytorzy);
            dataGridView1.DataSource = tabelaSpedytorzy;
        }
        private void SpedytorzyEdycja_Load(object sender, EventArgs e)
        {
            dataGridView1.Show();
            OleDbCommand createSpedytorzy = new OleDbCommand();
            createSpedytorzy.Connection = con;
            string querySpedytorzy = "SELECT Spedytorzy.Login, Spedytorzy.Firma, Spedytorzy.Imie, Spedytorzy.Nazwisko, Spedytorzy.Email, Spedytorzy.Telefon, Spedytorzy.Haslo FROM Spedytorzy";
            createSpedytorzy.CommandText = querySpedytorzy;
            OleDbDataAdapter spedytorzy = new OleDbDataAdapter(createSpedytorzy);
            DataTable tabelaSpedytorzy = new DataTable();
            spedytorzy.Fill(tabelaSpedytorzy);
            dataGridView1.DataSource = tabelaSpedytorzy;
            con.Open();
            OleDbCommand getPerm = new OleDbCommand();
            getPerm.Connection = con;
            getPerm.CommandText = "SELECT Rola FROM Pracownicy WHERE ID=" + AdminValue;
            permLVL = Convert.ToInt32(getPerm.ExecuteScalar());
            con.Close();
         
        }
        public void PermisionLevelUC(string perm)
        {
            AdminValue = perm;
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            kolumna = e.RowIndex;
            if (kolumna < 0 ) MessageBox.Show("Wybierz użytkownika!");
            else
                {
                    DataGridViewRow kol = dataGridView1.Rows[kolumna];
                    login_spedy.Text = kol.Cells[0].Value.ToString();
                    firma_spedy.Text = kol.Cells[1].Value.ToString();
                    imie_spedy.Text = kol.Cells[2].Value.ToString();
                    nazw_spedy.Text = kol.Cells[3].Value.ToString();
                    email_spedy.Text = kol.Cells[4].Value.ToString();
                    tele_spedy.Text = kol.Cells[5].Value.ToString();
                    string tmp = kol.Cells[6].Value.ToString();
                    string decusr = Encyryption.Decrypt(tmp);
                    haslo_spedy.Text = decusr;  
                } 
        }
        private void usun_spedy_Click(object sender, EventArgs e)
        {
            if (permLVL == 1)
            {
                MessageBox.Show("Tylko pracownicy z rolą Administrator mogą zarządzać tą sekcją!");
            }
            else
            {
                DialogResult result = MessageBox.Show("Czy na pewno chcesz usunąć spedytora?", "Uwaga!", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    con.Open();
                    OleDbCommand laczenie = new OleDbCommand();
                    laczenie.Connection = con;
                    string queryUsun = "Delete FROM Spedytorzy where Login='" + login_spedy.Text + "'";
                    laczenie.CommandText = queryUsun;
                    laczenie.ExecuteNonQuery();
                    con.Close();
                    odswiez_gridview();
                }
                else if (result == DialogResult.No)
                {

                }
            }
       
        }
        public void sprawdz_poprawnosc()
        {

            Regex r_spedy_tele = new Regex("^[1-9]{3}-[0-9]{3}-[0-9]{3}$");
            Regex email = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");

            if (imie_spedy.Text==""||firma_spedy.Text==""||nazw_spedy.Text==""||email_spedy.Text==""||login_spedy.Text==""||haslo_spedy.Text=="")
            {
                MessageBox.Show("Brak kompletu informacji!");

            }

            else if(!r_spedy_tele.IsMatch(tele_spedy.Text) || !email.IsMatch(email_spedy.Text))
            {
                MessageBox.Show("Niewlasciwe dane w polu!");
            }
            else
            {
                poprawne = true;
            }
            
        }
        private void edytuj_spedy_Click(object sender, EventArgs e)
        {
            sprawdz_poprawnosc();
            if (poprawne == true)
            {
                string decpass = Encyryption.Encrypt(haslo_spedy.Text);
                con.Open();
                OleDbCommand laczenie = new OleDbCommand();
                laczenie.Connection = con;
                string queryEdycja = "update Spedytorzy set Firma='" + firma_spedy.Text + "', Imie='" + imie_spedy.Text + "', Nazwisko='" + nazw_spedy.Text + "', Email='" + email_spedy.Text + "', Telefon='" + tele_spedy.Text + "', Login='" + login_spedy.Text + "', Haslo='" + decpass + "' where Login='" + login_spedy.Text+"'";
                laczenie.CommandText = queryEdycja;
                laczenie.ExecuteNonQuery();
                MessageBox.Show("Pomyślnie zaktualizowano użytkownika!");
                con.Close();
            }
            odswiez_gridview();
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                haslo_spedy.UseSystemPasswordChar = false;
            }else if (checkBox1.Checked == false)
            {
                haslo_spedy.UseSystemPasswordChar = true;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            DodawanieSpedytora spedytordodaj = new DodawanieSpedytora();
            spedytordodaj.ShowDialog();
            spedytordodaj = null;
            this.Show();
        }
    }
}
