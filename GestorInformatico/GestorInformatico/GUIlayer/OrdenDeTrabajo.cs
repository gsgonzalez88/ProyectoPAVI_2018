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
        string sql = "";
        int a = 0;
        private void OrdenDeTrabajo_Load(object sender, EventArgs e)
        {
            cmbMarca.DataSource = Utilidades.Ejecutar("Select * from Marca");
            cmbMarca.DisplayMember = "Descripcion";
            cmbMarca.ValueMember = "IdMarca";
            cmbMarca.SelectedIndex = -1;

            cmbEstado.DataSource = Utilidades.Ejecutar("Select * from Estado");
            cmbEstado.DisplayMember = "Descripcion";
            cmbEstado.ValueMember = "IdEstado";
            cmbEstado.SelectedIndex = -1;

            cmbTarea.DataSource = Utilidades.Ejecutar("Select * from Tarea");
            cmbTarea.DisplayMember = "Descripcion";
            cmbTarea.ValueMember = "IdTarea";
            cmbTarea.SelectedIndex = -1;
            llenargrilla(sender,e, sql);
            a = 1;
        }

        private void llenargrilla(object sender, EventArgs e,string sql)
        {
            DataTable table;
            string eje= "select e.Descripcion as Equipo ,t.Descripcion as Tarea,(em.Nombre +' '+em.Apellido) as EmpleadoG,es.Descripcion as Estado ,"
            + "(ema.Nombre +' '+ema.Apellido) as EmpleadoA, * from Orden o"
            + " join Equipo e on e.IdEquipo = o.IdEquipo"
            + " join Tarea t on o.IdTarea = t.IdTarea"
            + " join Empleado em on em.IdEmpleado=o.IdEmpleadoG"
            + " join Estado es on es.IdEstado = o.IdEstado"
            + " join Empleado ema on ema.IdEmpleado=o.IdEmpleadoAsi";
            if (!string.IsNullOrEmpty(sql))
	            {
                    eje += sql;    
	            }
            table = Utilidades.Ejecutar(eje);
            
            dataGridView1.Rows.Clear();
            if (table.Rows.Count > 0)
            {

                for (int i = 0; i < table.Rows.Count; i++)
                {
                    dataGridView1.Rows.Add(table.Rows[i]["IdOrden"].ToString()
                                   , table.Rows[i]["Equipo"].ToString()
                                   , table.Rows[i]["EmpleadoA"].ToString()
                                   , table.Rows[i]["Tarea"].ToString()
                                   , table.Rows[i]["Falla"].ToString()
                                    ,table.Rows[i]["Respuesta"].ToString()
                                    , table.Rows[i]["EmpleadoG"].ToString()
                                    , table.Rows[i]["TiempoRealizado"].ToString()
                                    , table.Rows[i]["FechaEntrega"].ToString()
                                    , table.Rows[i]["Estado"].ToString());
                }

            }
            else
            {
                MessageBox.Show("No existe orden");
               
            }
          
        }

        private void btnVerEquipo_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (a==1)
            {
                sql = ""; 
                sql += " where e.idMarca = " + cmbMarca.SelectedValue.ToString();
                llenargrilla(sender, e, sql);
                cmbTarea.Enabled = false;
                cmbEstado.Enabled = false;
            }
                    
        }

        private void cmbTarea_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (a == 1)
            {
                sql = ""; 
                sql += " where o.IdTarea = " + cmbTarea.SelectedValue.ToString();
                llenargrilla(sender, e, sql);
                cmbMarca.Enabled = false;
                cmbEstado.Enabled = false;
            }
        }

        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (a==1)
	        {
                sql = "";
            sql += " where o.IdEstado = " + cmbEstado.SelectedValue.ToString();
            llenargrilla(sender, e, sql);
            cmbTarea.Enabled = false;
            cmbEstado.Enabled = false;
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBuscar.Text))
            {
             
                if (cmbEstado.SelectedIndex != -1)
                {
                    sql += " and o.Nro = " + txtBuscar.Text;
                    llenargrilla(sender, e, sql);
                    return;
                }
                if (cmbMarca.SelectedIndex != -1)
                {
                    sql += " and o.Nro = " + txtBuscar.Text;
                    llenargrilla(sender, e, sql);
                    return;
                }
                if (cmbTarea.SelectedIndex != -1)
                {
                     sql += " and o.Nro = " + txtBuscar.Text;
                    llenargrilla(sender, e, sql);
                      return;
                }
	           if (!string.IsNullOrEmpty(txtBuscar.Text))
               { sql += " where o.Nro = " + txtBuscar.Text;
                    llenargrilla(sender, e, sql);
                   return;
               }
                

            }
            else
            {
                txtBuscar.BackColor = Color.LightBlue;
                MessageBox.Show("Complete el campo");
            }
        }

        private void btnRefescar_Click(object sender, EventArgs e)
        {
            cmbTarea.Enabled = true;
            cmbEstado.Enabled = true;
            cmbMarca.Enabled = true;
            txtBuscar.Text = "";
        }

        private void btnNueva_Click(object sender, EventArgs e)
        {
            AbmOrden orden = new AbmOrden();
            orden.ShowDialog();
        }

    }
}
