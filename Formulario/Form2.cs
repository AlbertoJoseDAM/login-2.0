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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            label1.Text = $"Bienvenido {Form1.GetUsuario()}, su contraseña es {Form1.GetContraseña()}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();

            this.Close();
        }
    }
}
