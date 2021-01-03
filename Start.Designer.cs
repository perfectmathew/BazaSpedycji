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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.loginString = new System.Windows.Forms.Label();
            this.SingInSwitch = new System.Windows.Forms.Button();
            this.SingUpSwitch = new System.Windows.Forms.Button();
            this.DevButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PasswordReval = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // register_password
            // 
            this.register_password.Location = new System.Drawing.Point(427, 412);
            this.register_password.Name = "register_password";
            this.register_password.Size = new System.Drawing.Size(123, 20);
            this.register_password.TabIndex = 0;
            this.register_password.UseSystemPasswordChar = true;
            // 
            // login_register
            // 
            this.login_register.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.login_register.Location = new System.Drawing.Point(427, 376);
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
            this.UserAccessL.Location = new System.Drawing.Point(427, 447);
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
            this.LoginButton.Location = new System.Drawing.Point(427, 474);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(123, 23);
            this.LoginButton.TabIndex = 4;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Magazyn_Spedycji.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(233, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(495, 283);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // loginString
            // 
            this.loginString.AutoSize = true;
            this.loginString.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.loginString.Location = new System.Drawing.Point(423, 335);
            this.loginString.Name = "loginString";
            this.loginString.Size = new System.Drawing.Size(125, 25);
            this.loginString.TabIndex = 6;
            this.loginString.Text = "Logowanie";
            this.loginString.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // SingInSwitch
            // 
            this.SingInSwitch.Location = new System.Drawing.Point(409, 301);
            this.SingInSwitch.Name = "SingInSwitch";
            this.SingInSwitch.Size = new System.Drawing.Size(75, 23);
            this.SingInSwitch.TabIndex = 7;
            this.SingInSwitch.Text = "Zaloguj";
            this.SingInSwitch.UseVisualStyleBackColor = true;
            this.SingInSwitch.Click += new System.EventHandler(this.SingInSwitch_Click);
            // 
            // SingUpSwitch
            // 
            this.SingUpSwitch.Location = new System.Drawing.Point(490, 301);
            this.SingUpSwitch.Name = "SingUpSwitch";
            this.SingUpSwitch.Size = new System.Drawing.Size(75, 23);
            this.SingUpSwitch.TabIndex = 8;
            this.SingUpSwitch.Text = "Zarejestruj";
            this.SingUpSwitch.UseVisualStyleBackColor = true;
            this.SingUpSwitch.Click += new System.EventHandler(this.SingUpSwitch_Click);
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
            this.label1.Location = new System.Drawing.Point(424, 360);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(425, 397);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Hasło";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(425, 432);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Wybierz poziom uprawnień:";
            // 
            // PasswordReval
            // 
            this.PasswordReval.AutoSize = true;
            this.PasswordReval.Location = new System.Drawing.Point(556, 415);
            this.PasswordReval.Name = "PasswordReval";
            this.PasswordReval.Size = new System.Drawing.Size(15, 14);
            this.PasswordReval.TabIndex = 13;
            this.PasswordReval.UseVisualStyleBackColor = true;
            this.PasswordReval.CheckedChanged += new System.EventHandler(this.PasswordReval_CheckedChanged);
            // 
            // MagazynSpedycji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 511);
            this.Controls.Add(this.PasswordReval);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DevButton);
            this.Controls.Add(this.SingUpSwitch);
            this.Controls.Add(this.SingInSwitch);
            this.Controls.Add(this.loginString);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.UserAccessL);
            this.Controls.Add(this.login_register);
            this.Controls.Add(this.register_password);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MagazynSpedycji";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Secret Shipping | Main Menu";
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
    }
}

