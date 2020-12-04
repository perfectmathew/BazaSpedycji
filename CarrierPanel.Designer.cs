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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.zamowieniaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.magazynSpedycjiDataSet = new Magazyn_Spedycji.MagazynSpedycjiDataSet();
            this.zamowieniaTableAdapter = new Magazyn_Spedycji.MagazynSpedycjiDataSetTableAdapters.ZamowieniaTableAdapter();
            this.IDZamText = new System.Windows.Forms.Label();
            this.StanZamText = new System.Windows.Forms.Label();
            this.IDZamField = new System.Windows.Forms.TextBox();
            this.StanZamField = new System.Windows.Forms.TextBox();
            this.UpdateOrderButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zamowieniaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.magazynSpedycjiDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Magazyn_Spedycji.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(-26, -15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(267, 151);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(247, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(715, 487);
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
            this.IDZamText.Location = new System.Drawing.Point(38, 186);
            this.IDZamText.Name = "IDZamText";
            this.IDZamText.Size = new System.Drawing.Size(78, 13);
            this.IDZamText.TabIndex = 8;
            this.IDZamText.Text = "ID Zamówienia";
            // 
            // StanZamText
            // 
            this.StanZamText.AutoSize = true;
            this.StanZamText.Location = new System.Drawing.Point(38, 226);
            this.StanZamText.Name = "StanZamText";
            this.StanZamText.Size = new System.Drawing.Size(89, 13);
            this.StanZamText.TabIndex = 9;
            this.StanZamText.Text = "Stan Zamówienia";
            // 
            // IDZamField
            // 
            this.IDZamField.Location = new System.Drawing.Point(41, 203);
            this.IDZamField.Name = "IDZamField";
            this.IDZamField.Size = new System.Drawing.Size(100, 20);
            this.IDZamField.TabIndex = 10;
            // 
            // StanZamField
            // 
            this.StanZamField.Location = new System.Drawing.Point(41, 243);
            this.StanZamField.Name = "StanZamField";
            this.StanZamField.Size = new System.Drawing.Size(100, 20);
            this.StanZamField.TabIndex = 11;
            // 
            // UpdateOrderButton
            // 
            this.UpdateOrderButton.Location = new System.Drawing.Point(41, 269);
            this.UpdateOrderButton.Name = "UpdateOrderButton";
            this.UpdateOrderButton.Size = new System.Drawing.Size(100, 23);
            this.UpdateOrderButton.TabIndex = 12;
            this.UpdateOrderButton.Text = "Update";
            this.UpdateOrderButton.UseVisualStyleBackColor = true;
            this.UpdateOrderButton.Click += new System.EventHandler(this.UpdateOrderButton_Click);
            // 
            // CarrierPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 511);
            this.Controls.Add(this.UpdateOrderButton);
            this.Controls.Add(this.StanZamField);
            this.Controls.Add(this.IDZamField);
            this.Controls.Add(this.StanZamText);
            this.Controls.Add(this.IDZamText);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CarrierPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Secret Shipping | CarrierPanel";
            this.Load += new System.EventHandler(this.CarrierPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zamowieniaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.magazynSpedycjiDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MagazynSpedycjiDataSet magazynSpedycjiDataSet;
        private System.Windows.Forms.BindingSource zamowieniaBindingSource;
        private MagazynSpedycjiDataSetTableAdapters.ZamowieniaTableAdapter zamowieniaTableAdapter;
        private System.Windows.Forms.Label IDZamText;
        private System.Windows.Forms.Label StanZamText;
        private System.Windows.Forms.TextBox IDZamField;
        private System.Windows.Forms.TextBox StanZamField;
        private System.Windows.Forms.Button UpdateOrderButton;
    }
}