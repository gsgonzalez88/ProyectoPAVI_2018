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

        int a = 0;
        private void AbmOrden_Load(object sender, EventArgs e)
        {
            cmbEstado.DataSource = Utilidades.Ejecutar("Select * from Estado");
            cmbEstado.DisplayMember = "Descripcion";
            cmbEstado.ValueMember = "IdEstado";
            cmbEstado.SelectedIndex = -1;

            txtNro.Enabled = false;
            cmbTarea.DataSource = Utilidades.Ejecutar("Select * from Tarea");
            cmbTarea.DisplayMember = "Descripcion";
            cmbTarea.ValueMember = "IdTarea";
            cmbTarea.SelectedIndex = -1;

            cmbEncargado.DataSource = Utilidades.Ejecutar("Select (e.Nombre +' '+ e.Apellido)as Empleado,e.IdEmpleado from Empleado e");
            cmbEncargado.DisplayMember = "Empleado";
            cmbEncargado.ValueMember = "IdEmpleado";
            cmbEncargado.SelectedIndex = -1;

            cmbSolicitante.DataSource = Utilidades.Ejecutar("Select (e.Nombre +' '+ e.Apellido)as Empleado,e.IdEmpleado from Empleado e");
            cmbSolicitante.DisplayMember = "Empleado";
            cmbSolicitante.ValueMember = "IdEmpleado";
            cmbSolicitante.SelectedIndex = -1;
          
            a = 1;
            txtTiempo.Visible = false;
            label13.Visible = false;

          
 
        }

        private void cmbTarea_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (a==1)
            {
               DataTable table= Utilidades.Ejecutar("Select * from Tarea where IdTarea =  " + cmbTarea.SelectedValue.ToString());
                txtTiempo.Visible = true;
                label13.Visible = true;
                txtTiempo.Text = table.Rows[0]["TiempoEstimado"].ToString();
                txtTiempo.Enabled = false;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DataTable table = Utilidades.Ejecutar("Select (IdOrden) as Nro from Orden");
            if (table.Rows.Count >0)
            {
                txtNro.Text = table.Rows[0]["Nro"].ToString();
            }
            else
            {
                txtNro.Text = "1";
            }
            
            if (!string.IsNullOrEmpty(txtEquipo.Text))
            {
                if (!string.IsNullOrEmpty(cmbEncargado.Text))
                {
                    if (!string.IsNullOrEmpty(cmbTarea.Text))
                    {
                        if (!string.IsNullOrEmpty(txtFecha.Text))
                        {
                            if (!string.IsNullOrEmpty(cmbEstado.Text))
                            {
                                dvgOrden.Rows.Add(txtNro.Text, txtEquipo.Text, cmbEncargado.Text, cmbSolicitante.Text, cmbTarea.Text, txtFalla.Text,
               txtRespuesta.Text, txtFechaRealizado.Text, txtTiempo.Text, txtFecha.Text, txtTiempoRealizado.Text, cmbEstado.Text);
                            }
                            else
                            {
                                obligatorio(sender, e);
                                return;
                            }
                        } 
                        else
                        {
                        obligatorio(sender, e);
                        return;
                        }
                    }
                    else
                    {
                        obligatorio(sender, e);
                        return;
                    }
                }
                else
                {
                    obligatorio(sender, e);
                    return;
                }
            }
            else
            {
                obligatorio(sender, e);
                return;
            }
           
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta Seguro que desea eliminar?","Infomacion",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (dvgOrden["Nro",0].Value != null )
                    dvgOrden.Rows.Remove(dvgOrden.CurrentRow);
                
               
            }
           
        }

        private void obligatorio(object sender, EventArgs e)
        {
            txtEquipo.BackColor = Color.LightBlue;
            cmbEncargado.BackColor = Color.LightBlue;
            cmbSolicitante.BackColor = Color.LightBlue;
            cmbTarea.BackColor = Color.LightBlue;
            txtFalla.BackColor = Color.LightBlue;
            txtFecha.BackColor = Color.LightBlue;
            cmbEstado.BackColor = Color.LightBlue;
            MessageBox.Show("Complete los campos obligatorios", "Informacion");
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (dvgOrden.Rows[0].Cells["Nro"].Value != null)
            {
                string sql = "";
                sql += "Insert orden Values(" + cmbEncargado.SelectedValue + "," + cmbSolicitante.SelectedValue + ",'" + txtFecha.Text + "'," + cmbEstado.SelectedValue + ")";
                Utilidades.Insert(sql);
                
                for (int i = 0; i < dvgOrden.Rows.Count; i++)
                {
                    if (dvgOrden.Rows[i].Cells["Nro"].Value != null)
                    {
                        string tarea = "Insert TareaOT Values (";
                        var Nro = dvgOrden.Rows[i].Cells["Nro"].Value.ToString();
                        var tot = dvgOrden.Rows[i].Cells["Tarea"].Value.ToString();
                        var equi = dvgOrden.Rows[i].Cells["Equipo"].Value.ToString();
                        var Esta = dvgOrden.Rows[i].Cells["Estado"].Value.ToString();
                        string Falla = dvgOrden.Rows[i].Cells["Falla"].Value.ToString();
                        string Respuesta = dvgOrden.Rows[i].Cells["Respuesta"].Value.ToString();
                        string FechaRealizado = dvgOrden.Rows[i].Cells["FechaRealizado"].Value.ToString();
                        string TiempoRealizado = dvgOrden.Rows[i].Cells["TiempoRealizado"].Value.ToString();
                        tarea += Nro + ",";
                        DataTable tableTarea = Utilidades.Ejecutar("Select IdTarea from Tarea where Descripcion = '" + tot + "'");
                        DataTable tableEquipo = Utilidades.Ejecutar("Select IdEquipo from Equipo where Descripcion = '" + equi + "'");
                        DataTable tableEstado = Utilidades.Ejecutar("Select IdEstado from Estado where Descripcion = '" + Esta + "'");
                        tarea += tableTarea.Rows[0]["IdTarea"] + "," + tableEquipo.Rows[0]["IdEquipo"] + "," + tableEstado.Rows[0]["IdEstado"] + ",";
                        tarea += Falla != "" ? "'"+ Falla.ToString() + "'," : "null";
                        tarea += Respuesta != "" ? "'" + Respuesta.ToString() + "'," : ",null";
                        tarea += FechaRealizado != "" ? "'" + FechaRealizado.ToString() + "'," : ",null";
                        tarea += TiempoRealizado != "" ? "'" + TiempoRealizado.ToString() + "'," : ",null";
                        tarea += ")";
                        Utilidades.Insert(tarea);
                    }

                }
            }
            else
            {
                MessageBox.Show("Cargue datos a la orden");
                return;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
        }

       


    }
}
