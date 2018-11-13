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
    public partial class FormLlenar : Form
    {
        public event Mensaje miEvento;

        public FormLlenar()
        {
            InitializeComponent();
        }

        private void btnLlenar_Click(object sender, EventArgs e)
        {
            // Al hacer click se dispara el evento
            miEvento(this.txtLlenar.Text);
        }
    }
}
