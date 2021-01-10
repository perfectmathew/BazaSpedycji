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
            this.zamowieniaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.magazynSpedycjiDataSet = new Magazyn_Spedycji.MagazynSpedycjiDataSet();
            this.zamowieniaTableAdapter = new Magazyn_Spedycji.MagazynSpedycjiDataSetTableAdapters.ZamowieniaTableAdapter();
            this.StanZamText = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.OrdresSwitch = new System.Windows.Forms.Button();
            this.changedataswitch = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.magazynSpedycjiDataSet1 = new Magazyn_Spedycji.MagazynSpedycjiDataSet();
            this.CarrierEditData = new System.Windows.Forms.Panel();
            this.CarrierOrdersPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.zamowieniaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.magazynSpedycjiDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.magazynSpedycjiDataSet1)).BeginInit();
            this.CarrierEditData.SuspendLayout();
            this.CarrierOrdersPanel.SuspendLayout();
            this.SuspendLayout();
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
            // StanZamText
            // 
            this.StanZamText.AutoSize = true;
            this.StanZamText.Font = new System.Drawing.Font("Nexa Bold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StanZamText.Location = new System.Drawing.Point(145, 159);
            this.StanZamText.Name = "StanZamText";
            this.StanZamText.Size = new System.Drawing.Size(283, 39);
            this.StanZamText.TabIndex = 9;
            this.StanZamText.Text = "Stan Zamówienia";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel1.Controls.Add(this.OrdresSwitch);
            this.panel1.Controls.Add(this.changedataswitch);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 514);
            this.panel1.TabIndex = 16;
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
            this.CarrierEditData.Controls.Add(this.CarrierOrdersPanel);
            this.CarrierEditData.Location = new System.Drawing.Point(200, 23);
            this.CarrierEditData.Name = "CarrierEditData";
            this.CarrierEditData.Size = new System.Drawing.Size(775, 487);
            this.CarrierEditData.TabIndex = 18;
            // 
            // CarrierOrdersPanel
            // 
            this.CarrierOrdersPanel.Controls.Add(this.StanZamText);
            this.CarrierOrdersPanel.Location = new System.Drawing.Point(3, 3);
            this.CarrierOrdersPanel.Name = "CarrierOrdersPanel";
            this.CarrierOrdersPanel.Size = new System.Drawing.Size(775, 487);
            this.CarrierOrdersPanel.TabIndex = 16;
            // 
            // CarrierPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 511);
            this.Controls.Add(this.CarrierEditData);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CarrierPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Secret Shipping | CarrierPanel";
            this.Load += new System.EventHandler(this.CarrierPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.zamowieniaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.magazynSpedycjiDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.magazynSpedycjiDataSet1)).EndInit();
            this.CarrierEditData.ResumeLayout(false);
            this.CarrierOrdersPanel.ResumeLayout(false);
            this.CarrierOrdersPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MagazynSpedycjiDataSet magazynSpedycjiDataSet;
        private System.Windows.Forms.BindingSource zamowieniaBindingSource;
        private MagazynSpedycjiDataSetTableAdapters.ZamowieniaTableAdapter zamowieniaTableAdapter;
        private System.Windows.Forms.Label StanZamText;
        private System.Windows.Forms.Button changedataswitch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button OrdresSwitch;
        private System.Windows.Forms.Panel panel2;
        private MagazynSpedycjiDataSet magazynSpedycjiDataSet1;
        private System.Windows.Forms.Panel CarrierEditData;
        private System.Windows.Forms.Panel CarrierOrdersPanel;
    }
}