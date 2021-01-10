namespace Magazyn_Spedycji.USerControls
{
    partial class ShopUC
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
            this.Amount = new System.Windows.Forms.TextBox();
            this.ProdutsCode = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.showcart = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.searchBar = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.CreateOrder = new System.Windows.Forms.Button();
            this.ToCart = new System.Windows.Forms.Button();
            this.backtoshop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(251, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(494, 399);
            this.dataGridView1.TabIndex = 0;
            // 
            // Amount
            // 
            this.Amount.Location = new System.Drawing.Point(117, 53);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(100, 20);
            this.Amount.TabIndex = 43;
            // 
            // ProdutsCode
            // 
            this.ProdutsCode.Location = new System.Drawing.Point(117, 29);
            this.ProdutsCode.Name = "ProdutsCode";
            this.ProdutsCode.Size = new System.Drawing.Size(100, 20);
            this.ProdutsCode.TabIndex = 42;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(35, 32);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(75, 13);
            this.label14.TabIndex = 51;
            this.label14.Text = "Kod Produktu:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(78, 54);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(32, 13);
            this.label13.TabIndex = 50;
            this.label13.Text = "Ilość:";
            // 
            // showcart
            // 
            this.showcart.BackColor = System.Drawing.SystemColors.Desktop;
            this.showcart.FlatAppearance.BorderSize = 0;
            this.showcart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showcart.Font = new System.Drawing.Font("Nexa Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showcart.ForeColor = System.Drawing.SystemColors.Control;
            this.showcart.Location = new System.Drawing.Point(10, 150);
            this.showcart.Name = "showcart";
            this.showcart.Size = new System.Drawing.Size(206, 57);
            this.showcart.TabIndex = 47;
            this.showcart.Text = "Wyświetl koszyk";
            this.showcart.UseVisualStyleBackColor = false;
            this.showcart.Click += new System.EventHandler(this.showcart_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel1.Location = new System.Drawing.Point(230, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(15, 396);
            this.panel1.TabIndex = 52;
            // 
            // searchBar
            // 
            this.searchBar.BackColor = System.Drawing.SystemColors.Desktop;
            this.searchBar.ForeColor = System.Drawing.SystemColors.Window;
            this.searchBar.Location = new System.Drawing.Point(251, 3);
            this.searchBar.Name = "searchBar";
            this.searchBar.Size = new System.Drawing.Size(459, 20);
            this.searchBar.TabIndex = 53;
            this.searchBar.TextChanged += new System.EventHandler(this.searchBar_TextChanged);
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.SystemColors.Desktop;
            this.SearchButton.FlatAppearance.BorderSize = 0;
            this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchButton.Image = global::Magazyn_Spedycji.Properties.Resources.searchicon;
            this.SearchButton.Location = new System.Drawing.Point(716, -2);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(29, 31);
            this.SearchButton.TabIndex = 54;
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // CreateOrder
            // 
            this.CreateOrder.BackColor = System.Drawing.SystemColors.Desktop;
            this.CreateOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateOrder.Font = new System.Drawing.Font("Nexa Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateOrder.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CreateOrder.Image = global::Magazyn_Spedycji.Properties.Resources.checkout;
            this.CreateOrder.Location = new System.Drawing.Point(10, 213);
            this.CreateOrder.Name = "CreateOrder";
            this.CreateOrder.Size = new System.Drawing.Size(206, 63);
            this.CreateOrder.TabIndex = 48;
            this.CreateOrder.Text = "Złóż Zamówienie";
            this.CreateOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CreateOrder.UseVisualStyleBackColor = false;
            this.CreateOrder.Click += new System.EventHandler(this.CreateOrder_Click);
            // 
            // ToCart
            // 
            this.ToCart.BackColor = System.Drawing.SystemColors.Desktop;
            this.ToCart.FlatAppearance.BorderSize = 0;
            this.ToCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ToCart.Font = new System.Drawing.Font("Nexa Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToCart.ForeColor = System.Drawing.SystemColors.Control;
            this.ToCart.Image = global::Magazyn_Spedycji.Properties.Resources.cart;
            this.ToCart.Location = new System.Drawing.Point(10, 87);
            this.ToCart.Name = "ToCart";
            this.ToCart.Size = new System.Drawing.Size(206, 57);
            this.ToCart.TabIndex = 46;
            this.ToCart.Text = "Dodaj do koszyka";
            this.ToCart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ToCart.UseVisualStyleBackColor = false;
            this.ToCart.Click += new System.EventHandler(this.ToCart_Click);
            // 
            // backtoshop
            // 
            this.backtoshop.BackColor = System.Drawing.SystemColors.Desktop;
            this.backtoshop.FlatAppearance.BorderSize = 0;
            this.backtoshop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backtoshop.Font = new System.Drawing.Font("Nexa Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backtoshop.ForeColor = System.Drawing.SystemColors.Control;
            this.backtoshop.Location = new System.Drawing.Point(10, 282);
            this.backtoshop.Name = "backtoshop";
            this.backtoshop.Size = new System.Drawing.Size(206, 43);
            this.backtoshop.TabIndex = 47;
            this.backtoshop.Text = "Wróć do sklepu";
            this.backtoshop.UseVisualStyleBackColor = false;
            this.backtoshop.Click += new System.EventHandler(this.backtoshop_Click);
            // 
            // ShopUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(757, 440);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.searchBar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.CreateOrder);
            this.Controls.Add(this.backtoshop);
            this.Controls.Add(this.showcart);
            this.Controls.Add(this.ToCart);
            this.Controls.Add(this.Amount);
            this.Controls.Add(this.ProdutsCode);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ShopUC";
            this.Text = "ShopUC";
            this.Load += new System.EventHandler(this.ShopUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox Amount;
        private System.Windows.Forms.TextBox ProdutsCode;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button CreateOrder;
        private System.Windows.Forms.Button showcart;
        private System.Windows.Forms.Button ToCart;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox searchBar;
        private System.Windows.Forms.Button backtoshop;
    }
}