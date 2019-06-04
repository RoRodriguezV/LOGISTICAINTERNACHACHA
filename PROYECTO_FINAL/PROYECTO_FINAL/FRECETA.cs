using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PROYECTO_FINAL
{
    public partial class FRECETA : Form
    {
        public FRECETA()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar");
            }
            finally
            {
                conectar.Close();

            }
        

    }

        private void button1_Click(object sender, EventArgs e)
        {
            dg_datos.Rows.Add(ComboBoxIngrediente.Text, txtBoxCantidad.Text, txtBoxMedida.Text);
            ComboBoxIngrediente.Text = "";
            txtBoxCantidad.Text = "";
            txtBoxMedida.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dg_datos.Rows.Remove(dg_datos.CurrentRow);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MENU_RECETA menrec = new MENU_RECETA();
            menrec.Show();
            this.Hide();
        }
    }
}
