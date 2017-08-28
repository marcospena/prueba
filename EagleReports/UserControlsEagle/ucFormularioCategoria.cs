using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReportsUtilitarios;

namespace EagleReports.UserControlsEagle
{
    public partial class ucFormularioCategoria : MetroFramework.Controls.MetroUserControl
    {
        public ucFormularioCategoria()
        {
            InitializeComponent();
        }

        private void mtVentas_Click(object sender, EventArgs e)
        {

            MostrarListaPorCategoria(CodCatReporte.codVentas);
        }

        private void mtCompras_Click(object sender, EventArgs e)
        {
            MostrarListaPorCategoria(CodCatReporte.codCompras);
        }

        private void mtCash_Click(object sender, EventArgs e)
        {
            MostrarListaPorCategoria(CodCatReporte.codCash);
        }

        private void mtTurnos_Click(object sender, EventArgs e)
        {
            MostrarListaPorCategoria(CodCatReporte.codTurnos);
        }

        private void mtEmpleados_Click(object sender, EventArgs e)
        {
            MostrarListaPorCategoria(CodCatReporte.codEmpleado);

        }

        public void MostrarListaPorCategoria(string cod)
        {
            ucLista uc = new ucLista(cod);
            FormularioEagleReports.Instance.MetroContainer.Controls.RemoveByKey("ucLista");
            if (!FormularioEagleReports.Instance.MetroContainer.Controls.ContainsKey("ucLista"))
            {

                uc.Dock = DockStyle.Fill;
                FormularioEagleReports.Instance.MetroContainer.Controls.Add(uc);
            }
            FormularioEagleReports.Instance.MetroContainer.Controls["ucLista"].BringToFront();
        }
    }
}
