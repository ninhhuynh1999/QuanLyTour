using QuanLyDuLich.DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;

namespace QuanLyDuLich.DAL
{
    public class DalTour
    {
        
        public static List<Tour> getAllTour()
        {
            using (var db = new tourEntities())
            {
                    var result = db.Tours.ToList<Tour>();
                    return result;
            }
                
            
        }
        public static Tour getTourById(int Id)
        {
            using (var db = new tourEntities())
            {
                Tour result = (from c in db.Tours where c.Id == Id select c).First();
                return result;
            }
        }
        public static int getMaxIdTour()
        {
            using (var db = new tourEntities())
            {
                var result = (from c in db.Tours select c).Max(c => c.Id);
                return int.Parse(result.ToString());
            }
        }
        public static void Insert(Tour tour)
        {
            using (var db = new tourEntities())
            {
                db.Tours.Add(tour);
                db.SaveChanges();
            }
        }
        public static void Update(Tour tour)
        {
            using(var db= new tourEntities())
            {
                db.Entry(tour).State = EntityState.Modified;
                db.SaveChanges();
            }
        }
        public static void Delete(Tour tour)
        {
            using (var db = new tourEntities())
            {
                
                db.Entry(tour).State = EntityState.Deleted;
                db.SaveChanges();
            }
        }
        public static List<Gia> GetGiaByTour(Tour tour)
        {
            using (var db = new tourEntities())
            {
                var result = from c in db.Gias where c.MaTour == tour.Id select c;
                return result.ToList<Gia>();
            }
            
        }
        public static List<DiaDiem> GetDiaDiemByTour(Tour tour)
        {
            if (tour is null)
            {
                return null;
            }
            using (var db = new tourEntities())
            {
                var result = from c in db.CTTours  where c.MaTour == tour.Id orderby c.ThuTu /*ascending*/ select c.DiaDiem;
                return result.ToList<DiaDiem>();
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
        public static Gia GetCurrentGiaTour(Tour tour)
        {
            using (var db = new tourEntities())
            {
                DateTime startDateTime = DateTime.Today;
                var result = from c in db.Gias where c.MaTour == tour.Id && startDateTime >= c.BatDau && startDateTime <= c.KetThuc select c ;

                return result.FirstOrDefault();
            }

        }
        public static void DeleteChiTietTourByTour(Tour tour)
        {
            using (var db = new tourEntities())
            {

                var result = db.CTTours.Where(x => x.MaTour == tour.Id).ToList();
                foreach(CTTour cTTour in result)
                {
                    cTTour.Delete();
                }

            }
        }
        public static List<DoanDL> GetDoanDLCuaTour(Tour tour)
        {
            using (var db = new tourEntities())
            {
                var result = from c in db.DoanDLs where c.MaTour == tour.Id select c;
                return result.ToList<DoanDL>();
            }

        }
    }
}
