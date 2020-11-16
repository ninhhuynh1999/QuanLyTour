
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDuLich.DAL
{
    class DalLoaiTour
    {
        public static void Insert(LoaiTour loaiTour)
        {
            using (var db = new tourEntities())
            {
                db.LoaiTours.Add(loaiTour);
                db.SaveChanges();
            }
        }
        public static void Update(LoaiTour loaiTour)
        {
            using (var db = new tourEntities())
            {
                db.Entry(loaiTour).State = EntityState.Modified;
                db.SaveChanges();
            }
        }
        public static void Delete(LoaiTour loaiTour)
        {
            using (var db = new tourEntities())
            {
                var result = (from c in db.LoaiTours where c.Id == loaiTour.Id select c).First();
                db.LoaiTours.Remove(result);
                db.SaveChanges();

            }
        }
        public static List<LoaiTour> GetAllLoaiTour()
        {
            using (var db = new tourEntities())
            {
                var result = db.LoaiTours.ToList<LoaiTour>();

                return result.ToList<LoaiTour>();
            }

        }
    }
}
