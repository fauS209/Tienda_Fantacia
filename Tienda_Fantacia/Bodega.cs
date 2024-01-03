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
    public partial class Bodega : Form
    {
        public Bodega()
        {
            InitializeComponent();
            LlenarCB();
            Llenar_DataG();
        }
        SqlConnection conexion = new SqlConnection("Data Source=FAU;Initial Catalog=TIENDA;Integrated Security=True");

        private void Llenar_DataG()
        {
            //Query LLenar el DataGrip
            String consulta = "select *  from Bodega";
            SqlDataAdapter adapter = new SqlDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Verificar()
        {
          if ( Convert.ToInt32( TBT_Disponibiliddad.Text)<=2) {
                MessageBox.Show("Quedan Pocas unidades del articulo: "+TBT_ID_Producto.Text);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TBT_ID_Producto.Text = dataGridView1.SelectedCells[0].Value.ToString();
            TBT_Disponibiliddad.Text = dataGridView1.SelectedCells[1].Value.ToString();
            TBT_Vendidos.Text = dataGridView1.SelectedCells[2].Value.ToString();
            TBT_ID_Provedor.Text = dataGridView1.SelectedCells[3].Value.ToString();
            Verificar();
        }

        private void LlenarCB()
        {
            //Query para Llenar CB
            conexion.Open();
            string consulta = "select * from Bodega";
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
            //Query para Llenar TBT, segun el Id seleccionado
            conexion.Open();
            SqlCommand cm = new SqlCommand("select * from Bodega where id_Productos='" + CB_ID_Productos.Text + "'", conexion);
            SqlDataReader reader = cm.ExecuteReader();
            if (reader.Read())
            {
                TBT_ID_Producto.Text = reader["ID_Productos"].ToString();
                TBT_Disponibiliddad.Text = reader["Disponibles"].ToString();
                TBT_Vendidos.Text = reader["Vendidos"].ToString();
                TBT_ID_Provedor.Text = reader["Id_Provedores"].ToString();
            }

            conexion.Close();
            Verificar();

        }

        private void CB_ID_Productos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Llenar();
        }


        private void Añadir()
        {
            conexion.Open();
            String consulta = "insert into Bodega values (@Id_Productos, @Disponibles, @Vendidos, @Id_Provedores )";
            SqlCommand adapter = new SqlCommand(consulta, conexion);
            adapter.Parameters.AddWithValue("@Id_Productos", TBT_ID_Producto.Text);
            adapter.Parameters.AddWithValue("@Disponibles", TBT_Disponibiliddad.Text);
            adapter.Parameters.AddWithValue("@Vendidos", TBT_Vendidos.Text);
            adapter.Parameters.AddWithValue("@Id_Provedores", TBT_ID_Provedor.Text);
            adapter.ExecuteNonQuery();
            conexion.Close();

        }

        private void Modificar()
        {
            conexion.Open();
            String consulta = "UPDATE Bodega SET Id_Productos=@Id_Productos, Disponibles=@Disponibles, Vendidos=@Vendidos, Id_Provedores=@Id_Provedores WHERE Id_Productos=@Id_Productos";
            SqlCommand adapter = new SqlCommand(consulta, conexion);
            adapter.Parameters.AddWithValue("@Id_Productos", TBT_ID_Producto.Text);
            adapter.Parameters.AddWithValue("@Disponibles", TBT_Disponibiliddad.Text);
            adapter.Parameters.AddWithValue("@Vendidos", TBT_Vendidos.Text);
            adapter.Parameters.AddWithValue("@Id_Provedores", TBT_ID_Provedor.Text);
            adapter.ExecuteNonQuery();
            conexion.Close();
           
        }

        private void Eliminar()
        {
            conexion.Open();
            String consulta = "Delete from Bodega where Id_Productos='" + TBT_ID_Producto.Text + "'";
            SqlCommand adapter = new SqlCommand(consulta, conexion);
            adapter.ExecuteNonQuery();
           
            conexion.Close();
        }


        private void Clear()
        {
            TBT_ID_Producto.Clear();
            TBT_Disponibiliddad.Clear();
            TBT_ID_Provedor.Clear();
            TBT_Vendidos.Clear();
            CB_ID_Productos.Items.Clear();

            
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

        private void BT_Añadir_Click(object sender, EventArgs e)
        {
            Añadir();
            Clear();
            LlenarCB();
           
        }

    
    }
}

