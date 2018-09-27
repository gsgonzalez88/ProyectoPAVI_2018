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

namespace GestorInformatico
{
    public partial class ABMProvincia : Form
    {
        public ABMProvincia()
        {
            InitializeComponent();
        }

        private void ABMProvincia_Load(object sender, EventArgs e)
        {
            LlenarGrilla();

        }

        private void LlenarGrilla()
        {
            DataTable table;
            table = Utilidades.Ejecutar("Select * from Provincia");
            dvgProvincia.Rows.Clear();
            if (table.Rows.Count > 0)
            {

                for (int i = 0; i < table.Rows.Count; i++)
                {
                    dvgProvincia.Rows.Add(table.Rows[i]["Descripcion"].ToString());
                }
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtProvincia.Text))
            {
                DataTable table;
                table = Utilidades.Ejecutar("Select * from Provincia"
                    + "  where Descripcion = '" + txtProvincia.Text + "'");
                if (table.Rows.Count == 0)
                {
                    Utilidades.Insert("Insert Provincia Values('" + txtProvincia.Text  + "')");
                    MessageBox.Show("Gurdado Correctamente", "Informacion");
                    return;
                }
                else
                {
                    MessageBox.Show("La provincia ya existe", "Informacion");
                    return;
                }
            }
            else
            {
                label2.Visible = true;
                label2.BackColor = Color.LightBlue;
                txtProvincia.Focus();
                txtProvincia.BackColor = Color.LightBlue;
            }
           
        }

        private void btnRefescar_Click(object sender, EventArgs e)
        {
            LlenarGrilla();
            txtProvincia.Clear();
            label2.BackColor = Color.White;
            txtProvincia.BackColor = Color.White;
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void EstaSeguro(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Desea salir?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
