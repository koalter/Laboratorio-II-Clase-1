using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace EjercicioNro69
{
    public partial class FrmAltaAlumno : Form
    {
        public FrmAltaAlumno()
        {
            InitializeComponent();
        }

        private void lblFoto_DoubleClick(object sender, EventArgs e)
        {
            ofdFoto.ShowDialog();
            txtFoto.Text = ofdFoto.FileName;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
