using QuanLyDuLich.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDuLich.BIZ
{
    class ListNguoi
    {
        public static List<Nguoi> listNguoi;
        //public static List<Nguoi> listNv;
        //public static List<Nguoi> listKhach;
        public  ListNguoi()
        {
            listNguoi = DalNguoi.getAll();
        }
        public List<Nguoi> GetAll()
        {
            return listNguoi;
        }
        public List<Nguoi> GetKhach()
        {
            return listNguoi.Where(n => n.MaVaiTro == 1).ToList<Nguoi>();
        }
        public List<Nguoi> GetNhanVien()
        {
            return listNguoi.Where(n => n.MaVaiTro == 2).ToList<Nguoi>();
        }
        

    }
}
