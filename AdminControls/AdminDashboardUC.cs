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
namespace Magazyn_Spedycji.AdminControls
{
    public partial class AdminDashboardUC : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\Users\Perfectamthew\Documents\GitHub\BazaSpedycji\Database\MagazynSpedycji.accdb");
        string AdminValue;
        string AdminName;
        int AdminRole;
        private void getname()
        {
            con.Open();
            OleDbCommand adminames = new OleDbCommand();
            adminames.Connection = con;
            adminames.CommandText = "SELECT Imie From Pracownicy WHERE ID="+AdminValue;
            AdminName = adminames.ExecuteScalar().ToString();
            OleDbCommand getPerm = new OleDbCommand();
            getPerm.Connection = con;
            getPerm.CommandText = "SELECT Rola FROM Pracownicy WHERE ID=" + AdminValue;
            AdminRole = Convert.ToInt32(getPerm.ExecuteScalar());
            con.Close();
            
        }
        public AdminDashboardUC()
        {
            InitializeComponent();
        }
        public void AdminUC(string AdmValue)
        {
            AdminValue = AdmValue;
        }
        private void AdminDashboardUC_Load(object sender, EventArgs e)
        {
            getname();
            label1.Text = "Witaj, " + AdminName+"!";
          
        }

        private void Pracownicy_Click(object sender, EventArgs e)
        {
            if (AdminRole == 1)
            {
                MessageBox.Show("Tylko Pracownicy z rolą Administrator mogą zarządzać tą sekcją!");
            }
            else
            {
                this.Hide();
                PracownicyEdycja edytujpracownik = new PracownicyEdycja();
                edytujpracownik.ShowDialog();
                edytujpracownik = null;
                this.Show();
            }
        }
        private void ProductsControl_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProduktEdycja produktedycja = new ProduktEdycja();
            produktedycja.ShowDialog();
            produktedycja = null;
            this.Show();
        }
        private void UserControl_Click(object sender, EventArgs e)
        {
            this.Hide();
            KlientEdycja klientedycja = new KlientEdycja();
            klientedycja.ShowDialog();
            klientedycja = null;
            this.Show();
        }
        private void CarrierControl_Click(object sender, EventArgs e)
        {
            this.Hide();
            SpedytorzyEdycja edytujspedytor = new SpedytorzyEdycja();
            edytujspedytor.ShowDialog();
            edytujspedytor = null;
            this.Show();
        }
    }
}
