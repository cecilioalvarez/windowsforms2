using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms001
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

            CargarTabla();
            
        }

        private void CargarTabla()
        {

        ConnectionStringSettings settings =
               ConfigurationManager
               .ConnectionStrings["miconexion"];
        String cadena = settings.ConnectionString;
            using (SqlConnection conexion =
            new SqlConnection(cadena))
            {
                conexion.Open();
                String sql = "select * from Facturas";
                SqlCommand comando = new SqlCommand(sql, conexion);

                DataTable table = new DataTable();

                SqlDataReader lector = comando.ExecuteReader();
                table.Load(lector);
                dataGridView1.DataSource = table;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void botonAceptar_Click(object sender, EventArgs e)
        {



            ConnectionStringSettings settings =
              ConfigurationManager
              .ConnectionStrings["miconexion"];
            String cadena = settings.ConnectionString;
            using (SqlConnection conexion =
            new SqlConnection(cadena))
            {
                conexion.Open();
                String sql = "insert into Facturas (numero,concepto) values (@Numero,@Concepto)";
                SqlCommand comando = new SqlCommand(sql, conexion);
                comando.Parameters.AddWithValue("@Numero",numeroTextBox.Text);
                comando.Parameters.AddWithValue("@Concepto",conceptoTextBox.Text);

                comando.ExecuteNonQuery();
                CargarTabla();


            }




        }
    }
}
