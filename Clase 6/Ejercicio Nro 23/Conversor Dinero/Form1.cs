using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Moneda;

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
            double auxiliar;
            if (double.TryParse(txtEuro.Text, out auxiliar) == true)
            {
                Euro E = auxiliar;
                Dolar D = (Dolar)E;
                Pesos P = (Pesos)E;

                txtEuroAEuro.Text = E.GetCantidad().ToString();
                txtEuroADolar.Text = D.GetCantidad().ToString();
                txtEuroAPesos.Text = P.GetCantidad().ToString();
            }
        }

        private void btnConvertDolar_Click(object sender, EventArgs e)
        {
            double auxiliar;
            if (double.TryParse(txtDolar.Text, out auxiliar) == true)
            {
                Dolar D = auxiliar;
                Pesos P = (Pesos)D;
                Euro E = (Euro)D;

                txtDolarAEuro.Text = E.GetCantidad().ToString();
                txtDolarADolar.Text = D.GetCantidad().ToString();
                txtDolarAPesos.Text = P.GetCantidad().ToString();
            }
            
        }

        private void btnConvertPesos_Click(object sender, EventArgs e)
        {
            double auxiliar;
            if (double.TryParse(txtPesos.Text, out auxiliar) == true)
            {
                Pesos P = auxiliar;
                Dolar D = (Dolar)P;
                Euro E = (Euro)P;

                txtPesosAEuro.Text = E.GetCantidad().ToString();
                txtPesosADolar.Text = D.GetCantidad().ToString();
                txtPesosAPesos.Text = P.GetCantidad().ToString();
            }
        }
    }
}
