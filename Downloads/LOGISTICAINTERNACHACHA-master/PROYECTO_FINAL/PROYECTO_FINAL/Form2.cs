using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace PROYECTO_FINAL
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnAgregar1_Click(object sender, EventArgs e)
        {
            dg_datos.Rows.Add(ComboBoxIngrediente.Text, txtBoxCantidad.Text, txtBoxMedida.Text);
            ComboBoxIngrediente.Text = "";
            txtBoxCantidad.Text = "";
            txtBoxMedida.Text = "";


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnEliminar2_Click(object sender, EventArgs e)
        {
            dg_datos.Rows.Remove(dg_datos.CurrentRow);

        }

        //public fila as Integer 
        private void dg_datos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }
             

        
        private void btnAgregar1_Click_1(object sender, EventArgs e)
        {
           
           
        }

        private void dg_datos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }

        private void dg_datos_Click(object sender, EventArgs e)
        {
            dg_datos.Columns.Add("ingrediente", "INGREDIENTE");
            dg_datos.Columns.Add("cantidad", "CANTIDAD");
            dg_datos.Columns.Add("medida", "MEDIDA");
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            fillProductCbx();
            fillProductCbx2();
        }

        private void fillProductCbx()
        {
            producto pprod = new producto();
            MySqlConnection conexion = BDcomun.ObtenerConexion();

            MySqlCommand _comando = conexion.CreateCommand();
            _comando.CommandText = "SELECT CodProducto, NombreProducto FROM producto";
            MySqlDataReader _reader = _comando.ExecuteReader();
            comboBox1.Items.Clear();
            while (_reader.Read())
            {

                comboBox1.Items.Add(_reader.GetString(0) + " " + _reader.GetString(1));
             
                
            }

            conexion.Close();

        }

    private void fillProductCbx2()
    {
        insumo insu = new insumo();
        MySqlConnection conexion = BDcomun.ObtenerConexion();

        MySqlCommand _comando = conexion.CreateCommand();
        _comando.CommandText = "SELECT CodInsumo, NombreInsumo FROM insumo";
        MySqlDataReader _reader = _comando.ExecuteReader();
        ComboBoxIngrediente.Items.Clear();
        while (_reader.Read())
        {

            ComboBoxIngrediente.Items.Add(_reader.GetString(0) + " " + _reader.GetString(1));


        }

        conexion.Close();

    }

    private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtBebida1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ComboBoxIngrediente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("seleccionado");
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            MySqlConnection conectar = BDcomun.ObtenerConexion();

            MySqlCommand _comando = conectar.CreateCommand();
            MySqlCommand agregar = new MySqlCommand("insert into receta values (@ingrediente, @cantidad, @medida)", conectar);
           

            try
            {
                foreach (DataGridViewRow row in dg_datos.Rows) 
                {
                    agregar.Parameters.Clear();

                    agregar.Parameters.AddWithValue("@ingrediente", Convert.ToString(row.Cells["INGREDIENTE"].Value));
                    agregar.Parameters.AddWithValue("@cantidad", Convert.ToString(row.Cells["CANTIDAD"].Value));
                    agregar.Parameters.AddWithValue("@medida", Convert.ToString(row.Cells["MEDIDA"].Value));

                    agregar.ExecuteNonQuery();

                }
                MessageBox.Show("Datos agregados");
            } catch(Exception ex)
                {
                MessageBox.Show("Error al agregar");
            }
            finally
            {
                conectar.Close();

            }
        }
    }
}
    