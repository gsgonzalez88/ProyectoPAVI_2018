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
using System.Data.SqlClient;

namespace GestorInformatico.GUIlayer
{
    public partial class AbmOrden : Form
    {
        string cadena = "Data Source=DESKTOP-KRHUM84\\SQLEXPRESS;Initial Catalog=Pancho;Integrated Security=True";
        private string idOrden = string.Empty;
        private bool visualizar = false;
        private bool Editartarea = false;
        private bool NuevaA = false;
 
        public AbmOrden( string id, bool ver,bool editar, bool nueva)
        {
            InitializeComponent();
            idOrden = id;
            visualizar = ver;
            Editartarea = editar;
            NuevaA = nueva;
        }

        int a = 0;
        private void AbmOrden_Load(object sender, EventArgs e)
        {
            txtNroTarea.Visible = false;
            if (NuevaA == true)
            {
                btnCerrar.Enabled = false;
                btnRefescar.Enabled = false;
            }
            if (visualizar == true)
            {
                btnRefescar.Enabled = false;
                btnAgregar.Enabled = false;
                btnEliminar.Enabled = false;
                btnUpdate.Enabled = false;
                BtnGuardar.Enabled = false;
                txtCliente.Enabled = false;
                txtDescripcionE.Enabled = false;
                txtFalla.Enabled = false;
                txtFecha.Enabled = false;
                txtFechaRealizado.Enabled = false;
                txtRespuesta.Enabled = false;
                txtTiempoRealizado.Enabled = false;
                cmbTarea.Enabled = false;
                cmbEstado.Enabled = false;
                btnCerrar.Enabled = false;
            }
            if (Editartarea == true)
            {
                txtCliente.Enabled = false;
                txtDescripcionE.Enabled = false;
                btnCerrar.Enabled = true;
                txtFecha.Enabled = false;
                btnRefescar.Enabled = true;
            }
                if (idOrden != string.Empty)
                {
                    BtnGuardar.Enabled = false;
                    llegargrilla(sender, e);
                    txtNro.Text = idOrden;
                    txtNro.Enabled = false;
                    DataTable table = Utilidades.Ejecutar("select es.Descripcion as Estado,(ema.Nombre +' '+ ema.Apellido) as Encargado,(emg.Nombre +' '+ emg.Apellido) as Solicitante,* from Orden o"
                                            + " join Estado es on o.IdEstado = es.IdEstado join Empleado ema on o.IdEmpleadoAsi = ema.IdEmpleado"
                                            + " join Empleado emg on o.IdEmpleadoG  =emg.IdEmpleado where idOrden =" + txtNro.Text);
                    cmbEncargado.Text = table.Rows[0]["Encargado"].ToString();
                    cmbSolicitante.Text = table.Rows[0]["Solicitante"].ToString();
                    cmbEstado.Text = table.Rows[0]["Estado"].ToString();
                    txtFecha.Text = table.Rows[0]["FechaEntrega"].ToString();
                    cmbEncargado.Enabled = false;
                    cmbSolicitante.Enabled = false;

                    DataTable tablet = Utilidades.Ejecutar("Select * from TareaOT where IdOT = " + txtNro.Text);
                    if (tablet.Rows.Count > 0)
                    {
                        cmbEquipo.Text = tablet.Rows[0]["IdEquipo"].ToString();
                        DataTable cliente = Utilidades.Ejecutar("Select * from cliente c join Equipo eq on eq.IdCliente = c.IdCliente");
                         DataTable Equipo = Utilidades.Ejecutar("Select * from Equipo where idEquipo = "+ cmbEquipo.Text);
                        txtCliente.Text = cliente.Rows[0]["NroDoc"].ToString();
                        txtDescripcionE.Text = Equipo.Rows[0]["Descripcion"].ToString();
                        cmbEquipo.Enabled = false;

                    }
                    else
                    {
                        cmbEquipo.DataSource = Utilidades.Ejecutar("Select e.IdEquipo from Equipo e ");
                        cmbEquipo.DisplayMember = "IdEquipo";
                        cmbEquipo.ValueMember = "IdEquipo";
                        cmbEquipo.SelectedIndex = -1;
                    }

                    cmbEstado.DataSource = Utilidades.Ejecutar("Select * from Estado where idEstado != 2");
                    cmbEstado.DisplayMember = "Descripcion";
                    cmbEstado.ValueMember = "IdEstado";

                    cmbTarea.DataSource = Utilidades.Ejecutar("Select * from Tarea");
                    cmbTarea.DisplayMember = "Descripcion";
                    cmbTarea.ValueMember = "IdTarea";
                    cmbTarea.SelectedIndex = -1;
                    a = 1;
                    txtTiempo.Visible = false;
                    label13.Visible = false;
                    return;
                }
                else
                {
                    DataTable table = Utilidades.Ejecutar("Select Max(NroOrden)+1 as NroOrden from Orden");
                    if (table.Rows[0]["NroOrden"].ToString() == "")
                    {
                        txtNro.Text = "1";
                        btnUpdate.Enabled = false;
                    }
                    else
                    {
                        txtNro.Text = table.Rows[0]["NroOrden"].ToString();
                        btnUpdate.Enabled = false;
                    }
                    
                }


                cmbEstado.DataSource = Utilidades.Ejecutar("Select * from Estado where idEstado != 2");
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

                label14.Visible = false;
                label15.Visible = false;
                txtCliente.Visible = false;
                txtDescripcionE.Visible = false;

                cmbEquipo.DataSource = Utilidades.Ejecutar("Select e.IdEquipo from Equipo e");
                cmbEquipo.DisplayMember = "IdEquipo";
                cmbEquipo.ValueMember = "IdEquipo";
                cmbEquipo.SelectedIndex = -1;

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
            if (txtNro.Text == string.Empty)
            {
                            DataTable table = Utilidades.Ejecutar("Select MAX(IdOrden) as Nro from Orden");
                if (table.Rows.Count > 0)
                {
                    txtNro.Text = table.Rows[0]["Nro"].ToString();
                }
                else
                {
                    txtNro.Text = "1";
                }
            }
            
            if (!string.IsNullOrEmpty(cmbEquipo.Text))
            {
                if (!string.IsNullOrEmpty(cmbEncargado.Text))
                {
                    if (!string.IsNullOrEmpty(cmbTarea.Text))
                    {
                        if (!string.IsNullOrEmpty(txtFecha.Text))
                        {
                            if (!string.IsNullOrEmpty(cmbEstado.Text))
                            {
                                if (!string.IsNullOrEmpty(txtFalla.Text))
                                {
                                    dvgOrden.Rows.Add(txtNro.Text, cmbEquipo.Text, cmbEncargado.Text, cmbSolicitante.Text, cmbTarea.Text, txtFalla.Text,
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
            cmbEquipo.BackColor = Color.LightBlue;
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
            SqlTransaction trasanccion;
            SqlCommand comando = new SqlCommand();
            SqlConnection conexion = new SqlConnection();
            conexion.ConnectionString = cadena;

            conexion.Open();
            trasanccion = conexion.BeginTransaction();
            comando.Connection = conexion;
            comando.Transaction = trasanccion;
            try
            {
                if (dvgOrden.Rows[0].Cells["Nro"].Value != null)
                {
                    string sql = ""; string tarea = "";
                    sql += "Insert orden Values("  + txtNro.Text +","+cmbEncargado.SelectedValue + "," + cmbSolicitante.SelectedValue + ",'" + txtFecha.Text + "'," + cmbEstado.SelectedValue + ")";

               

                    for (int i = 0; i < dvgOrden.Rows.Count; i++)
                    {
                        
                        if (dvgOrden.Rows[i].Cells["Nro"].Value != null)
                        {
                            tarea = "";
                             tarea = "Insert TareaOT Values (";
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
                            DataTable tableEquipo = Utilidades.Ejecutar("Select IdEquipo from Equipo where IdEquipo = '" + equi + "'");
                            DataTable tableEstado = Utilidades.Ejecutar("Select IdEstado from Estado where Descripcion = '" + Esta + "'");
                            tarea += tableTarea.Rows[0]["IdTarea"] + "," + tableEquipo.Rows[0]["IdEquipo"] + "," + tableEstado.Rows[0]["IdEstado"] + ",";
                            tarea += "'" + Falla.ToString() + "',";
                            tarea += Respuesta != "" ? "'" + Respuesta.ToString() + "'," : "null,";
                            tarea += FechaRealizado != "" ? "'" + FechaRealizado.ToString() + "'," : "null,";
                            tarea += TiempoRealizado != "" ? "'" + TiempoRealizado.ToString() + "'," : "null";
                            tarea += ")";
                            if (i != 0)
	                        {
                                sql += tarea;
	                        }
                            else
                            {
                                sql +=  tarea;
                            }
                           
                        }
                        

                    }
                    
                    comando.CommandText = sql;
                    comando.ExecuteNonQuery();
                    trasanccion.Commit();
                    MessageBox.Show("Se guardo Correctamente", "Informacion");
                    return;
                }
                else
                {
                    MessageBox.Show("Cargue datos a la orden");
                    return;
                }
            }
            catch (Exception ex)
            {
                trasanccion.Rollback();
                MessageBox.Show("Error de carga : "+ex.Message);
                return;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (a==1)
            {
                txtCliente.Text = "";
                txtDescripcionE.Text = "";
                DataTable table = Utilidades.Ejecutar("Select c.NroDoc, * from Equipo e "
                +"join Cliente c on c.IdCliente = e.IdCliente where e.IdEquipo = " + cmbEquipo.SelectedValue+"and  e.IdEstado = 1");
                label14.Visible = true;
                label15.Visible = true;
                txtCliente.Visible = true;
                txtDescripcionE.Visible = true;
                txtCliente.Text = table.Rows[0]["NroDoc"].ToString();
                txtDescripcionE.Text = table.Rows[0]["Descripcion"].ToString();
                txtCliente.Enabled = false;
                txtDescripcionE.Enabled = false;
            }
        }

        private void llegargrilla(object sender , EventArgs e)
        {
            DataTable table = Utilidades.Ejecutar("Select  (ema.Nombre +' '+ema.Apellido) as Encargado ,(emg.Nombre +' '+emg.Apellido) as Solicitante,"
            +" t.Descripcion as Tarea,t.TiempoEstimado as TiempoPrevisto,e.Descripcion as Equipo , es.Descripcion as Estado, o.FechaEntrega as FechaEntrega,* from TareaOT tot join Equipo e on e.IdEquipo = tot.IdEquipo"
            + " join Tarea t on tot.IdTarea = t.IdTarea "
            +" join Orden o on o.IdOrden = tot.IdOT"
            + " join Empleado ema on o.IdEmpleadoAsi = ema.IdEmpleado "
            +" join Empleado emg on o.IdEmpleadoG = emg.Idempleado "
            + " join Estado es on tot.IdEstado = es.IdEstado where idOT = " + idOrden);
            if (table.Rows.Count>0)
            {
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    dvgOrden.Rows.Add(table.Rows[i]["Id"].ToString()
                                   , table.Rows[i]["Equipo"].ToString()
                                   , table.Rows[i]["Encargado"].ToString()
                                   ,table.Rows[i]["Solicitante"].ToString()
                                   , table.Rows[i]["Tarea"].ToString()
                                   , table.Rows[i]["Falla"].ToString()
                                    , table.Rows[i]["Respuesta"].ToString()
                                    , table.Rows[i]["FechaRealizado"].ToString()
                                    , table.Rows[i]["TiempoPrevisto"].ToString()
                                    , table.Rows[i]["FechaEntrega"].ToString()
                                    ,table.Rows[i]["TiempoRealizado"].ToString()
                                    , table.Rows[i]["Estado"].ToString());
                }
            }
            
        }

        private void btnUpdate_Click(object sender,EventArgs e)
        {
            if (txtNroTarea.Text != "")
	        {
                string update = " Update TareaOT SET ";
                if (!string.IsNullOrEmpty(txtFechaRealizado.Text))
                {
                    update += "FechaRealizado = '" + txtFechaRealizado.Text+"'";
                }
                else
                {
                    MessageBox.Show("Complete el Fecha realizada", "Informacion");
                    return;
                }
                if (!string.IsNullOrEmpty(txtTiempoRealizado.Text))
                {
                    update += ",TiempoRealizado = " + txtTiempoRealizado.Text;
                }
                else
                {
                    MessageBox.Show("Complete el tiempo realizado", "Informacion");
                    return;
                }
                if (!string.IsNullOrEmpty(txtRespuesta.Text))
                {
                     update += ",Respuesta ='" + txtRespuesta.Text +"'";
                }
                else
                {
                    MessageBox.Show("Complete el Respuesta", "Informacion");
                    return;
                }
                update += ",IdEstado = " + cmbEstado.SelectedValue;
                update += " where Id = " + txtNroTarea.Text;

                Utilidades.Update(update);
                MessageBox.Show("Se guardo Correctamente", "Informacion");
	        } 
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Esta Seguro que desea Cerrar la Orden?","Informacion",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SqlTransaction trasanccion;
                SqlCommand comando = new SqlCommand();
                SqlConnection conexion = new SqlConnection();
                conexion.ConnectionString = cadena;

                conexion.Open();
                trasanccion = conexion.BeginTransaction();
                comando.Connection = conexion;
                comando.Transaction = trasanccion;
                try
                {
                    comando.CommandText = "Update Orden set idEstado  = 5 where idOrden ="+txtNro.Text;
                    comando.ExecuteNonQuery();
                    comando.CommandText = "Update TareaOT set idEstado = 5 where idOT = " + txtNro.Text;
                    comando.ExecuteNonQuery();
                    trasanccion.Commit();
                    conexion.Close();
                }
                catch (Exception ex)
                {

                    trasanccion.Rollback();
                    MessageBox.Show("Error de carga : " + ex.Message);
                    return; 
                }
    
            }
            
        }

        private void dvgOrden_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >-1 && dvgOrden.Rows[e.RowIndex].Cells[0].Value != null)
            {
                if (dvgOrden.Rows[e.RowIndex].Cells["Nro"].Value != null)
                {
                    txtNroTarea.Text = dvgOrden.Rows[e.RowIndex].Cells["Nro"].Value.ToString();
                    btnAgregar.Enabled = false;
                    txtFalla.Enabled = false;
                    cmbTarea.Enabled = false;
                    txtFalla.Text = dvgOrden.Rows[e.RowIndex].Cells["Falla"].Value.ToString();
                    cmbEncargado.Text = dvgOrden.Rows[e.RowIndex].Cells["Encargado"].Value.ToString();
                    cmbSolicitante.Text = dvgOrden.Rows[e.RowIndex].Cells["Solicitante"].Value.ToString();
                    cmbTarea.Text = dvgOrden.Rows[e.RowIndex].Cells["Tarea"].Value.ToString();
                    cmbEstado.Text = dvgOrden.Rows[e.RowIndex].Cells["Estado"].Value.ToString();
                    if (dvgOrden.Rows[e.RowIndex].Cells["Respuesta"].Value.ToString() != "")
                    {
                        txtRespuesta.Text = dvgOrden.Rows[e.RowIndex].Cells["Respuesta"].Value.ToString();
                        txtRespuesta.Enabled = false;
                    }
                    if (dvgOrden.Rows[e.RowIndex].Cells["FechaRealizado"].Value.ToString() != "")
                    {

                        txtFechaRealizado.Text = dvgOrden.Rows[e.RowIndex].Cells["FechaRealizado"].Value.ToString();
                        txtFechaRealizado.Enabled = false;
                    }
                    if (dvgOrden.Rows[e.RowIndex].Cells["FechaEntrega"].Value.ToString() != "")
                    {
                        txtFecha.Text = dvgOrden.Rows[e.RowIndex].Cells["FechaEntrega"].Value.ToString();
                    }
                    if (dvgOrden.Rows[e.RowIndex].Cells["TiempoRealizado"].Value.ToString() != "")
                    {
                          txtTiempoRealizado.Text = dvgOrden.Rows[e.RowIndex].Cells["TiempoRealizado"].Value.ToString();
                        txtTiempoRealizado.Enabled = false;
                    }
                }
                else
                {
                    if (visualizar ==true && NuevaA == false)
                    {
                        btnAgregar.Enabled = false;
                    }
                    else
                    {

                        btnAgregar.Enabled = true;
                        txtFalla.Enabled = true;
                        cmbTarea.Enabled = true;
                    }
                  
                }
            }
       
        }

        private void btnRefescar_Click(object sender, EventArgs e)
        {
            llegargrilla(sender, e);
        }

  
    }
}
