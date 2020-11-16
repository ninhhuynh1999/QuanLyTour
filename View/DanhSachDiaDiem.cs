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
    public partial class DanhSachDiaDiem : UserControl
    {
        private DiaDiem curDiaDiem;
        private List<DiaDiem> listDiaDiem;
        private DataView dv;
        public DanhSachDiaDiem()
        {
            InitializeComponent();
        }

        private void DanhSachDiaDiem_Load(object sender, EventArgs e)
        {
            listDiaDiem = DalDiaDiem.GetAllDiaDiem();
            loadData();
        }

        public void loadData()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Id");
            dt.Columns.Add("Tên Địa điểm");
            dt.Columns.Add("Ghi chú");
            foreach (DiaDiem diadiem in listDiaDiem)
            {
                if(diadiem.GhiChu == null)
                {
                    dt.Rows.Add(diadiem.Id, diadiem.Ten, "null");
                }
                else
                {
                    dt.Rows.Add(diadiem.Id, diadiem.Ten, diadiem.GhiChu);

                }
            }
            dv = new DataView(dt);

            dataGridView1.DataSource = dv;
            dataGridView1.Refresh();
            dataGridView1.Update();
            dataGridView1.AutoGenerateColumns = false;
        }
        public void KhoaChinhSua()
        {
            txTen.ReadOnly = true;
            txGHichu.ReadOnly = true;

            btLuu.Visible = false;
            btHuy.Visible = false;

            btChiTiet.Enabled = true;
            btThem.Enabled = true;
            btXoa.Enabled = true;
            btSua.Enabled = true;
            dataGridView1.Enabled = true;
            txTim.ReadOnly = false;
        }
        public void MoKhoaChinhSua()
        {
            txTen.ReadOnly = false;
            txGHichu.ReadOnly = false;

            btLuu.Visible = true;
            btHuy.Visible = true;

            btChiTiet.Enabled = false;
            btThem.Enabled = false;
            btXoa.Enabled = false;
            btSua.Enabled = false;
            dataGridView1.Enabled = false;
            txTim.ReadOnly = true;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0 && dataGridView1.CurrentCell.RowIndex >= 0)
            {
                int dong = dataGridView1.CurrentCell.RowIndex;
                DataGridViewRow row = dataGridView1.Rows[dong];
                int id = int.Parse(row.Cells[0].Value.ToString());
                curDiaDiem = listDiaDiem.Select(c => c).Where(s => s.Id == id).FirstOrDefault();
                //Console.WriteLine(curTour.Ten);
                if(curDiaDiem != null)
                {
                    txId.Text = curDiaDiem.Id.ToString();
                    txTen.Text = curDiaDiem.Ten.Trim();
                    txGHichu.Text = curDiaDiem.GhiChu;
                }
                
            }
        }

        private void txTim_TextChanged(object sender, EventArgs e)
        {
            dv.RowFilter = string.Format("[Id] + [Tên Địa điểm] + [Ghi chú] Like '%{0}%'", txTim.Text);
            if (txTim.Text.Trim() == "") dv.RowFilter = null;

            dataGridView1.DataSource = dv;
            dataGridView1.Refresh();
            dataGridView1.Update();
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            MoKhoaChinhSua();

        }

        private void btThem_Click(object sender, EventArgs e)
        {
            MoKhoaChinhSua();
            txId.Text = "-1";
            txTen.Text = "";
            txGHichu.Text = "";
            txTen.Focus();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (curDiaDiem.KiemtraXoa())
            {
                curDiaDiem.Delete();
                if(listDiaDiem.Count > 0)curDiaDiem = listDiaDiem[0];
                
                listDiaDiem = DalDiaDiem.GetAllDiaDiem();
                loadData();
            }
            else
            {
                MessageBox.Show("Dia dieem da duoc su dung nen khong the xoa", "Lỗi: Dia diem da duoc su dung!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void btChiTiet_Click(object sender, EventArgs e)
        {

        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            if(txTen.Text.Trim() == "")
            {
                MessageBox.Show("Tên bị rỗng", "Lỗi: Tên không được rỗng!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DiaDiem temp = new DiaDiem() { Id = int.Parse(txId.Text), Ten = txTen.Text, GhiChu = txGHichu.Text };
            if(temp.Id != -1)
            {
                temp.updated = true;
            }
            temp.Save();
            MessageBox.Show("Lưu thành công địa điểm mã:"+temp.Id , "Thành công: Lưu thành công!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            KhoaChinhSua();
            listDiaDiem = DalDiaDiem.GetAllDiaDiem();
            loadData();
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            txId.Text = curDiaDiem.Id + "";
            txTen.Text = curDiaDiem.Ten;
            txGHichu.Text = curDiaDiem.GhiChu;
            KhoaChinhSua();
        }
    }
}
