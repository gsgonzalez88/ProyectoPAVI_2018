using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorInformatico.Reportes
{
    public partial class ReporteVenta : Form
    {
        public ReporteVenta()
        {
            InitializeComponent();
        }

        private void ReporteVenta_Load(object sender, EventArgs e)
        {
            cargarCombo(cboEmpleado, DBHelper.Utilidades.Ejecutar("SELECT (Apellido + ' ' + Nombre) as Nombre, IdEmpleado FROM Empleado"), "Nombre", "IdEmpleado");
        }

        private void cargarCombo(ComboBox cbo, Object source, string display, String value)
        {
            cbo.DataSource = source;
            cbo.DisplayMember = display;
            cbo.ValueMember = value;
            cbo.SelectedIndex = -1;
        }

        private void btnInformeFecha_Click(object sender, EventArgs e)
        {
            Reportes.ReporteVenFecha rep = new Reportes.ReporteVenFecha();
            rep.fecha = dtpFecha.Value;
            rep.ShowDialog();
        }

        private void btnInformeEmpleado_Click(object sender, EventArgs e)
        {
            Reportes.ReporteVenEmp repo = new Reportes.ReporteVenEmp();
            repo.emp = Convert.ToInt32(cboEmpleado.SelectedValue);
            repo.ShowDialog();
        }
    }
}
