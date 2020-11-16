
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDuLich.DAL
{
    public class DalGiaTour
    {
        public static void Insert(Gia gia)
        {
            using (var db = new tourEntities())
            {
                db.Gias.Add(gia);
                db.SaveChanges();
            }
        }
        public static void Update(Gia gia)
        {
            using (var db = new tourEntities())
            {
                db.Entry(gia).State = EntityState.Modified;
                db.SaveChanges();
            }
        }
        public static void Delete(Gia gia)
        {
            using (var db = new tourEntities())
            {

                db.Entry(gia).State = EntityState.Deleted;
                db.SaveChanges();
            }
        }
    }
}
