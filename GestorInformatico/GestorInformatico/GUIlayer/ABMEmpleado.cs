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
using DBHelper;


namespace GestorInformatico
{
    public partial class ABMEmpleado : Form
    {
        public ABMEmpleado()
        {
            InitializeComponent();
        }
        
        int a = 0;        

        private void ABMEmpleado_Load(object sender, EventArgs e)
        {
            lblEstado.Visible = false;
            rbtInactivo.Visible = false;
            rbtActivo.Visible = false;
            rbtInactivo.Checked = false;
            rbtActivo.Checked = false;
            cmbProvin.DataSource = Utilidades.Ejecutar("Select * from Provincia");
            cmbProvin.DisplayMember = "Descripcion";
            cmbProvin.ValueMember = "idProvincia";
            cmbProvin.SelectedIndex = -1;
            cmbTDoc.DataSource = Utilidades.Ejecutar("Select * from TipoDoc");
            cmbTDoc.DisplayMember = "Descripcion";
            cmbTDoc.ValueMember = "idTipoDoc";
            cmbTDoc.SelectedIndex = -1;
            cmbBarrio.SelectedIndex = -1;
            cmbDepto.SelectedIndex = -1;
            cmbLocalidad.SelectedIndex = -1;
            LlenarGrilla();
            lblCamposOb.Visible = true;
            a = 1;
        }

        private void LlenarGrilla()
        {
            DataTable tabla = Utilidades.Ejecutar("Select e.Descripcion as Estado,* from empleado emp left outer join Estado e on e.idEstado = emp.IdEstado");
            dgvEmpleado.Rows.Clear();
            if (tabla.Rows.Count > 0)
            {
                for (int i=0;i<tabla.Rows.Count;i++)
                {
                    dgvEmpleado.Rows.Add(tabla.Rows[i]["Nombre"]
                        , tabla.Rows[i]["Apellido"]
                        , tabla.Rows[i]["NroDoc"]
                        , tabla.Rows[i]["Estado"]
                        );
                }
            }
        }
        

        private void EstaSeguro(object sender, FormClosingEventArgs e)
        {
           if (MessageBox.Show("Desea salir sin guardar?","Confirmar",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void btnBarrio_Click(object sender, EventArgs e)
        {
            AbmBarrio frmBarrio = new AbmBarrio();
            frmBarrio.ShowDialog();
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            AbmLocalidad loc = new AbmLocalidad();
            loc.ShowDialog();
        }

        private void btnDpto_Click(object sender, EventArgs e)
        {
            AbmDepto depto = new AbmDepto();
            depto.ShowDialog();
        }

        private void btnProvincia_Click(object sender, EventArgs e)
        {
            ABMProvincia prov = new ABMProvincia();
            prov.ShowDialog();
        }

        private void cmbProvin_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (a == 1 && cmbProvin.SelectedValue != null )
            {
                a = 0;
                cmbDepto.DataSource = Utilidades.Ejecutar("Select * from Departamento where IdProvincia = " + cmbProvin.SelectedValue.ToString());
                cmbDepto.DisplayMember = "Descripcion";
                cmbDepto.ValueMember = "IdDepartamento";
                cmbDepto.SelectedIndex = -1;
                a = 1;
            }
            cmbDepto.SelectedIndex = -1;
            cmbLocalidad.SelectedIndex = -1;
            cmbBarrio.SelectedIndex = -1;
        }

        private void rbtActivo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cmbTDoc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
