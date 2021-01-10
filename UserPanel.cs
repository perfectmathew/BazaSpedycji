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
namespace Magazyn_Spedycji
{

    public partial class UserPanel : Form
    {
        string UserValue;  
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\Users\Perfectamthew\Documents\GitHub\BazaSpedycji\Database\MagazynSpedycji.accdb");
        public UserPanel()
        {
            InitializeComponent();
          
        }
        public void UserCondiction(string LoginValue)
        {
            UserValue = LoginValue;
        }
        private void UserPanel_Load(object sender, EventArgs e)
        { 
            OrdersPanel.Hide();
            UserData.Hide();     
        }
        USerControls.UserOrdersUC ordersuC = new USerControls.UserOrdersUC() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        USerControls.UserUC uC = new USerControls.UserUC() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        USerControls.ShopUC shopuC = new USerControls.ShopUC() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        private void button3_Click(object sender, EventArgs e)
        {
            shopuC.Hide();
            uC.Hide();
            this.OrdersPanel.Show();
            con.Open();
            OleDbCommand newuser = new OleDbCommand();
            newuser.Connection = con;
            newuser.CommandText = "select ID from Klienci where ID=" + UserValue + "";
            Int32 IDK = (Int32)newuser.ExecuteScalar();
            ordersuC.OrderCondiction(IDK.ToString());
            con.Close();
            this.OrdersPanel.Controls.Add(ordersuC);
            ordersuC.Show();
            this.ordersuC.BringToFront();
        }
        private void MyDataOpen_Click(object sender, EventArgs e)
        {
            shopuC.Hide();
            ordersuC.Hide();
            this.UserData.Show();
            con.Open();
            OleDbCommand newuser = new OleDbCommand();
            newuser.Connection = con;
            newuser.CommandText = "select ID from Klienci where ID=" + UserValue + "";
            Int32 IDK = (Int32)newuser.ExecuteScalar();
            uC.ab(IDK.ToString());
            con.Close();
            this.UserData.Controls.Add(uC);
            uC.Show();
            this.uC.BringToFront();
        }
        private void ShopOpen_Click(object sender, EventArgs e)
        {
            ordersuC.Hide();
            uC.Hide();
            this.ShopPanel.Show();
            con.Open();
            OleDbCommand openshop = new OleDbCommand();
            openshop.Connection = con;
            openshop.CommandText = "select ID from Klienci where ID=" + UserValue + "";
            Int32 IDK = (Int32)openshop.ExecuteScalar();
            shopuC.ShopCondiction(IDK.ToString());
            con.Close();
            this.ShopPanel.Controls.Add(shopuC);
            shopuC.Show();
            this.shopuC.BringToFront();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
