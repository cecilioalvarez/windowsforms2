using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms001
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("formulario cargado");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hola desde windows forms");
        }

        private void botonPersona_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cajaNombre.Text + "," + cajaApellidos.Text);
        }

        private void botonNotas_Click(object sender, EventArgs e)
        {

            MessageBox.Show((Convert.ToInt32(cajaNota1.Text) + Convert.ToInt32(cajaNota2.Text) + Convert.ToInt32(cajaNota3.Text)).ToString());
        }
    }
}
