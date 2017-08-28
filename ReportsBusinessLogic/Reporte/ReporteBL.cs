using ReportsBusinessEntity;
using ReportsDataAccess.Reporte;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportsBusinessLogic.Reporte
{
    public class ReporteBL
    {
        public List<RPTt01_reporte> ListaReporte(int? id_estado = null)
        {
            return new ReporteDA().ListaReporte(id_estado);
        }
        public RPTt01_reporte BuscarReporte(int id)
        {
            return new ReporteDA().BuscarReporte(id);
        }
        public RPTt01_reporte BuscarReporteXCod(string cod)
        {
            return new ReporteDA().BuscarReporteXCod(cod);
        }
        public RPTt01_reporte BuscarReporteXCat(int id)
        {

            return new ReporteDA().BuscarReporteXCat(id);
        }

        public List<RPTt01_reporte> ListarReportePorVentas()
        {

            return new ReporteDA().ListarReportePorVentas();
        }
        public List<RPTt01_reporte> ListarReportePorCompras()
        {

            return new ReporteDA().ListarReportePorCompras();
        }
        public List<RPTt01_reporte> ListarReportePorCash()
        {

            return new ReporteDA().ListarReportePorCash();
        }
        public List<RPTt01_reporte> ListarReportePorTurnos()
        {

            return new ReporteDA().ListarReportePorTurnos();
        }
        public List<RPTt01_reporte> ListarReportePorEmpleados()
        {

            return new ReporteDA().ListarReportePorEmpleados();
        }
        public string BuscarCodCategoria(int id)
        {
            return new ReporteDA().BuscarCodCategoria(id);
        }
        public MSTt04_canal_vta BuscarCanalVenta(int id)
        {
            return new ReporteDA().BuscarCanalVenta(id);
        }
        public List<MSTt04_canal_vta> ListarCanalVenta()
        {
            return new ReporteDA().ListarCanalVenta();
        }

        public MSTt04_canal_vta ObtenerPrimerCanalVta()
        {
            return new ReporteDA().ObtenerPrimerCanalVta();
        }
        public MSTt04_canal_vta ObtenerUltimoCanalVta()
        {
            return new ReporteDA().ObtenerUltimoCanalVta();
        }
    }
}
