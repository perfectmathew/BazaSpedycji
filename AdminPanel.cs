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
            this.klienciTableAdapter.Fill(this.magazynSpedycjiDataSet.Klienci);

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
                        MessageBox.Show("This User, does not exist!");
                    }
                    else
                    {
                        command.ExecuteNonQuery();
                        MessageBox.Show("Data Deleted!");
                    }
                  

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unexcpected Error: " + ex);
                }
                con.Close();
            }
        }
         
    }
}
