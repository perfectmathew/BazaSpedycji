namespace Magazyn_Spedycji
{
    partial class AdminPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPanel));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.UsersButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ProductsButton = new System.Windows.Forms.Button();
            this.StorageButton = new System.Windows.Forms.Button();
            this.CarrierButton = new System.Windows.Forms.Button();
            this.DeleteIDBOX = new System.Windows.Forms.TextBox();
            this.DeleteIndex = new System.Windows.Forms.Button();
            this.OrdersButton = new System.Windows.Forms.Button();
            this.RaportsBox = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.klienciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.magazynSpedycjiDataSet = new Magazyn_Spedycji.MagazynSpedycjiDataSet();
            this.klienciTableAdapter = new Magazyn_Spedycji.MagazynSpedycjiDataSetTableAdapters.KlienciTableAdapter();
            this.UserIDText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klienciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.magazynSpedycjiDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Magazyn_Spedycji.Properties.Resources.logo;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // UsersButton
            // 
            resources.ApplyResources(this.UsersButton, "UsersButton");
            this.UsersButton.Name = "UsersButton";
            this.UsersButton.UseVisualStyleBackColor = true;
            this.UsersButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // ProductsButton
            // 
            resources.ApplyResources(this.ProductsButton, "ProductsButton");
            this.ProductsButton.Name = "ProductsButton";
            this.ProductsButton.UseVisualStyleBackColor = true;
            // 
            // StorageButton
            // 
            resources.ApplyResources(this.StorageButton, "StorageButton");
            this.StorageButton.Name = "StorageButton";
            this.StorageButton.UseVisualStyleBackColor = true;
            // 
            // CarrierButton
            // 
            resources.ApplyResources(this.CarrierButton, "CarrierButton");
            this.CarrierButton.Name = "CarrierButton";
            this.CarrierButton.UseVisualStyleBackColor = true;
            this.CarrierButton.Click += new System.EventHandler(this.CarrierButton_Click);
            // 
            // DeleteIDBOX
            // 
            resources.ApplyResources(this.DeleteIDBOX, "DeleteIDBOX");
            this.DeleteIDBOX.Name = "DeleteIDBOX";
            // 
            // DeleteIndex
            // 
            resources.ApplyResources(this.DeleteIndex, "DeleteIndex");
            this.DeleteIndex.Name = "DeleteIndex";
            this.DeleteIndex.UseVisualStyleBackColor = true;
            this.DeleteIndex.Click += new System.EventHandler(this.DeleteIndex_Click);
            // 
            // OrdersButton
            // 
            resources.ApplyResources(this.OrdersButton, "OrdersButton");
            this.OrdersButton.Name = "OrdersButton";
            this.OrdersButton.UseVisualStyleBackColor = true;
            // 
            // RaportsBox
            // 
            resources.ApplyResources(this.RaportsBox, "RaportsBox");
            this.RaportsBox.Name = "RaportsBox";
            this.RaportsBox.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            // 
            // klienciBindingSource
            // 
            this.klienciBindingSource.DataMember = "Klienci";
            this.klienciBindingSource.DataSource = this.magazynSpedycjiDataSet;
            // 
            // magazynSpedycjiDataSet
            // 
            this.magazynSpedycjiDataSet.DataSetName = "MagazynSpedycjiDataSet";
            this.magazynSpedycjiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // klienciTableAdapter
            // 
            this.klienciTableAdapter.ClearBeforeFill = true;
            // 
            // UserIDText
            // 
            resources.ApplyResources(this.UserIDText, "UserIDText");
            this.UserIDText.Name = "UserIDText";
            // 
            // AdminPanel
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.UserIDText);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RaportsBox);
            this.Controls.Add(this.OrdersButton);
            this.Controls.Add(this.DeleteIndex);
            this.Controls.Add(this.DeleteIDBOX);
            this.Controls.Add(this.CarrierButton);
            this.Controls.Add(this.StorageButton);
            this.Controls.Add(this.ProductsButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UsersButton);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AdminPanel";
            this.Load += new System.EventHandler(this.AdminPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klienciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.magazynSpedycjiDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button UsersButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ProductsButton;
        private System.Windows.Forms.Button StorageButton;
        private System.Windows.Forms.Button CarrierButton;
        private System.Windows.Forms.TextBox DeleteIDBOX;
        private System.Windows.Forms.Button DeleteIndex;
        private System.Windows.Forms.Button OrdersButton;
        private System.Windows.Forms.Button RaportsBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MagazynSpedycjiDataSet magazynSpedycjiDataSet;
        private System.Windows.Forms.BindingSource klienciBindingSource;
        private MagazynSpedycjiDataSetTableAdapters.KlienciTableAdapter klienciTableAdapter;
        private System.Windows.Forms.Label UserIDText;
    }
}