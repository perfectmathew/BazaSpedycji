namespace Magazyn_Spedycji
{
    partial class SpedytorzyEdycja
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
            this.haslo_spedy = new System.Windows.Forms.TextBox();
            this.login_spedy = new System.Windows.Forms.TextBox();
            this.tele_spedy = new System.Windows.Forms.TextBox();
            this.email_spedy = new System.Windows.Forms.TextBox();
            this.nazw_spedy = new System.Windows.Forms.TextBox();
            this.imie_spedy = new System.Windows.Forms.TextBox();
            this.firma_spedy = new System.Windows.Forms.TextBox();
            this.id_spedy = new System.Windows.Forms.TextBox();
            this.edytuj_spedy = new System.Windows.Forms.Button();
            this.usun_spedy = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // haslo_spedy
            // 
            this.haslo_spedy.Location = new System.Drawing.Point(12, 194);
            this.haslo_spedy.Name = "haslo_spedy";
            this.haslo_spedy.Size = new System.Drawing.Size(100, 20);
            this.haslo_spedy.TabIndex = 0;
            // 
            // login_spedy
            // 
            this.login_spedy.Location = new System.Drawing.Point(12, 168);
            this.login_spedy.Name = "login_spedy";
            this.login_spedy.Size = new System.Drawing.Size(100, 20);
            this.login_spedy.TabIndex = 1;
            // 
            // tele_spedy
            // 
            this.tele_spedy.Location = new System.Drawing.Point(12, 142);
            this.tele_spedy.Name = "tele_spedy";
            this.tele_spedy.Size = new System.Drawing.Size(100, 20);
            this.tele_spedy.TabIndex = 2;
            // 
            // email_spedy
            // 
            this.email_spedy.Location = new System.Drawing.Point(12, 116);
            this.email_spedy.Name = "email_spedy";
            this.email_spedy.Size = new System.Drawing.Size(100, 20);
            this.email_spedy.TabIndex = 3;
            // 
            // nazw_spedy
            // 
            this.nazw_spedy.Location = new System.Drawing.Point(12, 90);
            this.nazw_spedy.Name = "nazw_spedy";
            this.nazw_spedy.Size = new System.Drawing.Size(100, 20);
            this.nazw_spedy.TabIndex = 4;
            // 
            // imie_spedy
            // 
            this.imie_spedy.Location = new System.Drawing.Point(12, 64);
            this.imie_spedy.Name = "imie_spedy";
            this.imie_spedy.Size = new System.Drawing.Size(100, 20);
            this.imie_spedy.TabIndex = 5;
            // 
            // firma_spedy
            // 
            this.firma_spedy.Location = new System.Drawing.Point(12, 38);
            this.firma_spedy.Name = "firma_spedy";
            this.firma_spedy.Size = new System.Drawing.Size(100, 20);
            this.firma_spedy.TabIndex = 6;
            // 
            // id_spedy
            // 
            this.id_spedy.Location = new System.Drawing.Point(12, 12);
            this.id_spedy.Name = "id_spedy";
            this.id_spedy.ReadOnly = true;
            this.id_spedy.Size = new System.Drawing.Size(100, 20);
            this.id_spedy.TabIndex = 7;
            // 
            // edytuj_spedy
            // 
            this.edytuj_spedy.Location = new System.Drawing.Point(12, 235);
            this.edytuj_spedy.Name = "edytuj_spedy";
            this.edytuj_spedy.Size = new System.Drawing.Size(123, 43);
            this.edytuj_spedy.TabIndex = 8;
            this.edytuj_spedy.Text = "Edycja";
            this.edytuj_spedy.UseVisualStyleBackColor = true;
            this.edytuj_spedy.Click += new System.EventHandler(this.edytuj_spedy_Click);
            // 
            // usun_spedy
            // 
            this.usun_spedy.Location = new System.Drawing.Point(12, 284);
            this.usun_spedy.Name = "usun_spedy";
            this.usun_spedy.Size = new System.Drawing.Size(123, 46);
            this.usun_spedy.TabIndex = 9;
            this.usun_spedy.Text = "Usun";
            this.usun_spedy.UseVisualStyleBackColor = true;
            this.usun_spedy.Click += new System.EventHandler(this.usun_spedy_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(234, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(554, 426);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Haslo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(118, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Login";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(118, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Telefon";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(118, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(118, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Nazwisko";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(118, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Imie";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(118, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Frima";
            // 
            // SpedytorzyEdycja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.usun_spedy);
            this.Controls.Add(this.edytuj_spedy);
            this.Controls.Add(this.id_spedy);
            this.Controls.Add(this.firma_spedy);
            this.Controls.Add(this.imie_spedy);
            this.Controls.Add(this.nazw_spedy);
            this.Controls.Add(this.email_spedy);
            this.Controls.Add(this.tele_spedy);
            this.Controls.Add(this.login_spedy);
            this.Controls.Add(this.haslo_spedy);
            this.Name = "SpedytorzyEdycja";
            this.Text = "SpedytorzyEdycja";
            this.Load += new System.EventHandler(this.SpedytorzyEdycja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox haslo_spedy;
        private System.Windows.Forms.TextBox login_spedy;
        private System.Windows.Forms.TextBox tele_spedy;
        private System.Windows.Forms.TextBox email_spedy;
        private System.Windows.Forms.TextBox nazw_spedy;
        private System.Windows.Forms.TextBox imie_spedy;
        private System.Windows.Forms.TextBox firma_spedy;
        private System.Windows.Forms.TextBox id_spedy;
        private System.Windows.Forms.Button edytuj_spedy;
        private System.Windows.Forms.Button usun_spedy;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}