using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business
{
    public class B_WareHouses
    {
        public static List<WareHousesEntity> WareHousesList()
        {
            using (var db = new InventaryContext())
            {
                return db.WareHouses.ToList();
            }
        }

        public static void CretateWareHouses(WareHousesEntity OWareHouses)
        {
            using (var db = new InventaryContext())
            {
                db.WareHouses.Add(OWareHouses);
                db.SaveChanges();
            }
        }
        public static void UpdateStorage(WareHousesEntity OWareHouses)
        {
            using (var db = new InventaryContext())
            {
                db.WareHouses.Update(OWareHouses);
                db.SaveChanges();
            }
        }
    }
}
