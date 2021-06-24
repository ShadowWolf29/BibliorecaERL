
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
            this.BtnRegresar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ImgUser = new System.Windows.Forms.PictureBox();
            this.LblBibliotecaName = new System.Windows.Forms.Label();
            this.LblUserName = new System.Windows.Forms.Label();
            this.LblInicio = new System.Windows.Forms.LinkLabel();
            this.LblProfesores = new System.Windows.Forms.Label();
            this.txtNombreBuscar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtApellido2 = new System.Windows.Forms.TextBox();
            this.LblApellido2 = new System.Windows.Forms.Label();
            this.TxtApellido1 = new System.Windows.Forms.TextBox();
            this.LblApellido = new System.Windows.Forms.Label();
            this.TxtNombre1 = new System.Windows.Forms.TextBox();
            this.LblNombre1 = new System.Windows.Forms.Label();
            this.TxtNombre2 = new System.Windows.Forms.TextBox();
            this.LblNombre2 = new System.Windows.Forms.Label();
            this.TxtBuscatLibro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TxtUbicacion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtAutores = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtTitulo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtISBN = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.LblFin = new System.Windows.Forms.Label();
            this.LblFechaIni = new System.Windows.Forms.Label();
            this.LblTiempoTotal = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnRegresar
            // 
            this.BtnRegresar.BackColor = System.Drawing.SystemColors.Control;
            this.BtnRegresar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnRegresar.ForeColor = System.Drawing.Color.Black;
            this.BtnRegresar.Location = new System.Drawing.Point(24, 719);
            this.BtnRegresar.Name = "BtnRegresar";
            this.BtnRegresar.Size = new System.Drawing.Size(170, 30);
            this.BtnRegresar.TabIndex = 62;
            this.BtnRegresar.Text = "Regresar";
            this.BtnRegresar.UseVisualStyleBackColor = false;
            this.BtnRegresar.Click += new System.EventHandler(this.BtnRegresar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.ImgUser);
            this.panel1.Controls.Add(this.LblBibliotecaName);
            this.panel1.Controls.Add(this.LblUserName);
            this.panel1.Location = new System.Drawing.Point(1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1184, 54);
            this.panel1.TabIndex = 61;
            // 
            // ImgUser
            // 
            this.ImgUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ImgUser.Image = ((System.Drawing.Image)(resources.GetObject("ImgUser.Image")));
            this.ImgUser.Location = new System.Drawing.Point(1121, 4);
            this.ImgUser.Name = "ImgUser";
            this.ImgUser.Size = new System.Drawing.Size(50, 50);
            this.ImgUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImgUser.TabIndex = 4;
            this.ImgUser.TabStop = false;
            // 
            // LblBibliotecaName
            // 
            this.LblBibliotecaName.AutoSize = true;
            this.LblBibliotecaName.BackColor = System.Drawing.Color.Teal;
            this.LblBibliotecaName.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblBibliotecaName.ForeColor = System.Drawing.Color.White;
            this.LblBibliotecaName.Location = new System.Drawing.Point(11, 6);
            this.LblBibliotecaName.Name = "LblBibliotecaName";
            this.LblBibliotecaName.Size = new System.Drawing.Size(192, 40);
            this.LblBibliotecaName.TabIndex = 3;
            this.LblBibliotecaName.Text = "Biclioteca ERL";
            // 
            // LblUserName
            // 
            this.LblUserName.AutoSize = true;
            this.LblUserName.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblUserName.ForeColor = System.Drawing.Color.White;
            this.LblUserName.Location = new System.Drawing.Point(913, 12);
            this.LblUserName.Name = "LblUserName";
            this.LblUserName.Size = new System.Drawing.Size(202, 32);
            this.LblUserName.TabIndex = 2;
            this.LblUserName.Text = "Carlos Quintanilla";
            // 
            // LblInicio
            // 
            this.LblInicio.ActiveLinkColor = System.Drawing.Color.Silver;
            this.LblInicio.AutoSize = true;
            this.LblInicio.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblInicio.LinkColor = System.Drawing.Color.White;
            this.LblInicio.Location = new System.Drawing.Point(41, 66);
            this.LblInicio.Name = "LblInicio";
            this.LblInicio.Size = new System.Drawing.Size(71, 32);
            this.LblInicio.TabIndex = 60;
            this.LblInicio.TabStop = true;
            this.LblInicio.Text = "Inicio";
            this.LblInicio.VisitedLinkColor = System.Drawing.Color.White;
            this.LblInicio.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LblInicio_LinkClicked);
            // 
            // LblProfesores
            // 
            this.LblProfesores.AutoSize = true;
            this.LblProfesores.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblProfesores.ForeColor = System.Drawing.Color.White;
            this.LblProfesores.Location = new System.Drawing.Point(108, 66);
            this.LblProfesores.Name = "LblProfesores";
            this.LblProfesores.Size = new System.Drawing.Size(146, 32);
            this.LblProfesores.TabIndex = 59;
            this.LblProfesores.Text = "> Prestamos";
            this.LblProfesores.Click += new System.EventHandler(this.LblProfesores_Click);
            // 
            // txtNombreBuscar
            // 
            this.txtNombreBuscar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNombreBuscar.Location = new System.Drawing.Point(309, 168);
            this.txtNombreBuscar.Name = "txtNombreBuscar";
            this.txtNombreBuscar.Size = new System.Drawing.Size(275, 33);
            this.txtNombreBuscar.TabIndex = 57;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(309, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 30);
            this.label3.TabIndex = 56;
            this.label3.Text = "Nombre:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(309, 221);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(275, 329);
            this.dataGridView2.TabIndex = 55;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtApellido2);
            this.groupBox1.Controls.Add(this.LblApellido2);
            this.groupBox1.Controls.Add(this.TxtApellido1);
            this.groupBox1.Controls.Add(this.LblApellido);
            this.groupBox1.Controls.Add(this.TxtNombre1);
            this.groupBox1.Controls.Add(this.LblNombre1);
            this.groupBox1.Controls.Add(this.TxtNombre2);
            this.groupBox1.Controls.Add(this.LblNombre2);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(24, 119);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(279, 431);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del profesor";
            // 
            // TxtApellido2
            // 
            this.TxtApellido2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtApellido2.Location = new System.Drawing.Point(17, 337);
            this.TxtApellido2.Name = "TxtApellido2";
            this.TxtApellido2.Size = new System.Drawing.Size(234, 33);
            this.TxtApellido2.TabIndex = 21;
            // 
            // LblApellido2
            // 
            this.LblApellido2.AutoSize = true;
            this.LblApellido2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblApellido2.ForeColor = System.Drawing.Color.White;
            this.LblApellido2.Location = new System.Drawing.Point(18, 302);
            this.LblApellido2.Name = "LblApellido2";
            this.LblApellido2.Size = new System.Drawing.Size(179, 30);
            this.LblApellido2.TabIndex = 20;
            this.LblApellido2.Text = "Segundo apellido:";
            // 
            // TxtApellido1
            // 
            this.TxtApellido1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtApellido1.Location = new System.Drawing.Point(18, 262);
            this.TxtApellido1.Name = "TxtApellido1";
            this.TxtApellido1.Size = new System.Drawing.Size(233, 33);
            this.TxtApellido1.TabIndex = 17;
            // 
            // LblApellido
            // 
            this.LblApellido.AutoSize = true;
            this.LblApellido.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblApellido.ForeColor = System.Drawing.Color.White;
            this.LblApellido.Location = new System.Drawing.Point(18, 227);
            this.LblApellido.Name = "LblApellido";
            this.LblApellido.Size = new System.Drawing.Size(157, 30);
            this.LblApellido.TabIndex = 16;
            this.LblApellido.Text = "Primer apellido:";
            // 
            // TxtNombre1
            // 
            this.TxtNombre1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtNombre1.Location = new System.Drawing.Point(18, 102);
            this.TxtNombre1.Name = "TxtNombre1";
            this.TxtNombre1.Size = new System.Drawing.Size(233, 33);
            this.TxtNombre1.TabIndex = 13;
            // 
            // LblNombre1
            // 
            this.LblNombre1.AutoSize = true;
            this.LblNombre1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblNombre1.ForeColor = System.Drawing.Color.White;
            this.LblNombre1.Location = new System.Drawing.Point(18, 67);
            this.LblNombre1.Name = "LblNombre1";
            this.LblNombre1.Size = new System.Drawing.Size(156, 30);
            this.LblNombre1.TabIndex = 12;
            this.LblNombre1.Text = "Primer nombre:";
            // 
            // TxtNombre2
            // 
            this.TxtNombre2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtNombre2.Location = new System.Drawing.Point(18, 182);
            this.TxtNombre2.Name = "TxtNombre2";
            this.TxtNombre2.Size = new System.Drawing.Size(233, 33);
            this.TxtNombre2.TabIndex = 11;
            // 
            // LblNombre2
            // 
            this.LblNombre2.AutoSize = true;
            this.LblNombre2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblNombre2.ForeColor = System.Drawing.Color.White;
            this.LblNombre2.Location = new System.Drawing.Point(17, 147);
            this.LblNombre2.Name = "LblNombre2";
            this.LblNombre2.Size = new System.Drawing.Size(178, 30);
            this.LblNombre2.TabIndex = 10;
            this.LblNombre2.Text = "Segundo nombre:";
            // 
            // TxtBuscatLibro
            // 
            this.TxtBuscatLibro.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtBuscatLibro.Location = new System.Drawing.Point(885, 168);
            this.TxtBuscatLibro.Name = "TxtBuscatLibro";
            this.TxtBuscatLibro.Size = new System.Drawing.Size(275, 33);
            this.TxtBuscatLibro.TabIndex = 66;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(885, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 30);
            this.label1.TabIndex = 65;
            this.label1.Text = "Titulo o ISBN:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(885, 221);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(275, 329);
            this.dataGridView1.TabIndex = 64;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TxtUbicacion);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.TxtAutores);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.TxtTitulo);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.TxtISBN);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(600, 119);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(279, 431);
            this.groupBox2.TabIndex = 63;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos del libro";
            // 
            // TxtUbicacion
            // 
            this.TxtUbicacion.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtUbicacion.Location = new System.Drawing.Point(17, 337);
            this.TxtUbicacion.Name = "TxtUbicacion";
            this.TxtUbicacion.Size = new System.Drawing.Size(234, 33);
            this.TxtUbicacion.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(18, 302);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 30);
            this.label2.TabIndex = 20;
            this.label2.Text = "Ubicación:";
            // 
            // TxtAutores
            // 
            this.TxtAutores.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtAutores.Location = new System.Drawing.Point(18, 262);
            this.TxtAutores.Name = "TxtAutores";
            this.TxtAutores.Size = new System.Drawing.Size(233, 33);
            this.TxtAutores.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(18, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 30);
            this.label4.TabIndex = 16;
            this.label4.Text = "Autores:";
            // 
            // TxtTitulo
            // 
            this.TxtTitulo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtTitulo.Location = new System.Drawing.Point(18, 102);
            this.TxtTitulo.Name = "TxtTitulo";
            this.TxtTitulo.Size = new System.Drawing.Size(233, 33);
            this.TxtTitulo.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(18, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 30);
            this.label5.TabIndex = 12;
            this.label5.Text = "Titulo:";
            // 
            // TxtISBN
            // 
            this.TxtISBN.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtISBN.Location = new System.Drawing.Point(18, 182);
            this.TxtISBN.Name = "TxtISBN";
            this.TxtISBN.Size = new System.Drawing.Size(233, 33);
            this.TxtISBN.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(17, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 30);
            this.label6.TabIndex = 10;
            this.label6.Text = "ISBN:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.LblFin);
            this.groupBox3.Controls.Add(this.LblFechaIni);
            this.groupBox3.Controls.Add(this.LblTiempoTotal);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(24, 556);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(855, 147);
            this.groupBox3.TabIndex = 55;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos del Prestamo";
            // 
            // LblFin
            // 
            this.LblFin.AutoSize = true;
            this.LblFin.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblFin.ForeColor = System.Drawing.Color.White;
            this.LblFin.Location = new System.Drawing.Point(594, 84);
            this.LblFin.Name = "LblFin";
            this.LblFin.Size = new System.Drawing.Size(95, 30);
            this.LblFin.TabIndex = 19;
            this.LblFin.Text = "22/02/22";
            // 
            // LblFechaIni
            // 
            this.LblFechaIni.AutoSize = true;
            this.LblFechaIni.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblFechaIni.ForeColor = System.Drawing.Color.White;
            this.LblFechaIni.Location = new System.Drawing.Point(327, 84);
            this.LblFechaIni.Name = "LblFechaIni";
            this.LblFechaIni.Size = new System.Drawing.Size(95, 30);
            this.LblFechaIni.TabIndex = 18;
            this.LblFechaIni.Text = "16/02/22";
            // 
            // LblTiempoTotal
            // 
            this.LblTiempoTotal.AutoSize = true;
            this.LblTiempoTotal.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblTiempoTotal.ForeColor = System.Drawing.Color.White;
            this.LblTiempoTotal.Location = new System.Drawing.Point(32, 84);
            this.LblTiempoTotal.Name = "LblTiempoTotal";
            this.LblTiempoTotal.Size = new System.Drawing.Size(111, 30);
            this.LblTiempoTotal.TabIndex = 17;
            this.LblTiempoTotal.Text = "2 semanas";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(593, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(208, 30);
            this.label8.TabIndex = 16;
            this.label8.Text = "Fecha de devolucion:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(327, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 30);
            this.label7.TabIndex = 14;
            this.label7.Text = "Fecha de inicio:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(32, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(214, 30);
            this.label9.TabIndex = 12;
            this.label9.Text = "Tiempo del prestamo:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(945, 610);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 76);
            this.button1.TabIndex = 67;
            this.button1.Text = "Ingresar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // FrmPrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SaddleBrown;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.TxtBuscatLibro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.BtnRegresar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LblInicio);
            this.Controls.Add(this.LblProfesores);
            this.Controls.Add(this.txtNombreBuscar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmPrestamos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPrestamos";
            this.Load += new System.EventHandler(this.FrmPrestamos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnRegresar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox ImgUser;
        private System.Windows.Forms.Label LblBibliotecaName;
        private System.Windows.Forms.Label LblUserName;
        private System.Windows.Forms.LinkLabel LblInicio;
        private System.Windows.Forms.Label LblProfesores;
        private System.Windows.Forms.TextBox txtNombreBuscar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtApellido2;
        private System.Windows.Forms.Label LblApellido2;
        private System.Windows.Forms.TextBox TxtApellido1;
        private System.Windows.Forms.Label LblApellido;
        private System.Windows.Forms.TextBox TxtNombre1;
        private System.Windows.Forms.Label LblNombre1;
        private System.Windows.Forms.TextBox TxtNombre2;
        private System.Windows.Forms.Label LblNombre2;
        private System.Windows.Forms.TextBox TxtBuscatLibro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TxtUbicacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtAutores;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtTitulo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtISBN;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label LblFin;
        private System.Windows.Forms.Label LblFechaIni;
        private System.Windows.Forms.Label LblTiempoTotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
    }
}