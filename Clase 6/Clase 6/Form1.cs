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
    public partial class FrmPantalla1 : Form
    {
        public FrmPantalla1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Hola prro", "titulo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                this.btnSalir.Text = "Si";
            }
            else
            {
                this.btnSalir.Text = "No";
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

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            FrmOwner frmOwner = new FrmOwner();
            FrmPantalla2 frmPantalla2 = new FrmPantalla2();
            FrmPantalla2 frmPantalla3 = new FrmPantalla2();
            FrmPantalla2 frmPantalla4 = new FrmPantalla2();
            frmOwner.Show();
            frmPantalla4.MdiParent = this;
            frmPantalla4.Show();
            frmPantalla2.Show(frmOwner);
            frmPantalla3.Show();
            this.btnMostrar.Text = frmPantalla2.atributoString;
            frmPantalla2.Owner.Text = "";

        }

        private void btnCascada_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void btnVertical_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void btnHorizontal_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void btnArrange_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.ArrangeIcons);
        }
    }
}
