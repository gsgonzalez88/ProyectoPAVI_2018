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
                DataTable ds = Utilidades.Ejecutar(cmd);
                
                if (ds.Rows.Count >0)
                {
                    if (ds.Rows[0]["IdEstado"].ToString() == "1")
                    {
		          MessageBox.Show("Inicio correcto","Informacion",MessageBoxButtons.OK,MessageBoxIcon.Information);
                  this.Hide();
                  Menu frmMenu = new Menu();
                  frmMenu.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("El usuario esta dado de Baja","Informacion");
                        return;
                    }
            	}
                    
            }
            catch (Exception)
            {
                MessageBox.Show("Usuario o Constraseña incorrecto","Inicio Incorrecto",MessageBoxButtons.OK,MessageBoxIcon.Error);  
            }
           
        }

        private void estaSeguro(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Esta seguro que desea salir?","Confirmar",MessageBoxButtons.YesNo,MessageBoxIcon.Question) ==DialogResult.Yes)
            {
                e.Cancel = false;
            }else
        	{
                e.Cancel = true;
	        }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
