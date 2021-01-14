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
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= Database\MagazynSpedycji.accdb");
        public CarrierPanel()
        {
            InitializeComponent();

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
          
            con.Close();
        }

        private void CarrierPanel_Load(object sender, EventArgs e)
        {
            getData();
            CarrierEditData.Hide();
            StanZamText.Text = "Witaj, "+imieSpedytora;
        }

    
        USerControls.CarrierUC uC = new USerControls.CarrierUC() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        USerControls.CarrierOrdersUC uOrdersC = new USerControls.CarrierOrdersUC() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        private void changedataswitch_Click(object sender, EventArgs e)
        {

          
            uOrdersC.Hide();
            this.CarrierEditData.Show();
            con.Open();
            
            OleDbCommand newcarrier = new OleDbCommand();
            newcarrier.Connection = con;
            newcarrier.CommandText = "select ID from Spedytorzy where ID="+CarrierValue+"";
            Int32 IDK = (Int32)newcarrier.ExecuteScalar();
            uC.next(IDK.ToString());
            con.Close();
            this.CarrierEditData.Controls.Add(uC);
            uC.Show();
            this.uC.BringToFront();
            
        }
        private void OrdresSwitch_Click(object sender, EventArgs e)
        {


            uC.Hide();
            this.CarrierOrdersPanel.Show();
            con.Open();
             OleDbCommand newcarrier = new OleDbCommand();
            newcarrier.Connection = con;
            newcarrier.CommandText = "select ID from Spedytorzy where ID="+CarrierValue+"";
            Int32 IDK = (Int32)newcarrier.ExecuteScalar();
            uOrdersC.OrderValueUC(IDK.ToString());
            con.Close();
            this.CarrierOrdersPanel.Controls.Add(uOrdersC);
            uOrdersC.Show();
            this.uOrdersC.BringToFront();
        }
    }
}
