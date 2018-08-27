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
    public partial class BucarCliente : Form
    {
        public BucarCliente()
        {
           
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable table;
            table = Milibreria.Utilidades.ConsultarCliente( Convert.ToInt32(txtNroBuscar.Text));

            if (table.Rows.Count >0)
            {
               
            }
        }
    }
}
