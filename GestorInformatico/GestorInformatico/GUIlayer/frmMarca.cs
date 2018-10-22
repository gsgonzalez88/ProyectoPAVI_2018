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
    public partial class frmMarca : Form
    {
        string id = "nada";
        public frmMarca()
        {
            InitializeComponent();
        }

        private void frmMarca_Load(object sender, EventArgs e)
        {
            DataTable tabla = DBHelper.Utilidades.Ejecutar("SELECT m.IdMarca, m.Descripcion, e.Descripcion FROM Marca m, Estado e WHERE m.IdEstado = e.IdEstado");
            if (tabla.Rows.Count > 0)
            {
                dgvMarca.DataSource = tabla;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDescripcion.Text))
            {
                DataTable tabla = DBHelper.Utilidades.Ejecutar("SELECT m.IdMarca, m.Descripcion, e.Descripcion FROM Marca m, Estado e WHERE m.IdEstado = e.IdEstado AND m.Descripcion = '" + txtDescripcion.Text + "'");
                if (tabla.Rows.Count == 0)
                {
                    if ((MessageBox.Show("Desea guargar la nueva marca.", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) == DialogResult.Yes)
                    {
                        DBHelper.Utilidades.Insert("INSERT Marca VALUES ('" + txtDescripcion.Text + "',1)");
                        txtDescripcion.BackColor = Color.White;
                        lblCamposObli.BackColor = Color.White;
                        MessageBox.Show("Guardado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DataTable tabla2 = DBHelper.Utilidades.Ejecutar("SELECT m.IdMarca, m.Descripcion, e.Descripcion FROM Marca m, Estado e WHERE m.IdEstado = e.IdEstado");
                        if (tabla2.Rows.Count > 0)
                        {
                            dgvMarca.DataSource = tabla2;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("La marca ingresada ya existe, puede borrarla o ingresar otra", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Debe compretar los campos obligatorios.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lblDescripcion.BackColor = Color.LightBlue;
                txtDescripcion.BackColor = Color.LightBlue;
            }
        }


        private void btnBaja_Click(object sender, EventArgs e)
        {
            
                DBHelper.Utilidades.Update("UPDATE Marca SET IdEstado = 2 WHERE IdMarca = " + id);
                DataTable tabla = DBHelper.Utilidades.Ejecutar("SELECT m.IdMarca, m.Descripcion, e.Descripcion FROM Marca m, Estado e WHERE m.IdEstado = e.IdEstado");
                if (tabla.Rows.Count > 0)
                {
                    dgvMarca.DataSource = tabla;
                }
            
        }

        private void dgvMarca_SelectionChanged(object sender, EventArgs e)
        {
                id = dgvMarca.CurrentRow.Cells[0].Value.ToString();
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            DBHelper.Utilidades.Update("UPDATE Marca SET IdEstado = 1 WHERE IdMarca = " + id);
            DataTable tabla = DBHelper.Utilidades.Ejecutar("SELECT m.IdMarca, m.Descripcion, e.Descripcion FROM Marca m, Estado e WHERE m.IdEstado = e.IdEstado");
            if (tabla.Rows.Count > 0)
            {
                dgvMarca.DataSource = tabla;
            }
        }
    }
}
