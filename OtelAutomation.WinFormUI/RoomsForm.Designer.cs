namespace OtelAutomation.WinFormUI
{
    partial class RoomsForm
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRooms = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmbRoomTur = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numCapacity = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numCardN = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCapacity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCardN)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Room Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(15, 29);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(161, 22);
            this.txtName.TabIndex = 1;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(195, 29);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(229, 76);
            this.txtDescription.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(192, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Description:";
            // 
            // btnRooms
            // 
            this.btnRooms.Location = new System.Drawing.Point(442, 29);
            this.btnRooms.Name = "btnRooms";
            this.btnRooms.Size = new System.Drawing.Size(75, 23);
            this.btnRooms.TabIndex = 4;
            this.btnRooms.Text = "ADD";
            this.btnRooms.UseVisualStyleBackColor = true;
            this.btnRooms.Click += new System.EventHandler(this.btnRooms_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 185);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(518, 253);
            this.dataGridView1.TabIndex = 5;
            // 
            // cmbRoomTur
            // 
            this.cmbRoomTur.FormattingEnabled = true;
            this.cmbRoomTur.Location = new System.Drawing.Point(192, 139);
            this.cmbRoomTur.Name = "cmbRoomTur";
            this.cmbRoomTur.Size = new System.Drawing.Size(158, 24);
            this.cmbRoomTur.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(192, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "RoomTur:";
            // 
            // numCapacity
            // 
            this.numCapacity.Location = new System.Drawing.Point(15, 89);
            this.numCapacity.Name = "numCapacity";
            this.numCapacity.Size = new System.Drawing.Size(155, 22);
            this.numCapacity.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Room Capacity:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Room CardNo:";
            // 
            // numCardN
            // 
            this.numCardN.Location = new System.Drawing.Point(15, 139);
            this.numCardN.Name = "numCardN";
            this.numCardN.Size = new System.Drawing.Size(155, 22);
            this.numCardN.TabIndex = 10;
            // 
            // RoomsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numCardN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numCapacity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbRoomTur);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnRooms);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Name = "RoomsForm";
            this.Text = "RoomsForm";
            this.Load += new System.EventHandler(this.RoomsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCapacity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCardN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRooms;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmbRoomTur;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numCapacity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numCardN;
    }
}