using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioExtension
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            DateTime fechaNac;
            int dni;

            if (txtNombre.Text != String.Empty &&
                txtApellido.Text != String.Empty &&
                txtDireccion.Text != String.Empty &&
                DateTime.TryParse(txtFecha.Text, out fechaNac) &&
                int.TryParse(txtDni.Text, out dni)
                )
            {
                ((Form1)this.Owner).Listado.Items.Add(
                    new Alumno(txtNombre.Text, txtApellido.Text, fechaNac, dni, txtDireccion.Text).ToString());
                DialogResult = DialogResult.OK;
            }
            else
            {
                DialogResult = DialogResult.Abort;
            }
        }
    }
}
