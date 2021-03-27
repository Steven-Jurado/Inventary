using System;
using System.Collections.Generic;
using System.Text;
using Entities;
using DataAccess;
using System.Linq;

namespace Business
{
    public class B_InputOutput
    {
        public static List<InputOutputEntity> InputOutputsList()
        {
            using (var db = new InventaryContext())
            {
                return db.InputOutputs.ToList();
            }
        }

        public static void CreateInputOutput(InputOutputEntity OInputOutput)
        {
            using (var db = new InventaryContext())
            {
                db.InputOutputs.Add(OInputOutput);
                db.SaveChanges();
            }
        }

        public static void UpdateInputOutput(InputOutputEntity OInputOutput)
        {
            using (var db = new InventaryContext())
            {
                db.InputOutputs.Update(OInputOutput);
                db.SaveChanges();
            }
        }
    }
}
