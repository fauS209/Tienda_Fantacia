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
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
            LlenarCB();
        }
        SqlConnection conexion = new SqlConnection("Data Source=FAU;Initial Catalog=TIENDA;Integrated Security=True");



        private void LlenarCB()
        {
            conexion.Open();
            string consulta = "select * from Cliente";
            SqlCommand co = new SqlCommand(consulta, conexion);
            SqlDataReader lector = co.ExecuteReader();

            while (lector.Read())
            {
               CB_Cedula.Items.Add(lector[0].ToString());

            }
            conexion.Close();

        }

        private void Llenar()
        {
            conexion.Open();

            SqlCommand cm = new SqlCommand("select * from Cliente where Cedula='" + CB_Cedula.Text + "'", conexion);
            SqlDataReader reader = cm.ExecuteReader();
            if (reader.Read())
            {
               TBT_Cedula.Text = reader["Cedula"].ToString();
                TBT_Roll.Text = reader["Roll"].ToString();
                TBT_Nombre.Text = reader["Nombre"].ToString();
                TBT_Contacto.Text = reader["Contacto"].ToString();
                TBT_Correo.Text = reader["Correo"].ToString();
                TBT_V_Oro.Text = reader["Colones"].ToString();
                TBT_V_Gemas.Text = reader["Dolares"].ToString();
            }

            conexion.Close();

        }

        private void CB_Cedula_SelectedIndexChanged(object sender, EventArgs e)
        {
            Llenar();
        }


        private void Añadir()
        {
            conexion.Open();

            String consulta = "insert into Cliente values (@Cedula,@roll, @Nombre, @Contacto, @Correo, @Colones, @Dolares)";
            SqlCommand adapter = new SqlCommand(consulta, conexion);
            adapter.Parameters.AddWithValue("@Cedula", TBT_Cedula.Text);
            adapter.Parameters.AddWithValue("@Roll", TBT_Roll.Text);
            adapter.Parameters.AddWithValue("@Nombre", TBT_Nombre.Text);
            adapter.Parameters.AddWithValue("@Contacto", TBT_Contacto.Text);
            adapter.Parameters.AddWithValue("@Correo", TBT_Correo.Text);
            adapter.Parameters.AddWithValue("@Colones", TBT_V_Oro.Text);
            adapter.Parameters.AddWithValue("@Dolares", TBT_V_Gemas.Text);
            adapter.ExecuteNonQuery();
            conexion.Close();

        }

        private void Modificar()
        {
            conexion.Open();
            String consulta = "UPDATE Cliente SET Cedula=@Cedula, Roll=@Roll Nombre=@Nombre, Contacto=@Contacto, Correo=@Correo, Colones=@Colones, Dolares=@Dolares WHERE Cedula=@Cedula";
            SqlCommand adapter = new SqlCommand(consulta, conexion);
            adapter.Parameters.AddWithValue("@Cedula", TBT_Cedula.Text);
            adapter.Parameters.AddWithValue("@Roll", TBT_Roll.Text);
            adapter.Parameters.AddWithValue("@Nombre", TBT_Nombre.Text);
            adapter.Parameters.AddWithValue("@Contacto", TBT_Contacto.Text);
            adapter.Parameters.AddWithValue("@Correo", TBT_Correo.Text);
            adapter.Parameters.AddWithValue("@Colones", TBT_V_Oro.Text);
            adapter.Parameters.AddWithValue("@Dolares", TBT_V_Gemas.Text);
            adapter.ExecuteNonQuery();
            conexion.Close();

        }

        private void Eliminar()
        {
            conexion.Open();

            String consulta = "Delete from Cliente where Id_Productos='" + TBT_Cedula.Text + "'";
            SqlCommand adapter = new SqlCommand(consulta, conexion);
            adapter.ExecuteNonQuery();

            conexion.Close();
        }


        private void Clear()
        {
           TBT_Cedula.Clear();
            TBT_Roll.Clear();
            TBT_Nombre.Clear();
            TBT_Contacto.Clear();
            TBT_Correo.Clear();
            TBT_V_Gemas.Clear();
            TBT_V_Oro.Clear();
            CB_Cedula.Items.Clear();

        }


     

        private void BT_Añadir_Click(object sender, EventArgs e)
        {
            Añadir();
            Clear();
            LlenarCB();
        }

        private void BT_Modificar_Click(object sender, EventArgs e)
        {
            Modificar();
            Clear();
            LlenarCB();
        }

        private void BT_Eliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
            Clear();
            LlenarCB();
        }
    }
}

