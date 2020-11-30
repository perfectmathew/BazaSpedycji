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
    
    public partial class UserPanel : Form
    {
        string test;
        public void ab(string LoginValue)
        {
            test = LoginValue.ToString();
        }
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\Users\Perfectamthew\Documents\MagazynSpedycji.accdb");
        public UserPanel()
        {
            InitializeComponent();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
      
        private void UserPanel_Load(object sender, EventArgs e)
        {
          
            con.Open();
            OleDbCommand createKlienci = new OleDbCommand();
            createKlienci.Connection = con;
            string query = "Select * from Klienci WHERE ID="+test+"";
            createKlienci.CommandText = query;
            OleDbDataAdapter klienci = new OleDbDataAdapter(createKlienci);
            DataTable KlienciTable = new DataTable();
            klienci.Fill(KlienciTable);
            dataGridView1.DataSource = KlienciTable;
            con.Close();
        }
    }
}
