using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EjercicioNro60
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection conexion;
        SqlCommand comando;

        private void Form1_Load(object sender, EventArgs e)
        {
            conexion = new SqlConnection("Data Source=SMILER\\SQLEXPRESS;Initial Catalog=AdventureWorks2017;Integrated Security=True");
            comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.Connection = conexion;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool numeroDeSerieValido = false;
            String[] numero = txtProductNumber.Text.Split('-');
            if (numero.Length == 2)
            {
                if (numero[0].Length == 2 && numero[1].Length == 4)
                {
                    numeroDeSerieValido = true;
                    foreach (char letra in numero[0])
                    {
                        if (char.IsLetter(letra))
                        {
                            char.ToUpper(letra);
                        }
                        else
                        {
                            numeroDeSerieValido = false;
                            break;
                        }
                    }
                }
            }

            if (numeroDeSerieValido && txtName.Text != String.Empty)
            {
                String consulta = String.Format("INSERT INTO Production.Product(Name, ProductNumber) VALUES('{0}', '{1}')", 
                    txtName.Text, txtProductNumber.Text);

                comando.CommandText = consulta;
                conexion.Open();
                comando.ExecuteNonQuery();
                conexion.Close();
                MessageBox.Show("Se ha agregado un nuevo registro.");
            }
        }
    }
}
