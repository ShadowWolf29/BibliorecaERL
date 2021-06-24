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
    public partial class FrmPrestamos : Form
    {
        public FrmPrestamos()
        {
            InitializeComponent();
        }

        private void FrmPrestamos_Load(object sender, EventArgs e)
        {

        }

        private void LblProfesores_Click(object sender, EventArgs e)
        {

        }

        private void LblInicio_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmDashboard frm = new FrmDashboard();
            frm.Show();
            this.Close();
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            FrmDashboard frm = new FrmDashboard();
            frm.Show();
            this.Close();
        }
    }
}
