using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Milibreria;

namespace GestorInformatico
{
    public partial class ABMCliente : Form
    {
        public ABMCliente()
        {
            InitializeComponent();
        }
        int a = 0;
       

        private void ABMCliente_Load(object sender, EventArgs e)
        {
          
            cmbBarrio.SelectedIndex = -1;
            cmbDepto.SelectedIndex = -1;
            cmbLocalidad.SelectedIndex = -1;
          
            cmbProvin.DataSource = Milibreria.Utilidades.Ejecutar("Select * from Provincia");
            cmbProvin.DisplayMember = "Descripcion";
            cmbProvin.ValueMember = "idProvincia";
            cmbProvin.SelectedIndex = -1;

            cmbTdoc.DataSource = Milibreria.Utilidades.Ejecutar("Select * from TipoDoc"); 
            cmbTdoc.DisplayMember = "Descripcion";
            cmbTdoc.ValueMember = "IdTipoDoc";
            cmbTdoc.SelectedIndex = -1;

            DataTable tabla = Milibreria.Utilidades.Ejecutar("Select  e.Descripcion as Estado,* from cliente c  left outer join Estado e on e.idEstado = c.IdEstado");
            dgvParticular.Rows.Clear();
            if (tabla.Rows.Count >0)
            {
                for (int i = 0; i < tabla.Rows.Count; i++)
                {
                    dgvParticular.Rows.Add(tabla.Rows[i]["Nombre"]
                        , tabla.Rows[i]["Apellido"]
                        , tabla.Rows[i]["NroDoc"]
                        , tabla.Rows[i]["Cuit"]
                        , tabla.Rows[i]["Estado"]
                        );
                }
               
            }


            a = 1;
           
        }

        private void EstaSeguro(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Desea salir sin guardar??", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbmBarrio frmBarrio = new AbmBarrio();
            frmBarrio.ShowDialog();
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            AbmLocalidad loc = new AbmLocalidad();
            loc.ShowDialog();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (rbtEmpresa.Checked || rbtParticular.Checked )
            {
                if (txtNom.Text != "")
                {
                    if (txtCalle.Text != "")
                    {
                        if (cmbProvin.Text != "" || cmbProvin.SelectedIndex != -1)
                        {
                            if (cmbDepto.Text != "" || cmbDepto.SelectedIndex != -1)
                            {
                                if (cmbLocalidad.Text != "" || cmbLocalidad.SelectedIndex != -1)
                                {
                                    if (cmbBarrio.Text != "" || cmbBarrio.SelectedIndex != -1)
                                    {
                                        if (txtNroCalle.Text != "")
                                        {
                                            if (rbtEmpresa.Checked == true)
                                            {
                                                if (txtCuit.Text != "")
                                                {

                                                    Insert(sender, e);
                                                }
                                                else
                                                {
                                                    MessageBox.Show("Debe ingresar Cuit", "Informacion");
                                                    txtCuit.Focus();
                                                }

                                            }
                                            else
                                            {
                                                if (txtApellido.Text != "")
                                                {
                                                    if (cmbTdoc.Text != "" || cmbTdoc.SelectedIndex != -1)
                                                    {
                                                        if (txtNroDoc.Text != "")
                                                        {
                                                            Insert(sender, e);
                                                        }
                                                        else
                                                        {
                                                            MessageBox.Show("Debe ingresar Nro", "Informacion");
                                                            txtNroDoc.Focus();
                                                        }
                                                    }
                                                    else
                                                    {
                                                        MessageBox.Show("Debe ingresar Tipo Documento", "Informacion");
                                                        cmbTdoc.Focus();
                                                    }
                                                }
                                                else
                                                {
                                                    MessageBox.Show("Debe ingresar Apellido", "Informacion");
                                                    txtApellido.Focus();
                                                }


                                            }

                                        }
                                        else
                                        {
                                            MessageBox.Show("Debe ingresar un nro Calle", "Informacion");
                                            txtNroCalle.Focus();
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Debe ingresar un Barrio", "Informacion");
                                        cmbBarrio.Focus();
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Debe ingresar una Localidad", "Informacion");
                                    cmbLocalidad.Focus();
                                }
                            }

                            else
                            {
                                MessageBox.Show("Debe ingresar una Departamento", "Informacion");
                                cmbDepto.Focus();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Debe ingresar una Provincia", "Informacion");
                            cmbProvin.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Debe ingresar una Calle", "Informacion");
                        txtCalle.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Debe ingresar un Nombre", "Informacion");
                    txtNom.Focus();
                }

      
            }
            else
            {
                MessageBox.Show("Seleccione un tipo de cliente", "Informacion");
            }
           
           
                

  
        }

        private void cmbProvin_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ( a ==1 && cmbProvin.SelectedValue !=null)
            {
                a = 0;
            cmbDepto.DataSource = Milibreria.Utilidades.Ejecutar("Select * from Departamento where IdProvincia = " + cmbProvin.SelectedValue.ToString());
            cmbDepto.DisplayMember = "Descripcion";
            cmbDepto.ValueMember = "IdDepartamento";
            cmbDepto.SelectedIndex = -1;
            a = 1;
            }
            cmbDepto.SelectedIndex = -1;
            cmbLocalidad.SelectedIndex = -1;
            cmbBarrio.SelectedIndex = -1;
        }

        private void cmbDepto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (a == 1 && cmbDepto.SelectedValue != null)
            {
                a = 0;
                cmbLocalidad.DataSource = Milibreria.Utilidades.Ejecutar("Select * from Localidad where IdDepartamento = " + cmbDepto.SelectedValue.ToString());
                cmbLocalidad.DisplayMember = "Descripcion";
                cmbLocalidad.ValueMember = "IdLocalidad";
                cmbLocalidad.SelectedIndex = -1;
                a = 1;
            }
            cmbLocalidad.SelectedIndex = -1;
            cmbBarrio.SelectedIndex = -1;
        }

        private void cmbLocalidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (a == 1 && cmbLocalidad.SelectedValue != null)
            {
                a = 0;
                cmbBarrio.DataSource = Milibreria.Utilidades.Ejecutar("Select * from Barrio where IdLocalidad = " + cmbLocalidad.SelectedValue.ToString()); 
            cmbBarrio.DisplayMember = "Descripcion";
            cmbBarrio.ValueMember = "IdBarrio";
            cmbBarrio.SelectedIndex = -1;
            a = 1;
            }
            cmbBarrio.SelectedIndex = -1;
        }

        private void rbtParticular_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtParticular.Checked)
            {
                label6.Visible = false;
                txtCuit.Visible = false;
                rbtEmpresa.Visible = false;
                txtApellido.Visible = true;
                txtNroDoc.Visible = true;
                cmbTdoc.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                
            }
            else
            {
                label6.Visible = true;
                txtCuit.Visible = true;
                rbtEmpresa.Visible = true;
               
            }
        }

        private void limpiar(object sender,EventArgs e)
        {
            a = 0;
            txtApellido.Text = "";
            txtCalle.Text = "";
            txtCuit.Text = "";
            txtEmail.Text = "";
            txtNom.Text = "";
            txtNroCalle.Text = "";
            txtNroDoc.Text = "";
            txtBuscar.Text = "";
            txtTelefono.Text = "";
            cmbTdoc.Text="";
            cmbProvin.Text = "";
            cmbDepto.Text = "";
            cmbLocalidad.Text = "";
            cmbBarrio.Text = "";
            rbtEmpresa.Checked = false;
            rbtParticular.Checked = false;
            txtApellido.Visible = true;
            txtNroDoc.Visible = true;
            cmbTdoc.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            a = 1;
         }

        private void button5_Click(object sender, EventArgs e)
        {
            int nro;
            if (txtBuscar.Text != "")
            {



                nro = Convert.ToInt32(txtBuscar.Text);

                DataTable table = Milibreria.Utilidades.ConsultarCliente(nro);

                if (table.Rows.Count > 0)
                {

                    string tipo = table.Rows[0]["TipoCliente"].ToString();
                    string check = table.Rows[0]["Eliminado"].ToString();
                    if (tipo == "Empresa")
                    {
                        rbtEmpresa.Checked = true;
                        txtCuit.Text = table.Rows[0]["Cuit"].ToString();
                        rbtParticular.Visible = false;
                    }
                    else
                    {
                        rbtParticular.Checked = true;
                        txtCuit.Visible = false;
                        rbtEmpresa.Visible = false;
                    }
                    txtNom.Text = table.Rows[0]["Nombre"].ToString();
                    txtApellido.Text = table.Rows[0]["Apellido"].ToString();
                    txtNroDoc.Text = table.Rows[0]["NroDoc"].ToString();
                    txtTelefono.Text = table.Rows[0]["nroTelefono"].ToString();
                    txtEmail.Text = table.Rows[0]["Email"].ToString();
                    txtNroCalle.Text = table.Rows[0]["NroCalle"].ToString();
                    txtCalle.Text = table.Rows[0]["Calle"].ToString();
                    cmbTdoc.SelectedText = table.Rows[0]["TipoDoc"].ToString();
                    cmbProvin.SelectedText = table.Rows[0]["Prov"].ToString();
                    cmbDepto.SelectedText = table.Rows[0]["Depto"].ToString();
                    cmbBarrio.SelectedText = table.Rows[0]["Barrio"].ToString();
                    cmbLocalidad.SelectedText = table.Rows[0]["Localidad"].ToString();
                  
                }
                else
                {
                    MessageBox.Show("No existe el cliente", "Informacion");
                }
            }
            else
            {
                MessageBox.Show("Ingrese un nro de documento", "Informacion");
            }
            

        }

        private void rbtEmpresa_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtEmpresa.Checked)
            {
                
                rbtParticular.Visible = false;
                txtApellido.Visible = false;
                txtNroDoc.Visible = false;
                cmbTdoc.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                dgvParticular.Visible = false;
               
            }
            else
            {
                rbtParticular.Visible = true;

            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int nro;
            if (rbtEmpresa.Checked)
	        {
		 
	
            if (txtBuscar.Text != "")
            {
                nro = Convert.ToInt32(txtBuscar.Text);

                Milibreria.Utilidades.Ejecutar("delete from Cliente where Cuit =  " + txtBuscar.Text);
                MessageBox.Show("Empresa  eliminado", "Informacion");
            }
            else
            {
                MessageBox.Show("Busque el cliente a eliminar","Informacion");
            }
          }
            if (rbtParticular.Checked)
            {
               
            if (txtBuscar.Text != "")
            {
                nro = Convert.ToInt32(txtBuscar.Text);

                Milibreria.Utilidades.Ejecutar("delete from Cliente where NroDoc =  " + txtBuscar.Text);
                MessageBox.Show("Empresa  eliminado", "Informacion");
            }
            else
            {
                MessageBox.Show("Busque el cliente a eliminar","Informacion");
            } 
            }
            
        }



        private void Insert(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            if (rbtParticular.Checked)
            {
                table = Milibreria.Utilidades.Ejecutar("select c.NroDoc from Cliente c where c.NroDoc =" + txtNroDoc.Text);
            }
            else
            {
                table = Milibreria.Utilidades.Ejecutar("select c.Cuit from Cliente c where c.Cuit =" + txtCuit.Text);
            }
           
            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Empresa existente", "Informacion");
            }
            else
            {


                Milibreria.Utilidades.Insert("Insert Cliente Values('" + txtNom.Text + "','" + txtApellido.Text + "'," + txtCuit.Text + "," + cmbTdoc.SelectedValue.ToString() + "," + txtNroDoc.Text + ",'"
                    + rbtEmpresa.Text + "'," + cmbBarrio.SelectedValue.ToString() + "," + cmbLocalidad.SelectedValue.ToString() + ","
                    + cmbDepto.SelectedValue.ToString() + "," + cmbProvin.SelectedValue.ToString() + "," + txtTelefono.Text + ",'" + txtEmail.Text + "','" + txtCalle.Text + "'," + txtNroCalle.Text + "," + 1 + ")");
                MessageBox.Show("Se creo correctamente", "Informacion");

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
             if (txtBuscar.Text != "")
            {
            }
             else
             {
                 MessageBox.Show("Busque cliente a modificar","Informar");
             }
             
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbmDepto depto = new AbmDepto();
            depto.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ABMProvincia prov = new ABMProvincia();
            prov.ShowDialog();
        }


       
     }
      
}
