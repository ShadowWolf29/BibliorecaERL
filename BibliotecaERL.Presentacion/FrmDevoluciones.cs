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
    public partial class FrmDevoluciones : Form
    {
        public FrmDevoluciones()
        {
            InitializeComponent();
        }

        private void LblLibros_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmDashboard frm = new FrmDashboard();
            frm.Show();
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void LbllInicio_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmDashboard frm = new FrmDashboard();
            frm.Show();
            this.Close();
        }
    }
}
