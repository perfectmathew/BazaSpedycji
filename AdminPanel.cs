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
   
    public partial class AdminPanel : Form
    {
       public CarrierPanel CarrierPanel { get; set; }
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\Users\Perfectamthew\Documents\MagazynSpedycji.accdb");
        public AdminPanel()
        {
            InitializeComponent();
            dataGridView1.Hide();
            DeleteIDBOX.Hide();
            DeleteIndex.Hide();
            UserIDText.Hide();
        }

      
        private void button1_Click_1(object sender, EventArgs e)
        {
            dataGridView1.Show();
            DeleteIDBOX.Show();
            DeleteIndex.Show();
            UserIDText.Show();
            con.Open();
            OleDbCommand createKlienci = new OleDbCommand();
            createKlienci.Connection = con;
            string query = "Select * from Klienci";
            createKlienci.CommandText = query;
            OleDbDataAdapter klienci = new OleDbDataAdapter(createKlienci);
            DataTable KlienciTable = new DataTable();
            klienci.Fill(KlienciTable);
            dataGridView1.DataSource = KlienciTable;
            con.Close();

        }


        private void AdminPanel_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'magazynSpedycjiDataSet.Produkty' . Możesz go przenieść lub usunąć.

            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'magazynSpedycjiDataSet.Klienci' . Możesz go przenieść lub usunąć.

            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'magazynSpedycjiDataSet.Klienci' . Możesz go przenieść lub usunąć.



        }

        private void CarrierButton_Click(object sender, EventArgs e)
        {
         
        }

        private void DeleteIndex_Click(object sender, EventArgs e)
        {
            OleDbCommand chcek = new OleDbCommand();
            if (DeleteIDBOX.Text == "")
            {
                MessageBox.Show("Invalid value at UserID Box ");
            }
            else
            {
                try
                {

                    con.Open();
                    OleDbCommand command = new OleDbCommand();
                    OleDbCommand search = new OleDbCommand();
                    command.Connection = con;
              
                    string query = "delete from Klienci where ID=" + DeleteIDBOX.Text + "";
                    command.CommandText = query;
                    search.Connection = con;
                    search.CommandText = "SELECT * from Klienci where ID=" + DeleteIDBOX.Text + "";
                    OleDbDataReader reader = search.ExecuteReader();
                    int count = 0;
                    while (reader.Read())
                    {
                        count = count + 1;
                    }
                    if (count == 0)
                    {
                        MessageBox.Show("Użytkownik nie istnieje!");
                    }
                    else
                    {
                        command.ExecuteNonQuery();
                        MessageBox.Show("Użytkownik Usunięty!");
                    }
                  

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Napotkany problem: " + ex);
                }
                con.Close();
            }
        }
        
   
        
        private void pokaz_tabele_Click(object sender, EventArgs e)
        {
            dataGridView1.Show();
            DeleteIDBOX.Show();
            DeleteIndex.Show();
            UserIDText.Show();
            con.Open();
            //OleDbCommand createProdukty = new OleDbCommand();
            //createProdukty.Connection = con;

            switch (tabeleBox.SelectedIndex)
            {
                case 0:
                    OleDbCommand createProdukty = new OleDbCommand();
                    createProdukty.Connection = con;
                    string queryProdukty = "Select * from Produkty order by ID ASC";
                    createProdukty.CommandText = queryProdukty;
                    OleDbDataAdapter produkty = new OleDbDataAdapter(createProdukty);
                    DataTable tabelaProdukty = new DataTable();
                    produkty.Fill(tabelaProdukty);
                    dataGridView1.DataSource = tabelaProdukty;
                    con.Close();

                    break;

                case 1:
                    OleDbCommand createKlienci = new OleDbCommand();
                    createKlienci.Connection = con;
                    string queryKlienci = "Select * from Klienci";
                    createKlienci.CommandText = queryKlienci;
                    OleDbDataAdapter klienci = new OleDbDataAdapter(createKlienci);
                    DataTable KlienciTable = new DataTable();
                    klienci.Fill(KlienciTable);
                    dataGridView1.DataSource = KlienciTable;
                    con.Close();

                    break;
                case 2:
                    OleDbCommand createDostawcy = new OleDbCommand();
                    createDostawcy.Connection = con;
                    string queryDostawcy = "Select * from Dostawcy";
                    createDostawcy.CommandText = queryDostawcy;
                    OleDbDataAdapter dostawcy = new OleDbDataAdapter(createDostawcy);
                    DataTable DostawcyTable = new DataTable();
                    dostawcy.Fill(DostawcyTable);
                    dataGridView1.DataSource = DostawcyTable;
                    con.Close();
                    break;

                case 3:
                    OleDbCommand createPracownicy = new OleDbCommand();
                    createPracownicy.Connection = con;
                    string queryPracownicy = "Select * from Pracownicy";
                    createPracownicy.CommandText = queryPracownicy;
                    OleDbDataAdapter pracownicy = new OleDbDataAdapter(createPracownicy);
                    DataTable PracownicyTable = new DataTable();
                    pracownicy.Fill(PracownicyTable);
                    dataGridView1.DataSource = PracownicyTable;
                    con.Close();
                    break;

                case 4:
                    OleDbCommand createZamowienia = new OleDbCommand();
                    createZamowienia.Connection = con;
                    string queryZamowienia = "Select * from Zamowienia";
                    createZamowienia.CommandText = queryZamowienia;
                    OleDbDataAdapter zamowienia = new OleDbDataAdapter(createZamowienia);
                    DataTable ZamowieniaTable = new DataTable();
                    zamowienia.Fill(ZamowieniaTable);
                    dataGridView1.DataSource = ZamowieniaTable;
                    con.Close();
                    break;


            }









        }

        private void edycja_rdk_Click(object sender, EventArgs e)
        {

            switch (tabeleBox.SelectedIndex)
            {
                case 0:
                    this.Hide();

                    ProduktEdycja produktedycja = new ProduktEdycja();
                    produktedycja.ShowDialog();
                    produktedycja = null;
                    this.Show();

                    break;



            }

        }
    }
}
