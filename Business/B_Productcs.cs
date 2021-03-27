using System;
using System.Collections.Generic;
using System.Text;
using Entities;
using DataAccess;
using System.Linq;

namespace Business
{
    public class B_Productcs
    {
        public static List<ProductEntity> ProductsList()
        {
            using (var db = new InventaryContext())
            {
                return db.Products.ToList();
            }
        }

        public static void CreateProduct(ProductEntity OProduct)
        {
            using (var db = new InventaryContext())
            {
                db.Products.Add(OProduct);
                db.SaveChanges();
            }
        }

        public static void UpdateProduct(ProductEntity OProduct)
        {
            using (var db = new InventaryContext())
            {
                db.Products.Update(OProduct);
                db.SaveChanges();
            }
        }

        public static ProductEntity ProductsById(string id)
        {
            using (var db = new InventaryContext())
            {
                return db.Products.ToList().LastOrDefault(p=>p.ProductId == id.Trim());
            }
        }
    }
}
