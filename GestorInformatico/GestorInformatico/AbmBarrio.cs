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
    public partial class AbmBarrio : Form
    {
        public AbmBarrio()
        {
            InitializeComponent();
        }

        private void AbmBarrio_Load(object sender, EventArgs e)
        {

        string cadena = "Data Source=DESKTOP-KRHUM84\\SQLEXPRESS;Initial Catalog=Panchp;Integrated Security=True";
             
            SqlConnection con = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            DataTable table;
            con.ConnectionString = cadena;
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

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void EstaSeguro(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Desea salir sin guardar?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                e.Cancel = false;      
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
       
}
