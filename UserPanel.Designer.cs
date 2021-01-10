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
            this.panel2 = new System.Windows.Forms.Panel();
            this.UserData = new System.Windows.Forms.Panel();
            this.ShopPanel = new System.Windows.Forms.Panel();
            this.OrdersPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MyDataOpen = new System.Windows.Forms.Button();
            this.ShopOpen = new System.Windows.Forms.Button();
            this.ZamOpenButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.UserData.SuspendLayout();
            this.ShopPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(200, -2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(776, 35);
            this.panel2.TabIndex = 53;
            // 
            // UserData
            // 
            this.UserData.Controls.Add(this.ShopPanel);
            this.UserData.Location = new System.Drawing.Point(201, 34);
            this.UserData.Name = "UserData";
            this.UserData.Size = new System.Drawing.Size(773, 479);
            this.UserData.TabIndex = 54;
            // 
            // ShopPanel
            // 
            this.ShopPanel.Controls.Add(this.OrdersPanel);
            this.ShopPanel.Location = new System.Drawing.Point(3, 3);
            this.ShopPanel.Name = "ShopPanel";
            this.ShopPanel.Size = new System.Drawing.Size(773, 479);
            this.ShopPanel.TabIndex = 0;
            // 
            // OrdersPanel
            // 
            this.OrdersPanel.Location = new System.Drawing.Point(3, 3);
            this.OrdersPanel.Name = "OrdersPanel";
            this.OrdersPanel.Size = new System.Drawing.Size(773, 479);
            this.OrdersPanel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.MyDataOpen);
            this.panel1.Controls.Add(this.ShopOpen);
            this.panel1.Controls.Add(this.ZamOpenButton);
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 517);
            this.panel1.TabIndex = 53;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Magazyn_Spedycji.Properties.Resources.logo1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // MyDataOpen
            // 
            this.MyDataOpen.FlatAppearance.BorderSize = 0;
            this.MyDataOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MyDataOpen.Font = new System.Drawing.Font("Nexa Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MyDataOpen.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MyDataOpen.Image = global::Magazyn_Spedycji.Properties.Resources.register;
            this.MyDataOpen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MyDataOpen.Location = new System.Drawing.Point(0, 180);
            this.MyDataOpen.Name = "MyDataOpen";
            this.MyDataOpen.Size = new System.Drawing.Size(201, 76);
            this.MyDataOpen.TabIndex = 7;
            this.MyDataOpen.Text = "Moje dane";
            this.MyDataOpen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.MyDataOpen.UseVisualStyleBackColor = true;
            this.MyDataOpen.Click += new System.EventHandler(this.MyDataOpen_Click);
            // 
            // ShopOpen
            // 
            this.ShopOpen.FlatAppearance.BorderSize = 0;
            this.ShopOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShopOpen.Font = new System.Drawing.Font("Nexa Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShopOpen.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ShopOpen.Image = global::Magazyn_Spedycji.Properties.Resources.shop;
            this.ShopOpen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ShopOpen.Location = new System.Drawing.Point(0, 254);
            this.ShopOpen.Name = "ShopOpen";
            this.ShopOpen.Size = new System.Drawing.Size(201, 83);
            this.ShopOpen.TabIndex = 8;
            this.ShopOpen.Text = "Sklep";
            this.ShopOpen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ShopOpen.UseVisualStyleBackColor = true;
            this.ShopOpen.Click += new System.EventHandler(this.ShopOpen_Click);
            // 
            // ZamOpenButton
            // 
            this.ZamOpenButton.FlatAppearance.BorderSize = 0;
            this.ZamOpenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ZamOpenButton.Font = new System.Drawing.Font("Nexa Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZamOpenButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ZamOpenButton.Image = global::Magazyn_Spedycji.Properties.Resources.orders;
            this.ZamOpenButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ZamOpenButton.Location = new System.Drawing.Point(0, 327);
            this.ZamOpenButton.Name = "ZamOpenButton";
            this.ZamOpenButton.Size = new System.Drawing.Size(201, 89);
            this.ZamOpenButton.TabIndex = 9;
            this.ZamOpenButton.Text = "Moje zamówienia";
            this.ZamOpenButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ZamOpenButton.UseVisualStyleBackColor = true;
            this.ZamOpenButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::Magazyn_Spedycji.Properties.Resources.logout;
            this.button1.Location = new System.Drawing.Point(731, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(43, 35);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UserPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 511);
            this.Controls.Add(this.UserData);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Secret Shipping | UserPanel";
            this.Load += new System.EventHandler(this.UserPanel_Load);
            this.panel2.ResumeLayout(false);
            this.UserData.ResumeLayout(false);
            this.ShopPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button MyDataOpen;
        private System.Windows.Forms.Button ShopOpen;
        private System.Windows.Forms.Button ZamOpenButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel UserData;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel ShopPanel;
        private System.Windows.Forms.Panel OrdersPanel;
        private System.Windows.Forms.Button button1;
    }
}