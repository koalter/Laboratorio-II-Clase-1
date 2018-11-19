using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioNro69
{
    public partial class FrmPrincipal : Form
    {
        FrmTestDelegados frmTestDelegados;
        FrmMostrar frmMostrar;

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void testDelegadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTestDelegados = new FrmTestDelegados();
            frmTestDelegados.MdiParent = this;
            frmTestDelegados.Show();
            mostrarToolStripMenuItem.Enabled = true;
        }

        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMostrar = new FrmMostrar();
            frmMostrar.MdiParent = this;
            frmMostrar.Show();

            frmTestDelegados.EventoString += frmMostrar.ActualizarNombre;
            frmTestDelegados.EventoFoto += frmMostrar.ActualizarFoto;
        }
    }
}
