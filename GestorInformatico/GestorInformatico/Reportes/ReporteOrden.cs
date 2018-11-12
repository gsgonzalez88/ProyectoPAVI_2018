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
            cmbEncargado.Enabled = false;
            cmbEstado.Enabled = false;
            cmbMarca.Enabled = false;
            dtpDesde.Enabled = false;
            dtpHasta.Enabled = false;
            btnImprimir.Enabled = false;

            cmbEstado.DataSource = Utilidades.Ejecutar("Select * from Estado where idEstado != 2");
            cmbEstado.DisplayMember = "Descripcion";
            cmbEstado.ValueMember = "IdEstado";
            cmbEstado.SelectedIndex = -1;

            cmbEncargado.DataSource = Utilidades.Ejecutar("Select (e.Nombre +' '+ e.Apellido)as Empleado,e.IdEmpleado from Empleado e");
            cmbEncargado.DisplayMember = "Empleado";
            cmbEncargado.ValueMember = "IdEmpleado";
            cmbEncargado.SelectedIndex = -1;

            cmbMarca.DataSource = Utilidades.Ejecutar("Select * from Marca where idEstado != 2");
            cmbMarca.DisplayMember = "Descripcion";
            cmbMarca.ValueMember = "IdMarca";
            cmbMarca.SelectedIndex = -1;
        }
        public void desCheck()
        {
            ckbEncargado.Checked = false;
            ckbFecha.Checked = false;
            ckbMarca.Checked = false;
            ckbEstado.Checked = false;
            dtpDesde.Value = DateTime.Today;
            dtpHasta.Value = DateTime.Today;
            cmbEncargado.SelectedText = "";
            cmbEstado.SelectedText = "";
            cmbMarca.SelectedText = "";
            btnImprimir.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            desCheck();
        }

        private void ckbMarca_CheckedChanged(object sender, EventArgs e)
        {

            if (ckbMarca.Checked)
            {
                cmbMarca.Enabled = true;
                btnImprimir.Enabled = true;
            }
            else
            {
                cmbMarca.Enabled = false;
                btnImprimir.Enabled = false;
            }
        }



        private void ckbEncargado_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbEncargado.Checked)
            {
                btnImprimir.Enabled = true;
                cmbEncargado.Enabled = true;
            }
            else
            {
                cmbEncargado.Enabled = false;
            }
           
        }

        private void ckbEstado_CheckedChanged(object sender, EventArgs e)
        {
           
            if (ckbEstado.Checked)
            {
                btnImprimir.Enabled = true;
                cmbEstado.Enabled = true;
            }
            else
            {
                btnImprimir.Enabled = false;
                cmbEstado.Enabled = false;
            }
        }

        private void ckbFecha_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbFecha.Checked)
            {
                btnImprimir.Enabled = true;
                dtpDesde.Enabled = true;
                dtpHasta.Enabled = true;
            }
            else
            {
                dtpDesde.Enabled = false;
                dtpHasta.Enabled = false;
                btnImprimir.Enabled = false;
            }
            
        }
      
    }
}
