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
    public partial class frmNuevoArticulo : Form
    {
        public frmNuevoArticulo()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtDescripcion.Text))
            {
                if(!string.IsNullOrEmpty(txtStockActual.Text))
                {
                    if(!string.IsNullOrEmpty(txtStockMinimo.Text))
                    {
                        if(!string.IsNullOrEmpty(txtPrecio.Text))
                        {
                            DBHelper.Utilidades.Insert("INSERT INTO Articulo VALUES (\'" + txtDescripcion.Text +
                                "\'," + 1 + "," + Convert.ToInt32(txtStockActual.Text) + "," + Convert.ToInt32(txtStockMinimo.Text) + "," +
                                Convert.ToInt32(txtPrecio.Text) + ")");
                            MessageBox.Show("Artículo agregado con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();

                        }
                        else
                        {
                            MessageBox.Show("Debe completar todos los campos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Debe completar todos los campos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Debe completar todos los campos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Debe completar todos los campos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
