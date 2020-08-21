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
    public partial class Form6 : Form
    {
        DataSet midataset;
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            midataset = new DataSet();
            DataTable tabla = new DataTable("tabla1");
            tabla.Columns.Add("Nombre");
            tabla.Columns.Add("Apellidos");
            DataRow fila = tabla.NewRow();
            fila["Nombre"] = "pedro";
            fila["Apellidos"] = "alvarez";
            tabla.Rows.Add(fila);


            DataTable tabla2 = new DataTable("tabla2");
            tabla2.Columns.Add("Numero");
            tabla2.Columns.Add("Concepto");
            DataRow fila2 = tabla2.NewRow();
            fila2["Numero"] = "1";
            fila2["Concepto"] = "ordenador";
            tabla.Rows.Add(fila2);

            midataset.Tables.Add(tabla2);
            dataGridView1.DataSource = midataset;
            dataGridView1.DataMember = "tabla2";




        }
    }
}
