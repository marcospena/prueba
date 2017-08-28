using ReportsBusinessEntity;
using ReportsDataAccess.Producto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportsBusinessLogic.Producto
{
    public class ProductoBL
    {
        public PROt09_producto ObtenerPrimerProducto()
        {
            return new ProductoDA().ObtenerPrimerProducto();
        }
        public PROt09_producto ObtenerUltimoProducto()
        {
            return new ProductoDA().ObtenerUltimoProducto();
        }

        public PROt09_producto BuscarProducto(int id)
        {
            return new ProductoDA().BuscarProducto(id);
        }

        public List<PROt09_producto> ListarProducto()
        {
            return new ProductoDA().ListarProducto();
        }
    }
}
