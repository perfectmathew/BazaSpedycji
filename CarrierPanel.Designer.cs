namespace Magazyn_Spedycji
{
    partial class CarrierPanel
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarrierPanel));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.zamowieniaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.magazynSpedycjiDataSet = new Magazyn_Spedycji.MagazynSpedycjiDataSet();
            this.zamowieniaTableAdapter = new Magazyn_Spedycji.MagazynSpedycjiDataSetTableAdapters.ZamowieniaTableAdapter();
            this.IDZamText = new System.Windows.Forms.Label();
            this.StanZamText = new System.Windows.Forms.Label();
            this.IDZamField = new System.Windows.Forms.TextBox();
            this.UpdateOrderButton = new System.Windows.Forms.Button();
            this.StatusOrderCombo = new System.Windows.Forms.ComboBox();
            this.IDspedy = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.magazynSpedycjiDataSet1 = new Magazyn_Spedycji.MagazynSpedycjiDataSet();
            this.CarrierEditData = new System.Windows.Forms.Panel();
            this.OrdresSwitch = new System.Windows.Forms.Button();
            this.changedataswitch = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zamowieniaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.magazynSpedycjiDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.magazynSpedycjiDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(331, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(647, 488);
            this.dataGridView1.TabIndex = 7;
            // 
            // zamowieniaBindingSource
            // 
            this.zamowieniaBindingSource.DataMember = "Zamowienia";
            this.zamowieniaBindingSource.DataSource = this.magazynSpedycjiDataSet;
            // 
            // magazynSpedycjiDataSet
            // 
            this.magazynSpedycjiDataSet.DataSetName = "MagazynSpedycjiDataSet";
            this.magazynSpedycjiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // zamowieniaTableAdapter
            // 
            this.zamowieniaTableAdapter.ClearBeforeFill = true;
            // 
            // IDZamText
            // 
            this.IDZamText.AutoSize = true;
            this.IDZamText.Location = new System.Drawing.Point(205, 175);
            this.IDZamText.Name = "IDZamText";
            this.IDZamText.Size = new System.Drawing.Size(78, 13);
            this.IDZamText.TabIndex = 8;
            this.IDZamText.Text = "ID Zamówienia";
            // 
            // StanZamText
            // 
            this.StanZamText.AutoSize = true;
            this.StanZamText.Location = new System.Drawing.Point(205, 214);
            this.StanZamText.Name = "StanZamText";
            this.StanZamText.Size = new System.Drawing.Size(89, 13);
            this.StanZamText.TabIndex = 9;
            this.StanZamText.Text = "Stan Zamówienia";
            // 
            // IDZamField
            // 
            this.IDZamField.Location = new System.Drawing.Point(205, 191);
            this.IDZamField.Name = "IDZamField";
            this.IDZamField.Size = new System.Drawing.Size(100, 20);
            this.IDZamField.TabIndex = 10;
            // 
            // UpdateOrderButton
            // 
            this.UpdateOrderButton.BackColor = System.Drawing.SystemColors.Desktop;
            this.UpdateOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateOrderButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.UpdateOrderButton.Location = new System.Drawing.Point(205, 257);
            this.UpdateOrderButton.Name = "UpdateOrderButton";
            this.UpdateOrderButton.Size = new System.Drawing.Size(100, 23);
            this.UpdateOrderButton.TabIndex = 12;
            this.UpdateOrderButton.Text = "Zaktualizuj";
            this.UpdateOrderButton.UseVisualStyleBackColor = false;
            this.UpdateOrderButton.Click += new System.EventHandler(this.UpdateOrderButton_Click);
            // 
            // StatusOrderCombo
            // 
            this.StatusOrderCombo.FormattingEnabled = true;
            this.StatusOrderCombo.Items.AddRange(new object[] {
            "W drodze",
            "Zamknięte"});
            this.StatusOrderCombo.Location = new System.Drawing.Point(205, 230);
            this.StatusOrderCombo.Name = "StatusOrderCombo";
            this.StatusOrderCombo.Size = new System.Drawing.Size(100, 21);
            this.StatusOrderCombo.TabIndex = 13;
            // 
            // IDspedy
            // 
            this.IDspedy.AutoSize = true;
            this.IDspedy.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.IDspedy.Location = new System.Drawing.Point(3, 114);
            this.IDspedy.Name = "IDspedy";
            this.IDspedy.Size = new System.Drawing.Size(35, 13);
            this.IDspedy.TabIndex = 14;
            this.IDspedy.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel1.Controls.Add(this.OrdresSwitch);
            this.panel1.Controls.Add(this.IDspedy);
            this.panel1.Controls.Add(this.changedataswitch);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 514);
            this.panel1.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel2.Location = new System.Drawing.Point(197, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(781, 24);
            this.panel2.TabIndex = 17;
            // 
            // magazynSpedycjiDataSet1
            // 
            this.magazynSpedycjiDataSet1.DataSetName = "MagazynSpedycjiDataSet";
            this.magazynSpedycjiDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CarrierEditData
            // 
            this.CarrierEditData.Location = new System.Drawing.Point(200, 23);
            this.CarrierEditData.Name = "CarrierEditData";
            this.CarrierEditData.Size = new System.Drawing.Size(775, 487);
            this.CarrierEditData.TabIndex = 18;
            // 
            // OrdresSwitch
            // 
            this.OrdresSwitch.BackColor = System.Drawing.Color.Transparent;
            this.OrdresSwitch.FlatAppearance.BorderSize = 0;
            this.OrdresSwitch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OrdresSwitch.Font = new System.Drawing.Font("Nexa Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrdresSwitch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.OrdresSwitch.Image = global::Magazyn_Spedycji.Properties.Resources.orders;
            this.OrdresSwitch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OrdresSwitch.Location = new System.Drawing.Point(-1, 364);
            this.OrdresSwitch.Name = "OrdresSwitch";
            this.OrdresSwitch.Size = new System.Drawing.Size(200, 74);
            this.OrdresSwitch.TabIndex = 15;
            this.OrdresSwitch.Text = "Zamówienia";
            this.OrdresSwitch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.OrdresSwitch.UseVisualStyleBackColor = false;
            this.OrdresSwitch.Click += new System.EventHandler(this.OrdresSwitch_Click);
            // 
            // changedataswitch
            // 
            this.changedataswitch.BackColor = System.Drawing.Color.Transparent;
            this.changedataswitch.FlatAppearance.BorderSize = 0;
            this.changedataswitch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changedataswitch.Font = new System.Drawing.Font("Nexa Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changedataswitch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.changedataswitch.Image = global::Magazyn_Spedycji.Properties.Resources.usericon;
            this.changedataswitch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.changedataswitch.Location = new System.Drawing.Point(0, 438);
            this.changedataswitch.Name = "changedataswitch";
            this.changedataswitch.Size = new System.Drawing.Size(197, 74);
            this.changedataswitch.TabIndex = 15;
            this.changedataswitch.Text = "Moje Konto";
            this.changedataswitch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.changedataswitch.UseVisualStyleBackColor = false;
            this.changedataswitch.Click += new System.EventHandler(this.changedataswitch_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Magazyn_Spedycji.Properties.Resources.logo1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // CarrierPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 511);
            this.Controls.Add(this.CarrierEditData);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.StatusOrderCombo);
            this.Controls.Add(this.UpdateOrderButton);
            this.Controls.Add(this.IDZamField);
            this.Controls.Add(this.StanZamText);
            this.Controls.Add(this.IDZamText);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CarrierPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Secret Shipping | CarrierPanel";
            this.Load += new System.EventHandler(this.CarrierPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zamowieniaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.magazynSpedycjiDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.magazynSpedycjiDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private MagazynSpedycjiDataSet magazynSpedycjiDataSet;
        private System.Windows.Forms.BindingSource zamowieniaBindingSource;
        private MagazynSpedycjiDataSetTableAdapters.ZamowieniaTableAdapter zamowieniaTableAdapter;
        private System.Windows.Forms.Label IDZamText;
        private System.Windows.Forms.Label StanZamText;
        private System.Windows.Forms.TextBox IDZamField;
        private System.Windows.Forms.Button UpdateOrderButton;
        private System.Windows.Forms.ComboBox StatusOrderCombo;
        private System.Windows.Forms.Label IDspedy;
        private System.Windows.Forms.Button changedataswitch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button OrdresSwitch;
        private System.Windows.Forms.Panel panel2;
        private MagazynSpedycjiDataSet magazynSpedycjiDataSet1;
        private System.Windows.Forms.Panel CarrierEditData;
    }
}