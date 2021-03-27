using System;
using System.Collections.Generic;
using System.Text;
using Entities;
using DataAccess;
using System.Linq;

namespace Business
{
    public class B_Category
    {
        public static List<CategoryEntity> CategoryList()
        {
            //Esto significa que el cargo de Dato va a empezar y terminar 
            using (var db = new InventaryContext())
            {

                return db.Category.ToList();
            }

        }

        public static void CreateCategory(CategoryEntity OCategory)
        {
            using (var db = new InventaryContext())
            {
                db.Category.Add(OCategory);
                db.SaveChanges();
            }
        }

        public static void UpdateCategory(CategoryEntity OCategory)
        {
            using (var db = new InventaryContext())
            {
                db.Category.Update(OCategory);
                db.SaveChanges();
            }
        }

        public static CategoryEntity CategoryByID(string id)
        {
            using (var db = new InventaryContext())
            {
                return db.Category.ToList().LastOrDefault(c =>c.CategoryId == id.Trim());
            }
        }

    }
}
