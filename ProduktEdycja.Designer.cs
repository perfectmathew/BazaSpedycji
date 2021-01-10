namespace Magazyn_Spedycji
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProduktEdycja));
            this.id_prod = new System.Windows.Forms.TextBox();
            this.kod_prod = new System.Windows.Forms.TextBox();
            this.ilosc_prod = new System.Windows.Forms.TextBox();
            this.koszt_prod = new System.Windows.Forms.TextBox();
            this.opis_prod = new System.Windows.Forms.TextBox();
            this.nazwa_prod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.RandomNumber = new System.Windows.Forms.Button();
            this.usun_rdk = new System.Windows.Forms.Button();
            this.dodanie_rekordu = new System.Windows.Forms.Button();
            this.edycja_rekordu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // id_prod
            // 
            this.id_prod.Location = new System.Drawing.Point(30, 59);
            this.id_prod.Name = "id_prod";
            this.id_prod.Size = new System.Drawing.Size(100, 20);
            this.id_prod.TabIndex = 0;
            this.id_prod.TextChanged += new System.EventHandler(this.id_prod_TextChanged);
            // 
            // kod_prod
            // 
            this.kod_prod.Location = new System.Drawing.Point(30, 85);
            this.kod_prod.Name = "kod_prod";
            this.kod_prod.Size = new System.Drawing.Size(100, 20);
            this.kod_prod.TabIndex = 1;
            // 
            // ilosc_prod
            // 
            this.ilosc_prod.Location = new System.Drawing.Point(30, 189);
            this.ilosc_prod.Name = "ilosc_prod";
            this.ilosc_prod.Size = new System.Drawing.Size(100, 20);
            this.ilosc_prod.TabIndex = 2;
            // 
            // koszt_prod
            // 
            this.koszt_prod.Location = new System.Drawing.Point(30, 163);
            this.koszt_prod.Name = "koszt_prod";
            this.koszt_prod.Size = new System.Drawing.Size(100, 20);
            this.koszt_prod.TabIndex = 4;
            // 
            // opis_prod
            // 
            this.opis_prod.Location = new System.Drawing.Point(30, 137);
            this.opis_prod.Name = "opis_prod";
            this.opis_prod.Size = new System.Drawing.Size(100, 20);
            this.opis_prod.TabIndex = 5;
            // 
            // nazwa_prod
            // 
            this.nazwa_prod.Location = new System.Drawing.Point(30, 111);
            this.nazwa_prod.Name = "nazwa_prod";
            this.nazwa_prod.Size = new System.Drawing.Size(100, 20);
            this.nazwa_prod.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "ID produktu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(175, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Kod produktu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(175, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Nazwa produktu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(175, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Opis produktu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(175, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Cena Jednostkowa";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(175, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Ilość";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(325, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(420, 348);
            this.dataGridView1.TabIndex = 18;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel1.Location = new System.Drawing.Point(299, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(20, 348);
            this.panel1.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nexa Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(432, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(208, 26);
            this.label6.TabIndex = 24;
            this.label6.Text = "Wszystkie produkty";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Nexa Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(25, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(254, 26);
            this.label9.TabIndex = 24;
            this.label9.Text = "Zarządzanie produktami";
            // 
            // RandomNumber
            // 
            this.RandomNumber.FlatAppearance.BorderSize = 0;
            this.RandomNumber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RandomNumber.Image = global::Magazyn_Spedycji.Properties.Resources.random_small;
            this.RandomNumber.Location = new System.Drawing.Point(136, 83);
            this.RandomNumber.Name = "RandomNumber";
            this.RandomNumber.Size = new System.Drawing.Size(33, 23);
            this.RandomNumber.TabIndex = 25;
            this.RandomNumber.UseVisualStyleBackColor = true;
            this.RandomNumber.Click += new System.EventHandler(this.RandomNumber_Click);
            // 
            // usun_rdk
            // 
            this.usun_rdk.BackColor = System.Drawing.SystemColors.Desktop;
            this.usun_rdk.FlatAppearance.BorderSize = 0;
            this.usun_rdk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.usun_rdk.Font = new System.Drawing.Font("Nexa Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usun_rdk.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.usun_rdk.Image = global::Magazyn_Spedycji.Properties.Resources.delete;
            this.usun_rdk.Location = new System.Drawing.Point(30, 353);
            this.usun_rdk.Name = "usun_rdk";
            this.usun_rdk.Size = new System.Drawing.Size(212, 53);
            this.usun_rdk.TabIndex = 22;
            this.usun_rdk.Text = "Wycofaj z sprzedaży";
            this.usun_rdk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.usun_rdk.UseVisualStyleBackColor = false;
            this.usun_rdk.Click += new System.EventHandler(this.usun_rdk_Click);
            // 
            // dodanie_rekordu
            // 
            this.dodanie_rekordu.BackColor = System.Drawing.SystemColors.Desktop;
            this.dodanie_rekordu.FlatAppearance.BorderSize = 0;
            this.dodanie_rekordu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dodanie_rekordu.Font = new System.Drawing.Font("Nexa Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dodanie_rekordu.ForeColor = System.Drawing.SystemColors.Control;
            this.dodanie_rekordu.Image = global::Magazyn_Spedycji.Properties.Resources.add;
            this.dodanie_rekordu.Location = new System.Drawing.Point(30, 235);
            this.dodanie_rekordu.Name = "dodanie_rekordu";
            this.dodanie_rekordu.Size = new System.Drawing.Size(213, 53);
            this.dodanie_rekordu.TabIndex = 17;
            this.dodanie_rekordu.Text = "Dodaj produkt";
            this.dodanie_rekordu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.dodanie_rekordu.UseVisualStyleBackColor = false;
            this.dodanie_rekordu.Click += new System.EventHandler(this.dodanie_rekordu_Click);
            // 
            // edycja_rekordu
            // 
            this.edycja_rekordu.BackColor = System.Drawing.SystemColors.Desktop;
            this.edycja_rekordu.FlatAppearance.BorderSize = 0;
            this.edycja_rekordu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edycja_rekordu.Font = new System.Drawing.Font("Nexa Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edycja_rekordu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.edycja_rekordu.Image = global::Magazyn_Spedycji.Properties.Resources.edit;
            this.edycja_rekordu.Location = new System.Drawing.Point(30, 294);
            this.edycja_rekordu.Name = "edycja_rekordu";
            this.edycja_rekordu.Size = new System.Drawing.Size(213, 53);
            this.edycja_rekordu.TabIndex = 16;
            this.edycja_rekordu.Text = "Edytuj produkt";
            this.edycja_rekordu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.edycja_rekordu.UseVisualStyleBackColor = false;
            this.edycja_rekordu.Click += new System.EventHandler(this.edycja_rekordu_Click);
            // 
            // ProduktEdycja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 440);
            this.Controls.Add(this.RandomNumber);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.usun_rdk);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dodanie_rekordu);
            this.Controls.Add(this.edycja_rekordu);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nazwa_prod);
            this.Controls.Add(this.opis_prod);
            this.Controls.Add(this.koszt_prod);
            this.Controls.Add(this.ilosc_prod);
            this.Controls.Add(this.kod_prod);
            this.Controls.Add(this.id_prod);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProduktEdycja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.TextBox koszt_prod;
        private System.Windows.Forms.TextBox opis_prod;
        private System.Windows.Forms.TextBox nazwa_prod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button edycja_rekordu;
        private System.Windows.Forms.Button dodanie_rekordu;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button usun_rdk;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button RandomNumber;
    }
}