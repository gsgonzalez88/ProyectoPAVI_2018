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
            

            DataTable table;
            table = Milibreria.Utilidades.Ejecutar("select c.IdCliente,c.Cuit,c.NroDoc from Cliente c where c.NroDoc =" +txtNroDoc.Text);

            if (table.Rows.Count >0)
            {
                MessageBox.Show("Cliente existente", "Informacion");
            }
            else
            {
                int tipo;
                if (rbtParticular.Checked )
	            {
		            tipo=1;
                    txtCuit.Text = "NULL";
	            }
                else
	            {
                    tipo=0;
                 
	            }
                Milibreria.Utilidades.Insert("Insert Cliente Values('" + txtNom.Text + "','" + txtApellido.Text + "'," + txtCuit.Text + "," + "GETDATE()" + ",'" + "Null" + "'," + cmbTdoc.SelectedValue.ToString() + "," + txtNroDoc.Text + "," 
                    + tipo + "," + cmbBarrio.SelectedValue.ToString() + "," + cmbLocalidad.SelectedValue.ToString() + ","
                    + cmbDepto.SelectedValue.ToString() + "," + cmbProvin.SelectedValue.ToString() + "," + txtTelefono.Text + ",'" + txtEmail.Text + "','" + txtCalle.Text + "'," + txtNroCalle.Text + ")");
                MessageBox.Show("Se creo correctamente", "Informacion");
                limpiar(sender,e);
            }
           
        }

        private void cmbProvin_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ( a ==1 && cmbProvin.SelectedValue !=null)
            {
                a = 0;
            cmbDepto.DataSource = Milibreria.Utilidades.Ejecutar("Select * from Departamento where IdProvincia = " + cmbProvin.SelectedValue.ToString());
            cmbDepto.DisplayMember = "Descripcon";
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
            }
            else
            {
                label6.Visible = true;
                txtCuit.Visible = true;
            }
        }

        private void limpiar(object sender,EventArgs e)
        {
            txtApellido.Text = "";
            txtCalle.Text = "";
            txtCuit.Text = "";
            txtEmail.Text = "";
            txtNom.Text = "";
            txtNroCalle.Text = "";
            txtNroDoc.Text = "";
            txtTelefono.Text = "";
            cmbBarrio.SelectedIndex = -1;
            cmbDepto.SelectedIndex = -1;
            cmbLocalidad.SelectedIndex = -1;
            cmbProvin.SelectedIndex = -1;
            cmbTdoc.SelectedIndex = -1;
            rbtEmpresa.Checked = false;
            rbtParticular.Checked = false;
         }

        private void button5_Click(object sender, EventArgs e)
        {
            int nro = Convert.ToInt32(txtBuscar.Text);
            DataTable table =  Milibreria.Utilidades.ConsultarCliente(nro);

            if (table.Rows.Count>0)
            {
                txtNom.Text = table.Rows[0]["Nombre"].ToString();
                txtApellido.Text = table.Rows[0]["Apellido"].ToString();
                string tipo = table.Rows[0]["TipoC"].ToString();
                if (tipo =="Empreza")
                {
                    rbtEmpresa.Checked = true;
                     txtCuit.Text = table.Rows[0]["Cuit"].ToString();
                     limpiar(sender, e);
                }
                else
                {
                    rbtParticular.Checked = true;
                }
                txtNroDoc.Text = table.Rows[0]["NroDoc"].ToString();
                txtTelefono.Text = table.Rows[0]["Telefono"].ToString();
                txtEmail.Text = table.Rows[0]["Email"].ToString();
                txtNroCalle.Text = table.Rows[0]["NroCalle"].ToString();
                txtCalle.Text = table.Rows[0]["Calle"].ToString();
                cmbTdoc.SelectedText = table.Rows[0]["TipoDoc"].ToString();
                cmbProvin.SelectedText = table.Rows[0]["Prov"].ToString();
                cmbDepto.SelectedText = table.Rows[0]["Depto"].ToString();
            }
            
            else
            {
                MessageBox.Show("No existe el cliente", "Informacion");
            }

        }
        

      

       
     }
      
}
