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
    public partial class FrmLibros : Form
    {
        public FrmLibros()
        {
            InitializeComponent();
        }

        private void Listar()
        {
            toolTip1.SetToolTip(TxtCodigo, "El codigo se asignara automaticamente");
            toolTip2.SetToolTip(DgvListado, "Doble clic para modificar o eliminar");
            try
            {
                DgvListado.DataSource = NLibro.Listar();
                DgvListado.Columns[0].Visible = false;
                this.Limpiar();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Buscar()
        {
            try
            {
                DgvListado.DataSource = NLibro.Buscar(TxtBuscar.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Limpiar()
        {
            TxtBuscar.Clear();
            TxtAno.Clear();
            TxtAutores.Clear();
            TxtCantidad.Clear();
            TxtCodigo.Clear();
            TxtDescripcion.Clear();
            TxtEdicion.Clear();
            TxtEditorial.Clear();
            TxtIdioma.Clear();
            TxtISBM.Clear();
            TxtMateria.Clear();
            TxtPaginas.Clear();
            TxtPais.Clear();
            TxtTiutlos.Clear();
            TxtUbicacion.Clear();
            ErrorIcono.Clear();
            btnInsertar.Visible = true;
            BtnActualizar.Visible = false;
            DgvListado.Columns[0].Visible = false;
            BtnEliminar.Visible = false;
            Chkseleccionar.Checked = false;
        }

        private void MensajeError(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MensajeOk(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void lblBuscar_Click(object sender, EventArgs e)
        {

        }

        private void FrmLibros_Load(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void LbllInicio_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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

        private void DgvListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == DgvListado.Columns["Seleccionar"].Index)
            {
                DataGridViewCheckBoxCell chkEliminar = (DataGridViewCheckBoxCell)DgvListado.Rows[e.RowIndex].Cells["seleccionar"];
                chkEliminar.Value = !Convert.ToBoolean(chkEliminar.Value);
            }
        }

        private void TxtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            
        }

        private void TxtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            if (TxtBuscar.Text == "")
            {
                this.Listar();
            }
            else { this.Buscar(); }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                string Rpta = "";
                if(TxtAno.Text == string.Empty || TxtAutores.Text == string.Empty || TxtCantidad.Text == string.Empty || TxtDescripcion.Text == string.Empty || 
                  TxtEdicion.Text == string.Empty || TxtEditorial.Text == string.Empty || TxtIdioma.Text == string.Empty || TxtISBM.Text == string.Empty || 
                  TxtMateria.Text == string.Empty || TxtPaginas.Text == string.Empty || TxtPais.Text == string.Empty || TxtTiutlos.Text == string.Empty || TxtUbicacion.Text == string.Empty)
                {
                    this.MensajeError("Falta ingresar algunos datos");
                }
                else
                {
                    Rpta = NLibro.Insertar(int.Parse(TxtCantidad.Text), TxtISBM.Text.Trim(), TxtTiutlos.Text.Trim(), TxtAutores.Text.Trim(), int.Parse(TxtAno.Text),
                        int.Parse(TxtEdicion.Text), TxtPais.Text.Trim(), TxtIdioma.Text.Trim(), TxtMateria.Text.Trim(), int.Parse(TxtPaginas.Text), TxtUbicacion.Text.Trim(),
                        TxtDescripcion.Text.Trim(), TxtEditorial.Text.Trim()) ;

                    if (Rpta.Equals("OK"))
                    {
                        this.MensajeOk("Se inserto de forma correcta");
                        this.Limpiar();
                        this.Listar();
                    }
                    else
                    {
                        this.MensajeError(Rpta);
                    }
                }



            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }

        private void DgvListado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Limpiar();
            BtnActualizar.Visible = true;
            btnInsertar.Visible = false;
            TxtCodigo.Text = Convert.ToString(DgvListado.CurrentRow.Cells["id"].Value);
            TxtISBM.Text = Convert.ToString(DgvListado.CurrentRow.Cells["isbn"].Value);
            TxtTiutlos.Text = Convert.ToString(DgvListado.CurrentRow.Cells["titulo"].Value);
            TxtAutores.Text = Convert.ToString(DgvListado.CurrentRow.Cells["autores"].Value);
            TxtAno.Text = Convert.ToString(DgvListado.CurrentRow.Cells["anio_edicion"].Value);
            TxtEdicion.Text = Convert.ToString(DgvListado.CurrentRow.Cells["num_edicion"].Value);
            TxtPais.Text = Convert.ToString(DgvListado.CurrentRow.Cells["pais"].Value);
            TxtIdioma.Text = Convert.ToString(DgvListado.CurrentRow.Cells["idioma"].Value);
            TxtMateria.Text = Convert.ToString(DgvListado.CurrentRow.Cells["materia"].Value);
            TxtPaginas.Text = Convert.ToString(DgvListado.CurrentRow.Cells["num_paginas"].Value);
            TxtUbicacion.Text = Convert.ToString(DgvListado.CurrentRow.Cells["ubicacion"].Value);
            TxtDescripcion.Text = Convert.ToString(DgvListado.CurrentRow.Cells["descripcion"].Value);
            TxtEditorial.Text = Convert.ToString(DgvListado.CurrentRow.Cells["editorial"].Value);
            TxtCantidad.Text = Convert.ToString(DgvListado.CurrentRow.Cells["num_ejemplares"].Value);

        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                string Rpta = "";
                if (TxtAno.Text == string.Empty || TxtAutores.Text == string.Empty || TxtCantidad.Text == string.Empty || TxtDescripcion.Text == string.Empty ||
                  TxtEdicion.Text == string.Empty || TxtEditorial.Text == string.Empty || TxtIdioma.Text == string.Empty || TxtISBM.Text == string.Empty ||
                  TxtMateria.Text == string.Empty || TxtPaginas.Text == string.Empty || TxtPais.Text == string.Empty || TxtTiutlos.Text == string.Empty || TxtUbicacion.Text == string.Empty)
                {
                    this.MensajeError("Falta ingresar algunos datos");
                }
                else
                {
                    Rpta = NLibro.Actualizar(int.Parse(TxtCodigo.Text),int.Parse(TxtCantidad.Text), TxtISBM.Text.Trim(), TxtTiutlos.Text.Trim(), TxtAutores.Text.Trim(), int.Parse(TxtAno.Text),
                        int.Parse(TxtEdicion.Text), TxtPais.Text.Trim(), TxtIdioma.Text.Trim(), TxtMateria.Text.Trim(), int.Parse(TxtPaginas.Text), TxtUbicacion.Text.Trim(),
                        TxtDescripcion.Text.Trim(), TxtEditorial.Text.Trim());

                    if (Rpta.Equals("OK"))
                    {
                        this.MensajeOk("Se Actualizo de forma correcta");
                        this.Limpiar();
                        this.Listar();
                    }
                    else
                    {
                        this.MensajeError(Rpta);
                    }
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Esta seguro que desea eliminar el registro", "Biblioteca", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if(Opcion == DialogResult.OK)
                {
                    int Codigo;
                    string Rpta = "";

                    foreach(DataGridViewRow row in DgvListado.Rows)
                    {
                        if(Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToInt32(row.Cells[1].Value);
                            Rpta = NLibro.Eliminar(Codigo);
                            if(Rpta.Equals("OK"))
                            {
                                this.MensajeOk("Se elimino el registro: " + Convert.ToString(row.Cells[3].Value));
                            }
                            else
                            {
                                this.MensajeError(Rpta);
                                this.Limpiar();
                            }

                        }
                    }
                    this.Listar();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (Chkseleccionar.Checked)
            {
                BtnEliminar.Visible = true;
                DgvListado.Columns[0].Visible = true;
            }
            else
            {
                BtnEliminar.Visible = false;
                DgvListado.Columns[0].Visible = false;
            }
        }
    }
}
