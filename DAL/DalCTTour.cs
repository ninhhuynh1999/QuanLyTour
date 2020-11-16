using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace QuanLyDuLich.DAL
{
    public class DalCTTour
    {
        public static void Insert(CTTour cttour)
        {
            using (var db = new tourEntities())
            {
                db.CTTours.Add(cttour);
                db.SaveChanges();
            }
        }
        public static void Update(CTTour cttour)
        {
            using (var db = new tourEntities())
            {
                db.Entry(cttour).State = EntityState.Modified;
                db.SaveChanges();
            }
        }
        public static void Delete(CTTour cttour)
        {
            using (var db = new tourEntities())
            {

                var result = (from c in db.CTTours where c.MaDiaDiem == cttour.MaDiaDiem &&  c.MaTour == cttour.MaTour select c).First();
                db.CTTours.Remove(result);
                db.SaveChanges();

            }
        }
        
        

    }
}
