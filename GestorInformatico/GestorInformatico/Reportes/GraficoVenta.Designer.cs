namespace GestorInformatico.Reportes
{
    partial class GraficoVenta
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
            this.graficoVentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet2 = new GestorInformatico.DataLayer.DataSet2();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.grafico_VentaTableAdapter = new GestorInformatico.DataLayer.DataSet2TableAdapters.Grafico_VentaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.graficoVentaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // graficoVentaBindingSource
            // 
            this.graficoVentaBindingSource.DataMember = "Grafico_Venta";
            this.graficoVentaBindingSource.DataSource = this.dataSet2;
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "DataSet2";
            this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetGraficoVenta";
            reportDataSource1.Value = this.graficoVentaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GestorInformatico.Reportes.GraficoVenta.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(579, 352);
            this.reportViewer1.TabIndex = 0;
            // 
            // grafico_VentaTableAdapter
            // 
            this.grafico_VentaTableAdapter.ClearBeforeFill = true;
            // 
            // GraficoVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 352);
            this.Controls.Add(this.reportViewer1);
            this.Name = "GraficoVenta";
            this.Text = "Grafico";
            this.Load += new System.EventHandler(this.GraficoVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.graficoVentaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DataLayer.DataSet2 dataSet2;
        private System.Windows.Forms.BindingSource graficoVentaBindingSource;
        private DataLayer.DataSet2TableAdapters.Grafico_VentaTableAdapter grafico_VentaTableAdapter;
    }
}