using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Productos;
using Facturas;

namespace Ejercicio_Clase_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Producto p1 = new Producto(1, "Coca", 40);
            Producto p2 = new Producto(2, "Pepsi", 35);
            Factura f = new Factura();

            f[p1.Identificador] = p1; // f.productos.Add(p1);
            f[p2.Identificador] = p2; // f.productos.Add(p2);

            MessageBox.Show(f.Total.ToString());
        }
        
    }
}
