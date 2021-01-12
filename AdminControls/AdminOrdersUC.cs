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
using System.Text.RegularExpressions;
namespace Magazyn_Spedycji.AdminControls
{
    public partial class AdminOrdersUC : Form
    {
        int permLVL = 1;
        string AdminValue;
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\Users\Perfectamthew\Documents\GitHub\BazaSpedycji\Database\MagazynSpedycji.accdb");
        public AdminOrdersUC()
        {
            InitializeComponent();
        }
        public void PermisionLevelUC(string perm)
        {
            AdminValue = perm;
        }
        private void Zamowienia()
        {
            con.Open();
            OleDbCommand createZamowienia = new OleDbCommand();
            createZamowienia.Connection = con;
            string queryZamowienia = "SELECT StanZamowien.Nazwa AS [Stan Zamowienia], Zamowienia.IdZamowienia,  Zamowienia.DataZamowienia, Zamowienia.NazwaWysylki, Zamowienia.TypPlatnosci, Zamowienia.DataZaplaty, Zamowienia.Uwagi FROM Spedytorzy INNER JOIN(StanZamowien INNER JOIN Zamowienia ON StanZamowien.IdStanu = Zamowienia.IdStanu) ON Spedytorzy.ID = Zamowienia.IdSpedytora WHERE Spedytorzy.ID NOT IN ( 4 )";
            createZamowienia.CommandText = queryZamowienia;
            OleDbDataAdapter zamowienia = new OleDbDataAdapter(createZamowienia);
            DataTable OrderTable = new DataTable();
            zamowienia.Fill(OrderTable);
            dataGridView1.DataSource = OrderTable;
            con.Close();
        }
        private void DeleteOrder_Click(object sender, EventArgs e)
        {
            if (permLVL == 1)
            {
                MessageBox.Show("Tylko Pracownicy z rolą Administrator mogą zarządzać tą sekcją!");
            }
            else
            {

            }
        }
        private void editOrder_Click(object sender, EventArgs e)
        {

        }
        private void AdminOrdersUC_Load(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand getPerm = new OleDbCommand();
            getPerm.Connection = con;
            getPerm.CommandText = "SELECT Rola FROM Pracownicy WHERE ID=" + AdminValue;
            permLVL = Convert.ToInt32(getPerm.ExecuteScalar());
            con.Close();
            Zamowienia();
        }
        private void showmore_Click(object sender, EventArgs e)
        {

        }
    }
}
