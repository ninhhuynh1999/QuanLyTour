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
    public partial class ThongKeChiPhi : Form
    {
        CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");   // try with "en-US"

        private LoaiCP curLoaiCP;
        private List<DoanDL> listdoanDL;
        private List<ChiPhi> listChiPhi;
        private List<ChiPhi> listChiPhi_search;

        private List<LoaiCP> listLoaiCP;
        public ThongKeChiPhi()
        {
            InitializeComponent();
        }

        private void ThongKeChiPhi_Load(object sender, EventArgs e)
        {
            listLoaiCP = DalLoaiCP.GetAllLoaiCP();
           
            if(listLoaiCP.Count > 0)
            {
                curLoaiCP = listLoaiCP[0];
                listdoanDL = DalDoanDL.GetAllDoanDL();
                listChiPhi = DalChiPhi.GetChiPhiByLoaiCP(curLoaiCP);
            }
            loadDSLoaiCP();
            loadDSChiPhi(listChiPhi);

        }
        public void loadDSLoaiCP()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã loại chi phí");
            dt.Columns.Add("Tên loại Chi phí");
            foreach(LoaiCP loai in listLoaiCP)
            {
                dt.Rows.Add(loai.Id, loai.Ten.Trim());
            }
            DataView dv = new DataView(dt);

            dgvChiPhi.DataSource = dv;
            dgvChiPhi.Refresh();
            dgvChiPhi.Update();
            dgvChiPhi.AutoGenerateColumns = false;
        }
        public void loadDSChiPhi(List<ChiPhi> danhsach)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã đoàn");
            dt.Columns.Add("Tên đoàn");
            dt.Columns.Add("Giá tiền");

            decimal tongchiphi = 0;
            foreach (ChiPhi chiphi in danhsach)
            {
                string gia = String.Format(cul, "{0:c}", chiphi.GiaTien);

                DoanDL doan = listdoanDL.Select(x => x).Where(c => c.Id == chiphi.MaDoan).FirstOrDefault();
                 dt.Rows.Add(chiphi.MaDoan, doan.Ten.Trim(), gia);
                tongchiphi += (decimal)chiphi.GiaTien;
            }

            lbTongChiPhi.Text = String.Format(cul, "{0:c}", tongchiphi);
            DataView dv = new DataView(dt);
            dgvThongKe.DataSource = dv;
            dgvThongKe.Refresh();
            dgvThongKe.Update();
            dgvThongKe.AutoGenerateColumns = false;
        }

        private void btThongKe_Click(object sender, EventArgs e)
        {
            if (dgvChiPhi.Rows.Count > 0 && dgvChiPhi.CurrentCell.RowIndex < listLoaiCP.Count)
            {
                curLoaiCP = listLoaiCP[dgvChiPhi.CurrentCell.RowIndex];
            }
            listChiPhi = DalChiPhi.GetChiPhiByLoaiCP(curLoaiCP);
            loadDSChiPhi(listChiPhi);
        }

        private void dgvChiPhi_SelectionChanged(object sender, EventArgs e)
        {
            /*if(dgvChiPhi.Rows.Count > 0 && dgvChiPhi.CurrentCell.RowIndex < listLoaiCP.Count)
            {
                curLoaiCP = listLoaiCP[dgvChiPhi.CurrentCell.RowIndex];
            }*/
        }

        private void btLoc_Click(object sender, EventArgs e)
        {
            listChiPhi_search = new List<ChiPhi>();
            foreach (ChiPhi chiphi in listChiPhi)
            {                
                DoanDL doan = listdoanDL.Select(x => x).Where(c => c.Id == chiphi.MaDoan).FirstOrDefault();
                int result1 = DateTime.Compare((DateTime)doan.KhoiHanh, dateTimePicker1.Value);
                int result2 = DateTime.Compare((DateTime)doan.KhoiHanh, dateTimePicker2.Value);

                         

                if (result1 >= 0 && result2 <= 0)
                {
                    listChiPhi_search.Add(chiphi);
                }
            }
            //listChiPhi = temp;
            loadDSChiPhi(listChiPhi_search);
        }
    }
}
