namespace OtelAutomation.WinFormUI
{
    partial class RoomSpecificationForm
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
            this.cmbRooms = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listSpecification = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Room";
            // 
            // cmbRooms
            // 
            this.cmbRooms.FormattingEnabled = true;
            this.cmbRooms.Location = new System.Drawing.Point(12, 28);
            this.cmbRooms.Name = "cmbRooms";
            this.cmbRooms.Size = new System.Drawing.Size(156, 24);
            this.cmbRooms.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Specification";
            // 
            // listSpecification
            // 
            this.listSpecification.FormattingEnabled = true;
            this.listSpecification.ItemHeight = 16;
            this.listSpecification.Location = new System.Drawing.Point(191, 28);
            this.listSpecification.Name = "listSpecification";
            this.listSpecification.Size = new System.Drawing.Size(195, 292);
            this.listSpecification.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(405, 66);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(121, 34);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(402, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Value:";
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(405, 29);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(121, 22);
            this.txtValue.TabIndex = 6;
            // 
            // RoomSpecificationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 336);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.listSpecification);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbRooms);
            this.Controls.Add(this.label1);
            this.Name = "RoomSpecificationForm";
            this.Text = "RoomSpecificationForm";
            this.Load += new System.EventHandler(this.RoomSpecificationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbRooms;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listSpecification;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtValue;
    }
}