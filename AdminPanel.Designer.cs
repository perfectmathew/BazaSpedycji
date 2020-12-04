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
            this.label1 = new System.Windows.Forms.Label();
            this.DeleteIDBOX = new System.Windows.Forms.TextBox();
            this.DeleteIndex = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.klienciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.magazynSpedycjiDataSet = new Magazyn_Spedycji.MagazynSpedycjiDataSet();
            this.klienciTableAdapter = new Magazyn_Spedycji.MagazynSpedycjiDataSetTableAdapters.KlienciTableAdapter();
            this.UserIDText = new System.Windows.Forms.Label();
            this.pokaz_tabele = new System.Windows.Forms.Button();
            this.tabeleBox = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.edycja_rdk = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klienciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.magazynSpedycjiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
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
            // pokaz_tabele
            // 
            resources.ApplyResources(this.pokaz_tabele, "pokaz_tabele");
            this.pokaz_tabele.Name = "pokaz_tabele";
            this.pokaz_tabele.UseVisualStyleBackColor = true;
            this.pokaz_tabele.Click += new System.EventHandler(this.pokaz_tabele_Click);
            // 
            // tabeleBox
            // 
            this.tabeleBox.FormattingEnabled = true;
            this.tabeleBox.Items.AddRange(new object[] {
            resources.GetString("tabeleBox.Items"),
            resources.GetString("tabeleBox.Items1"),
            resources.GetString("tabeleBox.Items2"),
            resources.GetString("tabeleBox.Items3"),
            resources.GetString("tabeleBox.Items4")});
            resources.ApplyResources(this.tabeleBox, "tabeleBox");
            this.tabeleBox.Name = "tabeleBox";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Magazyn_Spedycji.Properties.Resources.logo;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // edycja_rdk
            // 
            resources.ApplyResources(this.edycja_rdk, "edycja_rdk");
            this.edycja_rdk.Name = "edycja_rdk";
            this.edycja_rdk.UseVisualStyleBackColor = true;
            this.edycja_rdk.Click += new System.EventHandler(this.edycja_rdk_Click);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // AdminPanel
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.edycja_rdk);
            this.Controls.Add(this.tabeleBox);
            this.Controls.Add(this.pokaz_tabele);
            this.Controls.Add(this.UserIDText);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.DeleteIndex);
            this.Controls.Add(this.DeleteIDBOX);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AdminPanel";
            this.Load += new System.EventHandler(this.AdminPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klienciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.magazynSpedycjiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DeleteIDBOX;
        private System.Windows.Forms.Button DeleteIndex;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MagazynSpedycjiDataSet magazynSpedycjiDataSet;
        private System.Windows.Forms.BindingSource klienciBindingSource;
        private MagazynSpedycjiDataSetTableAdapters.KlienciTableAdapter klienciTableAdapter;
        private System.Windows.Forms.Label UserIDText;
        private System.Windows.Forms.Button pokaz_tabele;
        private System.Windows.Forms.ComboBox tabeleBox;
        private System.Windows.Forms.Button edycja_rdk;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}