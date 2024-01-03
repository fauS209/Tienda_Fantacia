using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tienda_Fantacia
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        
        private void Abrir(object fHijo)
        {
            //Valida disponiblidad del panel centar(Abrir), en caso de estar utilizado, remover y sustituir
            if (this.P_Central.Controls.Count > 0)
                this.P_Central.Controls.RemoveAt(0);

            Form f = fHijo as Form;
            f.TopLevel = false;
            P_Central.Controls.Add(f);
            f.Show();

        }
        private void button2_Click(object sender, EventArgs e)
        {

            Abrir(new Bodega());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Abrir(new Producto());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Abrir(new Clientes());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Abrir(new Provedor());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Abrir(new Historial());
        }
      


        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void BT_Start_Click(object sender, EventArgs e)
        {
            Form3 login = new Form3();
            login.Show();
            this.Hide();
        }

      
    }
}
