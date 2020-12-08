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
namespace Magazyn_Spedycji
{
    public partial class CarrierPanel : Form
    {
        string CarrierValue;
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\Users\Perfectamthew\Documents\MagazynSpedycji.accdb");
        public CarrierPanel()
        {
            InitializeComponent();
        }
         public void ab(string LoginValue)
        {
            CarrierValue = LoginValue.ToString();
        }
        private void CarrierPanel_Load(object sender, EventArgs e)
        {
            
            con.Open();
            OleDbCommand createSpedytorzy = new OleDbCommand();
            createSpedytorzy.Connection = con; 
            string querySpedytorzy = "Select Zamowienia.NazwaWysylki, StanZamowien.Nazwa, Zamowienia.IdZamowienia, Zamowienia.IdKlienta,DataZamowienia, Zamowienia.DataWyslania, Zamowienia.Adres, Zamowienia.Miasto, Zamowienia.Wojewodztwo, Zamowienia.KodPocztowy, Zamowienia.Kraj, Zamowienia.OplatazaWysylke, Zamowienia.TypPlatnosci, Zamowienia.DataZaplaty, Zamowienia.Uwagi from Zamowienia INNER JOIN StanZamowien ON Zamowienia.IdStanu=StanZamowien.IdStanu where IdSpedytora=" + CarrierValue+"";
            createSpedytorzy.CommandText = querySpedytorzy;
            OleDbDataAdapter spedytorzy = new OleDbDataAdapter(createSpedytorzy);
            DataTable SpedytorzyTable = new DataTable();
            spedytorzy.Fill(SpedytorzyTable);
            dataGridView1.DataSource = SpedytorzyTable;
            con.Close();

        }

        private void UpdateOrderButton_Click(object sender, EventArgs e)
        {
            if (StatusOrderCombo.SelectedIndex == -1)
            {
                MessageBox.Show("Wybierz poziom uprawnień!");
            }
            if (StatusOrderCombo.SelectedIndex == 0)
            {
                try
                {

                    con.Open();
                    OleDbCommand command = new OleDbCommand();
                    OleDbCommand search = new OleDbCommand();
                    command.Connection = con;

                    string query = "Update Zamowienia SET IdStanu = " + 2 + " WHERE IdZamowienia = " + IDZamField.Text + "";
                    command.CommandText = query;
                    search.Connection = con;
                    search.CommandText = "SELECT * from Zamowienia where IdZamowienia=" + IDZamField.Text + "";
                    OleDbDataReader reader = search.ExecuteReader();
                    int count = 0;
                    while (reader.Read())
                    {
                        count = count + 1;
                    }
                    if (count == 0)
                    {
                        MessageBox.Show("Zamówienie nie istnieje");
                    }
                    else
                    {
                        command.ExecuteNonQuery();
                        MessageBox.Show("Stan zamówienia zaktualizowany!");
                     
                        OleDbCommand createSpedytorzy = new OleDbCommand();
                        createSpedytorzy.Connection = con;
                        string querySpedytorzy = "Select Zamowienia.NazwaWysylki, StanZamowien.Nazwa, Zamowienia.IdZamowienia, Zamowienia.IdKlienta,DataZamowienia, Zamowienia.DataWyslania, Zamowienia.Adres, Zamowienia.Miasto, Zamowienia.Wojewodztwo, Zamowienia.KodPocztowy, Zamowienia.Kraj, Zamowienia.OplatazaWysylke, Zamowienia.TypPlatnosci, Zamowienia.DataZaplaty, Zamowienia.Uwagi from Zamowienia INNER JOIN StanZamowien ON Zamowienia.IdStanu=StanZamowien.IdStanu where IdSpedytora=" + CarrierValue + "";
                        createSpedytorzy.CommandText = querySpedytorzy;
                        OleDbDataAdapter spedytorzy = new OleDbDataAdapter(createSpedytorzy);
                        DataTable SpedytorzyTable = new DataTable();
                        spedytorzy.Fill(SpedytorzyTable);
                        dataGridView1.DataSource = SpedytorzyTable;
                  
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Napotkany problem: " + ex);
                }
                con.Close();
            }
            if (StatusOrderCombo.SelectedIndex == 1)
            {
                try
                {

                    con.Open();
                    OleDbCommand command = new OleDbCommand();
                    OleDbCommand search = new OleDbCommand();
                    command.Connection = con;

                    string query = "Update Zamowienia SET IdStanu = " + 3 + " WHERE IdZamowienia = " + IDZamField.Text + "";
                    command.CommandText = query;
                    search.Connection = con;
                    search.CommandText = "SELECT * from Zamowienia where IdZamowienia=" + IDZamField.Text + "";
                    OleDbDataReader reader = search.ExecuteReader();
                    int count = 0;
                    while (reader.Read())
                    {
                        count = count + 1;
                    }
                    if (count == 0)
                    {
                        MessageBox.Show("Zamówienie nie istnieje");
                    }
                    else
                    {
                        command.ExecuteNonQuery();
                        MessageBox.Show("Stan zamówienia zaktualizowany!");

                        OleDbCommand createSpedytorzy = new OleDbCommand();
                        createSpedytorzy.Connection = con;
                        string querySpedytorzy = "Select Zamowienia.NazwaWysylki, StanZamowien.Nazwa, Zamowienia.IdZamowienia, Zamowienia.IdKlienta,DataZamowienia, Zamowienia.DataWyslania, Zamowienia.Adres, Zamowienia.Miasto, Zamowienia.Wojewodztwo, Zamowienia.KodPocztowy, Zamowienia.Kraj, Zamowienia.OplatazaWysylke, Zamowienia.TypPlatnosci, Zamowienia.DataZaplaty, Zamowienia.Uwagi from Zamowienia INNER JOIN StanZamowien ON Zamowienia.IdStanu=StanZamowien.IdStanu where IdSpedytora=" + CarrierValue + "";
                        createSpedytorzy.CommandText = querySpedytorzy;
                        OleDbDataAdapter spedytorzy = new OleDbDataAdapter(createSpedytorzy);
                        DataTable SpedytorzyTable = new DataTable();
                        spedytorzy.Fill(SpedytorzyTable);
                        dataGridView1.DataSource = SpedytorzyTable;

                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Napotkany problem: " + ex);
                }
                con.Close();
            }


        }
    }
}
