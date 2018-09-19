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
    public partial class AbmDepto : Form
    {
        public AbmDepto()
        {
            InitializeComponent();
        }

        private void AbmDepto_Load(object sender, EventArgs e)
        {
            LlenarGrilla();

            cmbProvincia.DataSource = Utilidades.Ejecutar("Select * from Provincia");
            cmbProvincia.DisplayMember = "Descripcion";
            cmbProvincia.ValueMember = "idProvincia";
            cmbProvincia.SelectedIndex = -1;
        }

        private void LlenarGrilla()
        {
            DataTable table;
            table = Utilidades.Ejecutar("Select d.Descripcion,P.Descripcion as Provincia"
            + " from Departamento d "
            + " join Provincia p on p.IdProvincia =d.IdProvincia");
            dvgDepartamento.Rows.Clear();
            if (table.Rows.Count > 0)
            {

                for (int i = 0; i < table.Rows.Count; i++)
                {
                    dvgDepartamento.Rows.Add(table.Rows[i]["Descripcion"].ToString()
                                   , table.Rows[i]["Provincia"].ToString());
                }
            }
        }

        private void btnRefescar_Click(object sender, EventArgs e)
        {
            txtDepto.Clear();
            cmbProvincia.SelectedIndex = -1;
            txtDepto.BackColor = Color.White;
            cmbProvincia.BackColor = Color.White;
            label3.BackColor = Color.White;
            cmbProvincia.Enabled = true;
            LlenarGrilla();
             
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            DataTable table;
            if (!string.IsNullOrEmpty(txtDepto.Text))
            {

                if (!string.IsNullOrEmpty(cmbProvincia.SelectedValue.ToString()))
                {
                    table = Utilidades.Ejecutar("Select * from Departamento where Descripcion = '" + txtDepto.Text + "' and idProvincia = " + cmbProvincia.SelectedValue);
                    if (table.Rows.Count == 0)
                    {
                        Utilidades.Insert("insert Departamento Values ('" + txtDepto.Text + "'," + cmbProvincia.SelectedValue + ")");
                        MessageBox.Show("Departamento Creado", "Informacion");
                        return;
                    }
                    else
                    {
                        MessageBox.Show("El Departamento ya Existe", "Informacion");
                        return;
                    }
                }
                else
                {
                    confirmar(sender, e);
                    cmbProvincia.Focus();
                    return;
                }
            }
            else
            {
                confirmar(sender, e);
                txtDepto.Focus();
            }
        }

        private void confirmar(object sender,EventArgs e )
        {
            txtDepto.BackColor = Color.LightBlue;
            cmbProvincia.BackColor = Color.LightBlue;
            label3.BackColor = Color.LightBlue;
            MessageBox.Show("Complete los campos Sombreados", "Informacion");
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
