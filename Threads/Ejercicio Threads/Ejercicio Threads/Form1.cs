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

namespace Ejercicio_Threads
{
    public partial class Form1 : Form
    {
        // Declaro las variables para los hilos
        Thread t1;
        Thread t2;
        Thread t3;
        Thread t4;

        public Form1()
        {
            InitializeComponent();
            // Creo las instancias de los hilos
            t2 = new Thread(new ParameterizedThreadStart(Metodo));
            t3 = new Thread(new ParameterizedThreadStart(Metodo));
            t1 = new Thread(new ParameterizedThreadStart(Metodo));
            t4 = new Thread(new ParameterizedThreadStart(Metodo));
        }
        
        // Creo un array de numeros con el numero en que inicializara cada textBox
        int[] numero = { 0, 0, 0, 0 };
        private void Metodo(object o) // o representara al indice de numero
        {
            int pos = (int)o;
            while (numero[pos] < 10000) // mientras el numero sea menor a 10000
            {
                numero[pos]++; // sumara 1
                Thread.Sleep(30); // esperara antes de seguir el procedimiento
                Mostrar(numero[pos], pos); // y llamara a un metodo Mostrar
            }
        }
        
        /// <summary>
        /// Pasará el numero de la iteracion al textBox
        /// </summary>
        /// <param name="num">numero</param>
        /// <param name="pos">indice</param>
        void Mostrar(int num, int pos)
        {
            switch (pos)
            {
                case 0:
                    // CODIGO: es el codigo que figura en el PPT para manejar elementos
                    // de un formulario
                    if (this.textBox1.InvokeRequired)
                    {
                        this.textBox1.BeginInvoke((MethodInvoker)delegate ()
                        {
                            this.textBox1.Text = num.ToString();
                        });
                    }
                    else
                    {
                        this.textBox1.Text = num.ToString();
                    }
                    // ENDCODIGO
                    break;
                case 1:
                    if (this.textBox2.InvokeRequired)
                    {
                        this.textBox2.BeginInvoke((MethodInvoker)delegate ()
                        {
                            this.textBox2.Text = num.ToString();
                        });
                    }
                    else
                    {
                        this.textBox2.Text = num.ToString();
                    }
                    break;
                case 2:
                    if (this.textBox3.InvokeRequired)
                    {
                        this.textBox3.BeginInvoke((MethodInvoker)delegate ()
                        {
                            this.textBox3.Text = num.ToString();
                        });
                    }
                    else
                    {
                        this.textBox3.Text = num.ToString();
                    }
                    break;
                case 3:
                    if (this.textBox4.InvokeRequired)
                    {
                        this.textBox4.BeginInvoke((MethodInvoker)delegate ()
                        {
                            this.textBox4.Text = num.ToString();
                        });
                    }
                    else
                    {
                        this.textBox4.Text = num.ToString();
                    }
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (t1.IsAlive)
            {
                t1.Abort();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (t2.IsAlive)
            {
                t2.Abort();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (t3.IsAlive)
            {
                t3.Abort();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (t4.IsAlive)
            {
                t4.Abort();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            t1.Abort();
            t2.Abort();
            t3.Abort();
            t4.Abort();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            t1.Start(0);
            t2.Start(1);
            t3.Start(2);
            t4.Start(3);
        }
    }
}
