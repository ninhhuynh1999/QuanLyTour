namespace QuanLyDuLich.View
{
    partial class DanhSachNguoi
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.txSearchKhach = new System.Windows.Forms.TextBox();
            this.cbSearchKhach = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btThemKH = new System.Windows.Forms.Button();
            this.btXoaKH = new System.Windows.Forms.Button();
            this.btSuaKH = new System.Windows.Forms.Button();
            this.dgvDSKhach = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.txSearchNV = new System.Windows.Forms.TextBox();
            this.cbSearchNhanVien = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btThemNV = new System.Windows.Forms.Button();
            this.btXoaNV = new System.Windows.Forms.Button();
            this.btSuaNV = new System.Windows.Forms.Button();
            this.dgvDSNhanVien = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSKhach)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(204, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý khách và nhân viên";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(4, 54);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(658, 654);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.txSearchKhach);
            this.tabPage1.Controls.Add(this.cbSearchKhach);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.btThemKH);
            this.tabPage1.Controls.Add(this.btXoaKH);
            this.tabPage1.Controls.Add(this.btSuaKH);
            this.tabPage1.Controls.Add(this.dgvDSKhach);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(650, 623);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Khách hàng";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(560, 210);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 57);
            this.button2.TabIndex = 18;
            this.button2.Text = "Xem chi tiết";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txSearchKhach
            // 
            this.txSearchKhach.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txSearchKhach.Location = new System.Drawing.Point(234, 241);
            this.txSearchKhach.MaxLength = 55;
            this.txSearchKhach.Name = "txSearchKhach";
            this.txSearchKhach.Size = new System.Drawing.Size(295, 27);
            this.txSearchKhach.TabIndex = 17;
            this.txSearchKhach.TextChanged += new System.EventHandler(this.txSearchKhach_TextChanged);
            // 
            // cbSearchKhach
            // 
            this.cbSearchKhach.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSearchKhach.FormattingEnabled = true;
            this.cbSearchKhach.Location = new System.Drawing.Point(92, 241);
            this.cbSearchKhach.Name = "cbSearchKhach";
            this.cbSearchKhach.Size = new System.Drawing.Size(136, 27);
            this.cbSearchKhach.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 19);
            this.label5.TabIndex = 15;
            this.label5.Text = "Tìm kiếm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(228, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Danh sách Khách hàng";
            // 
            // btThemKH
            // 
            this.btThemKH.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThemKH.Location = new System.Drawing.Point(560, 135);
            this.btThemKH.Name = "btThemKH";
            this.btThemKH.Size = new System.Drawing.Size(84, 29);
            this.btThemKH.TabIndex = 4;
            this.btThemKH.Text = "Thêm";
            this.btThemKH.UseVisualStyleBackColor = true;
            this.btThemKH.Click += new System.EventHandler(this.btThemKH_Click);
            // 
            // btXoaKH
            // 
            this.btXoaKH.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoaKH.Location = new System.Drawing.Point(560, 175);
            this.btXoaKH.Name = "btXoaKH";
            this.btXoaKH.Size = new System.Drawing.Size(84, 29);
            this.btXoaKH.TabIndex = 3;
            this.btXoaKH.Text = "Xóa";
            this.btXoaKH.UseVisualStyleBackColor = true;
            // 
            // btSuaKH
            // 
            this.btSuaKH.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSuaKH.Location = new System.Drawing.Point(560, 100);
            this.btSuaKH.Name = "btSuaKH";
            this.btSuaKH.Size = new System.Drawing.Size(84, 29);
            this.btSuaKH.TabIndex = 2;
            this.btSuaKH.Text = "Sửa";
            this.btSuaKH.UseVisualStyleBackColor = true;
            this.btSuaKH.Click += new System.EventHandler(this.btSuaKH_Click);
            // 
            // dgvDSKhach
            // 
            this.dgvDSKhach.AllowUserToAddRows = false;
            this.dgvDSKhach.AllowUserToDeleteRows = false;
            this.dgvDSKhach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSKhach.Location = new System.Drawing.Point(6, 274);
            this.dgvDSKhach.MultiSelect = false;
            this.dgvDSKhach.Name = "dgvDSKhach";
            this.dgvDSKhach.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.NullValue = "null";
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDSKhach.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvDSKhach.RowHeadersWidth = 51;
            this.dgvDSKhach.RowTemplate.Height = 24;
            this.dgvDSKhach.RowTemplate.ReadOnly = true;
            this.dgvDSKhach.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDSKhach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSKhach.Size = new System.Drawing.Size(638, 343);
            this.dgvDSKhach.TabIndex = 0;
            this.dgvDSKhach.SelectionChanged += new System.EventHandler(this.dgvDSKhach_SelectionChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.txSearchNV);
            this.tabPage2.Controls.Add(this.cbSearchNhanVien);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.btThemNV);
            this.tabPage2.Controls.Add(this.btXoaNV);
            this.tabPage2.Controls.Add(this.btSuaNV);
            this.tabPage2.Controls.Add(this.dgvDSNhanVien);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(650, 623);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Nhân viên";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(560, 210);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 57);
            this.button1.TabIndex = 15;
            this.button1.Text = "Xem chi tiết";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txSearchNV
            // 
            this.txSearchNV.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txSearchNV.Location = new System.Drawing.Point(234, 241);
            this.txSearchNV.MaxLength = 55;
            this.txSearchNV.Name = "txSearchNV";
            this.txSearchNV.Size = new System.Drawing.Size(295, 27);
            this.txSearchNV.TabIndex = 14;
            this.txSearchNV.TextChanged += new System.EventHandler(this.txSearchNV_TextChanged);
            // 
            // cbSearchNhanVien
            // 
            this.cbSearchNhanVien.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSearchNhanVien.FormattingEnabled = true;
            this.cbSearchNhanVien.Location = new System.Drawing.Point(92, 241);
            this.cbSearchNhanVien.Name = "cbSearchNhanVien";
            this.cbSearchNhanVien.Size = new System.Drawing.Size(136, 27);
            this.cbSearchNhanVien.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 19);
            this.label4.TabIndex = 12;
            this.label4.Text = "Tìm kiếm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(230, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 22);
            this.label3.TabIndex = 11;
            this.label3.Text = "Danh sách Nhân Viên";
            // 
            // btThemNV
            // 
            this.btThemNV.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThemNV.Location = new System.Drawing.Point(560, 138);
            this.btThemNV.Name = "btThemNV";
            this.btThemNV.Size = new System.Drawing.Size(84, 30);
            this.btThemNV.TabIndex = 10;
            this.btThemNV.Text = "Thêm";
            this.btThemNV.UseVisualStyleBackColor = true;
            this.btThemNV.Click += new System.EventHandler(this.btThemNV_Click);
            // 
            // btXoaNV
            // 
            this.btXoaNV.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoaNV.Location = new System.Drawing.Point(560, 174);
            this.btXoaNV.Name = "btXoaNV";
            this.btXoaNV.Size = new System.Drawing.Size(84, 30);
            this.btXoaNV.TabIndex = 9;
            this.btXoaNV.Text = "Xóa";
            this.btXoaNV.UseVisualStyleBackColor = true;
            // 
            // btSuaNV
            // 
            this.btSuaNV.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSuaNV.Location = new System.Drawing.Point(560, 102);
            this.btSuaNV.Name = "btSuaNV";
            this.btSuaNV.Size = new System.Drawing.Size(84, 30);
            this.btSuaNV.TabIndex = 8;
            this.btSuaNV.Text = "Sửa";
            this.btSuaNV.UseVisualStyleBackColor = true;
            this.btSuaNV.Click += new System.EventHandler(this.btSuaNV_Click);
            // 
            // dgvDSNhanVien
            // 
            this.dgvDSNhanVien.AllowUserToAddRows = false;
            this.dgvDSNhanVien.AllowUserToDeleteRows = false;
            this.dgvDSNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDSNhanVien.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDSNhanVien.ColumnHeadersHeight = 29;
            this.dgvDSNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.NullValue = "null";
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDSNhanVien.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDSNhanVien.Location = new System.Drawing.Point(6, 274);
            this.dgvDSNhanVien.MultiSelect = false;
            this.dgvDSNhanVien.Name = "dgvDSNhanVien";
            this.dgvDSNhanVien.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.NullValue = "null";
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDSNhanVien.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDSNhanVien.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvDSNhanVien.RowTemplate.Height = 24;
            this.dgvDSNhanVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSNhanVien.Size = new System.Drawing.Size(638, 343);
            this.dgvDSNhanVien.TabIndex = 7;
            this.dgvDSNhanVien.SelectionChanged += new System.EventHandler(this.dgvDSNhanVien_SelectionChanged);
            // 
            // DanhSachNguoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(665, 714);
            this.Name = "DanhSachNguoi";
            this.Size = new System.Drawing.Size(665, 714);
            this.Load += new System.EventHandler(this.DanhSachNguoi_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSKhach)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSNhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvDSKhach;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btThemKH;
        private System.Windows.Forms.Button btXoaKH;
        private System.Windows.Forms.Button btSuaKH;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txSearchKhach;
        private System.Windows.Forms.ComboBox cbSearchKhach;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txSearchNV;
        private System.Windows.Forms.ComboBox cbSearchNhanVien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btThemNV;
        private System.Windows.Forms.Button btXoaNV;
        private System.Windows.Forms.Button btSuaNV;
        private System.Windows.Forms.DataGridView dgvDSNhanVien;
    }
}
