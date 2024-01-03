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
    public partial class Tienda : Form
    {
        public Tienda()
        {
            InitializeComponent();
        }
        
        SqlConnection conexion = new SqlConnection("Data Source=FAU;Initial Catalog=TIENDA;Integrated Security=True");
        public int indice;
        public bool id_P= false;
        private void Mostrar()
        { 
            dataGridView1.Visible = true;
            LB_Id_Productos.Visible = true;
            LB_Cantidad.Visible = true;
            LB_Metodo_P.Visible = true;
            LB_Disponibles.Visible = true;
            LB_Oro.Visible = true;
            LB_Gemas.Visible = true;
            LB_Usuario.Visible = true;
            TBT_Cedula.Visible = true;
            TBT_Id_Productos.Visible = true;
            TBT_Cantidad.Visible = true;
            TBT_Disponibles.Visible = true;
            TBT_Oro.Visible = true;
            TBT_Gemas.Visible = true;
            CB_Metodo_P.Visible = true ;
            BT_Comprar.Visible = true ;
        }

        private void Llenar()
        {
            //Query LLenar el DataGrip
            String consulta = "select *  from Producto";
            SqlDataAdapter adapter = new SqlDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;

            if (id_P == true) {
                conexion.Open();
                //Query para LLenar los TBT segun el producto seleccionado
                SqlCommand cm = new SqlCommand ("select * from Bodega where Id_Productos='" + TBT_Id_Productos.Text + "'", conexion);
            SqlDataReader reader = cm.ExecuteReader();
            if (reader.Read())
            {
                TBT_Disponibles.Text = reader["Disponibles"].ToString();
              
                }
                conexion.Close();
            }

            Mostrar();
        }

        private void Comprar()
        {
            //Query insertar una compra en el historial
            conexion.Open();
            String consulta = "insert into Historial values (" + TBT_Id_Productos.Text + ",'" + TBT_Cantidad.Text + "','" + TBT_Cedula.Text + "','" + this.dateTimePicker1.Text + "','" + CB_Metodo_P.Text + "','" + TBT_Id.Text + "');";
            SqlCommand adapter = new SqlCommand(consulta, conexion);
            adapter.ExecuteNonQuery();
            conexion.Close(); 
        }

       
    
        private void Usuario()
        {
            //Query para LLenar la informacion del Cliente, segun su id
            conexion.Open();

            SqlCommand cm = new SqlCommand("select * from Cliente where Cedula='" + TBT_Cedula.Text + "'", conexion);
            SqlDataReader reader = cm.ExecuteReader();
            if (reader.Read())
            {
                LB_Usuario.Text = reader["Nombre"].ToString();
                TBT_Oro.Text = reader["Colones"].ToString();
                TBT_Gemas.Text = reader["Dolares"].ToString();
            }

            conexion.Close();
        
    }

        private void button3_Click(object sender, EventArgs e)
        {        
            try
            {
                Usuario();
                Llenar();
                Mostrar();
            } 
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo conectar con la base de datos" + ex.ToString());
            }   
        }

        private void Modificar()
        {
            conexion.Open();
            String consulta = "UPDATE Bodega SET Id_Productos=@Id_Productos, Disponibles=@Disponibles, Vendidos=@Vendidos WHERE Id_Productos=@Id_Productos";
            SqlCommand adapter = new SqlCommand(consulta, conexion);
            adapter.Parameters.AddWithValue("@Id_Productos", TBT_Id_Productos.Text);
            adapter.Parameters.AddWithValue("@Disponibles", (Convert.ToInt32(TBT_Disponibles.Text) - Convert.ToInt32(TBT_Cantidad.Text)));
            adapter.Parameters.AddWithValue("@Vendidos", TBT_Cantidad.Text);
           
            adapter.ExecuteNonQuery();
            conexion.Close();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TBT_Id_Productos.Text = dataGridView1.SelectedCells[0].Value.ToString();
            TBT_Gemas_Producto.Text = dataGridView1.SelectedCells[2].Value.ToString();
            TBT_Oro_Producto.Text = dataGridView1.SelectedCells[3].Value.ToString();
            id_P = true;
            Llenar();
        }

        private void BT_Comprar_Click(object sender, EventArgs e)
        {
            //Query para validar Compra, segun el Oro y Gemas
            while (indice == 0)
                {
                    if (Convert.ToInt32(TBT_Oro.Text) >= Convert.ToInt32(TBT_Oro_Producto.Text))
                    {
                        Comprar();
                        MessageBox.Show("Felicidades por su compra");
                        Modificar();
                        TBT_Id_Productos.Clear();
                    
                    }
                    else
                    {
                        MessageBox.Show("Fondos insuficientes");
                    }
                    break;
                }
            while (indice == 1)
            {
                if (Convert.ToInt32(TBT_Gemas.Text) >= Convert.ToInt32(TBT_Gemas_Producto.Text))
                {
                    Comprar();
                    MessageBox.Show("Felicidades por su compra");
                    Modificar();
                    TBT_Id_Productos.Clear();
                    
                }
                else
                {
                    MessageBox.Show("Fondos insuficientes");

                }
                break;
            }
        }

        private void CB_Metodo_P_SelectedIndexChanged(object sender, EventArgs e)
        {
             indice = CB_Metodo_P.SelectedIndex;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 login = new Form3();
            login.Show();
            this.Hide();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
