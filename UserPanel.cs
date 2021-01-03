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
        string UserValue;
        string imieKlienta;
        string nazwiskoKlienta;
        string EmailKlienta;
        string telefonKlienta;
        string adresKlienta;
        string miastoKlienta;
        string wojewodztwoKlienta;
        string kodpocztowyKlienta;
        string krajKlienta;
        string loginKlienta;
        string hasloKlienta;
        private PaySystem paySystem;

        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\Users\Perfectamthew\Documents\GitHub\BazaSpedycji\Database\MagazynSpedycji.accdb");




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
            Amount.Hide();
            ProdutsCode.Hide();
            ToCart.Hide();
            showcart.Hide();
          
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
        private void getUserData()
        {
            con.Open();
            OleDbCommand getImie = new OleDbCommand();
            getImie.Connection = con;
            getImie.CommandText = "Select Imie FROM Klienci WHERE ID=" + UserValue;
            imieKlienta = (string)getImie.ExecuteScalar();
            OleDbCommand getNazwisko = new OleDbCommand();
            getNazwisko.Connection = con;
            getNazwisko.CommandText = "Select Nazwisko FROM Klienci WHERE ID=" + UserValue;
            nazwiskoKlienta = (string)getNazwisko.ExecuteScalar();
            OleDbCommand getEmail = new OleDbCommand();
            getEmail.Connection = con;
            getEmail.CommandText = "Select Email FROM Klienci WHERE ID=" + UserValue;
            EmailKlienta = (string)getEmail.ExecuteScalar();
            OleDbCommand getTelefon = new OleDbCommand();
            getTelefon.Connection = con;
            getTelefon.CommandText = "Select Telefon FROM Klienci WHERE ID=" + UserValue;
            telefonKlienta = (string)getTelefon.ExecuteScalar();
            OleDbCommand getAdres = new OleDbCommand();
            getAdres.Connection = con;
            getAdres.CommandText = "Select Adres FROM Klienci WHERE ID=" + UserValue;
            adresKlienta = (string)getAdres.ExecuteScalar();
            OleDbCommand getMiasto = new OleDbCommand();
            getMiasto.Connection = con;
            getMiasto.CommandText = "Select Miasto FROM Klienci WHERE ID=" + UserValue;
            miastoKlienta = (string)getMiasto.ExecuteScalar();
            OleDbCommand getWoj = new OleDbCommand();
            getWoj.Connection = con;
            getWoj.CommandText = "Select Wojewodztwo FROM Klienci WHERE ID=" + UserValue;
            wojewodztwoKlienta = (string)getWoj.ExecuteScalar();
            OleDbCommand getPostal = new OleDbCommand();
            getPostal.Connection = con;
            getPostal.CommandText = "Select KodPocztowy FROM Klienci WHERE ID=" + UserValue;
            kodpocztowyKlienta = (string)getPostal.ExecuteScalar();
            OleDbCommand getKraj = new OleDbCommand();
            getKraj.Connection = con;
            getKraj.CommandText = "Select Kraj FROM Klienci WHERE ID=" + UserValue;
            krajKlienta = (string)getKraj.ExecuteScalar();
            OleDbCommand getLogin = new OleDbCommand();
            getLogin.Connection = con;
            getLogin.CommandText = "Select Login FROM Klienci WHERE ID=" + UserValue;
            loginKlienta = (string)getLogin.ExecuteScalar();
            OleDbCommand getHaslo = new OleDbCommand();
            getHaslo.Connection = con;
            getHaslo.CommandText = "Select Haslo FROM Klienci WHERE ID=" + UserValue;
            hasloKlienta = (string)getHaslo.ExecuteScalar();
            con.Close();
            ImieBox.Text = imieKlienta;
            NazwiskoBox.Text = nazwiskoKlienta;
            EmailBox.Text = EmailKlienta;
            TelefonBox.Text = telefonKlienta;
            AdresBox.Text = adresKlienta;
            MiastoBox.Text = miastoKlienta;
            WojewodztwoBox.Text = wojewodztwoKlienta;
            KodBox.Text = kodpocztowyKlienta;
            KrajBox.Text = krajKlienta;
            LoginBox.Text = loginKlienta;
            hasloBox.Text = hasloKlienta;
        }
        private void otworzsklep()
        {
            con.Open();
            OleDbCommand createSklep = new OleDbCommand();
            createSklep.Connection = con;
            string querySklep = "SELECT KodProduktu,NazwaProduktu,Opis,CenaJednostkowa,Ilosc FROM Produkty WHERE ID NOT IN ( 8 ) ORDER BY ID ASC";
            createSklep.CommandText = querySklep;
            OleDbDataAdapter sklep = new OleDbDataAdapter(createSklep);
            DataTable Sklep = new DataTable();
            sklep.Fill(Sklep);
            dataGridView1.DataSource = Sklep;
            con.Close();
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
            string queryData = "SELECT Imie,Nazwisko,Email,Telefon,Adres,Miasto,Wojewodztwo,KodPocztowy,Kraj,Login,Haslo FROM Klienci WHERE ID=" + UserValue + "";
            createUserData.CommandText = queryData;
            OleDbDataAdapter UserData = new OleDbDataAdapter(createUserData);
            DataTable UserDatabase = new DataTable();
            UserData.Fill(UserDatabase);
            dataGridView1.DataSource = UserDatabase;
            con.Close();
        }
        private void UserPanel_Load(object sender, EventArgs e)
        {
            showMore.Hide();
            IDOrder.Hide();
            label15.Hide();
            label13.Hide();
            label14.Hide();
            schowajelementyui();
            CreateOrder.Hide();
            DeleteFromCart.Hide();
            label1.Text = "ID KLIENTA: " + UserValue ;

            
            
        }
        private void button3_Click(object sender, EventArgs e)
        {
            showMore.Show();
            IDOrder.Show();
            label15.Show();
            label13.Hide();
            DeleteFromCart.Hide();
            label14.Hide();
            CreateOrder.Hide();
            schowajelementyui();
            con.Open();
            OleDbCommand createZamowienia = new OleDbCommand();
            createZamowienia.Connection = con;
            string queryZamowienia = "SELECT Zamowienia.IdZamowienia, StanZamowien.Nazwa AS StanZamowienia, Zamowienia.DataZamowienia, Spedytorzy.Firma, Zamowienia.NazwaWysylki, Zamowienia.TypPlatnosci, Zamowienia.DataZaplaty, Zamowienia.Uwagi FROM Spedytorzy INNER JOIN(StanZamowien INNER JOIN Zamowienia ON StanZamowien.IdStanu = Zamowienia.IdStanu) ON Spedytorzy.ID = Zamowienia.IdSpedytora WHERE Zamowienia.IdKlienta=" + UserValue + " AND Spedytorzy.ID NOT IN ( 4 )";
            createZamowienia.CommandText = queryZamowienia;
            OleDbDataAdapter zamowienia = new OleDbDataAdapter(createZamowienia);
            DataTable OrderTable = new DataTable();
            zamowienia.Fill(OrderTable);
            dataGridView1.DataSource = OrderTable;
            con.Close();
        }
        private void MyDataOpen_Click(object sender, EventArgs e)
        {
            showMore.Hide();
            IDOrder.Hide();
            label15.Hide();
            label13.Hide();
            label14.Hide();
            CreateOrder.Hide();
            DeleteFromCart.Hide();
            otworzsklep();
            getUserData();
            pokazelementyui();
        }
        private void ShopOpen_Click(object sender, EventArgs e)
        {
            schowajelementyui();
            showMore.Hide();
            IDOrder.Hide();
            label15.Hide();
            label13.Show();
            label14.Show();
            CreateOrder.Hide();
            DeleteFromCart.Hide();
            Amount.Show();
            ProdutsCode.Show();
            ToCart.Show();
            showcart.Show();
            otworzsklep();
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
        private void ToCart_Click(object sender, EventArgs e)
        {
            int wIlosc = 0;
            bool isNumber = false;
            isNumber = int.TryParse(Amount.Text, out wIlosc);
            if (ProdutsCode.Text == "" || Amount.Text=="" || !isNumber) MessageBox.Show("Wpisz Kod porduktu który chcesz dodać do koszyka, oraz jego ilość!");
            else
            {
                con.Open();
                OleDbCommand search = new OleDbCommand();
                search.Connection = con;
                search.CommandText = "Select * FROM Produkty WHERE KodProduktu='"+ProdutsCode.Text+"' AND Ilosc>="+Convert.ToInt32(Amount.Text);
                int count = 0;
                OleDbDataReader reader = search.ExecuteReader();
                while (reader.Read())
                {
                    count = count + 1;
                }
                if (count == 1) 
                {
                    DialogResult cartconfirm = MessageBox.Show("Czy chcesz dodać ten produkt do koszyka?","Uwaga!",MessageBoxButtons.YesNo);
                    if(cartconfirm==DialogResult.Yes)
                    {
                        OleDbCommand getOrderNumber = new OleDbCommand();
                        getOrderNumber.Connection = con;
                        getOrderNumber.CommandText = "SELECT TOP 1 SzczegolyZamowienia.IdZamowienia  FROM SzczegolyZamowienia ORDER BY SzczegolyZamowienia.IdZamowienia DESC";
                        Int32 CurentOrder = (Int32)getOrderNumber.ExecuteScalar();
                        OleDbCommand gedCode = new OleDbCommand();
                        gedCode.Connection = con;
                        //SELECT TOP 1 SzczegolyZamowienia.IdZamowienia  FROM SzczegolyZamowienia ORDER BY SzczegolyZamowienia.IdZamowienia DESC;
                        gedCode.CommandText = "Select ID FROM Produkty WHERE KodProduktu='" + ProdutsCode.Text + "'";
                        Int32 IIDProduktu = (Int32)gedCode.ExecuteScalar();
                      OleDbCommand cmd = new OleDbCommand();
                        cmd.Connection = con;
                        cmd.CommandText = "INSERT INTO SzczegolyZamowienia(IdZamowienia,IdProduktu,Ilosc,IdStanu,IDKlienta) values('" + CurentOrder + "','" + IIDProduktu + "','" + Amount.Text + "','" + 0 + "','"+UserValue+"') ";
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Poprawnie dodadno produkt do koszyka!");
                    }
                    else if(cartconfirm==DialogResult.No)
                    {
                    }
                }
                else MessageBox.Show("Brak produktu o podanym Kodzie, lub brak wystarczającej ilości produktu na magazynie!");
                con.Close();
            }
        }
        private void showcart_Click(object sender, EventArgs e)
        {
            CreateOrder.Show();
            DeleteFromCart.Show();
            con.Open();
            OleDbCommand getOrderNumber = new OleDbCommand();
            getOrderNumber.Connection = con;
            getOrderNumber.CommandText = "SELECT TOP 1 SzczegolyZamowienia.IdZamowienia  FROM SzczegolyZamowienia ORDER BY SzczegolyZamowienia.IdZamowienia DESC";
            Int32 CurentOrder = (Int32)getOrderNumber.ExecuteScalar();
            OleDbCommand createKoszyk = new OleDbCommand();
            createKoszyk.Connection = con;
            string queryKoszyk= "SELECT Produkty.NazwaProduktu, SzczegolyZamowienia.Ilosc, Produkty.CenaJednostkowa, Produkty.CenaJednostkowa*SzczegolyZamowienia.Ilosc AS CenaOgolna FROM Produkty INNER JOIN(Klienci INNER JOIN SzczegolyZamowienia ON Klienci.ID = SzczegolyZamowienia.IDKlienta) ON Produkty.ID = SzczegolyZamowienia.IdProduktu WHERE SzczegolyZamowienia.IdZamowienia = "+Convert.ToInt32( CurentOrder)+" AND Klienci.ID="+UserValue+" AND IdProduktu NOT IN ( 8 )";
            createKoszyk.CommandText = queryKoszyk;
            OleDbDataAdapter koszyk = new OleDbDataAdapter(createKoszyk);
            DataTable Koszyk = new DataTable();
            koszyk.Fill(Koszyk);
            dataGridView1.DataSource = Koszyk;
            con.Close();
   
        }
        private void CreateOrder_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand getOrderNumber = new OleDbCommand();
            getOrderNumber.Connection = con;
            getOrderNumber.CommandText = "SELECT TOP 1 SzczegolyZamowienia.IdZamowienia  FROM SzczegolyZamowienia ORDER BY SzczegolyZamowienia.IdZamowienia DESC";
            Int32 CurentOrder = (Int32)getOrderNumber.ExecuteScalar();
            OleDbCommand checkifCartisEmpty = new OleDbCommand();
            checkifCartisEmpty.Connection = con;
            string queryKoszyk = "SELECT Produkty.NazwaProduktu, SzczegolyZamowienia.Ilosc, Produkty.CenaJednostkowa, Produkty.CenaJednostkowa*SzczegolyZamowienia.Ilosc AS CenaOgolna FROM Produkty INNER JOIN(Klienci INNER JOIN SzczegolyZamowienia ON Klienci.ID = SzczegolyZamowienia.IDKlienta) ON Produkty.ID = SzczegolyZamowienia.IdProduktu WHERE SzczegolyZamowienia.IdZamowienia = " + Convert.ToInt32(CurentOrder) + " AND Klienci.ID=" + UserValue + " AND IdProduktu NOT IN ( 8 )";
            checkifCartisEmpty.CommandText = queryKoszyk;
            int count = 0;
            OleDbDataReader reader = checkifCartisEmpty.ExecuteReader();
            while (reader.Read())
            {
                count = count + 1;
            }
            if (count == 0) MessageBox.Show("Koszyk jest pusty!");
            else {
                DeleteFromCart.Hide();
                DialogResult payconfirm = MessageBox.Show("Czy napewno chcesz zakupić przedmioty znajdujące się w koszyku?", "Potwierdzenie złożenia zamówienia", MessageBoxButtons.YesNo);
                if (payconfirm == DialogResult.Yes)
                {
                    int usccon = Convert.ToInt32(UserValue);
                    this.Hide();
                    PaySystem pay = new PaySystem();
                    pay.UserCondiction(usccon.ToString());
                    pay.ShowDialog();
                    pay = null;
                    this.Show();
                }
                else if (payconfirm == DialogResult.No)
                {
                }
            }
            con.Close();   
        }
        private void  DeleteFromCart_Click(object sender, EventArgs e)
        {
            if (ProdutsCode.Text == "") MessageBox.Show("Wskaż produkt który chcesz usunąc!");
            else
            {
                con.Open();
                OleDbCommand getProductID = new OleDbCommand();
                getProductID.Connection = con;
                getProductID.CommandText = "SELECT ID FROM Produkty WHERE KodProduktu='"+ProdutsCode.Text+"'";
                Int32 IDProduktu = (Int32)getProductID.ExecuteScalar();
                OleDbCommand DeleteFromCart = new OleDbCommand();
                DeleteFromCart.Connection = con;
                DeleteFromCart.CommandText = "DELETE FROM SzczegolyZamowien WHERE IdProduktu='"+IDProduktu+"', AND IdKlienta='"+UserValue+"'";

                con.Close();
            }
        }
        private void showMore_Click(object sender, EventArgs e)
        {
            if (IDOrder.Text == "") MessageBox.Show("Wpisz ID Zamówienia!");
            else
            {
                con.Open();
                OleDbCommand checker = new OleDbCommand();
                checker.Connection = con;
                checker.CommandText = "SELECT IdZamowienia FROM Zamowienia WHERE IdKlienta=" + UserValue + " AND IdZamowienia=" + IDOrder.Text + "";
                OleDbDataReader reader = checker.ExecuteReader();
                int count = 0;
                while (reader.Read())
                {
                    count = count + 1;
                }
                if (count == 0) MessageBox.Show("To zamówienie nie istnieje, lub jest przypisane dla innego użytkownika!");
                else
                {
                    OleDbCommand createKoszyk = new OleDbCommand();
                    createKoszyk.Connection = con;
                    string queryKoszyk = "SELECT Produkty.NazwaProduktu, SzczegolyZamowienia.Ilosc, Produkty.CenaJednostkowa, Produkty.CenaJednostkowa*SzczegolyZamowienia.Ilosc AS CenaOgolna FROM Produkty INNER JOIN(Klienci INNER JOIN SzczegolyZamowienia ON Klienci.ID = SzczegolyZamowienia.IDKlienta) ON Produkty.ID = SzczegolyZamowienia.IdProduktu WHERE SzczegolyZamowienia.IdZamowienia = " + IDOrder.Text + " AND Klienci.ID=" + UserValue + " AND IdProduktu NOT IN ( 8 )";
                    createKoszyk.CommandText = queryKoszyk;
                    OleDbDataAdapter koszyk = new OleDbDataAdapter(createKoszyk);
                    DataTable Koszyk = new DataTable();
                    koszyk.Fill(Koszyk);
                    dataGridView1.DataSource = Koszyk;
                }
                con.Close();
            }
        }

        private void deaktywacja_konta_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand laczenie = new OleDbCommand();
            laczenie.Connection = con;
            //string queryUsun = "DELETE FROM Klienci WHERE Login=" + akutalnie_zalogowany.Text;
           // laczenie.CommandText = queryUsun;
           // laczenie.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("blablalba"); //tutaj mialabyc dezaktywacja konta ale co mi sie nie chca wartoci przesylac z jednego forma do drugiego i nie ogarniam dlaczego jak ogarniesz to wyswietlanie to w kwerendzie wystarczy na koncu podtawic pole z loginem akutalnie zalogowanego uzytkownika


        }
        
    }
}
