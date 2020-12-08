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
    public partial class ProduktEdycja : Form
    {
        bool poprawne = false;
        int kolumna = 0;

        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\Users\Perfectamthew\Documents\MagazynSpedycji.accdb");
        public ProduktEdycja()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.Show();
            OleDbCommand createProdukty = new OleDbCommand();
            createProdukty.Connection = con;
            string queryProdukty = "Select * from Produkty";
            createProdukty.CommandText = queryProdukty;
            OleDbDataAdapter produkty = new OleDbDataAdapter(createProdukty);
            DataTable tabelaProdukty = new DataTable();
            produkty.Fill(tabelaProdukty);
            dataGridView1.DataSource = tabelaProdukty;
            con.Close();
        }
    
        public void sprawdz_poprawnosc()
        {
            Regex r_cenakoszt = new Regex("^[0-9]+(,[0-9]{1,2})?$");
            Regex r_ilosc_id = new Regex("^[0-9]+$");


            if (kod_prod.Text == "" || nazwa_prod.Text == "" || opis_prod.Text == "")
            {
                MessageBox.Show("Brak kompletu informacji!");

            }
      
            else if (!r_ilosc_id.IsMatch(ilosc_prod.Text) || !r_ilosc_id.IsMatch(id_prod.Text))
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
            OleDbCommand createProdukty = new OleDbCommand();
            createProdukty.Connection = con;
            string queryProdukty = "Select * from Produkty";
            createProdukty.CommandText = queryProdukty;
            OleDbDataAdapter produkty = new OleDbDataAdapter(createProdukty);
            DataTable tabelaProdukty = new DataTable();
            produkty.Fill(tabelaProdukty);
            dataGridView1.DataSource = tabelaProdukty;
        }
        

        private void edycja_rekordu_Click(object sender, EventArgs e)
        {
            
            sprawdz_poprawnosc();

            if (poprawne == true)
            {

                con.Open();
                OleDbCommand laczenie = new OleDbCommand();
                laczenie.Connection = con;
                // "' ,NazwaProduktu='" + nazwa_prod.Text + "' ,Ops='" + opis_prod + "' ,KosztStandardowy'" + Convert.ToInt32(koszt_prod.Text) + "' ,CenaKatalogowa='" + Convert.ToInt32(cenakat_prod.Text) + "' ,Ilosc='" + Convert.ToInt32(ilosc_prod.Text) +

                string queryEdycja = "update Produkty set KodProduktu='" + kod_prod.Text + "', NazwaProduktu='" + nazwa_prod.Text + "', Ops='" + opis_prod.Text + "', CenaJednostkowa='" + koszt_prod.Text + "', Ilosc='" + ilosc_prod.Text + "' where ID=" + id_prod.Text;
                laczenie.CommandText = queryEdycja;
                laczenie.ExecuteNonQuery();
                MessageBox.Show("Pomyślnie zaktualizowano produkt");
                con.Close();

            }
            odswiez_gridview();
        }

        private void dodanie_rekordu_Click(object sender, EventArgs e)
        {


            //insert into Produkty(ID, KodProduktu, NazwaProduktu, Ops, KosztStandardowy, CenaKatologowa, Ilosc) values('3', 'KAC-17', 'Hula hop rozowe', 'super koleczko do krecenia', '25', '30', '7')
       sprawdz_poprawnosc();

            if (poprawne == true)
            {

                con.Open();
                OleDbCommand laczenie = new OleDbCommand();
                laczenie.Connection = con;

                string queryDodaj = "insert into Produkty(ID, KodProduktu, NazwaProduktu, Ops, CenaJednostkowa, Ilosc) values('" + id_prod.Text + "','" + kod_prod.Text + "','" + nazwa_prod.Text + "','" + opis_prod.Text + "','" + koszt_prod.Text + "','" + ilosc_prod.Text + "')";
                laczenie.CommandText = queryDodaj;
                laczenie.ExecuteNonQuery();
                MessageBox.Show("Pomyślnie dodano produkt");
                con.Close();

     
            }
            odswiez_gridview();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            kolumna = e.RowIndex;
            DataGridViewRow kol = dataGridView1.Rows[kolumna];
            id_prod.Text = kol.Cells[0].Value.ToString();
            kod_prod.Text = kol.Cells[1].Value.ToString();
            nazwa_prod.Text = kol.Cells[2].Value.ToString();
            opis_prod.Text = kol.Cells[3].Value.ToString();
            koszt_prod.Text = kol.Cells[4].Value.ToString();
            ilosc_prod.Text = kol.Cells[5].Value.ToString();
            wycofane_prod.Checked = Convert.ToBoolean( kol.Cells[6].Value.ToString());
        }



        private void usun_rdk_Click(object sender, EventArgs e)
        {
            kolumna = dataGridView1.CurrentCell.RowIndex;
            con.Open();
            OleDbCommand laczenie = new OleDbCommand();
            laczenie.Connection = con;
            string queryUsun = "Delete FROM Produkty where ID="+kolumna;
            laczenie.CommandText = queryUsun;
            laczenie.ExecuteNonQuery();
            con.Close();

            odswiez_gridview();

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
