
namespace BibliotecaERL.Presentacion.Reportes
{
    partial class ReportePrestamos
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
            this.prestamos_activosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DsBiblioteca = new BibliotecaERL.Presentacion.Reportes.DsBiblioteca();
            this.prestamos_activosTableAdapter = new BibliotecaERL.Presentacion.Reportes.DsBibliotecaTableAdapters.prestamos_activosTableAdapter();
            this.prestamos_acBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prestamos_acTableAdapter = new BibliotecaERL.Presentacion.Reportes.DsBibliotecaTableAdapters.prestamos_acTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.prestamos_activosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DsBiblioteca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamos_acBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // prestamos_activosBindingSource
            // 
            this.prestamos_activosBindingSource.DataMember = "prestamos_activos";
            this.prestamos_activosBindingSource.DataSource = this.DsBiblioteca;
            // 
            // DsBiblioteca
            // 
            this.DsBiblioteca.DataSetName = "DsBiblioteca";
            this.DsBiblioteca.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // prestamos_activosTableAdapter
            // 
            this.prestamos_activosTableAdapter.ClearBeforeFill = true;
            // 
            // prestamos_acBindingSource
            // 
            this.prestamos_acBindingSource.DataMember = "prestamos_ac";
            this.prestamos_acBindingSource.DataSource = this.DsBiblioteca;
            // 
            // prestamos_acTableAdapter
            // 
            this.prestamos_acTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.prestamos_acBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "BibliotecaERL.Presentacion.Reportes.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(902, 562);
            this.reportViewer1.TabIndex = 0;
            // 
            // ReportePrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 562);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReportePrestamos";
            this.Text = "ReportePrestamos";
            this.Load += new System.EventHandler(this.ReportePrestamos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.prestamos_activosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DsBiblioteca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamos_acBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource prestamos_activosBindingSource;
        private DsBiblioteca DsBiblioteca;
        private DsBibliotecaTableAdapters.prestamos_activosTableAdapter prestamos_activosTableAdapter;
        private System.Windows.Forms.BindingSource prestamos_acBindingSource;
        private DsBibliotecaTableAdapters.prestamos_acTableAdapter prestamos_acTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}