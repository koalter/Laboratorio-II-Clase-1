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

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                StreamReader file = new StreamReader(ofd.FileName);
                sfd.FileName = ofd.FileName;
                rtbTexto.Text = file.ReadToEnd();
                file.Close();
            }

        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sfd.FileName != "")
            {
                StreamWriter file = new StreamWriter(sfd.FileName);
                file.Write(rtbTexto.Text);
                file.Close();
            }
            else
            {
                guardarComoToolStripMenuItem_Click(sender, e);
            }
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                StreamWriter file = new StreamWriter(sfd.FileName);
                file.Write(rtbTexto.Text);
                file.Close();
            }
        }
    }
}
