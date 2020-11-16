using QuanLyDuLich.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDuLich
{
    public partial class frMain : Form
    {
        public frMain()
        {
            InitializeComponent();
            loadDanhSachTour();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadDanhSachTour();
        }

        private void btDoanDL_Click(object sender, EventArgs e)
        {
            loadDanhSachDoanDL();
        }
        public void loadDanhSachTour()
        {
            userControl = new DanhsachTour();
            pnMain.Controls.Clear();
            pnMain.Controls.Add(userControl);
            userControl.Show();
        }
        public void loadDanhSachDoanDL()
        {
            userControl = new DanhSachDoanDuLich();
            pnMain.Controls.Clear();
            pnMain.Controls.Add(userControl);
            userControl.Show();
        }

        private void pnMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btKhachNhanVien_Click(object sender, EventArgs e)
        {
            userControl = new DanhSachNguoi();
            pnMain.Controls.Clear();
            pnMain.Controls.Add(userControl);
            userControl.Show();
        }

        private void btChiPhi_Click(object sender, EventArgs e)
        {
            userControl = new DanhSachChiPhi();
            pnMain.Controls.Clear();
            pnMain.Controls.Add(userControl);
            userControl.Show();
        }

        private void btDiaDiem_Click(object sender, EventArgs e)
        {
            userControl = new DanhSachDiaDiem();
            pnMain.Controls.Clear();
            pnMain.Controls.Add(userControl);
            userControl.Show();
        }
    }
}
