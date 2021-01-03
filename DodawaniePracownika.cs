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
    public partial class DodawaniePracownika : Form
    {

        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\Users\Perfectamthew\Documents\GitHub\BazaSpedycji\Database\MagazynSpedycji.accdb");
        public DodawaniePracownika()
        {
            InitializeComponent();
        }

        private void dodaj_pracownika_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand polacz = new OleDbCommand();
            polacz.Connection = con;
            string queryDodajPracownika = "insert into Pracownicy(Imie, Nazwisko, Email, Telefon, Adres, Miasto, Wojewodztwo, KodPocztowy, Login, Haslo) values('" + prac_imie.Text + "','" + prac_nazw.Text + "','" + prac_email.Text + "','" + prac_tele.Text + "','" + prac_adres.Text + "','" + prac_miasto.Text + "','" + prac_woje.Text + "','" + prac_kodpocz.Text + "','" + prac_login.Text + "','" + prac_haslo.Text + "')";
            polacz.CommandText = queryDodajPracownika;
            polacz.ExecuteNonQuery();
            polacz.CommandText = queryDodajPracownika;
            polacz.ExecuteNonQuery();
            MessageBox.Show("Dodano nowego pracownika");
            con.Close();


        }
    }
}
