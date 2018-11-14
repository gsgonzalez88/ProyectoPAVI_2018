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
            cmbSolicitante.Enabled = false;
            dtpDesde.Enabled = false;
            dtpHasta.Enabled = false;
        }
        public void desCheck()
        {
            ckbEncargado.Checked = false;
            ckbFecha.Checked = false;
            ckbMarca.Checked = false;
            ckbSolicitante.Checked = false;
            ckbEstado.Checked = false;
            dtpDesde.Value = DateTime.Today;
            dtpHasta.Value = DateTime.Today;
            cmbEncargado.SelectedText = "";
            cmbEstado.SelectedText = "";
            cmbMarca.SelectedText = "";
            cmbSolicitante.SelectedText = "";
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            desCheck();
        }

        private void ckbMarca_CheckedChanged(object sender, EventArgs e)
        {

            if (ckbMarca.Checked)
            {
                cmbEncargado.Enabled = true;
            }
            else
            {
                cmbEncargado.Enabled = false;
            }
        }

        private void ckbSolicitante_CheckedChanged(object sender, EventArgs e)
        {
          
            if (ckbSolicitante.Checked)
            {
                cmbEncargado.Enabled = true;
            }
            else
            {
                ckbSolicitante.Enabled = false;
            }
        }

        private void ckbEncargado_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbEncargado.Checked)
            {
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
                cmbEstado.Enabled = true;
            }
            else
            {
                cmbEstado.Enabled = false;
            }
        }

        private void ckbFecha_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbFecha.Checked)
            {
                dtpDesde.Enabled = true;
                dtpHasta.Enabled = true;
            }
            else
            {
                dtpDesde.Enabled = false;
                dtpHasta.Enabled = false;
            }
            
        }
      
    }
}
