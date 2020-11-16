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
    public partial class FormThemDoan : Form
    {
        private DoanDL curDoanDL;
        private List<Tour> listTour;
        private List<Gia> listGia;
        private decimal curGia;
        public FormThemDoan()
        {
            InitializeComponent();
            this.curDoanDL = new DoanDL();
            LoadTour();
        }
        public FormThemDoan(DoanDL doanDL)
        {
            
            InitializeComponent();
            this.Text = "Chỉnh sửa thông tin đoàn du lịch";
            this.curDoanDL = doanDL;
            LoadTour();
            loadDataDoan();
        }
        void LoadTour()
        {
            listTour = DalTour.getAllTour();
            foreach(Tour tour in listTour)
            {
                cbTour.Items.Add(tour.Id+". "+tour.Ten.Trim());
            }
            try
            {
               // cbTour.SelectedIndex = 0;
            }
            catch(Exception e)
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txTenDoan.Text == "")
            {
                MessageBox.Show("Tên doàn không được để trống!", "Lỗi:Tên doàn không được để trống!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            int result = DateTime.Compare(dateBatDau.Value, dateKetThuc.Value);
            if (result > 0)
            {
                //relationship = "is later than";
                MessageBox.Show("Ngày bắt đầu phải nhỏ hơn ngày kết thúc.", "Lỗi: Ngày bắt đầu lớn hơn ngày kết thúc!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (result == 0)
            {
                // relationship = "is the same time as";
                MessageBox.Show("Ngày bắt đầu và ngày kết thúc phải khác nhau", "Lỗi:Trùng ngày bắt đầu và ngày kết thúc!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            if(cbTour.SelectedIndex == -1)
            {
                MessageBox.Show("Hãy chọn Tour !!!!", "Lỗi: Chưa chọn Tour!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            // laays du lieu de luu
            if(this.Text == "Chỉnh sửa thông tin đoàn du lịch")
            {
                DoanDL doanDL = new DoanDL() { Id = curDoanDL.Id, KhoiHanh = dateBatDau.Value, KetThuc = dateKetThuc.Value, MaTour = listTour[cbTour.SelectedIndex].Id, Gia = curGia, Ten = txTenDoan.Text,  updated =true };
                doanDL.Save();
                if (doanDL.Id != -1)
                {
                    MessageBox.Show("Sửa thông tin Đoàn thành công. Trang sửa thông tin đoàn sẽ đóng!!!!", "Thông báo: Sửa thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            else
            {
                 DoanDL doanDL = new DoanDL() {  Id = -1, KhoiHanh = dateBatDau.Value,  KetThuc = dateKetThuc.Value, MaTour = listTour[cbTour.SelectedIndex].Id,  Gia = curGia, Ten = txTenDoan.Text  };
                 doanDL.Save();
                if (doanDL.Id != -1)
                {
                    MessageBox.Show("Thêm Đoàn thành công. Trang thêm đoàn sẽ đóng!!!!", "Thông báo: Thêm thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
           
            
        }



        private void cbTour_SelectedValueChanged(object sender, EventArgs e)
        {

            LayGia();

        }
        public void LayGia()
        {
            if (cbTour.SelectedIndex != -1)
            {
                //MessageBox.Show(listTour[cbTour.SelectedIndex].GetCurrentGiaTour().Gia1.ToString(), "Lỗi:Tour không có Giá !!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Tour tour_temp = listTour[cbTour.SelectedIndex];
                listGia = tour_temp.GetListGiaTour();
                if (listGia is null)
                {
                    MessageBox.Show("Tour này hiện chưa có Giá. Bạn cần thêm giá để chọn Tour này", "Lỗi:Tour không có Giá !!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cbTour.SelectedIndex = -1;
                    txGia.Text = "";

                }
                else
                {
                    Gia gia_temp = tour_temp.GetGiaByDatetime(dateBatDau.Value);
                    if (gia_temp is null)
                    {
                        MessageBox.Show("Tour này hiện chưa có Giá trong thời gian này. Bạn cần thêm giá để chọn Tour này", "Lỗi:Tour không có Giá trong thời gian này !!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cbTour.SelectedIndex = -1;
                        txGia.Text = "";
                    }
                    else
                    {
                        CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");   // try with "en-US"
                    //    string a = gia_temp.Gia1.ToString("#,###", cul.NumberFormat);
                        string a = String.Format(cul, "{0:c}", gia_temp.Gia1);
                        txGia.Text = a;
                        curGia = gia_temp.Gia1;
                        
                    }
                }
            }
        }
        public void loadDataDoan()
        {
            txTenDoan.Text = curDoanDL.Ten.Trim();
            dateBatDau.Value = (DateTime)curDoanDL.KhoiHanh;
            dateKetThuc.Value = (DateTime)curDoanDL.KetThuc;
            cbTour.SelectedIndex = listTour.IndexOf(listTour.Where(s => s.Id == curDoanDL.MaTour).FirstOrDefault());
        }

        private void dateBatDau_ValueChanged(object sender, EventArgs e)
        {
            LayGia();
        }
    }
}
