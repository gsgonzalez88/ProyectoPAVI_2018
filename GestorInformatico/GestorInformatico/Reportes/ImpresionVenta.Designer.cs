namespace GestorInformatico.Reportes
{
    partial class ImpresionVenta
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataSet2 = new GestorInformatico.DataLayer.DataSet2();
            this.impresionVentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.impresion_VentaTableAdapter = new GestorInformatico.DataLayer.DataSet2TableAdapters.Impresion_VentaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.impresionVentaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetImpresionVenta";
            reportDataSource1.Value = this.impresionVentaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GestorInformatico.Reportes.ImpresionVenta.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(617, 312);
            this.reportViewer1.TabIndex = 0;
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "DataSet2";
            this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // impresionVentaBindingSource
            // 
            this.impresionVentaBindingSource.DataMember = "Impresion_Venta";
            this.impresionVentaBindingSource.DataSource = this.dataSet2;
            // 
            // impresion_VentaTableAdapter
            // 
            this.impresion_VentaTableAdapter.ClearBeforeFill = true;
            // 
            // ImpresionVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 312);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ImpresionVenta";
            this.Text = "Impresion Venta";
            this.Load += new System.EventHandler(this.ImpresionVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.impresionVentaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource impresionVentaBindingSource;
        private DataLayer.DataSet2 dataSet2;
        private DataLayer.DataSet2TableAdapters.Impresion_VentaTableAdapter impresion_VentaTableAdapter;
    }
}