using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReportsBusinessLogic.Reporte;
using ReportsBusinessEntity;

namespace EagleReports.UserControlsEagle
{
    public partial class ucLista : MetroFramework.Controls.MetroUserControl
    {
        ReporteBL oReporteBL = new ReporteBL();
        string cod_categ;
        public ucLista(string cod_categ)
        {
            this.cod_categ = cod_categ;
            InitializeComponent();
        }

        private void ucLista_Load(object sender, EventArgs e)
        {
            ActualizarLista();
        }

        public void ActualizarLista()
        {
            //Limpia la grilla
            dgvReporteVentas.Rows.Clear();
            var lista = new List<RPTt01_reporte>();
            //Dependiendo del codigo de la categoria_reporte se listara la grilla
            switch (cod_categ)
            {
                case "CR001":
                    lista = oReporteBL.ListarReportePorVentas();
                    break;
                case "CR002":
                    lista = oReporteBL.ListarReportePorCompras();
                    break;
                case "CR003":
                    lista = oReporteBL.ListarReportePorCash();
                    break;
                case "CR004":
                    lista = oReporteBL.ListarReportePorTurnos();
                    break;
                case "CR005":
                    lista = oReporteBL.ListarReportePorEmpleados();
                    break;
                default:
                    break;
            }
            //Recorre la grilla agregando los datos de la bd
            for (int i = 0; i < lista.Count(); i++)
            {
                if (lista[i].id_reporte != 0)
                {
                    dgvReporteVentas.Rows.Add(
                                                lista[i].id_reporte,
                                                lista[i].txt_desc,
                                                lista[i].id_categoria_reporte
                        );
                }
            }
            //Condicion para anular el boton siguiente si no hay registros en la bd
            if (dgvReporteVentas.RowCount == 0)
            {
                lnkSiguiente.Enabled = false;
            }
            else
            {
                lnkSiguiente.Enabled = true;
            }
        }

        private void lnkAtras_Click(object sender, EventArgs e)
        {
            //Muestra el control de usuario ucFormularioCategoria
            FormularioEagleReports.Instance.MetroPanel.Controls["ucFormularioCategoria"].BringToFront();
        }

        private void lnkSiguiente_Click(object sender, EventArgs e)
        {
            //entra siempre y cuando se seleccione un registro de la grilla
            if (dgvReporteVentas.SelectedCells[0].RowIndex >= 0)
            {
                //obtiene el ID del registro seleccionado
                var id = int.Parse(dgvReporteVentas.Rows[dgvReporteVentas.SelectedCells[0].RowIndex].Cells[0].Value.ToString());
                //busca en la bd por medio del id obtenido
                var reporte = oReporteBL.BuscarReporte(id);
                //envia el parametro reporte, 0, 0; se envia 0 ya que se cargara los datos de RVC por defecto
                ucParametros uc = new ucParametros(reporte,0,0);
                //Elimina el control de usuario ucParametros del formularioEageReports con la finalidad de evitar
                //que se queden pegados los datos
                FormularioEagleReports.Instance.MetroContainer.Controls.RemoveByKey("ucParametros");
                if (!FormularioEagleReports.Instance.MetroContainer.Controls.ContainsKey("ucParametros"))
                {

                    uc.Dock = DockStyle.Fill;
                    FormularioEagleReports.Instance.MetroContainer.Controls.Add(uc);
                }
                FormularioEagleReports.Instance.MetroContainer.Controls["ucParametros"].BringToFront();



            }
        }
    }
}
