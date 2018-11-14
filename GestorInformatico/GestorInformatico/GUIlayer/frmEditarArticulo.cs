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
    public partial class frmEditarArticulo : Form
    {
        int idArticulo;
        public frmEditarArticulo(int id)
        {
            idArticulo = id;
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtDescripcion.Text))
            {
                if(!string.IsNullOrEmpty(txtStockMinimo.Text))
                {
                    if(!string.IsNullOrEmpty(txtPrecio.Text))
                    {
                        DBHelper.Utilidades.Update("UPDATE Articulo SET Descripcion = \'" + txtDescripcion.Text +
                            "\', StockMinimo = " + Convert.ToInt32(txtStockMinimo.Text) + ", Precio = " +
                            Convert.ToInt32(txtPrecio.Text) + "WHERE IdArticulo = " + idArticulo);
                        MessageBox.Show("Artículo editado con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Debe completar todos los campos.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Debe completar todos los campos.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Debe completar todos los campos.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
