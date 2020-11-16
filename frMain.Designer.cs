using QuanLyDuLich.View;
using System.Windows.Forms;

namespace QuanLyDuLich
{
    partial class frMain
    {
        public UserControl userControl;
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
            this.pnMenu = new System.Windows.Forms.Panel();
            this.btTimKiem = new System.Windows.Forms.Button();
            this.btChiPhi = new System.Windows.Forms.Button();
            this.btDSDiaDiem = new System.Windows.Forms.Button();
            this.btKhachNhanVien = new System.Windows.Forms.Button();
            this.btDoanDL = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pnMain = new System.Windows.Forms.Panel();
            this.btDiaDiem = new System.Windows.Forms.Button();
            this.pnMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnMenu
            // 
            this.pnMenu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnMenu.Controls.Add(this.btDiaDiem);
            this.pnMenu.Controls.Add(this.btTimKiem);
            this.pnMenu.Controls.Add(this.btChiPhi);
            this.pnMenu.Controls.Add(this.btDSDiaDiem);
            this.pnMenu.Controls.Add(this.btKhachNhanVien);
            this.pnMenu.Controls.Add(this.btDoanDL);
            this.pnMenu.Controls.Add(this.button1);
            this.pnMenu.Location = new System.Drawing.Point(13, 13);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Size = new System.Drawing.Size(200, 714);
            this.pnMenu.TabIndex = 0;
            // 
            // btTimKiem
            // 
            this.btTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btTimKiem.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btTimKiem.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTimKiem.Location = new System.Drawing.Point(14, 486);
            this.btTimKiem.Name = "btTimKiem";
            this.btTimKiem.Size = new System.Drawing.Size(163, 61);
            this.btTimKiem.TabIndex = 5;
            this.btTimKiem.Text = "Tìm kiếm";
            this.btTimKiem.UseVisualStyleBackColor = false;
            // 
            // btChiPhi
            // 
            this.btChiPhi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btChiPhi.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btChiPhi.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btChiPhi.Location = new System.Drawing.Point(14, 334);
            this.btChiPhi.Name = "btChiPhi";
            this.btChiPhi.Size = new System.Drawing.Size(163, 61);
            this.btChiPhi.TabIndex = 4;
            this.btChiPhi.Text = "Danh sách Chi phí";
            this.btChiPhi.UseVisualStyleBackColor = false;
            this.btChiPhi.Click += new System.EventHandler(this.btChiPhi_Click);
            // 
            // btDSDiaDiem
            // 
            this.btDSDiaDiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btDSDiaDiem.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btDSDiaDiem.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDSDiaDiem.Location = new System.Drawing.Point(14, 177);
            this.btDSDiaDiem.Name = "btDSDiaDiem";
            this.btDSDiaDiem.Size = new System.Drawing.Size(163, 61);
            this.btDSDiaDiem.TabIndex = 3;
            this.btDSDiaDiem.Text = "Danh sách địa điểm";
            this.btDSDiaDiem.UseVisualStyleBackColor = false;
            // 
            // btKhachNhanVien
            // 
            this.btKhachNhanVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btKhachNhanVien.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btKhachNhanVien.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btKhachNhanVien.Location = new System.Drawing.Point(14, 254);
            this.btKhachNhanVien.Name = "btKhachNhanVien";
            this.btKhachNhanVien.Size = new System.Drawing.Size(163, 61);
            this.btKhachNhanVien.TabIndex = 2;
            this.btKhachNhanVien.Text = "Khách và Nhân viên";
            this.btKhachNhanVien.UseVisualStyleBackColor = false;
            this.btKhachNhanVien.Click += new System.EventHandler(this.btKhachNhanVien_Click);
            // 
            // btDoanDL
            // 
            this.btDoanDL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btDoanDL.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btDoanDL.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDoanDL.Location = new System.Drawing.Point(14, 100);
            this.btDoanDL.Name = "btDoanDL";
            this.btDoanDL.Size = new System.Drawing.Size(163, 61);
            this.btDoanDL.TabIndex = 1;
            this.btDoanDL.Text = "Quản lý Đoàn khách";
            this.btDoanDL.UseVisualStyleBackColor = false;
            this.btDoanDL.Click += new System.EventHandler(this.btDoanDL_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(14, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 61);
            this.button1.TabIndex = 0;
            this.button1.Text = "Quản lý Tour";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pnMain
            // 
            this.pnMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnMain.BackColor = System.Drawing.Color.White;
            this.pnMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnMain.Location = new System.Drawing.Point(220, 13);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(670, 714);
            this.pnMain.TabIndex = 1;
            this.pnMain.Paint += new System.Windows.Forms.PaintEventHandler(this.pnMain_Paint);
            // 
            // btDiaDiem
            // 
            this.btDiaDiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btDiaDiem.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btDiaDiem.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDiaDiem.Location = new System.Drawing.Point(14, 410);
            this.btDiaDiem.Name = "btDiaDiem";
            this.btDiaDiem.Size = new System.Drawing.Size(163, 61);
            this.btDiaDiem.TabIndex = 6;
            this.btDiaDiem.Text = "Danh sách Địa điểm";
            this.btDiaDiem.UseVisualStyleBackColor = false;
            this.btDiaDiem.Click += new System.EventHandler(this.btDiaDiem_Click);
            // 
            // frMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(902, 739);
            this.Controls.Add(this.pnMain);
            this.Controls.Add(this.pnMenu);
            this.Location = new System.Drawing.Point(500, 0);
            this.Name = "frMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý Du lịch";
            this.pnMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnMenu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pnMain;
        private Button btDoanDL;
        private Button btKhachNhanVien;
        private Button btDSDiaDiem;
        private Button btChiPhi;
        private Button btTimKiem;
        private Button btDiaDiem;
    }
}

