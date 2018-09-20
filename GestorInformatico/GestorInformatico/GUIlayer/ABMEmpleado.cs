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
            cmbProvin.DataSource = Utilidades.Ejecutar("Select * from Provincia");
            cmbProvin.DisplayMember = "Descripcion";
            cmbProvin.ValueMember = "idProvincia";
            cmbProvin.SelectedIndex = -1;
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


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

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

        }
    }
}
