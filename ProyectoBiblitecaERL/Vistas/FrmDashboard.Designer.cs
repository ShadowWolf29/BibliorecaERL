
namespace ProyectoBiblitecaERL.Vistas
{
    partial class FrmDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDashboard));
            this.LblInicio = new System.Windows.Forms.Label();
            this.LblUserName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ImgUser = new System.Windows.Forms.PictureBox();
            this.LblBibliotecaName = new System.Windows.Forms.Label();
            this.BtnLibros = new System.Windows.Forms.Button();
            this.BtnVideos = new System.Windows.Forms.Button();
            this.BtnPrestamos = new System.Windows.Forms.Button();
            this.BtnProfesores = new System.Windows.Forms.Button();
            this.BtnDevoluciones = new System.Windows.Forms.Button();
            this.BtnReportes = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgUser)).BeginInit();
            this.SuspendLayout();
            // 
            // LblInicio
            // 
            this.LblInicio.AutoSize = true;
            this.LblInicio.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblInicio.ForeColor = System.Drawing.Color.White;
            this.LblInicio.Location = new System.Drawing.Point(44, 56);
            this.LblInicio.Name = "LblInicio";
            this.LblInicio.Size = new System.Drawing.Size(81, 37);
            this.LblInicio.TabIndex = 1;
            this.LblInicio.Text = "Inicio";
            this.LblInicio.Click += new System.EventHandler(this.label1_Click);
            // 
            // LblUserName
            // 
            this.LblUserName.AutoSize = true;
            this.LblUserName.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblUserName.ForeColor = System.Drawing.Color.White;
            this.LblUserName.Location = new System.Drawing.Point(538, 10);
            this.LblUserName.Name = "LblUserName";
            this.LblUserName.Size = new System.Drawing.Size(202, 32);
            this.LblUserName.TabIndex = 2;
            this.LblUserName.Text = "Carlos Quintanilla";
            this.LblUserName.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.ImgUser);
            this.panel1.Controls.Add(this.LblBibliotecaName);
            this.panel1.Controls.Add(this.LblUserName);
            this.panel1.Location = new System.Drawing.Point(1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(810, 54);
            this.panel1.TabIndex = 3;
            // 
            // ImgUser
            // 
            this.ImgUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ImgUser.Image = ((System.Drawing.Image)(resources.GetObject("ImgUser.Image")));
            this.ImgUser.Location = new System.Drawing.Point(746, 0);
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
            this.LblBibliotecaName.Click += new System.EventHandler(this.LblBibliotecaName_Click);
            // 
            // BtnLibros
            // 
            this.BtnLibros.BackColor = System.Drawing.Color.Teal;
            this.BtnLibros.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnLibros.ForeColor = System.Drawing.Color.White;
            this.BtnLibros.Location = new System.Drawing.Point(159, 134);
            this.BtnLibros.Name = "BtnLibros";
            this.BtnLibros.Size = new System.Drawing.Size(174, 76);
            this.BtnLibros.TabIndex = 4;
            this.BtnLibros.Text = "LIBROS";
            this.BtnLibros.UseVisualStyleBackColor = false;
            this.BtnLibros.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnVideos
            // 
            this.BtnVideos.BackColor = System.Drawing.Color.Teal;
            this.BtnVideos.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnVideos.ForeColor = System.Drawing.Color.White;
            this.BtnVideos.Location = new System.Drawing.Point(159, 248);
            this.BtnVideos.Name = "BtnVideos";
            this.BtnVideos.Size = new System.Drawing.Size(174, 76);
            this.BtnVideos.TabIndex = 5;
            this.BtnVideos.Text = "VIDEOS";
            this.BtnVideos.UseVisualStyleBackColor = false;
            // 
            // BtnPrestamos
            // 
            this.BtnPrestamos.BackColor = System.Drawing.Color.Teal;
            this.BtnPrestamos.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnPrestamos.ForeColor = System.Drawing.Color.White;
            this.BtnPrestamos.Location = new System.Drawing.Point(496, 134);
            this.BtnPrestamos.Name = "BtnPrestamos";
            this.BtnPrestamos.Size = new System.Drawing.Size(174, 76);
            this.BtnPrestamos.TabIndex = 6;
            this.BtnPrestamos.Text = "PRESTAMOS";
            this.BtnPrestamos.UseVisualStyleBackColor = false;
            this.BtnPrestamos.Click += new System.EventHandler(this.BtnPrestamos_Click);
            // 
            // BtnProfesores
            // 
            this.BtnProfesores.BackColor = System.Drawing.Color.Teal;
            this.BtnProfesores.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnProfesores.ForeColor = System.Drawing.Color.White;
            this.BtnProfesores.Location = new System.Drawing.Point(159, 365);
            this.BtnProfesores.Name = "BtnProfesores";
            this.BtnProfesores.Size = new System.Drawing.Size(174, 76);
            this.BtnProfesores.TabIndex = 9;
            this.BtnProfesores.Text = "PROFESORES";
            this.BtnProfesores.UseVisualStyleBackColor = false;
            this.BtnProfesores.Click += new System.EventHandler(this.BtnProfesores_Click);
            // 
            // BtnDevoluciones
            // 
            this.BtnDevoluciones.BackColor = System.Drawing.Color.Teal;
            this.BtnDevoluciones.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnDevoluciones.ForeColor = System.Drawing.Color.White;
            this.BtnDevoluciones.Location = new System.Drawing.Point(496, 248);
            this.BtnDevoluciones.Name = "BtnDevoluciones";
            this.BtnDevoluciones.Size = new System.Drawing.Size(174, 76);
            this.BtnDevoluciones.TabIndex = 8;
            this.BtnDevoluciones.Text = "DEVOLUCIONES";
            this.BtnDevoluciones.UseVisualStyleBackColor = false;
            this.BtnDevoluciones.Click += new System.EventHandler(this.BtnDevoluciones_Click);
            // 
            // BtnReportes
            // 
            this.BtnReportes.BackColor = System.Drawing.Color.Teal;
            this.BtnReportes.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnReportes.ForeColor = System.Drawing.Color.White;
            this.BtnReportes.Location = new System.Drawing.Point(496, 365);
            this.BtnReportes.Name = "BtnReportes";
            this.BtnReportes.Size = new System.Drawing.Size(174, 76);
            this.BtnReportes.TabIndex = 7;
            this.BtnReportes.Text = "REPORTES";
            this.BtnReportes.UseVisualStyleBackColor = false;
            this.BtnReportes.Click += new System.EventHandler(this.BtnReportes_Click);
            // 
            // FrmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SaddleBrown;
            this.ClientSize = new System.Drawing.Size(806, 511);
            this.Controls.Add(this.BtnProfesores);
            this.Controls.Add(this.BtnDevoluciones);
            this.Controls.Add(this.BtnReportes);
            this.Controls.Add(this.BtnPrestamos);
            this.Controls.Add(this.BtnVideos);
            this.Controls.Add(this.BtnLibros);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LblInicio);
            this.Name = "FrmDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LblInicio;
        private System.Windows.Forms.Label LblUserName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox ImgUser;
        private System.Windows.Forms.Label LblBibliotecaName;
        private System.Windows.Forms.Button BtnLibros;
        private System.Windows.Forms.Button BtnVideos;
        private System.Windows.Forms.Button BtnPrestamos;
        private System.Windows.Forms.Button BtnProfesores;
        private System.Windows.Forms.Button BtnDevoluciones;
        private System.Windows.Forms.Button BtnReportes;
    }
}