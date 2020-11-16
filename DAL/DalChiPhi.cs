using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDuLich.DAL
{
    class DalChiPhi
    {
        public static void Insert(ChiPhi chiPhi)
        {
            using (var db = new tourEntities())
            {
                db.ChiPhis.Add(chiPhi);
                db.SaveChanges();
            }
        }
        public static void Update(ChiPhi chiPhi)
        {
            using (var db = new tourEntities())
            {
                db.Entry(chiPhi).State = EntityState.Modified;
                db.SaveChanges();
            }
        }
        public static void Delete(ChiPhi chiPhi)
        {
            using (var db = new tourEntities())
            {

                var result = (from c in db.ChiPhis where c.Id == chiPhi.Id  select c).First();
                db.ChiPhis.Remove(result);
                db.SaveChanges();

            }
        }

        public static List<ChiPhi> GetChiPhiDoan(DoanDL doanDL)
        {
            using (var db = new tourEntities())
            {
                var result = (from c in db.ChiPhis where  c.MaDoan == doanDL.Id select c);
                return result.ToList<ChiPhi>();
            }

        }
        public static List<ChiPhi> GetChiPhiByLoaiCP(LoaiCP loaicp)
        {
            using (var db = new tourEntities())
            {
                var result = (from c in db.ChiPhis where c.LoaiChiPhi == loaicp.Id select c);
                return result.ToList<ChiPhi>();
            }
        }
        public static DoanDL GetDoanByChiPhi(ChiPhi chiphi)
        {
            using (var db = new tourEntities())
            {
                var result = from c in db.DoanDLs where c.Id == chiphi.MaDoan select c;
                return result.ToList<DoanDL>().FirstOrDefault();
            }

        }
        public static List<ChiPhi> GetChiPhiCuaTour(Tour tour)
        {
            using (var db = new tourEntities())
            {
                var result = from c in db.DoanDLs where c.MaTour == tour.Id select c;
                result.ToList<DoanDL>();
                List<ChiPhi> listchiphi = new List<ChiPhi>();
                foreach(DoanDL doan in result)
                {
                    var kq = from c in db.ChiPhis where c.MaDoan == doan.Id select c;
                    kq.ToList<ChiPhi>();
                    listchiphi.AddRange(kq);
                }
                return listchiphi;
            }

        }

    }
}
