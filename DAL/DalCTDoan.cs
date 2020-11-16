using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDuLich.DAL
{
    class DalCTDoan
    {
        public static void Insert(CTDoan ctDoan)
        {
            using (var db = new tourEntities())
            {
                db.CTDoans.Add(ctDoan);
                db.SaveChanges();
            }
        }
        public static void Update(CTDoan ctDoan)
        {
            using (var db = new tourEntities())
            {
                db.Entry(ctDoan).State = EntityState.Modified;
                db.SaveChanges();
            }
        }
        public static void Delete(CTDoan ctDoan)
        {
            using (var db = new tourEntities())
            {

                 var result = (from c in db.CTDoans where c.MaDoan== ctDoan.MaDoan && c.MaNguoiThamGia == ctDoan.MaNguoiThamGia select c).First();
                 db.CTDoans.Remove(result);
                 db.SaveChanges();

            }
        }
    }
}
