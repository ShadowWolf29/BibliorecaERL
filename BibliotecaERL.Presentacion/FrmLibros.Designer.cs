
namespace ProyectoBiblitecaERL.Vistas
{
    partial class FrmLibros
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblBibliotecaName = new System.Windows.Forms.Label();
            this.LblUserName = new System.Windows.Forms.Label();
            this.LblInicio = new System.Windows.Forms.Label();
            this.GrbDatos = new System.Windows.Forms.GroupBox();
            this.Chkseleccionar = new System.Windows.Forms.CheckBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.LblDescripcion = new System.Windows.Forms.Label();
            this.TxtPaginas = new System.Windows.Forms.TextBox();
            this.LblPaginas = new System.Windows.Forms.Label();
            this.TxtEdicion = new System.Windows.Forms.TextBox();
            this.LblEdicion = new System.Windows.Forms.Label();
            this.TxtUbicacion = new System.Windows.Forms.TextBox();
            this.LblUbicacion = new System.Windows.Forms.Label();
            this.TxtAno = new System.Windows.Forms.TextBox();
            this.LblAno = new System.Windows.Forms.Label();
            this.TxtCantidad = new System.Windows.Forms.TextBox();
            this.LblCantidad = new System.Windows.Forms.Label();
            this.TxtISBM = new System.Windows.Forms.TextBox();
            this.LblISBM = new System.Windows.Forms.Label();
            this.TxtIdioma = new System.Windows.Forms.TextBox();
            this.LblIdioma = new System.Windows.Forms.Label();
            this.TxtMateria = new System.Windows.Forms.TextBox();
            this.LblMateria = new System.Windows.Forms.Label();
            this.TxtEditorial = new System.Windows.Forms.TextBox();
            this.LblEditorial = new System.Windows.Forms.Label();
            this.TxtPais = new System.Windows.Forms.TextBox();
            this.LblPais = new System.Windows.Forms.Label();
            this.TxtAutores = new System.Windows.Forms.TextBox();
            this.LblAutores = new System.Windows.Forms.Label();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.LblCodigo = new System.Windows.Forms.Label();
            this.TxtTiutlos = new System.Windows.Forms.TextBox();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.DgvListado = new System.Windows.Forms.DataGridView();
            this.Seleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.LblTituloBuscar = new System.Windows.Forms.Label();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.LblLibros = new System.Windows.Forms.Label();
            this.BtnRegresar = new System.Windows.Forms.Button();
            this.LbllInicio = new System.Windows.Forms.LinkLabel();
            this.ErrorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.GrbDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorIcono)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.LblBibliotecaName);
            this.panel1.Controls.Add(this.LblUserName);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(933, 47);
            this.panel1.TabIndex = 5;
            // 
            // LblBibliotecaName
            // 
            this.LblBibliotecaName.AutoSize = true;
            this.LblBibliotecaName.BackColor = System.Drawing.Color.Teal;
            this.LblBibliotecaName.Font = new System.Drawing.Font("Segoe UI", 21.75F);
            this.LblBibliotecaName.ForeColor = System.Drawing.Color.White;
            this.LblBibliotecaName.Location = new System.Drawing.Point(9, 5);
            this.LblBibliotecaName.Name = "LblBibliotecaName";
            this.LblBibliotecaName.Size = new System.Drawing.Size(192, 40);
            this.LblBibliotecaName.TabIndex = 3;
            this.LblBibliotecaName.Text = "Biclioteca ERL";
            // 
            // LblUserName
            // 
            this.LblUserName.AutoSize = true;
            this.LblUserName.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.LblUserName.ForeColor = System.Drawing.Color.White;
            this.LblUserName.Location = new System.Drawing.Point(688, 10);
            this.LblUserName.Name = "LblUserName";
            this.LblUserName.Size = new System.Drawing.Size(203, 32);
            this.LblUserName.TabIndex = 2;
            this.LblUserName.Text = "Carlos Quintanilla";
            // 
            // LblInicio
            // 
            this.LblInicio.AutoSize = true;
            this.LblInicio.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.LblInicio.ForeColor = System.Drawing.Color.White;
            this.LblInicio.Location = new System.Drawing.Point(-84, 204);
            this.LblInicio.Name = "LblInicio";
            this.LblInicio.Size = new System.Drawing.Size(81, 37);
            this.LblInicio.TabIndex = 4;
            this.LblInicio.Text = "Inicio";
            // 
            // GrbDatos
            // 
            this.GrbDatos.Controls.Add(this.Chkseleccionar);
            this.GrbDatos.Controls.Add(this.btnCancelar);
            this.GrbDatos.Controls.Add(this.btnInsertar);
            this.GrbDatos.Controls.Add(this.BtnActualizar);
            this.GrbDatos.Controls.Add(this.BtnEliminar);
            this.GrbDatos.Controls.Add(this.TxtDescripcion);
            this.GrbDatos.Controls.Add(this.LblDescripcion);
            this.GrbDatos.Controls.Add(this.TxtPaginas);
            this.GrbDatos.Controls.Add(this.LblPaginas);
            this.GrbDatos.Controls.Add(this.TxtEdicion);
            this.GrbDatos.Controls.Add(this.LblEdicion);
            this.GrbDatos.Controls.Add(this.TxtUbicacion);
            this.GrbDatos.Controls.Add(this.LblUbicacion);
            this.GrbDatos.Controls.Add(this.TxtAno);
            this.GrbDatos.Controls.Add(this.LblAno);
            this.GrbDatos.Controls.Add(this.TxtCantidad);
            this.GrbDatos.Controls.Add(this.LblCantidad);
            this.GrbDatos.Controls.Add(this.TxtISBM);
            this.GrbDatos.Controls.Add(this.LblISBM);
            this.GrbDatos.Controls.Add(this.TxtIdioma);
            this.GrbDatos.Controls.Add(this.LblIdioma);
            this.GrbDatos.Controls.Add(this.TxtMateria);
            this.GrbDatos.Controls.Add(this.LblMateria);
            this.GrbDatos.Controls.Add(this.TxtEditorial);
            this.GrbDatos.Controls.Add(this.LblEditorial);
            this.GrbDatos.Controls.Add(this.TxtPais);
            this.GrbDatos.Controls.Add(this.LblPais);
            this.GrbDatos.Controls.Add(this.TxtAutores);
            this.GrbDatos.Controls.Add(this.LblAutores);
            this.GrbDatos.Controls.Add(this.TxtCodigo);
            this.GrbDatos.Controls.Add(this.LblCodigo);
            this.GrbDatos.Controls.Add(this.TxtTiutlos);
            this.GrbDatos.Controls.Add(this.LblTitulo);
            this.GrbDatos.Font = new System.Drawing.Font("Segoe UI", 21.75F);
            this.GrbDatos.ForeColor = System.Drawing.Color.White;
            this.GrbDatos.Location = new System.Drawing.Point(10, 101);
            this.GrbDatos.Name = "GrbDatos";
            this.GrbDatos.Size = new System.Drawing.Size(471, 647);
            this.GrbDatos.TabIndex = 6;
            this.GrbDatos.TabStop = false;
            this.GrbDatos.Text = "Datos del libro";
            // 
            // Chkseleccionar
            // 
            this.Chkseleccionar.BackColor = System.Drawing.Color.White;
            this.Chkseleccionar.Cursor = System.Windows.Forms.Cursors.Default;
            this.Chkseleccionar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chkseleccionar.ForeColor = System.Drawing.Color.Black;
            this.Chkseleccionar.Location = new System.Drawing.Point(114, 610);
            this.Chkseleccionar.Name = "Chkseleccionar";
            this.Chkseleccionar.Size = new System.Drawing.Size(97, 23);
            this.Chkseleccionar.TabIndex = 43;
            this.Chkseleccionar.Text = "Seleccionar";
            this.Chkseleccionar.UseVisualStyleBackColor = false;
            this.Chkseleccionar.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.btnCancelar.ForeColor = System.Drawing.Color.Black;
            this.btnCancelar.Location = new System.Drawing.Point(217, 601);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(101, 35);
            this.btnCancelar.TabIndex = 42;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.BackColor = System.Drawing.Color.Teal;
            this.btnInsertar.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.btnInsertar.ForeColor = System.Drawing.Color.White;
            this.btnInsertar.Location = new System.Drawing.Point(328, 600);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(119, 35);
            this.btnInsertar.TabIndex = 41;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = false;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.BackColor = System.Drawing.Color.Teal;
            this.BtnActualizar.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.BtnActualizar.ForeColor = System.Drawing.Color.White;
            this.BtnActualizar.Location = new System.Drawing.Point(328, 600);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(119, 35);
            this.BtnActualizar.TabIndex = 40;
            this.BtnActualizar.Text = "Actualizar";
            this.BtnActualizar.UseVisualStyleBackColor = false;
            this.BtnActualizar.Visible = false;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.SystemColors.Control;
            this.BtnEliminar.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.BtnEliminar.ForeColor = System.Drawing.Color.Black;
            this.BtnEliminar.Location = new System.Drawing.Point(7, 601);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(101, 35);
            this.BtnEliminar.TabIndex = 13;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Visible = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.TxtDescripcion.Location = new System.Drawing.Point(130, 485);
            this.TxtDescripcion.Multiline = true;
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(318, 110);
            this.TxtDescripcion.TabIndex = 39;
            // 
            // LblDescripcion
            // 
            this.LblDescripcion.AutoSize = true;
            this.LblDescripcion.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.LblDescripcion.ForeColor = System.Drawing.Color.White;
            this.LblDescripcion.Location = new System.Drawing.Point(16, 485);
            this.LblDescripcion.Name = "LblDescripcion";
            this.LblDescripcion.Size = new System.Drawing.Size(115, 25);
            this.LblDescripcion.TabIndex = 38;
            this.LblDescripcion.Text = "Descripción:";
            // 
            // TxtPaginas
            // 
            this.TxtPaginas.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.TxtPaginas.Location = new System.Drawing.Point(328, 443);
            this.TxtPaginas.Name = "TxtPaginas";
            this.TxtPaginas.Size = new System.Drawing.Size(120, 33);
            this.TxtPaginas.TabIndex = 37;
            // 
            // LblPaginas
            // 
            this.LblPaginas.AutoSize = true;
            this.LblPaginas.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.LblPaginas.ForeColor = System.Drawing.Color.White;
            this.LblPaginas.Location = new System.Drawing.Point(241, 442);
            this.LblPaginas.Name = "LblPaginas";
            this.LblPaginas.Size = new System.Drawing.Size(89, 30);
            this.LblPaginas.TabIndex = 36;
            this.LblPaginas.Text = "Paginas:";
            // 
            // TxtEdicion
            // 
            this.TxtEdicion.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.TxtEdicion.Location = new System.Drawing.Point(120, 442);
            this.TxtEdicion.Name = "TxtEdicion";
            this.TxtEdicion.Size = new System.Drawing.Size(115, 33);
            this.TxtEdicion.TabIndex = 35;
            // 
            // LblEdicion
            // 
            this.LblEdicion.AutoSize = true;
            this.LblEdicion.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.LblEdicion.ForeColor = System.Drawing.Color.White;
            this.LblEdicion.Location = new System.Drawing.Point(15, 442);
            this.LblEdicion.Name = "LblEdicion";
            this.LblEdicion.Size = new System.Drawing.Size(85, 30);
            this.LblEdicion.TabIndex = 34;
            this.LblEdicion.Text = "Edición:";
            // 
            // TxtUbicacion
            // 
            this.TxtUbicacion.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.TxtUbicacion.Location = new System.Drawing.Point(120, 399);
            this.TxtUbicacion.Name = "TxtUbicacion";
            this.TxtUbicacion.Size = new System.Drawing.Size(328, 33);
            this.TxtUbicacion.TabIndex = 33;
            // 
            // LblUbicacion
            // 
            this.LblUbicacion.AutoSize = true;
            this.LblUbicacion.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.LblUbicacion.ForeColor = System.Drawing.Color.White;
            this.LblUbicacion.Location = new System.Drawing.Point(15, 399);
            this.LblUbicacion.Name = "LblUbicacion";
            this.LblUbicacion.Size = new System.Drawing.Size(109, 30);
            this.LblUbicacion.TabIndex = 32;
            this.LblUbicacion.Text = "Ubicación:";
            // 
            // TxtAno
            // 
            this.TxtAno.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.TxtAno.Location = new System.Drawing.Point(301, 182);
            this.TxtAno.Name = "TxtAno";
            this.TxtAno.Size = new System.Drawing.Size(147, 33);
            this.TxtAno.TabIndex = 31;
            // 
            // LblAno
            // 
            this.LblAno.AutoSize = true;
            this.LblAno.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.LblAno.ForeColor = System.Drawing.Color.White;
            this.LblAno.Location = new System.Drawing.Point(247, 182);
            this.LblAno.Name = "LblAno";
            this.LblAno.Size = new System.Drawing.Size(56, 30);
            this.LblAno.TabIndex = 30;
            this.LblAno.Text = "Año:";
            // 
            // TxtCantidad
            // 
            this.TxtCantidad.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.TxtCantidad.Location = new System.Drawing.Point(120, 182);
            this.TxtCantidad.Name = "TxtCantidad";
            this.TxtCantidad.Size = new System.Drawing.Size(121, 33);
            this.TxtCantidad.TabIndex = 29;
            // 
            // LblCantidad
            // 
            this.LblCantidad.AutoSize = true;
            this.LblCantidad.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.LblCantidad.ForeColor = System.Drawing.Color.White;
            this.LblCantidad.Location = new System.Drawing.Point(15, 182);
            this.LblCantidad.Name = "LblCantidad";
            this.LblCantidad.Size = new System.Drawing.Size(101, 30);
            this.LblCantidad.TabIndex = 28;
            this.LblCantidad.Text = "Cantidad:";
            // 
            // TxtISBM
            // 
            this.TxtISBM.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.TxtISBM.Location = new System.Drawing.Point(301, 52);
            this.TxtISBM.Name = "TxtISBM";
            this.TxtISBM.Size = new System.Drawing.Size(147, 33);
            this.TxtISBM.TabIndex = 27;
            this.TxtISBM.TextChanged += new System.EventHandler(this.textBox10_TextChanged);
            // 
            // LblISBM
            // 
            this.LblISBM.AutoSize = true;
            this.LblISBM.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.LblISBM.ForeColor = System.Drawing.Color.White;
            this.LblISBM.Location = new System.Drawing.Point(247, 51);
            this.LblISBM.Name = "LblISBM";
            this.LblISBM.Size = new System.Drawing.Size(66, 30);
            this.LblISBM.TabIndex = 26;
            this.LblISBM.Text = "ISBM:";
            this.LblISBM.Click += new System.EventHandler(this.label1_Click);
            // 
            // TxtIdioma
            // 
            this.TxtIdioma.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.TxtIdioma.Location = new System.Drawing.Point(120, 312);
            this.TxtIdioma.Name = "TxtIdioma";
            this.TxtIdioma.Size = new System.Drawing.Size(328, 33);
            this.TxtIdioma.TabIndex = 25;
            // 
            // LblIdioma
            // 
            this.LblIdioma.AutoSize = true;
            this.LblIdioma.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.LblIdioma.ForeColor = System.Drawing.Color.White;
            this.LblIdioma.Location = new System.Drawing.Point(15, 312);
            this.LblIdioma.Name = "LblIdioma";
            this.LblIdioma.Size = new System.Drawing.Size(82, 30);
            this.LblIdioma.TabIndex = 24;
            this.LblIdioma.Text = "Idioma:";
            // 
            // TxtMateria
            // 
            this.TxtMateria.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.TxtMateria.Location = new System.Drawing.Point(120, 355);
            this.TxtMateria.Name = "TxtMateria";
            this.TxtMateria.Size = new System.Drawing.Size(328, 33);
            this.TxtMateria.TabIndex = 23;
            // 
            // LblMateria
            // 
            this.LblMateria.AutoSize = true;
            this.LblMateria.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.LblMateria.ForeColor = System.Drawing.Color.White;
            this.LblMateria.Location = new System.Drawing.Point(15, 355);
            this.LblMateria.Name = "LblMateria";
            this.LblMateria.Size = new System.Drawing.Size(89, 30);
            this.LblMateria.TabIndex = 22;
            this.LblMateria.Text = "Materia:";
            // 
            // TxtEditorial
            // 
            this.TxtEditorial.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.TxtEditorial.Location = new System.Drawing.Point(120, 225);
            this.TxtEditorial.Name = "TxtEditorial";
            this.TxtEditorial.Size = new System.Drawing.Size(328, 33);
            this.TxtEditorial.TabIndex = 21;
            // 
            // LblEditorial
            // 
            this.LblEditorial.AutoSize = true;
            this.LblEditorial.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.LblEditorial.ForeColor = System.Drawing.Color.White;
            this.LblEditorial.Location = new System.Drawing.Point(15, 224);
            this.LblEditorial.Name = "LblEditorial";
            this.LblEditorial.Size = new System.Drawing.Size(93, 30);
            this.LblEditorial.TabIndex = 20;
            this.LblEditorial.Text = "Editorial:";
            // 
            // TxtPais
            // 
            this.TxtPais.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.TxtPais.Location = new System.Drawing.Point(120, 269);
            this.TxtPais.Name = "TxtPais";
            this.TxtPais.Size = new System.Drawing.Size(328, 33);
            this.TxtPais.TabIndex = 19;
            // 
            // LblPais
            // 
            this.LblPais.AutoSize = true;
            this.LblPais.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.LblPais.ForeColor = System.Drawing.Color.White;
            this.LblPais.Location = new System.Drawing.Point(15, 269);
            this.LblPais.Name = "LblPais";
            this.LblPais.Size = new System.Drawing.Size(54, 30);
            this.LblPais.TabIndex = 18;
            this.LblPais.Text = "País:";
            // 
            // TxtAutores
            // 
            this.TxtAutores.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.TxtAutores.Location = new System.Drawing.Point(120, 139);
            this.TxtAutores.Name = "TxtAutores";
            this.TxtAutores.Size = new System.Drawing.Size(328, 33);
            this.TxtAutores.TabIndex = 17;
            // 
            // LblAutores
            // 
            this.LblAutores.AutoSize = true;
            this.LblAutores.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.LblAutores.ForeColor = System.Drawing.Color.White;
            this.LblAutores.Location = new System.Drawing.Point(15, 139);
            this.LblAutores.Name = "LblAutores";
            this.LblAutores.Size = new System.Drawing.Size(90, 30);
            this.LblAutores.TabIndex = 16;
            this.LblAutores.Text = "Autores:";
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.TxtCodigo.Location = new System.Drawing.Point(120, 52);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.ReadOnly = true;
            this.TxtCodigo.Size = new System.Drawing.Size(121, 33);
            this.TxtCodigo.TabIndex = 13;
            // 
            // LblCodigo
            // 
            this.LblCodigo.AutoSize = true;
            this.LblCodigo.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.LblCodigo.ForeColor = System.Drawing.Color.White;
            this.LblCodigo.Location = new System.Drawing.Point(15, 51);
            this.LblCodigo.Name = "LblCodigo";
            this.LblCodigo.Size = new System.Drawing.Size(84, 30);
            this.LblCodigo.TabIndex = 12;
            this.LblCodigo.Text = "Codigo:";
            this.LblCodigo.Click += new System.EventHandler(this.label2_Click);
            // 
            // TxtTiutlos
            // 
            this.TxtTiutlos.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.TxtTiutlos.Location = new System.Drawing.Point(120, 95);
            this.TxtTiutlos.Name = "TxtTiutlos";
            this.TxtTiutlos.Size = new System.Drawing.Size(328, 33);
            this.TxtTiutlos.TabIndex = 11;
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.LblTitulo.ForeColor = System.Drawing.Color.White;
            this.LblTitulo.Location = new System.Drawing.Point(15, 95);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(70, 30);
            this.LblTitulo.TabIndex = 10;
            this.LblTitulo.Text = "Titulo:";
            // 
            // DgvListado
            // 
            this.DgvListado.AllowUserToAddRows = false;
            this.DgvListado.AllowUserToDeleteRows = false;
            this.DgvListado.AllowUserToOrderColumns = true;
            this.DgvListado.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.DgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccionar});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvListado.DefaultCellStyle = dataGridViewCellStyle1;
            this.DgvListado.Location = new System.Drawing.Point(487, 194);
            this.DgvListado.Name = "DgvListado";
            this.DgvListado.ReadOnly = true;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.DgvListado.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvListado.RowTemplate.Height = 25;
            this.DgvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvListado.Size = new System.Drawing.Size(432, 547);
            this.DgvListado.TabIndex = 7;
            this.DgvListado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListado_CellContentClick);
            this.DgvListado.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListado_CellDoubleClick);
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "Seleccionar";
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.ReadOnly = true;
            // 
            // LblTituloBuscar
            // 
            this.LblTituloBuscar.AutoSize = true;
            this.LblTituloBuscar.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.LblTituloBuscar.ForeColor = System.Drawing.Color.White;
            this.LblTituloBuscar.Location = new System.Drawing.Point(496, 116);
            this.LblTituloBuscar.Name = "LblTituloBuscar";
            this.LblTituloBuscar.Size = new System.Drawing.Size(70, 30);
            this.LblTituloBuscar.TabIndex = 8;
            this.LblTituloBuscar.Text = "Titulo:";
            this.LblTituloBuscar.Click += new System.EventHandler(this.lblBuscar_Click);
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.TxtBuscar.Location = new System.Drawing.Point(569, 117);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(253, 33);
            this.TxtBuscar.TabIndex = 9;
            this.TxtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBuscar_KeyPress);
            this.TxtBuscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtBuscar_KeyUp);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.textBox3.Location = new System.Drawing.Point(103, 159);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(294, 33);
            this.textBox3.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(293, 305);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 30);
            this.label1.TabIndex = 30;
            this.label1.Text = "ISBM:";
            // 
            // textBox11
            // 
            this.textBox11.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.textBox11.Location = new System.Drawing.Point(108, 306);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(171, 33);
            this.textBox11.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(23, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 30);
            this.label2.TabIndex = 28;
            this.label2.Text = "Codigo:";
            // 
            // textBox14
            // 
            this.textBox14.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.textBox14.Location = new System.Drawing.Point(356, 321);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(171, 33);
            this.textBox14.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(293, 320);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 30);
            this.label3.TabIndex = 36;
            this.label3.Text = "ISBM:";
            // 
            // textBox15
            // 
            this.textBox15.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.textBox15.Location = new System.Drawing.Point(108, 321);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(171, 33);
            this.textBox15.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(23, 320);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 30);
            this.label4.TabIndex = 34;
            this.label4.Text = "Codigo:";
            // 
            // LblLibros
            // 
            this.LblLibros.AutoSize = true;
            this.LblLibros.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.LblLibros.ForeColor = System.Drawing.Color.White;
            this.LblLibros.Location = new System.Drawing.Point(82, 57);
            this.LblLibros.Name = "LblLibros";
            this.LblLibros.Size = new System.Drawing.Size(101, 32);
            this.LblLibros.TabIndex = 14;
            this.LblLibros.Text = "> Libros";
            this.LblLibros.Click += new System.EventHandler(this.label6_Click);
            // 
            // BtnRegresar
            // 
            this.BtnRegresar.BackColor = System.Drawing.SystemColors.Control;
            this.BtnRegresar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnRegresar.ForeColor = System.Drawing.Color.Black;
            this.BtnRegresar.Location = new System.Drawing.Point(10, 753);
            this.BtnRegresar.Name = "BtnRegresar";
            this.BtnRegresar.Size = new System.Drawing.Size(91, 26);
            this.BtnRegresar.TabIndex = 41;
            this.BtnRegresar.Text = "Regresar";
            this.BtnRegresar.UseVisualStyleBackColor = false;
            this.BtnRegresar.Click += new System.EventHandler(this.BtnRegresar_Click);
            // 
            // LbllInicio
            // 
            this.LbllInicio.ActiveLinkColor = System.Drawing.Color.Silver;
            this.LbllInicio.AutoSize = true;
            this.LbllInicio.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.LbllInicio.LinkColor = System.Drawing.Color.White;
            this.LbllInicio.Location = new System.Drawing.Point(25, 57);
            this.LbllInicio.Name = "LbllInicio";
            this.LbllInicio.Size = new System.Drawing.Size(72, 32);
            this.LbllInicio.TabIndex = 42;
            this.LbllInicio.TabStop = true;
            this.LbllInicio.Text = "Inicio";
            this.LbllInicio.VisitedLinkColor = System.Drawing.Color.White;
            this.LbllInicio.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LbllInicio_LinkClicked);
            // 
            // ErrorIcono
            // 
            this.ErrorIcono.ContainerControl = this;
            // 
            // FrmLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SaddleBrown;
            this.ClientSize = new System.Drawing.Size(929, 790);
            this.Controls.Add(this.LbllInicio);
            this.Controls.Add(this.BtnRegresar);
            this.Controls.Add(this.LblLibros);
            this.Controls.Add(this.TxtBuscar);
            this.Controls.Add(this.LblTituloBuscar);
            this.Controls.Add(this.DgvListado);
            this.Controls.Add(this.GrbDatos);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LblInicio);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "FrmLibros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "v";
            this.Load += new System.EventHandler(this.FrmLibros_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.GrbDatos.ResumeLayout(false);
            this.GrbDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorIcono)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblBibliotecaName;
        private System.Windows.Forms.Label LblUserName;
        private System.Windows.Forms.Label LblInicio;
        private System.Windows.Forms.GroupBox GrbDatos;
        private System.Windows.Forms.DataGridView DgvListado;
        private System.Windows.Forms.Label LblTituloBuscar;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.TextBox TxtIdioma;
        private System.Windows.Forms.Label LblIdioma;
        private System.Windows.Forms.TextBox TxtMateria;
        private System.Windows.Forms.Label LblMateria;
        private System.Windows.Forms.TextBox TxtEditorial;
        private System.Windows.Forms.Label LblEditorial;
        private System.Windows.Forms.TextBox TxtPais;
        private System.Windows.Forms.Label LblPais;
        private System.Windows.Forms.TextBox TxtAutores;
        private System.Windows.Forms.Label LblAutores;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.Label LblCodigo;
        private System.Windows.Forms.TextBox TxtTiutlos;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox TxtISBM;
        private System.Windows.Forms.Label LblISBM;
        private System.Windows.Forms.TextBox TxtAno;
        private System.Windows.Forms.Label LblAno;
        private System.Windows.Forms.TextBox TxtCantidad;
        private System.Windows.Forms.Label LblCantidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnActualizar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.Label LblDescripcion;
        private System.Windows.Forms.TextBox TxtPaginas;
        private System.Windows.Forms.Label LblPaginas;
        private System.Windows.Forms.TextBox TxtEdicion;
        private System.Windows.Forms.Label LblEdicion;
        private System.Windows.Forms.TextBox TxtUbicacion;
        private System.Windows.Forms.Label LblUbicacion;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblLibros;
        private System.Windows.Forms.Button BtnRegresar;
        private System.Windows.Forms.LinkLabel LbllInicio;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccionar;
        private System.Windows.Forms.ErrorProvider ErrorIcono;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.CheckBox Chkseleccionar;
    }
}