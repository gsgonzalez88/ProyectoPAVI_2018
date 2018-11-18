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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.pavGestorDataSet = new GestorInformatico.pavGestorDataSet();
            this.graficoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.graficoTableAdapter = new GestorInformatico.pavGestorDataSetTableAdapters.GraficoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pavGestorDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graficoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.graficoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GestorInformatico.Reportes.GraficoArticulos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(726, 392);
            this.reportViewer1.TabIndex = 0;
            // 
            // pavGestorDataSet
            // 
            this.pavGestorDataSet.DataSetName = "pavGestorDataSet";
            this.pavGestorDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // graficoBindingSource
            // 
            this.graficoBindingSource.DataMember = "Grafico";
            this.graficoBindingSource.DataSource = this.pavGestorDataSet;
            // 
            // graficoTableAdapter
            // 
            this.graficoTableAdapter.ClearBeforeFill = true;
            // 
            // GraficoVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 392);
            this.Controls.Add(this.reportViewer1);
            this.Name = "GraficoVenta";
            this.Text = "GraficoVenta";
            this.Load += new System.EventHandler(this.GraficoVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pavGestorDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graficoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private pavGestorDataSet pavGestorDataSet;
        private System.Windows.Forms.BindingSource graficoBindingSource;
        private pavGestorDataSetTableAdapters.GraficoTableAdapter graficoTableAdapter;

    }
}