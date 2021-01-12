namespace Magazyn_Spedycji.AdminControls
{
    partial class AdminOrdersUC
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
            this.DeleteOrder = new System.Windows.Forms.Button();
            this.editOrder = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.idorder = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.showmore = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(351, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(478, 481);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Wybierz zamówienie którym chcesz zarządzać";
            // 
            // DeleteOrder
            // 
            this.DeleteOrder.BackColor = System.Drawing.SystemColors.Desktop;
            this.DeleteOrder.FlatAppearance.BorderSize = 0;
            this.DeleteOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteOrder.Font = new System.Drawing.Font("Nexa Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteOrder.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.DeleteOrder.Location = new System.Drawing.Point(62, 284);
            this.DeleteOrder.Name = "DeleteOrder";
            this.DeleteOrder.Size = new System.Drawing.Size(210, 58);
            this.DeleteOrder.TabIndex = 2;
            this.DeleteOrder.Text = "Usuń zamówienie";
            this.DeleteOrder.UseVisualStyleBackColor = false;
            this.DeleteOrder.Click += new System.EventHandler(this.DeleteOrder_Click);
            // 
            // editOrder
            // 
            this.editOrder.BackColor = System.Drawing.SystemColors.Desktop;
            this.editOrder.FlatAppearance.BorderSize = 0;
            this.editOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editOrder.Font = new System.Drawing.Font("Nexa Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editOrder.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.editOrder.Location = new System.Drawing.Point(62, 156);
            this.editOrder.Name = "editOrder";
            this.editOrder.Size = new System.Drawing.Size(210, 58);
            this.editOrder.TabIndex = 2;
            this.editOrder.Text = "Edytuj status";
            this.editOrder.UseVisualStyleBackColor = false;
            this.editOrder.Click += new System.EventHandler(this.editOrder_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Opłacone",
            "W trakcie realizacji",
            "Wysłane",
            "Zakończone"});
            this.comboBox1.Location = new System.Drawing.Point(62, 119);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(210, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // idorder
            // 
            this.idorder.Location = new System.Drawing.Point(62, 80);
            this.idorder.Name = "idorder";
            this.idorder.Size = new System.Drawing.Size(100, 20);
            this.idorder.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Akcja:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "ID zamówienia:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nexa Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(282, 26);
            this.label4.TabIndex = 7;
            this.label4.Text = "Zarządzanie zamówieniami";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel1.Location = new System.Drawing.Point(326, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(19, 481);
            this.panel1.TabIndex = 8;
            // 
            // showmore
            // 
            this.showmore.BackColor = System.Drawing.SystemColors.Desktop;
            this.showmore.FlatAppearance.BorderSize = 0;
            this.showmore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showmore.Font = new System.Drawing.Font("Nexa Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showmore.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.showmore.Location = new System.Drawing.Point(62, 220);
            this.showmore.Name = "showmore";
            this.showmore.Size = new System.Drawing.Size(210, 58);
            this.showmore.TabIndex = 2;
            this.showmore.Text = "Wyświetl szczegóły";
            this.showmore.UseVisualStyleBackColor = false;
            this.showmore.Click += new System.EventHandler(this.showmore_Click);
            // 
            // AdminOrdersUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(853, 505);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.idorder);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.editOrder);
            this.Controls.Add(this.showmore);
            this.Controls.Add(this.DeleteOrder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AdminOrdersUC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zarządzanie zamówieniami";
            this.Load += new System.EventHandler(this.AdminOrdersUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DeleteOrder;
        private System.Windows.Forms.Button editOrder;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox idorder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button showmore;
    }
}