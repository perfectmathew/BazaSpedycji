using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Magazyn_Spedycji
{

    public partial class PaySystem : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\Users\Perfectamthew\Documents\MagazynSpedycji.accdb");
        string UserValue;
        string orderValue;
        int iddelivery = 0;
        public PaySystem()
        {
            InitializeComponent();

        }
        public void UserCondiction(string LoginValue)
        {
            UserValue = LoginValue;
        }
        List<Dictionary<string, string>> rows = new List<Dictionary<string, string>>();
        Dictionary<string, string> column;
        private void PaySystem_Load(object sender, EventArgs e)
        {
            PaymentGateway.Hide();
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
            OleDbCommand getOrderSum = new OleDbCommand();
            getOrderSum.Connection = con;
            getOrderSum.CommandText = "SELECT Sum(SzczegolyZamowienia.Ilosc*Produkty.CenaJednostkowa) AS Dozapłacenia FROM Klienci INNER JOIN(Produkty INNER JOIN SzczegolyZamowienia ON Produkty.ID = SzczegolyZamowienia.IdProduktu) ON Klienci.ID = SzczegolyZamowienia.IDKlienta WHERE SzczegolyZamowienia.IdZamowienia = " + Convert.ToInt32(CurentOrder) + " AND Klienci.ID=" + Convert.ToInt32(UserValue) + "";
            orderValue = (string)getOrderSum.ExecuteScalar().ToString();
            PriceText.Text = "Kwota do zapłacenia: " + orderValue+" PLN";
            OleDbCommand search = new OleDbCommand();
            search.Connection = con;
           search.CommandText = "SELECT Produkty.ID, Produkty.Ilosc-SzczegolyZamowienia.Ilosc AS Wyr1 FROM Produkty INNER JOIN(Klienci INNER JOIN SzczegolyZamowienia ON Klienci.ID = SzczegolyZamowienia.IDKlienta) ON Produkty.ID = SzczegolyZamowienia.IdProduktu WHERE SzczegolyZamowienia.IdZamowienia = " + Convert.ToInt32(CurentOrder) + " AND Klienci.ID=" + Convert.ToInt32(UserValue) + "";
            int count = 0;
            OleDbDataReader reader = search.ExecuteReader();
            while (reader.Read())
            {
                column = new Dictionary<string, string>();
                column["ID"] = reader["ID"].ToString();
                column["Wyr1"] = reader["Wyr1"].ToString();
                rows.Add(column);
            }reader.Close();
          
         
            con.Close();
        }
        private void getDeliveryOption()
        {
            if (DeliveryOption.SelectedIndex==0)
            {
                iddelivery = 1;
            }
            else if(DeliveryOption.SelectedIndex==1)
            {
                iddelivery = 2;
            }
            else if (DeliveryOption.SelectedIndex == 2)
            {
                iddelivery = 3;
            }
        }
        private void PayButton_Click(object sender, EventArgs e)
        {
            PaymentGateway.Show();
            if(DeliveryOption.SelectedIndex==-1 ||  PaymentsMethod.SelectedIndex == -1)
            {
                MessageBox.Show("Wybierz sposób dostawy i metodę płatności!");
            }
            else
            {
                con.Open();
                OleDbCommand getOrderNumber = new OleDbCommand();
                getOrderNumber.Connection = con;
                getOrderNumber.CommandText = "SELECT TOP 1 SzczegolyZamowienia.IdZamowienia  FROM SzczegolyZamowienia ORDER BY SzczegolyZamowienia.IdZamowienia DESC";
                Int32 CurentOrder = (Int32)getOrderNumber.ExecuteScalar();
                OleDbCommand getOrderSum = new OleDbCommand();
                getOrderSum.Connection = con;
                getOrderSum.CommandText = "SELECT Sum(SzczegolyZamowienia.Ilosc*Produkty.CenaJednostkowa) AS Dozapłacenia FROM Klienci INNER JOIN(Produkty INNER JOIN SzczegolyZamowienia ON Produkty.ID = SzczegolyZamowienia.IdProduktu) ON Klienci.ID = SzczegolyZamowienia.IDKlienta WHERE SzczegolyZamowienia.IdZamowienia = " + Convert.ToInt32(CurentOrder) + " AND Klienci.ID=" + Convert.ToInt32(UserValue) + "";
                orderValue = (string)getOrderSum.ExecuteScalar().ToString();
                OleDbCommand updateAmount = new OleDbCommand();
                updateAmount.Connection = con;
                foreach (Dictionary<string, string> column in rows)
                {
                    updateAmount.CommandText = "Update Produkty SET Ilosc=" + column["Wyr1"] + " WHERE ID=" + column["ID"] + "";
                    updateAmount.ExecuteNonQuery();
                }
                String CurentDate = DateTime.Now.ToString("dd.MM.yyy");
                OleDbCommand newTransaction = new OleDbCommand();
                newTransaction.Connection = con;
                newTransaction.CommandText = "INSERT INTO ZamZaku(DataUtworzenia,IdStanu,CenaPrzesylki,DataPlatnosci,KwotaWplacona,SposobZaplaty,Uwagi) VALUES('" + CurentDate + "','" + 2 + "','" + 8 + "','" + CurentDate + "','"+orderValue+"','"+PaymentsMethod.Text+"','"+Uwagi.Text+"')";
                newTransaction.ExecuteNonQuery();
                getDeliveryOption();
                OleDbCommand updateOrder = new OleDbCommand();
                updateOrder.Connection = con;
                updateOrder.CommandText = "UPDATE Zamowienia SET Idklienta='"+UserValue+"', DataZamowienia='"+CurentDate+"', IdSpedytora='"+iddelivery+"', NazwaWysylki='"+DeliveryOption.Text+"', TypPlatnosci='"+PaymentsMethod.Text+"', DataZaplaty='"+CurentDate+"' WHERE IdZamowienia="+CurentOrder;
                updateOrder.ExecuteNonQuery();
                OleDbCommand CreatenewOrder = new OleDbCommand();
                CreatenewOrder.Connection = con;
                CreatenewOrder.CommandText = "INSERT INTO Zamowienia(IdPracownika,IdKlienta,IdSpedytora,IdStanu) VALUES('"+1+"','"+UserValue+"','"+4+"','"+1+"')";
                CreatenewOrder.ExecuteNonQuery();
                OleDbCommand getNweOrder = new OleDbCommand();
                getNweOrder.Connection = con;
                getNweOrder.CommandText = "SELECT TOP 1 Zamowienia.IdZamowienia  FROM Zamowienia ORDER BY Zamowienia.IdZamowienia DESC";
                Int32 NewOrder = (Int32)getNweOrder.ExecuteScalar();
                OleDbCommand CreatenewCart = new OleDbCommand();
                CreatenewCart.Connection = con;
                CreatenewCart.CommandText = "INSERT INTO SzczegolyZamowienia(IdZamowienia,IdProduktu,IdKlienta) VALUES('" + NewOrder + "','"+8+"','"+UserValue+"')";
                CreatenewCart.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Twoje zamówienie zostało opłacane i przekazane do realizacji!");
                this.Close();
            }
        }

    }
}
