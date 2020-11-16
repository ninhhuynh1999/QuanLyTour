using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyDuLich.DAL;

namespace QuanLyDuLich.View
{
    public partial class DanhSachNguoi : UserControl
    {
        private Nguoi curKhach;
        private Nguoi curNhanVien;
        private List<Nguoi> listKhach;
        private List<Nguoi> listNhanvien;
        private List<Nguoi> DsDoan_Khach;
        private List<Nguoi> DsDoan_NV;
        private List<Nguoi> DsTour_Khach;
        private List<Nguoi> DsTour_NV;
        private List<Nguoi> DsTour_ThongKe;

        private DataView dv_khach; 
        private DataView dv_nv;

        public DanhSachNguoi()
        {
            InitializeComponent();
        }

        private void btThongKe_Click(object sender, EventArgs e)
        {

        }

        private void DanhSachNguoi_Load(object sender, EventArgs e)
        {
            listKhach = DalNguoi.getKhach();
            listNhanvien = DalNguoi.getNhanVien();

            loadDSKhach();
            loadDSNhanVien();

        }
        public void loadDSKhach()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã khách");
            dt.Columns.Add("Tên Khách");
            dt.Columns.Add("CMND");
            dt.Columns.Add("SĐT");
            dt.Columns.Add("Email");
            cbSearchKhach.Items.Add("Tất cả");

            foreach (DataColumn dc in dt.Columns)
            {
                cbSearchKhach.Items.Add(dc.ColumnName);
            }
            if(cbSearchKhach.Items.Count > 0)
            {
                cbSearchKhach.SelectedIndex = 0;
            }
            foreach (Nguoi nguoi in listKhach)
            {
                dt.Rows.Add(nguoi.Id,nguoi.Ten,nguoi.CMND,nguoi.SDT,nguoi.Email);
            }
             dv_khach = new DataView(dt);

            dgvDSKhach.DataSource = dv_khach;
            dgvDSKhach.Refresh();
            dgvDSKhach.Update();
            dgvDSKhach.AutoGenerateColumns = false;
        }
        public void loadDSNhanVien()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã nhân viên");
            dt.Columns.Add("Tên Nhân viên");
            dt.Columns.Add("CMND");
            dt.Columns.Add("SĐT");
            dt.Columns.Add("Email");
            cbSearchNhanVien.Items.Add("Tất cả");

            foreach (DataColumn dc in dt.Columns)
            {
                cbSearchNhanVien.Items.Add(dc.ColumnName);
            }

            if (cbSearchNhanVien.Items.Count > 0)
            {
                cbSearchNhanVien.SelectedIndex = 0;
            }

            foreach (Nguoi nguoi in listNhanvien)
            {
                dt.Rows.Add(nguoi.Id, nguoi.Ten, nguoi.CMND, nguoi.SDT, nguoi.Email);
            }
             dv_nv = new DataView(dt);

            dgvDSNhanVien.DataSource = dv_nv;
            dgvDSNhanVien.Refresh();
            dgvDSNhanVien.Update();
            dgvDSNhanVien.AutoGenerateColumns = false;
        }
        public void LoadDSTourDaDi(Nguoi nguoi)
        {

        }
        public void LoadDSDiaDiemDaDi(Nguoi nguoi)
        {
            
        }

        private void dgvDSKhach_SelectionChanged(object sender, EventArgs e)
        {
            
                if (dgvDSKhach.Rows.Count > 0)
                {
                    curKhach = listKhach[dgvDSKhach.CurrentCell.RowIndex];
                   Console.WriteLine(curKhach.Ten);
                }

            
        }

        private void dgvDSNhanVien_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDSNhanVien.Rows.Count > 0)
            {
                curNhanVien = listNhanvien[dgvDSNhanVien.CurrentCell.RowIndex];
                Console.WriteLine(curNhanVien.Ten);
            }
        }

        private void txSearchKhach_TextChanged(object sender, EventArgs e)
        {
            if (cbSearchKhach.Text == "Tất cả")
            {
                String s = "";
                for (int i = 1; i < cbSearchKhach.Items.Count; i++)
                {
                    if (i == cbSearchKhach.Items.Count - 1)
                    {
                        s += "[" + cbSearchKhach.GetItemText(cbSearchKhach.Items[i]) + "]";
                        break;
                    }
                    s += "[" + cbSearchKhach.GetItemText(cbSearchKhach.Items[i]) + "] + ";

                }

                dv_khach.RowFilter = string.Format(s + " Like '%{0}%'", txSearchKhach.Text);
            }
            else
            {
                dv_khach.RowFilter = string.Format("[" + cbSearchKhach.Text + "]" + " Like '%{0}%'", txSearchKhach.Text);
               // Console.WriteLine(cbSearchKhach.Text);

            }

            dgvDSKhach.DataSource = dv_khach;
            dgvDSKhach.Refresh();
            dgvDSKhach.Update();
        }

        private void txSearchNV_TextChanged(object sender, EventArgs e)
        {
            if (cbSearchNhanVien.Text == "Tất cả")
            {
                String s = "";
                for (int i = 1; i < cbSearchNhanVien.Items.Count; i++)
                {
                    if (i == cbSearchNhanVien.Items.Count - 1)
                    {
                        s += "[" + cbSearchNhanVien.GetItemText(cbSearchNhanVien.Items[i]) + "]";
                        break;
                    }
                    s += "[" + cbSearchNhanVien.GetItemText(cbSearchNhanVien.Items[i]) + "] + ";

                }

                dv_nv.RowFilter = string.Format(s + " Like '%{0}%'", txSearchNV.Text);
            }
            else
            {
                dv_nv.RowFilter = string.Format("[" + cbSearchNhanVien.Text + "]" + " Like '%{0}%'", txSearchNV.Text);
               // Console.WriteLine(cbSearchNhanVien.Text);

            }

            dgvDSNhanVien.DataSource = dv_nv;
            dgvDSNhanVien.Refresh();
            dgvDSKhach.Update();
        }

        private void btThemKH_Click(object sender, EventArgs e)
        {
            ThemNguoi themNguoi = new ThemNguoi();
            themNguoi.ShowDialog();
            listKhach = DalNguoi.getKhach();
            loadDSKhach();
            listNhanvien = DalNguoi.getNhanVien();
            loadDSNhanVien();
        }

        private void btThemNV_Click(object sender, EventArgs e)
        {
            ThemNguoi themNguoi = new ThemNguoi();
            themNguoi.ShowDialog();
            listNhanvien = DalNguoi.getNhanVien();
            loadDSNhanVien();
            listKhach = DalNguoi.getKhach();
            loadDSKhach();
        }

        private void btSuaKH_Click(object sender, EventArgs e)
        {
            ThemNguoi themNguoi = new ThemNguoi(curKhach);
            themNguoi.ShowDialog();
            listKhach = DalNguoi.getKhach();
            loadDSKhach();
        }

        private void btSuaNV_Click(object sender, EventArgs e)
        {
            ThemNguoi themNguoi = new ThemNguoi(curNhanVien);
            themNguoi.ShowDialog();
            listNhanvien = DalNguoi.getNhanVien();
            loadDSNhanVien();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 chitietNguoi = new Form1(curKhach);
            chitietNguoi.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 chitietNguoi = new Form1(curNhanVien);
            chitietNguoi.ShowDialog();

        }
    }
}
