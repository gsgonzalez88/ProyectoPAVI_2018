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

namespace GestorInformatico
{
    public partial class ABMCliente : Form
    {
        public ABMCliente()
        {
            InitializeComponent();
        }

       

        private void ABMCliente_Load(object sender, EventArgs e)
        {
            
            string cadena = "Data Source=DESKTOP-KRHUM84\\SQLEXPRESS;Initial Catalog=Prueba;Integrated Security=True";
             
            SqlConnection con = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            DataTable table;
            con.ConnectionString = cadena;
            con.Open();

            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from Barrio ";
            table = new DataTable();
            table.Load(cmd.ExecuteReader());
            con.Close();

            cmbBarrio.DataSource = table;
            cmbBarrio.DisplayMember = "Descripcion";
            cmbBarrio.ValueMember = "Descripcion";
            con.Open();

            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from Localidad ";
            table = new DataTable();
            table.Load(cmd.ExecuteReader());
            con.Close();

            cmbLocalidad.DataSource = table;
            cmbLocalidad.DisplayMember = "Descripcion";
            cmbLocalidad.ValueMember = "Descripcion";
            con.Open();

            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from TipoDoc";
            table = new DataTable();
            table.Load(cmd.ExecuteReader());
            con.Close();

            cmbTdoc.DataSource = table;
            cmbTdoc.DisplayMember = "Descripcion";
            cmbTdoc.ValueMember = "Descripcion";
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            con.Open();
            cmd.CommandText = "Select * from Provincia";
            table = new DataTable();
            table.Load(cmd.ExecuteReader());
            con.Close();
            
            cmbProvin.DataSource = table;
            cmbProvin.DisplayMember = "Descripcion";
            cmbProvin.ValueMember = "Descripcion";
            con.Open();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from Departamento";
            table = new DataTable();
            table.Load(cmd.ExecuteReader());
            con.Close();
         
             cmbDepto.DataSource = table;
             cmbDepto.DisplayMember = "Descripcion";
             cmbDepto.ValueMember = "Descripcion";
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

       

       

       

      
    }
}
