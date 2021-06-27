
namespace BibliotecaERL.Presentacion.Reportes
{
    partial class ReporteLibros
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
            this.DsBiblioteca = new BibliotecaERL.Presentacion.Reportes.DsBiblioteca();
            this.libros_stockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libros_stockTableAdapter = new BibliotecaERL.Presentacion.Reportes.DsBibliotecaTableAdapters.libros_stockTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DsBiblioteca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libros_stockBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DtsLibro";
            reportDataSource1.Value = this.libros_stockBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "BibliotecaERL.Presentacion.Reportes.RptLibros.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(969, 631);
            this.reportViewer1.TabIndex = 0;
            // 
            // DsBiblioteca
            // 
            this.DsBiblioteca.DataSetName = "DsBiblioteca";
            this.DsBiblioteca.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // libros_stockBindingSource
            // 
            this.libros_stockBindingSource.DataMember = "libros_stock";
            this.libros_stockBindingSource.DataSource = this.DsBiblioteca;
            // 
            // libros_stockTableAdapter
            // 
            this.libros_stockTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 631);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteLibros";
            this.Text = "ReporteLibros";
            this.Load += new System.EventHandler(this.ReporteLibros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DsBiblioteca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libros_stockBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource libros_stockBindingSource;
        private DsBiblioteca DsBiblioteca;
        private DsBibliotecaTableAdapters.libros_stockTableAdapter libros_stockTableAdapter;
    }
}