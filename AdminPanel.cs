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
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= Database\MagazynSpedycji.accdb");
        string AdminValue;
        int AdminRole;
        public AdminPanel()
        {
            InitializeComponent();
            if (con.State.Equals("Open")) { con.Close(); }
            dataGridView1.Hide();
        }
        public void AdminCondiciont(string LoginValue)
        {
            AdminValue = LoginValue;
        }
        AdminControls.AdminDashboardUC dashboardUC = new AdminControls.AdminDashboardUC() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        private void spedyt_dodaj_Click(object sender, EventArgs e)
        {
            this.Hide();
            DodawanieSpedytora spedytordodaj = new DodawanieSpedytora();
            spedytordodaj.ShowDialog();
            spedytordodaj = null;
            this.Show();
        }
    
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void AdminPanel_Load(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand getPerm = new OleDbCommand();
            getPerm.Connection = con;
            getPerm.CommandText = "SELECT Rola FROM Pracownicy WHERE ID="+AdminValue;
            AdminRole = Convert.ToInt32(getPerm.ExecuteScalar());
            con.Close();
            dashboardUC.AdminUC(AdminValue);
            this.AdminControlPanel.Controls.Add(dashboardUC);
            dashboardUC.Show();
            this.AdminControlPanel.BringToFront();
            if (AdminRole == 1)
            {
                label3.Text = "Dashboard/Pracownik";
            }
            else if (AdminRole == 2)
            {
                label3.Text = "Dashboard/Administrator";
            }
        }
    }
}
