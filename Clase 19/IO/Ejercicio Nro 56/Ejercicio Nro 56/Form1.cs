using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Ejercicio_Nro_56
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rtbTexto_TextChanged(object sender, EventArgs e)
        {
            lblCaracteres.Text = String.Format("{0} caracteres", rtbTexto.Text.Length.ToString());
        }

        string archivo;

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ofd.Filter = "Archivos de texto (*.txt)|*.txt|Archivos de datos (*.dat)|*.dat";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                StreamReader file = new StreamReader(ofd.FileName);
                rtbTexto.Text = file.ReadToEnd();
                archivo = ofd.FileName;
                ofd.FileName = "";
                file.Close();
                guardarToolStripMenuItem.Enabled = true;
            }

        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamWriter file = new StreamWriter(archivo);
            file.Write(rtbTexto.Text);
            file.Close();
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sfd.Filter = "Archivos de texto (*.txt)|*.txt|Archivo DAT (*.dat)|*.dat";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                StreamWriter file = new StreamWriter(sfd.FileName);
                file.Write(rtbTexto.Text);
                archivo = sfd.FileName;
                sfd.FileName = "";
                file.Close();
                guardarToolStripMenuItem.Enabled = true;
            }
        }
    }
}
