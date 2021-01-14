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
        int kolumna = 0;
        string AdminValue;
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= Database\MagazynSpedycji.accdb");
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
            string queryZamowienia = "SELECT StanZamowien.Nazwa AS [Stan Zamowienia], Zamowienia.IdZamowienia,  Zamowienia.DataZamowienia, Zamowienia.NazwaWysylki, Zamowienia.DataDostarczenia, Zamowienia.TypPlatnosci, Zamowienia.DataZaplaty, Zamowienia.Uwagi FROM Spedytorzy INNER JOIN(StanZamowien INNER JOIN Zamowienia ON StanZamowien.IdStanu = Zamowienia.IdStanu) ON Spedytorzy.ID = Zamowienia.IdSpedytora WHERE Spedytorzy.ID NOT IN ( 4 ) AND Archiwum=0";
            createZamowienia.CommandText = queryZamowienia;
            OleDbDataAdapter zamowienia = new OleDbDataAdapter(createZamowienia);
            DataTable OrderTable = new DataTable();
            zamowienia.Fill(OrderTable);
            dataGridView1.DataSource = OrderTable;
            con.Close();
        }
        private void Zamowieniaadm()
        {
            con.Open();
            OleDbCommand createZamowienia = new OleDbCommand();
            createZamowienia.Connection = con;
            string queryZamowienia = "SELECT StanZamowien.Nazwa AS [Stan Zamowienia], Zamowienia.IdZamowienia, Zamowienia.DataZamowienia, Zamowienia.NazwaWysylki, Zamowienia.TypPlatnosci, Zamowienia.DataZaplaty, Zamowienia.Uwagi FROM Spedytorzy INNER JOIN (StanZamowien INNER JOIN Zamowienia ON StanZamowien.IdStanu = Zamowienia.IdStanu) ON Spedytorzy.ID = Zamowienia.IdSpedytora WHERE (((Zamowienia.Archiwum)=True))";
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
                int wIlosc = 0;
                bool isNumber = false;
                isNumber = int.TryParse(idorder.Text, out wIlosc);
                if (idorder.Text == "" || !isNumber) MessageBox.Show("Nie wybrałeś zamówienia!");
                else
                {
                    DialogResult result = MessageBox.Show("Ta opcja przeniesie zamówienie do archiwum, czy napewno chesz to zrobić?", "Uwaga!", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        con.Open();
                        OleDbCommand checker = new OleDbCommand();
                        checker.Connection = con;
                        checker.CommandText = "SELECT IdZamowienia FROM Zamowienia WHERE  IdZamowienia=" + idorder.Text + "";
                        OleDbDataReader reader = checker.ExecuteReader();
                        int count = 0;
                        while (reader.Read())
                        {
                            count = count + 1;
                        }
                        if (count == 1)
                        {
                            OleDbCommand updater = new OleDbCommand();
                            updater.Connection = con;
                            updater.CommandText = "UPDATE Zamowienia SET Archiwum=1 WHERE  IdZamowienia=" + idorder.Text + "";
                            updater.ExecuteNonQuery();
                            reader.Close();
                            Zamowienia();
                        }
                        else
                        {
                            MessageBox.Show("Nie znaleziono zamówienia!");
                        }
                        con.Close();
                    }
                    else if (result == DialogResult.No)
                    {

                    }
                }
            }
        }
        private void editOrder_Click(object sender, EventArgs e)
        {
            int wIlosc = 0;
            bool isNumber = false;
            isNumber = int.TryParse(idorder.Text, out wIlosc);
            if (actionbox.SelectedIndex==-1 || idorder.Text == "" || !isNumber)
            {
                MessageBox.Show("Wpisz ID zamówienia i wybierz akcję jaką chcesz wykonać!");
            }
            else
            {
                con.Open();
                OleDbCommand checker = new OleDbCommand();
                checker.Connection = con;
                checker.CommandText = "SELECT IdZamowienia FROM Zamowienia WHERE  IdZamowienia=" + idorder.Text + "";
                OleDbDataReader reader = checker.ExecuteReader();
           
                int count = 0;
                while (reader.Read())
                {
                    count = count + 1;
                }
                if (count == 0)
                {
                    MessageBox.Show("Nie znaleziono zamówienia!");
                    con.Close();
                }
                else
                {
                    con.Close();
                    if (actionbox.SelectedIndex == 0)
                    {
                        con.Open();
                        OleDbCommand updater = new OleDbCommand();
                        updater.Connection = con;
                        updater.CommandText = "Update Zamowienia SET IdPracownika=" + AdminValue + " WHERE IdZamowienia=" + idorder.Text + "";
                        updater.ExecuteNonQuery();
                        OleDbCommand updateStan = new OleDbCommand();
                        updateStan.Connection = con;
                        updateStan.CommandText = "UPDATE Zamowienia SET IdStanu=2 WHERE IdZamowienia=" + idorder.Text + "";
                        updateStan.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Pomyślnie zmieniono status zamówienia!");
                        Zamowienia();
                    }
                    else if (actionbox.SelectedIndex == 1)
                    {
                        con.Open();
                        OleDbCommand updater = new OleDbCommand();
                        updater.Connection = con;
                        updater.CommandText = "Update Zamowienia SET IdPracownika=" + AdminValue + " WHERE IdZamowienia=" + idorder.Text + "";
                        updater.ExecuteNonQuery();
                        String CurentDate = DateTime.Now.ToString("dd.MM.yyy");
                        OleDbCommand updateStan = new OleDbCommand();
                        updateStan.Connection = con;
                        updateStan.CommandText = "UPDATE Zamowienia SET IdStanu=3, DataWyslania='" + CurentDate + "' WHERE IdZamowienia=" + idorder.Text + "";
                        updateStan.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Pomyślnie zmieniono status zamówienia!");
                        Zamowienia();
                    }
                    else if (actionbox.SelectedIndex == 2)
                    {

                        DialogResult result = MessageBox.Show("Czy chcesz automatycznie przenieść zamówienie do archiwum?", "UWAGA!", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            con.Open();
                            OleDbCommand updater = new OleDbCommand();
                            updater.Connection = con;
                            updater.CommandText = "Update Zamowienia SET IdPracownika=" + AdminValue + " WHERE IdZamowienia=" + idorder.Text + "";
                            updater.ExecuteNonQuery();
                            OleDbCommand updateStan = new OleDbCommand();
                            updateStan.Connection = con;
                            updateStan.CommandText = "UPDATE Zamowienia SET IdStanu=4 WHERE IdZamowienia=" + idorder.Text + "";
                            updateStan.ExecuteNonQuery();
                            OleDbCommand archive = new OleDbCommand();
                            archive.Connection = con;
                            archive.CommandText = "UPDATE Zamowienia SET Archiwum=1 WHERE  IdZamowienia=" + idorder.Text + "";
                            archive.ExecuteNonQuery();
                            con.Close();
                            MessageBox.Show("Pomyślnie zmieniono status zamówienia i przeniesiono do  archiwum!");
                            Zamowienia();
                        }
                        else if (result == DialogResult.No)
                        {
                            con.Open();
                            OleDbCommand updater = new OleDbCommand();
                            updater.Connection = con;
                            updater.CommandText = "Update Zamowienia SET IdPracownika=" + AdminValue + " WHERE IdZamowienia=" + idorder.Text + "";
                            updater.ExecuteNonQuery();
                            OleDbCommand updateStan = new OleDbCommand();
                            updateStan.Connection = con;
                            updateStan.CommandText = "UPDATE Zamowienia SET IdStanu=4 WHERE IdZamowienia=" + idorder.Text + "";
                            updateStan.ExecuteNonQuery();

                            con.Close();
                            MessageBox.Show("Pomyślnie zmieniono status zamówienia!");
                            Zamowienia();
                        }
                    }
                }
            }
        }
        private void AdminOrdersUC_Load(object sender, EventArgs e)
        {
            backtoorders.Hide();
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
            int wIlosc = 0;
            bool isNumber = false;
            isNumber = int.TryParse(idorder.Text, out wIlosc);
            if (idorder.Text == "" || !isNumber) MessageBox.Show("Wpisz ID Zamówienia!");
            else
            {
                backtoorders.Show();
                con.Open();
                OleDbCommand checker = new OleDbCommand();
                checker.Connection = con;
                checker.CommandText = "SELECT IdZamowienia FROM Zamowienia WHERE  IdZamowienia=" + idorder.Text + "";
                OleDbDataReader reader = checker.ExecuteReader();
                int count = 0;
                while (reader.Read())
                {
                    count = count + 1;
                }
                if (count == 0) MessageBox.Show("To zamówienie nie istnieje!");
                else
                {
                    OleDbCommand createKoszyk = new OleDbCommand();
                    createKoszyk.Connection = con;
                    string queryKoszyk = "SELECT Produkty.NazwaProduktu AS [Nazwa Produktu], SzczegolyZamowienia.Ilosc, Produkty.CenaJednostkowa AS [Cena Jednostkowa], Produkty.CenaJednostkowa*SzczegolyZamowienia.Ilosc AS [Cena Ogolna] FROM Produkty INNER JOIN(Klienci INNER JOIN SzczegolyZamowienia ON Klienci.ID = SzczegolyZamowienia.IDKlienta) ON Produkty.ID = SzczegolyZamowienia.IdProduktu WHERE SzczegolyZamowienia.IdZamowienia = " + idorder.Text + "  AND IdProduktu NOT IN ( 8 )";
                    createKoszyk.CommandText = queryKoszyk;
                    OleDbDataAdapter koszyk = new OleDbDataAdapter(createKoszyk);
                    DataTable Koszyk = new DataTable();
                    koszyk.Fill(Koszyk);
                    dataGridView1.DataSource = Koszyk;
                }
                con.Close();
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            kolumna = e.RowIndex;
            if (kolumna < 0) MessageBox.Show("Wybierz użytkownika!");
            else
            {
                DataGridViewRow kol = dataGridView1.Rows[kolumna];
                idorder.Text = kol.Cells[1].Value.ToString();
            }
        }
        private void backtoorders_Click(object sender, EventArgs e)
        {
            backtoorders.Hide();
            Zamowienia();
        }
        private void orderhistory_Click(object sender, EventArgs e)
        {
            if (permLVL == 1)
            {
                MessageBox.Show("Tylko Pracownicy z rolą Administrator mogą zarządzać tą sekcją!");
            }
            else if (permLVL == 2)
            {
                backtoorders.Show();
                Zamowieniaadm();
            }
        }
    }
}
