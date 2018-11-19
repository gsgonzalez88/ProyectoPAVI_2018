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
    public partial class ReporteVenEmp : Form
    {
        public ReporteVenEmp()
        {
            InitializeComponent();
        }

        public int emp { get; set; }

        private void ReporteVenEmp_Load(object sender, EventArgs e)
        {
            this.venta_EmpleadoTableAdapter.Fill(this.dataSet2.Venta_Empleado, emp);
            this.reportViewer1.RefreshReport();
        }
    }
}
