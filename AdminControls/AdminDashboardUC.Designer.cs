namespace Magazyn_Spedycji.AdminControls
{
    partial class AdminDashboardUC
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Orders = new System.Windows.Forms.Button();
            this.ProductsControl = new System.Windows.Forms.Button();
            this.CarrierControl = new System.Windows.Forms.Button();
            this.Pracownicy = new System.Windows.Forms.Button();
            this.DataControl = new System.Windows.Forms.Button();
            this.UserControl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nexa Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(322, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Witaj, Admin!";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel1.Location = new System.Drawing.Point(265, 113);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(21, 282);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel2.Location = new System.Drawing.Point(499, 113);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(21, 282);
            this.panel2.TabIndex = 2;
            // 
            // Orders
            // 
            this.Orders.BackColor = System.Drawing.SystemColors.Desktop;
            this.Orders.FlatAppearance.BorderSize = 0;
            this.Orders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Orders.Font = new System.Drawing.Font("Nexa Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Orders.ForeColor = System.Drawing.SystemColors.Control;
            this.Orders.Image = global::Magazyn_Spedycji.Properties.Resources.ordersControl;
            this.Orders.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Orders.Location = new System.Drawing.Point(562, 113);
            this.Orders.Name = "Orders";
            this.Orders.Size = new System.Drawing.Size(127, 113);
            this.Orders.TabIndex = 1;
            this.Orders.Text = "Zamówienia";
            this.Orders.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Orders.UseVisualStyleBackColor = false;
            this.Orders.Click += new System.EventHandler(this.Orders_Click);
            // 
            // ProductsControl
            // 
            this.ProductsControl.BackColor = System.Drawing.SystemColors.Desktop;
            this.ProductsControl.FlatAppearance.BorderSize = 0;
            this.ProductsControl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProductsControl.Font = new System.Drawing.Font("Nexa Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductsControl.ForeColor = System.Drawing.SystemColors.Control;
            this.ProductsControl.Image = global::Magazyn_Spedycji.Properties.Resources.ProductControl;
            this.ProductsControl.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ProductsControl.Location = new System.Drawing.Point(324, 113);
            this.ProductsControl.Name = "ProductsControl";
            this.ProductsControl.Size = new System.Drawing.Size(127, 113);
            this.ProductsControl.TabIndex = 1;
            this.ProductsControl.Text = "Produkty";
            this.ProductsControl.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ProductsControl.UseVisualStyleBackColor = false;
            this.ProductsControl.Click += new System.EventHandler(this.ProductsControl_Click);
            // 
            // CarrierControl
            // 
            this.CarrierControl.BackColor = System.Drawing.SystemColors.Desktop;
            this.CarrierControl.FlatAppearance.BorderSize = 0;
            this.CarrierControl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CarrierControl.Font = new System.Drawing.Font("Nexa Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CarrierControl.ForeColor = System.Drawing.SystemColors.Control;
            this.CarrierControl.Image = global::Magazyn_Spedycji.Properties.Resources.CarriersControl;
            this.CarrierControl.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CarrierControl.Location = new System.Drawing.Point(99, 282);
            this.CarrierControl.Name = "CarrierControl";
            this.CarrierControl.Size = new System.Drawing.Size(127, 113);
            this.CarrierControl.TabIndex = 1;
            this.CarrierControl.Text = "Spedytorzy";
            this.CarrierControl.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.CarrierControl.UseVisualStyleBackColor = false;
            this.CarrierControl.Click += new System.EventHandler(this.CarrierControl_Click);
            // 
            // Pracownicy
            // 
            this.Pracownicy.BackColor = System.Drawing.SystemColors.Desktop;
            this.Pracownicy.FlatAppearance.BorderSize = 0;
            this.Pracownicy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Pracownicy.Font = new System.Drawing.Font("Nexa Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pracownicy.ForeColor = System.Drawing.SystemColors.Control;
            this.Pracownicy.Image = global::Magazyn_Spedycji.Properties.Resources.workersControl;
            this.Pracownicy.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Pracownicy.Location = new System.Drawing.Point(324, 282);
            this.Pracownicy.Name = "Pracownicy";
            this.Pracownicy.Size = new System.Drawing.Size(127, 113);
            this.Pracownicy.TabIndex = 1;
            this.Pracownicy.Text = "Pracownicy";
            this.Pracownicy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Pracownicy.UseVisualStyleBackColor = false;
            this.Pracownicy.Click += new System.EventHandler(this.Pracownicy_Click);
            // 
            // DataControl
            // 
            this.DataControl.BackColor = System.Drawing.SystemColors.Desktop;
            this.DataControl.FlatAppearance.BorderSize = 0;
            this.DataControl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DataControl.Font = new System.Drawing.Font("Nexa Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataControl.ForeColor = System.Drawing.SystemColors.Control;
            this.DataControl.Image = global::Magazyn_Spedycji.Properties.Resources.edit1;
            this.DataControl.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.DataControl.Location = new System.Drawing.Point(562, 282);
            this.DataControl.Name = "DataControl";
            this.DataControl.Size = new System.Drawing.Size(127, 113);
            this.DataControl.TabIndex = 1;
            this.DataControl.Text = "Moje Dane";
            this.DataControl.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.DataControl.UseVisualStyleBackColor = false;
            this.DataControl.Click += new System.EventHandler(this.DataControl_Click);
            // 
            // UserControl
            // 
            this.UserControl.BackColor = System.Drawing.SystemColors.Desktop;
            this.UserControl.FlatAppearance.BorderSize = 0;
            this.UserControl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UserControl.Font = new System.Drawing.Font("Nexa Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserControl.ForeColor = System.Drawing.SystemColors.Control;
            this.UserControl.Image = global::Magazyn_Spedycji.Properties.Resources.usersControl;
            this.UserControl.Location = new System.Drawing.Point(99, 113);
            this.UserControl.Name = "UserControl";
            this.UserControl.Size = new System.Drawing.Size(127, 113);
            this.UserControl.TabIndex = 1;
            this.UserControl.Text = "Użytkownicy";
            this.UserControl.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.UserControl.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.UserControl.UseVisualStyleBackColor = false;
            this.UserControl.Click += new System.EventHandler(this.UserControl_Click);
            // 
            // AdminDashboardUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 474);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Orders);
            this.Controls.Add(this.ProductsControl);
            this.Controls.Add(this.CarrierControl);
            this.Controls.Add(this.Pracownicy);
            this.Controls.Add(this.DataControl);
            this.Controls.Add(this.UserControl);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminDashboardUC";
            this.Text = "AdminDashboardUC";
            this.Load += new System.EventHandler(this.AdminDashboardUC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button UserControl;
        private System.Windows.Forms.Button ProductsControl;
        private System.Windows.Forms.Button Orders;
        private System.Windows.Forms.Button CarrierControl;
        private System.Windows.Forms.Button DataControl;
        private System.Windows.Forms.Button Pracownicy;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}