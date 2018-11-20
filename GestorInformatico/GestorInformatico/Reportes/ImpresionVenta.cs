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
    public partial class ImpresionVenta : Form
    {
        public ImpresionVenta()
        {
            InitializeComponent();
        }

        public int idVenta { get; set; }
        private void ImpresionVenta_Load(object sender, EventArgs e)
        {
            this.impresion_VentaTableAdapter.Fill(this.dataSet2.Impresion_Venta, idVenta);
            this.reportViewer1.RefreshReport();
        }
    }
}
