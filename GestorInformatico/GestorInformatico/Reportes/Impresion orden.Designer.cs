namespace GestorInformatico.Reportes
{
    partial class Impresion_orden
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
            this.Orden_ProcedureBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new GestorInformatico.DataLayer.DataSet();
            this.ordenProcedureBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orden_ProcedureTableAdapter = new GestorInformatico.DataLayer.DataSetTableAdapters.Orden_ProcedureTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Orden_ProcedureBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordenProcedureBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Orden_ProcedureBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GestorInformatico.Reportes.ImporteObra.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(838, 414);
            this.reportViewer1.TabIndex = 0;
            // 
            // Orden_ProcedureBindingSource
            // 
            this.Orden_ProcedureBindingSource.DataMember = "Orden_Procedure";
            this.Orden_ProcedureBindingSource.DataSource = this.dataSet;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordenProcedureBindingSource
            // 
            this.ordenProcedureBindingSource.DataMember = "Orden_Procedure";
            this.ordenProcedureBindingSource.DataSource = this.dataSet;
            // 
            // orden_ProcedureTableAdapter
            // 
            this.orden_ProcedureTableAdapter.ClearBeforeFill = true;
            // 
            // Impresion_orden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 414);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Impresion_orden";
            this.Text = "Impresion_orden";
            this.Load += new System.EventHandler(this.Impresion_orden_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Orden_ProcedureBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordenProcedureBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ordenProcedureBindingSource;
        private DataLayer.DataSet dataSet;
        private DataLayer.DataSetTableAdapters.Orden_ProcedureTableAdapter orden_ProcedureTableAdapter;
        private System.Windows.Forms.BindingSource Orden_ProcedureBindingSource;


    }
}