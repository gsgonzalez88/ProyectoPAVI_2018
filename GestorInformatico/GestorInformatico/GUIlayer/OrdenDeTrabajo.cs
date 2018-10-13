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
        string idUsuarioSeleccionado;
        bool ver = false;
        bool editar = false;

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

            llenargrilla(sender,e, sql);
            a = 1;
            btnCerrar.Enabled = false;
            btnBuscar.Enabled = false;
        }

        private void llenargrilla(object sender, EventArgs e,string sql)
        {
            DataTable table;
            string eje= "select distinct tot.IdOT,(emA.Apellido + '' +emA. Nombre) as Encargado ,es.Descripcion as Estado,(emG.Apellido + ' '+ emG.Nombre) as Solicitante,eq.Descripcion as Equipo,o.FechaEntrega from TareaOT tot"+
          " join Orden o on o.IdOrden = tot.IdOT left  join Empleado emA on emA.IdEmpleado = o.IdEmpleadoAsi left  join Empleado emG on emG.IdEmpleado = o.IdEmpleadoG" +
          " join Estado	 es on es.IdEstado = o.IdEstado  join Equipo eq on tot.IdEquipo = eq.IdEquipo";
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
                    dataGridView1.Rows.Add(table.Rows[i]["IdOT"].ToString()
                                   ,table.Rows[i]["Equipo"].ToString()
                                   , table.Rows[i]["Encargado"].ToString()
                                    , table.Rows[i]["Solicitante"].ToString()
                                    , table.Rows[i]["FechaEntrega"].ToString()
                                    , table.Rows[i]["Estado"].ToString());
                }

            }
            else
            {
                MessageBox.Show("No existe orden");
               
            }
          
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (a==1)
            {
                sql = "";
                if (cmbMarca.SelectedIndex != -1)
                {
                    sql += " where eq.idMarca = " + cmbMarca.SelectedValue.ToString();
                    llenargrilla(sender, e, sql);
                    cmbEstado.Enabled = false;
                }
               
            }
                    
        }

        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (a==1)
	        {
                sql = "";
                if (cmbEstado.SelectedIndex != -1)
                {
                    sql += " where o.IdEstado = " + cmbEstado.SelectedValue.ToString();
                    llenargrilla(sender, e, sql);
                    cmbMarca.Enabled = false;
                }
             
         
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ver = true;
            if (idUsuarioSeleccionado != string.Empty)
            {
                AbmOrden orden = new AbmOrden(idUsuarioSeleccionado,ver,editar);
                orden.ShowDialog();
            }
        }

        private void btnRefescar_Click(object sender, EventArgs e)
        {
            cmbEstado.Enabled = true;
            cmbMarca.Enabled = true;
            cmbEstado.SelectedIndex = -1;
            cmbMarca.SelectedIndex = -1;
            llenargrilla(sender,e,sql="");
        }

        private void btnNueva_Click(object sender, EventArgs e)
        {
            idUsuarioSeleccionado = string.Empty;
            AbmOrden orden = new AbmOrden(idUsuarioSeleccionado,ver,editar);
            orden.ShowDialog();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            editar = true;
            if (idUsuarioSeleccionado != string.Empty)
            {
                AbmOrden orden = new AbmOrden(idUsuarioSeleccionado,ver,editar);
                orden.ShowDialog();
            }
           
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idUsuarioSeleccionado = "";
            if (e.RowIndex > -1)
            {
                
                 idUsuarioSeleccionado = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                DataTable orden = Utilidades.Ejecutar("select * from Orden where IdOrden = "+idUsuarioSeleccionado.ToString());
                if (orden.Rows[0]["IdEstado"].ToString() == "5")
                {
                    btnCerrar.Enabled = false;
                    btnBuscar.Enabled = true;
                    
                }
                else
                {
                    btnCerrar.Enabled = true;
                    btnBuscar.Enabled = true;
                }
               
            }
        }

    }
}
