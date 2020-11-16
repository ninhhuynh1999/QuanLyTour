using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDuLich.DAL
{
    class DalNguoi
    {
        public static void Insert(Nguoi nguoi)
        {
            using (var db = new tourEntities())
            {
                db.Nguois.Add(nguoi);
                db.SaveChanges();
            }
        }
        public static void Update(Nguoi nguoi)
        {
            using (var db = new tourEntities())
            {
                db.Entry(nguoi).State = EntityState.Modified;
                db.SaveChanges();
            }
        }
        public static void Delete(Nguoi nguoi)
        {
            using (var db = new tourEntities())
            {

                var result = (from c in db.Nguois where c.Id == nguoi.Id select c).First();
                db.Nguois.Remove(result);
                db.SaveChanges();

            }
        }
        public static Nguoi GetNguoiById(int Id)
        {
            using (var db = new tourEntities())
            {
                var result = from c in db.Nguois where c.Id == Id select c;
                return (Nguoi)result.FirstOrDefault();
            }

        }
        public static List<Nguoi> getKhach()
        {
            using (var db = new tourEntities())
            {
                var result = from c in db.Nguois where c.MaVaiTro == 1 select c;
                return result.ToList<Nguoi>();
            }

        }
        public static List<Nguoi> getNhanVien()
        {
            using (var db = new tourEntities())
            {
                var result = from c in db.Nguois where c.MaVaiTro == 2 select c;
                return result.ToList<Nguoi>();
            }

        }
        public static List<Nguoi> getAll()
        {
            using (var db = new tourEntities())
            {
                var result = from c in db.Nguois select c;
                return result.ToList<Nguoi>();
            }

        }
        public static List<Tour> getTourDaDi(Nguoi nguoi)
        {
            using (var db = new tourEntities())
            {
                List<CTDoan> result = (from c in db.CTDoans where c.MaNguoiThamGia == nguoi.Id select c).ToList();
                List<Tour> kq = new List<Tour>();
                foreach( CTDoan ct in result)
                {
                    kq.Add((from c in db.DoanDLs where c.Id == ct.MaDoan select c.Tour).FirstOrDefault());
                }
                return kq.Distinct().ToList<Tour>();
            }

        }
        public static List<DoanDL> getDoanDaDi(Nguoi nguoi)
        {
            using (var db = new tourEntities())
            {
                List<CTDoan> result = (from c in db.CTDoans where c.MaNguoiThamGia == nguoi.Id select c).ToList();
                List<DoanDL> kq = new List<DoanDL>();
                foreach (CTDoan ct in result)
                {
                    kq.Add((from c in db.DoanDLs where c.Id == ct.MaDoan select c).FirstOrDefault());
                }
                return kq.Distinct().ToList<DoanDL>();
            }

        }
    }
}
