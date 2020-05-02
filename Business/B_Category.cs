using Entities;
using System;
using System.Collections.Generic;
using System.Text;
using DataAccess;
using System.Linq;

namespace Business
{
    public class B_Category
    {
        //Metodo para listar los datos
        public static List<CategoryEntity> CategoryList()
        {
            using (var db = new InventaryContext())
            {
                return db.Categories.ToList();
            }
        }

        //Metodo para agregar y guardar los datos
        public static void CreateCategory(CategoryEntity oCategory)
        {
            using (var db = new InventaryContext())
            {
                db.Categories.Add(oCategory);
                db.SaveChanges();
            } 
        }


        //Metodo para actualizar y guardar los datos
        public static void UpdateCategory(CategoryEntity oCategory)
        {
            using (var db = new InventaryContext())
            {
                db.Categories.Update(oCategory);
                db.SaveChanges();
            }
        }
    }
}
