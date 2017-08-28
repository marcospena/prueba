using EagleReports.UserControlsEagle;
using ReportsBusinessEntity;
using ReportsBusinessLogic.Reporte;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EagleReports.FormularioBusquedas
{
    public partial class FormularioListaRVC : MetroFramework.Forms.MetroForm
    {
        int id;
        int isInicio;
        int valorNum;
        ReporteBL oReporteBL = new ReporteBL();
        public FormularioListaRVC(int id, int isInicio, int valorNum)
        {
            this.id = id;
            this.isInicio = isInicio;
            this.valorNum = valorNum;
            InitializeComponent();
            ActualizarLista();
        }

        public void ActualizarLista()
        {

            dgvBuscarPor.Rows.Clear();
            var lista = oReporteBL.ListarCanalVenta();

            for (int i = 0; i < lista.Count(); i++)
            {
                if (lista[i].id_can_vta != 0)
                {
                    dgvBuscarPor.Rows.Add(
                                                lista[i].id_can_vta,
                                                lista[i].txt_abrv
                        );
                }
            }
        }

        private void dgvBuscarPor_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var idRVC = int.Parse(dgvBuscarPor.Rows[dgvBuscarPor.SelectedCells[0].RowIndex].Cells[0].Value.ToString());

            var reporte = oReporteBL.BuscarReporte(id);
            switch (isInicio)
            {
                case 1:
                    MostrarUCParametro(reporte,idRVC,valorNum);
                    this.Close();
                    break;
                case 0:
                    MostrarUCParametro(reporte,valorNum,idRVC);
                    this.Close();
                    break;
                default:
                    break;
            }
        }

        public void MostrarUCParametro(RPTt01_reporte reporte,int idRVCInicio, int idRVCFinal)
        {
            ucParametros uc = new ucParametros(reporte, idRVCInicio, idRVCFinal);
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
