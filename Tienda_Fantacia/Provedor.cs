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
    public partial class Provedor : Form
    {
        public Provedor()
        {
            InitializeComponent();
            LlenarCB();
        }
        SqlConnection conexion = new SqlConnection("Data Source=FAU;Initial Catalog=TIENDA;Integrated Security=True");



        private void LlenarCB()
        {
            conexion.Open();
            string consulta = "select * from Provedor";
            SqlCommand co = new SqlCommand(consulta, conexion);
            SqlDataReader lector = co.ExecuteReader();

            while (lector.Read())
            {
                CB_ID_Provedores.Items.Add(lector[0].ToString());

            }
            conexion.Close();



        }

        private void Llenar()
        {
            conexion.Open();

            SqlCommand cm = new SqlCommand("select * from Provedor where Id_Provedores='" + CB_ID_Provedores.Text + "'", conexion);
            SqlDataReader reader = cm.ExecuteReader();
            if (reader.Read())
            {
                TBT_ID_Provedores.Text = reader["Id_Provedores"].ToString();
                TBT_Nombre.Text = reader["Nombre"].ToString();
                TBT_Contacto.Text = reader["Contacto"].ToString();
                TBT_P_Suministrado.Text = reader["Productos_suministrados"].ToString();
                TBT_F_Entrega.Text = reader["Fecha_Entregas"].ToString();
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

            String consulta = "insert into Provedor values (@Id_Provedores, @Nombre, @Contacto, @Productos_suministrados,@Fecha_Entregas )";
            SqlCommand adapter = new SqlCommand(consulta, conexion);
            adapter.Parameters.AddWithValue("@Id_Provedores", TBT_ID_Provedores.Text);
            adapter.Parameters.AddWithValue("@Nombre", TBT_Nombre.Text);
            adapter.Parameters.AddWithValue("@Contacto", TBT_Contacto.Text);
            adapter.Parameters.AddWithValue("@Productos_suministrados", TBT_P_Suministrado.Text);
            adapter.Parameters.AddWithValue("@Fecha_Entregas", TBT_F_Entrega.Text);
            adapter.ExecuteNonQuery();
            conexion.Close();

        }

        private void Modificar()
        {
            conexion.Open();
            String consulta = "UPDATE Provedor SET Id_Provedores=@Id_Provedores, Nombre=@Nombre, Contacto=@Contacto, Productos_suministrados=@Productos_suministrados,Fecha_Entregas=@Fecha_Entregas WHERE Id_Provedores=@Id_Provedores";
            SqlCommand adapter = new SqlCommand(consulta, conexion);
            adapter.Parameters.AddWithValue("@Id_Provedores", TBT_ID_Provedores.Text);
            adapter.Parameters.AddWithValue("Nombre", TBT_Nombre.Text);
            adapter.Parameters.AddWithValue("Contacto", TBT_Contacto.Text);
            adapter.Parameters.AddWithValue("@Productos_suministrados", TBT_P_Suministrado.Text);
            adapter.Parameters.AddWithValue("@Fecha_Entregas", TBT_F_Entrega.Text);
            adapter.ExecuteNonQuery();
            conexion.Close();

        }

        private void Eliminar()
        {
            conexion.Open();

            String consulta = "Delete from Provedor where Id_Provedores='" + TBT_ID_Provedores.Text + "'";
            SqlCommand adapter = new SqlCommand(consulta, conexion);
            adapter.ExecuteNonQuery();

            conexion.Close();
        }


        private void Clear()
        {
            TBT_ID_Provedores.Clear();
            TBT_Nombre.Clear();
            TBT_Contacto.Clear();
            TBT_P_Suministrado.Clear();
            TBT_F_Entrega.Clear();
            CB_ID_Provedores.Items.Clear();


        }

        private void BT_Modificar_Click_1(object sender, EventArgs e)
        {
            Modificar();
            Clear();
            LlenarCB();
            
        }

        private void BT_Añadir_Click_1(object sender, EventArgs e)
        {
            Añadir();
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

