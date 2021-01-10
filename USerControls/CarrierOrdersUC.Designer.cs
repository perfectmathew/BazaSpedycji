namespace Magazyn_Spedycji.USerControls
{
    partial class CarrierOrdersUC
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.IDZamField = new System.Windows.Forms.TextBox();
            this.IDZamText = new System.Windows.Forms.Label();
            this.StatusOrderCombo = new System.Windows.Forms.ComboBox();
            this.UpdateOrderButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(212, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(525, 399);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nexa Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(402, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Zamówienia:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel1.Location = new System.Drawing.Point(189, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(17, 399);
            this.panel1.TabIndex = 2;
            // 
            // IDZamField
            // 
            this.IDZamField.Location = new System.Drawing.Point(27, 188);
            this.IDZamField.Name = "IDZamField";
            this.IDZamField.Size = new System.Drawing.Size(141, 20);
            this.IDZamField.TabIndex = 11;
            // 
            // IDZamText
            // 
            this.IDZamText.AutoSize = true;
            this.IDZamText.Font = new System.Drawing.Font("Nexa Bold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDZamText.Location = new System.Drawing.Point(40, 167);
            this.IDZamText.Name = "IDZamText";
            this.IDZamText.Size = new System.Drawing.Size(113, 18);
            this.IDZamText.TabIndex = 12;
            this.IDZamText.Text = "ID Zamówienia";
            // 
            // StatusOrderCombo
            // 
            this.StatusOrderCombo.FormattingEnabled = true;
            this.StatusOrderCombo.Items.AddRange(new object[] {
            "W drodze",
            "Zamknięte"});
            this.StatusOrderCombo.Location = new System.Drawing.Point(27, 235);
            this.StatusOrderCombo.Name = "StatusOrderCombo";
            this.StatusOrderCombo.Size = new System.Drawing.Size(141, 21);
            this.StatusOrderCombo.TabIndex = 14;
            this.StatusOrderCombo.SelectedIndexChanged += new System.EventHandler(this.StatusOrderCombo_SelectedIndexChanged);
            // 
            // UpdateOrderButton
            // 
            this.UpdateOrderButton.BackColor = System.Drawing.SystemColors.Desktop;
            this.UpdateOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateOrderButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.UpdateOrderButton.Location = new System.Drawing.Point(27, 262);
            this.UpdateOrderButton.Name = "UpdateOrderButton";
            this.UpdateOrderButton.Size = new System.Drawing.Size(141, 40);
            this.UpdateOrderButton.TabIndex = 15;
            this.UpdateOrderButton.Text = "Zaktualizuj";
            this.UpdateOrderButton.UseVisualStyleBackColor = false;
            this.UpdateOrderButton.Click += new System.EventHandler(this.UpdateOrderButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nexa Bold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = "Status Zamówienia";
            // 
            // CarrierOrdersUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 448);
            this.Controls.Add(this.UpdateOrderButton);
            this.Controls.Add(this.StatusOrderCombo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IDZamText);
            this.Controls.Add(this.IDZamField);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CarrierOrdersUC";
            this.Text = "CarrierOrdersUC";
            this.Load += new System.EventHandler(this.CarrierOrdersUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox IDZamField;
        private System.Windows.Forms.Label IDZamText;
        private System.Windows.Forms.ComboBox StatusOrderCombo;
        private System.Windows.Forms.Button UpdateOrderButton;
        private System.Windows.Forms.Label label2;
    }
}