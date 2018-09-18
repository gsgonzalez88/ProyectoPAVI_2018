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
            if (!string.IsNullOrEmpty(txtUsuario.Text))
            {

                if (!string.IsNullOrEmpty(txtContraseña.Text))
                {
                    try
                    {
                        DataTable ds = Utilidades.Ejecutar("Select * from Usuario where Nombre = '" + txtUsuario.Text + "'");

                        if (ds.Rows.Count > 0)
                        {
                            if (txtUsuario.Text == ds.Rows[0]["Nombre"].ToString())
                            {
                                if (txtContraseña.Text == ds.Rows[0]["Contraseña"].ToString())
                                {
                                    if (ds.Rows[0]["IdEstado"].ToString() == "1")
                                    {
                                        MessageBox.Show("Inicio correcto", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        this.Visible = false;
                                        Menu frmMenu = new Menu();
                                        frmMenu.Show();
                                        return;
                                    }
                                    else
                                    {
                                        MessageBox.Show("El usuario esta dado de Baja", "Informacion");
                                        return;
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Contraseña Erronea", "Informacion");
                                    return;
                                }
                            }
                            else
                            {
                                MessageBox.Show("Usuario Erroneo", "Informacion");
                                return;
                            }
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Usuario o Constraseña incorrecto", "Inicio Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtContraseña.Text = null;
                        txtUsuario.Text = null;
                    }
                }
                else
                {
                    txtContraseña.BackColor = Color.LightBlue;
                    txtContraseña.Focus();
                    label3.Visible = true;
                    return;
                }
            }
            else
            {
                txtUsuario.BackColor = Color.LightBlue;
                txtContraseña.BackColor = Color.LightBlue;
                txtUsuario.Focus();
                label3.Visible = true;
                label3.BackColor = Color.LightBlue;
                return;
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

        private void Login_Load(object sender, EventArgs e)
        {
            label3.Visible = false;
        }

    }
}
