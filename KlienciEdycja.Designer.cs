namespace Magazyn_Spedycji
{
    partial class KlientEdycja
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.imie_klie = new System.Windows.Forms.TextBox();
            this.nazw_klie = new System.Windows.Forms.TextBox();
            this.email_klie = new System.Windows.Forms.TextBox();
            this.telefon_klie = new System.Windows.Forms.TextBox();
            this.adres_klie = new System.Windows.Forms.TextBox();
            this.miasto_klie = new System.Windows.Forms.TextBox();
            this.woje_klie = new System.Windows.Forms.TextBox();
            this.kodp_klie = new System.Windows.Forms.TextBox();
            this.kraj_klie = new System.Windows.Forms.TextBox();
            this.login_klie = new System.Windows.Forms.TextBox();
            this.haslo_klie = new System.Windows.Forms.TextBox();
            this.edycja_rdk_klie = new System.Windows.Forms.Button();
            this.usun_klienta = new System.Windows.Forms.Button();
            this.id_klie = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(224, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(564, 426);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // imie_klie
            // 
            this.imie_klie.Location = new System.Drawing.Point(12, 12);
            this.imie_klie.Name = "imie_klie";
            this.imie_klie.Size = new System.Drawing.Size(100, 20);
            this.imie_klie.TabIndex = 2;
            // 
            // nazw_klie
            // 
            this.nazw_klie.Location = new System.Drawing.Point(12, 38);
            this.nazw_klie.Name = "nazw_klie";
            this.nazw_klie.Size = new System.Drawing.Size(100, 20);
            this.nazw_klie.TabIndex = 3;
            // 
            // email_klie
            // 
            this.email_klie.Location = new System.Drawing.Point(12, 64);
            this.email_klie.Name = "email_klie";
            this.email_klie.Size = new System.Drawing.Size(100, 20);
            this.email_klie.TabIndex = 4;
            // 
            // telefon_klie
            // 
            this.telefon_klie.Location = new System.Drawing.Point(12, 90);
            this.telefon_klie.Name = "telefon_klie";
            this.telefon_klie.Size = new System.Drawing.Size(100, 20);
            this.telefon_klie.TabIndex = 5;
            // 
            // adres_klie
            // 
            this.adres_klie.Location = new System.Drawing.Point(12, 116);
            this.adres_klie.Name = "adres_klie";
            this.adres_klie.Size = new System.Drawing.Size(100, 20);
            this.adres_klie.TabIndex = 6;
            // 
            // miasto_klie
            // 
            this.miasto_klie.Location = new System.Drawing.Point(12, 142);
            this.miasto_klie.Name = "miasto_klie";
            this.miasto_klie.Size = new System.Drawing.Size(100, 20);
            this.miasto_klie.TabIndex = 7;
            // 
            // woje_klie
            // 
            this.woje_klie.Location = new System.Drawing.Point(12, 168);
            this.woje_klie.Name = "woje_klie";
            this.woje_klie.Size = new System.Drawing.Size(100, 20);
            this.woje_klie.TabIndex = 8;
            // 
            // kodp_klie
            // 
            this.kodp_klie.Location = new System.Drawing.Point(12, 194);
            this.kodp_klie.Name = "kodp_klie";
            this.kodp_klie.Size = new System.Drawing.Size(100, 20);
            this.kodp_klie.TabIndex = 9;
            // 
            // kraj_klie
            // 
            this.kraj_klie.Location = new System.Drawing.Point(12, 220);
            this.kraj_klie.Name = "kraj_klie";
            this.kraj_klie.Size = new System.Drawing.Size(100, 20);
            this.kraj_klie.TabIndex = 10;
            // 
            // login_klie
            // 
            this.login_klie.Location = new System.Drawing.Point(12, 246);
            this.login_klie.Name = "login_klie";
            this.login_klie.Size = new System.Drawing.Size(100, 20);
            this.login_klie.TabIndex = 11;
            // 
            // haslo_klie
            // 
            this.haslo_klie.Location = new System.Drawing.Point(12, 272);
            this.haslo_klie.Name = "haslo_klie";
            this.haslo_klie.Size = new System.Drawing.Size(100, 20);
            this.haslo_klie.TabIndex = 12;
            // 
            // edycja_rdk_klie
            // 
            this.edycja_rdk_klie.Location = new System.Drawing.Point(12, 298);
            this.edycja_rdk_klie.Name = "edycja_rdk_klie";
            this.edycja_rdk_klie.Size = new System.Drawing.Size(100, 42);
            this.edycja_rdk_klie.TabIndex = 14;
            this.edycja_rdk_klie.Text = "Edytuj";
            this.edycja_rdk_klie.UseVisualStyleBackColor = true;
            this.edycja_rdk_klie.Click += new System.EventHandler(this.edycja_rdk_klie_Click);
            // 
            // usun_klienta
            // 
            this.usun_klienta.Location = new System.Drawing.Point(12, 346);
            this.usun_klienta.Name = "usun_klienta";
            this.usun_klienta.Size = new System.Drawing.Size(100, 42);
            this.usun_klienta.TabIndex = 15;
            this.usun_klienta.Text = "Usun";
            this.usun_klienta.UseVisualStyleBackColor = true;
            this.usun_klienta.Click += new System.EventHandler(this.usun_klienta_Click);
            // 
            // id_klie
            // 
            this.id_klie.Location = new System.Drawing.Point(118, 12);
            this.id_klie.Name = "id_klie";
            this.id_klie.Size = new System.Drawing.Size(100, 20);
            this.id_klie.TabIndex = 16;
            // 
            // KlientEdycja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.id_klie);
            this.Controls.Add(this.usun_klienta);
            this.Controls.Add(this.edycja_rdk_klie);
            this.Controls.Add(this.haslo_klie);
            this.Controls.Add(this.login_klie);
            this.Controls.Add(this.kraj_klie);
            this.Controls.Add(this.kodp_klie);
            this.Controls.Add(this.woje_klie);
            this.Controls.Add(this.miasto_klie);
            this.Controls.Add(this.adres_klie);
            this.Controls.Add(this.telefon_klie);
            this.Controls.Add(this.email_klie);
            this.Controls.Add(this.nazw_klie);
            this.Controls.Add(this.imie_klie);
            this.Controls.Add(this.dataGridView1);
            this.Name = "KlientEdycja";
            this.Text = "Klient Edycja";
            this.Load += new System.EventHandler(this.KlientEdycja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox imie_klie;
        private System.Windows.Forms.TextBox nazw_klie;
        private System.Windows.Forms.TextBox email_klie;
        private System.Windows.Forms.TextBox telefon_klie;
        private System.Windows.Forms.TextBox adres_klie;
        private System.Windows.Forms.TextBox miasto_klie;
        private System.Windows.Forms.TextBox woje_klie;
        private System.Windows.Forms.TextBox kodp_klie;
        private System.Windows.Forms.TextBox kraj_klie;
        private System.Windows.Forms.TextBox login_klie;
        private System.Windows.Forms.TextBox haslo_klie;
        private System.Windows.Forms.Button edycja_rdk_klie;
        private System.Windows.Forms.Button usun_klienta;
        private System.Windows.Forms.TextBox id_klie;
    }
}