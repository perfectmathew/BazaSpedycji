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
    public partial class DodawanieSpedytora : Form
    {

        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\Users\Perfectamthew\Documents\GitHub\BazaSpedycji\Database\MagazynSpedycji.accdb");
        public DodawanieSpedytora()
        {
            InitializeComponent();
        }

        /*
        public void sprawdz_poprawnosc()
        {
            Regex r_klie_kodp = new Regex("^[0-9]{2}-[0-9]{3}$");
            Regex r_klie_tele = new Regex("^[1-9]{3}-[0-9]{3}-[0-9]{3}$");


            if ()
            {
                MessageBox.Show("Brak kompletu informacji!");

            }

            else if ()
            {
                MessageBox.Show("Niewlasciwe dane w polu!");
            }
            else
            {
                poprawne = true;
            }

        }

        */

        private void dodaj_spedy_Click(object sender, EventArgs e)
        {

           // if (poprawne == true)
           // {

                con.Open();
                OleDbCommand laczenie = new OleDbCommand();
                laczenie.Connection = con;
                string queryDodaj = "insert into Spedytorzy(ID, Firma, Imie, Nazwisko, Email, Telefon, Login, Haslo) values('" + id_spedy.Text + "','" + firma_spedy.Text + "','" + imie_spedy.Text + "','" + nazwi_spedy.Text + "','" + email_spedy.Text + "','" + tele_spedy.Text + "','" + login_spedy.Text + "','" + haslo_spedy.Text + "')";
                laczenie.CommandText = queryDodaj;
                laczenie.ExecuteNonQuery();
                MessageBox.Show("Dodano nowego spedytora");
                con.Close();
           // }


        }
    }
}
