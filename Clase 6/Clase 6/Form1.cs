using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Hola prro", "titulo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                this.button1.Text = "Si";
            }
            else
            {
                this.button1.Text = "No";
            }
        }

        // Esta acción se ejecuta cuando el formulario se carga
        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Form1_Load", "Form1");
        }

        // Esta acción se ejecuta cuando se quiere cerrar el formulario
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Está seguro?", "Guardar", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
