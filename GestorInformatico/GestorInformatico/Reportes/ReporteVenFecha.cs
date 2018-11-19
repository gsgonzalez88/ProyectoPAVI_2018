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
    public partial class ReporteVenFecha : Form
    {
        public ReporteVenFecha()
        {
            InitializeComponent();
        }

        public DateTime fecha { get; set; }

        private void ReporteVenFecha_Load(object sender, EventArgs e)
        {
            this.venta_FechaTableAdapter.Fill(this.dataSet2.Venta_Fecha,fecha);
            this.reportViewer1.RefreshReport();
        }
    }
}
