using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorInformatico.GUIlayer
{
    public partial class AbmEditarEmpleado : Form
    {
        int idEmpleado;
        int idProvincia;
        int idDepto;
        int idLocalidad;
        DataTable tabla;
        public AbmEditarEmpleado(int id)
        {
            InitializeComponent();

            idEmpleado = id;
        }

        private void AbmEditarEmpleado_Load(object sender, EventArgs e)
        {
            cargarCombo(cmbTDoc, DBHelper.Utilidades.Ejecutar("SELECT * FROM TipoDoc"), "Descripcion", "IdTipoDoc");
            cargarCombo(cmbProvin, DBHelper.Utilidades.Ejecutar("SELECT * FROM Provincia"), "Descripcion", "IdProvincia");
            tabla = DBHelper.Utilidades.Ejecutar("SELECT Apellido, Nombre, IdTipoDoc, NroDoc, IdProvincia, IdDepartamento, IdLocalidad, IdBarrio, nroTelefono, Email, Calle, NroCalle FROM Empleado WHERE IdEmpleado = " + idEmpleado);
            if(tabla.Rows.Count > 0)
            {
                txtNombreEmp.Text = tabla.Rows[0].ItemArray[1].ToString();
                txtApellido.Text = tabla.Rows[0].ItemArray[0].ToString();

                cmbTDoc.SelectedValue = Convert.ToInt32(tabla.Rows[0].ItemArray[2]);

                txtNroDocumento.Text = tabla.Rows[0].ItemArray[3].ToString();
                txtEmail.Text = tabla.Rows[0].ItemArray[9].ToString();
                txtTelefono.Text = tabla.Rows[0].ItemArray[8].ToString();
                txtCalle.Text = tabla.Rows[0].ItemArray[10].ToString();
                txtNumeroCalle.Text = tabla.Rows[0].ItemArray[11].ToString();

                cmbProvin.SelectedValue = Convert.ToInt32(tabla.Rows[0].ItemArray[4]);
            }
        }
        private void cargarCombo(ComboBox cbo, Object source, string display, String value)
        {
            cbo.DataSource = source;
            cbo.DisplayMember = display;
            cbo.ValueMember = value;
            cbo.SelectedIndex = -1;
        }

        private void cmbProvin_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cmbProvin.Text) && cmbProvin.SelectedIndex != -1)
            {
                idProvincia = Convert.ToInt32(cmbProvin.SelectedValue.GetHashCode());
                cargarCombo(cmbDepto, DBHelper.Utilidades.Ejecutar("SELECT * FROM Departamento WHERE IdProvincia = " + idProvincia), "Descripcion", "IdDepartamento");
                if (tabla != null)
                {
                    cmbDepto.SelectedValue = Convert.ToInt32(tabla.Rows[0].ItemArray[5]);
                }
            }
        }

        private void cmbDepto_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cmbDepto.Text))
            {
                idDepto = Convert.ToInt32(cmbDepto.SelectedValue.GetHashCode());
                cargarCombo(cmbLocalidad, DBHelper.Utilidades.Ejecutar("SELECT * FROM Localidad WHERE IdDepartamento = " + idDepto), "Descripcion", "IdLocalidad");
                if (tabla != null)
                {
                    cmbLocalidad.SelectedValue = Convert.ToInt32(tabla.Rows[0].ItemArray[6]);
                }
            }
        }

        private void cmbLocalidad_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cmbLocalidad.Text))
            {
                idLocalidad = Convert.ToInt32(cmbLocalidad.SelectedValue.GetHashCode());
                cargarCombo(cmbBarrio, DBHelper.Utilidades.Ejecutar("SELECT * FROM Barrio WHERE IdLocalidad = " + idLocalidad), "Descripcion", "IdBarrio");
                if (tabla != null)
                {
                    cmbBarrio.SelectedValue = Convert.ToInt32(tabla.Rows[0].ItemArray[7]);
                }
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtApellido.Text))
            {
                if (!string.IsNullOrEmpty(txtNombreEmp.Text))
                {
                    if (!string.IsNullOrEmpty(cmbTDoc.Text))
                    {
                        if (!string.IsNullOrEmpty(txtNroDocumento.Text))
                        {
                            if (!string.IsNullOrEmpty(txtEmail.Text))
                            {
                                if (!string.IsNullOrEmpty(txtTelefono.Text))
                                {
                                    if (!string.IsNullOrEmpty(txtCalle.Text))
                                    {
                                        if (!string.IsNullOrEmpty(txtNumeroCalle.Text))
                                        {
                                            if (!string.IsNullOrEmpty(cmbProvin.Text))
                                            {
                                                if (!string.IsNullOrEmpty(cmbDepto.Text))
                                                {
                                                    if (!string.IsNullOrEmpty(cmbLocalidad.Text))
                                                    {
                                                        if (!string.IsNullOrEmpty(cmbBarrio.Text))
                                                        {
                                                            DBHelper.Utilidades.Update("UPDATE Empleado SET Nombre = \'" + txtNombreEmp.Text + "\',Apellido = \'" + txtApellido.Text + "\',IdTipoDoc = " + Convert.ToInt32(cmbTDoc.SelectedValue.GetHashCode()) + ",NroDoc = " +
                                                                Convert.ToInt32(txtNroDocumento.Text) + ",IdBarrio = " + Convert.ToInt32(cmbBarrio.SelectedValue.GetHashCode()) + ",IdLocalidad = " + Convert.ToInt32(cmbLocalidad.SelectedValue.GetHashCode()) +
                                                                ",IdDepartamento = " + Convert.ToInt32(cmbDepto.SelectedValue.GetHashCode()) + ",IdProvincia = " + Convert.ToInt32(cmbProvin.SelectedValue.GetHashCode()) + ",nroTelefono = " + Convert.ToInt32(txtTelefono.Text) + ",Email = \'" +
                                                                txtEmail.Text + "\',Calle = \'" + txtCalle.Text + "\',NroCalle = " + Convert.ToInt32(txtNumeroCalle.Text) + "WHERE IdEmpleado = " + idEmpleado);
                                                            MessageBox.Show("Artículo editado con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                            this.Close();
                                                        }
                                                        else
                                                        {
                                                            MessageBox.Show("Debe completar los campor obligatorios.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                                            lblCamposOb.BackColor = Color.LightBlue;
                                                            lblApellido.BackColor = Color.LightBlue;
                                                            lblNombre.BackColor = Color.LightBlue;
                                                            lblTipoDoc.BackColor = Color.LightBlue;
                                                            lblNroDoc.BackColor = Color.LightBlue;
                                                            lblEmail.BackColor = Color.LightBlue;
                                                            lblTelefono.BackColor = Color.LightBlue;
                                                            lblCalle.BackColor = Color.LightBlue;
                                                            lblNroCalle.BackColor = Color.LightBlue;
                                                            lblProvincia.BackColor = Color.LightBlue;
                                                            lblDepartamento.BackColor = Color.LightBlue;
                                                            lblLocalidad.BackColor = Color.LightBlue;
                                                            lblBarrio.BackColor = Color.LightBlue;
                                                        }
                                                    }
                                                    else
                                                    {
                                                        MessageBox.Show("Debe completar los campor obligatorios.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                                        lblCamposOb.BackColor = Color.LightBlue;
                                                        lblApellido.BackColor = Color.LightBlue;
                                                        lblNombre.BackColor = Color.LightBlue;
                                                        lblTipoDoc.BackColor = Color.LightBlue;
                                                        lblNroDoc.BackColor = Color.LightBlue;
                                                        lblEmail.BackColor = Color.LightBlue;
                                                        lblTelefono.BackColor = Color.LightBlue;
                                                        lblCalle.BackColor = Color.LightBlue;
                                                        lblNroCalle.BackColor = Color.LightBlue;
                                                        lblProvincia.BackColor = Color.LightBlue;
                                                        lblDepartamento.BackColor = Color.LightBlue;
                                                        lblLocalidad.BackColor = Color.LightBlue;
                                                        lblBarrio.BackColor = Color.LightBlue;
                                                    }
                                                }
                                                else
                                                {
                                                    MessageBox.Show("Debe completar los campor obligatorios.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                                    lblCamposOb.BackColor = Color.LightBlue;
                                                    lblApellido.BackColor = Color.LightBlue;
                                                    lblNombre.BackColor = Color.LightBlue;
                                                    lblTipoDoc.BackColor = Color.LightBlue;
                                                    lblNroDoc.BackColor = Color.LightBlue;
                                                    lblEmail.BackColor = Color.LightBlue;
                                                    lblTelefono.BackColor = Color.LightBlue;
                                                    lblCalle.BackColor = Color.LightBlue;
                                                    lblNroCalle.BackColor = Color.LightBlue;
                                                    lblProvincia.BackColor = Color.LightBlue;
                                                    lblDepartamento.BackColor = Color.LightBlue;
                                                    lblLocalidad.BackColor = Color.LightBlue;
                                                    lblBarrio.BackColor = Color.LightBlue;
                                                }
                                            }
                                            else
                                            {
                                                MessageBox.Show("Debe completar los campor obligatorios.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                                lblCamposOb.BackColor = Color.LightBlue;
                                                lblApellido.BackColor = Color.LightBlue;
                                                lblNombre.BackColor = Color.LightBlue;
                                                lblTipoDoc.BackColor = Color.LightBlue;
                                                lblNroDoc.BackColor = Color.LightBlue;
                                                lblEmail.BackColor = Color.LightBlue;
                                                lblTelefono.BackColor = Color.LightBlue;
                                                lblCalle.BackColor = Color.LightBlue;
                                                lblNroCalle.BackColor = Color.LightBlue;
                                                lblProvincia.BackColor = Color.LightBlue;
                                                lblDepartamento.BackColor = Color.LightBlue;
                                                lblLocalidad.BackColor = Color.LightBlue;
                                                lblBarrio.BackColor = Color.LightBlue;
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Debe completar los campor obligatorios.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                            lblCamposOb.BackColor = Color.LightBlue;
                                            lblApellido.BackColor = Color.LightBlue;
                                            lblNombre.BackColor = Color.LightBlue;
                                            lblTipoDoc.BackColor = Color.LightBlue;
                                            lblNroDoc.BackColor = Color.LightBlue;
                                            lblEmail.BackColor = Color.LightBlue;
                                            lblTelefono.BackColor = Color.LightBlue;
                                            lblCalle.BackColor = Color.LightBlue;
                                            lblNroCalle.BackColor = Color.LightBlue;
                                            lblProvincia.BackColor = Color.LightBlue;
                                            lblDepartamento.BackColor = Color.LightBlue;
                                            lblLocalidad.BackColor = Color.LightBlue;
                                            lblBarrio.BackColor = Color.LightBlue;
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Debe completar los campor obligatorios.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                        lblCamposOb.BackColor = Color.LightBlue;
                                        lblApellido.BackColor = Color.LightBlue;
                                        lblNombre.BackColor = Color.LightBlue;
                                        lblTipoDoc.BackColor = Color.LightBlue;
                                        lblNroDoc.BackColor = Color.LightBlue;
                                        lblEmail.BackColor = Color.LightBlue;
                                        lblTelefono.BackColor = Color.LightBlue;
                                        lblCalle.BackColor = Color.LightBlue;
                                        lblNroCalle.BackColor = Color.LightBlue;
                                        lblProvincia.BackColor = Color.LightBlue;
                                        lblDepartamento.BackColor = Color.LightBlue;
                                        lblLocalidad.BackColor = Color.LightBlue;
                                        lblBarrio.BackColor = Color.LightBlue;
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Debe completar los campor obligatorios.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    lblCamposOb.BackColor = Color.LightBlue;
                                    lblApellido.BackColor = Color.LightBlue;
                                    lblNombre.BackColor = Color.LightBlue;
                                    lblTipoDoc.BackColor = Color.LightBlue;
                                    lblNroDoc.BackColor = Color.LightBlue;
                                    lblEmail.BackColor = Color.LightBlue;
                                    lblTelefono.BackColor = Color.LightBlue;
                                    lblCalle.BackColor = Color.LightBlue;
                                    lblNroCalle.BackColor = Color.LightBlue;
                                    lblProvincia.BackColor = Color.LightBlue;
                                    lblDepartamento.BackColor = Color.LightBlue;
                                    lblLocalidad.BackColor = Color.LightBlue;
                                    lblBarrio.BackColor = Color.LightBlue;
                                }
                            }
                            else
                            {
                                MessageBox.Show("Debe completar los campor obligatorios.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                lblCamposOb.BackColor = Color.LightBlue;
                                lblApellido.BackColor = Color.LightBlue;
                                lblNombre.BackColor = Color.LightBlue;
                                lblTipoDoc.BackColor = Color.LightBlue;
                                lblNroDoc.BackColor = Color.LightBlue;
                                lblEmail.BackColor = Color.LightBlue;
                                lblTelefono.BackColor = Color.LightBlue;
                                lblCalle.BackColor = Color.LightBlue;
                                lblNroCalle.BackColor = Color.LightBlue;
                                lblProvincia.BackColor = Color.LightBlue;
                                lblDepartamento.BackColor = Color.LightBlue;
                                lblLocalidad.BackColor = Color.LightBlue;
                                lblBarrio.BackColor = Color.LightBlue;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Debe completar los campor obligatorios.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            lblCamposOb.BackColor = Color.LightBlue;
                            lblApellido.BackColor = Color.LightBlue;
                            lblNombre.BackColor = Color.LightBlue;
                            lblTipoDoc.BackColor = Color.LightBlue;
                            lblNroDoc.BackColor = Color.LightBlue;
                            lblEmail.BackColor = Color.LightBlue;
                            lblTelefono.BackColor = Color.LightBlue;
                            lblCalle.BackColor = Color.LightBlue;
                            lblNroCalle.BackColor = Color.LightBlue;
                            lblProvincia.BackColor = Color.LightBlue;
                            lblDepartamento.BackColor = Color.LightBlue;
                            lblLocalidad.BackColor = Color.LightBlue;
                            lblBarrio.BackColor = Color.LightBlue;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Debe completar los campor obligatorios.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        lblCamposOb.BackColor = Color.LightBlue;
                        lblApellido.BackColor = Color.LightBlue;
                        lblNombre.BackColor = Color.LightBlue;
                        lblTipoDoc.BackColor = Color.LightBlue;
                        lblNroDoc.BackColor = Color.LightBlue;
                        lblEmail.BackColor = Color.LightBlue;
                        lblTelefono.BackColor = Color.LightBlue;
                        lblCalle.BackColor = Color.LightBlue;
                        lblNroCalle.BackColor = Color.LightBlue;
                        lblProvincia.BackColor = Color.LightBlue;
                        lblDepartamento.BackColor = Color.LightBlue;
                        lblLocalidad.BackColor = Color.LightBlue;
                        lblBarrio.BackColor = Color.LightBlue;
                    }
                }
                else
                {
                    MessageBox.Show("Debe completar los campor obligatorios.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    lblCamposOb.BackColor = Color.LightBlue;
                    lblApellido.BackColor = Color.LightBlue;
                    lblNombre.BackColor = Color.LightBlue;
                    lblTipoDoc.BackColor = Color.LightBlue;
                    lblNroDoc.BackColor = Color.LightBlue;
                    lblEmail.BackColor = Color.LightBlue;
                    lblTelefono.BackColor = Color.LightBlue;
                    lblCalle.BackColor = Color.LightBlue;
                    lblNroCalle.BackColor = Color.LightBlue;
                    lblProvincia.BackColor = Color.LightBlue;
                    lblDepartamento.BackColor = Color.LightBlue;
                    lblLocalidad.BackColor = Color.LightBlue;
                    lblBarrio.BackColor = Color.LightBlue;
                }
            }
            else
            {
                MessageBox.Show("Debe completar los campor obligatorios.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lblCamposOb.BackColor = Color.LightBlue;
                lblApellido.BackColor = Color.LightBlue;
                lblNombre.BackColor = Color.LightBlue;
                lblTipoDoc.BackColor = Color.LightBlue;
                lblNroDoc.BackColor = Color.LightBlue;
                lblEmail.BackColor = Color.LightBlue;
                lblTelefono.BackColor = Color.LightBlue;
                lblCalle.BackColor = Color.LightBlue;
                lblNroCalle.BackColor = Color.LightBlue;
                lblProvincia.BackColor = Color.LightBlue;
                lblDepartamento.BackColor = Color.LightBlue;
                lblLocalidad.BackColor = Color.LightBlue;
                lblBarrio.BackColor = Color.LightBlue;
            }
        }
    }
}
