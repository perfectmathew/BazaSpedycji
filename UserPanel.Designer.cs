namespace Magazyn_Spedycji
{
    partial class UserPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserPanel));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MyDataOpen = new System.Windows.Forms.Button();
            this.ShopOpen = new System.Windows.Forms.Button();
            this.ZamOpenButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.ImieBox = new System.Windows.Forms.TextBox();
            this.NazwiskoBox = new System.Windows.Forms.TextBox();
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.TelefonBox = new System.Windows.Forms.TextBox();
            this.AdresBox = new System.Windows.Forms.TextBox();
            this.MiastoBox = new System.Windows.Forms.TextBox();
            this.WojewodztwoBox = new System.Windows.Forms.TextBox();
            this.KodBox = new System.Windows.Forms.TextBox();
            this.KrajBox = new System.Windows.Forms.TextBox();
            this.LoginBox = new System.Windows.Forms.TextBox();
            this.hasloBox = new System.Windows.Forms.TextBox();
            this.UpdateUserButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Magazyn_Spedycji.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(-21, -18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 131);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // MyDataOpen
            // 
            this.MyDataOpen.Location = new System.Drawing.Point(306, 24);
            this.MyDataOpen.Name = "MyDataOpen";
            this.MyDataOpen.Size = new System.Drawing.Size(75, 64);
            this.MyDataOpen.TabIndex = 7;
            this.MyDataOpen.Text = "Moje dane";
            this.MyDataOpen.UseVisualStyleBackColor = true;
            this.MyDataOpen.Click += new System.EventHandler(this.MyDataOpen_Click);
            // 
            // ShopOpen
            // 
            this.ShopOpen.Location = new System.Drawing.Point(225, 24);
            this.ShopOpen.Name = "ShopOpen";
            this.ShopOpen.Size = new System.Drawing.Size(75, 64);
            this.ShopOpen.TabIndex = 8;
            this.ShopOpen.Text = "Sklep";
            this.ShopOpen.UseVisualStyleBackColor = true;
            this.ShopOpen.Click += new System.EventHandler(this.ShopOpen_Click);
            // 
            // ZamOpenButton
            // 
            this.ZamOpenButton.Location = new System.Drawing.Point(387, 24);
            this.ZamOpenButton.Name = "ZamOpenButton";
            this.ZamOpenButton.Size = new System.Drawing.Size(75, 64);
            this.ZamOpenButton.TabIndex = 9;
            this.ZamOpenButton.Text = "Moje zamówienia";
            this.ZamOpenButton.UseVisualStyleBackColor = true;
            this.ZamOpenButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(225, 94);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(723, 389);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "ID KILENTA:";
            // 
            // ImieBox
            // 
            this.ImieBox.Location = new System.Drawing.Point(101, 146);
            this.ImieBox.Name = "ImieBox";
            this.ImieBox.Size = new System.Drawing.Size(100, 20);
            this.ImieBox.TabIndex = 12;
            // 
            // NazwiskoBox
            // 
            this.NazwiskoBox.Location = new System.Drawing.Point(101, 173);
            this.NazwiskoBox.Name = "NazwiskoBox";
            this.NazwiskoBox.Size = new System.Drawing.Size(100, 20);
            this.NazwiskoBox.TabIndex = 13;
            // 
            // EmailBox
            // 
            this.EmailBox.Location = new System.Drawing.Point(101, 200);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(100, 20);
            this.EmailBox.TabIndex = 14;
            // 
            // TelefonBox
            // 
            this.TelefonBox.Location = new System.Drawing.Point(101, 227);
            this.TelefonBox.Name = "TelefonBox";
            this.TelefonBox.Size = new System.Drawing.Size(100, 20);
            this.TelefonBox.TabIndex = 15;
            // 
            // AdresBox
            // 
            this.AdresBox.Location = new System.Drawing.Point(101, 254);
            this.AdresBox.Name = "AdresBox";
            this.AdresBox.Size = new System.Drawing.Size(100, 20);
            this.AdresBox.TabIndex = 16;
            // 
            // MiastoBox
            // 
            this.MiastoBox.Location = new System.Drawing.Point(101, 284);
            this.MiastoBox.Name = "MiastoBox";
            this.MiastoBox.Size = new System.Drawing.Size(100, 20);
            this.MiastoBox.TabIndex = 17;
            // 
            // WojewodztwoBox
            // 
            this.WojewodztwoBox.Location = new System.Drawing.Point(129, 312);
            this.WojewodztwoBox.Name = "WojewodztwoBox";
            this.WojewodztwoBox.Size = new System.Drawing.Size(72, 20);
            this.WojewodztwoBox.TabIndex = 18;
            // 
            // KodBox
            // 
            this.KodBox.Location = new System.Drawing.Point(127, 338);
            this.KodBox.Name = "KodBox";
            this.KodBox.Size = new System.Drawing.Size(74, 20);
            this.KodBox.TabIndex = 19;
            // 
            // KrajBox
            // 
            this.KrajBox.Location = new System.Drawing.Point(101, 364);
            this.KrajBox.Name = "KrajBox";
            this.KrajBox.Size = new System.Drawing.Size(100, 20);
            this.KrajBox.TabIndex = 20;
            // 
            // LoginBox
            // 
            this.LoginBox.Location = new System.Drawing.Point(101, 390);
            this.LoginBox.Name = "LoginBox";
            this.LoginBox.Size = new System.Drawing.Size(100, 20);
            this.LoginBox.TabIndex = 21;
            // 
            // hasloBox
            // 
            this.hasloBox.Location = new System.Drawing.Point(101, 416);
            this.hasloBox.Name = "hasloBox";
            this.hasloBox.Size = new System.Drawing.Size(100, 20);
            this.hasloBox.TabIndex = 22;
            // 
            // UpdateUserButton
            // 
            this.UpdateUserButton.Location = new System.Drawing.Point(12, 442);
            this.UpdateUserButton.Name = "UpdateUserButton";
            this.UpdateUserButton.Size = new System.Drawing.Size(189, 23);
            this.UpdateUserButton.TabIndex = 23;
            this.UpdateUserButton.Text = "Zaktualizuj dane";
            this.UpdateUserButton.UseVisualStyleBackColor = true;
            this.UpdateUserButton.Click += new System.EventHandler(this.UpdateUserButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(53, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "Imię:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(12, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 25;
            this.label3.Text = "Nazwisko:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(43, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(27, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 20);
            this.label5.TabIndex = 27;
            this.label5.Text = "Telefon:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(40, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 20);
            this.label6.TabIndex = 28;
            this.label6.Text = "Adres:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(34, 284);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 20);
            this.label7.TabIndex = 29;
            this.label7.Text = "Miasto:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(8, 312);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 20);
            this.label8.TabIndex = 30;
            this.label8.Text = "Województwo:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(8, 338);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 20);
            this.label9.TabIndex = 31;
            this.label9.Text = "KodPocztowy:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(56, 364);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 20);
            this.label10.TabIndex = 32;
            this.label10.Text = "Kraj:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(44, 390);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 20);
            this.label11.TabIndex = 33;
            this.label11.Text = "Login:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.Location = new System.Drawing.Point(40, 416);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 20);
            this.label12.TabIndex = 34;
            this.label12.Text = "Hasło:";
            // 
            // UserPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 511);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UpdateUserButton);
            this.Controls.Add(this.hasloBox);
            this.Controls.Add(this.LoginBox);
            this.Controls.Add(this.KrajBox);
            this.Controls.Add(this.KodBox);
            this.Controls.Add(this.WojewodztwoBox);
            this.Controls.Add(this.MiastoBox);
            this.Controls.Add(this.AdresBox);
            this.Controls.Add(this.TelefonBox);
            this.Controls.Add(this.EmailBox);
            this.Controls.Add(this.NazwiskoBox);
            this.Controls.Add(this.ImieBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ZamOpenButton);
            this.Controls.Add(this.ShopOpen);
            this.Controls.Add(this.MyDataOpen);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Secret Shipping | UserPanel";
            this.Load += new System.EventHandler(this.UserPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button MyDataOpen;
        private System.Windows.Forms.Button ShopOpen;
        private System.Windows.Forms.Button ZamOpenButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ImieBox;
        private System.Windows.Forms.TextBox NazwiskoBox;
        private System.Windows.Forms.TextBox EmailBox;
        private System.Windows.Forms.TextBox TelefonBox;
        private System.Windows.Forms.TextBox AdresBox;
        private System.Windows.Forms.TextBox MiastoBox;
        private System.Windows.Forms.TextBox WojewodztwoBox;
        private System.Windows.Forms.TextBox KodBox;
        private System.Windows.Forms.TextBox KrajBox;
        private System.Windows.Forms.TextBox LoginBox;
        private System.Windows.Forms.TextBox hasloBox;
        private System.Windows.Forms.Button UpdateUserButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}