using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReportsBusinessEntity;
using ReportsBusinessLogic.Reporte;
using ReportsUtilitarios;
using EagleReports.FormularioBusquedas;
using EagleReports.FormularioCrystal;

namespace EagleReports.UserControlsEagle
{
    public partial class ucParametros : MetroFramework.Controls.MetroUserControl
    {
        RPTt01_reporte reporte;
        int inicioRVC;
        int finRVC;
        ReporteBL oReporteBL = new ReporteBL();
        
        public ucParametros(RPTt01_reporte reporte, int inicioRVC, int finRVC)
        {
            this.reporte = reporte;
            this.inicioRVC = inicioRVC;
            this.finRVC = finRVC;
            InitializeComponent();
            CargarCamposForm();
        }

        private void htmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void htmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void ucParametros_Load(object sender, EventArgs e)
        {

        }

        public void ObtenerCanalVenta()
        {

            var primerCanalVta = oReporteBL.ObtenerPrimerCanalVta();
            var ultimoCanalVta = oReporteBL.ObtenerUltimoCanalVta();
            txbIDRVCinicio.Text = primerCanalVta.id_can_vta.ToString();
            txtRangoRvcDesd.Text = primerCanalVta.txt_abrv;
            txbIDRVCfin.Text = ultimoCanalVta.id_can_vta.ToString();
            txtRangoRvcA.Text = ultimoCanalVta.txt_abrv;
            
        }

        public void CargarCamposForm()
        {
            

            lnkSiguiente.Enabled = false;
            //txbIdRVCFrom.Text = "1";
            //txbIDRVCTo.Text = "1";
            //tbxID.Clear();
            //txbCategoria.Clear();
            //tbxID.Text = reporte.id_reporte.ToString();
            //txbCategoria.Text = reporte.RPTt02_categoria_reporte.cod_categoria_reporte;
            txtRangoRvcDesd.Clear();
            txtRangoRvcA.Clear();
            txbIDRVCinicio.Clear();
            txbIDRVCfin.Clear();
            //Realiza distintas combinaciones de las condiciones del reporte (los "sn")
            
            switch (reporte.sn_date_range)
            {
                case true:
                    switch (reporte.sn_rvc_range)
                    {
                        case true:
                            
                            if (inicioRVC == 0 && finRVC == 0)
                            {
                                ObtenerCanalVenta();
                            }
                            else
                            {
                                var canalVtaInicio = oReporteBL.BuscarCanalVenta(inicioRVC);
                                txtRangoRvcDesd.Text = canalVtaInicio.txt_abrv;
                                txbIDRVCinicio.Text = canalVtaInicio.id_can_vta.ToString();

                                var canalVtaFin = oReporteBL.BuscarCanalVenta(finRVC);
                                txtRangoRvcA.Text = canalVtaFin.txt_abrv;
                                txbIDRVCfin.Text = canalVtaFin.id_can_vta.ToString();

                            }
                            pnlRangoRVC.Visible = true;
                            break;
                        case false:
                            pnlRangoRVC.Visible = false;
                            break;
                        default:
                            break;
                    }
                    pnlRangoFec.Visible = true;

                    break;
                case false:
                    switch (reporte.sn_rvc_range)
                    {
                        case true:
                            pnlRangoRVC.Location = new Point(pnlRangoRVC.Location.X, pnlRangoRVC.Location.Y - 27);
                            if (inicioRVC == 0 && finRVC == 0)
                            {
                                ObtenerCanalVenta();
                            }
                            else
                            {
                                var canalVtaInicio = oReporteBL.BuscarCanalVenta(inicioRVC);
                                txtRangoRvcDesd.Text = canalVtaInicio.txt_abrv;
                                txbIDRVCinicio.Text = canalVtaInicio.id_can_vta.ToString();

                                var canalVtaFin = oReporteBL.BuscarCanalVenta(finRVC);
                                txtRangoRvcA.Text = canalVtaFin.txt_abrv;
                                txbIDRVCfin.Text = canalVtaFin.id_can_vta.ToString();

                            }
                            pnlRangoRVC.Visible = true;
                            break;
                        case false:
                            pnlRangoRVC.Visible = false;
                            break;
                        default:
                            break;
                    }
                    pnlRangoFec.Visible = false;
                    break;
            }

        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            //int idRVCInicio = int.Parse(txbIDRVCinicio.Text);
            int idRVCInicio = (txbIDRVCinicio.Text == "") ? 0 : int.Parse(txbIDRVCinicio.Text);
            //int idRVCFin = int.Parse(txbIDRVCfin.Text);
            int idRVCFin = (txbIDRVCfin.Text == "") ? 0 : int.Parse(txbIDRVCfin.Text);
            
            DateTime fechaInicio = DateTime.Parse(dtRangoFecFrom.Text);
            DateTime fechaFin = DateTime.Parse(dtRangoFecTo.Text);

            FormularioCrystalReport of = new FormularioCrystalReport(reporte,fechaInicio,fechaFin, idRVCInicio, idRVCFin);
            of.Show();
        }

        private void lnkAtras_Click(object sender, EventArgs e)
        {
            var cod = oReporteBL.BuscarCodCategoria(reporte.id_categoria_reporte);
            switch (cod)
            {
                case "CR001":
                    MostrarListaReporte(CodCatReporte.codVentas);
                    break;
                case "CR002":
                    MostrarListaReporte(CodCatReporte.codCompras);
                    break;
                case "CR003":
                    MostrarListaReporte(CodCatReporte.codCash);
                    break;
                case "CR004":
                    MostrarListaReporte(CodCatReporte.codTurnos);
                    break;
                case "CR005":
                    MostrarListaReporte(CodCatReporte.codEmpleado);
                    break;
                default:
                    MessageBox.Show("Ha ocurrido un error inesperado, consulte con su administrador");
                    break;
            }
        }

        public void MostrarListaReporte(string cod)
        {
            //crea el objeto del control de usuario ucLista y envia el codigo de la categoria
            ucLista oucLista = new ucLista(cod);
            //Elimina el control de usuario ucLista que exista en el formularioEagleReports y lo crea denuevo
            //Se hace de esta forma para evitar que los datos se queden pegados
            FormularioEagleReports.Instance.MetroContainer.Controls.RemoveByKey("ucLista");
            if (!FormularioEagleReports.Instance.MetroContainer.Controls.ContainsKey("ucLista"))
            {

                oucLista.Dock = DockStyle.Fill;
                FormularioEagleReports.Instance.MetroContainer.Controls.Add(oucLista);
            }
            FormularioEagleReports.Instance.MetroContainer.Controls["ucLista"].BringToFront();
        }

        private void tbxRangoRVCFrom_Click(object sender, EventArgs e)
        {
            
        }

        private void tbxRangoRVCTo_Click(object sender, EventArgs e)
        {
            
        }

        private void txtRangoRvcDesd_Click(object sender, EventArgs e)
        {
            var id = int.Parse(txbIDRVCfin.Text);
            //Manda los parametros del id_reporte para que pueda devolver sus datos al terminar la accion
            //Manda 1 porque quiere decir que  el textbox es el inicio del rango de RVC
            //Manda el id del RVC fin que se guarda como hidden en el formulario
            FormularioListaRVC oform = new FormularioListaRVC(reporte.id_reporte, 1, id);
            oform.ShowDialog();
        }

        private void txtRangoRvcA_Click(object sender, EventArgs e)
        {
            //Manda los parametros del id_reporte para que pueda devolver sus datos al terminar la accion,
            //Manda 0 porque quiere decir que  el textbox es el fin del rango de RVC,
            //Manda el id del RVC inicio que se guarda como hidden en el formulario
            var id = int.Parse(txbIDRVCinicio.Text);
            FormularioListaRVC oform = new FormularioListaRVC(reporte.id_reporte, 0, id);
            oform.ShowDialog();
        }
    }
}
