
namespace ProyectoBiblitecaERL.Vistas
{
    partial class FrmPrestamos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrestamos));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ImgUser = new System.Windows.Forms.PictureBox();
            this.LblBibliotecaName = new System.Windows.Forms.Label();
            this.LblUserName = new System.Windows.Forms.Label();
            this.LblInicio = new System.Windows.Forms.LinkLabel();
            this.LblProfesores = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Nuevo = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.TxtBuscatLibro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DgvLibro = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TxtUbicacion = new System.Windows.Forms.TextBox();
            this.TxtAutores = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtTitulo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtISBN = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnRegresar = new System.Windows.Forms.Button();
            this.txtNombreBuscar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DgvProfesor = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtApellido1 = new System.Windows.Forms.TextBox();
            this.TxtNombre1 = new System.Windows.Forms.TextBox();
            this.LblNombre1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblapellidos = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.lblestado = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.lbltitulos = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lbltiempo = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lbl_fechadevolucion = new System.Windows.Forms.Label();
            this.lbl_fechainicio = new System.Windows.Forms.Label();
            this.lblnombres = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.txtprestamo = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.Dgvactivos = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.LblApellido = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.DtpDevolucion = new System.Windows.Forms.DateTimePicker();
            this.txtidlibro = new System.Windows.Forms.TextBox();
            this.txtidprofesor = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgUser)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.Nuevo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLibro)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProfesor)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgvactivos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.ImgUser);
            this.panel1.Controls.Add(this.LblBibliotecaName);
            this.panel1.Controls.Add(this.LblUserName);
            this.panel1.Location = new System.Drawing.Point(1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1015, 47);
            this.panel1.TabIndex = 61;
            // 
            // ImgUser
            // 
            this.ImgUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ImgUser.Image = ((System.Drawing.Image)(resources.GetObject("ImgUser.Image")));
            this.ImgUser.Location = new System.Drawing.Point(961, 3);
            this.ImgUser.Name = "ImgUser";
            this.ImgUser.Size = new System.Drawing.Size(43, 43);
            this.ImgUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImgUser.TabIndex = 4;
            this.ImgUser.TabStop = false;
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
            this.LblUserName.Location = new System.Drawing.Point(751, 10);
            this.LblUserName.Name = "LblUserName";
            this.LblUserName.Size = new System.Drawing.Size(203, 32);
            this.LblUserName.TabIndex = 2;
            this.LblUserName.Text = "Carlos Quintanilla";
            // 
            // LblInicio
            // 
            this.LblInicio.ActiveLinkColor = System.Drawing.Color.Silver;
            this.LblInicio.AutoSize = true;
            this.LblInicio.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.LblInicio.LinkColor = System.Drawing.Color.White;
            this.LblInicio.Location = new System.Drawing.Point(35, 57);
            this.LblInicio.Name = "LblInicio";
            this.LblInicio.Size = new System.Drawing.Size(72, 32);
            this.LblInicio.TabIndex = 60;
            this.LblInicio.TabStop = true;
            this.LblInicio.Text = "Inicio";
            this.LblInicio.VisitedLinkColor = System.Drawing.Color.White;
            this.LblInicio.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LblInicio_LinkClicked);
            // 
            // LblProfesores
            // 
            this.LblProfesores.AutoSize = true;
            this.LblProfesores.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.LblProfesores.ForeColor = System.Drawing.Color.White;
            this.LblProfesores.Location = new System.Drawing.Point(93, 57);
            this.LblProfesores.Name = "LblProfesores";
            this.LblProfesores.Size = new System.Drawing.Size(147, 32);
            this.LblProfesores.TabIndex = 59;
            this.LblProfesores.Text = "> Prestamos";
            this.LblProfesores.Click += new System.EventHandler(this.LblProfesores_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Nuevo);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(2, 92);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1014, 659);
            this.tabControl1.TabIndex = 68;
            // 
            // Nuevo
            // 
            this.Nuevo.BackColor = System.Drawing.Color.Sienna;
            this.Nuevo.Controls.Add(this.btnCancelar);
            this.Nuevo.Controls.Add(this.txtidprofesor);
            this.Nuevo.Controls.Add(this.label10);
            this.Nuevo.Controls.Add(this.txtidlibro);
            this.Nuevo.Controls.Add(this.button1);
            this.Nuevo.Controls.Add(this.TxtBuscatLibro);
            this.Nuevo.Controls.Add(this.label1);
            this.Nuevo.Controls.Add(this.DgvLibro);
            this.Nuevo.Controls.Add(this.groupBox2);
            this.Nuevo.Controls.Add(this.BtnRegresar);
            this.Nuevo.Controls.Add(this.txtNombreBuscar);
            this.Nuevo.Controls.Add(this.label3);
            this.Nuevo.Controls.Add(this.DgvProfesor);
            this.Nuevo.Controls.Add(this.groupBox1);
            this.Nuevo.Location = new System.Drawing.Point(4, 25);
            this.Nuevo.Name = "Nuevo";
            this.Nuevo.Padding = new System.Windows.Forms.Padding(3);
            this.Nuevo.Size = new System.Drawing.Size(1006, 630);
            this.Nuevo.TabIndex = 0;
            this.Nuevo.Text = "Nuevo";
            this.Nuevo.Click += new System.EventHandler(this.Nuevo_Click);
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(388, 16);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label10.Size = new System.Drawing.Size(230, 40);
            this.label10.TabIndex = 79;
            this.label10.Text = "Nuevo prestamo";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 21.75F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(802, 493);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 66);
            this.button1.TabIndex = 78;
            this.button1.Text = "Ingresar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TxtBuscatLibro
            // 
            this.TxtBuscatLibro.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.TxtBuscatLibro.Location = new System.Drawing.Point(752, 120);
            this.TxtBuscatLibro.Name = "TxtBuscatLibro";
            this.TxtBuscatLibro.Size = new System.Drawing.Size(236, 33);
            this.TxtBuscatLibro.TabIndex = 77;
            this.TxtBuscatLibro.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtBuscatLibro_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(752, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 30);
            this.label1.TabIndex = 76;
            this.label1.Text = "Titulo o ISBN:";
            // 
            // DgvLibro
            // 
            this.DgvLibro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvLibro.Location = new System.Drawing.Point(752, 166);
            this.DgvLibro.Name = "DgvLibro";
            this.DgvLibro.RowTemplate.Height = 25;
            this.DgvLibro.Size = new System.Drawing.Size(236, 285);
            this.DgvLibro.TabIndex = 75;
            this.DgvLibro.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvLibro_CellContentDoubleClick);
            this.DgvLibro.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvLibro_CellDoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DtpDevolucion);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.TxtUbicacion);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.TxtAutores);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.TxtTitulo);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.TxtISBN);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 21.75F);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(507, 77);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(239, 388);
            this.groupBox2.TabIndex = 74;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos del libro";
            // 
            // TxtUbicacion
            // 
            this.TxtUbicacion.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.TxtUbicacion.Location = new System.Drawing.Point(18, 273);
            this.TxtUbicacion.Name = "TxtUbicacion";
            this.TxtUbicacion.ReadOnly = true;
            this.TxtUbicacion.Size = new System.Drawing.Size(201, 33);
            this.TxtUbicacion.TabIndex = 21;
            // 
            // TxtAutores
            // 
            this.TxtAutores.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.TxtAutores.Location = new System.Drawing.Point(18, 208);
            this.TxtAutores.Name = "TxtAutores";
            this.TxtAutores.ReadOnly = true;
            this.TxtAutores.Size = new System.Drawing.Size(200, 33);
            this.TxtAutores.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(18, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 30);
            this.label4.TabIndex = 16;
            this.label4.Text = "Autores:";
            // 
            // TxtTitulo
            // 
            this.TxtTitulo.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.TxtTitulo.Location = new System.Drawing.Point(18, 69);
            this.TxtTitulo.Name = "TxtTitulo";
            this.TxtTitulo.ReadOnly = true;
            this.TxtTitulo.Size = new System.Drawing.Size(200, 33);
            this.TxtTitulo.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(18, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 30);
            this.label5.TabIndex = 12;
            this.label5.Text = "Titulo:";
            // 
            // TxtISBN
            // 
            this.TxtISBN.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.TxtISBN.Location = new System.Drawing.Point(18, 139);
            this.TxtISBN.Name = "TxtISBN";
            this.TxtISBN.ReadOnly = true;
            this.TxtISBN.Size = new System.Drawing.Size(200, 33);
            this.TxtISBN.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(18, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 30);
            this.label6.TabIndex = 10;
            this.label6.Text = "ISBN:";
            // 
            // BtnRegresar
            // 
            this.BtnRegresar.BackColor = System.Drawing.SystemColors.Control;
            this.BtnRegresar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnRegresar.ForeColor = System.Drawing.Color.Black;
            this.BtnRegresar.Location = new System.Drawing.Point(14, 589);
            this.BtnRegresar.Name = "BtnRegresar";
            this.BtnRegresar.Size = new System.Drawing.Size(146, 34);
            this.BtnRegresar.TabIndex = 73;
            this.BtnRegresar.Text = "Regresar";
            this.BtnRegresar.UseVisualStyleBackColor = false;
            // 
            // txtNombreBuscar
            // 
            this.txtNombreBuscar.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.txtNombreBuscar.Location = new System.Drawing.Point(258, 120);
            this.txtNombreBuscar.Name = "txtNombreBuscar";
            this.txtNombreBuscar.Size = new System.Drawing.Size(236, 33);
            this.txtNombreBuscar.TabIndex = 72;
            this.txtNombreBuscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtNombreBuscar_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(258, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 30);
            this.label3.TabIndex = 71;
            this.label3.Text = "Nombre:";
            // 
            // DgvProfesor
            // 
            this.DgvProfesor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvProfesor.Location = new System.Drawing.Point(258, 166);
            this.DgvProfesor.Name = "DgvProfesor";
            this.DgvProfesor.RowTemplate.Height = 25;
            this.DgvProfesor.Size = new System.Drawing.Size(236, 285);
            this.DgvProfesor.TabIndex = 70;
            this.DgvProfesor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvProfesor_CellContentClick);
            this.DgvProfesor.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvProfesor_CellContentClick);
            this.DgvProfesor.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvProfesor_CellDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtApellido1);
            this.groupBox1.Controls.Add(this.LblApellido);
            this.groupBox1.Controls.Add(this.TxtNombre1);
            this.groupBox1.Controls.Add(this.LblNombre1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 21.75F);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(14, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(239, 374);
            this.groupBox1.TabIndex = 68;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Profesor";
            // 
            // TxtApellido1
            // 
            this.TxtApellido1.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.TxtApellido1.Location = new System.Drawing.Point(20, 194);
            this.TxtApellido1.Name = "TxtApellido1";
            this.TxtApellido1.ReadOnly = true;
            this.TxtApellido1.Size = new System.Drawing.Size(200, 33);
            this.TxtApellido1.TabIndex = 17;
            // 
            // TxtNombre1
            // 
            this.TxtNombre1.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.TxtNombre1.Location = new System.Drawing.Point(15, 88);
            this.TxtNombre1.Name = "TxtNombre1";
            this.TxtNombre1.ReadOnly = true;
            this.TxtNombre1.Size = new System.Drawing.Size(200, 33);
            this.TxtNombre1.TabIndex = 13;
            // 
            // LblNombre1
            // 
            this.LblNombre1.AutoSize = true;
            this.LblNombre1.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.LblNombre1.ForeColor = System.Drawing.Color.White;
            this.LblNombre1.Location = new System.Drawing.Point(15, 58);
            this.LblNombre1.Name = "LblNombre1";
            this.LblNombre1.Size = new System.Drawing.Size(85, 30);
            this.LblNombre1.TabIndex = 12;
            this.LblNombre1.Text = "nombre";
            this.LblNombre1.Click += new System.EventHandler(this.LblNombre1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Sienna;
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.txtprestamo);
            this.tabPage2.Controls.Add(this.label22);
            this.tabPage2.Controls.Add(this.Dgvactivos);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1006, 630);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Activo";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(40, 581);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 34);
            this.button2.TabIndex = 85;
            this.button2.Text = "Regresar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblapellidos);
            this.groupBox4.Controls.Add(this.label24);
            this.groupBox4.Controls.Add(this.lblestado);
            this.groupBox4.Controls.Add(this.label26);
            this.groupBox4.Controls.Add(this.lbltitulos);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.lbltiempo);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.lbl_fechadevolucion);
            this.groupBox4.Controls.Add(this.lbl_fechainicio);
            this.groupBox4.Controls.Add(this.lblnombres);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Controls.Add(this.label20);
            this.groupBox4.Controls.Add(this.label21);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 21.75F);
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(648, 102);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(317, 461);
            this.groupBox4.TabIndex = 81;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Prestamo";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // lblapellidos
            // 
            this.lblapellidos.AutoSize = true;
            this.lblapellidos.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.lblapellidos.ForeColor = System.Drawing.Color.White;
            this.lblapellidos.Location = new System.Drawing.Point(21, 232);
            this.lblapellidos.Name = "lblapellidos";
            this.lblapellidos.Size = new System.Drawing.Size(0, 25);
            this.lblapellidos.TabIndex = 29;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.label24.ForeColor = System.Drawing.Color.White;
            this.label24.Location = new System.Drawing.Point(21, 263);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(207, 30);
            this.label24.TabIndex = 28;
            this.label24.Text = "Estado del prestamo:";
            // 
            // lblestado
            // 
            this.lblestado.AutoSize = true;
            this.lblestado.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.lblestado.ForeColor = System.Drawing.Color.White;
            this.lblestado.Location = new System.Drawing.Point(21, 293);
            this.lblestado.Name = "lblestado";
            this.lblestado.Size = new System.Drawing.Size(0, 25);
            this.lblestado.TabIndex = 27;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.label26.ForeColor = System.Drawing.Color.White;
            this.label26.Location = new System.Drawing.Point(21, 206);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(206, 30);
            this.label26.TabIndex = 26;
            this.label26.Text = "Apellido del profesor";
            // 
            // lbltitulos
            // 
            this.lbltitulos.AutoSize = true;
            this.lbltitulos.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.lbltitulos.ForeColor = System.Drawing.Color.White;
            this.lbltitulos.Location = new System.Drawing.Point(21, 120);
            this.lbltitulos.Name = "lbltitulos";
            this.lbltitulos.Size = new System.Drawing.Size(0, 25);
            this.lbltitulos.TabIndex = 25;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(21, 152);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(206, 30);
            this.label13.TabIndex = 24;
            this.label13.Text = "Nombre del profesor";
            // 
            // lbltiempo
            // 
            this.lbltiempo.AutoSize = true;
            this.lbltiempo.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.lbltiempo.ForeColor = System.Drawing.Color.White;
            this.lbltiempo.Location = new System.Drawing.Point(21, 69);
            this.lbltiempo.Name = "lbltiempo";
            this.lbltiempo.Size = new System.Drawing.Size(25, 25);
            this.lbltiempo.TabIndex = 23;
            this.lbltiempo.Text = "+";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(21, 43);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(214, 30);
            this.label15.TabIndex = 22;
            this.label15.Text = "Tiempo del prestamo:";
            // 
            // lbl_fechadevolucion
            // 
            this.lbl_fechadevolucion.AutoSize = true;
            this.lbl_fechadevolucion.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.lbl_fechadevolucion.ForeColor = System.Drawing.Color.White;
            this.lbl_fechadevolucion.Location = new System.Drawing.Point(21, 407);
            this.lbl_fechadevolucion.Name = "lbl_fechadevolucion";
            this.lbl_fechadevolucion.Size = new System.Drawing.Size(0, 25);
            this.lbl_fechadevolucion.TabIndex = 19;
            // 
            // lbl_fechainicio
            // 
            this.lbl_fechainicio.AutoSize = true;
            this.lbl_fechainicio.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.lbl_fechainicio.ForeColor = System.Drawing.Color.White;
            this.lbl_fechainicio.Location = new System.Drawing.Point(58, 346);
            this.lbl_fechainicio.Name = "lbl_fechainicio";
            this.lbl_fechainicio.Size = new System.Drawing.Size(0, 25);
            this.lbl_fechainicio.TabIndex = 18;
            // 
            // lblnombres
            // 
            this.lblnombres.AutoSize = true;
            this.lblnombres.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.lblnombres.ForeColor = System.Drawing.Color.White;
            this.lblnombres.Location = new System.Drawing.Point(21, 178);
            this.lblnombres.Name = "lblnombres";
            this.lblnombres.Size = new System.Drawing.Size(0, 25);
            this.lblnombres.TabIndex = 17;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(19, 377);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(208, 30);
            this.label19.TabIndex = 16;
            this.label19.Text = "Fecha de devolucion:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(21, 316);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(156, 30);
            this.label20.TabIndex = 14;
            this.label20.Text = "Fecha de inicio:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(21, 94);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(65, 30);
            this.label21.TabIndex = 12;
            this.label21.Text = "Titulo";
            // 
            // txtprestamo
            // 
            this.txtprestamo.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.txtprestamo.Location = new System.Drawing.Point(35, 131);
            this.txtprestamo.Name = "txtprestamo";
            this.txtprestamo.Size = new System.Drawing.Size(574, 33);
            this.txtprestamo.TabIndex = 84;
            this.txtprestamo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.label22.ForeColor = System.Drawing.Color.White;
            this.label22.Location = new System.Drawing.Point(35, 98);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(201, 30);
            this.label22.TabIndex = 83;
            this.label22.Text = "Nombre de profesor";
            this.label22.Click += new System.EventHandler(this.label22_Click);
            // 
            // Dgvactivos
            // 
            this.Dgvactivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgvactivos.Location = new System.Drawing.Point(35, 176);
            this.Dgvactivos.Name = "Dgvactivos";
            this.Dgvactivos.RowTemplate.Height = 25;
            this.Dgvactivos.Size = new System.Drawing.Size(574, 387);
            this.Dgvactivos.TabIndex = 82;
            this.Dgvactivos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgvactivos_CellContentClick);
            this.Dgvactivos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgvactivos_CellDoubleClick);
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(377, 16);
            this.label11.Name = "label11";
            this.label11.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label11.Size = new System.Drawing.Size(221, 40);
            this.label11.TabIndex = 80;
            this.label11.Text = "Prestamo activo";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // LblApellido
            // 
            this.LblApellido.AutoSize = true;
            this.LblApellido.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.LblApellido.ForeColor = System.Drawing.Color.White;
            this.LblApellido.Location = new System.Drawing.Point(15, 139);
            this.LblApellido.Name = "LblApellido";
            this.LblApellido.Size = new System.Drawing.Size(91, 30);
            this.LblApellido.TabIndex = 16;
            this.LblApellido.Text = "apellido:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(18, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 30);
            this.label2.TabIndex = 20;
            this.label2.Text = "Ubicación:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(18, 309);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(203, 30);
            this.label7.TabIndex = 22;
            this.label7.Text = "Fecha de devolucion";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // DtpDevolucion
            // 
            this.DtpDevolucion.CalendarFont = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpDevolucion.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpDevolucion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpDevolucion.Location = new System.Drawing.Point(6, 342);
            this.DtpDevolucion.MinDate = new System.DateTime(2021, 6, 27, 0, 0, 0, 0);
            this.DtpDevolucion.Name = "DtpDevolucion";
            this.DtpDevolucion.Size = new System.Drawing.Size(226, 23);
            this.DtpDevolucion.TabIndex = 23;
            // 
            // txtidlibro
            // 
            this.txtidlibro.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtidlibro.Location = new System.Drawing.Point(6, 504);
            this.txtidlibro.Name = "txtidlibro";
            this.txtidlibro.Size = new System.Drawing.Size(100, 25);
            this.txtidlibro.TabIndex = 18;
            this.txtidlibro.Visible = false;
            // 
            // txtidprofesor
            // 
            this.txtidprofesor.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtidprofesor.Location = new System.Drawing.Point(134, 504);
            this.txtidprofesor.Name = "txtidprofesor";
            this.txtidprofesor.Size = new System.Drawing.Size(100, 25);
            this.txtidprofesor.TabIndex = 19;
            this.txtidprofesor.Visible = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(655, 504);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(91, 40);
            this.btnCancelar.TabIndex = 80;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FrmPrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SaddleBrown;
            this.ClientSize = new System.Drawing.Size(1015, 751);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LblInicio);
            this.Controls.Add(this.LblProfesores);
            this.Name = "FrmPrestamos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPrestamos";
            this.Load += new System.EventHandler(this.FrmPrestamos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgUser)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.Nuevo.ResumeLayout(false);
            this.Nuevo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLibro)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProfesor)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgvactivos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox ImgUser;
        private System.Windows.Forms.Label LblBibliotecaName;
        private System.Windows.Forms.Label LblUserName;
        private System.Windows.Forms.LinkLabel LblInicio;
        private System.Windows.Forms.Label LblProfesores;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Nuevo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TxtBuscatLibro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DgvLibro;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TxtUbicacion;
        private System.Windows.Forms.TextBox TxtAutores;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtTitulo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtISBN;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnRegresar;
        private System.Windows.Forms.TextBox txtNombreBuscar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView DgvProfesor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtApellido1;
        private System.Windows.Forms.TextBox TxtNombre1;
        private System.Windows.Forms.Label LblNombre1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lbltitulos;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lbltiempo;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lbl_fechadevolucion;
        private System.Windows.Forms.Label lbl_fechainicio;
        private System.Windows.Forms.Label lblnombres;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtprestamo;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.DataGridView Dgvactivos;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblapellidos;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label lblestado;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label LblApellido;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DtpDevolucion;
        private System.Windows.Forms.TextBox txtidprofesor;
        private System.Windows.Forms.TextBox txtidlibro;
        private System.Windows.Forms.Button btnCancelar;
    }
}