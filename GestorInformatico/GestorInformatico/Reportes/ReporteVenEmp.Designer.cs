namespace GestorInformatico.Reportes
{
    partial class ReporteVenEmp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.ventaEmpleadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet2 = new GestorInformatico.DataLayer.DataSet2();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.venta_EmpleadoTableAdapter = new GestorInformatico.DataLayer.DataSet2TableAdapters.Venta_EmpleadoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ventaEmpleadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // ventaEmpleadoBindingSource
            // 
            this.ventaEmpleadoBindingSource.DataMember = "Venta_Empleado";
            this.ventaEmpleadoBindingSource.DataSource = this.dataSet2;
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "DataSet2";
            this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetVenEmp";
            reportDataSource1.Value = this.ventaEmpleadoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GestorInformatico.Reportes.ReporteVentaEmpleado.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(557, 486);
            this.reportViewer1.TabIndex = 0;
            // 
            // venta_EmpleadoTableAdapter
            // 
            this.venta_EmpleadoTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteVenEmp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 486);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteVenEmp";
            this.Text = "Reporte de Venta";
            this.Load += new System.EventHandler(this.ReporteVenEmp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ventaEmpleadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ventaEmpleadoBindingSource;
        private DataLayer.DataSet2 dataSet2;
        private DataLayer.DataSet2TableAdapters.Venta_EmpleadoTableAdapter venta_EmpleadoTableAdapter;
    }
}