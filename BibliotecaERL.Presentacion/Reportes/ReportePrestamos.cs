using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaERL.Presentacion.Reportes
{
    public partial class ReportePrestamos : Form
    {
        public ReportePrestamos()
        {
            InitializeComponent();
        }

        private void ReportePrestamos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DsBiblioteca.prestamos_ac' table. You can move, or remove it, as needed.
            this.prestamos_acTableAdapter.Fill(this.DsBiblioteca.prestamos_ac);
            // TODO: This line of code loads data into the 'DsBiblioteca.prestamos_activos' table. You can move, or remove it, as needed.


            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
