using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorInformatico.GUIlayer
{
    public partial class frmVenta : Form
    {
        public frmVenta()
        {
            InitializeComponent();
        }

        private void frmVenta_Load(object sender, EventArgs e)
        {
            txtCliente.Text = "Consumidor Final";
            txtFecha.Text = DateTime.Today.ToShortDateString();
            cargarCombo(cboArticulo, DBHelper.Utilidades.Ejecutar("SELECT * FROM  Articulo"), "Descripcion", "IdArticulo");
            cargarCombo(cboFormaPago, DBHelper.Utilidades.Ejecutar("SELECT * FROM FormaPago"), "Descripcion", "IdTipoFP");
            cargarCombo(cboEmpleado, DBHelper.Utilidades.Ejecutar("SELECT * FROM Empleado"), "Apellido", "IdEmpleado");
        }

        private void cargarCombo(ComboBox cbo, Object source, string display, String value)
        {
            cbo.DataSource = source;
            cbo.DisplayMember = display;
            cbo.ValueMember = value;
            cbo.SelectedIndex = -1;
        }

        private void cboArticulo_TextChanged(object sender, EventArgs e)
        {
            DataTable tabla = DBHelper.Utilidades.Ejecutar("SELECT * FROM Articulo WHERE Descripcion = \'" + cboArticulo.Text + "\'");
            if (tabla.Rows.Count > 0 && cboArticulo.SelectedIndex != -1)
            {
                txtPrecio.Text = tabla.Rows[0].ItemArray[5].ToString();
            }
            else
            {
                txtPrecio.Text = "";
            }
        }

        private void cboFormaPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable tabla = DBHelper.Utilidades.Ejecutar("SELECT * FROM FormaPago WHERE Descripcion = \'" + cboFormaPago.Text + "\'");
            if (tabla.Rows.Count > 0 && cboFormaPago.SelectedIndex != -1)
            {
                txtDescuento.Text = tabla.Rows[0].ItemArray[2].ToString();
            }
            else
            {
                txtDescuento.Text = "";
            }
        }

  
    }
}
