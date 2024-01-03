using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tienda_Fantacia
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        SqlConnection conexion = new SqlConnection("Data Source=FAU;Initial Catalog=TIENDA;Integrated Security=True");
 
        private void BT_Start_Click(object sender, EventArgs e)
        {
            Tienda tienda = new Tienda();
            Menu InicioT = new Menu();
            conexion.Open();

            //Query para validar si el id pertecene a un Cliente
            string consulta = "Select * from Cliente where Cedula='"+textBox1.Text+"'";
            SqlCommand comando = new SqlCommand(consulta, conexion);
            SqlDataReader lector;
            lector = comando.ExecuteReader();

            if (lector.HasRows == true) {
                this.Hide();
               tienda.Show();
            }
            conexion.Close();


            conexion.Open();
            //Query para validar si el id pertecene a un empleado
            string consulta1 = "Select * from Empleado where Id_Empleados='" + textBox1.Text + "'";
            SqlCommand comando1 = new SqlCommand(consulta1, conexion);
            SqlDataReader lector1;
            lector1 = comando1.ExecuteReader();
            if (lector1.HasRows == true)
            {
                this.Hide();
                InicioT.Show();
            } 
            conexion.Close();

          
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
