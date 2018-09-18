using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorInformatico
{
    public partial class ABMEmpleado : Form
    {
        public ABMEmpleado()
        {
            InitializeComponent();
        }

        private void ABMEmpleado_Load(object sender, EventArgs e)
        {

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
    }
}
