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
    public partial class ZamowieniaEdycja : Form
    {
        int kolumna = 0;
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\Users\wojna\Desktop\BazaSpedycji-main\Database\MagazynSpedycji.accdb");
        public ZamowieniaEdycja()
        {
            InitializeComponent();
        }

        private void ZamowieniaEdycja_Load(object sender, EventArgs e)
        {
            OleDbCommand createZamowienia = new OleDbCommand();
            createZamowienia.Connection = con;
            string queryZamowienia = "Select * from Zamowienia";
            createZamowienia.CommandText = queryZamowienia;
            OleDbDataAdapter zamowienie = new OleDbDataAdapter(createZamowienia);
            DataTable tabelaZamowienia = new DataTable();
            zamowienie.Fill(tabelaZamowienia);
            dataGridView1.DataSource = tabelaZamowienia;
            con.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            kolumna = e.RowIndex;
            if (kolumna < 0 || kolumna > 6) MessageBox.Show("Wybierz produkt!");
            else
            {
                DataGridViewRow kol = dataGridView1.Rows[kolumna];
                idzamowienia_zam.Text = kol.Cells[0].Value.ToString();
                idprac_zam.Text = kol.Cells[1].Value.ToString();
                idkli_zam.Text = kol.Cells[2].Value.ToString();
                datazam_zam.Text = kol.Cells[3].Value.ToString();
                datawys_zam.Text = kol.Cells[4].Value.ToString();
                idspedy_zam.Text = kol.Cells[5].Value.ToString();
                nazwawys_zam.Text = kol.Cells[6].Value.ToString();
                typplat_zam.Text = kol.Cells[7].Value.ToString();
                datazap_zam.Text = kol.Cells[8].Value.ToString();
                uwagi_zam.Text = kol.Cells[9].Value.ToString();
                idstan_zam.Text = kol.Cells[10].Value.ToString();
            }
        }
    }
}
