using QuanLyDuLich.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDuLich.View
{
    public partial class ChiTietDoanDL : Form
    {
        private DoanDL curDoanDL;
        private List<Nguoi> listNhanVien;
        private List<Nguoi> listKhach;
        private List<ChiPhi> listChiPhi;

        private List<LoaiCP> listloaiCP;
        List<Nguoi> khachs;
        List<Nguoi> nv ;

        private DataTable dt_nv;
        private DataView dv_nv;
        private DataTable dt_khach;
        private DataView dv_khach;
        private DataTable dt_cp;
        private DataView dv_cp;
        public ChiTietDoanDL()
        {
            InitializeComponent();
        }
        public ChiTietDoanDL(DoanDL doanDL)
        {
            this.curDoanDL = doanDL;

            InitializeComponent();

            /* this.curDoanDL = doanDL;
             curDoanDL.GetCTDoanByDoan();
             listKhach = curDoanDL.GetKhachDoan();
             listNhanVien = curDoanDL.GetNhanVienDoan();
             listChiPhi = curDoanDL.GetChiPhiDoan();
             loadKhach_Doan();
             loadNhanVien_Doan();
             khachs = DalNguoi.getKhach();
             nv = DalNguoi.getNhanVien();
             DataCombobox();*/
        }

        private void txVitriNhanVien_Click(object sender, EventArgs e)
        {
            if(txVitriNhanVien.Text == "Nhập vai trò của nhân viên")
            {
                txVitriNhanVien.Text = "";
            }
        }

        private void txVitriNhanVien_Leave(object sender, EventArgs e)
        {
            if(txVitriNhanVien.Text == "")
            {
                txVitriNhanVien.Text = "Nhập vai trò của nhân viên";
            }
        }
        public void loadKhach_Doan()
        {
            cbSearchThanhVien.SelectedIndex = 0;
            dgvKhach.DataSource = null;
            dgvKhach.Refresh();
            dgvKhach.Update();
            
            //  listNhanVien = curDoanDL.GetNhanVienDoan();
            

            dt_khach = new DataTable();
            dt_khach.Columns.Add("Mã Khách");
            dt_khach.Columns.Add("Tên Khách");
            foreach(Nguoi nguoi in listKhach)
            {
                dt_khach.Rows.Add(nguoi.Id, nguoi.Ten);
            }
            dv_khach = new DataView(dt_khach);
            dgvKhach.DataSource = dv_khach;
            dgvKhach.Refresh();
            dgvKhach.Update();
            dgvKhach.AutoGenerateColumns = false;
        }
        public void loadNhanVien_Doan()
        {

            dgvNhanVien.DataSource = null;
            dgvNhanVien.Refresh();
            dgvNhanVien.Update();
            //  listNhanVien = curDoanDL.GetNhanVienDoan();
            dt_nv = new DataTable();
            dt_nv.Columns.Add("Mã Nhân viên");
            dt_nv.Columns.Add("Tên Nhân viên");
            dt_nv.Columns.Add("Vị trí trong đoàn");

            foreach (Nguoi nguoi in listNhanVien)
            {
                dt_nv.Rows.Add(nguoi.Id, nguoi.Ten, curDoanDL.listCTDoan.Where(s => s.MaNguoiThamGia == nguoi.Id).FirstOrDefault().ChucVuTrongDoan);
            }
            dv_nv = new DataView(dt_nv);
            dgvNhanVien.DataSource = dv_nv;
            dgvNhanVien.Refresh();
            dgvNhanVien.Update();
            dgvNhanVien.AutoGenerateColumns = false;
        }
        public void DataCombobox()
        {
            cbNhanVien.Items.Clear();
            cbKhach.Items.Clear();

          
            foreach (Nguoi nguoi in listKhach)
            {
                khachs.RemoveAll(s => s.Id == nguoi.Id);

            }
            foreach (Nguoi nguoi in listNhanVien)
            {
                nv.RemoveAll(s => s.Id == nguoi.Id);

            }

            khachs = khachs.OrderBy(c => c.Id).ToList<Nguoi>();
            nv = nv.OrderBy(c => c.Id).ToList<Nguoi>();


            foreach (Nguoi nguoi in khachs)
            {
                
                    cbKhach.Items.Add(nguoi.Id + ". " + nguoi.Ten.Trim());
              
            }
            foreach (Nguoi nguoi in nv)
            {

                    cbNhanVien.Items.Add(nguoi.Id + ". " + nguoi.Ten.Trim());

            }
            cbKhach.SelectedIndex = (cbKhach.Items.Count > 0) ? 0 : -1;
            cbNhanVien.SelectedIndex = (cbNhanVien.Items.Count > 0)? 0 : -1;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((cbKhach.SelectedIndex < 0))
            {
                return;
            }
            CTDoan ctDoan = new CTDoan() { MaDoan = curDoanDL.Id, MaNguoiThamGia = khachs[cbKhach.SelectedIndex].Id, ChucVuTrongDoan = "Khách" };
            ctDoan.Save();
            listKhach.Add(khachs[cbKhach.SelectedIndex]);
            //Console.WriteLine(listKhach.Count);
            khachs.RemoveAt(cbKhach.SelectedIndex);
            DataCombobox();
            dgvKhach.DataSource = null;
            loadKhach_Doan();
            
        }

        private void btThemNhanVien_Click(object sender, EventArgs e)
        {
            if ((cbNhanVien.SelectedIndex < 0))
            {
                return;
            }
            CTDoan ctDoan = new CTDoan() { MaDoan = curDoanDL.Id, MaNguoiThamGia = nv[cbNhanVien.SelectedIndex].Id, ChucVuTrongDoan = txVitriNhanVien.Text };
            ctDoan.Save();
            curDoanDL.GetCTDoanByDoan();
            listNhanVien.Add(nv[cbNhanVien.SelectedIndex]);
            nv.RemoveAt(cbNhanVien.SelectedIndex);
            DataCombobox();
            loadNhanVien_Doan();
           
        }

        private void btXoaKhach_Click(object sender, EventArgs e)
        {
            if(dgvKhach.SelectedRows.Count > 0)
            {
                CTDoan ctDoan = new CTDoan() { MaDoan = curDoanDL.Id, MaNguoiThamGia = listKhach[dgvKhach.CurrentCell.RowIndex].Id,ChucVuTrongDoan="Khách"};
                ctDoan.Delete();
                khachs.Add(listKhach[dgvKhach.CurrentCell.RowIndex]);
                //Console.WriteLine(listKhach.Count);
                listKhach.RemoveAt(dgvKhach.CurrentCell.RowIndex);
                DataCombobox();
                dgvKhach.DataSource = null;
                loadKhach_Doan();
            }
        }
        private void btXoaNhanVien_Click(object sender, EventArgs e)
        {
            CTDoan ctDoan = new CTDoan() { MaDoan = curDoanDL.Id, MaNguoiThamGia = listNhanVien[dgvNhanVien.CurrentCell.RowIndex].Id };
            ctDoan.Delete();
            nv.Add(listNhanVien[dgvNhanVien.CurrentCell.RowIndex]);
            //Console.WriteLine(listKhach.Count);
            listNhanVien.RemoveAt(dgvNhanVien.CurrentCell.RowIndex);
            DataCombobox();
            dgvNhanVien.DataSource = null;
            loadNhanVien_Doan();
        }

        private void btTimThanhVien_Click(object sender, EventArgs e)
        {
            if (cbSearchThanhVien.Text == "Tất cả")
            {
              
                dv_khach.RowFilter = string.Format("[Tên Khách] Like '%{0}%'", txSearchThanhVien.Text);
                dv_nv.RowFilter = string.Format("[Tên Nhân viên] Like '%{0}%'", txSearchThanhVien.Text);

            }
            if(cbSearchThanhVien.Text == "Khách")
            {
                dv_khach.RowFilter = string.Format("[Tên Khách] Like '%{0}%'", txSearchThanhVien.Text);
            }
            if (cbSearchThanhVien.Text == "Nhân viên")
            {
                dv_khach.RowFilter = string.Format("[Tên Nhân viên] Like '%{0}%'", txSearchThanhVien.Text);
            }
            dgvKhach.DataSource = dv_khach;
            dgvKhach.Refresh();
            dgvKhach.Update();

            dgvNhanVien.DataSource = dv_nv;
            dgvNhanVien.Refresh();
            dgvNhanVien.Update();
        }

        private void txSearchThanhVien_TextChanged(object sender, EventArgs e)
        {
            if(txSearchThanhVien.Text == "")
            {
                dv_khach.RowFilter = string.Format("[Tên Khách] Like '%{0}%'", txSearchThanhVien.Text);
                dv_nv.RowFilter = string.Format("[Tên Nhân viên] Like '%{0}%'", txSearchThanhVien.Text);

                dgvKhach.DataSource = dv_khach;
                dgvKhach.Refresh();
                dgvKhach.Update();

                dgvNhanVien.DataSource = dv_nv;
                dgvNhanVien.Refresh();
                dgvNhanVien.Update();
            }
        }

        private void btResetThanhVien_Click(object sender, EventArgs e)
        {
            curDoanDL.GetCTDoanByDoan();
            listKhach = curDoanDL.GetKhachDoan();
            listNhanVien = curDoanDL.GetNhanVienDoan();
            loadKhach_Doan();
            loadNhanVien_Doan();
            khachs = DalNguoi.getKhach();
            nv = DalNguoi.getNhanVien();
            DataCombobox();
        }

        public void LoadChiPhi()
        {
            dgvChiChi.DataSource = null;
            dgvChiChi.Refresh();
            dgvChiChi.Update();
            
            dt_cp = new DataTable();
            dt_cp.Columns.Add("Id");

            dt_cp.Columns.Add("Loại Chi Phí ");
            dt_cp.Columns.Add("Mã đoàn");
            dt_cp.Columns.Add("Giá tiền");
            dt_cp.Columns.Add("Ghi chú");

            List<String> ColNameList = new List<String>();
            ColNameList.Add("Tất cả");

           // int i = 1;
            foreach (DataColumn c in dt_cp.Columns)
            {
                ColNameList.Add(c.ColumnName);
                /*if(i++ >= 3)
                {
                    break;
                }*/
            }


            String[] ColNameArray = ColNameList.ToArray();

            cbSearchChiPhi.Items.AddRange(ColNameArray);

            CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");   // try with "en-US"

            foreach (ChiPhi chiPhi in listChiPhi)
            {
                string a = String.Format(cul, "{0:c}", chiPhi.GiaTien);
                String s = listloaiCP.Where(ss => ss.Id == chiPhi.LoaiChiPhi).First().Ten.ToString().Trim();
                dt_cp.Rows.Add(chiPhi.Id, s, chiPhi.MaDoan, a, chiPhi.GhiChu);
            }
            dv_cp = new DataView(dt_cp);
            dgvChiChi.DataSource = dv_cp;
            dgvChiChi.Refresh();
            dgvChiChi.Update();
            dgvChiChi.AutoGenerateColumns = false;
        }

        private void ChiTietDoanDL_Load(object sender, EventArgs e)
        {
            curDoanDL.GetCTDoanByDoan();
            listKhach = curDoanDL.GetKhachDoan();
            listNhanVien = curDoanDL.GetNhanVienDoan();
            listChiPhi = curDoanDL.GetChiPhiDoan();
            LoaiCP loaiCP = new LoaiCP();
            listloaiCP = loaiCP.GetAllLoaiCP();
            khachs = DalNguoi.getKhach();
            nv = DalNguoi.getNhanVien();
            
            loadKhach_Doan();
            loadNhanVien_Doan();
            DataCombobox();
            LoadChiPhi();
            loadLoaiCP();
            TinhDoanhThu();
        }

        private void dgvChiChi_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvChiChi.Rows.Count < 1)
            {
                return;
            }
            if(dgvChiChi.SelectedRows.Count > 0)
            {
                if(listChiPhi.Count > 0 && dgvChiChi.CurrentCell.RowIndex <= (listChiPhi.Count -1) )
                {
                    ChiPhi temp = listChiPhi[dgvChiChi.CurrentCell.RowIndex];
                    tx_TT_GiaCP.Text = temp.GiaTien.ToString();
                    cb_TT_LoaiCP.SelectedValue = temp.LoaiChiPhi;
                    tx_TT_GhiChuCP.Text = temp.GhiChu;

                }

            }
        }
        public void loadLoaiCP()
        {
            cb_TT_LoaiCP.Items.Clear();
            cb_Them_LoaiCP.Items.Clear();

            /* foreach (LoaiCP loai in listloaiCP)
             {

             }*/
            List<LoaiCP> loaiCPs = listloaiCP;
            cb_TT_LoaiCP.DataSource = listloaiCP;
            cb_TT_LoaiCP.DisplayMember = "Ten";
            cb_TT_LoaiCP.ValueMember = "Id";

            cb_Them_LoaiCP.BindingContext = new BindingContext();
            cb_Them_LoaiCP.DataSource = loaiCPs;
            cb_Them_LoaiCP.DisplayMember = "Ten";
            cb_Them_LoaiCP.ValueMember = "Id";

            if (cb_TT_LoaiCP.Items.Count > 0)
            {
                cb_TT_LoaiCP.SelectedIndex = 0;
            }
            if (cb_Them_LoaiCP.Items.Count > 0)
            {
                cb_Them_LoaiCP.SelectedIndex = 0;
            }
            //   cb_TT_LoaiCP.SelectedValue = 3;


        }
        public void EnableEditChiPhi()
        {
            cb_TT_LoaiCP.Enabled = true;
            tx_TT_GiaCP.ReadOnly = false;
            tx_TT_GhiChuCP.ReadOnly = false;

            btLuuCP.Enabled = true;
            btHuyCP.Enabled = true;
            dgvChiChi.Enabled = false;
            btThemChiPhi.Enabled = false;
        }
        public void DisableEditChiphi()
        {
            cb_TT_LoaiCP.Enabled = false;
            tx_TT_GiaCP.ReadOnly = true;
            tx_TT_GhiChuCP.ReadOnly = true;

            dgvChiChi.Enabled = true;

            btLuuCP.Enabled = false;
            btHuyCP.Enabled = false;

            btThemChiPhi.Enabled = true;
        }

        private void cb_TT_LoaiCP_SelectedIndexChanged(object sender, EventArgs e)
        {
           // Console.WriteLine(cb_TT_LoaiCP.ValueMember);
        }

        private void btLuuCP_Click(object sender, EventArgs e)
        {
            ChiPhi curChiPhi = listChiPhi[dgvChiChi.CurrentCell.RowIndex];
            ChiPhi temp = new ChiPhi()
            {
                Id = curChiPhi.Id,
                LoaiChiPhi = int.Parse(cb_TT_LoaiCP.SelectedValue.ToString()),
                MaDoan = curDoanDL.Id,
                GiaTien = decimal.Parse(tx_TT_GiaCP.Text)  ,
                GhiChu = tx_TT_GhiChuCP.Text,
                updated = true
            };
            
            temp.Save();
            listChiPhi = curDoanDL.GetChiPhiDoan();
            DisableEditChiphi();
            LoadChiPhi();
            
        }

        private void btSuaChiPhi_Click(object sender, EventArgs e)
        {
            if (dgvChiChi.Rows.Count < 1)
            {
                return;
            }
            if (dgvChiChi.SelectedRows.Count > 0)
            {

                EnableEditChiPhi();

            }
        }

        private void btHuyCP_Click(object sender, EventArgs e)
        {

            DisableEditChiphi();
            ChiPhi temp = listChiPhi[dgvChiChi.CurrentCell.RowIndex];
            tx_TT_GiaCP.Text = temp.GiaTien.ToString();
            cb_TT_LoaiCP.SelectedValue = temp.LoaiChiPhi;
            tx_TT_GhiChuCP.Text = temp.GhiChu;
        }

        private void btXoaChiPhi_Click(object sender, EventArgs e)
        {
            if (dgvChiChi.Rows.Count < 1)
            {
                MessageBox.Show("Không có dữ liệu để xóa", "Lỗi: Không có dữ liệu để để xóa!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tx_TT_GiaCP.Text = "";
                tx_TT_GhiChuCP.Text = "";
                return;
            }
            if (dgvChiChi.SelectedRows.Count > 0)
            {
                if (listChiPhi.Count > 0 && dgvChiChi.CurrentCell.RowIndex <= (listChiPhi.Count - 1))
                {
                    ChiPhi temp = listChiPhi[dgvChiChi.CurrentCell.RowIndex];
                    temp.Delete();
                    listChiPhi.Remove(temp);
                    LoadChiPhi();
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu để xóa", "Lỗi: Không có dữ liệu để để xóa!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            
            
        }

        private void btThemChiPhi_Click(object sender, EventArgs e)
        {
            if(tx_Them_GiaTien.Text.Trim() == "")
            {
                MessageBox.Show("Mục thêm giá rỗng", "Lỗi: Không được để mục thêm giá RỖNG!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            ChiPhi chiphi = new ChiPhi() { Id = -1, LoaiChiPhi = int.Parse(cb_Them_LoaiCP.SelectedValue.ToString()), MaDoan = curDoanDL.Id, GhiChu = tx_Them_ghichu.Text, GiaTien = decimal.Parse(tx_Them_GiaTien.Text.ToString()) };
            chiphi.Save();
            listChiPhi.Add(chiphi);
            tx_Them_GiaTien.Text = "";
            tx_Them_ghichu.Text = "";

            LoadChiPhi();
        }

        private void tx_Them_GiaTien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void tx_TT_GiaCP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txSearchChiPhi_TextChanged(object sender, EventArgs e)
        {
            if (cbSearchChiPhi.Text == "Tất cả")
            {
                String s = "";
                for (int i = 1; i < cbSearchChiPhi.Items.Count; i++)
                {
                    if (i == cbSearchChiPhi.Items.Count - 1)
                    {
                        s += "[" + cbSearchChiPhi.GetItemText(cbSearchChiPhi.Items[i]) + "]";
                        break;
                    }
                    s += "[" + cbSearchChiPhi.GetItemText(cbSearchChiPhi.Items[i]) + "] + ";

                }

                dv_cp.RowFilter = string.Format(s + " Like '%{0}%'", txSearchChiPhi.Text);
            }
            else
            {
                dv_cp.RowFilter = string.Format("[" + cbSearchChiPhi.Text + "]" + " Like '%{0}%'", txSearchChiPhi.Text);
                Console.WriteLine(cbSearchChiPhi.Text);

            }

            dgvChiChi.DataSource = dv_cp;
            dgvChiChi.Refresh();
            dgvChiChi.Update();
        }
        public void TinhDoanhThu()
        {
            int sl = listKhach.Count;
            decimal gia = (decimal)curDoanDL.Gia;
            decimal tongchiphi = 0;
            CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");   // try with "en-US"
            string a = String.Format(cul, "{0:c}", gia);
            foreach (ChiPhi chiphi in listChiPhi)
            {
                tongchiphi += (decimal)chiphi.GiaTien;
            }
            string tongCP = String.Format(cul, "{0:c}", tongchiphi);

            txSoKhach_DoanhThu.Text = "" + sl;
            txGia_DoanhThu.Text = a;
            txTongCP_DoanhThu.Text = tongCP;
            decimal loinhuan = sl * gia - tongchiphi;
            string loiNhuan = String.Format(cul, "{0:c}", loinhuan);
            txLoiNhuan_DoanhThu.Text = "" + loiNhuan;
        }

        private void btTinhDoanhTHu_Click(object sender, EventArgs e)
        {
            TinhDoanhThu();
        }
    }
}
