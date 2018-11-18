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
    public partial class GraficoVenta : Form
    {
        public GraficoVenta()
        {
            InitializeComponent();
        }

        private void GraficoVenta_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'pavGestorDataSet.Grafico' Puede moverla o quitarla según sea necesario.
            this.graficoTableAdapter.Fill(this.pavGestorDataSet.Grafico);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
