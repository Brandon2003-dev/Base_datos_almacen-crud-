using Actividad_S9_Almacen_de_productos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AActividad_S9_Almacen_de_productos.DAO
{
    public class CrudProductos
    {
        public void AgregarProductos(Producto ParamProducto)
        {
            using (AlmacenContext db = new AlmacenContext())
            {
                Producto Producto = new Producto();
                Producto.Nombre = ParamProducto.Nombre;
                Producto.Descripcion = ParamProducto.Descripcion;
                Producto.Precio = ParamProducto.Precio;
                Producto.Stock = ParamProducto.Stock;
                db.Add(Producto);
                db.SaveChanges();
            }
        }
    }
}
