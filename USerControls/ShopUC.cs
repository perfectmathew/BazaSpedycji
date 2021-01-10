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
namespace Magazyn_Spedycji.USerControls
{
    public partial class ShopUC : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\Users\Perfectamthew\Documents\GitHub\BazaSpedycji\Database\MagazynSpedycji.accdb");
        string UserValue;
        private void otworzsklep()
        {
            con.Open();
            OleDbCommand createSklep = new OleDbCommand();
            createSklep.Connection = con;
            string querySklep = "SELECT KodProduktu,NazwaProduktu,Opis,CenaJednostkowa,Ilosc FROM Produkty WHERE ID NOT IN(8) AND Wsprzedazy = true ORDER BY ID ASC";
            createSklep.CommandText = querySklep;
            OleDbDataAdapter sklep = new OleDbDataAdapter(createSklep);
            DataTable Sklep = new DataTable();
            sklep.Fill(Sklep);
            dataGridView1.DataSource = Sklep;
            con.Close();
        }
        public ShopUC()
        {
            InitializeComponent();
        }
        public void ShopCondiction(string LoginValue)
        {
            UserValue = LoginValue;
        }
        private void ShopUC_Load(object sender, EventArgs e)
        {
            otworzsklep();
            backtoshop.Hide();
            CreateOrder.Hide();
        }
        private void showcart_Click(object sender, EventArgs e)
        {
            CreateOrder.Show();
            searchBar.Hide();
            SearchButton.Hide();
            con.Open();
            OleDbCommand getOrderNumber = new OleDbCommand();
            getOrderNumber.Connection = con;
            getOrderNumber.CommandText = "SELECT TOP 1 SzczegolyZamowienia.IdZamowienia  FROM SzczegolyZamowienia ORDER BY SzczegolyZamowienia.IdZamowienia DESC";
            Int32 CurentOrder = (Int32)getOrderNumber.ExecuteScalar();
            OleDbCommand createKoszyk = new OleDbCommand();
            createKoszyk.Connection = con;
            string queryKoszyk = "SELECT Produkty.NazwaProduktu, SzczegolyZamowienia.Ilosc, Produkty.CenaJednostkowa, Produkty.CenaJednostkowa*SzczegolyZamowienia.Ilosc AS CenaOgolna FROM Produkty INNER JOIN(Klienci INNER JOIN SzczegolyZamowienia ON Klienci.ID = SzczegolyZamowienia.IDKlienta) ON Produkty.ID = SzczegolyZamowienia.IdProduktu WHERE SzczegolyZamowienia.IdZamowienia = " + Convert.ToInt32(CurentOrder) + " AND Klienci.ID=" + UserValue + " AND IdProduktu NOT IN ( 8 )";
            createKoszyk.CommandText = queryKoszyk;
            OleDbDataAdapter koszyk = new OleDbDataAdapter(createKoszyk);
            DataTable Koszyk = new DataTable();
            koszyk.Fill(Koszyk);
            dataGridView1.DataSource = Koszyk;
            con.Close();
            backtoshop.Show();
        }
        private void ToCart_Click(object sender, EventArgs e)
        {
            int wIlosc = 0;
            bool isNumber = false;
            isNumber = int.TryParse(Amount.Text, out wIlosc);
            if (ProdutsCode.Text == "" || Amount.Text == "" || !isNumber) MessageBox.Show("Wpisz Kod porduktu który chcesz dodać do koszyka, oraz jego ilość!");
            else
            {
                con.Open();
                OleDbCommand search = new OleDbCommand();
                search.Connection = con;
                search.CommandText = "Select * FROM Produkty WHERE KodProduktu='" + ProdutsCode.Text + "' AND Ilosc>=" + Convert.ToInt32(Amount.Text);
                int count = 0;
                OleDbDataReader reader = search.ExecuteReader();
                while (reader.Read())
                {
                    count = count + 1;
                }
                if (count == 1)
                {
                    DialogResult cartconfirm = MessageBox.Show("Czy chcesz dodać ten produkt do koszyka?", "Uwaga!", MessageBoxButtons.YesNo);
                    if (cartconfirm == DialogResult.Yes)
                    {
                        OleDbCommand getOrderNumber = new OleDbCommand();
                        getOrderNumber.Connection = con;
                        getOrderNumber.CommandText = "SELECT TOP 1 SzczegolyZamowienia.IdZamowienia  FROM SzczegolyZamowienia ORDER BY SzczegolyZamowienia.IdZamowienia DESC";
                        Int32 CurentOrder = (Int32)getOrderNumber.ExecuteScalar();
                        OleDbCommand gedCode = new OleDbCommand();
                        gedCode.Connection = con;
                        //SELECT TOP 1 SzczegolyZamowienia.IdZamowienia  FROM SzczegolyZamowienia ORDER BY SzczegolyZamowienia.IdZamowienia DESC;
                        gedCode.CommandText = "Select ID FROM Produkty WHERE KodProduktu='" + ProdutsCode.Text + "'";
                        Int32 IIDProduktu = (Int32)gedCode.ExecuteScalar();
                        OleDbCommand cmd = new OleDbCommand();
                        cmd.Connection = con;
                        cmd.CommandText = "INSERT INTO SzczegolyZamowienia(IdZamowienia,IdProduktu,Ilosc,IdStanu,IDKlienta) values('" + CurentOrder + "','" + IIDProduktu + "','" + Amount.Text + "','" + 0 + "','" + UserValue + "') ";
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Poprawnie dodadno produkt do koszyka!");
                    }
                    else if (cartconfirm == DialogResult.No)
                    {
                    }
                }
                else MessageBox.Show("Brak produktu o podanym Kodzie, lub brak wystarczającej ilości produktu na magazynie!");
                con.Close();
            }
        }
        private void CreateOrder_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand getOrderNumber = new OleDbCommand();
            getOrderNumber.Connection = con;
            getOrderNumber.CommandText = "SELECT TOP 1 SzczegolyZamowienia.IdZamowienia  FROM SzczegolyZamowienia ORDER BY SzczegolyZamowienia.IdZamowienia DESC";
            Int32 CurentOrder = (Int32)getOrderNumber.ExecuteScalar();
            OleDbCommand checkifCartisEmpty = new OleDbCommand();
            checkifCartisEmpty.Connection = con;
            string queryKoszyk = "SELECT Produkty.NazwaProduktu, SzczegolyZamowienia.Ilosc, Produkty.CenaJednostkowa, Produkty.CenaJednostkowa*SzczegolyZamowienia.Ilosc AS CenaOgolna FROM Produkty INNER JOIN(Klienci INNER JOIN SzczegolyZamowienia ON Klienci.ID = SzczegolyZamowienia.IDKlienta) ON Produkty.ID = SzczegolyZamowienia.IdProduktu WHERE SzczegolyZamowienia.IdZamowienia = " + Convert.ToInt32(CurentOrder) + " AND Klienci.ID=" + UserValue + " AND IdProduktu NOT IN ( 8 )";
            checkifCartisEmpty.CommandText = queryKoszyk;
            int count = 0;
            OleDbDataReader reader = checkifCartisEmpty.ExecuteReader();
            while (reader.Read())
            {
                count = count + 1;
            }
            if (count == 0) MessageBox.Show("Koszyk jest pusty!");
            else
            {
               
                DialogResult payconfirm = MessageBox.Show("Czy napewno chcesz zakupić przedmioty znajdujące się w koszyku?", "Potwierdzenie złożenia zamówienia", MessageBoxButtons.YesNo);
                if (payconfirm == DialogResult.Yes)
                {
                    int usccon = Convert.ToInt32(UserValue);
                    this.Hide();
                    PaySystem pay = new PaySystem();
                    pay.UserCondiction(usccon.ToString());
                    pay.ShowDialog();
                    pay = null;
                    this.Show();
                }
                else if (payconfirm == DialogResult.No)
                {
                }
            }
            con.Close();
        }

        private void backtoshop_Click(object sender, EventArgs e)
        {
            CreateOrder.Hide();
            otworzsklep();
            searchBar.Show();
            SearchButton.Show();
            backtoshop.Hide();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            // SELECT Produkty.* FROM Produkty WHERE NazwaProduktu LIKE "*Piwo*";
            con.Open();
            OleDbCommand search = new OleDbCommand();
            search.Connection = con;
            string searchquery = "SELECT * FROM Produkty WHERE NazwaProduktu LIKE '%"+searchBar.Text+"%'";
            search.CommandText = searchquery;
            OleDbDataAdapter searchedItem = new OleDbDataAdapter(search);
            DataTable Searcher = new DataTable();
            searchedItem.Fill(Searcher);
            dataGridView1.DataSource = Searcher;
            con.Close();
        }

        private void searchBar_TextChanged(object sender, EventArgs e)
        {
            if (searchBar.Text == "")
            {
                otworzsklep();
            }
        }
    }
}
