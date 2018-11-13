using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioDelegados
{
    // Declaro al delegado fuera de la clase form
    // Declaro un evento del tipo del delegado dentro del formulario FormLlenar
    public delegate void Mensaje(string texto);

    public partial class Form1 : Form
    {
        FormLlenar formLlenar;
        FormCargar formCargar;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // El boton carga la primera ventana
            if (formCargar == null)
            {
                formLlenar = new FormLlenar();
                // Le añado al delegado una funcion (anonima) que no haga nada para que no rompa
                formLlenar.miEvento += (string a) => { };
                formLlenar.Show(this);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Si la primer ventana no existe, primero la crea
            if (formLlenar == null)
            {
                button1_Click(sender, e);
            }
            // Creo una nueva instancia de la segunda ventana
            formCargar = new FormCargar();
            // Recorro todos los formularios hijos
            foreach (Form formulario in this.OwnedForms)
            {
                if (formulario is FormLlenar)
                {
                    // Por cada uno le (quito primero y) agrego la funcion que escriba en txtCargar
                    ((FormLlenar)formulario).miEvento -= formCargar.CargarTexto;
                    ((FormLlenar)formulario).miEvento += formCargar.CargarTexto;
                }
            }
            formCargar.Show(this);
        }
    }
}
