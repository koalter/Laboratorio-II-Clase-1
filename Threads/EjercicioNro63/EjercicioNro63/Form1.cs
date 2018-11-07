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

namespace EjercicioNro63
{
    public partial class Form1 : Form
    {
        Thread t1;

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            t1 = new Thread(AsignarHora);
            t1.Start();
        }
        
        void AsignarHora()
        {
            while (true)
            {
                if (this.lblHora.InvokeRequired)
                {
                    this.lblHora.BeginInvoke((MethodInvoker)delegate ()
                    {
                        this.lblHora.Text = DateTime.Now.ToString("dd/mm/yyyy hh:mm:ss");
                    }
                    );
                }
                else
                {
                    this.lblHora.Text = DateTime.Now.ToString("dd/mm/yyyy hh:mm:ss");
                }

                Thread.Sleep(1000);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (t1.IsAlive)
            {
                t1.Abort();
            }
        }
    }
}
