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
    public partial class FormCargar : Form
    {
        public FormCargar()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Es el metodo que va a capturar el evento de FormLlenar
        /// </summary>
        /// <param name="texto"></param>
        public void CargarTexto(string texto)
        {
            txtCargar.Text += texto;
        }
    }
}
