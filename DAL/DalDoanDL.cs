using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDuLich.DAL
{
    public class DalDoanDL
    {
        public static List<DoanDL> GetAllDoanDL()
        {
            using (var db = new tourEntities())
            {
                return db.DoanDLs.ToList<DoanDL>();
            }
        }
        public static void Insert(DoanDL doanDL)
        {
            using (var db = new tourEntities())
            {
                db.DoanDLs.Add(doanDL);
                db.SaveChanges();
            }
        }
        public static void Update(DoanDL doanDL)
        {
            using (var db = new tourEntities())
            {
                db.Entry<DoanDL>(doanDL).State = EntityState.Modified;
                db.SaveChanges();
            }
        }
        public static void Delete(DoanDL doanDL)
        {
            using (var db = new tourEntities())
            {

                db.Entry(doanDL).State = EntityState.Deleted;
                db.SaveChanges();
            }
        }
        public static List<CTDoan> GetCTDoanByDoan(DoanDL doanDL)
        {
            using (var db = new tourEntities())
            {
                var result = from c in db.CTDoans where c.MaDoan == doanDL.Id  select c;
                return result.ToList<CTDoan>();
            }
        }
        public static List<Nguoi> GetKhachFromDoan(DoanDL doanDL)
        {
            using (var db = new tourEntities())
            {
                var result = from c in db.CTDoans join n in db.Nguois on c.MaNguoiThamGia equals n.Id where n.MaVaiTro == 1 select n;
                return result.ToList<Nguoi>();

            }


        }
        public static List<Nguoi> GetNhanVienFromDoan(DoanDL doanDL)
        {
            using (var db = new tourEntities())
            {
                var result = from c in db.CTDoans join n in db.Nguois on c.MaNguoiThamGia equals n.Id where n.MaVaiTro == 2 select n;
                return result.ToList<Nguoi>();
            }
        }
        public static List<DoanDL> GetDoanByBatDau(DateTime dateTimeBD, DateTime dateTimeKT)
        {
            using (var db = new tourEntities())
            {
                var result = from c in db.DoanDLs where c.KhoiHanh >= dateTimeBD && c.KhoiHanh <= dateTimeKT select c;
                return result.ToList<DoanDL>();
            }

        }
    }
}
