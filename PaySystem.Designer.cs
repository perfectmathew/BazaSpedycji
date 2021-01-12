namespace Magazyn_Spedycji
{
    partial class PaySystem
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
            this.PaymentsMethod = new System.Windows.Forms.ComboBox();
            this.Uwagi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PriceText = new System.Windows.Forms.Label();
            this.DeliveryOption = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.PayButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // PaymentsMethod
            // 
            this.PaymentsMethod.FormattingEnabled = true;
            this.PaymentsMethod.Items.AddRange(new object[] {
            "Paypal",
            "Przelew 24H",
            "Blik",
            "Czek"});
            this.PaymentsMethod.Location = new System.Drawing.Point(612, 35);
            this.PaymentsMethod.Name = "PaymentsMethod";
            this.PaymentsMethod.Size = new System.Drawing.Size(124, 21);
            this.PaymentsMethod.TabIndex = 44;
            // 
            // Uwagi
            // 
            this.Uwagi.Location = new System.Drawing.Point(482, 78);
            this.Uwagi.Multiline = true;
            this.Uwagi.Name = "Uwagi";
            this.Uwagi.Size = new System.Drawing.Size(124, 50);
            this.Uwagi.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(482, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 46;
            this.label1.Text = "Uwagi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(609, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 47;
            this.label2.Text = "Metoda płatności:";
            // 
            // PriceText
            // 
            this.PriceText.AutoSize = true;
            this.PriceText.Font = new System.Drawing.Font("Nexa Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceText.ForeColor = System.Drawing.SystemColors.Desktop;
            this.PriceText.Location = new System.Drawing.Point(482, 223);
            this.PriceText.Name = "PriceText";
            this.PriceText.Size = new System.Drawing.Size(56, 20);
            this.PriceText.TabIndex = 49;
            this.PriceText.Text = "label3";
            // 
            // DeliveryOption
            // 
            this.DeliveryOption.FormattingEnabled = true;
            this.DeliveryOption.Items.AddRange(new object[] {
            "DPD 24H",
            "DHL Fast Delivery",
            "UPS Fast Service"});
            this.DeliveryOption.Location = new System.Drawing.Point(482, 35);
            this.DeliveryOption.Name = "DeliveryOption";
            this.DeliveryOption.Size = new System.Drawing.Size(124, 21);
            this.DeliveryOption.TabIndex = 50;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(464, 238);
            this.dataGridView1.TabIndex = 51;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(485, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 52;
            this.label3.Text = "Sposób dostawy:";
            // 
            // PayButton
            // 
            this.PayButton.BackColor = System.Drawing.SystemColors.Desktop;
            this.PayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PayButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.PayButton.Image = global::Magazyn_Spedycji.Properties.Resources.cash;
            this.PayButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PayButton.Location = new System.Drawing.Point(612, 82);
            this.PayButton.Name = "PayButton";
            this.PayButton.Size = new System.Drawing.Size(124, 46);
            this.PayButton.TabIndex = 41;
            this.PayButton.Text = "Zapłać";
            this.PayButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.PayButton.UseVisualStyleBackColor = false;
            this.PayButton.Click += new System.EventHandler(this.PayButton_Click);
            // 
            // PaySystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 262);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.DeliveryOption);
            this.Controls.Add(this.PriceText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Uwagi);
            this.Controls.Add(this.PaymentsMethod);
            this.Controls.Add(this.PayButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "PaySystem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment Gateway";
            this.Load += new System.EventHandler(this.PaySystem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PayButton;
        private System.Windows.Forms.ComboBox PaymentsMethod;
        private System.Windows.Forms.TextBox Uwagi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label PriceText;
        private System.Windows.Forms.ComboBox DeliveryOption;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
    }
}