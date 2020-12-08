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
        bool poprawne = false;
        int kolumna = 0;
        string UserValue;
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\Users\Perfectamthew\Documents\MagazynSpedycji.accdb");
        public UserPanel()
        {
            InitializeComponent();
        }
        public void UserCondiction(string LoginValue)
        {
            UserValue = LoginValue;
        }
        private void schowajelementyui()
        {
            UpdateUserButton.Hide();
            ImieBox.Hide();
            NazwiskoBox.Hide();
            EmailBox.Hide();
            TelefonBox.Hide();
            AdresBox.Hide();
            MiastoBox.Hide();
            WojewodztwoBox.Hide();
            KodBox.Hide();
            KrajBox.Hide();
            LoginBox.Hide();
            hasloBox.Hide();
            label2.Hide();
            label3.Hide();
            label4.Hide();
            label5.Hide();
            label6.Hide();
            label7.Hide();
            label8.Hide();
            label9.Hide();
            label10.Hide();
            label11.Hide();
            label12.Hide();

        }
        private void pokazelementyui()
        {
            UpdateUserButton.Show();
            ImieBox.Show();
            NazwiskoBox.Show();
            EmailBox.Show();
            TelefonBox.Show();
            AdresBox.Show();
            MiastoBox.Show();
            WojewodztwoBox.Show();
            KodBox.Show();
            KrajBox.Show();
            LoginBox.Show();
            hasloBox.Show();
            label2.Show();
            label3.Show();
            label4.Show();
            label5.Show();
            label6.Show();
            label7.Show();
            label8.Show();
            label9.Show();
            label10.Show();
            label11.Show();
            label12.Show();

        }
        private void checkdata()
        {
            Regex sprawdztelefon = new Regex("^[0-9]{3}-[0-9]{3}-[0-9]{3}$");
            Regex sprawdzkodpocztowy = new Regex("^[0-9]{2}-[0-9]{3}$");
            if (ImieBox.Text == "" || NazwiskoBox.Text == "" || EmailBox.Text == "" || TelefonBox.Text== "" ||AdresBox.Text== "" || MiastoBox.Text== "" ||WojewodztwoBox.Text== "" || KodBox.Text== "" ||KrajBox.Text== "" ||LoginBox.Text== "" || hasloBox.Text== "" )
            {
                MessageBox.Show("Brak kompletu informacji!");

            }
            else if (!sprawdztelefon.IsMatch(TelefonBox.Text) || !sprawdzkodpocztowy.IsMatch(KodBox.Text))
            {
                MessageBox.Show("Niewlasciwe dane w folrmualrzu!");
            }
            else
            {
                poprawne = true;
            }
        }
        private void odswiez()
        {
            OleDbCommand createUserData = new OleDbCommand();
            createUserData.Connection = con;
            string queryData = "SELECT * FROM Klienci WHERE ID=" + UserValue + "";
            createUserData.CommandText = queryData;
            OleDbDataAdapter UserData = new OleDbDataAdapter(createUserData);
            DataTable UserDatabase = new DataTable();
            UserData.Fill(UserDatabase);
            dataGridView1.DataSource = UserDatabase;
            con.Close();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            kolumna = e.RowIndex;
            DataGridViewRow kol = dataGridView1.Rows[kolumna];
            ImieBox.Text = kol.Cells[1].Value.ToString();
            NazwiskoBox.Text = kol.Cells[2].Value.ToString();
            EmailBox.Text = kol.Cells[3].Value.ToString();
            TelefonBox.Text = kol.Cells[4].Value.ToString();
            AdresBox.Text = kol.Cells[5].Value.ToString();
           MiastoBox.Text = kol.Cells[6].Value.ToString();
            WojewodztwoBox.Text = kol.Cells[7].Value.ToString();
            KodBox.Text = kol.Cells[8].Value.ToString();
            KrajBox.Text = kol.Cells[9].Value.ToString();
            LoginBox.Text = kol.Cells[10].Value.ToString();
           hasloBox.Text = kol.Cells[11].Value.ToString();
        }
        private void UserPanel_Load(object sender, EventArgs e)
        {
            schowajelementyui();
            label1.Text = "ID KLIENTA: " + UserValue ;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            schowajelementyui();
            con.Open();
            OleDbCommand createZamowienia = new OleDbCommand();
            createZamowienia.Connection = con;
            string queryZamowienia = "SELECT Zamowienia.IdZamowienia , DataZamowienia, StanZamowien.Nazwa as [Stan Zamowienia], Zamowienia.DataWyslania, Zamowienia.Adres, Zamowienia.Miasto, Zamowienia.Wojewodztwo, Zamowienia.KodPocztowy, Zamowienia.Kraj, Zamowienia.OplatazaWysylke, Zamowienia.TypPlatnosci, Zamowienia.DataZaplaty, Zamowienia.Uwagi FROM [Zamowienia] INNER JOIN StanZamowien ON Zamowienia.IdStanu=StanZamowien.IdStanu where IdKlienta=" + UserValue + "";
            createZamowienia.CommandText = queryZamowienia;
            OleDbDataAdapter zamowienia = new OleDbDataAdapter(createZamowienia);
            DataTable OrderTable = new DataTable();
            zamowienia.Fill(OrderTable);
            dataGridView1.DataSource = OrderTable;
            con.Close();
        }

        private void MyDataOpen_Click(object sender, EventArgs e)
        {
            pokazelementyui();
            con.Open();
            OleDbCommand createUserData = new OleDbCommand();
            createUserData.Connection = con;
            string queryData = "SELECT * FROM Klienci WHERE ID="+UserValue+"";
            createUserData.CommandText = queryData;
            OleDbDataAdapter UserData = new OleDbDataAdapter(createUserData);
            DataTable UserDatabase = new DataTable();
            UserData.Fill(UserDatabase);
            dataGridView1.DataSource = UserDatabase;
            con.Close();
        }

        private void ShopOpen_Click(object sender, EventArgs e)
        {
            schowajelementyui();
            con.Open();
            OleDbCommand createSklep = new OleDbCommand();
            createSklep.Connection = con;
            string querySklep = "SELECT * FROM Produkty ORDER BY ID ASC";
            createSklep.CommandText = querySklep;
            OleDbDataAdapter sklep = new OleDbDataAdapter(createSklep);
            DataTable Sklep = new DataTable();
            sklep.Fill(Sklep);
            dataGridView1.DataSource = Sklep;
            con.Close();
        }

        private void UpdateUserButton_Click(object sender, EventArgs e)
        {
            checkdata();
            if (poprawne == true)
            {
                con.Open();
                OleDbCommand laczenie = new OleDbCommand();
                laczenie.Connection = con;
        

                string queryEdycja = "update Klienci set Imie='" + ImieBox.Text + "', Nazwisko='" + NazwiskoBox.Text + "', Telefon='" + TelefonBox.Text + "', Adres='" + AdresBox.Text + "', Miasto='" + MiastoBox.Text + "', Wojewodztwo='"+WojewodztwoBox.Text+"', KodPocztowy='"+KodBox.Text+"', Kraj='"+KrajBox.Text+"', Login='"+LoginBox.Text+"', Haslo='"+hasloBox.Text+ "' where ID=" + UserValue;
                laczenie.CommandText = queryEdycja;
                laczenie.ExecuteNonQuery();
                MessageBox.Show("Pomyślnie zaktualizowano twoje dane!");
                con.Close();
            }
            odswiez();
        }
    }
}
