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
        string ProductCode;
        string NameOfProduct;
        string Description;
        string price;
        string amount;
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\Users\Perfectamthew\Documents\GitHub\BazaSpedycji\Database\MagazynSpedycji.accdb");
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
      
            else if (!r_ilosc_id.IsMatch(ilosc_prod.Text))
            {
                MessageBox.Show("Niewlasciwe dane w polu!");
            }
            else
            {
                poprawne = true;
            }
        }
        private void getProductData()
        {
            if (con.State.Equals("Open")) { con.Close(); }
            con.Open();
            OleDbCommand search = new OleDbCommand();
            search.Connection = con;
            search.CommandText = "SELECT KodProduktu FROM Produkty WHERE ID=" + id_prod.Text + "";
            OleDbDataReader reader = search.ExecuteReader();
            int count = 0;
            while (reader.Read())
            {
                count = count + 1;
            }
            if (count == 1)
            {
                OleDbCommand getCode = new OleDbCommand();
                getCode.Connection = con;
                getCode.CommandText = "SELECT KodProduktu FROM Produkty WHERE ID=" + id_prod.Text + "";
                ProductCode = getCode.ExecuteScalar().ToString();
                OleDbCommand getName = new OleDbCommand();
                getName.Connection = con;
                getName.CommandText = "SELECT NazwaProduktu FROM Produkty WHERE ID=" + id_prod.Text + "";
                NameOfProduct = getName.ExecuteScalar().ToString();
                OleDbCommand getDescription = new OleDbCommand();
                getDescription.Connection = con;
                getDescription.CommandText = "SELECT Opis FROM Produkty WHERE ID=" + id_prod.Text + "";
                Description = getDescription.ExecuteScalar().ToString();
                OleDbCommand getPrice = new OleDbCommand();
                getPrice.Connection = con;
                getPrice.CommandText = "SELECT CenaJednostkowa FROM Produkty WHERE ID=" + id_prod.Text + "";
                price = getPrice.ExecuteScalar().ToString();
                OleDbCommand getAmount = new OleDbCommand();
                getAmount.Connection = con;
                getAmount.CommandText = "SELECT Ilosc FROM Produkty WHERE ID=" + id_prod.Text + "";
                amount = getAmount.ExecuteScalar().ToString();
              
                kod_prod.Text = ProductCode;
                nazwa_prod.Text = NameOfProduct;
                opis_prod.Text = Description;
                koszt_prod.Text = price;
                ilosc_prod.Text = amount;
            }
            else
            {
                MessageBox.Show("Nie znaleziono produktu!");
            }
            con.Close();
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
                OleDbCommand checker = new OleDbCommand();
                checker.Connection = con;
                checker.CommandText = "SELECT ID FROM Produkty WHERE ID=" + id_prod.Text + "";
                OleDbDataReader reader = checker.ExecuteReader();
                int count = 0;
                while (reader.Read())
                {
                    count = count + 1;
                }
                if (count == 1)
                {
                    OleDbCommand laczenie = new OleDbCommand();
                    laczenie.Connection = con;
                    string queryEdycja = "update Produkty set KodProduktu='" + kod_prod.Text + "', NazwaProduktu='" + nazwa_prod.Text + "', Opis='" + opis_prod.Text + "', CenaJednostkowa='" + koszt_prod.Text + "', Ilosc='" + ilosc_prod.Text + "' where ID=" + id_prod.Text;
                    laczenie.CommandText = queryEdycja;
                    laczenie.ExecuteNonQuery();
                    MessageBox.Show("Pomyślnie zaktualizowano produkt");
                    reader.Close();
                }
                else
                {
                    MessageBox.Show("Produkt nie istnieje!");
                }
                con.Close();
            }
            odswiez_gridview();
        }
        private void dodanie_rekordu_Click(object sender, EventArgs e)
        {
       sprawdz_poprawnosc();

            if (poprawne == true)
            {
                con.Open();
                OleDbCommand checker = new OleDbCommand();
                checker.Connection = con;
                checker.CommandText = "SELECT ID FROM Produkty WHERE KodProduktu='"+kod_prod.Text+"'";
                OleDbDataReader reader = checker.ExecuteReader();
                int count = 0;
                while (reader.Read())
                {
                    count = count + 1;
                }
                if (count == 1)
                {
                    MessageBox.Show("Produkt już istnieje!");
                }
                else if(count==0)
                {
                    OleDbCommand laczenie = new OleDbCommand();
                    laczenie.Connection = con;
                    string queryDodaj = "insert into Produkty(KodProduktu, NazwaProduktu, Opis, CenaJednostkowa, Ilosc, Wsprzedazy) values('" + kod_prod.Text + "','" + nazwa_prod.Text + "','" + opis_prod.Text + "','" + koszt_prod.Text + "','" + ilosc_prod.Text + "',"+1+")";
                    laczenie.CommandText = queryDodaj;
                    laczenie.ExecuteNonQuery();
                    MessageBox.Show("Pomyślnie dodano produkt");
                }
                con.Close();
            }
            odswiez_gridview();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          
           
        }
        private void usun_rdk_Click(object sender, EventArgs e)
        {
            if (id_prod.Text == "")
            {
                MessageBox.Show("Brak kompletu informacji!");
            }
            else
            {
                con.Open();
                OleDbCommand checker = new OleDbCommand();
                checker.Connection = con;
                checker.CommandText = "SELECT KodProduktu FROM Produkty WHERE ID=" + id_prod.Text + "";
                OleDbDataReader reader = checker.ExecuteReader();
                int count = 0;
                while (reader.Read())
                {
                    count = count + 1;
                }
                if (count == 1)
                {
                    reader.Close();
                    DialogResult result = MessageBox.Show("Czy napewno chcesz wycofać produkt z sprzedaży?", "Uwaga!", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {

                        OleDbCommand EditProduct = new OleDbCommand();
                        EditProduct.Connection = con;
                        EditProduct.CommandText = "UPDATE Produkty SET Wsprzedazy=0 WHERE ID=" + id_prod.Text;
                        EditProduct.ExecuteNonQuery();
                        con.Close();
                        odswiez_gridview();
                    }
                    else if (result == DialogResult.No)
                    {

                    }
                } else
                {
                    MessageBox.Show("Nieprawidłowe ID produktu!");
                }
            }
        }
        private static Random random = new Random();
        private void RandomNumber_Click(object sender, EventArgs e)
        {
            int num = random.Next(0000, 9999);
            string productcodeGen = "MG-"+num;
            kod_prod.Text = productcodeGen;
        }
        private void id_prod_TextChanged(object sender, EventArgs e)
        {
            getProductData();
        }
    }
}
