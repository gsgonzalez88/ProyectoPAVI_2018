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

namespace GestorInformatico.GUIlayer
{
    public partial class AbmOrden : Form
    {
        public AbmOrden()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            cmbEstado.DataSource = Utilidades.Ejecutar("Select * from Estado");
                cmbEstado.DisplayMember = "Descripcion";
            cmbEstado.ValueMember = "IdEstado";

            txtNro.Enabled = false;
            txtRespuesta = false;
            cmbTarea.DataSource = Utilidades.Ejecutar("Select * from Tarea");
            cmbTarea.DisplayMember = "Descripcion";
            cmbTarea.ValueMember = "IdTarea";
        }



    }
}
