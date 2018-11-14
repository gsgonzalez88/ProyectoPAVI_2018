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
    public partial class ImpresionVenta : Form
    {
        int idVenta;
        int idEmpleado;
        int idCliente;
        int idFormaPago;
        int idArticulo;
        public ImpresionVenta(int id)
        {
            InitializeComponent();
            idVenta = id;
        }

        private void ImpresionVenta_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet.FormaPago' Puede moverla o quitarla según sea necesario.
            //this.formaPagoTableAdapter.Fill(this.dataSet.FormaPago);
            // TODO: esta línea de código carga datos en la tabla 'dataSet.Cliente' Puede moverla o quitarla según sea necesario.
            //this.clienteTableAdapter.Fill(this.dataSet.Cliente);
            // TODO: esta línea de código carga datos en la tabla 'dataSet.Empleado' Puede moverla o quitarla según sea necesario.
            //this.empleadoTableAdapter.Fill(this.dataSet.Empleado);
            // TODO: esta línea de código carga datos en la tabla 'dataSet.Articulo' Puede moverla o quitarla según sea necesario.
            //this.articuloTableAdapter.Fill(this.dataSet.Articulo);
            // TODO: esta línea de código carga datos en la tabla 'dataSet.Venta' Puede moverla o quitarla según sea necesario.
            //this.ventaTableAdapter.Fill(this.dataSet.Venta);
            // TODO: esta línea de código carga datos en la tabla 'dataSet.detalleVenta' Puede moverla o quitarla según sea necesario.
            //this.detalleVentaTableAdapter.Fill(this.dataSet.detalleVenta);
            DataTable tabla = DBHelper.Utilidades.Ejecutar("SELECT * FROM Venta WHERE IdVenta = \'" + idVenta + "\'");
            idEmpleado = Convert.ToInt32(tabla.Rows[0].ItemArray[1]);
            idCliente = Convert.ToInt32(tabla.Rows[0].ItemArray[2]);
            idFormaPago = Convert.ToInt32(tabla.Rows[0].ItemArray[3]);
            ventaBindingSource.DataSource = tabla;
            
            tabla = DBHelper.Utilidades.Ejecutar("SELECT * FROM detalleVenta WHERE NroVenta= \'" + idVenta + "\'");
            idArticulo = Convert.ToInt32(tabla.Rows[0].ItemArray[1]);
            detalleVentaBindingSource.DataSource = tabla;

            tabla = DBHelper.Utilidades.Ejecutar("SELECT * FROM Empleado WHERE IdEmpleado = \'" + idEmpleado + "\'");
            empleadoBindingSource.DataSource = tabla;

            tabla = DBHelper.Utilidades.Ejecutar("SELECT * FROM Cliente WHERE IdCliente = \'" + idCliente + "\'");
            clienteBindingSource.DataSource = tabla;

            tabla = DBHelper.Utilidades.Ejecutar("SELECT * FROM Articulo WHERE IdArticulo = \'" + idArticulo + "\'");
            articuloBindingSource.DataSource = tabla;

            tabla = DBHelper.Utilidades.Ejecutar("SELECT * FROM FormaPago WHERE IdTipoFP = \'" + idFormaPago + "\'");
            formaPagoBindingSource.DataSource = tabla;

            this.reportViewer1.RefreshReport();
        }
    }
}
