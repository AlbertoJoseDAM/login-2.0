using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario
{
    public partial class Form1 : Form
    {

        private static string usuario = "Jose";

        private static string contraseña = "1234";


        public Form1()
        {
            InitializeComponent();
        }

      

        private void button1_Click_1(object sender, EventArgs e)
        {
            if ((textBox1.Text == usuario) && (textBox2.Text == contraseña))
            {
                MessageBox.Show("Conexión establecida");

                Form2 form2 = new Form2();

                form2.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("La contraseña o el usuario son incorrectos");
            }
        }

        public static string GetUsuario()
        {
            return usuario;
        }

        public static string GetContraseña()
        {
            return contraseña;
        }



    }
}
