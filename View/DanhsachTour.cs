using QuanLyDuLich.DAL;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data;

namespace QuanLyDuLich.View
{
    public partial class DanhsachTour : UserControl
    {
        private Tour curTour = new Tour();
        private List<Tour> listTour = new List<Tour>();
        private List<Tour> ListTourDel = new List<Tour>();
        private DataTable dt;
        private DataView dv;
        public DanhsachTour()
        {
            InitializeComponent();
            loadDSTour();
        }

        public void loadDSTour()
        {
            dt = new DataTable();
            dt.Columns.Add("Id");
            dt.Columns.Add("Tên Tour");
            dt.Columns.Add("Mã Loại Tour");

            listTour = DalTour.getAllTour();
            foreach(Tour tour in listTour)
            {
                dt.Rows.Add(tour.Id, tour.Ten, tour.MaLoaiTour);
            }
            dv = new DataView(dt);
          
            dataGridView1.DataSource = dv;
            dataGridView1.Refresh();
            dataGridView1.Update();
            dataGridView1.AutoGenerateColumns = false;

            //    dataGridView1.Columns["DoanDLs"].Visible = false;
            // dataGridView1.Columns.Remove("DoanDLs");


            comboBox1.Items.Clear();
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
            if (curTour != null)
            {
                frChiTietTour frChiTietTour = new frChiTietTour(curTour);
                frChiTietTour.ShowDialog();
                loadDSTour();
            }
        }

        private void btThem_Click(object sender, EventArgs e)
        {

            frChiTietTour frChiTietTour = new frChiTietTour();
            frChiTietTour.ShowDialog();
            loadDSTour();

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if(dataGridView1.Rows.Count > 0)
            {
                int dong = dataGridView1.CurrentCell.RowIndex;
                DataGridViewRow row = dataGridView1.Rows[dong];
                int id = int.Parse(row.Cells[0].Value.ToString());
                curTour = listTour.Select(c => c).Where(s => s.Id == id).FirstOrDefault();
                Console.WriteLine(curTour.Ten);
            }
       
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Tất cả")
            {
                String s = "";
                for (int i = 1;i < comboBox1.Items.Count; i++)
                {
                    if(i == comboBox1.Items.Count - 1)
                    {
                        s += "[" + comboBox1.GetItemText(comboBox1.Items[i]) + "]";
                        break;
                    }
                    s += "[" + comboBox1.GetItemText(comboBox1.Items[i]) + "] +";

                }
                dv.RowFilter = string.Format(s+" Like '%{0}%'", textBox1.Text);
            }
            else
            {
                dv.RowFilter = string.Format("[" + comboBox1.Text + "]" + " Like '%{0}%'", textBox1.Text);

            }

            dataGridView1.DataSource = dv;
            dataGridView1.Refresh();
            dataGridView1.Update();
        }

    }
}
