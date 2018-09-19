using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conversor_Dinero
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvertEuro_Click(object sender, EventArgs e)
        {
            txtEuroAEuro.Text = ;
            txtEuroADolar.Text = ;
            txtEuroAPesos.Text = ;
        }

        private void btnConvertDolar_Click(object sender, EventArgs e)
        {
            txtDolarAEuro.Text = ;
            txtDolarADolar.Text = ;
            txtDolarAPesos.Text = ;
        }

        private void btnConvertPesos_Click(object sender, EventArgs e)
        {
            
            txtPesosAEuro.Text = ;
            txtPesosADolar.Text = ;
            txtPesosAPesos.Text = ;
        }
    }
}
