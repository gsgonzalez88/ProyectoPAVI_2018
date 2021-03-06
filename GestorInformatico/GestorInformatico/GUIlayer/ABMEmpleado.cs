﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DBHelper;


namespace GestorInformatico
{
    public partial class ABMEmpleado : Form
    {
        int idProvincia;
        int idDepto;
        int idLocalidad;
        int idEmpleado;

        public ABMEmpleado()
        {
            InitializeComponent();
        }  

        private void ABMEmpleado_Load(object sender, EventArgs e)
        {
            cargarCombo(cmbProvin, DBHelper.Utilidades.Ejecutar("SELECT * FROM Provincia"), "Descripcion", "IdProvincia");
            
            
            
            cargarCombo(cmbTDoc, DBHelper.Utilidades.Ejecutar("SELECT * FROM TipoDoc"), "Descripcion", "IdTipoDoc");

            DataTable tabla = DBHelper.Utilidades.Ejecutar("SELECT Emp.IdEmpleado, Emp.Apellido, Emp.Nombre, Emp.NroDoc, Est.Descripcion, P.Descripcion, D.Descripcion, L.Descripcion, B.Descripcion, Emp.nroTelefono, Emp.Email, Emp.Calle, Emp.NroCalle " + 
                "FROM Empleado Emp, Estado Est, Provincia P, Departamento D, Localidad L, Barrio B" + 
                " WHERE Emp.IdEstado = Est.IdEstado AND Emp.IdProvincia = P.IdProvincia AND Emp.IdDepartamento = D.IdDepartamento AND Emp.IdLocalidad = L.IdLocalidad AND Emp.IdBarrio = B.IdBarrio");
            if(tabla.Rows.Count > 0)
            {
                dgvEmpleado.DataSource = tabla;
            }
        }

        private void cargarCombo(ComboBox cbo, Object source, string display, String value)
        {
            cbo.DataSource = source;
            cbo.DisplayMember = display;
            cbo.ValueMember = value;
            cbo.SelectedIndex = -1;
        }


        private void btnBarrio_Click(object sender, EventArgs e)
        {
            AbmBarrio frmBarrio = new AbmBarrio();
            frmBarrio.ShowDialog();
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            AbmLocalidad loc = new AbmLocalidad();
            loc.ShowDialog();
        }

        private void btnDpto_Click(object sender, EventArgs e)
        {
            AbmDepto depto = new AbmDepto();
            depto.ShowDialog();
        }

        private void btnProvincia_Click(object sender, EventArgs e)
        {
            ABMProvincia prov = new ABMProvincia();
            prov.ShowDialog();
        }

        private void cmbProvin_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cmbProvin.Text) && cmbProvin.SelectedIndex != -1)
            {
                idProvincia = Convert.ToInt32(cmbProvin.SelectedValue.GetHashCode());
                cargarCombo(cmbDepto, DBHelper.Utilidades.Ejecutar("SELECT * FROM Departamento WHERE IdProvincia = " + idProvincia), "Descripcion", "IdDepartamento");
            }
        }

        private void cmbDepto_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cmbDepto.Text))
            {
                idDepto = Convert.ToInt32(cmbDepto.SelectedValue.GetHashCode());
                cargarCombo(cmbLocalidad, DBHelper.Utilidades.Ejecutar("SELECT * FROM Localidad WHERE IdDepartamento = " + idDepto), "Descripcion", "IdLocalidad");
            }
        }

        private void cmbLocalidad_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cmbLocalidad.Text))
            {
                idLocalidad = Convert.ToInt32(cmbLocalidad.SelectedValue.GetHashCode());
                cargarCombo(cmbBarrio, DBHelper.Utilidades.Ejecutar("SELECT * FROM Barrio WHERE IdLocalidad = " + idLocalidad), "Descripcion", "IdBarrio");
            }
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            DBHelper.Utilidades.Update("UPDATE Empleado SET IdEstado = 1 WHERE IdEmpleado = " + idEmpleado);
            DataTable tabla = DBHelper.Utilidades.Ejecutar("SELECT Emp.IdEmpleado, Emp.Apellido, Emp.Nombre, Emp.NroDoc, Est.Descripcion, P.Descripcion, D.Descripcion, L.Descripcion, B.Descripcion, Emp.nroTelefono, Emp.Email, Emp.Calle, Emp.NroCalle " + 
                "FROM Empleado Emp, Estado Est, Provincia P, Departamento D, Localidad L, Barrio B" + 
                " WHERE Emp.IdEstado = Est.IdEstado AND Emp.IdProvincia = P.IdProvincia AND Emp.IdDepartamento = D.IdDepartamento AND Emp.IdLocalidad = L.IdLocalidad AND Emp.IdBarrio = B.IdBarrio");
            if (tabla.Rows.Count > 0)
            {
                dgvEmpleado.DataSource = tabla;
            }
        }

        private void dgvEmpleado_SelectionChanged(object sender, EventArgs e)
        {
            idEmpleado = Convert.ToInt32(dgvEmpleado.CurrentRow.Cells[0].Value);
        }

        private void ABMEmpleado_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("¿Seguro que desea salir?","Confirmar",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                e.Cancel = false;
                Application.ExitThread();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            DBHelper.Utilidades.Update("UPDATE Empleado SET IdEstado = 2 WHERE IdEmpleado = " + idEmpleado);
            DataTable tabla = DBHelper.Utilidades.Ejecutar("SELECT Emp.IdEmpleado, Emp.Apellido, Emp.Nombre, Emp.NroDoc, Est.Descripcion, P.Descripcion, D.Descripcion, L.Descripcion, B.Descripcion, Emp.nroTelefono, Emp.Email, Emp.Calle, Emp.NroCalle " +
                "FROM Empleado Emp, Estado Est, Provincia P, Departamento D, Localidad L, Barrio B" +
                " WHERE Emp.IdEstado = Est.IdEstado AND Emp.IdProvincia = P.IdProvincia AND Emp.IdDepartamento = D.IdDepartamento AND Emp.IdLocalidad = L.IdLocalidad AND Emp.IdBarrio = B.IdBarrio");
            if (tabla.Rows.Count > 0)
            {
                dgvEmpleado.DataSource = tabla;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtApellido.Text))
            {
                if(!string.IsNullOrEmpty(txtNombreEmp.Text))
                {
                    if(!string.IsNullOrEmpty(cmbTDoc.Text))
                    {
                        if(!string.IsNullOrEmpty(txtNroDocumento.Text))
                        {
                            if(!string.IsNullOrEmpty(txtEmail.Text))
                            {
                                if(!string.IsNullOrEmpty(txtTelefono.Text))
                                {
                                    if(!string.IsNullOrEmpty(txtCalle.Text))
                                    {
                                        if(!string.IsNullOrEmpty(txtNumeroCalle.Text))
                                        {
                                            if(!string.IsNullOrEmpty(cmbProvin.Text))
                                            {
                                                if(!string.IsNullOrEmpty(cmbDepto.Text))
                                                {
                                                    if(!string.IsNullOrEmpty(cmbLocalidad.Text))
                                                    {
                                                        if(!string.IsNullOrEmpty(cmbBarrio.Text))
                                                        {
                                                            DBHelper.Utilidades.Insert("INSERT INTO Empleado VALUES (\'" + txtNombreEmp.Text + "\',\'" + txtApellido.Text + "\'," + Convert.ToInt32(cmbTDoc.SelectedValue.GetHashCode()) + "," +
                                                                Convert.ToInt32(txtNroDocumento.Text) + "," + Convert.ToInt32(cmbBarrio.SelectedValue.GetHashCode()) + "," + Convert.ToInt32(cmbLocalidad.SelectedValue.GetHashCode()) +
                                                                "," + Convert.ToInt32(cmbDepto.SelectedValue.GetHashCode()) + "," + Convert.ToInt32(cmbProvin.SelectedValue.GetHashCode()) + "," + Convert.ToInt32(txtTelefono.Text) + ",\'" +
                                                                txtEmail.Text + "\',\'" + txtCalle.Text + "\'," + Convert.ToInt32(txtNumeroCalle.Text) + ",1)");
                                                            MessageBox.Show("Empleado agregado con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                                            DataTable tabla = DBHelper.Utilidades.Ejecutar("SELECT Emp.IdEmpleado, Emp.Apellido, Emp.Nombre, Emp.NroDoc, Est.Descripcion, P.Descripcion, D.Descripcion, L.Descripcion, B.Descripcion, Emp.nroTelefono, Emp.Email, Emp.Calle, Emp.NroCalle " + 
                                                                "FROM Empleado Emp, Estado Est, Provincia P, Departamento D, Localidad L, Barrio B" + 
                                                                " WHERE Emp.IdEstado = Est.IdEstado AND Emp.IdProvincia = P.IdProvincia AND Emp.IdDepartamento = D.IdDepartamento AND Emp.IdLocalidad = L.IdLocalidad AND Emp.IdBarrio = B.IdBarrio");
                                                            if (tabla.Rows.Count > 0)
                                                            {
                                                                dgvEmpleado.DataSource = tabla;
                                                            }
                                                            txtApellido.Text = "";
                                                            txtNombreEmp.Text = "";
                                                            cmbTDoc.SelectedIndex = -1;
                                                            txtNroDocumento.Text = "";
                                                            txtEmail.Text = "";
                                                            txtTelefono.Text = "";
                                                            txtCalle.Text = "";
                                                            txtNumeroCalle.Text = "";
                                                            cmbProvin.SelectedIndex = -1;
                                                            cmbDepto.SelectedIndex = -1;
                                                            cmbLocalidad.SelectedIndex = -1;
                                                            cmbBarrio.SelectedIndex = -1;
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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(idEmpleado.ToString()))
            {
                GUIlayer.AbmEditarEmpleado emp = new GUIlayer.AbmEditarEmpleado(idEmpleado);
                emp.ShowDialog();
                DataTable tabla = DBHelper.Utilidades.Ejecutar("SELECT Emp.IdEmpleado, Emp.Apellido, Emp.Nombre, Emp.NroDoc, Est.Descripcion, P.Descripcion, D.Descripcion, L.Descripcion, B.Descripcion, Emp.nroTelefono, Emp.Email, Emp.Calle, Emp.NroCalle " +
                "FROM Empleado Emp, Estado Est, Provincia P, Departamento D, Localidad L, Barrio B" +
                " WHERE Emp.IdEstado = Est.IdEstado AND Emp.IdProvincia = P.IdProvincia AND Emp.IdDepartamento = D.IdDepartamento AND Emp.IdLocalidad = L.IdLocalidad AND Emp.IdBarrio = B.IdBarrio");
                if (tabla.Rows.Count > 0)
                {
                    dgvEmpleado.DataSource = tabla;
                }
            }
        }
    }
}
