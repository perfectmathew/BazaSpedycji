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
        string imieSpedytora;
        string nazwiskoSpedytora;
        string EmailSpedytora;
        string TelefonSpedytora;
        string LoginSpedytora;
        string HasloSpedytora;
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\Users\wojna\Desktop\BazaSpedycji-main\Database\MagazynSpedycji.accdb");
        public CarrierPanel()
        {
            InitializeComponent();
        }
        private void odswiez()
        {
           
            OleDbCommand createSpedytorzy = new OleDbCommand();
            createSpedytorzy.Connection = con;
            string querySpedytorzy = "SELECT Zamowienia.IdZamowienia, Zamowienia.NazwaWysylki, StanZamowien.Nazwa AS StanZamowienia, Zamowienia.DataZamowienia, Klienci.Imie, Klienci.Nazwisko, Klienci.Telefon, Klienci.Adres, Klienci.Miasto, Klienci.Wojewodztwo, Klienci.KodPocztowy, Klienci.Kraj FROM StanZamowien INNER JOIN(Spedytorzy INNER JOIN (Klienci INNER JOIN Zamowienia ON Klienci.ID = Zamowienia.IdKlienta) ON Spedytorzy.ID = Zamowienia.IdSpedytora) ON StanZamowien.IdStanu = Zamowienia.IdStanu WHERE Zamowienia.IdSpedytora=" + CarrierValue + "";
            createSpedytorzy.CommandText = querySpedytorzy;
            OleDbDataAdapter spedytorzy = new OleDbDataAdapter(createSpedytorzy);
            DataTable SpedytorzyTable = new DataTable();
            spedytorzy.Fill(SpedytorzyTable);
            dataGridView1.DataSource = SpedytorzyTable;
            
        }
        public void ab(string LoginValue)
        {
            CarrierValue = LoginValue.ToString();
        }
        public void getData()
        {
            con.Open();
            OleDbCommand getImie = new OleDbCommand();
            getImie.Connection = con;
            getImie.CommandText = "Select Imie FROM Spedytorzy WHERE ID="+CarrierValue;
            imieSpedytora = (string)getImie.ExecuteScalar();
            OleDbCommand getNazwisko = new OleDbCommand();
            getNazwisko.Connection = con;
            getNazwisko.CommandText = "Select Nazwisko FROM Spedytorzy WHERE ID=" + CarrierValue;
            nazwiskoSpedytora = (string)getNazwisko.ExecuteScalar();
            OleDbCommand getEmail = new OleDbCommand();
            getEmail.Connection = con;
            getEmail.CommandText = "Select Email FROM Spedytorzy WHERE ID=" + CarrierValue;
            EmailSpedytora = (string)getEmail.ExecuteScalar();
            OleDbCommand getTelefon = new OleDbCommand();
            getTelefon.Connection = con;
            getTelefon.CommandText = "Select Telefon FROM Spedytorzy WHERE ID=" + CarrierValue;
            TelefonSpedytora = (string)getTelefon.ExecuteScalar();
            OleDbCommand getLogin = new OleDbCommand();
            getLogin.Connection = con;
            getLogin.CommandText = "Select Login FROM Spedytorzy WHERE ID=" + CarrierValue;
            LoginSpedytora = (string)getLogin.ExecuteScalar();
            OleDbCommand getHaslo = new OleDbCommand();
            getHaslo.Connection = con;
            getHaslo.CommandText = "Select Haslo FROM Spedytorzy WHERE ID=" + CarrierValue;
            HasloSpedytora = (string)getHaslo.ExecuteScalar();
            con.Close();
        }
        private void CarrierPanel_Load(object sender, EventArgs e)
        {
            IDspedy.Text = "Twoje unikalne ID: "+CarrierValue;
            getData();
         //   MessageBox.Show(imieSpedytora+nazwiskoSpedytora+EmailSpedytora+TelefonSpedytora+LoginSpedytora+HasloSpedytora);
            con.Open();
            OleDbCommand createSpedytorzy = new OleDbCommand();
            createSpedytorzy.Connection = con; 
            string querySpedytorzy = "SELECT Zamowienia.IdZamowienia, Zamowienia.NazwaWysylki, StanZamowien.Nazwa AS StanZamowienia, Zamowienia.DataZamowienia, Klienci.Imie, Klienci.Nazwisko, Klienci.Telefon, Klienci.Adres, Klienci.Miasto, Klienci.Wojewodztwo, Klienci.KodPocztowy, Klienci.Kraj FROM StanZamowien INNER JOIN(Spedytorzy INNER JOIN (Klienci INNER JOIN Zamowienia ON Klienci.ID = Zamowienia.IdKlienta) ON Spedytorzy.ID = Zamowienia.IdSpedytora) ON StanZamowien.IdStanu = Zamowienia.IdStanu WHERE Zamowienia.IdSpedytora="+CarrierValue+"";
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
                MessageBox.Show("Wybierz Status zamówienia!");
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

                        odswiez();
                  
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

                        odswiez();

                    }

                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Napotkany problem: " + ex);
                }
            con.Close();

            }

        }

        private void changedataswitch_Click(object sender, EventArgs e)
        {

        }
    }
}
