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
    public partial class FrmPrestamos : Form
    {
        public FrmPrestamos()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            txtidlibro.Clear();
            txtidprofesor.Clear();
            TxtApellido1.Clear();
            TxtNombre1.Clear();
            TxtTitulo.Clear();
            TxtUbicacion.Clear();
            TxtAutores.Clear();
            TxtISBN.Clear();
        }

        private void Listar_Profesor()
        {
            try
            {
                DgvProfesor.DataSource = NUsuario.Listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Listar_Libro()
        {
            try
            {
                DgvLibro.DataSource = NLibro.Listar_disponible();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void BuscarLibro()
        {
            try
            {
                DgvLibro.DataSource = NLibro.Buscar_disponible(TxtBuscatLibro.Text);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void BuscarActivos()
        {
            try
            {
                Dgvactivos.DataSource = Nprestamo.BuscarPrestamos(txtprestamo.Text);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void BuscarProfesor()
        {
            try
            {
                DgvProfesor.DataSource = NUsuario.Buscar(txtNombreBuscar.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void FrmPrestamos_Load(object sender, EventArgs e)
        {
            DtpDevolucion.MinDate = DateTime.Today;
            DtpDevolucion.Format = DateTimePickerFormat.Custom;
            DtpDevolucion.CustomFormat = "yyyy-MM-dd";
            this.Listar_Libro();
            this.Listar_Profesor();
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

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmDashboard frm = new FrmDashboard();
            frm.Show();
            this.Close();
        }

        private void Nuevo_Click(object sender, EventArgs e)
        {

        }

        private void LblNombre1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void DgvProfesor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void DgvLibro_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DgvProfesor_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtNombre1.Text = Convert.ToString(DgvProfesor.CurrentRow.Cells["nombre"].Value);
            TxtApellido1.Text = Convert.ToString(DgvProfesor.CurrentRow.Cells["apellido"].Value);
            txtidprofesor.Text = Convert.ToString(DgvProfesor.CurrentRow.Cells["id_empleado"].Value);
        }

        private void DgvLibro_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtISBN.Text = Convert.ToString(DgvLibro.CurrentRow.Cells["isbn"].Value);
            TxtAutores.Text = Convert.ToString(DgvLibro.CurrentRow.Cells["autores"].Value);
            TxtTitulo.Text = Convert.ToString(DgvLibro.CurrentRow.Cells["titulo"].Value);
            TxtUbicacion.Text = Convert.ToString(DgvLibro.CurrentRow.Cells["ubicacion"].Value);
            txtidlibro.Text = Convert.ToString(DgvLibro.CurrentRow.Cells["id"].Value);
        }

        private void txtNombreBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            this.BuscarProfesor();
        }

        private void TxtBuscatLibro_KeyUp(object sender, KeyEventArgs e)
        {
            this.BuscarLibro();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string Rpta = "";
                if (txtidlibro.Text == string.Empty || txtidprofesor.Text == string.Empty)
                {
                    MessageBox.Show("Por favor seleccione un libro y un profesor", "Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    DateTime date = DateTime.UtcNow.Date;
                    Rpta = Nprestamo.Insertar(int.Parse(txtidlibro.Text), int.Parse(txtidprofesor.Text), date, DtpDevolucion.Value);
                    NLibro.ActualizarCantidad(int.Parse(txtidlibro.Text));

                    if (Rpta.Equals("OK"))
                    {
                        MessageBox.Show("Se inserto de forma correcta", "Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Hubo un error al insertar", "Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            this.BuscarActivos();
        }

        private void Dgvactivos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                lbltitulos.Text = Convert.ToString(Dgvactivos.CurrentRow.Cells["titulo"].Value);
                lblnombres.Text = Convert.ToString(Dgvactivos.CurrentRow.Cells["nombre"].Value);
                lblapellidos.Text = Convert.ToString(Dgvactivos.CurrentRow.Cells["apellido"].Value);
                lbl_fechainicio.Text = Convert.ToString(Dgvactivos.CurrentRow.Cells["fecha_prestamo"].Value);
                lbl_fechadevolucion.Text = Convert.ToString(Dgvactivos.CurrentRow.Cells["fecha_devolucion"].Value);
                DateTime fecha_inicio = Convert.ToDateTime(Dgvactivos.CurrentRow.Cells["fecha_prestamo"].Value);
                DateTime fecha_devolucion = Convert.ToDateTime(Dgvactivos.CurrentRow.Cells["fecha_devolucion"].Value);
                lbltiempo.Text = (fecha_devolucion - fecha_inicio).Days.ToString() + " Dias";
                if (fecha_devolucion < DateTime.UtcNow.Date)
                {
                    lblestado.Text = "Prestamo vencido";
                }
                else
                {
                    lblestado.Text = "Prestamo activo";
                }
            }catch(Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void Dgvactivos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
