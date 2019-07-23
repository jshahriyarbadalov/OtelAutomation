namespace OtelAutomation.WinFormUI
{
    partial class SaleForm
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
            this.cmbCustomer = new System.Windows.Forms.ComboBox();
            this.cmbRoom = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numRoomPrice = new System.Windows.Forms.NumericUpDown();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.numProdUnit = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numProdPrice = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numDiscount = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSaleAdd = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numRoomPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numProdUnit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numProdPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDiscount)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer:";
            // 
            // cmbCustomer
            // 
            this.cmbCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCustomer.FormattingEnabled = true;
            this.cmbCustomer.Location = new System.Drawing.Point(16, 43);
            this.cmbCustomer.Name = "cmbCustomer";
            this.cmbCustomer.Size = new System.Drawing.Size(139, 24);
            this.cmbCustomer.TabIndex = 1;
            // 
            // cmbRoom
            // 
            this.cmbRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRoom.FormattingEnabled = true;
            this.cmbRoom.Location = new System.Drawing.Point(173, 43);
            this.cmbRoom.Name = "cmbRoom";
            this.cmbRoom.Size = new System.Drawing.Size(139, 24);
            this.cmbRoom.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Room";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(333, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Room Price:";
            // 
            // numRoomPrice
            // 
            this.numRoomPrice.Location = new System.Drawing.Point(336, 44);
            this.numRoomPrice.Name = "numRoomPrice";
            this.numRoomPrice.Size = new System.Drawing.Size(120, 22);
            this.numRoomPrice.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(440, 350);
            this.dataGridView1.TabIndex = 6;
            // 
            // numProdUnit
            // 
            this.numProdUnit.Location = new System.Drawing.Point(481, 131);
            this.numProdUnit.Name = "numProdUnit";
            this.numProdUnit.Size = new System.Drawing.Size(140, 22);
            this.numProdUnit.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(478, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Product Quantity:";
            // 
            // numProdPrice
            // 
            this.numProdPrice.Location = new System.Drawing.Point(481, 189);
            this.numProdPrice.Name = "numProdPrice";
            this.numProdPrice.Size = new System.Drawing.Size(140, 22);
            this.numProdPrice.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(478, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Product Price:";
            // 
            // numDiscount
            // 
            this.numDiscount.Location = new System.Drawing.Point(481, 245);
            this.numDiscount.Name = "numDiscount";
            this.numDiscount.Size = new System.Drawing.Size(140, 22);
            this.numDiscount.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(478, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Discount:";
            // 
            // btnSaleAdd
            // 
            this.btnSaleAdd.Location = new System.Drawing.Point(515, 296);
            this.btnSaleAdd.Name = "btnSaleAdd";
            this.btnSaleAdd.Size = new System.Drawing.Size(75, 23);
            this.btnSaleAdd.TabIndex = 13;
            this.btnSaleAdd.Text = "Sale Add";
            this.btnSaleAdd.UseVisualStyleBackColor = true;
            this.btnSaleAdd.Click += new System.EventHandler(this.btnSaleAdd_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(637, 88);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(383, 321);
            this.listView1.TabIndex = 14;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Row No:";
            this.columnHeader1.Width = 68;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Product Name:";
            this.columnHeader2.Width = 106;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Quantity:";
            this.columnHeader3.Width = 73;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Price:";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Discount:";
            this.columnHeader5.Width = 74;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(819, 415);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // SaleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 462);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnSaleAdd);
            this.Controls.Add(this.numDiscount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numProdPrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numProdUnit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.numRoomPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbRoom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbCustomer);
            this.Controls.Add(this.label1);
            this.Name = "SaleForm";
            this.Text = "SaleForm";
            this.Load += new System.EventHandler(this.SaleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numRoomPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numProdUnit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numProdPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDiscount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCustomer;
        private System.Windows.Forms.ComboBox cmbRoom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numRoomPrice;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.NumericUpDown numProdUnit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numProdPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numDiscount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSaleAdd;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}