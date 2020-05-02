using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business
{
    public class B_InputOutput
    {
        //Metodo para listar los datos
        public List<InputOutputEntity> OutputList()
        {
            using (var db = new InventaryContext())
            {
                return db.InOuts.ToList();
            }
        }

        //Metodo para agregar y guardar los datos
        public void CreateOutput(InputOutputEntity oOutput)
        {
            using (var db = new InventaryContext())
            {
                db.InOuts.Add(oOutput);
                db.SaveChanges();
            }
        }


        //Metodo para actualizar y guardar los datos
        public void UpdateOutput(InputOutputEntity oOutput)
        {
            using (var db = new InventaryContext())
            {
                db.InOuts.Update(oOutput);
                db.SaveChanges();
            }
        }
    }
}
