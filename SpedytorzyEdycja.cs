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
    public partial class SpedytorzyEdycja : Form
    {
        int kolumna = 0;
        bool poprawne = false;
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\Users\wojna\Desktop\BazaSpedycji-main\Database\MagazynSpedycji.accdb");
        public SpedytorzyEdycja()
        {
            InitializeComponent();
        }

        public void odswiez_gridview()
        {
            OleDbCommand createSpedytorzy = new OleDbCommand();
            createSpedytorzy.Connection = con;
            string querySpedytorzy = "Select * from Spedytorzy";
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
            string querySpedytorzy = "Select * from Spedytorzy";
            createSpedytorzy.CommandText = querySpedytorzy;
            OleDbDataAdapter spedytorzy = new OleDbDataAdapter(createSpedytorzy);
            DataTable tabelaSpedytorzy = new DataTable();
            spedytorzy.Fill(tabelaSpedytorzy);
            dataGridView1.DataSource = tabelaSpedytorzy;
            con.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        
                kolumna = e.RowIndex;
                if (kolumna < 0 || kolumna > 8) MessageBox.Show("Wybierz produkt!");
                else
                {
                    DataGridViewRow kol = dataGridView1.Rows[kolumna];
                    id_spedy.Text = kol.Cells[0].Value.ToString();
                    firma_spedy.Text = kol.Cells[1].Value.ToString();
                    imie_spedy.Text = kol.Cells[2].Value.ToString();
                    nazw_spedy.Text = kol.Cells[3].Value.ToString();
                    email_spedy.Text = kol.Cells[3].Value.ToString();
                    tele_spedy.Text = kol.Cells[5].Value.ToString();
                    login_spedy.Text = kol.Cells[6].Value.ToString();
                    haslo_spedy.Text = kol.Cells[7].Value.ToString();
                }
            
        }

        private void usun_spedy_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Czy na pewno chcesz usunąć spedytora?", "Uwaga!", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                kolumna = dataGridView1.CurrentCell.RowIndex;
                con.Open();
                OleDbCommand laczenie = new OleDbCommand();
                laczenie.Connection = con;
                string queryUsun = "Delete FROM Spedytorzy where ID=" + kolumna;
                laczenie.CommandText = queryUsun;
                laczenie.ExecuteNonQuery();
                con.Close();
                //odswiez_gridview();
            }
            else if (result == DialogResult.No)
            {

            }
        }


        public void sprawdz_poprawnosc()
        {

            Regex r_spedy_tele = new Regex("^[1-9]{3}-[0-9]{3}-[0-9]{3}$");


            if(imie_spedy.Text==""||firma_spedy.Text==""||nazw_spedy.Text==""||email_spedy.Text==""||login_spedy.Text==""||haslo_spedy.Text=="")
            {
                MessageBox.Show("Brak kompletu informacji!");

            }

            else if(!r_spedy_tele.IsMatch(tele_spedy.Text))
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
                con.Open();
                OleDbCommand laczenie = new OleDbCommand();
                laczenie.Connection = con;


                string queryEdycja = "update Spedytorzy set Firma='" + firma_spedy.Text + "', Imie='" + imie_spedy.Text + "', Nazwisko='" + nazw_spedy.Text + "', Email='" + email_spedy.Text + "', Telefon='" + tele_spedy.Text + "', Login='" + login_spedy.Text + "', Haslo='" + haslo_spedy.Text + "' where ID=" + id_spedy.Text;
                laczenie.CommandText = queryEdycja;
                laczenie.ExecuteNonQuery();
                MessageBox.Show("Pomyślnie zaktualizowano produkt");
                con.Close();
            }
            odswiez_gridview();

        }
    }
}
