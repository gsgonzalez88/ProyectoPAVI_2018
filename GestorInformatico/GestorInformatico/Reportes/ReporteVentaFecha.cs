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
    public partial class ReporteVentaFecha : Form
    {
        DateTime fecha;
        int idEmpleado;
        int idCliente;
        int idFormaPago;
        public ReporteVentaFecha(DateTime fec)
        {
            fecha = fec;
            InitializeComponent();
        }

        private void ReporteVentaFecha_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet.FormaPago' Puede moverla o quitarla según sea necesario.
            //this.formaPagoTableAdapter.Fill(this.dataSet.FormaPago);
            // TODO: esta línea de código carga datos en la tabla 'dataSet.Cliente' Puede moverla o quitarla según sea necesario.
            //this.clienteTableAdapter.Fill(this.dataSet.Cliente);
            // TODO: esta línea de código carga datos en la tabla 'dataSet.Empleado' Puede moverla o quitarla según sea necesario.
            //this.empleadoTableAdapter.Fill(this.dataSet.Empleado);
            // TODO: esta línea de código carga datos en la tabla 'dataSet.Venta' Puede moverla o quitarla según sea necesario.
            //this.ventaTableAdapter.Fill(this.dataSet.Venta);
            DataTable tabla = DBHelper.Utilidades.Ejecutar("SELECT * FROM Venta WHERE FechaVenta = \'" + fecha + "\'");
            idEmpleado = Convert.ToInt32(tabla.Rows[0].ItemArray[1]);
            idCliente = Convert.ToInt32(tabla.Rows[0].ItemArray[2]);
            idFormaPago = Convert.ToInt32(tabla.Rows[0].ItemArray[3]);
            ventaBindingSource.DataSource = tabla;
            
            tabla = DBHelper.Utilidades.Ejecutar("SELECT * FROM Empleado WHERE IdEmpleado = \'" + idEmpleado + "\'");
            empleadoBindingSource.DataSource = tabla;

            tabla = DBHelper.Utilidades.Ejecutar("SELECT * FROM Cliente WHERE IdCliente = \'" + idCliente + "\'");
            clienteBindingSource.DataSource = tabla;

            tabla = DBHelper.Utilidades.Ejecutar("SELECT * FROM FormaPago WHERE IdTipoFP = \'" + idFormaPago + "\'");
            formaPagoBindingSource.DataSource = tabla;
            this.reportViewer1.RefreshReport();
        }
    }
}
