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
    public partial class frmArticulo : Form
    {
        int id;
        public frmArticulo()
        {
            InitializeComponent();
        }



        private void frmArticulo_Load(object sender, EventArgs e)
        {
            DataTable tabla = DBHelper.Utilidades.Ejecutar("SELECT a.IdArticulo, a.Descripcion, a.StockActual, a.StockMinimo, a.Precio, e.Descripcion FROM Articulo a, Estado e WHERE a.Estado = e.IdEstado");
            if (tabla.Rows.Count > 0)
            {
                dgvArticulo.DataSource = tabla;
            }

            cargarCombo(cboArticulo, DBHelper.Utilidades.Ejecutar("SELECT * FROM Articulo"), "Descripcion", "IdArticulo");
        }

        private void cargarCombo(ComboBox cbo, Object source, string display, String value)
        {
            cbo.DataSource = source;
            cbo.DisplayMember = display;
            cbo.ValueMember = value;
            cbo.SelectedIndex = -1;
        }

        private void btnActualizarStock_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(cboArticulo.Text))
            {
                if(!string.IsNullOrEmpty(txtStockIngr.Text))
                {
                    DBHelper.Utilidades.Update("UPDATE Articulo SET StockActual = \'" + Convert.ToInt32(txtStockIngr.Text) + "\'");
                    MessageBox.Show("Stock actualizado con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DataTable tabla = DBHelper.Utilidades.Ejecutar("SELECT a.IdArticulo, a.Descripcion, a.StockActual, a.StockMinimo, a.Precio, e.Descripcion FROM Articulo a, Estado e WHERE a.Estado = e.IdEstado");
                    if (tabla.Rows.Count > 0)
                    {
                        dgvArticulo.DataSource = tabla;
                    }
                }
                else
                {
                    MessageBox.Show("Debe completar los campos obligatorios.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtStockIngr.BackColor = Color.LightBlue;
                    cboArticulo.BackColor = Color.LightBlue;
                    lblCamposObli.BackColor = Color.LightBlue;
                }
            }
            else
            {
                MessageBox.Show("Debe completar los campos obligatorios.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtStockIngr.BackColor = Color.LightBlue;
                cboArticulo.BackColor = Color.LightBlue;
                lblCamposObli.BackColor = Color.LightBlue;
            }
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            DBHelper.Utilidades.Update("UPDATE Articulo SET Estado = 1 WHERE IdArticulo = " + id);
            DataTable tabla = DBHelper.Utilidades.Ejecutar("SELECT a.IdArticulo, a.Descripcion, a.StockActual, a.StockMinimo, a.Precio, e.Descripcion FROM Articulo a, Estado e WHERE a.Estado = e.IdEstado");
            if (tabla.Rows.Count > 0)
            {
                dgvArticulo.DataSource = tabla;
            }
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            DBHelper.Utilidades.Update("UPDATE Articulo SET Estado = 2 WHERE IdArticulo = " + id);
            DataTable tabla = DBHelper.Utilidades.Ejecutar("SELECT a.IdArticulo, a.Descripcion, a.StockActual, a.StockMinimo, a.Precio, e.Descripcion FROM Articulo a, Estado e WHERE a.Estado = e.IdEstado");
            if (tabla.Rows.Count > 0)
            {
                dgvArticulo.DataSource = tabla;
            }
        }

        private void cboArticulo_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cboArticulo.Text))
            {
                DataTable tabla = DBHelper.Utilidades.Ejecutar("SELECT IdArticulo FROM Articulo WHERE Descripcion = \'" + cboArticulo.Text + "\'");
                if (tabla.Rows.Count > 0 && cboArticulo.SelectedIndex != -1)
                {
                    id = Convert.ToInt32(tabla.Rows[0].ItemArray[0]);
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cboArticulo.Text))
            {
                GUIlayer.frmEditarArticulo art = new frmEditarArticulo(id);
                art.ShowDialog();
                DataTable tabla = DBHelper.Utilidades.Ejecutar("SELECT a.IdArticulo, a.Descripcion, a.StockActual, a.StockMinimo, a.Precio, e.Descripcion FROM Articulo a, Estado e WHERE a.Estado = e.IdEstado");
                if (tabla.Rows.Count > 0)
                {
                    dgvArticulo.DataSource = tabla;
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un artículo a editar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboArticulo.BackColor = Color.LightBlue;
                lblCamposObli.BackColor = Color.LightBlue;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            GUIlayer.frmNuevoArticulo art = new frmNuevoArticulo();
            art.ShowDialog();
            DataTable tabla = DBHelper.Utilidades.Ejecutar("SELECT a.IdArticulo, a.Descripcion, a.StockActual, a.StockMinimo, a.Precio, e.Descripcion FROM Articulo a, Estado e WHERE a.Estado = e.IdEstado");
            if (tabla.Rows.Count > 0)
            {
                dgvArticulo.DataSource = tabla;
            }
        }

        private void frmArticulo_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea salir?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                e.Cancel = false;
                Application.ExitThread();
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
