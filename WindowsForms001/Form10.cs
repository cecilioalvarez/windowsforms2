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
    public partial class Retroceder : Form
    {
        DataSet midataset;
        SqlDataAdapter adaptador1 = new SqlDataAdapter();

        public Retroceder()
        {
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
           
            midataset = new DataSet();


            ConnectionStringSettings settings =
              ConfigurationManager
              .ConnectionStrings["miconexion"];
            String cadena = settings.ConnectionString;
            SqlConnection conexion =
             new SqlConnection(cadena);
            
                conexion.Open();
                String sql = "select * from Facturas";
                
                SqlCommand comando = conexion.CreateCommand();
                comando.CommandText = sql;
                comando.CommandType = CommandType.Text;

                SqlCommand comandoInsertar = conexion.CreateCommand();
                comandoInsertar.CommandType = CommandType.Text;
                // consulta parametrizada
                String sqlInsertar = "insert into Facturas ( numero,concepto)" +
                    " values (@numero,@concepto)";
                comandoInsertar.CommandText = sqlInsertar;
                comandoInsertar.Parameters.Add("@numero", SqlDbType.Int, 10,"numero");
                comandoInsertar.Parameters.Add("@concepto", SqlDbType.VarChar, 20,"concepto");
                // esta es la clave primaria de la tabla con la cual
                // insertaremos nuevos elementos
                comandoInsertar.Parameters["@numero"].SourceVersion = DataRowVersion.Original;


                String sqlActulizar = "update Facturas set concepto=@concepto where @numero=numero";
                
                
                SqlCommand comandoActualizar = conexion.CreateCommand();

                comandoActualizar
                    .Parameters.Add("@numero", SqlDbType.Int, 10,"numero");
                comandoActualizar
                    .Parameters.Add("@concepto", SqlDbType.VarChar, 20,"concepto");
                comandoActualizar
                    .Parameters["@numero"].SourceVersion = DataRowVersion.Original;


                comandoActualizar.CommandType = CommandType.Text;
                comandoActualizar.CommandText = sqlActulizar;

                string sqlBorrar = "delete from Facturas where numero=@numero";
            SqlCommand comandoBorrar = conexion.CreateCommand();
                comandoBorrar.CommandText = sqlBorrar;
                comandoBorrar.CommandType = CommandType.Text;
            comandoBorrar
                   .Parameters.Add("@numero", SqlDbType.Int, 10, "numero");

            comandoBorrar
              .Parameters["@numero"].SourceVersion = DataRowVersion.Original;


            adaptador1.SelectCommand = comando;
            adaptador1.InsertCommand = comandoInsertar;
            adaptador1.UpdateCommand = comandoActualizar;
            adaptador1.DeleteCommand = comandoBorrar;

                adaptador1.Fill(midataset, "Facturas");

            //
            bindingSource1.DataSource = midataset.Tables["Facturas"];
            dataGridView1.DataSource = bindingSource1;
            NumeroTextBox.DataBindings
                .Add("Text", bindingSource1, "Numero");

            ConceptoTextBox.DataBindings
               .Add("Text", bindingSource1, "Concepto");

            label3.Text = bindingSource1.Position.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            adaptador1.Update(midataset,"Facturas");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataGridViewRow fila = dataGridView1.CurrentRow;
            dataGridView1.Rows.Remove(fila);
            adaptador1.Update(midataset, "Facturas");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bindingSource1.MovePrevious();
        }

        private void botonAvanzar_Click(object sender, EventArgs e)
        {
            bindingSource1.MoveNext();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bindingSource1.MoveFirst();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            bindingSource1.MoveLast();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            bindingSource1.Sort = "Concepto";
        }

        private void bindingSource1_PositionChanged(object sender, EventArgs e)
        {
            label3.Text = bindingSource1.Position.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            bindingSource1.Filter = "concepto='"
                + FiltroTxt.Text + "'";
           // bindingSource1.DataSource = midataset.Tables["Facturas"];
           
        }
    }
}
