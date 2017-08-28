using CrystalDecisions.CrystalReports.Engine;
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

namespace EagleReports.FormularioCrystal
{
    public partial class FormularioCrystalReport : Form
    {
        RPTt01_reporte reporte;
        DateTime fechaInicio;
        DateTime fechaFin;
        int idRVCinicio;
        int idRVCFin;
        public FormularioCrystalReport(RPTt01_reporte reporte, DateTime fechaInicio, DateTime fechaFin, int idRVCinicio, int idRVCfin)
        {
            this.reporte = reporte;
            this.fechaInicio = fechaInicio;
            this.fechaFin = fechaFin;
            this.idRVCinicio = idRVCinicio;
            this.idRVCFin = idRVCfin;
            InitializeComponent();
        }
        ReporteBL oReporteBL = new ReporteBL();
        private void FormularioCrystalReport_Load(object sender, EventArgs e)
        {
            CargarReporte();
        }
        public void CargarReporte()
        {
            //Crea un nuevo documento de reporte
            ReportDocument reportDocument = new ReportDocument();
            string filePath = reporte.txt_path;
            //Carga el reporte de la bd en el documento
            reportDocument.Load(filePath);
            //if el reporte no tiene parametros lo muestra, si no realiza una buscqueda de los parametros que existe
            //y los manda al reporte
            if (reportDocument.ParameterFields.Count == 0)
            {
                crystalReportViewer1.ReportSource = reportDocument;
            }
            else
            {
                for (int i = 0; i < reportDocument.ParameterFields.Count; i++)
                {
                    var param = reportDocument.ParameterFields[i].Name;
                    var tipoParam = reportDocument.ParameterFields[i].ParameterValueType.ToString();
                    //Mandara los parametros segun el tipo de parametro que tenga el reporte
                    switch (tipoParam)
                    {
                        case "BooleanParameter":
                            break;
                        case "StringParameter":
                            //si es 1 quiere decir que el parametro es un string
                            if (reportDocument.ParameterFields.Count == 1)
                            {

                            }
                            //si no es 1 quiere decir que el parametro es una fecha
                            else
                            {
                                //si i es 0 quiere decir que es el primer parametro entonces se agrega la fecha de inicio
                                if (i == 0)
                                {
                                    reportDocument.SetParameterValue(param, fechaInicio);
                                }
                                //si i es 1 quiere decir que es el segundo parametro entonces se agrega la fecha de fin
                                if (i == 1)
                                {
                                    reportDocument.SetParameterValue(param, fechaFin);
                                }
                            }
                            
                            break;
                        case "DateParameter":
                            break;
                        case "DateTimeParameter":
                            break;
                        case "TimeParameter":
                            break;
                        case "CurrencyParameter":
                            break;
                        case "NumberParameter":

                            if (idRVCinicio != 0 && idRVCFin != 0)
                            {
                                if (i == 0)
                                {
                                    reportDocument.SetParameterValue(param, idRVCinicio);
                                }
                                if (i == 1)
                                {
                                    reportDocument.SetParameterValue(param, idRVCFin);
                                }
                            }
                            //if (numInicio != 0 && numFin != 0)
                            //{
                            //    if (i == 0)
                            //    {
                            //        reportDocument.SetParameterValue(param, numInicio);
                            //    }
                            //    if (i == 1)
                            //    {
                            //        reportDocument.SetParameterValue(param, numFin);
                            //    }

                            //}
                            break;
                        default:
                            break;
                    }
                }

                crystalReportViewer1.ReportSource = reportDocument;
            }
        }
    }
}
