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
    public partial class Producto : Form
    {
        public Producto()
        {
            InitializeComponent();
            LlenarCB();
        }
        SqlConnection conexion = new SqlConnection("Data Source=FAU;Initial Catalog=TIENDA;Integrated Security=True");



        private void LlenarCB()
        {
            conexion.Open();
            string consulta = "select * from Producto";
            SqlCommand co = new SqlCommand(consulta, conexion);
            SqlDataReader lector = co.ExecuteReader();

            while (lector.Read())
            {
                CB_ID_Productos.Items.Add(lector[0].ToString());

            }
            conexion.Close();

        }

        private void Llenar()
        {
            conexion.Open();

            SqlCommand cm = new SqlCommand("select * from Producto where id_Productos='" + CB_ID_Productos.Text + "'", conexion);
            SqlDataReader reader = cm.ExecuteReader();
            if (reader.Read())
            {
                TBT_ID_Producto.Text = reader["ID_Productos"].ToString();
                TBT_Nombre.Text = reader["Nombre"].ToString();     
                TBT_V_Gemas.Text = reader["Valor_Dolar"].ToString();
                TBT_V_Oro.Text = reader["Valor_Colon"].ToString();
            }

            conexion.Close();

        }

        private void CB_ID_Productos_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Llenar();
        }


        private void Añadir()
        {
            conexion.Open();

            String consulta = "insert into Producto values (@Id_Productos, @Nombre,  @Valor_Dolar, @Valor_Colon)";
            SqlCommand adapter = new SqlCommand(consulta, conexion);
            adapter.Parameters.AddWithValue("@Id_Productos", TBT_ID_Producto.Text);
            adapter.Parameters.AddWithValue("@Nombre", TBT_Nombre.Text);    
            adapter.Parameters.AddWithValue("@Valor_Dolar", TBT_V_Gemas.Text);
            adapter.Parameters.AddWithValue("@Valor_Colon", TBT_V_Oro.Text);
            adapter.ExecuteNonQuery();
            conexion.Close();

        }

        private void Modificar()
        {
            conexion.Open();
            String consulta = "UPDATE Producto SET Id_Productos=@Id_Productos, Nombre=@Nombre,  Valor_Dolar=@Valor_Dolar, Valor_Colon=@Valor_Colon WHERE Id_Productos=@Id_Productos";
            SqlCommand adapter = new SqlCommand(consulta, conexion);
            adapter.Parameters.AddWithValue("@Id_Productos", TBT_ID_Producto.Text);
            adapter.Parameters.AddWithValue("@Nombre", TBT_Nombre.Text);
            adapter.Parameters.AddWithValue("@Valor_Dolar", TBT_V_Gemas.Text);
            adapter.Parameters.AddWithValue("@Valor_Colon", TBT_V_Oro.Text);
            adapter.ExecuteNonQuery();
            conexion.Close();

        }

        private void Eliminar()
        {
            conexion.Open();

            String consulta = "Delete from Producto where Id_Productos='" + TBT_ID_Producto.Text + "'";
            SqlCommand adapter = new SqlCommand(consulta, conexion);
            adapter.ExecuteNonQuery();

            conexion.Close();
        }


        private void Clear()
        {
            TBT_ID_Producto.Clear();
            TBT_Nombre.Clear();
            TBT_V_Gemas.Clear();
            TBT_V_Oro.Clear();
            CB_ID_Productos.Items.Clear();

        }


        private void BT_Añadir_Click_1(object sender, EventArgs e)
        { 
            Añadir();
            Clear();
            LlenarCB();
        }

        private void BT_Modificar_Click_1(object sender, EventArgs e)
        {
            Modificar();
            Clear();
            LlenarCB();
        }

        private void BT_Eliminar_Click_1(object sender, EventArgs e)
        {
            Eliminar();
            Clear();
            LlenarCB();
        }

      
    }
}

