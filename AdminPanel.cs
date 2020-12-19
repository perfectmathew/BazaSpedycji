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
        }

        private void pokaz_tabele_Click(object sender, EventArgs e)
        {
            dataGridView1.Show();
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
                    string queryKlienci = "Select * from Klienci order by ID ASC ";
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
                    string queryDostawcy = "Select * from Spedytorzy";
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
                    string queryPracownicy = "Select * from ZamZaku";
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
               // case 1:
            }

        }
    }
}
