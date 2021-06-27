using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBiblitecaERL.Vistas
{
    public partial class FrmReportes : Form
    {
        public FrmReportes()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LbllInicio_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmDashboard frm = new FrmDashboard();
            frm.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmDashboard frm = new FrmDashboard();
            frm.Show();
            this.Close();
        }

        private void BtnLibros_Click(object sender, EventArgs e)
        {
            BibliotecaERL.Presentacion.Reportes.ReporteLibros ReporteL = new BibliotecaERL.Presentacion.Reportes.ReporteLibros();
            ReporteL.ShowDialog();
        }

        private void BtnPrestamos_Click(object sender, EventArgs e)
        {
            BibliotecaERL.Presentacion.Reportes.ReportePrestamos ReporteP = new BibliotecaERL.Presentacion.Reportes.ReportePrestamos();
            ReporteP.ShowDialog();
        }
    }
}
