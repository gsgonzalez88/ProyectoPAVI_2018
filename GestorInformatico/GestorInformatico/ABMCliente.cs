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

            lbxBarrio.DataSource = table;
            lbxBarrio.DisplayMember = "Descripcion";
            lbxBarrio.ValueMember = "Descripcion";
            con.Open();

            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from Localidad ";
            table = new DataTable();
            table.Load(cmd.ExecuteReader());
            con.Close();

            lbxLocalidad.DataSource = table;
            lbxLocalidad.DisplayMember = "Descripcion";
            lbxLocalidad.ValueMember = "Descripcion";
        }


      
    }
}
