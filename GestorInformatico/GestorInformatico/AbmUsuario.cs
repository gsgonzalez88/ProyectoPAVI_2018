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

        }

        private void LlenarGrilla()
        {
            DataTable tabla = Milibreria.Utilidades.Ejecutar("Select  em.Descripcion,e.Descripcion as Estado,* from Usuario "
            +" left outer join Estado e on e.idEstado = c.IdEstado"
            +" left outer join Empleado em on u.IdEmpleado = em.IdEmpleado");
            dgvUsuario.Rows.Clear();
            if (tabla.Rows.Count > 0)
            {
                for (int i = 0; i < tabla.Rows.Count; i++)
                {
                    dgvUsuario.Rows.Add(tabla.Rows[i]["Nombre"]
                         , tabla.Rows[i]["Estado"]
                        , tabla.Rows[i]["Empleado"]
                        );
                }

            }
        }
    }
}
