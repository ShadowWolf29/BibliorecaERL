﻿
namespace ProyectoBiblitecaERL.Vistas
{
    partial class FrmDevoluciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDevoluciones));
            this.LbllInicio = new System.Windows.Forms.LinkLabel();
            this.LblLibros = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ImgUser = new System.Windows.Forms.PictureBox();
            this.LblBibliotecaName = new System.Windows.Forms.Label();
            this.LblUserName = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LblFin = new System.Windows.Forms.Label();
            this.LblFechaIni = new System.Windows.Forms.Label();
            this.LblTiempoTotal = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.BtnRegresar = new System.Windows.Forms.Button();
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
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgUser)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LbllInicio
            // 
            this.LbllInicio.ActiveLinkColor = System.Drawing.Color.Silver;
            this.LbllInicio.AutoSize = true;
            this.LbllInicio.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbllInicio.LinkColor = System.Drawing.Color.White;
            this.LbllInicio.Location = new System.Drawing.Point(29, 66);
            this.LbllInicio.Name = "LbllInicio";
            this.LbllInicio.Size = new System.Drawing.Size(71, 32);
            this.LbllInicio.TabIndex = 45;
            this.LbllInicio.TabStop = true;
            this.LbllInicio.Text = "Inicio";
            this.LbllInicio.VisitedLinkColor = System.Drawing.Color.White;
            this.LbllInicio.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LbllInicio_LinkClicked);
            // 
            // LblLibros
            // 
            this.LblLibros.AutoSize = true;
            this.LblLibros.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblLibros.ForeColor = System.Drawing.Color.White;
            this.LblLibros.Location = new System.Drawing.Point(99, 66);
            this.LblLibros.Name = "LblLibros";
            this.LblLibros.Size = new System.Drawing.Size(181, 32);
            this.LblLibros.TabIndex = 44;
            this.LblLibros.Text = "> Devoluciones";
            this.LblLibros.Click += new System.EventHandler(this.LblLibros_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.ImgUser);
            this.panel1.Controls.Add(this.LblBibliotecaName);
            this.panel1.Controls.Add(this.LblUserName);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1089, 54);
            this.panel1.TabIndex = 43;
            // 
            // ImgUser
            // 
            this.ImgUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ImgUser.Image = ((System.Drawing.Image)(resources.GetObject("ImgUser.Image")));
            this.ImgUser.Location = new System.Drawing.Point(839, 2);
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
            this.LblUserName.Location = new System.Drawing.Point(631, 12);
            this.LblUserName.Name = "LblUserName";
            this.LblUserName.Size = new System.Drawing.Size(202, 32);
            this.LblUserName.TabIndex = 2;
            this.LblUserName.Text = "Carlos Quintanilla";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(757, 564);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 56);
            this.button1.TabIndex = 78;
            this.button1.Text = "Devolver";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.LblFin);
            this.groupBox3.Controls.Add(this.LblFechaIni);
            this.groupBox3.Controls.Add(this.LblTiempoTotal);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(595, 127);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(293, 431);
            this.groupBox3.TabIndex = 69;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos del Prestamo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(25, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 25);
            this.label2.TabIndex = 25;
            this.label2.Text = "1515156516516";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(25, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 30);
            this.label1.TabIndex = 24;
            this.label1.Text = "Estado del prestamo:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(25, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 25);
            this.label4.TabIndex = 23;
            this.label4.Text = "2 semanas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(25, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(214, 30);
            this.label5.TabIndex = 22;
            this.label5.Text = "Tiempo del prestamo:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // LblFin
            // 
            this.LblFin.AutoSize = true;
            this.LblFin.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblFin.ForeColor = System.Drawing.Color.White;
            this.LblFin.Location = new System.Drawing.Point(25, 355);
            this.LblFin.Name = "LblFin";
            this.LblFin.Size = new System.Drawing.Size(86, 25);
            this.LblFin.TabIndex = 19;
            this.LblFin.Text = "22/02/22";
            // 
            // LblFechaIni
            // 
            this.LblFechaIni.AutoSize = true;
            this.LblFechaIni.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblFechaIni.ForeColor = System.Drawing.Color.White;
            this.LblFechaIni.Location = new System.Drawing.Point(25, 280);
            this.LblFechaIni.Name = "LblFechaIni";
            this.LblFechaIni.Size = new System.Drawing.Size(86, 25);
            this.LblFechaIni.TabIndex = 18;
            this.LblFechaIni.Text = "16/02/22";
            // 
            // LblTiempoTotal
            // 
            this.LblTiempoTotal.AutoSize = true;
            this.LblTiempoTotal.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblTiempoTotal.ForeColor = System.Drawing.Color.White;
            this.LblTiempoTotal.Location = new System.Drawing.Point(25, 205);
            this.LblTiempoTotal.Name = "LblTiempoTotal";
            this.LblTiempoTotal.Size = new System.Drawing.Size(100, 25);
            this.LblTiempoTotal.TabIndex = 17;
            this.LblTiempoTotal.Text = "2 semanas";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(25, 325);
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
            this.label7.Location = new System.Drawing.Point(25, 250);
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
            this.label9.Location = new System.Drawing.Point(25, 110);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 30);
            this.label9.TabIndex = 12;
            this.label9.Text = "ISBN:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // BtnRegresar
            // 
            this.BtnRegresar.BackColor = System.Drawing.SystemColors.Control;
            this.BtnRegresar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnRegresar.ForeColor = System.Drawing.Color.Black;
            this.BtnRegresar.Location = new System.Drawing.Point(29, 727);
            this.BtnRegresar.Name = "BtnRegresar";
            this.BtnRegresar.Size = new System.Drawing.Size(170, 30);
            this.BtnRegresar.TabIndex = 73;
            this.BtnRegresar.Text = "Regresar";
            this.BtnRegresar.UseVisualStyleBackColor = false;
            // 
            // txtNombreBuscar
            // 
            this.txtNombreBuscar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNombreBuscar.Location = new System.Drawing.Point(314, 176);
            this.txtNombreBuscar.Name = "txtNombreBuscar";
            this.txtNombreBuscar.Size = new System.Drawing.Size(275, 33);
            this.txtNombreBuscar.TabIndex = 72;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(314, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 30);
            this.label3.TabIndex = 71;
            this.label3.Text = "Nombre:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(314, 229);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(275, 329);
            this.dataGridView2.TabIndex = 70;
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
            this.groupBox1.Location = new System.Drawing.Point(29, 127);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(279, 431);
            this.groupBox1.TabIndex = 68;
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
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(29, 590);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 30);
            this.button2.TabIndex = 79;
            this.button2.Text = "Regresar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FrmDevoluciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SaddleBrown;
            this.ClientSize = new System.Drawing.Size(902, 634);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.BtnRegresar);
            this.Controls.Add(this.txtNombreBuscar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LbllInicio);
            this.Controls.Add(this.LblLibros);
            this.Controls.Add(this.panel1);
            this.Name = "FrmDevoluciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Devoluciones";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgUser)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel LbllInicio;
        private System.Windows.Forms.Label LblLibros;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox ImgUser;
        private System.Windows.Forms.Label LblBibliotecaName;
        private System.Windows.Forms.Label LblUserName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label LblFin;
        private System.Windows.Forms.Label LblFechaIni;
        private System.Windows.Forms.Label LblTiempoTotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button BtnRegresar;
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}