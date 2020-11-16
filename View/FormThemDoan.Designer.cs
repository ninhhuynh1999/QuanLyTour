namespace QuanLyDuLich.View
{
    partial class FormThemDoan
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
            this.txTenDoan = new System.Windows.Forms.TextBox();
            this.dateBatDau = new System.Windows.Forms.DateTimePicker();
            this.dateKetThuc = new System.Windows.Forms.DateTimePicker();
            this.txLichTrinh = new System.Windows.Forms.TextBox();
            this.cbTour = new System.Windows.Forms.ComboBox();
            this.txGia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txTenDoan
            // 
            this.txTenDoan.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txTenDoan.Location = new System.Drawing.Point(165, 41);
            this.txTenDoan.Margin = new System.Windows.Forms.Padding(4);
            this.txTenDoan.MaxLength = 30;
            this.txTenDoan.Name = "txTenDoan";
            this.txTenDoan.Size = new System.Drawing.Size(274, 27);
            this.txTenDoan.TabIndex = 0;
            // 
            // dateBatDau
            // 
            this.dateBatDau.CustomFormat = "dd/MM/yyyy";
            this.dateBatDau.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateBatDau.Location = new System.Drawing.Point(165, 106);
            this.dateBatDau.Margin = new System.Windows.Forms.Padding(4);
            this.dateBatDau.Name = "dateBatDau";
            this.dateBatDau.Size = new System.Drawing.Size(274, 27);
            this.dateBatDau.TabIndex = 1;
            this.dateBatDau.ValueChanged += new System.EventHandler(this.dateBatDau_ValueChanged);
            // 
            // dateKetThuc
            // 
            this.dateKetThuc.CustomFormat = "dd/MM/yyyy";
            this.dateKetThuc.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateKetThuc.Location = new System.Drawing.Point(165, 171);
            this.dateKetThuc.Margin = new System.Windows.Forms.Padding(4);
            this.dateKetThuc.Name = "dateKetThuc";
            this.dateKetThuc.Size = new System.Drawing.Size(274, 27);
            this.dateKetThuc.TabIndex = 2;
            // 
            // txLichTrinh
            // 
            this.txLichTrinh.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txLichTrinh.Location = new System.Drawing.Point(165, 242);
            this.txLichTrinh.Margin = new System.Windows.Forms.Padding(4);
            this.txLichTrinh.Name = "txLichTrinh";
            this.txLichTrinh.Size = new System.Drawing.Size(274, 27);
            this.txLichTrinh.TabIndex = 3;
            // 
            // cbTour
            // 
            this.cbTour.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbTour.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbTour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTour.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTour.FormattingEnabled = true;
            this.cbTour.Location = new System.Drawing.Point(165, 314);
            this.cbTour.Margin = new System.Windows.Forms.Padding(4);
            this.cbTour.Name = "cbTour";
            this.cbTour.Size = new System.Drawing.Size(274, 27);
            this.cbTour.TabIndex = 4;
            this.cbTour.SelectedValueChanged += new System.EventHandler(this.cbTour_SelectedValueChanged);
            // 
            // txGia
            // 
            this.txGia.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txGia.Location = new System.Drawing.Point(165, 388);
            this.txGia.Margin = new System.Windows.Forms.Padding(4);
            this.txGia.Name = "txGia";
            this.txGia.ReadOnly = true;
            this.txGia.Size = new System.Drawing.Size(274, 27);
            this.txGia.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tên Đoàn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 113);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ngày bắt đầu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 178);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ngày kết thúc";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(54, 249);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Lịch trình";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(96, 322);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tour";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(105, 395);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 19);
            this.label6.TabIndex = 11;
            this.label6.Text = "Giá";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(165, 481);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 35);
            this.button1.TabIndex = 12;
            this.button1.Text = "Lưu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(284, 481);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 35);
            this.button2.TabIndex = 13;
            this.button2.Text = "Hủy";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // FormThemDoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 553);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txGia);
            this.Controls.Add(this.cbTour);
            this.Controls.Add(this.txLichTrinh);
            this.Controls.Add(this.dateKetThuc);
            this.Controls.Add(this.dateBatDau);
            this.Controls.Add(this.txTenDoan);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormThemDoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm Đoàn du lịch";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txTenDoan;
        private System.Windows.Forms.DateTimePicker dateBatDau;
        private System.Windows.Forms.DateTimePicker dateKetThuc;
        private System.Windows.Forms.TextBox txLichTrinh;
        private System.Windows.Forms.ComboBox cbTour;
        private System.Windows.Forms.TextBox txGia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}