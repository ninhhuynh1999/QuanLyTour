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
    public partial class frChiTietTour : Form
    {
        private Tour curTour;
        private Gia curGia;
        private decimal doanhthu;
        private List<CTTour> listCT_Tour;
        private List<Gia> listGiaTour;
        private List<DiaDiem> listDiaDiem;
        private List<DiaDiem> listDiaDiem_Tour;
        private List<DoanDL> listDoanDL;
        private DataView dv_doanhthu;
        private List<LoaiCP> listLoaiCP;
        private List<ChiPhi> listChiPhi;

        /* public BindingList<DiaDiem> listĐiaiem_TourBindings;
         public BindingList<DiaDiem> listĐiaiemBindings;*/

        BindingList<Gia> listGia_TourBindings;
        private String TrangThai;

        public frChiTietTour()
        {
            InitializeComponent();
            TrangThai = "AddTour";
            this.Text = "Thêm Tour";

            listDiaDiem = DalDiaDiem.GetAllDiaDiem();
            listDiaDiem_Tour = new List<DiaDiem>();
            HienThiThongTin();


        }

        public frChiTietTour(Tour tour)
        {
            this.curTour = tour;
            InitializeComponent();

            HienThiThongTin();
            this.Text = "Chi tiết Tour " + curTour.Id;
            TrangThai = "Editable";
        }


        void HienThiThongTin()
        {
            loadDSLoaiTour();
            loadDiaDiem();
            loadGia();
            if (TrangThai != "AddTour")
            {
                LoadCacDoanThamGiaVaoTour();
                loadComboboxTHongKe();
                txId.Text = curTour.Id.ToString();
                txTenTour.Text = curTour.Ten.ToString().Trim();
                // txDacDiem.Text = curTour.DacDiem.ToString();
                cbLoaiTour.SelectedValue = curTour.MaLoaiTour;


                DisableEdit();

            }
            else
            {
                txId.Text = "-1";
                btSuaTour.Enabled = false;
                btXoaTour.Enabled = false;
                EnableEdit();
                DisableEditGia();
                DisableEdit_DD();

            }


        }
        void loadDSLoaiTour()
        {

            List<LoaiTour> result = DalTour.GetAllLoaiTour();

            cbLoaiTour.DropDownStyle = ComboBoxStyle.DropDownList;
            cbLoaiTour.DataSource = result;

            cbLoaiTour.DisplayMember = "Ten";
            cbLoaiTour.ValueMember = "Id";

            //cbLoaiTour.SelectedValue = 4;
        }

        void loadDiaDiem()
        {
            listDiaDiem = DalDiaDiem.GetAllDiaDiem();
            listBoxPhai.Items.Clear();
            listBoxTrai.Items.Clear();
            if (TrangThai == "AddTour")
            {
                foreach (DiaDiem diaDiem in listDiaDiem)
                {
                    if (!listDiaDiem_Tour.Contains(diaDiem))
                    {
                        listBoxTrai.Items.Add(diaDiem);
                    }
                }

                listBoxTrai.DisplayMember = "Ten";
                listBoxTrai.ValueMember = "Id";
                listBoxPhai.DisplayMember = "Ten";
                listBoxPhai.ValueMember = "Id";
            }
            else
            {
                listDiaDiem_Tour = DalTour.GetDiaDiemByTour(curTour);
                foreach (DiaDiem diaDiem in listDiaDiem_Tour)
                {
                    listBoxPhai.Items.Add(diaDiem);
                    listDiaDiem.RemoveAll(s => s.Id == diaDiem.Id);
                }


                foreach (DiaDiem diaDiem in listDiaDiem)
                {
                    if (!listDiaDiem_Tour.Contains(diaDiem))
                    {
                        listBoxTrai.Items.Add(diaDiem);
                    }
                }

                listBoxTrai.DisplayMember = "Ten";
                listBoxTrai.ValueMember = "Id";
                listBoxPhai.DisplayMember = "Ten";
                listBoxPhai.ValueMember = "Id";

                if (listBoxTrai.Items.Count > 0)
                    listBoxTrai.SetSelected(0, true);
                if (listBoxPhai.Items.Count > 0)
                    listBoxPhai.SetSelected(0, true);
            }

            //listĐiaiemBindings = new BindingList<DiaDiem>(listDiaDiem);
            // listBoxTrai.DataSource = listĐiaiemBindings;
            /* listBoxTrai.DisplayMember = "Ten";
             listBoxTrai.ValueMember = "Id";*/

            //listBoxTrai.SelectedValue = 3;

            //mattour = 1
            /*if (Id != 0)
            {

            }*/
        }

        void loadGia()
        {
            DisableEditGia();
            if (TrangThai == "AddTour")
            {

                btSuaGia.Enabled = false;
                btXoaGia.Enabled = false;

            }
            else
            {
                listGiaTour = DalTour.GetGiaByTour(curTour);
                listGia_TourBindings = new BindingList<Gia>(listGiaTour);
                //dgvGia.AutoGenerateColumns = false;
                dgvGia.DataSource = listGia_TourBindings;
                dgvGia.Columns[0].HeaderText = "Id";
                dgvGia.Columns[2].HeaderText = "Ngay Bat Dau";
                dgvGia.Columns[3].HeaderText = "Ngay Ket Thuc";
                dgvGia.Columns[1].HeaderText = "Gia";
                dgvGia.Columns["MaTour"].Visible = false;
                dgvGia.Columns["Tour"].Visible = false;


            }


        }
        void loadCurGia(Gia gia)
        {
            txGia.Text = gia.Gia1.ToString();
            dateTimePickerBD.Value = gia.BatDau;
            dateTimePickerKT.Value = gia.KetThuc;
        }
        public void EnableEdit()
        {
            txId.ReadOnly = true;

            txTenTour.ReadOnly = false;
            cbLoaiTour.Enabled = true;


            btSuaTour.Enabled = false;
            btXoaTour.Enabled = false;

            btThemTour.Visible = true;
            btReset.Visible = true;
        }
        public void DisableEdit()
        {
            txId.ReadOnly = true;

            txTenTour.ReadOnly = true;

            cbLoaiTour.Enabled = false;

            btSuaTour.Enabled = true;
            btXoaTour.Enabled = true;

            btThemTour.Visible = false;
            btReset.Visible = false;

        }
        public void DisableEdit_DD()
        {
            btDiaDiemAdd.Enabled = false;
            btDiaDiemRemove.Enabled = false;
            btLuuDD.Enabled = false;
            btHuyDD.Enabled = false;
        }
        public void EnableEdit_DD()
        {
            btDiaDiemAdd.Enabled = true;
            btDiaDiemRemove.Enabled = true;
            btLuuDD.Enabled = true;
            btHuyDD.Enabled = true;
        }
        void DisableEditGia()
        {
            txGia.ReadOnly = true;
            dateTimePickerBD.Enabled = false;
            dateTimePickerKT.Enabled = false;
            dgvGia.Enabled = true;

            btThemGia.Enabled = true;
            btSuaGia.Enabled = true;
            btXoaGia.Enabled = true;
            btHuyGia.Visible = false;
            btLuuGia.Visible = false;
        }
        void EnableEditGia()
        {
            txGia.ReadOnly = false;
            dateTimePickerBD.Enabled = true;
            dateTimePickerKT.Enabled = true;
            dgvGia.Enabled = false;

            btThemGia.Enabled = false;
            btSuaGia.Enabled = false;
            btXoaGia.Enabled = false;
            btHuyGia.Visible = true;
            btLuuGia.Visible = true;


        }
        private void btSuaTour_Click(object sender, EventArgs e)
        {
            EnableEdit();
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            if (TrangThai == "AddTour")
            {
                this.Close();
            }
            DisableEdit();
            loadDSLoaiTour();
            HienThiThongTin();
        }

        private void btThemTour_Click(object sender, EventArgs e)
        {
            if (!txTenTour.Text.Equals(""))
            {
                Tour tour_tmp = new Tour();
                tour_tmp.Id = int.Parse(txId.Text);
                tour_tmp.Ten = txTenTour.Text.Trim();
                tour_tmp.MaLoaiTour = int.Parse(cbLoaiTour.SelectedValue.ToString());
                Console.WriteLine(tour_tmp.Id + tour_tmp.Ten + tour_tmp.MaLoaiTour);

                if (TrangThai == "Editable")
                {
                    tour_tmp.updated = true;
                }
                tour_tmp.Save();
                tour_tmp.updated = false;

                if (TrangThai == "AddTour")
                {
                    TrangThai = "Editable";
                }
                curTour = tour_tmp;
                HienThiThongTin();
                DisableEdit();
                EnableEdit_DD();
            }
            else
            {
                MessageBox.Show("Hãy nhập tên Tour", "Lỗi nhập dữ liệu",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btDiaDiemAdd_Click(object sender, EventArgs e)
        {
            if (listBoxTrai.SelectedItems.Count > 0)
            {


                listBoxPhai.Items.Add((DiaDiem)listBoxTrai.SelectedItem);
                listDiaDiem.Remove((DiaDiem)listBoxTrai.SelectedItem);
                listDiaDiem_Tour.Add((DiaDiem)listBoxTrai.SelectedItem);
                listBoxTrai.Items.Remove((DiaDiem)listBoxTrai.SelectedItem);
            }



        }

        private void btDiaDiemRemove_Click(object sender, EventArgs e)
        {
            if (listBoxPhai.SelectedItems.Count > 0)
            {


                listBoxTrai.Items.Add((DiaDiem)listBoxPhai.SelectedItem);


                listDiaDiem.Add((DiaDiem)listBoxPhai.SelectedItem);
                listDiaDiem_Tour.Remove((DiaDiem)listBoxPhai.SelectedItem);
                listBoxPhai.Items.Remove((DiaDiem)listBoxPhai.SelectedItem);
            }

        }

        private void btThemGia_Click(object sender, EventArgs e)
        {
            if (TrangThai != "AddTour")
            {
                Gia gia = new Gia();
                gia.MaTour = curTour.Id;
                gia.BatDau = dateTimePickerBD.Value;
                gia.KetThuc = dateTimePickerKT.Value;
                gia.Gia1 = decimal.Parse(txGia.Text);
                gia.Id = -1;
                if (btThemGia.Text == "Lưu")
                {
                    gia.updated = true;
                    gia.Id = listGiaTour[dgvGia.CurrentCell.RowIndex].Id;
                }
                gia.Save();
                dgvGia.DataSource = null;
                loadGia();
                btThemGia.Text = "Thêm";
            }


        }

        private void dgvGia_SelectionChanged(object sender, EventArgs e)
        {
            int curIndex = listGiaTour.IndexOf(curGia);
            if (listGiaTour.Count > 0)
            {
                //Console.WriteLine("vao trong if");
                // set new cur DD

                curGia = listGiaTour[dgvGia.CurrentRow.Index];
            }
            if (curIndex != -1)
            {
                curGia = listGiaTour[curIndex];
            }


            foreach (DataGridViewRow row in dgvGia.SelectedRows)
            {
                txGia.Text = row.Cells[1].Value.ToString();
                dateTimePickerBD.Value = Convert.ToDateTime(row.Cells[2].Value.ToString());
                dateTimePickerKT.Value = Convert.ToDateTime(row.Cells[3].Value.ToString());
            }

        }

        private void btSuaGia_Click(object sender, EventArgs e)
        {
            if (dgvGia.SelectedRows.Count > 0)
            {
                EnableEditGia();
                btLuuGia.Text = "Lưu";
            }
        }

        private void btHuyGia_Click(object sender, EventArgs e)
        {
            DisableEditGia();

            loadCurGia(curGia);
        }

        private void btThemGia_Click_1(object sender, EventArgs e)
        {
            EnableEditGia();
            txGia.Text = "";

        }

        private void btXoaGia_Click(object sender, EventArgs e)
        {
            if (dgvGia.SelectedRows.Count > 0)
            {
                int i = listGiaTour.IndexOf(curGia);
                Console.WriteLine("xao  gia thu" + i);
                curGia.Delete();

                if (i == listGiaTour.Count - 1)
                {
                    curGia = listGiaTour[i];
                    dgvGia.Rows[i].Selected = true;
                }
                else
                {
                    if (listGiaTour.Count > 0)
                    {
                        curGia = listGiaTour[i];
                        dgvGia.Rows[i].Selected = true;

                    }

                }
                listGiaTour.Remove(curGia);
                loadGia();


            }
        }

        private void dgvGia_Click(object sender, EventArgs e)
        {
            curGia = listGiaTour[dgvGia.CurrentCell.RowIndex];

        }

        private void btLuuDD_Click(object sender, EventArgs e)
        {
            int tt = 1;
            curTour.DeleteAllChiTietTour();
            foreach (DiaDiem diaDiem in listDiaDiem_Tour)
            {
                Console.WriteLine(diaDiem.Id + "%%" + diaDiem.Ten);
                CTTour temp = new CTTour() { MaDiaDiem = diaDiem.Id, MaTour = curTour.Id, ThuTu = tt };
                tt++;
                temp.Save();
            }
            MessageBox.Show("Lưu chi tiết tour", "Thành công",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btHuyDD_Click(object sender, EventArgs e)
        {
            loadDiaDiem();
        }
        public void LoadCacDoanThamGiaVaoTour()
        {
            listDoanDL = curTour.GetDoanDL();
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã đoàn");
            dt.Columns.Add("Tên Đoàn");
            dt.Columns.Add("Ngày bắt đầu");
            dt.Columns.Add("Ngày kết thúc");
            dt.Columns.Add("Giá");
            dt.Columns.Add("Số khách");
            dt.Columns.Add("Tổng chi phí");

            CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");   // try with "en-US"
            doanhthu = 0;
            foreach (DoanDL doanDL in listDoanDL)
            {
                doanDL.GetChiPhiDoan();
                doanDL.GetCTDoanByDoan();
                int sl = doanDL.GetKhachDoan().Count;
                doanhthu += doanDL.TinhDoanhThu();
                string gia = String.Format(cul, "{0:c}", doanDL.Gia);
                string chiphi = String.Format(cul, "{0:c}", doanDL.GetTongChiPhi());

                dt.Rows.Add(doanDL.Id, doanDL.Ten,doanDL.KhoiHanh.Value.ToString("dd/MM/yyyy"), doanDL.KetThuc.Value.ToString("dd/MM/yyyy"), gia,sl,chiphi);
            }
            dv_doanhthu = new DataView(dt);

            dgvDoanhThu.DataSource = dv_doanhthu;
            dgvDoanhThu.Refresh();
            dgvDoanhThu.Update();
            dgvDoanhThu.AutoGenerateColumns = false;

            string a = String.Format(cul, "{0:c}", doanhthu);

            lbDoanhThu.Text = a;
            lbSoLuongDoan.Text = listDoanDL.Count.ToString();
        }

        private void btTim_Doanhthu_Click(object sender, EventArgs e)
        {
            //Console.WriteLine(dateBD_doanhthu.Value.Date+", "+ dateKT_doanhthu.Value.Date);
            // Console.WriteLine("[Ngày bắt đầu] >= '{0:dd/MM/yyyy}' AND [Ngày bắt đầu] <= '{1:dd/MM/yyyy}' ", dateBD_doanhthu.Value.Date, dateKT_doanhthu.Value.Date);
            CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");   // try with "en-US"
            decimal doanhthu1 = 0;

            dv_doanhthu.RowFilter = string.Format("[Ngày bắt đầu] >= '{0:dd/MM/yyyy}' AND [Ngày bắt đầu] <= '{1:dd/MM/yyyy}' ", dateBD_doanhthu.Value.Date, dateKT_doanhthu.Value.Date);
            dgvDoanhThu.DataSource = dv_doanhthu;
            dgvDoanhThu.Refresh();
            dgvDoanhThu.Update();
            for(int i = 0; i< dgvDoanhThu.Rows.Count; i++)
            {
                DoanDL result = listDoanDL.Select(x => x).Where(d => d.Id== int.Parse(dgvDoanhThu.Rows[i].Cells[0].Value.ToString())).FirstOrDefault();
                doanhthu1 += result.TinhDoanhThu();
            }
            lbSoLuongDoan.Text = dgvDoanhThu.Rows.Count+"";
            lbDoanhThu.Text = String.Format(cul, "{0:c}", doanhthu1);

        }

        private void btHuy_doanhthu_Click(object sender, EventArgs e)
        {
            CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");   // try with "en-US"

            dv_doanhthu.RowFilter = null;
            dgvDoanhThu.DataSource = dv_doanhthu;
            dgvDoanhThu.Refresh();
            dgvDoanhThu.Update();
            lbSoLuongDoan.Text = listDoanDL.Count.ToString();
            lbDoanhThu.Text = String.Format(cul, "{0:c}",doanhthu );
        }
        public void loadComboboxTHongKe()
        {
            listLoaiCP = DalLoaiCP.GetAllLoaiCP();
            cbLoaiCP_ThongKe.Items.Add("0. Tất cả loại chi phí");

            foreach (LoaiCP loai in listLoaiCP)
            {
                cbLoaiCP_ThongKe.Items.Add(loai.Id + ". " + loai.Ten);
            }
            if (cbLoaiCP_ThongKe.Items.Count > 0) cbLoaiCP_ThongKe.SelectedIndex = 0;
            listChiPhi = DalChiPhi.GetChiPhiByLoaiCP(listLoaiCP[cbLoaiCP_ThongKe.SelectedIndex]);
            loadThongKe(listChiPhi);
            
        }
        public void loadThongKe(List<ChiPhi> danhsach)
        {
            CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");   // try with "en-US"

            DataTable dt = new DataTable();
            dt.Columns.Add("Mã đoàn");
            dt.Columns.Add("Tên đoàn");
            dt.Columns.Add("Chi phí");

            decimal tongchiphi = 0;
            foreach (ChiPhi chiphi in danhsach)
            {
                string gia = String.Format(cul, "{0:c}", chiphi.GiaTien);

                DoanDL doan = chiphi.GetDoanDL();
                dt.Rows.Add(chiphi.MaDoan, doan.Ten.Trim(), gia);
                tongchiphi += (decimal)chiphi.GiaTien;
            }

            lbThongKe.Text = String.Format(cul, "{0:c}", tongchiphi);
            DataView dv = new DataView(dt);
            dgv_ThongKe.DataSource = dv;
            dgv_ThongKe.Refresh();
            dgv_ThongKe.Update();
            dgv_ThongKe.AutoGenerateColumns = false;
        }

        private void btTim_ThongKe_Click(object sender, EventArgs e)
        {
            
            listChiPhi = DalChiPhi.GetChiPhiByLoaiCP(listLoaiCP[cbLoaiCP_ThongKe.SelectedIndex]);
            loadThongKe(listChiPhi);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<ChiPhi> listChiPhi_search = new List<ChiPhi>();
            foreach (ChiPhi chiphi in listChiPhi)
            {
                DoanDL doan = chiphi.GetDoanDL();
                int result1 = DateTime.Compare((DateTime)doan.KhoiHanh, dateDB_ThongKe.Value);
                int result2 = DateTime.Compare((DateTime)doan.KhoiHanh, dateKT_ThongKe.Value);



                if (result1 >= 0 && result2 <= 0)
                {
                    listChiPhi_search.Add(chiphi);
                }
            }
            //listChiPhi = temp;
            loadThongKe(listChiPhi_search);
        }
    }
}
