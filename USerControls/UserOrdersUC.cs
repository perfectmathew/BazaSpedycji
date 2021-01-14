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
    public partial class UserOrdersUC : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= Database\MagazynSpedycji.accdb");
        string UserValue;
        public UserOrdersUC()
        {
            InitializeComponent();
        }
        private void ZamowieniaKlienta()
        {
            con.Open();
            OleDbCommand createZamowienia = new OleDbCommand();
            createZamowienia.Connection = con;
            string queryZamowienia = "SELECT Zamowienia.IdZamowienia, StanZamowien.Nazwa AS StanZamowienia, Zamowienia.DataZamowienia, Spedytorzy.Firma, Zamowienia.NazwaWysylki, Zamowienia.TypPlatnosci, Zamowienia.DataZaplaty, Zamowienia.Uwagi FROM Spedytorzy INNER JOIN(StanZamowien INNER JOIN Zamowienia ON StanZamowien.IdStanu = Zamowienia.IdStanu) ON Spedytorzy.ID = Zamowienia.IdSpedytora WHERE Zamowienia.IdKlienta=" + UserValue + " AND Spedytorzy.ID NOT IN ( 4 )";
            createZamowienia.CommandText = queryZamowienia;
            OleDbDataAdapter zamowienia = new OleDbDataAdapter(createZamowienia);
            DataTable OrderTable = new DataTable();
            zamowienia.Fill(OrderTable);
            dataGridView1.DataSource = OrderTable;
            con.Close();
        }
        private void UserOrdersUC_Load(object sender, EventArgs e)
        {
            backButton.Hide();
            ZamowieniaKlienta();
        }
        public void OrderCondiction(string LoginValue)
        {
            UserValue = LoginValue;
        }
        private void showMore_Click(object sender, EventArgs e)
        {
            backButton.Show();
            int wIlosc = 0;
            bool isNumber = false;
            isNumber = int.TryParse(IDOrder.Text, out wIlosc);
            if (IDOrder.Text == "" || !isNumber) MessageBox.Show("Wpisz ID Zamówienia!");
            else
            {
                con.Open();
                OleDbCommand checker = new OleDbCommand();
                checker.Connection = con;
                checker.CommandText = "SELECT IdZamowienia FROM Zamowienia WHERE IdKlienta=" + UserValue + " AND IdZamowienia=" + IDOrder.Text + "";
                OleDbDataReader reader = checker.ExecuteReader();
                int count = 0;
                while (reader.Read())
                {
                    count = count + 1;
                }
                if (count == 0) MessageBox.Show("To zamówienie nie istnieje, lub jest przypisane dla innego użytkownika!");
                else
                {
                    OleDbCommand createKoszyk = new OleDbCommand();
                    createKoszyk.Connection = con;
                    string queryKoszyk = "SELECT Produkty.NazwaProduktu, SzczegolyZamowienia.Ilosc, Produkty.CenaJednostkowa, Produkty.CenaJednostkowa*SzczegolyZamowienia.Ilosc AS CenaOgolna FROM Produkty INNER JOIN(Klienci INNER JOIN SzczegolyZamowienia ON Klienci.ID = SzczegolyZamowienia.IDKlienta) ON Produkty.ID = SzczegolyZamowienia.IdProduktu WHERE SzczegolyZamowienia.IdZamowienia = " + IDOrder.Text + " AND Klienci.ID=" + UserValue + " AND IdProduktu NOT IN ( 8 )";
                    createKoszyk.CommandText = queryKoszyk;
                    OleDbDataAdapter koszyk = new OleDbDataAdapter(createKoszyk);
                    DataTable Koszyk = new DataTable();
                    koszyk.Fill(Koszyk);
                    dataGridView1.DataSource = Koszyk;
                }
                con.Close();
            }
        }
        private void backButton_Click(object sender, EventArgs e)
        {
            backButton.Hide();
            ZamowieniaKlienta();
        }
    }
}
