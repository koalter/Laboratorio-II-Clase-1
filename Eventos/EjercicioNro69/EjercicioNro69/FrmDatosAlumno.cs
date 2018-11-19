using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace EjercicioNro69
{
    public delegate void DelegadoMostrar(Alumno a);

    public partial class FrmDatosAlumno : FrmAltaAlumno
    {
        public FrmDatosAlumno() : base()
        {
            InitializeComponent();
        }

        public void ActualizarAlumno(Alumno alumno)
        {
            
        }
    }
}
