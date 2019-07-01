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
    public partial class ForMermas : Form
    {
        public ForMermas()
        {
            InitializeComponent();
            dataGridView1.Columns.Add("codsucursal", "SUCURSAL");
            dataGridView1.Columns.Add("codproducto", "PRODUCTO");
            dataGridView1.Columns.Add("cantidadmerma", "CANTIDAD MERMA");
            dataGridView1.Columns.Add("fechainicio", "FECHA INICIO");
            dataGridView1.Columns.Add("fechafin", "FECHA FINAL");
            //dataGridView1.DataSource = BDconsultas.BuscarPersonas();
            textBoxCantMer.KeyPress += txtCantidad_KeyPress;
            comBoxCodSucur.KeyPress += cbxSucursal_KeyPress;
            comBoxCodPro.KeyPress += cbxProducto_KeyPress;

            Limpiar();
            Combobox();
        }

        void Combobox()
        {
            String query = String.Format("SELECT CodSucursal FROM sucursal", comBoxCodSucur.Text);
            MySqlCommand comando = new MySqlCommand(query, BDcomun.ObtenerConexion());
            MySqlDataReader reader = comando.ExecuteReader();
            comBoxCodSucur.Items.Clear();
            if (reader.HasRows)
                while (reader.Read())
                    comBoxCodSucur.Items.Add(reader.GetString("CodSucursal"));


            String _query = String.Format("SELECT CodProducto FROM producto", comBoxCodPro.Text);
            MySqlCommand _comando = new MySqlCommand(_query, BDcomun.ObtenerConexion());
            MySqlDataReader _reader = _comando.ExecuteReader();
            comBoxCodPro.Items.Clear();
            if (_reader.HasRows)
                while (_reader.Read())
                   comBoxCodPro.Items.Add(_reader.GetString("CodProducto"));
        }

        void Limpiar()
        {
            comBoxCodSucur.Items.Clear();
            comBoxCodPro.Items.Clear();
            textBoxCantMer.Clear();
            dtpFechaInicio.ResetText();
            dtpFechaFinal.ResetText();
        }

      
        private void ForMermas_Load(object sender, EventArgs e)
        {
            dataGridView1.AllowUserToAddRows = false;
        }

        private void bt_registrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(comBoxCodSucur.Text) || string.IsNullOrWhiteSpace(comBoxCodPro.Text) || string.IsNullOrWhiteSpace(textBoxCantMer.Text) || string.IsNullOrWhiteSpace(dtpFechaInicio.Text) || string.IsNullOrWhiteSpace(dtpFechaFinal.Text))

                MessageBox.Show("Hay Uno o mas Campos Vacios!", "Campos Vacios!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            else
            {
               
                dtpFechaInicio.Format = DateTimePickerFormat.Custom;
                dtpFechaInicio.CustomFormat = "yyyy/MM/dd";
                dtpFechaFinal.Format = DateTimePickerFormat.Custom;
                dtpFechaFinal.CustomFormat = "yyyy/MM/dd";


                dataGridView1.Rows.Add(comBoxCodSucur.Text, comBoxCodPro.Text, textBoxCantMer.Text, dtpFechaInicio.Text, dtpFechaFinal.Text);

                comBoxCodSucur.Text = "";
                comBoxCodPro.Text = "";
                textBoxCantMer.Text = "";
                dtpFechaInicio.Text = "";
                dtpFechaFinal.Text = "";
            }

        }
        public int fila { get; set; }

        private void bt_eliminar_Click(object sender, EventArgs e)
        {

            try
            {
                dataGridView1.Rows.RemoveAt(fila); //borrando todos los datos de la fila seleccionada de acuerdo al valor de "fila"
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("No hay ninguna columna seleccionada"); //Cuando se intenta borrar una fila que no se seleccionó
            }

        }

        private void REGISTRAR_Click(object sender, EventArgs e)
        {
            MySqlConnection conexion = BDcomun.ObtenerConexion();
            MySqlCommand comando;

            try
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    comando = new MySqlCommand("Insert into merma values (?CodSucursal, ?CodProducto, ?CantidadMerma, ?FechaInicio , ?FechaFin) ", BDcomun.ObtenerConexion());

                    comando.Parameters.Add("?CodSucursal", MySqlDbType.VarChar).Value = Convert.ToString(row.Cells["codsucursal"].Value);
                    comando.Parameters.Add("?CodProducto", MySqlDbType.VarChar).Value = Convert.ToString(row.Cells["codproducto"].Value);
                    comando.Parameters.Add("?CantidadMerma", MySqlDbType.VarChar).Value = Convert.ToString(row.Cells["cantidadmerma"].Value);
                    comando.Parameters.Add("?FechaInicio", MySqlDbType.Date).Value = Convert.ToDateTime(row.Cells["fechainicio"].Value);
                    comando.Parameters.Add("?FechaFin", MySqlDbType.Date).Value = Convert.ToDateTime(row.Cells["fechafin"].Value);

                    comando.ExecuteNonQuery();

                }

                MessageBox.Show("Datos Registrados");

                dataGridView1.Rows.Clear();
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void VOLVER_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                string fila = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            }
            else
                MessageBox.Show("debe de seleccionar una fila");
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)) //Para obligar a que sólo se introduzcan números 
            {
                e.Handled = false;
            }
            else
                 if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso 
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan 
                e.Handled = true;
            }
        }

        private void cbxSucursal_KeyPress(object sender, KeyPressEventArgs e)
        {
            comBoxCodSucur.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void cbxProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            comBoxCodPro.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void textBoxCantMer_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


