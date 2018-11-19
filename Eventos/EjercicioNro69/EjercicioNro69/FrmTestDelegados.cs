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

        public FrmTestDelegados()
        {
            InitializeComponent();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            EventoString(txtDatos.Text);
        }
    }
}
