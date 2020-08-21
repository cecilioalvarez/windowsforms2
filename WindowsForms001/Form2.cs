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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radio = sender as RadioButton;

            EtiquetaRadios.Text = radio.Text;
        }

       
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void botonSeleccionado_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                MessageBox.Show(radioButton1.Text);
            }else if (radioButton2.Checked)
            {
                MessageBox.Show(radioButton2.Text);
            }else
            {
                MessageBox.Show(radioButton3.Text);
            }
        }

        private void botonInformatico_Click(object sender, EventArgs e)
        {
            if (esInformatico.Checked)
            {
                MessageBox.Show("la caja esta checkeada");
            }else
            {
                MessageBox.Show("la caja no esta checkeada");
            }
        }
    }
}
