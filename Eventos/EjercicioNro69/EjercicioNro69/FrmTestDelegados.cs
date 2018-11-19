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
    public partial class FrmTestDelegados : Form
    {
        public event DelegadoString EventoString;
        public event DelegadoString EventoFoto;
        string _rutaArchivo;

        public FrmTestDelegados()
        {
            InitializeComponent();
            openFileDialog1.InitialDirectory = "My Pictures";
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            EventoString(txtDatos.Text);
            EventoFoto(_rutaArchivo);
        }

        private void btnBuscarFoto_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            _rutaArchivo = openFileDialog1.FileName;
        }
    }
}
