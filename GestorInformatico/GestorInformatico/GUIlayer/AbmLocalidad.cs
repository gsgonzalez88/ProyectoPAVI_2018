using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Milibreria;

namespace GestorInformatico
{
    public partial class AbmLocalidad : Form
    {
        public AbmLocalidad()
        {
            InitializeComponent();
        }
        int a = 0;

        private void LlenarGrilla()
        {
            DataTable table;
            table = Milibreria.Utilidades.Ejecutar("Select l.Descripcion as Localidad,l.CodigoPostal as Codigo,d.Descripcion as Departamento,P.Descripcion as Provincia"
            + " from Localidad l"
            + " join Departamento d on d.IdDepartamento = l.IdDepartamento"
               + " join Provincia p on p.IdProvincia =d.IdProvincia");
            dgvLocalidad.Rows.Clear();
            if (table.Rows.Count > 0)
            {

                for (int i = 0; i < table.Rows.Count; i++)
                {
                    dgvLocalidad.Rows.Add(table.Rows[i]["Localidad"].ToString()
                                   , table.Rows[i]["Codigo"].ToString()
                                   , table.Rows[i]["Departamento"].ToString()
                                    ,table.Rows[i]["Provincia"].ToString());
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbmDepto depto = new AbmDepto();
            depto.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ABMProvincia provincia = new ABMProvincia();
            provincia.ShowDialog();
        }

        private void AbmLocalidad_Load(object sender, EventArgs e)
        {

            LlenarGrilla();
            
            DataTable tabla = Milibreria.Utilidades.Ejecutar("Select * from Provincia");

            cmbProvincia.DataSource = tabla;
            cmbProvincia.DisplayMember = "Descripcion";
            cmbProvincia.ValueMember = "IdProvincia";
            cmbProvincia.SelectedIndex = -1;
            a = 1;
        }

        private void cmbProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (a == 1 && cmbProvincia.SelectedValue != null)
            {
                a = 0;
                cmbDepartamento.DataSource = Milibreria.Utilidades.Ejecutar("Select * from Departamento"
                + " where IdProvincia = " + cmbProvincia.SelectedValue.ToString());
                cmbDepartamento.DisplayMember = "Descripcion";
                cmbDepartamento.ValueMember = "IdDepartamento";
                cmbDepartamento.SelectedIndex = -1;
                a = 1;
            }
            
        }

        private void btnRefescar_Click(object sender, EventArgs e)
        {
            cmbDepartamento.SelectedIndex = -1;
            cmbProvincia.SelectedIndex = -1;
            txtLoc.Clear();
            txtCod.Clear();
            dgvLocalidad.Rows.Clear();
            LlenarGrilla();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtLoc.Text != "")
            {
                
           
            if (cmbProvincia.SelectedValue != null)
            {
                if (cmbDepartamento.SelectedValue != null)
                {

                    if (txtCod.Text != "")
                    {
                        Milibreria.Utilidades.Insert("Insert Localidad Values ('" + txtLoc.Text + "'," + cmbDepartamento.SelectedValue.ToString() + "," + txtCod.Text + ")");
                        MessageBox.Show("Guardado Correctamente", "Informacion");
                        txtCod.Focus();
                        return;
                    }
                    MessageBox.Show("Complete los campos", "Informacion");
                    txtCod.Focus();
                    return;
                   
                }
                MessageBox.Show("Complete los campos", "Informacion");
                cmbDepartamento.Focus();
                return;
                   
            }
            MessageBox.Show("Complete los campos", "Informacion");
            cmbProvincia.Focus();
            return;
                   
            }
            else
            {
                MessageBox.Show("Complete los campos", "Informacion");
                txtLoc.Focus();
            }
        }

       
    }
}
