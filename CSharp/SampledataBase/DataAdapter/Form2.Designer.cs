namespace DataAdapter
{
    partial class Form2
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
            this.btnCustomersAndOrders = new System.Windows.Forms.Button();
            this.gridviewCustomersAndOrders = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCountries = new System.Windows.Forms.ComboBox();
            this.btnProdCategories = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnLink = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewCustomersAndOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCustomersAndOrders
            // 
            this.btnCustomersAndOrders.Location = new System.Drawing.Point(243, 79);
            this.btnCustomersAndOrders.Name = "btnCustomersAndOrders";
            this.btnCustomersAndOrders.Size = new System.Drawing.Size(281, 23);
            this.btnCustomersAndOrders.TabIndex = 0;
            this.btnCustomersAndOrders.Text = "Cutomers And Orders";
            this.btnCustomersAndOrders.UseVisualStyleBackColor = true;
            this.btnCustomersAndOrders.Click += new System.EventHandler(this.btnCustomersAndOrders_Click);
            // 
            // gridviewCustomersAndOrders
            // 
            this.gridviewCustomersAndOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridviewCustomersAndOrders.Location = new System.Drawing.Point(103, 138);
            this.gridviewCustomersAndOrders.Name = "gridviewCustomersAndOrders";
            this.gridviewCustomersAndOrders.Size = new System.Drawing.Size(785, 194);
            this.gridviewCustomersAndOrders.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select Country";
            // 
            // cmbCountries
            // 
            this.cmbCountries.FormattingEnabled = true;
            this.cmbCountries.Location = new System.Drawing.Point(172, 17);
            this.cmbCountries.Name = "cmbCountries";
            this.cmbCountries.Size = new System.Drawing.Size(121, 21);
            this.cmbCountries.TabIndex = 3;
            this.cmbCountries.Text = "All Countries";
            this.cmbCountries.SelectedIndexChanged += new System.EventHandler(this.cmbCountries_SelectedIndexChanged);
            // 
            // btnProdCategories
            // 
            this.btnProdCategories.Location = new System.Drawing.Point(617, 79);
            this.btnProdCategories.Name = "btnProdCategories";
            this.btnProdCategories.Size = new System.Drawing.Size(222, 23);
            this.btnProdCategories.TabIndex = 4;
            this.btnProdCategories.Text = "Get Products";
            this.btnProdCategories.UseVisualStyleBackColor = true;
            this.btnProdCategories.Click += new System.EventHandler(this.btnProdCategories_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(538, 20);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(75, 23);
            this.btnOrder.TabIndex = 5;
            this.btnOrder.Text = "Total Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnLink
            // 
            this.btnLink.Location = new System.Drawing.Point(390, 12);
            this.btnLink.Name = "btnLink";
            this.btnLink.Size = new System.Drawing.Size(75, 23);
            this.btnLink.TabIndex = 6;
            this.btnLink.Text = "Join";
            this.btnLink.UseVisualStyleBackColor = true;
            this.btnLink.Click += new System.EventHandler(this.btnLink_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 357);
            this.Controls.Add(this.btnLink);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.btnProdCategories);
            this.Controls.Add(this.cmbCountries);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridviewCustomersAndOrders);
            this.Controls.Add(this.btnCustomersAndOrders);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridviewCustomersAndOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCustomersAndOrders;
        private System.Windows.Forms.DataGridView gridviewCustomersAndOrders;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCountries;
        private System.Windows.Forms.Button btnProdCategories;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnLink;
    }
}