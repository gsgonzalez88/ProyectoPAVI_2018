using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GestorInformatico.GUIlayer
{
    public partial class frmVenta : Form
    {
        string cadena = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=BaseProyecto;User ID=sa;Password=2xdpn5fv0";
        int descuento = 0;
        int total = 0;
        public frmVenta()
        {
            InitializeComponent();
        }

        private void frmVenta_Load(object sender, EventArgs e)
        {
            txtFecha.Text = DateTime.Today.ToShortDateString().ToString();
            cargarCombo(cboArticulo, DBHelper.Utilidades.Ejecutar("SELECT * FROM  Articulo"), "Descripcion", "IdArticulo");
            cargarCombo(cboFormaPago, DBHelper.Utilidades.Ejecutar("SELECT * FROM FormaPago"), "Descripcion", "IdTipoFP");
            cargarCombo(cboEmpleado, DBHelper.Utilidades.Ejecutar("SELECT (Apellido + ' ' + Nombre) as Nombre, IdEmpleado FROM Empleado"), "Nombre", "IdEmpleado");
            txtFecha.Enabled = false;
            btnImprimir.Visible = false;
            lblCamposObli.Visible = false;
            txtStock.Enabled = false;
            txtPrecio.Enabled = false;
            lblNombreCli.Visible = false;
            txtNombreCli.Visible = false;
            txtNombreCli.Enabled = false;
            txtTotal.Enabled = false;
            lblCamposObli.BackColor = Color.LightBlue;
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
                descuento = Convert.ToInt32(tabla.Rows[0].ItemArray[2]);
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
                    cboFormaPago.Focus();
                }
                else
                {
                    MessageBox.Show("El cliente buscado no existe, verifique los datos ingresados o registrelo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnRegCliente_Click(object sender, EventArgs e)
        {
            ABMCliente cliente = new ABMCliente();
            cliente.ShowDialog();
        }

        private void btnDpto_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(cboArticulo.Text))
            {
                if (!string.IsNullOrEmpty(txtCantidad.Text))
                {
                    if ((Convert.ToInt32(txtCantidad.Text) <= Convert.ToInt32(txtStock.Text)))
                    {
                        if (!string.IsNullOrEmpty(cboFormaPago.Text))
                        {
                            if (!string.IsNullOrEmpty(txtNombreCli.Text))
                            {
                                if (!string.IsNullOrEmpty(cboFormaPago.Text))
                                {
                                    DataTable tabla = DBHelper.Utilidades.Ejecutar("SELECT A.IdArticulo, A.Descripcion, F.Descuento, F.Descripcion FROM Articulo A, FormaPago F WHERE A.Descripcion = \'"
                                        + cboArticulo.Text + "\' AND F.Descripcion = \'" + cboFormaPago.Text + "\'");
                                    DataGridViewRow fila = new DataGridViewRow();
                                    fila.CreateCells(dgvDetalles);
                                    fila.Cells[0].Value = tabla.Rows[0].ItemArray[0].ToString();
                                    fila.Cells[1].Value = cboArticulo.Text;
                                    fila.Cells[2].Value = txtPrecio.Text;
                                    int prec = Convert.ToInt32(txtPrecio.Text);
                                    fila.Cells[3].Value = txtCantidad.Text;
                                    int cant = Convert.ToInt32(txtCantidad.Text);
                                    fila.Cells[4].Value = prec * cant * descuento / 100;
                                    fila.Cells[5].Value = (prec * cant) - (prec * cant * descuento / 100);
                                    total = total + (prec * cant) - (prec * cant * descuento / 100);
                                    dgvDetalles.Rows.Add(fila);
                                    cboArticulo.SelectedIndex = -1;
                                    txtCantidad.Text = "";
                                    txtTotal.Text = total.ToString();
                                    cboFormaPago.Enabled = false;
                                    cboArticulo.Focus();
                                }
                                else
                                {
                                    MessageBox.Show("Complete los campos obligatorios", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    cboFormaPago.BackColor = Color.LightBlue;
                                    cboEmpleado.BackColor = Color.LightBlue;
                                    cboArticulo.BackColor = Color.LightBlue;
                                    txtDNICli.BackColor = Color.LightBlue;
                                    txtCantidad.BackColor = Color.LightBlue;
                                    lblCamposObli.Visible = true;
                                }
                            }
                            else
                            {
                                MessageBox.Show("Complete los campos obligatorios", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                cboFormaPago.BackColor = Color.LightBlue;
                                cboEmpleado.BackColor = Color.LightBlue;
                                cboArticulo.BackColor = Color.LightBlue;
                                txtDNICli.BackColor = Color.LightBlue;
                                txtCantidad.BackColor = Color.LightBlue;
                                lblCamposObli.Visible = true;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Complete los campos obligatorios", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            cboFormaPago.BackColor = Color.LightBlue;
                            cboEmpleado.BackColor = Color.LightBlue;
                            cboArticulo.BackColor = Color.LightBlue;
                            txtDNICli.BackColor = Color.LightBlue;
                            txtCantidad.BackColor = Color.LightBlue;
                            lblCamposObli.Visible = true;
                        }
                    }
                    else
                    {
                        MessageBox.Show("No puede ingresar una cantidad superior al stock del producto", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Complete los campos obligatorios", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cboFormaPago.BackColor = Color.LightBlue;
                    cboEmpleado.BackColor = Color.LightBlue;
                    cboArticulo.BackColor = Color.LightBlue;
                    txtDNICli.BackColor = Color.LightBlue;
                    txtCantidad.BackColor = Color.LightBlue;
                    lblCamposObli.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("Complete los campos obligatorios", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboFormaPago.BackColor = Color.LightBlue;
                cboEmpleado.BackColor = Color.LightBlue;
                cboArticulo.BackColor = Color.LightBlue;
                txtDNICli.BackColor = Color.LightBlue;
                txtCantidad.BackColor = Color.LightBlue;
                lblCamposObli.Visible = true;
            }
    }

        private void grbCliente_Enter(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int menos = Convert.ToInt32(dgvDetalles.CurrentRow.Cells[5].Value);
            dgvDetalles.Rows.Remove(dgvDetalles.CurrentRow);
            total = total - menos;
            txtTotal.Text = total.ToString();
        }

        private void btnGuargar_Click(object sender, EventArgs e)
        {
            SqlTransaction transaccion;
            SqlCommand comando = new SqlCommand();
            SqlConnection conexion = new SqlConnection();
            conexion.ConnectionString = cadena;

            conexion.Open();
            transaccion = conexion.BeginTransaction();
            comando.Connection = conexion;
            comando.Transaction = transaccion;
            try
            {
                if(dgvDetalles.Rows.Count > 0)
                {
                    DataTable idCliente = DBHelper.Utilidades.Ejecutar("SELECT IdCliente FROM Cliente WHERE NroDoc = \'" + txtDNICli.Text + "\'");
                    string sql = "INSERT INTO Venta VALUES (" + cboEmpleado.SelectedValue + ",'" + idCliente.Rows[0].ItemArray[0].ToString() +
                        "'," + cboFormaPago.SelectedValue + ",CONVERT(date,'" + txtFecha.Text.ToString() + "',103)" + "," + txtTotal.Text + ")";
                    comando.CommandText = sql;
                    comando.ExecuteNonQuery();
                    DataTable tabla = DBHelper.Utilidades.Ejecutar("SELECT IDENT_CURRENT('Venta')");
                    int identity = Convert.ToInt32(tabla.Rows[0].ItemArray[0]);
                    for(int i = 0; i < dgvDetalles.Rows.Count; i++)
                    {
                        string detVenta = "INSERT INTO detalleVenta VALUES (" + identity + "," + dgvDetalles.Rows[i].Cells[0].Value + 
                            "," + dgvDetalles.Rows[i].Cells[4].Value + "," + dgvDetalles.Rows[0].Cells[3].Value + "," + dgvDetalles.Rows[i].Cells[5].Value  + ")";
                        comando.CommandText = detVenta;
                        comando.ExecuteNonQuery();
                        DataTable StockActYMin = DBHelper.Utilidades.Ejecutar("SELECT StockActual, StockMinimo FROM Articulo WHERE IdArticulo = " + dgvDetalles.Rows[i].Cells[0].Value + "");
                        int stockAct = Convert.ToInt32(StockActYMin.Rows[0].ItemArray[0]);
                        int stockMin = Convert.ToInt32(StockActYMin.Rows[0].ItemArray[1]);
                        stockAct = stockAct - (Convert.ToInt32(dgvDetalles.Rows[i].Cells[3].Value));
                        string art = "UPDATE Articulo SET StockActual = " + stockAct + " WHERE IdArticulo = " + dgvDetalles.Rows[i].Cells[0].Value;
                        DBHelper.Utilidades.Update(art);
                    }
                    transaccion.Commit();
                    MessageBox.Show("La venta se guardó correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnImprimir.Visible = true;
                }
                else
                {
                    MessageBox.Show("Debe cargar artículos a la orden de venta", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            catch(Exception ex)
            {
                transaccion.Rollback();
                MessageBox.Show(ex.Message, "Error de carga", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

  
    }
}
