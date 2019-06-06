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

            String _query = String.Format("SELECT CodInsumo FROM receta", ComboBoxIngrediente.Text);
            MySqlCommand _comando = new MySqlCommand(_query, BDcomun.ObtenerConexion());
            MySqlDataReader _reader = _comando.ExecuteReader();
            ComboBoxIngrediente.Items.Clear();
            if (_reader.HasRows)
                while (_reader.Read())
                    ComboBoxIngrediente.Items.Add(_reader.GetString("CodInsumo"));

            String _query2 = String.Format("SELECT CodProducto FROM receta", comboBox1.Text);
            MySqlCommand _comando2 = new MySqlCommand(_query2, BDcomun.ObtenerConexion());
            MySqlDataReader _reader2 = _comando2.ExecuteReader();
            comboBox1.Items.Clear();
            if (_reader2.HasRows)
                while (_reader2.Read())
                    comboBox1.Items.Add(_reader2.GetString("CodProducto"));

            dg_datos.DataSource = BDconsultas.BuscarRecetas();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public receta recetaactual { get; set; }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(comboBox1.Text) || string.IsNullOrWhiteSpace(txtcantidad.Text) || string.IsNullOrWhiteSpace(ComboBoxIngrediente.Text))

                MessageBox.Show("Hay Uno o mas Campos Vacios!", "Campos Vacios!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            else
            {
                receta preceta = new receta();
                preceta.CodProducto = comboBox1.Text;
                preceta.CodInsumo = ComboBoxIngrediente.Text;
                preceta.CantidadReceta = Convert.ToInt32(txtcantidad.Text);


                int resultado = BDconsultas.AgregarReceta(preceta);
                if (resultado > 0)
                {
                    MessageBox.Show("Asignación Guardada Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo guardar la asignación", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta Seguro que desea eliminar el elemeto de la receta Actual", "Estas Seguro??", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

            {
                if (BDconsultas.EliminarReceta(recetaactual.CodProducto) > 0)

                {
                    MessageBox.Show("Insumo de receta Eliminada Correctamente!", "Ingrediente de receta Eliminada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else

                {
                    MessageBox.Show("No se pudo eliminar el ingrediente de la receta", "Ingrediente de receta No Eliminada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

            else

                MessageBox.Show("Se cancelo la eliminación", "Eliminación Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MENU_RECETA menrec = new MENU_RECETA();
            menrec.Show();
            this.Hide();
        }

        private void FRECETA_Load(object sender, EventArgs e)
        {

        }

        private void btrefrescar_Click(object sender, EventArgs e)
        {
            dg_datos.DataSource = BDconsultas.BuscarRecetas();

        }

        private void btseleccionar_Click(object sender, EventArgs e)
        {
            if (dg_datos.SelectedRows.Count == 1)
            {
                string id = Convert.ToString(dg_datos.CurrentRow.Cells[1].Value);
                recetaactual = BDconsultas.ObtenerReceta(id);


            }
            else
                MessageBox.Show("Debe de seleccionar una fila");
            if (recetaactual != null)
            {

                comboBox1.Text = Convert.ToString(recetaactual.CodProducto);
                ComboBoxIngrediente.Text = Convert.ToString(recetaactual.CodInsumo);
                txtcantidad.Text = Convert.ToString(recetaactual.CantidadReceta);


            }
        }

        private void btactualizar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(comboBox1.Text) || string.IsNullOrWhiteSpace(txtcantidad.Text) || string.IsNullOrWhiteSpace(ComboBoxIngrediente.Text))

                MessageBox.Show("Hay Uno o mas Campos Vacios!", "Campos Vacios!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            else
            {
                receta preceta = new receta();
                preceta.CodProducto = comboBox1.Text;
                preceta.CodInsumo = ComboBoxIngrediente.Text;
                preceta.CantidadReceta = Convert.ToInt32(txtcantidad.Text);


                int resultado = BDconsultas.ActualizarReceta(preceta);
                if (resultado > 0)
                {
                    MessageBox.Show("Receta Guardada Con Exito!!", "Actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo guardar la receta", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
        }
    }
}
