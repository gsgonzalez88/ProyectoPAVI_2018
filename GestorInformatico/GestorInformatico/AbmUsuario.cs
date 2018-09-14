using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorInformatico
{
    public partial class AbmUsuario : Form
    {
        public AbmUsuario()
        {
            InitializeComponent();
        }

        private void AbmUsuario_Load(object sender, EventArgs e)
        {
            LlenarGrilla();
            txtContraAnterior.Enabled = false;
            rbtActivo.Visible = false;
            rbtInactivo.Visible = false;
            label4.Visible = false;
            txtContraAnterior.Enabled = false;
            label5.Visible = true;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
        }

        private void LlenarGrilla()
        {
            DataTable tabla = Milibreria.Utilidades.Ejecutar("Select  em.Nombre as NombreEmpleado,em.Apellido,e.Descripcion as Estado,* from Usuario u "
            +" left outer join Estado e on e.idEstado = u.IdEstado"
            +" left outer join Empleado em on u.IdEmpleado = em.IdEmpleado");
            dgvUsuario.Rows.Clear();
            if (tabla.Rows.Count > 0)
            {
                for (int i = 0; i < tabla.Rows.Count; i++)
                {
                    dgvUsuario.Rows.Add(tabla.Rows[i]["Nombre"]
                         , tabla.Rows[i]["Estado"]
                        , tabla.Rows[i]["NombreEmpleado"]
                        ,tabla.Rows[i]["Apellido"]
                        );
                }

            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUsuario.Text))
            {
            rbtActivo.Visible = true;
            rbtInactivo.Visible = true;
            label4.Visible = true;
            txtNro.Enabled = false;
                DataTable table = Milibreria.Utilidades.Ejecutar("select e.NroDoc,* from Usuario u"
                + " join Empleado e on u.IdEmpleado = e.IdEmpleado where u.Nombre ='" + txtUsuario.Text + "'");
                if (table.Rows.Count>0)
                {
                    txtNro.Text = table.Rows[0]["NroDoc"].ToString();
                    txtContraAnterior.Enabled = true;
                     int estado = Convert.ToInt32( table.Rows[0]["IdEstado"].ToString());
                     if (estado == 1)
                    {
                        rbtActivo.Checked = true;
                    }
                     else
                     {
                         if (estado == 2)
                         {
                            rbtInactivo.Checked = true;
                         }
                     }
                }
                else
                {
                    MessageBox.Show("No existe el usuario", "Informacion");
                    return;
                }

            }
            else
            {
                MessageBox.Show("Complete el Campo", "Informacion");
                txtUsuario.Focus();
                return;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            DataTable table;
            txtContraAnterior.Enabled = false;
            if (!string.IsNullOrEmpty(txtUsuario.Text))
            {
                if (!string.IsNullOrEmpty(txtContraseña.Text))
                {
                    if (!string.IsNullOrEmpty(txtConfirmar.Text))
                    {
                        if (txtConfirmar.Text == txtContraseña.Text)
                        {
                            if (!string.IsNullOrEmpty(txtNro.Text))
                            {
                                table = Milibreria.Utilidades.Ejecutar("Select IdEmpleado from Empleado where NroDoc = " + txtNro.Text);
                                Milibreria.Utilidades.Insert("Insert Usuario values ('" + txtUsuario.Text + "'," + txtContraseña.Text + "," + table.Rows[0]["IdEmpleado"].ToString()+",1)");
                                MessageBox.Show("Creacion de usuario Exitosa", "Informacion");
                                return;
                            }
                            else
                            {
                                MessageBox.Show("Ingrese nro de empelado", "Informacion");
                                label9.Visible = true;
                                txtNro.Focus();
                                return;
                            }
                           
                        }
                        else
                        {
                            MessageBox.Show("Las Contraseñas no coinciden", "Informacion");
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Complete el Campo", "Informacion");
                        label8.Visible = true;
                        txtConfirmar.Focus();
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Complete el Campo", "Informacion");
                    label7.Visible = true;
                    txtContraseña.Focus();
                   
                    return;
                }

            }
            else
            {
                MessageBox.Show("Complete el Campo", "Informacion");
                label6.Visible = true;
                txtUsuario.Focus();
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LlenarGrilla();
            rbtActivo.Visible = false;
            rbtInactivo.Visible = false;
            label4.Visible = false;
            txtUsuario.Text = "";
            txtNro.Text = "";
            txtContraseña.Text = "";
            txtConfirmar.Text = "";
            txtContraAnterior.Text = "";
            txtContraAnterior.Enabled = false;
            rbtActivo.Checked = false;
            rbtInactivo.Checked = false;
            txtNro.Enabled = true;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUsuario.Text))
            {
                Milibreria.Utilidades.Update("Update Usuario  set IdEstado =2 where Nombre = '" + txtUsuario.Text+"'");
                MessageBox.Show("Usuario Dado de Baja", "Informacion");
                return;
            }
            else
            {
                MessageBox.Show("Complete el Campo", "Informacion");
                txtUsuario.Focus();
                return;
            }

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUsuario.Text))
            {
               DataTable table=  Milibreria.Utilidades.Ejecutar("select e.IdEmpleado,* from Usuario u"
                + " join Empleado e on u.IdEmpleado = e.IdEmpleado where u.Nombre ='" + txtUsuario.Text + "'");
               txtNro.Text = table.Rows[0]["NroDoc"].ToString();
               if (txtUsuario.Text != table.Rows[0]["Nombre"].ToString() || txtUsuario.Text == table.Rows[0]["Nombre"].ToString())
               {
                   string sql = "update usuario set Nombre ='" + txtUsuario.Text;
                   if (txtContraAnterior.Text != table.Rows[0]["Contraseña"].ToString() && !string.IsNullOrEmpty(txtContraAnterior.Text))
                   {
                       MessageBox.Show("Contraseña Anterior incorrecta", "Informacion");
                       return;
                   }
                   else
                   {
                       if (!string.IsNullOrEmpty(txtContraseña.Text) || !string.IsNullOrEmpty(txtConfirmar.Text))
                       {
                           if (txtContraseña.Text == txtConfirmar.Text)
                           {
                               sql += "',Contraseña = " + txtContraseña.Text + ",";
                           }
                           else
                           {
                               MessageBox.Show("Contraseña no coinciden", "Informacion");
                               return;
                           }
                          
                       }
                       else
                       {
                           sql += "',Contraseña = " + table.Rows[0]["Contraseña"].ToString() + ",";
                       }
                   }
                   if (rbtInactivo.Checked)
                   {
                       sql += " IdEstado = " + 2;

                   }
                   if (rbtActivo.Checked)
                   {
                       sql += " IdEstado = " + 1;

                   }
                   sql += " where IdEmpleado =  " + table.Rows[0]["IdEmpleado"].ToString() + " and IdUsuario = " + table.Rows[0]["IdUsuario"].ToString();
                   Milibreria.Utilidades.Update(sql);
                   MessageBox.Show("Actulizacion Correcta", "Informacion");
                   return;
               }
            }
            else
            {
                MessageBox.Show("Complete el Campo", "Informacion");
                txtUsuario.Focus();
                return;
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
