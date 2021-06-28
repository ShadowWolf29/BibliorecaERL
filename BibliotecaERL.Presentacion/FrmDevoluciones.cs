using BibliotecaERL.Negocio;
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

        private void Limpiar()
        {
            ;   lbltitulo.Text = "";
                TxtNombre1.Text = "";
                TxtApellido1.Text = "";
                LblFechaIni.Text ="";
                LblFin.Text = "";
                lblid.Text = "";
                lblidlibro.Text = "";
                lblestado.Text = "";
                lbltiempo.Text = "";
        }

        private void BuscarActivos()
        {
            try
            {
                DgvDevolucion.DataSource = Nprestamo.BuscarPrestamos(txtNombreBuscar.Text);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void ListarActivos()
        {
            try
            {
                DgvDevolucion.DataSource = Nprestamo.BuscarPrestamo();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                lbltitulo.Text = Convert.ToString(DgvDevolucion.CurrentRow.Cells["titulo"].Value);
                TxtNombre1.Text = Convert.ToString(DgvDevolucion.CurrentRow.Cells["nombre"].Value);
                TxtApellido1.Text = Convert.ToString(DgvDevolucion.CurrentRow.Cells["apellido"].Value);
                LblFechaIni.Text = Convert.ToString(DgvDevolucion.CurrentRow.Cells["fecha_prestamo"].Value);
                LblFin.Text = Convert.ToString(DgvDevolucion.CurrentRow.Cells["fecha_devolucion"].Value);
                lblid.Text = Convert.ToString(DgvDevolucion.CurrentRow.Cells["id_prestamo"].Value);
                lblidlibro.Text = Convert.ToString(DgvDevolucion.CurrentRow.Cells["id_libro"].Value);
                DateTime fecha_inicio = Convert.ToDateTime(DgvDevolucion.CurrentRow.Cells["fecha_prestamo"].Value);
                DateTime fecha_devolucion = Convert.ToDateTime(DgvDevolucion.CurrentRow.Cells["fecha_devolucion"].Value);
                lbltiempo.Text = (fecha_devolucion - fecha_inicio).Days.ToString() + " Dias";
                if (fecha_devolucion < DateTime.UtcNow.Date)
                {
                    lblestado.Text = "Prestamo vencido";
                }
                else
                {
                    lblestado.Text = "Prestamo activo";
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void txtNombreBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            this.BuscarActivos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(lblid.Text == string.Empty)
            {
                MessageBox.Show("Por favor seleccione un prestamo", "Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    string Rpta = "";
                    DateTime date = DateTime.UtcNow.Date;
                    Rpta = Nprestamo.ActualizarPrestamo(int.Parse(lblid.Text));
                    NLibro.ActualizarEjemplares(int.Parse(lblidlibro.Text));
                    if (Rpta.Equals("OK"))
                    {
                        this.Limpiar();
                        this.BuscarActivos();
                        MessageBox.Show("Se hizo la devolucion de forma correcta", "Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error al devolver el libro", "Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.StackTrace);
                }
            }
        }

        private void FrmDevoluciones_Load(object sender, EventArgs e)
        {
            this.ListarActivos();
        }
    }
}
