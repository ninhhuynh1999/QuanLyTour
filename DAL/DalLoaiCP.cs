using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDuLich.DAL
{
    class DalLoaiCP
    {
        public static void Insert(LoaiCP loaiCP)
        {
            using (var db = new tourEntities())
            {
                db.LoaiCPs.Add(loaiCP);
                db.SaveChanges();
            }
        }
        public static void Update(LoaiCP loaiCP)
        {
            using (var db = new tourEntities())
            {
                db.Entry(loaiCP).State = EntityState.Modified;
                db.SaveChanges();
            }
        }
        public static void Delete(LoaiCP loaiCP)
        {
            using (var db = new tourEntities())
            {

                var result = (from c in db.LoaiCPs where c.Id == loaiCP.Id select c).First();
                db.LoaiCPs.Remove(result);
                db.SaveChanges();

            }
        }
        public static List<LoaiCP> GetAllLoaiCP()
        {
            using (var db = new tourEntities())
            {
                var result = (from c in db.LoaiCPs select c);
                return result.ToList<LoaiCP>();
            }

        }
        public String GetTenChiPhiById(int Id)
        {
            using (var db = new tourEntities())
            {
                var result = from c in db.LoaiCPs where c.Id == Id select c.Ten;
                return result.First().Trim();
            }

        }
        

    }
}
