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
    public partial class ReporteVenta : Form
    {
        public ReporteVenta()
        {
            InitializeComponent();
        }

        private void ReporteVenta_Load(object sender, EventArgs e)
        {

        }

        private void btnInformeFecha_Click(object sender, EventArgs e)
        {
            DateTime fecha = dtpFecha.Value.Date;
            Reportes.ReporteVentaFecha rep = new Reportes.ReporteVentaFecha(fecha);
            rep.ShowDialog();
        }
    }
}
