using QuanLyDuLich.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDuLich.View
{
    public partial class ThemNguoi : Form
    {
        private Nguoi curNguoi;
        public ThemNguoi()
        {
            InitializeComponent();
        }
        public ThemNguoi(Nguoi nguoi)
        {
            InitializeComponent();
            curNguoi = nguoi;
            if(curNguoi.MaVaiTro == 1)
            {
                this.Text = "Chinh sửa thông tin Khách hàng.";
            }
            if (curNguoi.MaVaiTro == 2)
            {
                this.Text = "Chinh sửa thông tin Nhân viên.";
            }
        }
        public void loadData()
        {
            if(curNguoi is null)
            {
                txId.Text = "-1";
                comboBox1.Visible = true;
                lbPhanLoai.Visible = true;
            }
            else
            {
                txId.Text = curNguoi.Id.ToString();
                txTen.Text = curNguoi.Ten.Trim();
                txCMND.Text = curNguoi.CMND.ToString().Trim();
                txSDT.Text = curNguoi.SDT.ToString().Trim();
                txEmail.Text = curNguoi.Email.Trim();
            }

        }

        private void ThemNguoi_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void txSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            
        }

        private void txCMND_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            if (txTen.Text == "")
            {
                MessageBox.Show("Tên  không được để trống!", "Lỗi:Tên  không được để trống!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txCMND.Text == "" && txSDT.Text == "" && txEmail.Text == "")
            {
                MessageBox.Show("Phải nhập vào ít nhất 1 trong 3 trường Email, SĐT, CMND!", "Lỗi:Phải nhập ít nhất 1 trong 3 trường Email, SĐT, CMND !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txSDT.Text.Length < 11 && txSDT.Text.Length > 0)
            {
                MessageBox.Show("SĐT không đúng format!", "Lỗi:SĐT không đúng format !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if ( (txCMND.Text.Length != 12 && txCMND.Text.Length > 0))
            {
                MessageBox.Show("CMND không đúng format!", "Lỗi:CMND không đúng format !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                var test = new MailAddress(txEmail.Text);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Email không đúng format!", "Lỗi:Email không đúng format !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Nguoi temp = new Nguoi() { Id = -1, Ten = txTen.Text.Trim(), CMND = txCMND.Text.Trim(), SDT = txSDT.Text.Trim(), Email = txEmail.Text.Trim() };
            if(this.Text == "Thêm Người")
            {
                if(comboBox1.SelectedIndex == -1)
                {
                    MessageBox.Show("Chưa chọn Phân loại", "Lỗi:Chưa chọn Phân loại !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                temp.MaVaiTro = comboBox1.SelectedIndex + 1;
            }
            else
            {
                temp.Id = curNguoi.Id;
                temp.MaVaiTro = curNguoi.MaVaiTro;
                temp.updated = true;
            }
            temp.Save();

            MessageBox.Show("Lưu thành công", "Giao điện sẽ đóng lại", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();

        }
    }
}
