namespace Magazyn_Spedycji
{
    partial class MagazynSpedycji
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MagazynSpedycji));
            this.register_password = new System.Windows.Forms.TextBox();
            this.login_register = new System.Windows.Forms.TextBox();
            this.UserAccessL = new System.Windows.Forms.ComboBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.loginString = new System.Windows.Forms.Label();
            this.DevButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PasswordReval = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.magazynSpedycjiDataSet1 = new Magazyn_Spedycji.MagazynSpedycjiDataSet();
            this.RegisterPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SingInSwitch = new System.Windows.Forms.Button();
            this.SingUpSwitch = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.magazynSpedycjiDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // register_password
            // 
            this.register_password.Location = new System.Drawing.Point(518, 387);
            this.register_password.Name = "register_password";
            this.register_password.Size = new System.Drawing.Size(123, 20);
            this.register_password.TabIndex = 0;
            this.register_password.UseSystemPasswordChar = true;
            // 
            // login_register
            // 
            this.login_register.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.login_register.Location = new System.Drawing.Point(518, 348);
            this.login_register.Name = "login_register";
            this.login_register.Size = new System.Drawing.Size(123, 20);
            this.login_register.TabIndex = 2;
            this.login_register.TextChanged += new System.EventHandler(this.login_register_TextChanged);
            // 
            // UserAccessL
            // 
            this.UserAccessL.FormattingEnabled = true;
            this.UserAccessL.Items.AddRange(new object[] {
            "Pracownik",
            "Klient",
            "Spedytor"});
            this.UserAccessL.Location = new System.Drawing.Point(520, 426);
            this.UserAccessL.Name = "UserAccessL";
            this.UserAccessL.Size = new System.Drawing.Size(123, 21);
            this.UserAccessL.TabIndex = 3;
            this.UserAccessL.SelectedIndexChanged += new System.EventHandler(this.UserAccessL_SelectedIndexChanged);
            // 
            // LoginButton
            // 
            this.LoginButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LoginButton.BackColor = System.Drawing.SystemColors.Desktop;
            this.LoginButton.FlatAppearance.BorderSize = 0;
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LoginButton.Location = new System.Drawing.Point(520, 456);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(123, 23);
            this.LoginButton.TabIndex = 4;
            this.LoginButton.Text = "Zaloguj";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // loginString
            // 
            this.loginString.AutoSize = true;
            this.loginString.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.loginString.Location = new System.Drawing.Point(513, 298);
            this.loginString.Name = "loginString";
            this.loginString.Size = new System.Drawing.Size(125, 25);
            this.loginString.TabIndex = 6;
            this.loginString.Text = "Logowanie";
            this.loginString.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DevButton
            // 
            this.DevButton.Location = new System.Drawing.Point(24, 12);
            this.DevButton.Name = "DevButton";
            this.DevButton.Size = new System.Drawing.Size(75, 23);
            this.DevButton.TabIndex = 9;
            this.DevButton.Text = "Dev";
            this.DevButton.UseVisualStyleBackColor = true;
            this.DevButton.Click += new System.EventHandler(this.DevButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(515, 332);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(516, 371);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Hasło";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(518, 411);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Wybierz poziom uprawnień:";
            // 
            // PasswordReval
            // 
            this.PasswordReval.AutoSize = true;
            this.PasswordReval.Location = new System.Drawing.Point(647, 390);
            this.PasswordReval.Name = "PasswordReval";
            this.PasswordReval.Size = new System.Drawing.Size(15, 14);
            this.PasswordReval.TabIndex = 13;
            this.PasswordReval.UseVisualStyleBackColor = true;
            this.PasswordReval.CheckedChanged += new System.EventHandler(this.PasswordReval_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel1.Controls.Add(this.SingInSwitch);
            this.panel1.Controls.Add(this.SingUpSwitch);
            this.panel1.Location = new System.Drawing.Point(-1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 510);
            this.panel1.TabIndex = 14;
            // 
            // magazynSpedycjiDataSet1
            // 
            this.magazynSpedycjiDataSet1.DataSetName = "MagazynSpedycjiDataSet";
            this.magazynSpedycjiDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // RegisterPanel
            // 
            this.RegisterPanel.Location = new System.Drawing.Point(372, 301);
            this.RegisterPanel.Name = "RegisterPanel";
            this.RegisterPanel.Size = new System.Drawing.Size(447, 201);
            this.RegisterPanel.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel2.Location = new System.Drawing.Point(197, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(777, 18);
            this.panel2.TabIndex = 16;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Magazyn_Spedycji.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(324, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(495, 283);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // SingInSwitch
            // 
            this.SingInSwitch.BackColor = System.Drawing.Color.Transparent;
            this.SingInSwitch.FlatAppearance.BorderSize = 0;
            this.SingInSwitch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SingInSwitch.Font = new System.Drawing.Font("Nexa Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SingInSwitch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SingInSwitch.Image = global::Magazyn_Spedycji.Properties.Resources.login;
            this.SingInSwitch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SingInSwitch.Location = new System.Drawing.Point(0, 357);
            this.SingInSwitch.Name = "SingInSwitch";
            this.SingInSwitch.Size = new System.Drawing.Size(200, 72);
            this.SingInSwitch.TabIndex = 7;
            this.SingInSwitch.Text = "Zaloguj";
            this.SingInSwitch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SingInSwitch.UseVisualStyleBackColor = false;
            this.SingInSwitch.Click += new System.EventHandler(this.SingInSwitch_Click);
            // 
            // SingUpSwitch
            // 
            this.SingUpSwitch.BackColor = System.Drawing.Color.Transparent;
            this.SingUpSwitch.FlatAppearance.BorderSize = 0;
            this.SingUpSwitch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SingUpSwitch.Font = new System.Drawing.Font("Nexa Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SingUpSwitch.ForeColor = System.Drawing.SystemColors.Control;
            this.SingUpSwitch.Image = global::Magazyn_Spedycji.Properties.Resources.register;
            this.SingUpSwitch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SingUpSwitch.Location = new System.Drawing.Point(0, 435);
            this.SingUpSwitch.Name = "SingUpSwitch";
            this.SingUpSwitch.Size = new System.Drawing.Size(200, 75);
            this.SingUpSwitch.TabIndex = 8;
            this.SingUpSwitch.Text = "Zarejestruj";
            this.SingUpSwitch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SingUpSwitch.UseVisualStyleBackColor = false;
            this.SingUpSwitch.Click += new System.EventHandler(this.SingUpSwitch_Click);
            // 
            // MagazynSpedycji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 511);
            this.Controls.Add(this.RegisterPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.PasswordReval);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DevButton);
            this.Controls.Add(this.loginString);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.UserAccessL);
            this.Controls.Add(this.login_register);
            this.Controls.Add(this.register_password);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MagazynSpedycji";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Secret Shipping | Main Menu";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.magazynSpedycjiDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox register_password;
        private System.Windows.Forms.ComboBox UserAccessL;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label loginString;
        private System.Windows.Forms.Button SingInSwitch;
        private System.Windows.Forms.Button SingUpSwitch;
        private System.Windows.Forms.Button DevButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox PasswordReval;
        public System.Windows.Forms.TextBox login_register;
        private System.Windows.Forms.Panel panel1;
        private MagazynSpedycjiDataSet magazynSpedycjiDataSet1;
        private System.Windows.Forms.Panel RegisterPanel;
        private System.Windows.Forms.Panel panel2;
    }
}

