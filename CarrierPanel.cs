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
      //  string CarrierValue;
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\Users\Perfectamthew\Documents\MagazynSpedycji.accdb");
        public CarrierPanel()
        {
            InitializeComponent();
           
        }
      /*  public void ab(string LoginValue)
        {
            //CarrierValue = LoginValue.ToString();
        }*/ //Funkcja pobiera login 
        private void CarrierPanel_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'magazynSpedycjiDataSet.Zamowienia' . Możesz go przenieść lub usunąć.
            this.zamowieniaTableAdapter.Fill(this.magazynSpedycjiDataSet.Zamowienia);

        }

        private void UpdateOrderButton_Click(object sender, EventArgs e)
        {
          //  MessageBox.Show(CarrierValue.ToString()); //
               
            if (IDZamField.Text!="" || StanZamField.Text=="1" || StanZamField.Text == "2" || StanZamField.Text == "3")
            {


                // string query= "Update Zamowienia SET IdStanu = "+StanZamField.Text+ " WHERE IdZamowienia = " + IDZamField.Text + "";
                try
                {

                    con.Open();
                    OleDbCommand command = new OleDbCommand();
                    OleDbCommand search = new OleDbCommand();
                    command.Connection = con;

                    string query = "Update Zamowienia SET IdStanu = " + StanZamField.Text + " WHERE IdZamowienia = " + IDZamField.Text + "";
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
                        this.zamowieniaTableAdapter.Fill(this.magazynSpedycjiDataSet.Zamowienia);
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Napotkany problem: " + ex);
                }
                con.Close();
            }
            else
            {
                MessageBox.Show("Nieprawidłowy format!");
            }
        }
    }
}
