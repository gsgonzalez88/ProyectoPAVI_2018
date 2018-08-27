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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void estaSeguro(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Esta seguro que desea salir?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                e.Cancel = false;
                Application.ExitThread();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            ABMCliente abmC = new ABMCliente();
            abmC.ShowDialog();
        }

      

    

     

      

        
    }
}
