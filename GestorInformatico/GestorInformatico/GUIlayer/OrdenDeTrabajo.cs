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
    public partial class OrdenDeTrabajo : Form
    {
        public OrdenDeTrabajo()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void OrdenDeTrabajo_Load(object sender, EventArgs e)
        {
            cmbEquipo.DataSource = Utilidades.Ejecutar("Select * from Marca");
            cmbEquipo.DisplayMember = "Descripcion";
            cmbEquipo.ValueMember = "IdMarca";
            cmbEquipo.SelectedIndex = -1;

            cmbEstado.DataSource = Utilidades.Ejecutar("Select * from Estado");
            cmbEstado.DisplayMember = "Descripcion";
            cmbEstado.ValueMember = "IdEstado";
            cmbEstado.SelectedIndex = -1;

            cmbTarea.DataSource = Utilidades.Ejecutar("Select * from Tarea");
            cmbTarea.DisplayMember = "Descripcion";
            cmbTarea.ValueMember = "IdTarea";
            cmbTarea.SelectedIndex = -1;

        }
    }
}
