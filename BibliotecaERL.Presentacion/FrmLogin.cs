using BibliotecaERL.Negocio;
using ProyectoBiblitecaERL.Vistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBiblitecaERL
{
    public partial class FrmLogin : Form
    {

        public static class Global
        {
            public static int id_empleado;
            public static string nombre;
            public static string rol;
            public static int id_rol;

        }
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable Tabla = new DataTable();
                Tabla = NUsuario.Login(TxtEmail.Text.Trim(), TxtPassword.Text.Trim());
                if(Tabla.Rows.Count <= 0)
                {
                    MessageBox.Show("El correo o clave son incorrectos.", "Acceso Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    FrmDashboard Frm = new FrmDashboard();
                    Global.id_empleado = Convert.ToInt32(Tabla.Rows[0][0]);
                    Global.id_rol = Convert.ToInt32(Tabla.Rows[0][1]); 
                    Global.rol = Convert.ToString(Tabla.Rows[0][2]);
                    Global.nombre = Convert.ToString(Tabla.Rows[0][3]);
                    Frm.Show();
                    this.Hide();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
