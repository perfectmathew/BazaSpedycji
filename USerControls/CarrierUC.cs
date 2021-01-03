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
namespace Magazyn_Spedycji.USerControls
{
  
    public partial class CarrierUC : Form
    {
     
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\Users\Perfectamthew\Documents\GitHub\BazaSpedycji\Database\MagazynSpedycji.accdb");
        string CarrierValue;
        string imieSpedytora;
        string nazwiskoSpedytora;
        string EmailSpedytora;
        string TelefonSpedytora;
        string LoginSpedytora;
        string HasloSpedytora;
     
        public void getData()
        {
            con.Open();
            OleDbCommand getImie = new OleDbCommand();
            getImie.Connection = con;
            getImie.CommandText = "Select Imie FROM Spedytorzy WHERE ID=" + CarrierValue;
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
            NameText.Text = imieSpedytora;
            SurrnameText.Text = nazwiskoSpedytora;
            EmailText.Text = EmailSpedytora;
            PhoneText.Text = TelefonSpedytora;
            LoginText.Text = LoginSpedytora;
            PassText.Text = HasloSpedytora;
        }

        public CarrierUC()
        {
            InitializeComponent();
         
        }
        public void next(string LoginValue)
        {
            CarrierValue = LoginValue.ToString();
        }
        private void UpdateCarrirerData_Click(object sender, EventArgs e)
        {

        }

        private void CarrierUC_Load(object sender, EventArgs e)
        {
            getData();
        }
    }
}
