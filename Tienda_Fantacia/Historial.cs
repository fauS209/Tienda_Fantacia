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
    public partial class Historial : Form
    {
        public Historial()
        {
            InitializeComponent();
            Llenar();
        }

        SqlConnection conexion = new SqlConnection("Data Source=FAU;Initial Catalog=TIENDA;Integrated Security=True");
        private void Llenar(){
            String consulta = "select *  from Historial";
            SqlDataAdapter adapter = new SqlDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

       
    }
}
