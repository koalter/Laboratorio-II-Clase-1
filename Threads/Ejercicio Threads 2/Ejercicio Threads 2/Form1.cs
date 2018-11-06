using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Ejercicio_Threads_2
{
    public partial class Form1 : Form
    {
        Thread tReloj;
        Thread tImagen;

        public Form1()
        {
            InitializeComponent();
        }

        void IniciarReloj()
        {
            int reloj = 100;
            while (reloj != 0)
            {
                reloj--;
                Thread.Sleep(1000);
                Mostrar(reloj);
            }

            if (reloj == 0)
            {
                MessageBox.Show("Has perdido!");
                tImagen.Abort();
                //new Form2();
            }
        }

        void Mostrar(object o)
        {
            if (this.labelReloj.InvokeRequired)
            {
                this.labelReloj.BeginInvoke((MethodInvoker)delegate ()
                {
                    this.labelReloj.Text = o.ToString();
                }
                );
            }
            else
            {
                this.labelReloj.Text = o.ToString();
            }

        }

        void CambiarPosicion()
        {
            Random rand = new Random();
            int x;
            int y;
            while (true)
            {
                x = rand.Next(609);
                y = rand.Next(277);
                Thread.Sleep(500);
                if (this.pb.InvokeRequired)
                {
                    this.pb.BeginInvoke((MethodInvoker)delegate ()
                    {
                        this.pb.Location = new Point(x, y);
                    }
                    );
                }
                else
                {
                    this.pb.Location = new Point(x, y);
                }
            }
        }

        private void btnComenzar_Click(object sender, EventArgs e)
        {
            btnComenzar.Visible = false;
            labelReloj.Visible = true;
            pb.Visible = true;
            tReloj.Start();
            tImagen.Start();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (tReloj.IsAlive)
            {
                tReloj.Abort();
            }
            if (tImagen.IsAlive)
            {
                tImagen.Abort();
            }
        }

        private void pb_Click(object sender, EventArgs e)
        {
            tReloj.Abort();
            tImagen.Abort();
            MessageBox.Show("Has ganado!");
            //new Form2();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tReloj = new Thread(IniciarReloj);
            tImagen = new Thread(CambiarPosicion);
        }
    }
}
