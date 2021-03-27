using DataAccess;
using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business
{
    public class B_Storage
    {
        public static List<StorageEntity> StoragesList()
        {
            using (var db = new InventaryContext())
            {
                return db.Storages.ToList();
            }
        }

        public static void CretateStorage(StorageEntity OStorage)
        {
            using (var db = new InventaryContext())
            {
                db.Storages.Add(OStorage);
                db.SaveChanges();
            }
        }
        public static void UpdateStorage(StorageEntity OStorage)
        {
            using (var db = new InventaryContext())
            {
                db.Storages.Update(OStorage);
                db.SaveChanges();
            }
        }

        public static bool IsProductsInWareHouses(string idStorage)
        {
            using (var db = new InventaryContext())
            {
                var product = db.Storages.ToList().Where(p => p.StorageId == idStorage.Trim());
                return product.Any();
            }
        }

        public static List<StorageEntity> StoragesProductWareHouses(string idWareHouses)
        {
            using (var db = new InventaryContext())
            {
                return db.Storages.Include(s=>s.Product).Include(s=>s.HousesEntity).Where(w => w.WareHousesId == idWareHouses.Trim()).ToList();
            }
        }

    }
}
