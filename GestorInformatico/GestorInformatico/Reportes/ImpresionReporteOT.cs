using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorInformatico.Reportes
{
    public partial class ImpresionReporteOT : Form
    {
        public ImpresionReporteOT()
        {
            InitializeComponent();
        }

        private void ImpresionReporteOT_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
