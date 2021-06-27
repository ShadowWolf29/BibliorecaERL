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
    public partial class ReporteLibros : Form
    {
        public ReporteLibros()
        {
            InitializeComponent();
        }

        private void ReporteLibros_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DsBiblioteca.libros_stock' table. You can move, or remove it, as needed.
            this.libros_stockTableAdapter.Fill(this.DsBiblioteca.libros_stock);

            this.reportViewer1.RefreshReport();
        }
    }
}
