﻿using System;
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
using System.IO;
using AESCrypto;
namespace Magazyn_Spedycji
{
    public partial class SingUp : Form
    {
        bool poprawnoc_hasla = false;
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= Database\MagazynSpedycji.accdb");
        public SingUp()
        {
            InitializeComponent();
        }
        public void sprawdz_haslo()
        {
            Regex r_haslo = new Regex("^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9]).{8,15}$");
            if (r_haslo.IsMatch(Pass.Text))
            {
                poprawnoc_hasla = true;
            }
        }
        private void SingUpButton_Click(object sender, EventArgs e)
        {
            sprawdz_haslo();
            Regex email = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            if (FirstName.Text == "" || SurrName.Text == "" || mail.Text == "" || Login.Text == "")
            {
                MessageBox.Show("Uzupełnij wszystkie pola!");
            }
            else if (poprawnoc_hasla == false) 
            {
                MessageBox.Show("Hasło musi składac się z conajmniej z 8 znakow, 1 dużej litery i cyfry");
            }
            else if (!email.IsMatch(mail.Text))
            {
                MessageBox.Show("Nieprawidłowy format adresu Email");
            }
            else
            {
                OleDbCommand chcek = new OleDbCommand();
                try
                {
                    con.Open();
                    OleDbCommand check = new OleDbCommand();
                    check.Connection = con;
                    check.CommandText ="select * from Klienci where Login='"+Login.Text+"'";
                    OleDbDataReader reader = check.ExecuteReader();
                    int count = 0;
                    while (reader.Read())
                    {
                        count = count + 1;
                    }
                    if (count == 0)
                    {
                        string encusr = Encyryption.Encrypt(Pass.Text);
                        OleDbCommand cmd = new OleDbCommand();
                        cmd.Connection = con;
                        cmd.CommandText = "INSERT INTO Klienci(Imie,Nazwisko,Email,Login,Haslo) values('" + FirstName.Text + "','" + SurrName.Text + "','" + mail.Text + "','" + Login.Text + "','" + encusr + "') ";
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Pomyślnie zarejestrowano!");
                        this.Hide();
                    }
                    else MessageBox.Show("Użytkownik o danym loginie już istnieje w naszej bazie danych!");
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unexcpected Error: " + ex);
                }
            }  
        }
        private void PassSwitch_CheckedChanged(object sender, EventArgs e)
        {
            if (PassSwitch.Checked)
            {
                Pass.UseSystemPasswordChar = false;
            }
            else Pass.UseSystemPasswordChar = true;
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
