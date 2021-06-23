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
    public partial class FrmDashboard : Form
    {
        public FrmDashboard()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void LblBibliotecaName_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmLibros frm = new FrmLibros();
            frm.Show();
            this.Close();
        }

        private void BtnProfesores_Click(object sender, EventArgs e)
        {
            FrmProfesores frm = new FrmProfesores();
            frm.Show();
            this.Close();
        }

        private void BtnPrestamos_Click(object sender, EventArgs e)
        {
            FrmPrestamos frm = new FrmPrestamos();
            frm.Show();
            this.Close();
        }

        private void BtnDevoluciones_Click(object sender, EventArgs e)
        {
            FrmDevoluciones frm = new FrmDevoluciones();
            frm.Show();
            this.Close();
        }

        private void BtnReportes_Click(object sender, EventArgs e)
        {
            FrmReportes frm = new FrmReportes();
            frm.Show();
            this.Close();
        }
    }
}
