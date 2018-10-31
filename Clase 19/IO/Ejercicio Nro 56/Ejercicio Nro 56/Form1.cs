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
using IO;

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

        PuntoTxt txt = new PuntoTxt();
        PuntoDat dat = new PuntoDat();

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ofd.Filter = "Archivos de texto (*.txt)|*.txt|Archivos de datos (*.dat)|*.dat";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                switch (ofd.FilterIndex)
                {
                    case 0:
                        
                        rtbTexto.Text = txt.Leer(ofd.FileName);
                        break;
                    case 1:
                        dat = dat.Leer(ofd.FileName);
                        rtbTexto.Text = dat.Contenido;
                        break;
                }
                guardarToolStripMenuItem.Enabled = true;
            }

        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switch (sfd.FilterIndex)
            {
                case 0:
                    txt.Guardar(sfd.FileName, rtbTexto.Text);
                    break;
                case 1:
                    dat.Contenido = rtbTexto.Text;
                    dat.Guardar(sfd.FileName, dat);
                    break;
            }
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sfd.Filter = "Archivos de texto (*.txt)|*.txt|Archivo DAT (*.dat)|*.dat";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                guardarToolStripMenuItem.Enabled = true;
                guardarToolStripMenuItem_Click(sender, e);
            }
        }
    }
}
