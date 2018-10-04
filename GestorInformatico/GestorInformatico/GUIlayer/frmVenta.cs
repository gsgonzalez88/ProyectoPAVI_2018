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
        int descuento = 0;
        public frmVenta()
        {
            InitializeComponent();
        }

        private void frmVenta_Load(object sender, EventArgs e)
        {
            txtFecha.Text = DateTime.Today.ToShortDateString();
            cargarCombo(cboArticulo, DBHelper.Utilidades.Ejecutar("SELECT * FROM  Articulo"), "Descripcion", "IdArticulo");
            cargarCombo(cboFormaPago, DBHelper.Utilidades.Ejecutar("SELECT * FROM FormaPago"), "Descripcion", "IdTipoFP");
            cargarCombo(cboEmpleado, DBHelper.Utilidades.Ejecutar("SELECT (Apellido + ' ' + Nombre) as Nombre, IdEmpleado FROM Empleado"), "Nombre", "IdEmpleado");
            //"Select (c.Nombre + ' ' + c.Apellido) as Nombre,c.IdCliente from Cliente c where c.IdEstado = 1"
            txtFecha.Enabled = false;
            btnImprimir.Visible = false;
            lblCamposObli.Visible = false;
            txtStock.Enabled = false;
            txtPrecio.Enabled = false;
            lblNombreCli.Visible = false;
            txtNombreCli.Visible = false;
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
                txtStock.Text = tabla.Rows[0].ItemArray[3].ToString();
                txtPrecio.Text = tabla.Rows[0].ItemArray[5].ToString();
            }
            else
            {
                txtStock.Text = "";
                txtPrecio.Text = "";
            }
        }

        private void cboFormaPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable tabla = DBHelper.Utilidades.Ejecutar("SELECT * FROM FormaPago WHERE Descripcion = \'" + cboFormaPago.Text + "\'");
            if (tabla.Rows.Count > 0 && cboFormaPago.SelectedIndex != -1)
            {
                descuento = (int)tabla.Rows[0].ItemArray[2];
            }
            else
            {
                descuento = 0;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtDNICli.Text))
            {
                DataTable tabla = DBHelper.Utilidades.Ejecutar("SELECT (Nombre + ' ' + Apellido) as Nombre FROM Cliente WHERE NroDoc = \'" + txtDNICli.Text + "\'");
                if(tabla.Rows.Count > 0)
                {
                    lblNombreCli.Visible = true;
                    txtNombreCli.Visible = true;
                    txtNombreCli.Text = tabla.Rows[0].ItemArray[0].ToString();
                }
                else
                {
                    MessageBox.Show("El cliente buscado no existe, verifique los datos ingresados o registrelo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

  
    }
}
