
namespace QuanLyDuLich.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Nguoi
    {
        internal bool updated = false;

        public int Save()
        {
            if (Id == -1)
                DalNguoi.Insert(this);

            if (updated)
                DalNguoi.Update(this);

            return this.Id;
        }
        public void Delete()
        {
            DalNguoi.Delete(this);
        }
        public List<Tour> GetTourDaDi()
        {
            return DalNguoi.getTourDaDi(this);
        }
        public List<DoanDL> GetDoanDaDi()
        {
            return DalNguoi.getDoanDaDi(this);
        }
    }
}
