using ReportsBusinessEntity;
using ReportsUtilitarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportsDataAccess.Reporte
{
    public class ReporteDA
    {
        public List<RPTt01_reporte> ListaReporte(int? id_estado = null)
        {
            var lista = new List<RPTt01_reporte>();
            using (var db = new EagleContext())
            {
                try
                {
                    if (id_estado == null)
                    {
                        lista = db.RPTt01_reporte.ToList();
                    }
                    else
                    {
                        lista = db.RPTt01_reporte.Where(x => x.id_estado == Estado.IdActivo).ToList();
                    }
                    
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Lista Reporte: ", e.Message);
                }
            }
            return lista;
        }
       
        public RPTt01_reporte BuscarReporte(int id)
        {
            var obj = new RPTt01_reporte();
            using (var db = new EagleContext())
            {
                try
                {
                    obj = db.RPTt01_reporte.Find(id);
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Búsqueda Reporte por ID: ", e.Message);
                }
            }
            return obj;
        }
        public RPTt01_reporte BuscarReporteXCod(string cod)
        {
            var obj = new RPTt01_reporte();
            using (var db = new EagleContext())
            {
                try
                {
                    obj = db.RPTt01_reporte.SingleOrDefault(x => x.cod_reporte == cod);
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Búsqueda Reporte por COD: ", e.Message);
                }
            }
            return obj;
        }
        public RPTt01_reporte BuscarReporteXCat(int id)
        {
            var obj = new RPTt01_reporte();
            using (var db = new EagleContext())
            {
                try
                {
                    obj = db.RPTt01_reporte.SingleOrDefault(x => x.id_categoria_reporte == id && x.id_estado != Estado.IdInactivo);
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Búsqueda Reporte por COD: ", e.Message);
                }
            }
            return obj;
        }

        public List<RPTt01_reporte> ListarReportePorVentas()
        {
            var categoria = new RPTt02_categoria_reporte();
            var lista = new List<RPTt01_reporte>();
            using (var db = new EagleContext())
            {
                try
                {
                    categoria = db.RPTt02_categoria_reporte.Single(x => x.cod_categoria_reporte == CodCatReporte.codVentas);
                    lista = db.RPTt01_reporte.Where(x => x.id_estado != Estado.IdInactivo && x.id_categoria_reporte == categoria.id_categoria_reporte).ToList();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Lista Reporte Por Ventas: ", e.Message);
                }
            }
            return lista;
        }
        public List<RPTt01_reporte> ListarReportePorCompras()
        {
            var categoria = new RPTt02_categoria_reporte();
            var lista = new List<RPTt01_reporte>();
            using (var db = new EagleContext())
            {
                try
                {
                    categoria = db.RPTt02_categoria_reporte.Single(x => x.cod_categoria_reporte == CodCatReporte.codCompras);
                    lista = db.RPTt01_reporte.Where(x => x.id_estado != Estado.IdInactivo && x.id_categoria_reporte == categoria.id_categoria_reporte).ToList();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Lista Reporte Por Compras: ", e.Message);
                }
            }
            return lista;
        }
        public List<RPTt01_reporte> ListarReportePorCash()
        {
            var categoria = new RPTt02_categoria_reporte();
            var lista = new List<RPTt01_reporte>();
            using (var db = new EagleContext())
            {
                try
                {
                    categoria = db.RPTt02_categoria_reporte.Single(x => x.cod_categoria_reporte == CodCatReporte.codCash);
                    lista = db.RPTt01_reporte.Where(x => x.id_estado != Estado.IdInactivo && x.id_categoria_reporte == categoria.id_categoria_reporte).ToList();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Lista Reporte Por Cash: ", e.Message);
                }
            }
            return lista;
        }
        public List<RPTt01_reporte> ListarReportePorTurnos()
        {
            var categoria = new RPTt02_categoria_reporte();
            var lista = new List<RPTt01_reporte>();
            using (var db = new EagleContext())
            {
                try
                {
                    categoria = db.RPTt02_categoria_reporte.Single(x => x.cod_categoria_reporte == CodCatReporte.codTurnos);
                    lista = db.RPTt01_reporte.Where(x => x.id_estado != Estado.IdInactivo && x.id_categoria_reporte == categoria.id_categoria_reporte).ToList();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Lista Reporte Por Turnos: ", e.Message);
                }
            }
            return lista;
        }
        public List<RPTt01_reporte> ListarReportePorEmpleados()
        {
            var categoria = new RPTt02_categoria_reporte();
            var lista = new List<RPTt01_reporte>();
            using (var db = new EagleContext())
            {
                try
                {
                    categoria = db.RPTt02_categoria_reporte.Single(x => x.cod_categoria_reporte == CodCatReporte.codEmpleado);
                    lista = db.RPTt01_reporte.Where(x => x.id_estado != Estado.IdInactivo && x.id_categoria_reporte == categoria.id_categoria_reporte).ToList();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Lista Reporte Por Empleados: ", e.Message);
                }
            }
            return lista;
        }
        public string BuscarCodCategoria(int id)
        {
            var categoria = new RPTt02_categoria_reporte();
            using (var db = new EagleContext())
            {
                try
                {
                    categoria = db.RPTt02_categoria_reporte.Find(id);

                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Busqueda Codigo Categoria: ", e.Message);
                }
            }
            return categoria.cod_categoria_reporte;
        }
        
        public MSTt04_canal_vta BuscarCanalVenta(int id)
        {
            var canalVta = new MSTt04_canal_vta();
            using (var db = new EagleContext())
            {
                try
                {
                    canalVta = db.MSTt04_canal_vta.Find(id);

                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Busqueda Canal Venta: ", e.Message);
                }
            }
            return canalVta;
        }
        public List<MSTt04_canal_vta> ListarCanalVenta()
        {
            
            var lista = new List<MSTt04_canal_vta>();
            using (var db = new EagleContext())
            {
                try
                {
                    
                    lista = db.MSTt04_canal_vta.Where(x => x.id_estado == Estado.IdActivo).ToList();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Lista Canal de Venta: ", e.Message);
                }
            }
            return lista;
        }
        public MSTt04_canal_vta ObtenerPrimerCanalVta()
        {
            var canalVta = new MSTt04_canal_vta();
            using (var db = new EagleContext())
            {
                try
                {
                    canalVta = db.MSTt04_canal_vta.First();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Búsqueda Primer Canal Venta: ", e.Message);
                }
            }
            return canalVta;
        }
        public MSTt04_canal_vta ObtenerUltimoCanalVta()
        {
            var canalVta = new MSTt04_canal_vta();
            using (var db = new EagleContext())
            {
                try
                {
                    var lista = db.MSTt04_canal_vta.Where(x=>x.id_estado == Estado.IdActivo).OrderByDescending(x=>x.id_can_vta).Take(1).ToList();

                    canalVta = lista[0];
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Búsqueda Ultimo Canal Venta: ", e.Message);
                }
            }
            return canalVta;
        }
    }
}
