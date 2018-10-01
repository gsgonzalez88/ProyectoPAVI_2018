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
    public partial class AbmEquipo : Form
    {
        public AbmEquipo()
        {
            InitializeComponent();
        }

        int a = 0;
        private void AbmEquipo_Load(object sender, EventArgs e)
        {
            cboMarca.DataSource = Utilidades.Ejecutar("Select * from Marca");
            cboMarca.DisplayMember = "Descripcion";
            cboMarca.ValueMember = "IdMarca";
            cboMarca.SelectedIndex = -1;

            cboFiltro.DataSource = Utilidades.Ejecutar("Select * from Marca");
            cboFiltro.DisplayMember = "Descripcion";
            cboFiltro.ValueMember = "IdMarca";
            cboFiltro.SelectedIndex = -1;
            llegargrilla(sender, e);
            a = 1;

            cmbCliente.DataSource = Utilidades.Ejecutar("Select (c.Nombre + ' ' + c.Apellido) as Nombre,c.IdCliente from Cliente c");
            cmbCliente.DisplayMember = "Nombre";
            cmbCliente.ValueMember = "IdCliente";
            cmbCliente.SelectedIndex = -1;


        }

        private void llegargrilla(object sender, EventArgs e)
        {
            DataTable table = Utilidades.Ejecutar("select m.Descripcion as Marca , (c.Nombre + ' ' + c.Apellido) as Cliente,es.Descripcion as Estado, * from Equipo e"
              + " join Marca m on m.IdMarca = e.IdMarca"
              + " join Cliente c on c.IdCliente = e.IdCliente"
              + " join Estado es on e.IdEstado = es.IdEstado");
            dgvEquipo.Rows.Clear();
            if (table.Rows.Count > 0)
            {
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    dgvEquipo.Rows.Add(table.Rows[i]["IdEquipo"],
                                        table.Rows[i]["Descripcion"],
                                        table.Rows[i]["Cliente"],
                                        table.Rows[i]["Marca"],
                                        table.Rows[i]["Estado"]);
                }
            }
        }

        private void cboFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (a == 1 && cboFiltro.SelectedIndex != -1)
            {
                DataTable table = Utilidades.Ejecutar("select m.Descripcion as Marca , c.Apellido,es.Descripcion as Estado, * from Equipo e"
              + " join Marca m on m.IdMarca = e.IdMarca"
              + " join Cliente c on c.IdCliente = e.IdCliente"
              + " join Estado es on e.IdEstado = es.IdEstado"
              + "  where m.IdMarca = '" + cboFiltro.SelectedValue + "'");
                dgvEquipo.Rows.Clear();
                if (table.Rows.Count > 0 && table.Rows != null)
                {
                    for (int i = 0; i < table.Rows.Count; i++)
                    {
                        dgvEquipo.Rows.Add(table.Rows[i]["IdEquipo"],
                                            table.Rows[i]["Descripcion"],
                                            table.Rows[i]["Apellido"],
                                            table.Rows[i]["Marca"],
                                            table.Rows[i]["Estado"]);
                    }

                }
                else
                {
                    MessageBox.Show("No existe Equipo");
                    return;
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBuscar.Text))
            {
                DataTable table;
                if (!string.IsNullOrEmpty(cboFiltro.Text))
                {
                    table = Utilidades.Ejecutar("select m.Descripcion as Marca , c.Apellido,es.IdEstado as Estado, * from Equipo e"
              + " join Marca m on m.IdMarca = e.IdMarca"
              + " join Cliente c on c.IdCliente = e.IdCliente"
              + " join Estado es on e.IdEstado = es.IdEstado"
              + "  where m.IdMarca = '" + cboFiltro.SelectedValue + "' and e.IdEquipo ='" + txtBuscar.Text + "'");
                }
                else
                {
                    table = Utilidades.Ejecutar("select m.Descripcion as Marca , c.Apellido,es.IdEstado as Estado, * from Equipo e"
                    + " join Estado es on e.IdEstado = es.IdEstado"
                   + "  where e.IdEquipo ='" + txtBuscar.Text + "'");
                }
                if (table.Rows.Count>0)
                {
                    txtNro.Enabled = false;
                    cboMarca.Enabled = false;
                    txtNro.Text = table.Rows[0]["idEquipo"].ToString();
                    txtDescripcion.Text = table.Rows[0]["Descripcion"].ToString();
                    cmbCliente.Text = table.Rows[0]["Apellido"].ToString();
                    txtObservaciones.Text = table.Rows[0]["Observaciones"].ToString();
                    cboMarca.SelectedText = table.Rows[0]["Marca"].ToString();
                    if (table.Rows[0]["Estado"].ToString() == "1" )
                    {
                        rbtActivo.Checked = true;
                    }
                    else
                    {
                        rbtInactivo.Checked = true;
                    }

                }
                else
                {
                    MessageBox.Show("No existe el Equipo");
                    return;
                }
                
            }
            else
            {
                MessageBox.Show("Complete el campo");
                txtBuscar.BackColor = Color.LightBlue;
                return;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DataTable table = Utilidades.Ejecutar("select es.IdEstado as Estado, * from Equipo e"
                 + " join Estado es on e.IdEstado = es.IdEstado"
                + "  where e.IdEquipo ='" + txtNro.Text + "'");
            if (table.Rows.Count >0)
            {
                if (table.Rows[0]["Estado"].ToString() =="2")
                {
                    MessageBox.Show("El Equipo esta inactivo");
                    return;
                }
                MessageBox.Show("El Equipo ya existe");
                return;
            }
            else
            {
                string sql = "insert equipo values(";
                if (!string.IsNullOrEmpty(txtDescripcion.Text))
                {
                    sql += "'" + txtDescripcion.Text + "'";
                }
                else
                {
                    obligatorio(sender, e);
                    return;
                }
                if (!string.IsNullOrEmpty(cmbCliente.Text))
                {
                    sql += "," + cmbCliente.SelectedIndex;
                }
                else
                {
                    obligatorio(sender, e);
                    return;
                }
                if (!string.IsNullOrEmpty(cboMarca.Text))
                {
                    sql += "," + cboMarca.SelectedIndex;
                }
                else
                {
                    obligatorio(sender, e);
                    return;
                }
                if (!string.IsNullOrEmpty(txtObservaciones.Text))
                {
                    sql += "," + txtObservaciones.Text;
                }
                else
                {
                    sql += "NULL";                    
                }

                sql += ",1)";
                Utilidades.Insert(sql);
                MessageBox.Show("Guardado Correctamente");
                return;

            }
        }

        private void obligatorio(object sender, EventArgs e)
        {
            txtDescripcion.BackColor = Color.LightBlue;
            cmbCliente.BackColor = Color.LightBlue;
            label3.BackColor = Color.LightBlue;
            cboMarca.BackColor = Color.LightBlue;
            MessageBox.Show("Complete el campo");
        }

    }
}

