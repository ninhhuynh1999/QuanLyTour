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
    public partial class DanhSachChiPhi : UserControl
    {
        private LoaiCP curChiphi;
        private List<LoaiCP> listChiphi;
        private DataView dv;

        public DanhSachChiPhi()
        {
            InitializeComponent();
        }

        public void LoadDanhsachCP()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã Chi phí");
            dt.Columns.Add("Tên Chi phí");
            dt.Columns.Add("Ghi chú");
            foreach (LoaiCP loaicp in listChiphi)
            {
                if(loaicp.GhiChu == null)
                {
                    dt.Rows.Add(loaicp.Id, loaicp.Ten, "null");

                }
                else
                {
                    dt.Rows.Add(loaicp.Id, loaicp.Ten, loaicp.GhiChu);

                }
            }
            dv = new DataView(dt);

            dataGridView1.DataSource = dv;
            dataGridView1.Refresh();
            dataGridView1.Update();
            dataGridView1.AutoGenerateColumns = false;

        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0 && dataGridView1.CurrentCell.RowIndex < listChiphi.Count && dataGridView1.CurrentCell.RowIndex != -1)
            {
                curChiphi = listChiphi[dataGridView1.CurrentCell.RowIndex];
            }
            txId.Text = curChiphi.Id + "";
            txTen.Text = curChiphi.Ten.Trim();
            txGhiChu.Text = curChiphi.GhiChu;
        }
        public void MoKhoaChinhSua()
        {
            txId.ReadOnly = true;
            txTen.ReadOnly = false;
            txGhiChu.ReadOnly = false;

            btLuu.Visible = true;
            btHuy.Visible = true;
            dataGridView1.Enabled = false;

            btThem.Enabled = false;
            btXoa.Enabled = false;
            btSua.Enabled = false;
            btThongTin.Enabled = false;
            txTimKiem.Enabled = false;
        }
        public void KhoaChinhSua()
        {
            txId.ReadOnly = true;
            txTen.ReadOnly = true;
            txGhiChu.ReadOnly = true;

            btLuu.Visible = false;
            btHuy.Visible = false;
            dataGridView1.Enabled = true;

            btThem.Enabled = true;
            btXoa.Enabled = true;
            btSua.Enabled = true;
            btThongTin.Enabled = true;
            txTimKiem.Enabled = true;

        }

        private void DanhSachChiPhi_Load(object sender, EventArgs e)
        {
            listChiphi = DalLoaiCP.GetAllLoaiCP();
            LoadDanhsachCP();
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            MoKhoaChinhSua();
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            if (txTen.Text.Trim() == "")
            {
                MessageBox.Show("Tên không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            LoaiCP temp = new LoaiCP();
            temp.Id = int.Parse(txId.Text.Trim());
            temp.Ten = txTen.Text.Trim();
            temp.GhiChu = txGhiChu.Text.Trim();

            if (temp.Id != -1)
            {
                temp.updated = true;
            }
            try
            {
                temp.Save();
                txId.Text = temp.Id.ToString();
                MessageBox.Show("Lưu thành công", "Lưu thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                KhoaChinhSua();
                listChiphi = DalLoaiCP.GetAllLoaiCP();
                LoadDanhsachCP();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                Console.WriteLine("loi luu Loai Chi Phi");
            }
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            KhoaChinhSua();
            txGhiChu.Text = curChiphi.GhiChu;
            txTen.Text = curChiphi.Ten.Trim();
            txId.Text = curChiphi.Id.ToString().Trim();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            MoKhoaChinhSua();
            txGhiChu.Text = "";
            txTen.Text = "";
            txId.Text = "-1";
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            curChiphi.GetChiPhi();
            if (curChiphi.listChiPhi.Count > 0)
            {
                MessageBox.Show("Loại chi phí này đang được sử dụng ở đoàn có Id=" + curChiphi.listChiPhi[0].Id, "Không thể xóa !!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                curChiphi.Delete();
                listChiphi = DalLoaiCP.GetAllLoaiCP();
                LoadDanhsachCP();
            }

        }

        private void txTimKiem_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txTimKiem_TextChanged(object sender, EventArgs e)
        {
            dv.RowFilter = string.Format("[Mã Chi phí] + [Tên Chi phí] + [Ghi chú]" + " Like '%{0}%'", txTimKiem.Text);
            dataGridView1.DataSource = dv;
            dataGridView1.Refresh();
            dataGridView1.Update();
        }

        private void btThongTin_Click(object sender, EventArgs e)
        {
            ThongKeChiPhi thongKeChiPhi = new ThongKeChiPhi();
            thongKeChiPhi.ShowDialog();
        }
    }
}
