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
using System.Globalization;

namespace QuanLyDuLich.View
{
    public partial class DanhSachDoanDuLich : UserControl
    {
        private DoanDL curDoanDL= new DoanDL();
        private List<DoanDL> listDoanDL = new List<DoanDL>();
        private DataTable dt;
        private DataView dv;
        public DanhSachDoanDuLich()
        {
            InitializeComponent();
            loadDSDoanDL();
        }
        
        

        public void loadDSDoanDL()
        {
            dt = new DataTable();
            dt.Columns.Add("Mã Đoàn du lịch");
            dt.Columns.Add("Tên Đoàn");
            dt.Columns.Add("Ngày Khởi hành");
            dt.Columns.Add("Ngày kết thúc");
            dt.Columns.Add("Giá");
            dt.Columns.Add("Mã tour");
            //dt.Columns.Add("Tên tour");

            CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");   // try with "en-US"

            listDoanDL = DalDoanDL.GetAllDoanDL();
            foreach (DoanDL doanDL in listDoanDL)
            {
                                                                         //    string a = gia_temp.Gia1.ToString("#,###", cul.NumberFormat);
                string a = String.Format(cul, "{0:c}", doanDL.Gia);
                dt.Rows.Add(doanDL.Id, doanDL.Ten, doanDL.KhoiHanh.GetValueOrDefault().ToShortDateString(),doanDL.KetThuc.GetValueOrDefault().ToShortDateString(), a.Replace(",00", ""), doanDL.MaTour);
            }
            dv = new DataView(dt);

            dataGridView1.DataSource = dv;
            dataGridView1.Refresh();
            dataGridView1.Update();
            dataGridView1.AutoGenerateColumns = false;

            //    dataGridView1.Columns["DoanDLs"].Visible = false;
            // dataGridView1.Columns.Remove("DoanDLs");



            List<String> ColNameList = new List<String>();
            ColNameList.Add("Tất cả");

            int i = 1;
            foreach (DataColumn c in dt.Columns)
            {
                ColNameList.Add(c.ColumnName);
                /*if(i++ >= 3)
                {
                    break;
                }*/
            }


            String[] ColNameArray = ColNameList.ToArray();

            comboBox1.Items.AddRange(ColNameArray);
            if (comboBox1.Items.Count > 0) comboBox1.SelectedIndex = 0;
            //   curTour = (listTour != null) ? listTour[0] : null;
        }



        private void btSua_Click(object sender, EventArgs e)
        {
            if (curDoanDL != null)
            {
                FormThemDoan formThemDoan = new FormThemDoan(curDoanDL);
                formThemDoan.ShowDialog();
                loadDSDoanDL();
            }
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            FormThemDoan formThemDoan = new FormThemDoan();
            formThemDoan.ShowDialog();
            loadDSDoanDL();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                curDoanDL = listDoanDL[dataGridView1.CurrentCell.RowIndex];
                Console.WriteLine(curDoanDL.Ten);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Tất cả")
            {
                String s = "";
                for (int i = 1; i < comboBox1.Items.Count; i++)
                {
                    if (i == comboBox1.Items.Count - 1)
                    {
                        s += "[" + comboBox1.GetItemText(comboBox1.Items[i]) + "]";
                        break;
                    }
                    s += "[" + comboBox1.GetItemText(comboBox1.Items[i]) + "] + ";

                }
                
                dv.RowFilter = string.Format(s + " Like '%{0}%'", textBox1.Text);
            }
            else
            {
                dv.RowFilter = string.Format("[" + comboBox1.Text + "]" + " Like '%{0}%'", textBox1.Text);
                Console.WriteLine(comboBox1.Text);

            }

            dataGridView1.DataSource = dv;
            dataGridView1.Refresh();
            dataGridView1.Update();
        }

        private void DanhSachDoanDuLich_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!(curDoanDL is null))
            {
                ChiTietDoanDL chiTietDoanDL = new ChiTietDoanDL(curDoanDL);
                chiTietDoanDL.ShowDialog();

            }
        }
    }
}
