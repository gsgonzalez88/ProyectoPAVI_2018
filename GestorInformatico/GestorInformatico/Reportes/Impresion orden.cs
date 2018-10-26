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
    public partial class Impresion_orden : Form
    {
 
        public Impresion_orden()
        {
            InitializeComponent();        
        }

        public int idOT { get; set; }

       
        private void Impresion_orden_Load(object sender, EventArgs e)
        {

            this.orden_ProcedureTableAdapter.Fill(this.dataSet.Orden_Procedure,idOT);

            this.reportViewer1.RefreshReport();
        }

    }
}
