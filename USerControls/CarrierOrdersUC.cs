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
namespace Magazyn_Spedycji.USerControls
{

    public partial class CarrierOrdersUC : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= Database\MagazynSpedycji.accdb");
        string CarrierValue;

        public CarrierOrdersUC()
        {
            InitializeComponent();
        }
        public void OrderValueUC(string LoginValue)
        {
            CarrierValue = LoginValue.ToString();
        }
        private void CreateOrders()
        {
            con.Open();
            OleDbCommand createSpedytorzy = new OleDbCommand();
            createSpedytorzy.Connection = con;
            string querySpedytorzy = "SELECT Zamowienia.IdZamowienia, StanZamowien.Nazwa AS [Status], Zamowienia.DataWyslania ,Klienci.Imie, Klienci.Nazwisko, Klienci.Telefon, Klienci.Adres, Klienci.Miasto, Klienci.Wojewodztwo, Klienci.KodPocztowy, Klienci.Kraj FROM Klienci INNER JOIN(StanZamowien INNER JOIN (Spedytorzy INNER JOIN Zamowienia ON Spedytorzy.ID = Zamowienia.IdSpedytora) ON StanZamowien.IdStanu = Zamowienia.IdStanu) ON Klienci.ID = Zamowienia.IdKlienta WHERE Zamowienia.IdSpedytora=" + CarrierValue + " AND Zamowienia.IdStanu=3 AND Zamowienia.Dostarczone=0";
            createSpedytorzy.CommandText = querySpedytorzy;
            OleDbDataAdapter spedytorzy = new OleDbDataAdapter(createSpedytorzy);
            DataTable SpedytorzyTable = new DataTable();
            spedytorzy.Fill(SpedytorzyTable);
            dataGridView1.DataSource = SpedytorzyTable;
            con.Close();
        }
        private void UpdateOrderButton_Click(object sender, EventArgs e)
        {
            Regex ID = new Regex(@"^[0-9]$");
            if( IDZamField.Text==""|| StatusOrderCombo.SelectedIndex == -1)
            {
                MessageBox.Show("Brak kompletu informacji!");
            }
            else
            {
                con.Open();
                OleDbCommand search = new OleDbCommand();
                search.Connection = con;
                search.CommandText = "SELECT IdZamowienia FROM Zamowienia WHERE IdZamowienia=" + IDZamField.Text + " AND IdSpedytora=" + CarrierValue;
                OleDbDataReader reader = search.ExecuteReader();
                int count = 0;
                while (reader.Read())
                {
                    count = count + 1;
                }
                if (count == 1)
                {
                    String CurentDate = DateTime.Now.ToString("dd.MM.yyy");
                    if (StatusOrderCombo.SelectedIndex == 0) 
                    {
                        OleDbCommand UpdateStatus0 = new OleDbCommand();
                        UpdateStatus0.Connection = con;
                        string query = "UPDATE Zamowienia SET Dostarczone=0, DataWyslania='"+CurentDate+"' WHERE IdZamowienia=" + IDZamField.Text;
                        UpdateStatus0.CommandText = query;
                        UpdateStatus0.ExecuteNonQuery();
                        MessageBox.Show("Pomyślnie zaktualizowano status zamówienia!");
                    }
                    if (StatusOrderCombo.SelectedIndex == 1) 
                    {
                        OleDbCommand UpdateStatus0 = new OleDbCommand();
                        UpdateStatus0.Connection = con;
                        string query = "UPDATE Zamowienia SET IdStanu=5, Dostarczone=1, DataDostarczenia='" + CurentDate + "' WHERE IdZamowienia=" + IDZamField.Text;
                        UpdateStatus0.CommandText = query;
                        UpdateStatus0.ExecuteNonQuery();
                        MessageBox.Show("Pomyślnie zaktualizowano status zamówienia!");
                    }
                    con.Close();
                    CreateOrders();
                }
                else
                {
                    MessageBox.Show("Nie znaleziono zamówienia! Lub zamówienie nie zostało przydzielone do ciebie!");
                }
            }
        }
        private void CarrierOrdersUC_Load(object sender, EventArgs e)
        {
            CreateOrders();
        }
        private void StatusOrderCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
