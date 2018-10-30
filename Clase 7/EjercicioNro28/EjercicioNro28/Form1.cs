using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioNro28
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Dictionary<string, int> diccionario = new Dictionary<string, int>();
            rtbTexto.Text.Trim('.', ',');
            string[] palabras = rtbTexto.Text.Split(' ');
            foreach (string palabra in palabras)
            {
                if (diccionario.ContainsKey(palabra) == false)
                {
                    diccionario.Add(palabra, 1);
                }
                else
                {
                    diccionario[palabra]++;
                }
            }

            // Ordeno el diccionario por aparicion de palabras
            diccionario.OrderBy(item => item.Value);

            StringBuilder sb = new StringBuilder();
            int i = 0;
            foreach (var item in diccionario)
            {
                if (i >= 3)
                {
                    break;
                }
                sb.AppendLine("Palabra: " + item.Key + " -- Apariciones: " + item.Value);
                i++;
            }
            
            MessageBox.Show(sb.ToString(), "TOP 3 de palabras con más apariciones");
        }
    }
}
