namespace PRN292_Nhom4_PH1
{
    partial class MonHoc
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtMonHoc = new System.Windows.Forms.DataGridView();
            this.grbIDMH = new System.Windows.Forms.GroupBox();
            this.txtIDMH = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbbHK = new System.Windows.Forms.ComboBox();
            this.txtTenMH = new System.Windows.Forms.TextBox();
            this.grbTenMH = new System.Windows.Forms.GroupBox();
            this.grbSoTc = new System.Windows.Forms.GroupBox();
            this.numberUDSOTC = new System.Windows.Forms.NumericUpDown();
            this.checkbLythuyet = new System.Windows.Forms.CheckBox();
            this.checkbThucHanh = new System.Windows.Forms.CheckBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtMonHoc)).BeginInit();
            this.grbIDMH.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grbTenMH.SuspendLayout();
            this.grbSoTc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberUDSOTC)).BeginInit();
            this.SuspendLayout();
            // 
            // dtMonHoc
            // 
            this.dtMonHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtMonHoc.Location = new System.Drawing.Point(10, 9);
            this.dtMonHoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtMonHoc.Name = "dtMonHoc";
            this.dtMonHoc.RowHeadersWidth = 51;
            this.dtMonHoc.Size = new System.Drawing.Size(439, 290);
            this.dtMonHoc.TabIndex = 0;
            this.dtMonHoc.Text = "dataGridView1";
            this.dtMonHoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtMonHoc_CellClick);
            // 
            // grbIDMH
            // 
            this.grbIDMH.Controls.Add(this.txtIDMH);
            this.grbIDMH.Location = new System.Drawing.Point(470, 9);
            this.grbIDMH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbIDMH.Name = "grbIDMH";
            this.grbIDMH.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbIDMH.Size = new System.Drawing.Size(219, 52);
            this.grbIDMH.TabIndex = 1;
            this.grbIDMH.TabStop = false;
            this.grbIDMH.Text = "IDMH";
            // 
            // txtIDMH
            // 
            this.txtIDMH.Location = new System.Drawing.Point(6, 20);
            this.txtIDMH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIDMH.Name = "txtIDMH";
            this.txtIDMH.Size = new System.Drawing.Size(208, 23);
            this.txtIDMH.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbbHK);
            this.groupBox2.Location = new System.Drawing.Point(470, 80);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(219, 52);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ma_HK";
            // 
            // cbbHK
            // 
            this.cbbHK.FormattingEnabled = true;
            this.cbbHK.Location = new System.Drawing.Point(6, 20);
            this.cbbHK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbHK.Name = "cbbHK";
            this.cbbHK.Size = new System.Drawing.Size(208, 23);
            this.cbbHK.TabIndex = 0;
            // 
            // txtTenMH
            // 
            this.txtTenMH.Location = new System.Drawing.Point(6, 20);
            this.txtTenMH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenMH.Name = "txtTenMH";
            this.txtTenMH.Size = new System.Drawing.Size(208, 23);
            this.txtTenMH.TabIndex = 0;
            // 
            // grbTenMH
            // 
            this.grbTenMH.Controls.Add(this.txtTenMH);
            this.grbTenMH.Location = new System.Drawing.Point(470, 153);
            this.grbTenMH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbTenMH.Name = "grbTenMH";
            this.grbTenMH.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbTenMH.Size = new System.Drawing.Size(219, 52);
            this.grbTenMH.TabIndex = 1;
            this.grbTenMH.TabStop = false;
            this.grbTenMH.Text = "Ten_MH";
            // 
            // grbSoTc
            // 
            this.grbSoTc.Controls.Add(this.numberUDSOTC);
            this.grbSoTc.Location = new System.Drawing.Point(470, 230);
            this.grbSoTc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbSoTc.Name = "grbSoTc";
            this.grbSoTc.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbSoTc.Size = new System.Drawing.Size(219, 52);
            this.grbSoTc.TabIndex = 1;
            this.grbSoTc.TabStop = false;
            this.grbSoTc.Text = "So_TC";
            // 
            // numberUDSOTC
            // 
            this.numberUDSOTC.Location = new System.Drawing.Point(6, 20);
            this.numberUDSOTC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numberUDSOTC.Name = "numberUDSOTC";
            this.numberUDSOTC.Size = new System.Drawing.Size(207, 23);
            this.numberUDSOTC.TabIndex = 0;
            // 
            // checkbLythuyet
            // 
            this.checkbLythuyet.AutoSize = true;
            this.checkbLythuyet.Location = new System.Drawing.Point(476, 313);
            this.checkbLythuyet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkbLythuyet.Name = "checkbLythuyet";
            this.checkbLythuyet.Size = new System.Drawing.Size(73, 19);
            this.checkbLythuyet.TabIndex = 2;
            this.checkbLythuyet.Text = "LyThuyet";
            this.checkbLythuyet.UseVisualStyleBackColor = true;
            // 
            // checkbThucHanh
            // 
            this.checkbThucHanh.AutoSize = true;
            this.checkbThucHanh.Location = new System.Drawing.Point(598, 313);
            this.checkbThucHanh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkbThucHanh.Name = "checkbThucHanh";
            this.checkbThucHanh.Size = new System.Drawing.Size(81, 19);
            this.checkbThucHanh.TabIndex = 3;
            this.checkbThucHanh.Text = "ThucHanh";
            this.checkbThucHanh.UseVisualStyleBackColor = true;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(32, 308);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(82, 22);
            this.btnInsert.TabIndex = 4;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(167, 308);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(82, 22);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(312, 308);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(82, 22);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseMnemonic = false;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // MonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 340);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.checkbThucHanh);
            this.Controls.Add(this.checkbLythuyet);
            this.Controls.Add(this.grbSoTc);
            this.Controls.Add(this.grbTenMH);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grbIDMH);
            this.Controls.Add(this.dtMonHoc);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MonHoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMonHoc";
            ((System.ComponentModel.ISupportInitialize)(this.dtMonHoc)).EndInit();
            this.grbIDMH.ResumeLayout(false);
            this.grbIDMH.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.grbTenMH.ResumeLayout(false);
            this.grbTenMH.PerformLayout();
            this.grbSoTc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numberUDSOTC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtMonHoc;
        private System.Windows.Forms.GroupBox grbIDMH;
        private System.Windows.Forms.TextBox txtIDMH;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtTenMH;
        private System.Windows.Forms.GroupBox grbTenMH;
        private System.Windows.Forms.GroupBox grbSoTc;
        private System.Windows.Forms.NumericUpDown numberUDSOTC;
        private System.Windows.Forms.CheckBox checkbLythuyet;
        private System.Windows.Forms.CheckBox checkbThucHanh;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox cbbHK;
    }
}

