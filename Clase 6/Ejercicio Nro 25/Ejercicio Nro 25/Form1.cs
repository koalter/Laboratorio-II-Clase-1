using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ejercicio_Nro_13;

namespace Ejercicio_Nro_25
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBinToDec_Click(object sender, EventArgs e)
        {
            double auxiliar;
            if (Double.TryParse(txtBinario.Text, out auxiliar) && !(txtBinario.Text.Contains("2") ||
                txtBinario.Text.Contains("3") || txtBinario.Text.Contains("4") || txtBinario.Text.Contains("5") ||
                txtBinario.Text.Contains("6") || txtBinario.Text.Contains("7") || txtBinario.Text.Contains("8") ||
                txtBinario.Text.Contains("9")))
            {
                txtResultadoDec.Text = Conversor.BinarioDecimal(txtBinario.Text).ToString();
            }
            else
            {
                MessageBox.Show("Ha ingresado un dato incorrecto!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDecToBin_Click(object sender, EventArgs e)
        {
            double auxiliar;
            string strNumero = txtDecimal.Text.Replace('.', ',');
            if (Double.TryParse(strNumero, out auxiliar))
            {
                txtResultadoBin.Text = Conversor.DecimalBinario(auxiliar);
            }
            else
            {
                MessageBox.Show("Ha ingresado un dato incorrecto!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
