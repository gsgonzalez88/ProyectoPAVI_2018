using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorInformatico
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void estaSeguro(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Esta seguro que desea salir?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                e.Cancel = false;
                Application.ExitThread();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            ABMCliente Cliente = new ABMCliente();
            Cliente.MdiParent = this;
            Cliente.Show();

        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbmUsuario usuario = new AbmUsuario();
            usuario.MdiParent = this;
            usuario.Show();
       
        }

        private void barrioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbmBarrio barrio = new AbmBarrio();
            barrio.MdiParent = this;
            barrio.Show();
        }

        private void localidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbmLocalidad localidad = new AbmLocalidad();
            localidad.MdiParent = this;
            localidad.Show();
        }

        private void departamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbmDepto departamento = new AbmDepto();
            departamento.MdiParent = this;
            departamento.Show();
        }

        private void provinciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABMProvincia Provincia = new ABMProvincia();
            Provincia.MdiParent = this;
            Provincia.Show();
        }
                
        private void empleadoToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            ABMEmpleado empleado = new ABMEmpleado();
            empleado.MdiParent= this;
            empleado.Show();
        }

        private void consultarVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestorInformatico.GUIlayer.frmVenta venta = new GestorInformatico.GUIlayer.frmVenta();
            venta.MdiParent = this;
            venta.Show();
        }

        private void equipoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            GestorInformatico.GUIlayer.AbmEquipo equipo = new GUIlayer.AbmEquipo();
            equipo.MdiParent = this;
            equipo.Show();
        }

        private void formaDePagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestorInformatico.GUIlayer.frmFormaPago formaPago = new GestorInformatico.GUIlayer.frmFormaPago();
            formaPago.MdiParent = this;
            formaPago.Show();
        }

        private void marcaToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            GestorInformatico.GUIlayer.frmMarca marca = new GestorInformatico.GUIlayer.frmMarca();
            marca.MdiParent = this;
            marca.Show();
           
        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ordenDeTrabajoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestorInformatico.GUIlayer.OrdenDeTrabajo orden = new GUIlayer.OrdenDeTrabajo();
            orden.MdiParent = this;
            orden.Show();
        }

        
    }
}
