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

        public DateTime fecha { get; set; }
        public DateTime Fecha2 { get; set; }
        public int idEsta { get; set; }
        public int idmarc { get; set; }

        private void ImpresionReporteOT_Load(object sender, EventArgs e)
        { 
            
            this.reporteOTTableAdapter.Fill(this.dataSet.ReporteOT, fecha, Fecha2, idEsta, idmarc);
            this.reportViewer1.RefreshReport();
        }
    }
}
