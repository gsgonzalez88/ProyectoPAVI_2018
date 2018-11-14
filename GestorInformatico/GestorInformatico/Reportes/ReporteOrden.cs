using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBHelper;

namespace GestorInformatico.Reportes
{
    public partial class ReporteOrden : Form
    {
        public ReporteOrden()
        {
            InitializeComponent();
        }

        private void ReporteOrden_Load(object sender, EventArgs e)
        {
            dtpDesde.Value = DateTime.Today;
            dtpHasta.Value = DateTime.Today;
            btnImprimir.Enabled = true;

            cmbEstado.DataSource = Utilidades.Ejecutar("Select * from Estado where idEstado != 2");
            cmbEstado.DisplayMember = "Descripcion";
            cmbEstado.ValueMember = "IdEstado";
            cmbEstado.SelectedIndex = -1;

          

            cmbMarca.DataSource = Utilidades.Ejecutar("Select * from Marca where idEstado != 2");
            cmbMarca.DisplayMember = "Descripcion";
            cmbMarca.ValueMember = "IdMarca";
            cmbMarca.SelectedIndex = -1;
        }
        public void desCheck()
        {
            
            dtpDesde.Value = DateTime.Today;
            dtpHasta.Value = DateTime.Today;
         
            cmbEstado.SelectedText = "";
            cmbMarca.SelectedText = "";
            btnImprimir.Enabled = true;
        }

      

      

        
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            Reportes.ImpresionReporteOT repo = new ImpresionReporteOT();
           
                repo.fecha = dtpDesde.Value;
                repo.Fecha2 = dtpHasta.Value;
                repo.idEsta = (int)cmbEstado.SelectedValue;
                repo.idmarc = (int)cmbMarca.SelectedValue;
            
            repo.Show();
        }
      
    }
}
