using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Temperatura;

namespace Conversor_Temperatura
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvertFahrenheit_Click(object sender, EventArgs e)
        {
            double auxiliar;
            if (double.TryParse(txtFahrenheit.Text, out auxiliar) == true)
            {
                Fahrenheit F = auxiliar;
                Celsius C = (Celsius)F;
                Kelvin K = (Kelvin)F;

                txtFahrenheitAFahrenheit.Text = F.GetTemperatura().ToString();
                txtFahrenheitACelsius.Text = C.GetTemperatura().ToString();
                txtFahrenheitAKelvin.Text = K.GetTemperatura().ToString();
            }
        }

        private void btnConvertCelsius_Click(object sender, EventArgs e)
        {
            double auxiliar;
            if (double.TryParse(txtCelsius.Text, out auxiliar) == true)
            {
                Celsius C = auxiliar;
                Kelvin K = (Kelvin)C;
                Fahrenheit F = (Fahrenheit)C;

                txtCelsiusAFahrenheit.Text = F.GetTemperatura().ToString();
                txtCelsiusACelsius.Text = C.GetTemperatura().ToString();
                txtCelsiusAKelvin.Text = K.GetTemperatura().ToString();
            }
        }

        private void btnConvertKelvin_Click(object sender, EventArgs e)
        {
            double auxiliar;
            if (double.TryParse(txtKelvin.Text, out auxiliar) == true)
            {
                Kelvin K = auxiliar;
                Celsius C = (Celsius)K;
                Fahrenheit F = (Fahrenheit)K;

                txtKelvinAFahrenheit.Text = F.GetTemperatura().ToString();
                txtKelvinACelsius.Text = C.GetTemperatura().ToString();
                txtKelvinAKelvin.Text = K.GetTemperatura().ToString();
            }
        }
    }
}
