using System.Data;
using System.Linq;

namespace QuanLyDuLich.View
{
    partial class frChiTietTour
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
            this.pnThongTin = new System.Windows.Forms.Panel();
            this.btReset = new System.Windows.Forms.Button();
            this.cbLoaiTour = new System.Windows.Forms.ComboBox();
            this.btThemTour = new System.Windows.Forms.Button();
            this.txTenTour = new System.Windows.Forms.TextBox();
            this.txId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btHuyDD = new System.Windows.Forms.Button();
            this.btLuuDD = new System.Windows.Forms.Button();
            this.listBoxPhai = new System.Windows.Forms.ListBox();
            this.listBoxTrai = new System.Windows.Forms.ListBox();
            this.btDiaDiemRemove = new System.Windows.Forms.Button();
            this.btDiaDiemAdd = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btThemGia = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btHuyGia = new System.Windows.Forms.Button();
            this.btLuuGia = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txGia = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePickerKT = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerBD = new System.Windows.Forms.DateTimePicker();
            this.btSuaGia = new System.Windows.Forms.Button();
            this.btXoaGia = new System.Windows.Forms.Button();
            this.dgvGia = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btHuy_doanhthu = new System.Windows.Forms.Button();
            this.btTim_Doanhthu = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dateKT_doanhthu = new System.Windows.Forms.DateTimePicker();
            this.dateBD_doanhthu = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbDoanhThu = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbSoLuongDoan = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvDoanhThu = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btXoaTour = new System.Windows.Forms.Button();
            this.btSuaTour = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dgv_ThongKe = new System.Windows.Forms.DataGridView();
            this.cbLoaiCP_ThongKe = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dateDB_ThongKe = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.dateKT_ThongKe = new System.Windows.Forms.DateTimePicker();
            this.btTim_ThongKe = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.lbThongKe = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pnThongTin.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGia)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhThu)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ThongKe)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnThongTin
            // 
            this.pnThongTin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnThongTin.Controls.Add(this.btReset);
            this.pnThongTin.Controls.Add(this.cbLoaiTour);
            this.pnThongTin.Controls.Add(this.btThemTour);
            this.pnThongTin.Controls.Add(this.txTenTour);
            this.pnThongTin.Controls.Add(this.txId);
            this.pnThongTin.Controls.Add(this.label4);
            this.pnThongTin.Controls.Add(this.label2);
            this.pnThongTin.Controls.Add(this.label1);
            this.pnThongTin.Location = new System.Drawing.Point(1, 4);
            this.pnThongTin.Name = "pnThongTin";
            this.pnThongTin.Size = new System.Drawing.Size(589, 144);
            this.pnThongTin.TabIndex = 0;
            // 
            // btReset
            // 
            this.btReset.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btReset.Location = new System.Drawing.Point(467, 70);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(87, 38);
            this.btReset.TabIndex = 1;
            this.btReset.Text = "Hủy";
            this.btReset.UseVisualStyleBackColor = true;
            this.btReset.Visible = false;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // cbLoaiTour
            // 
            this.cbLoaiTour.Enabled = false;
            this.cbLoaiTour.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLoaiTour.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cbLoaiTour.FormattingEnabled = true;
            this.cbLoaiTour.Location = new System.Drawing.Point(389, 23);
            this.cbLoaiTour.Name = "cbLoaiTour";
            this.cbLoaiTour.Size = new System.Drawing.Size(174, 25);
            this.cbLoaiTour.TabIndex = 7;
            // 
            // btThemTour
            // 
            this.btThemTour.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThemTour.Location = new System.Drawing.Point(331, 70);
            this.btThemTour.Name = "btThemTour";
            this.btThemTour.Size = new System.Drawing.Size(87, 38);
            this.btThemTour.TabIndex = 0;
            this.btThemTour.Text = "Lưu";
            this.btThemTour.UseVisualStyleBackColor = true;
            this.btThemTour.Visible = false;
            this.btThemTour.Click += new System.EventHandler(this.btThemTour_Click);
            // 
            // txTenTour
            // 
            this.txTenTour.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txTenTour.Location = new System.Drawing.Point(111, 83);
            this.txTenTour.MaxLength = 40;
            this.txTenTour.Name = "txTenTour";
            this.txTenTour.ReadOnly = true;
            this.txTenTour.Size = new System.Drawing.Size(174, 25);
            this.txTenTour.TabIndex = 5;
            // 
            // txId
            // 
            this.txId.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txId.Location = new System.Drawing.Point(111, 23);
            this.txId.Name = "txId";
            this.txId.ReadOnly = true;
            this.txId.Size = new System.Drawing.Size(174, 25);
            this.txId.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(303, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Loại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Tour";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Tour";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(1, 154);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(829, 533);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btHuyDD);
            this.tabPage1.Controls.Add(this.btLuuDD);
            this.tabPage1.Controls.Add(this.listBoxPhai);
            this.tabPage1.Controls.Add(this.listBoxTrai);
            this.tabPage1.Controls.Add(this.btDiaDiemRemove);
            this.tabPage1.Controls.Add(this.btDiaDiemAdd);
            this.tabPage1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(821, 501);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Địa Điểm";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btHuyDD
            // 
            this.btHuyDD.Location = new System.Drawing.Point(432, 282);
            this.btHuyDD.Name = "btHuyDD";
            this.btHuyDD.Size = new System.Drawing.Size(87, 50);
            this.btHuyDD.TabIndex = 7;
            this.btHuyDD.Text = "Hủy";
            this.btHuyDD.UseVisualStyleBackColor = true;
            this.btHuyDD.Click += new System.EventHandler(this.btHuyDD_Click);
            // 
            // btLuuDD
            // 
            this.btLuuDD.Location = new System.Drawing.Point(305, 282);
            this.btLuuDD.Name = "btLuuDD";
            this.btLuuDD.Size = new System.Drawing.Size(87, 50);
            this.btLuuDD.TabIndex = 6;
            this.btLuuDD.Text = "Lưu";
            this.btLuuDD.UseVisualStyleBackColor = true;
            this.btLuuDD.Click += new System.EventHandler(this.btLuuDD_Click);
            // 
            // listBoxPhai
            // 
            this.listBoxPhai.FormattingEnabled = true;
            this.listBoxPhai.ItemHeight = 23;
            this.listBoxPhai.Location = new System.Drawing.Point(546, 34);
            this.listBoxPhai.Name = "listBoxPhai";
            this.listBoxPhai.Size = new System.Drawing.Size(230, 349);
            this.listBoxPhai.TabIndex = 5;
            // 
            // listBoxTrai
            // 
            this.listBoxTrai.FormattingEnabled = true;
            this.listBoxTrai.ItemHeight = 23;
            this.listBoxTrai.Location = new System.Drawing.Point(37, 34);
            this.listBoxTrai.Name = "listBoxTrai";
            this.listBoxTrai.Size = new System.Drawing.Size(230, 349);
            this.listBoxTrai.TabIndex = 4;
            // 
            // btDiaDiemRemove
            // 
            this.btDiaDiemRemove.Location = new System.Drawing.Point(360, 180);
            this.btDiaDiemRemove.Name = "btDiaDiemRemove";
            this.btDiaDiemRemove.Size = new System.Drawing.Size(114, 44);
            this.btDiaDiemRemove.TabIndex = 3;
            this.btDiaDiemRemove.Text = "<<<<";
            this.btDiaDiemRemove.UseVisualStyleBackColor = true;
            this.btDiaDiemRemove.Click += new System.EventHandler(this.btDiaDiemRemove_Click);
            // 
            // btDiaDiemAdd
            // 
            this.btDiaDiemAdd.Location = new System.Drawing.Point(360, 101);
            this.btDiaDiemAdd.Name = "btDiaDiemAdd";
            this.btDiaDiemAdd.Size = new System.Drawing.Size(114, 44);
            this.btDiaDiemAdd.TabIndex = 2;
            this.btDiaDiemAdd.Text = ">>>>";
            this.btDiaDiemAdd.UseVisualStyleBackColor = true;
            this.btDiaDiemAdd.Click += new System.EventHandler(this.btDiaDiemAdd_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btThemGia);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Controls.Add(this.btSuaGia);
            this.tabPage2.Controls.Add(this.btXoaGia);
            this.tabPage2.Controls.Add(this.dgvGia);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(821, 501);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Giá";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btThemGia
            // 
            this.btThemGia.Location = new System.Drawing.Point(649, 112);
            this.btThemGia.Name = "btThemGia";
            this.btThemGia.Size = new System.Drawing.Size(75, 32);
            this.btThemGia.TabIndex = 16;
            this.btThemGia.Text = "Thêm";
            this.btThemGia.UseVisualStyleBackColor = true;
            this.btThemGia.Click += new System.EventHandler(this.btThemGia_Click_1);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btHuyGia);
            this.panel2.Controls.Add(this.btLuuGia);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txGia);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.dateTimePickerKT);
            this.panel2.Controls.Add(this.dateTimePickerBD);
            this.panel2.Location = new System.Drawing.Point(7, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(636, 171);
            this.panel2.TabIndex = 5;
            // 
            // btHuyGia
            // 
            this.btHuyGia.Location = new System.Drawing.Point(514, 110);
            this.btHuyGia.Name = "btHuyGia";
            this.btHuyGia.Size = new System.Drawing.Size(92, 32);
            this.btHuyGia.TabIndex = 16;
            this.btHuyGia.Text = "Hủy";
            this.btHuyGia.UseVisualStyleBackColor = true;
            this.btHuyGia.Visible = false;
            this.btHuyGia.Click += new System.EventHandler(this.btHuyGia_Click);
            // 
            // btLuuGia
            // 
            this.btLuuGia.Location = new System.Drawing.Point(400, 111);
            this.btLuuGia.Name = "btLuuGia";
            this.btLuuGia.Size = new System.Drawing.Size(92, 32);
            this.btLuuGia.TabIndex = 15;
            this.btLuuGia.Text = "Thêm";
            this.btLuuGia.UseVisualStyleBackColor = true;
            this.btLuuGia.Click += new System.EventHandler(this.btThemGia_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(396, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 19);
            this.label7.TabIndex = 14;
            this.label7.Text = "Giá";
            // 
            // txGia
            // 
            this.txGia.Location = new System.Drawing.Point(440, 38);
            this.txGia.Name = "txGia";
            this.txGia.Size = new System.Drawing.Size(166, 27);
            this.txGia.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 19);
            this.label6.TabIndex = 12;
            this.label6.Text = "Ngày kết thúc";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "Ngày bắt đầu";
            // 
            // dateTimePickerKT
            // 
            this.dateTimePickerKT.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerKT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerKT.Location = new System.Drawing.Point(130, 111);
            this.dateTimePickerKT.Name = "dateTimePickerKT";
            this.dateTimePickerKT.Size = new System.Drawing.Size(200, 27);
            this.dateTimePickerKT.TabIndex = 10;
            // 
            // dateTimePickerBD
            // 
            this.dateTimePickerBD.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerBD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerBD.Location = new System.Drawing.Point(130, 38);
            this.dateTimePickerBD.Name = "dateTimePickerBD";
            this.dateTimePickerBD.Size = new System.Drawing.Size(200, 27);
            this.dateTimePickerBD.TabIndex = 9;
            // 
            // btSuaGia
            // 
            this.btSuaGia.Location = new System.Drawing.Point(649, 150);
            this.btSuaGia.Name = "btSuaGia";
            this.btSuaGia.Size = new System.Drawing.Size(75, 27);
            this.btSuaGia.TabIndex = 4;
            this.btSuaGia.Text = "Sửa";
            this.btSuaGia.UseVisualStyleBackColor = true;
            this.btSuaGia.Click += new System.EventHandler(this.btSuaGia_Click);
            // 
            // btXoaGia
            // 
            this.btXoaGia.Location = new System.Drawing.Point(739, 150);
            this.btXoaGia.Name = "btXoaGia";
            this.btXoaGia.Size = new System.Drawing.Size(75, 27);
            this.btXoaGia.TabIndex = 3;
            this.btXoaGia.Text = "Xóa";
            this.btXoaGia.UseVisualStyleBackColor = true;
            this.btXoaGia.Click += new System.EventHandler(this.btXoaGia_Click);
            // 
            // dgvGia
            // 
            this.dgvGia.AllowUserToAddRows = false;
            this.dgvGia.AllowUserToDeleteRows = false;
            this.dgvGia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGia.Location = new System.Drawing.Point(4, 183);
            this.dgvGia.MultiSelect = false;
            this.dgvGia.Name = "dgvGia";
            this.dgvGia.ReadOnly = true;
            this.dgvGia.RowHeadersWidth = 51;
            this.dgvGia.RowTemplate.Height = 24;
            this.dgvGia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGia.Size = new System.Drawing.Size(814, 312);
            this.dgvGia.TabIndex = 0;
            this.dgvGia.SelectionChanged += new System.EventHandler(this.dgvGia_SelectionChanged);
            this.dgvGia.Click += new System.EventHandler(this.dgvGia_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Controls.Add(this.lbSoLuongDoan);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.dgvDoanhThu);
            this.tabPage3.Location = new System.Drawing.Point(4, 28);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(821, 501);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Doanh thu";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btHuy_doanhthu);
            this.groupBox2.Controls.Add(this.btTim_Doanhthu);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.dateKT_doanhthu);
            this.groupBox2.Controls.Add(this.dateBD_doanhthu);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(804, 108);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lọc";
            // 
            // btHuy_doanhthu
            // 
            this.btHuy_doanhthu.Location = new System.Drawing.Point(409, 72);
            this.btHuy_doanhthu.Name = "btHuy_doanhthu";
            this.btHuy_doanhthu.Size = new System.Drawing.Size(75, 30);
            this.btHuy_doanhthu.TabIndex = 14;
            this.btHuy_doanhthu.Text = "Hủy";
            this.btHuy_doanhthu.UseVisualStyleBackColor = true;
            this.btHuy_doanhthu.Click += new System.EventHandler(this.btHuy_doanhthu_Click);
            // 
            // btTim_Doanhthu
            // 
            this.btTim_Doanhthu.Location = new System.Drawing.Point(298, 72);
            this.btTim_Doanhthu.Name = "btTim_Doanhthu";
            this.btTim_Doanhthu.Size = new System.Drawing.Size(75, 30);
            this.btTim_Doanhthu.TabIndex = 13;
            this.btTim_Doanhthu.Text = "Tìm";
            this.btTim_Doanhthu.UseVisualStyleBackColor = true;
            this.btTim_Doanhthu.Click += new System.EventHandler(this.btTim_Doanhthu_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(430, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 19);
            this.label10.TabIndex = 12;
            this.label10.Text = "Ngày kết thúc";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(51, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 19);
            this.label9.TabIndex = 11;
            this.label9.Text = "Ngày bắt đàu";
            // 
            // dateKT_doanhthu
            // 
            this.dateKT_doanhthu.CustomFormat = "dd/MM/yyyy";
            this.dateKT_doanhthu.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateKT_doanhthu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateKT_doanhthu.Location = new System.Drawing.Point(556, 26);
            this.dateKT_doanhthu.Name = "dateKT_doanhthu";
            this.dateKT_doanhthu.Size = new System.Drawing.Size(200, 27);
            this.dateKT_doanhthu.TabIndex = 10;
            this.dateKT_doanhthu.Value = new System.DateTime(2020, 11, 13, 0, 0, 0, 0);
            // 
            // dateBD_doanhthu
            // 
            this.dateBD_doanhthu.CustomFormat = "dd/MM/yyyy";
            this.dateBD_doanhthu.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateBD_doanhthu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateBD_doanhthu.Location = new System.Drawing.Point(173, 26);
            this.dateBD_doanhthu.Name = "dateBD_doanhthu";
            this.dateBD_doanhthu.Size = new System.Drawing.Size(200, 27);
            this.dateBD_doanhthu.TabIndex = 9;
            this.dateBD_doanhthu.Value = new System.DateTime(2020, 11, 13, 0, 0, 0, 0);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbDoanhThu);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Location = new System.Drawing.Point(7, 395);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(803, 100);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Doanh Thu";
            // 
            // lbDoanhThu
            // 
            this.lbDoanhThu.AutoSize = true;
            this.lbDoanhThu.Font = new System.Drawing.Font("Times New Roman", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDoanhThu.Location = new System.Drawing.Point(213, 49);
            this.lbDoanhThu.Name = "lbDoanhThu";
            this.lbDoanhThu.Size = new System.Drawing.Size(69, 22);
            this.lbDoanhThu.TabIndex = 1;
            this.lbDoanhThu.Text = "label12";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 50);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(188, 19);
            this.label11.TabIndex = 0;
            this.label11.Text = "Số tiền thu được của Tour:";
            // 
            // lbSoLuongDoan
            // 
            this.lbSoLuongDoan.AutoSize = true;
            this.lbSoLuongDoan.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoLuongDoan.Location = new System.Drawing.Point(255, 131);
            this.lbSoLuongDoan.Name = "lbSoLuongDoan";
            this.lbSoLuongDoan.Size = new System.Drawing.Size(63, 19);
            this.lbSoLuongDoan.TabIndex = 9;
            this.lbSoLuongDoan.Text = "label11";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(247, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "Các đoàn tham gia vào Tour:";
            // 
            // dgvDoanhThu
            // 
            this.dgvDoanhThu.AllowUserToAddRows = false;
            this.dgvDoanhThu.AllowUserToDeleteRows = false;
            this.dgvDoanhThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoanhThu.Location = new System.Drawing.Point(6, 154);
            this.dgvDoanhThu.MultiSelect = false;
            this.dgvDoanhThu.Name = "dgvDoanhThu";
            this.dgvDoanhThu.ReadOnly = true;
            this.dgvDoanhThu.RowHeadersWidth = 51;
            this.dgvDoanhThu.RowTemplate.Height = 24;
            this.dgvDoanhThu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDoanhThu.Size = new System.Drawing.Size(807, 235);
            this.dgvDoanhThu.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btXoaTour);
            this.panel1.Controls.Add(this.btSuaTour);
            this.panel1.Location = new System.Drawing.Point(619, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 144);
            this.panel1.TabIndex = 2;
            // 
            // btXoaTour
            // 
            this.btXoaTour.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoaTour.Location = new System.Drawing.Point(52, 72);
            this.btXoaTour.Name = "btXoaTour";
            this.btXoaTour.Size = new System.Drawing.Size(95, 43);
            this.btXoaTour.TabIndex = 3;
            this.btXoaTour.Text = "Xóa Tour";
            this.btXoaTour.UseVisualStyleBackColor = true;
            // 
            // btSuaTour
            // 
            this.btSuaTour.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSuaTour.Location = new System.Drawing.Point(52, 12);
            this.btSuaTour.Name = "btSuaTour";
            this.btSuaTour.Size = new System.Drawing.Size(95, 43);
            this.btSuaTour.TabIndex = 2;
            this.btSuaTour.Text = "Chỉnh sửa";
            this.btSuaTour.UseVisualStyleBackColor = true;
            this.btSuaTour.Click += new System.EventHandler(this.btSuaTour_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.lbThongKe);
            this.tabPage4.Controls.Add(this.label14);
            this.tabPage4.Controls.Add(this.groupBox3);
            this.tabPage4.Controls.Add(this.dgv_ThongKe);
            this.tabPage4.Location = new System.Drawing.Point(4, 28);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(821, 501);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Thống kê chi phí";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dgv_ThongKe
            // 
            this.dgv_ThongKe.AllowUserToAddRows = false;
            this.dgv_ThongKe.AllowUserToDeleteRows = false;
            this.dgv_ThongKe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ThongKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ThongKe.Location = new System.Drawing.Point(8, 273);
            this.dgv_ThongKe.Name = "dgv_ThongKe";
            this.dgv_ThongKe.ReadOnly = true;
            this.dgv_ThongKe.RowHeadersWidth = 51;
            this.dgv_ThongKe.RowTemplate.Height = 24;
            this.dgv_ThongKe.Size = new System.Drawing.Size(806, 222);
            this.dgv_ThongKe.TabIndex = 0;
            // 
            // cbLoaiCP_ThongKe
            // 
            this.cbLoaiCP_ThongKe.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLoaiCP_ThongKe.FormattingEnabled = true;
            this.cbLoaiCP_ThongKe.Location = new System.Drawing.Point(128, 37);
            this.cbLoaiCP_ThongKe.Name = "cbLoaiCP_ThongKe";
            this.cbLoaiCP_ThongKe.Size = new System.Drawing.Size(225, 27);
            this.cbLoaiCP_ThongKe.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(23, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 19);
            this.label8.TabIndex = 2;
            this.label8.Text = "Loại chi phí";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.btTim_ThongKe);
            this.groupBox3.Controls.Add(this.dateKT_ThongKe);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.dateDB_ThongKe);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.cbLoaiCP_ThongKe);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(8, 15);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(806, 150);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Lọc";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(23, 112);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 19);
            this.label12.TabIndex = 3;
            this.label12.Text = "Ngày bắt đầu";
            // 
            // dateDB_ThongKe
            // 
            this.dateDB_ThongKe.CustomFormat = "dd/MM/yyyy";
            this.dateDB_ThongKe.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateDB_ThongKe.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateDB_ThongKe.Location = new System.Drawing.Point(128, 104);
            this.dateDB_ThongKe.Name = "dateDB_ThongKe";
            this.dateDB_ThongKe.Size = new System.Drawing.Size(200, 27);
            this.dateDB_ThongKe.TabIndex = 4;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(354, 110);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(102, 19);
            this.label13.TabIndex = 5;
            this.label13.Text = "Ngày kết thúc";
            // 
            // dateKT_ThongKe
            // 
            this.dateKT_ThongKe.CustomFormat = "dd/MM/yyyy";
            this.dateKT_ThongKe.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateKT_ThongKe.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateKT_ThongKe.Location = new System.Drawing.Point(462, 102);
            this.dateKT_ThongKe.Name = "dateKT_ThongKe";
            this.dateKT_ThongKe.Size = new System.Drawing.Size(200, 27);
            this.dateKT_ThongKe.TabIndex = 6;
            // 
            // btTim_ThongKe
            // 
            this.btTim_ThongKe.Location = new System.Drawing.Point(378, 31);
            this.btTim_ThongKe.Name = "btTim_ThongKe";
            this.btTim_ThongKe.Size = new System.Drawing.Size(91, 37);
            this.btTim_ThongKe.TabIndex = 7;
            this.btTim_ThongKe.Text = "Tìm";
            this.btTim_ThongKe.UseVisualStyleBackColor = true;
            this.btTim_ThongKe.Click += new System.EventHandler(this.btTim_ThongKe_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 241);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(93, 19);
            this.label14.TabIndex = 4;
            this.label14.Text = "Tổng chi phí";
            // 
            // lbThongKe
            // 
            this.lbThongKe.AutoSize = true;
            this.lbThongKe.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThongKe.Location = new System.Drawing.Point(117, 241);
            this.lbThongKe.Name = "lbThongKe";
            this.lbThongKe.Size = new System.Drawing.Size(64, 19);
            this.lbThongKe.TabIndex = 5;
            this.lbThongKe.Text = "label15";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(681, 102);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 27);
            this.button1.TabIndex = 8;
            this.button1.Text = "Lọc";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frChiTietTour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 699);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pnThongTin);
            this.Name = "frChiTietTour";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thong tin Tour";
            this.pnThongTin.ResumeLayout(false);
            this.pnThongTin.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGia)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhThu)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ThongKe)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnThongTin;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txTenTour;
        private System.Windows.Forms.TextBox txId;
        private System.Windows.Forms.ComboBox cbLoaiTour;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btThemTour;
        private System.Windows.Forms.Button btReset;
        private System.Windows.Forms.Button btDiaDiemAdd;
        private System.Windows.Forms.Button btDiaDiemRemove;
        private System.Windows.Forms.ListBox listBoxTrai;
        private System.Windows.Forms.ListBox listBoxPhai;
        private System.Windows.Forms.DataGridView dgvGia;
        private System.Windows.Forms.Button btLuuDD;
        private System.Windows.Forms.Button btHuyDD;
        private System.Windows.Forms.Button btXoaGia;
        private System.Windows.Forms.Button btSuaGia;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txGia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePickerKT;
        private System.Windows.Forms.DateTimePicker dateTimePickerBD;
        private System.Windows.Forms.Button btLuuGia;
        private System.Windows.Forms.Button btHuyGia;
        private System.Windows.Forms.Button btSuaTour;
        private System.Windows.Forms.Button btXoaTour;
        private System.Windows.Forms.Button btThemGia;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvDoanhThu;
        private System.Windows.Forms.Label lbSoLuongDoan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbDoanhThu;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btHuy_doanhthu;
        private System.Windows.Forms.Button btTim_Doanhthu;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateKT_doanhthu;
        private System.Windows.Forms.DateTimePicker dateBD_doanhthu;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgv_ThongKe;
        private System.Windows.Forms.Label lbThongKe;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btTim_ThongKe;
        private System.Windows.Forms.DateTimePicker dateKT_ThongKe;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dateDB_ThongKe;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbLoaiCP_ThongKe;
        private System.Windows.Forms.Button button1;
    }
}