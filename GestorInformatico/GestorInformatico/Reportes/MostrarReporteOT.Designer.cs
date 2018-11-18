namespace GestorInformatico.Reportes
{
    partial class MostrarReporteOT
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
            this.dataSet = new GestorInformatico.DataLayer.DataSet();
            this.dataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pavGestorDataSet = new GestorInformatico.pavGestorDataSet();
            this.reporteOTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reporteOTTableAdapter = new GestorInformatico.pavGestorDataSetTableAdapters.ReporteOTTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pavGestorDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteOTBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "ReporteOrden";
            reportDataSource1.Value = this.reporteOTBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GestorInformatico.Reportes.InformeOT.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(284, 261);
            this.reportViewer1.TabIndex = 0;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSetBindingSource
            // 
            this.dataSetBindingSource.DataSource = this.dataSet;
            this.dataSetBindingSource.Position = 0;
            // 
            // pavGestorDataSet
            // 
            this.pavGestorDataSet.DataSetName = "pavGestorDataSet";
            this.pavGestorDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reporteOTBindingSource
            // 
            this.reporteOTBindingSource.DataMember = "ReporteOT";
            this.reporteOTBindingSource.DataSource = this.pavGestorDataSet;
            // 
            // reporteOTTableAdapter
            // 
            this.reporteOTTableAdapter.ClearBeforeFill = true;
            // 
            // MostrarReporteOT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.reportViewer1);
            this.Name = "MostrarReporteOT";
            this.Text = "MostrarReporteOT";
            this.Load += new System.EventHandler(this.MostrarReporteOT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pavGestorDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteOTBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource reporteOTBindingSource;
        private pavGestorDataSet pavGestorDataSet;
        private DataLayer.DataSet dataSet;
        private System.Windows.Forms.BindingSource dataSetBindingSource;
        private pavGestorDataSetTableAdapters.ReporteOTTableAdapter reporteOTTableAdapter;
    }
}