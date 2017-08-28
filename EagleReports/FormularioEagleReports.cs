using EagleReports.UserControlsEagle;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EagleReports
{
    public partial class FormularioEagleReports : MetroFramework.Forms.MetroForm
    {
        static FormularioEagleReports _instance;

        public static FormularioEagleReports Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new FormularioEagleReports();
                }
                return _instance;
            }
        }

        public MetroFramework.Controls.MetroPanel MetroContainer
        {
            get { return pnlEagleReport; }
            set { pnlEagleReport = value; }
        }

        public MetroFramework.Controls.MetroPanel MetroPanel
        {
            get { return pnlEagleReport; }
            set { pnlEagleReport = value; }
        }
        public FormularioEagleReports()
        {
            InitializeComponent();
        }

        private void FormularioEagleReports_Load(object sender, EventArgs e)
        {
            _instance = this;
            ucFormularioCategoria uc = new ucFormularioCategoria();
            uc.Dock = DockStyle.Fill;
            pnlEagleReport.Controls.Add(uc);
        }
    }
}
