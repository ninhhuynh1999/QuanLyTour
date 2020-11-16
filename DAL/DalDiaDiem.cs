
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDuLich.DAL
{
    public class DalDiaDiem
    {
        public static List<DiaDiem> GetAllDiaDiem()
        {
            using (var db = new tourEntities())
            {
                var result = from c in db.DiaDiems select c;
                return result.ToList<DiaDiem>();
            }

        }
        public static void Insert(DiaDiem diadiem)
        {
            using (var db = new tourEntities())
            {
                db.DiaDiems.Add(diadiem);
                db.SaveChanges();
            }
        }
        public static void Update(DiaDiem diadiem)
        {
            using (var db = new tourEntities())
            {
                db.Entry(diadiem).State = EntityState.Modified;
                db.SaveChanges();
            }
        }
        public static void Delete(DiaDiem diadiem)
        {
            using (var db = new tourEntities())
            {

                db.Entry(diadiem).State = EntityState.Deleted;
                db.SaveChanges();
            }
        }
        public static Boolean KiemtraXoa(DiaDiem diadiem)
        {
            using (var db = new tourEntities())
            {
                var result = from c in db.CTTours where c.MaDiaDiem == diadiem.Id select c;
                int sl  = result.ToList<CTTour>().Count;
                if (sl == 0)
                {
                    return true;
                }
                return false;
            }

        }


    }
}
