using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioExtension
{
    public partial class Form1 : Form
    {
        public ListBox Listado
        {
            get
            {
                return this.boxAlumnos;
            }
            set
            {
                this.boxAlumnos = value;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Form2 registro = new Form2();
            registro.ShowDialog(this);
            if (registro.DialogResult == DialogResult.Abort)
            {
                MessageBox.Show("No se ha cargado el registro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }

    public static class MiExtension
    {
        public static string Mostrar(this DateTime fecha)
        {
            return fecha.ToString("dd/MM/yyyy");
        }
        
        public static string Mostrar(this int dni)
        {
            string stringDni = dni.ToString();
            stringDni = stringDni.Insert(stringDni.Length - 6, ".");
            stringDni = stringDni.Insert(stringDni.Length - 3, ".");

            return stringDni;
        }
    }
}
