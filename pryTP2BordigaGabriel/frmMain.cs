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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void cmdVerLogs_Click(object sender, EventArgs e)
        {
            frmRegistrarLogs frmRegistrarLogs = new frmRegistrarLogs();
            frmRegistrarLogs.Show();
        }

        private void cmdCrearUsuarios_Click(object sender, EventArgs e)
        {
            frmCrearUsuarios frmCrearUsuarios = new frmCrearUsuarios();
            frmCrearUsuarios.Show();
        }

        private void cmdPantallaDeReporte_Click(object sender, EventArgs e)
        {
            frmPantallaDeReportes Pantalla = new frmPantallaDeReportes();
            Pantalla.Show();
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
