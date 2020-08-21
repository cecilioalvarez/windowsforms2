using System;
using System.Collections;
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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

            comboBox1.Items.Add("insuficiente");
            comboBox1.Items.Add("suficiente");
            comboBox1.Items.Add("bien");
            comboBox1.Items.Add("notable");
            comboBox1.Items.Add("sobresaliente");

            comboBox2.Items.Add("1");
            comboBox2.Items.Add("2");
            comboBox2.Items.Add("3");
            comboBox2.Items.Add("4");
            comboBox2.Items.Add("5");

            listBox1.Items.Add("hola");
            listBox1.Items.Add("que");
            listBox1.Items.Add("tal");
            listBox1.Items.Add("estas");
         




        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListControl combo = sender as ListControl;
            MessageBox.Show(combo.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
           IList lista= listBox1.SelectedItems;
            string textoTotal = "";
            foreach(string texto in lista)
            {

                textoTotal += texto + ",";
            }
            MessageBox.Show(textoTotal);
        }
    }
}
