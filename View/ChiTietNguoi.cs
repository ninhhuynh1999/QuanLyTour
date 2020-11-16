using QuanLyDuLich.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDuLich.View
{
    public partial class Form1 : Form
    {
        private Nguoi curNguoi;
        private List<Tour> listTour;
        private List<DoanDL> listDoan;
        private List<LoaiTour> listLoaiTour;
        private DataView dv_tour;
        private DataView dv_doan;

        public Form1()
        {
            InitializeComponent();
        }
        public Form1(Nguoi nguoi)
        {
            curNguoi = nguoi;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listTour = curNguoi.GetTourDaDi();
            listDoan = curNguoi.GetDoanDaDi();
            listLoaiTour = DalLoaiTour.GetAllLoaiTour();
            
            loadDoan(listDoan);
        }
        
        public void loadDoan(List<DoanDL> danhsach)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Tên tour");
            dt.Columns.Add("Mã Đoàn");
            dt.Columns.Add("Tên Doàn");
            dt.Columns.Add("Ngày khởi hành");
            dt.Columns.Add("Ngày Kết thúc");
            dt.Columns.Add("Giá");
            cbSearch.Items.Clear();
            cbSearch.Items.Add("Tất cả");
            foreach (DataColumn dc in dt.Columns)
            {
                cbSearch.Items.Add(dc.ColumnName);
            }
            cbSearch.SelectedIndex = 0;

            foreach (DoanDL doan in danhsach)
            {
                dt.Rows.Add(listTour.Select(c => c).Where(x => x.Id == doan.MaTour).FirstOrDefault().Ten.Trim(), doan.Id, doan.Ten.Trim(), doan.KhoiHanh.Value.ToString("dd/MM/yyyy"), doan.KetThuc.Value.ToString("dd/MM/yyyy"), doan.Gia );
            }
            dv_doan = new DataView(dt);

            dgvDoan.DataSource = dv_doan;
            dgvDoan.Refresh();
            dgvDoan.Update();
            dgvDoan.AutoGenerateColumns = false;
            lbSL_Doan.Text = dgvDoan.Rows.Count.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<DoanDL> listĐoanL_search = new List<DoanDL>();
            foreach (DoanDL doan in listDoan)
            {
                
                int result1 = DateTime.Compare((DateTime)doan.KhoiHanh.Value.Date, dateBD_Doan.Value.Date);
                int result2 = DateTime.Compare((DateTime)doan.KhoiHanh.Value.Date, dateKT_Doan.Value.Date);



                if (result1 >= 0 && result2 <= 0)
                {
                    listĐoanL_search.Add(doan);
                }
            }
            //listChiPhi = temp;
            loadDoan(listĐoanL_search);
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            loadDoan(listDoan);
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            if (cbSearch.Text == "Tất cả")
            {
                String s = "";
                for (int i = 1; i < cbSearch.Items.Count; i++)
                {
                    if (i == cbSearch.Items.Count - 1)
                    {
                        s += "[" + cbSearch.GetItemText(cbSearch.Items[i]) + "]";
                        break;
                    }
                    s += "[" + cbSearch.GetItemText(cbSearch.Items[i]) + "] + ";

                }

                dv_doan.RowFilter = string.Format(s + " Like '%{0}%'", txSearch.Text);
            }
            else
            {
                dv_doan.RowFilter = string.Format("[" + cbSearch.Text + "]" + " Like '%{0}%'", txSearch.Text);
                // Console.WriteLine(cbSearchKhach.Text);

            }

            dgvDoan.DataSource = dv_doan;
            dgvDoan.Refresh();
            dgvDoan.Update();
            lbSL_Doan.Text = dgvDoan.Rows.Count + "";
        }

        private void txSearch_TextChanged(object sender, EventArgs e)
        {
            if(txSearch.Text.Trim() == "")
            {
                dv_doan.RowFilter = null;
                dgvDoan.DataSource = dv_doan;
                dgvDoan.Refresh();
                dgvDoan.Update();
            }
        }
    }
}
