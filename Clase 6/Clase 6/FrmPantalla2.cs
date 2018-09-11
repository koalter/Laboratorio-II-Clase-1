using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase_6
{
    public partial class FrmPantalla2 : Form
    {
        public string atributoString = "Atributo Clase FrmPantalla2";

        public FrmPantalla2()
        {
            InitializeComponent();
        }

        private void FrmPantalla2_Load(object sender, EventArgs e)
        {
            //this.DialogResult = DialogResult.Cancel;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            // Me devuelve el estado del Checkbox
            //MessageBox.Show(this.chkEnviaPublicidad.Checked.ToString());

            // Me devuelve el estado del RadioBox
            //MessageBox.Show(this.rdoArgentino.Checked ? "Argentino" : "Extranjero");
            // if ? True : False
            // con foreach
            //foreach (Control radio in grbNacionalidad.Controls)
            //{
            //    // RadioButton es un hijo de Control, por eso casteamos a radio como RadioButton
            //    if (radio is RadioButton && ((RadioButton)radio).Checked)
            //    {
            //        MessageBox.Show(radio.Text);
            //    }
            //}

            // Me devuelve el valor de la ListBox (podemos usar .SelectedIndex / .SelectedItem / .SelectedItems / .SelectedValue
            MessageBox.Show(this.lstPosicion.SelectedItem.ToString());
        }

    }
}
