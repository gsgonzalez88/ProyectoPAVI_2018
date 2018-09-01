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
    public partial class AbmDepto : Form
    {
        public AbmDepto()
        {
            InitializeComponent();
        }

        private void AbmDepto_Load(object sender, EventArgs e)
        {
            LlenarGrilla();

        }

        private void LlenarGrilla()
        {
            DataTable table;
            table = Milibreria.Utilidades.Ejecutar("Select d.Descripcion,P.Descripcion as Provincia"
            + " from Departamento d "
            + " join Provincia p on p.IdProvincia =d.IdProvincia");
            dvgDepartamento.Rows.Clear();
            if (table.Rows.Count > 0)
            {

                for (int i = 0; i < table.Rows.Count; i++)
                {
                    dvgDepartamento.Rows.Add(table.Rows[i]["Descripcion"].ToString()
                                   , table.Rows[i]["Provincia"].ToString());
                }
            }
        }
    }
}
