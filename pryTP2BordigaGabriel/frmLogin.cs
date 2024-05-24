using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryTP2BordigaGabriel
{
    public partial class frmLogin : Form
    {
        private clsUsuario usuario;
        public frmLogin()
        {
            InitializeComponent();
            usuario = new clsUsuario();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string nombreUsuario = txtUsuario.Text;
            string contraseña = txtPassword.Text;

            if (usuario.ValidarUsuario(nombreUsuario, contraseña))
            {
                MessageBox.Show("Inicio de sesión exitoso", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Aquí puedes abrir el formulario principal o realizar otras acciones después del inicio de sesión exitoso
            }
            else
            {
                MessageBox.Show("Nombre de usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
