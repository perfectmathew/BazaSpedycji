﻿namespace Magazyn_Spedycji
{
    partial class ProduktEdycja
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.id_prod = new System.Windows.Forms.TextBox();
            this.kod_prod = new System.Windows.Forms.TextBox();
            this.ilosc_prod = new System.Windows.Forms.TextBox();
            this.cenakat_prod = new System.Windows.Forms.TextBox();
            this.koszt_prod = new System.Windows.Forms.TextBox();
            this.opis_prod = new System.Windows.Forms.TextBox();
            this.nazwa_prod = new System.Windows.Forms.TextBox();
            this.wycofane_prod = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.edycja_rekordu = new System.Windows.Forms.Button();
            this.dodanie_rekordu = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iddost_prod = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.sort_rdk = new System.Windows.Forms.Button();
            this.usun_rdk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // id_prod
            // 
            this.id_prod.Location = new System.Drawing.Point(12, 12);
            this.id_prod.Name = "id_prod";
            this.id_prod.Size = new System.Drawing.Size(100, 20);
            this.id_prod.TabIndex = 0;
            // 
            // kod_prod
            // 
            this.kod_prod.Location = new System.Drawing.Point(12, 38);
            this.kod_prod.Name = "kod_prod";
            this.kod_prod.Size = new System.Drawing.Size(100, 20);
            this.kod_prod.TabIndex = 1;
            // 
            // ilosc_prod
            // 
            this.ilosc_prod.Location = new System.Drawing.Point(12, 168);
            this.ilosc_prod.Name = "ilosc_prod";
            this.ilosc_prod.Size = new System.Drawing.Size(100, 20);
            this.ilosc_prod.TabIndex = 2;
            // 
            // cenakat_prod
            // 
            this.cenakat_prod.Location = new System.Drawing.Point(12, 142);
            this.cenakat_prod.Name = "cenakat_prod";
            this.cenakat_prod.Size = new System.Drawing.Size(100, 20);
            this.cenakat_prod.TabIndex = 3;
            // 
            // koszt_prod
            // 
            this.koszt_prod.Location = new System.Drawing.Point(12, 116);
            this.koszt_prod.Name = "koszt_prod";
            this.koszt_prod.Size = new System.Drawing.Size(100, 20);
            this.koszt_prod.TabIndex = 4;
            // 
            // opis_prod
            // 
            this.opis_prod.Location = new System.Drawing.Point(12, 90);
            this.opis_prod.Name = "opis_prod";
            this.opis_prod.Size = new System.Drawing.Size(100, 20);
            this.opis_prod.TabIndex = 5;
            // 
            // nazwa_prod
            // 
            this.nazwa_prod.Location = new System.Drawing.Point(12, 64);
            this.nazwa_prod.Name = "nazwa_prod";
            this.nazwa_prod.Size = new System.Drawing.Size(100, 20);
            this.nazwa_prod.TabIndex = 6;
            // 
            // wycofane_prod
            // 
            this.wycofane_prod.AutoSize = true;
            this.wycofane_prod.Location = new System.Drawing.Point(12, 194);
            this.wycofane_prod.Name = "wycofane_prod";
            this.wycofane_prod.Size = new System.Drawing.Size(80, 17);
            this.wycofane_prod.TabIndex = 7;
            this.wycofane_prod.Text = "checkBox1";
            this.wycofane_prod.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "ID produktu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Kod produktu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(140, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Nazwa produktu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(140, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Opis produktu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(140, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Koszt standardowy";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(140, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Cena katalogowa";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(140, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Ilosc";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(140, 198);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Wycofany";
            // 
            // edycja_rekordu
            // 
            this.edycja_rekordu.Location = new System.Drawing.Point(118, 240);
            this.edycja_rekordu.Name = "edycja_rekordu";
            this.edycja_rekordu.Size = new System.Drawing.Size(112, 53);
            this.edycja_rekordu.TabIndex = 16;
            this.edycja_rekordu.Text = "Edytuj rekord";
            this.edycja_rekordu.UseVisualStyleBackColor = true;
            this.edycja_rekordu.Click += new System.EventHandler(this.edycja_rekordu_Click);
            // 
            // dodanie_rekordu
            // 
            this.dodanie_rekordu.Location = new System.Drawing.Point(6, 240);
            this.dodanie_rekordu.Name = "dodanie_rekordu";
            this.dodanie_rekordu.Size = new System.Drawing.Size(106, 53);
            this.dodanie_rekordu.TabIndex = 17;
            this.dodanie_rekordu.Text = "Dodaj rekord";
            this.dodanie_rekordu.UseVisualStyleBackColor = true;
            this.dodanie_rekordu.Click += new System.EventHandler(this.dodanie_rekordu_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(320, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(845, 426);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // iddost_prod
            // 
            this.iddost_prod.Location = new System.Drawing.Point(12, 214);
            this.iddost_prod.Name = "iddost_prod";
            this.iddost_prod.Size = new System.Drawing.Size(100, 20);
            this.iddost_prod.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(140, 217);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "id_dostawcy";
            // 
            // sort_rdk
            // 
            this.sort_rdk.Location = new System.Drawing.Point(6, 299);
            this.sort_rdk.Name = "sort_rdk";
            this.sort_rdk.Size = new System.Drawing.Size(112, 53);
            this.sort_rdk.TabIndex = 21;
            this.sort_rdk.Text = "Sortuj rekordy ";
            this.sort_rdk.UseVisualStyleBackColor = true;
            this.sort_rdk.Click += new System.EventHandler(this.sort_rdk_Click);
            // 
            // usun_rdk
            // 
            this.usun_rdk.Location = new System.Drawing.Point(124, 299);
            this.usun_rdk.Name = "usun_rdk";
            this.usun_rdk.Size = new System.Drawing.Size(106, 53);
            this.usun_rdk.TabIndex = 22;
            this.usun_rdk.Text = "Usun rekord";
            this.usun_rdk.UseVisualStyleBackColor = true;
            this.usun_rdk.Click += new System.EventHandler(this.usun_rdk_Click);
            // 
            // ProduktEdycja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 450);
            this.Controls.Add(this.usun_rdk);
            this.Controls.Add(this.sort_rdk);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.iddost_prod);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dodanie_rekordu);
            this.Controls.Add(this.edycja_rekordu);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.wycofane_prod);
            this.Controls.Add(this.nazwa_prod);
            this.Controls.Add(this.opis_prod);
            this.Controls.Add(this.koszt_prod);
            this.Controls.Add(this.cenakat_prod);
            this.Controls.Add(this.ilosc_prod);
            this.Controls.Add(this.kod_prod);
            this.Controls.Add(this.id_prod);
            this.Name = "ProduktEdycja";
            this.Text = "Product Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox id_prod;
        private System.Windows.Forms.TextBox kod_prod;
        private System.Windows.Forms.TextBox ilosc_prod;
        private System.Windows.Forms.TextBox cenakat_prod;
        private System.Windows.Forms.TextBox koszt_prod;
        private System.Windows.Forms.TextBox opis_prod;
        private System.Windows.Forms.TextBox nazwa_prod;
        private System.Windows.Forms.CheckBox wycofane_prod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button edycja_rekordu;
        private System.Windows.Forms.Button dodanie_rekordu;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox iddost_prod;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button sort_rdk;
        private System.Windows.Forms.Button usun_rdk;
    }
}