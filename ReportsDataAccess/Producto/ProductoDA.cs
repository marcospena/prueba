using ReportsBusinessEntity;
using ReportsUtilitarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportsDataAccess.Producto
{
    public class ProductoDA
    {
        public PROt09_producto ObtenerPrimerProducto()
        {
            var producto = new PROt09_producto();
            using (var db = new EagleContext())
            {
                try
                {
                    producto = db.PROt09_producto.First();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Búsqueda Primer Producto: ", e.Message);
                }
            }
            return producto;
        }
        public PROt09_producto ObtenerUltimoProducto()
        {
            var producto = new PROt09_producto();
            using (var db = new EagleContext())
            {
                try
                {
                    var lista = db.PROt09_producto.OrderByDescending(x => x.id_producto).Take(1).ToList();
                    producto = lista[0];
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Búsqueda Ultimo Producto: ", e.Message);
                }
            }
            return producto;
        }

        public PROt09_producto BuscarProducto(int id)
        {
            var producto = new PROt09_producto();

            using (var db = new EagleContext())
            {
                try
                {
                    producto = db.PROt09_producto.Find(id);
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Búsqueda Producto por ID: ", e.Message);
                }
            }
            return producto;
        }

        public List<PROt09_producto> ListarProducto()
        {
            var lista = new List<PROt09_producto>();
            using (var db = new EagleContext())
            {
                try
                {
                    lista = db.PROt09_producto.Where(x => x.id_estado != 0).ToList();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Lista Producto: ", e.Message);
                }
            }
            return lista;
        }
    }
}
