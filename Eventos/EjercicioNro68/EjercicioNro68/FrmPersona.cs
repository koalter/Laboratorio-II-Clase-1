using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioNro68
{
    public partial class FrmPersona : Form
    {
        public event DelegadoString EventoString;
        Persona persona;

        public FrmPersona()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (persona == null)
            {
                persona = new Persona(txtNombre.Text, txtApellido.Text);
                btnCrear.Text = "Actualizar";
                NotificarCambio("Se ha creado a la persona.");
            }
            else
            {
                persona.Nombre = txtNombre.Text;
                persona.Apellido = txtApellido.Text;
                NotificarCambio("Se han actualizado los datos de la persona.");
            }

            MessageBox.Show(persona.Mostrar());
        }

        public static void NotificarCambio(string cambio)
        {
            MessageBox.Show(cambio);
        }

        private void FrmPersona_Load(object sender, EventArgs e)
        {
            this.EventoString += NotificarCambio;
        }
    }
}
