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
    public partial class frmFormaPago : Form
    {
        public frmFormaPago()
        {
            InitializeComponent();
        }

        private void frmFormaPago_Load(object sender, EventArgs e)
        {
            DataTable tabla = DBHelper.Utilidades.Ejecutar("SELECT * FROM FormaPago");
            if(tabla.Rows.Count > 0)
            {
                dgvFormaPago.DataSource = tabla;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDescripcion.Text) && !string.IsNullOrEmpty(txtDescuento.Text))
            {
                DataTable tabla = DBHelper.Utilidades.Ejecutar("SELECT * FROM FormaPago WHERE Descripcion = \'" + txtDescripcion + "\'");
                if (tabla.Rows.Count == 0)
                {
                    if ((MessageBox.Show("Desea guardar la nueva forma de pago", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) == DialogResult.Yes)
                    {
                        DBHelper.Utilidades.Insert("INSERT FormaPago Values (\'" + txtDescripcion.Text + "\',\'" + txtDescuento.Text + "\')");
                        txtDescripcion.BackColor = Color.White;
                        txtDescuento.BackColor = Color.White;
                        lblCamposObli.BackColor = Color.White;
                        txtDescripcion.Text = "";
                        txtDescuento.Text = "";
                        MessageBox.Show("Guardado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DataTable tabla2 = DBHelper.Utilidades.Ejecutar("SELECT * FROM FormaPago");
                        if (tabla2.Rows.Count > 0)
                        {
                            dgvFormaPago.DataSource = tabla2;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Ya existe ese tipo de pago, haz click en el boton modificar para realizar los cambios", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Debe completar los campos obligatorios.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lblCamposObli.BackColor = Color.LightBlue;
                txtDescripcion.BackColor = Color.LightBlue;
                txtDescuento.BackColor = Color.LightBlue;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtDescripcion.Text) && !string.IsNullOrEmpty(txtDescuento.Text))
            {
                DataTable id = DBHelper.Utilidades.Ejecutar("SELECT IdTipoFP From FormaPago WHERE Descripcion = \'" + txtDescripcion.Text + "\'");
                if (id.Rows.Count > 0)
                {
                    int id2 = Convert.ToInt32(id.Rows[0].ItemArray[0]);
                    DBHelper.Utilidades.Update("UPDATE FormaPago SET Descripcion = \'" + txtDescripcion.Text + "\',Descuento = \'" + txtDescuento.Text + "\' WHERE IdTipoFP = \'" + id2 + "\'");
                    txtDescripcion.BackColor = Color.White;
                    txtDescuento.BackColor = Color.White;
                    lblCamposObli.BackColor = Color.White;
                    txtDescripcion.Text = "";
                    txtDescuento.Text = "";
                    MessageBox.Show("Se ha realizado la modificación correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DataTable tabla2 = DBHelper.Utilidades.Ejecutar("SELECT * FROM FormaPago");
                    if (tabla2.Rows.Count > 0)
                    {
                        dgvFormaPago.DataSource = tabla2;
                    }
                }
                else
                {
                    MessageBox.Show("No se encontro el valor que desea modificar, verifique si está escrito correctamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Debe completar los campos obligatorios.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lblCamposObli.BackColor = Color.LightBlue;
                txtDescripcion.BackColor = Color.LightBlue;
                txtDescuento.BackColor = Color.LightBlue;
            }
        }
    }
}
