using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBHelper;

namespace GestorInformatico.GUIlayer
{
    public partial class DetalleCliente : Form
    {
        string equipo;
        public DetalleCliente(string numero)
        {
            InitializeComponent();
            equipo = numero;
        }
        private void llegargrilla(object sender, EventArgs e)
        {
            DataTable table = Utilidades.Ejecutar("select (c.Nombre + ' ' + c.Apellido) as Cliente,es.Descripcion as Estado,td.Descripcion as TipoDoc, * from Cliente c"
              + " join Estado es on c.IdEstado = es.IdEstado"
              + " join TipoDoc td on td.IdTipoDoc = c.IdTipoDoc ");
            dgvCliente.Rows.Clear();
            if (table.Rows.Count > 0)
            {
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    dgvCliente.Rows.Add(table.Rows[i]["Cliente"],
                                        table.Rows[i]["Cuit"],
                                        table.Rows[i]["TipoDoc"],
                                        table.Rows[i]["NroDoc"],
                                         table.Rows[i]["TipoCliente"],
                                        table.Rows[i]["Estado"]);
                }
            }
        }

        private void DetalleCliente_Load(object sender, EventArgs e)
        {
            llegargrilla(sender, e);
        }
    }
}
