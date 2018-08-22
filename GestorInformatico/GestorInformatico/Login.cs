using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Milibreria;
namespace GestorInformatico
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                string cmd = string.Format("Select * from Usuario where Nombre = '{0}' and Contraseña ='{1}'", txtUsuario.Text.Trim(), txtContraseña.Text.Trim());
                DataSet ds = Utilidades.Ejecutar(cmd);
                string cuenta = ds.Tables[0].Rows[0]["Nombre"].ToString().Trim();
                string Constraseña = ds.Tables[0].Rows[0]["Contraseña"].ToString().Trim();
                if (txtUsuario.Text == cuenta && txtContraseña.Text == Constraseña)
	            {
		          MessageBox.Show("Inicio correcto");
            	}
               
                    
            }
            catch (Exception)
            {

                MessageBox.Show("Usuario o Constraseña incorrecto"); 
                
            }
          
                     
           
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
