﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBHelper;

namespace GestorInformatico
{
    public partial class AbmLocalidad : Form
    {
        public AbmLocalidad()
        {
            InitializeComponent();
        }
        int a = 0;

        private void LlenarGrilla()
        {
            DataTable table;
            table = Utilidades.Ejecutar("Select l.Descripcion as Localidad,l.CodigoPostal as Codigo,d.Descripcion as Departamento,P.Descripcion as Provincia"
            + " from Localidad l"
            + " join Departamento d on d.IdDepartamento = l.IdDepartamento"
               + " join Provincia p on p.IdProvincia =d.IdProvincia");
            dgvLocalidad.Rows.Clear();
            if (table.Rows.Count > 0)
            {

                for (int i = 0; i < table.Rows.Count; i++)
                {
                    dgvLocalidad.Rows.Add(table.Rows[i]["Localidad"].ToString()
                                   , table.Rows[i]["Codigo"].ToString()
                                   , table.Rows[i]["Departamento"].ToString()
                                    , table.Rows[i]["Provincia"].ToString());
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbmDepto depto = new AbmDepto();
            depto.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ABMProvincia provincia = new ABMProvincia();
            provincia.ShowDialog();
        }

        private void AbmLocalidad_Load(object sender, EventArgs e)
        {

            LlenarGrilla();

            DataTable tabla = Utilidades.Ejecutar("Select * from Provincia");

            cmbProvincia.DataSource = tabla;
            cmbProvincia.DisplayMember = "Descripcion";
            cmbProvincia.ValueMember = "IdProvincia";
            cmbProvincia.SelectedIndex = -1;
            a = 1;
        }

        private void cmbProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (a == 1 && cmbProvincia.SelectedValue != null)
            {
                a = 0;
                cmbDepartamento.DataSource = Utilidades.Ejecutar("Select * from Departamento"
                + " where IdProvincia = " + cmbProvincia.SelectedValue.ToString());
                cmbDepartamento.DisplayMember = "Descripcion";
                cmbDepartamento.ValueMember = "IdDepartamento";
                cmbDepartamento.SelectedIndex = -1;
                a = 1;
            }

        }

        private void btnRefescar_Click(object sender, EventArgs e)
        {
            cmbDepartamento.SelectedIndex = -1;
            cmbProvincia.SelectedIndex = -1;
            txtLoc.Clear();
            txtCod.Clear();
            dgvLocalidad.Rows.Clear();
            LlenarGrilla();
            txtLoc.BackColor = Color.White;
            cmbDepartamento.BackColor = Color.White;
            cmbProvincia.BackColor = Color.White;
            label5.BackColor = Color.White;
            txtCod.BackColor = Color.White;
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtLoc.Text))
            {
                if (!string.IsNullOrEmpty(cmbProvincia.SelectedValue.ToString()))
                {
                    if (!string.IsNullOrEmpty(cmbDepartamento.SelectedValue.ToString()))
                    {

                        if (!string.IsNullOrEmpty(txtCod.Text))
                        {
                            Utilidades.Insert("Insert Localidad Values ('" + txtLoc.Text + "'," + cmbDepartamento.SelectedValue.ToString() + "," + txtCod.Text + ")");
                            MessageBox.Show("Guardado Correctamente", "Informacion");
                            return;
                        }
                        confirmar(sender, e);
                        txtCod.Focus();
                        return;

                    } 
                    confirmar(sender, e);
                    cmbDepartamento.Focus();
                    return;

                }
                confirmar(sender, e);
                cmbProvincia.Focus();
                return;

            }
            else
            {
                confirmar(sender, e);
                txtLoc.Focus();
            }
        }

        private void confirmar(object sender, EventArgs e)
        {
            txtLoc.BackColor = Color.LightBlue;
            txtCod.BackColor = Color.LightBlue;
            cmbDepartamento.BackColor = Color.LightBlue;
            cmbProvincia.BackColor = Color.LightBlue;
            label5.BackColor = Color.LightBlue;
            MessageBox.Show("Complete los campos Sombreados", "Informacion");
        }

    }
}
