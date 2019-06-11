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
    public partial class FPedidos : Form
    {
        public FPedidos()
        {
            InitializeComponent();
            dgvPedido.Columns.Add("origen", "ORIGEN");
            dgvPedido.Columns.Add("destino", "DESTINO");
            dgvPedido.Columns.Add("producto", "PRODUCTO");
            dgvPedido.Columns.Add("cantidad", "CANTIDAD");
            dgvPedido.Columns.Add("fecha", "FECHA");

            Limpiar();
            Combobox();

        }
        void Combobox()
        {
            String query = String.Format("SELECT CodSucursal FROM sucursal", cbOrigen.Text);
            MySqlCommand comando = new MySqlCommand(query, BDcomun.ObtenerConexion());
            MySqlDataReader reader = comando.ExecuteReader();
            cbOrigen.Items.Clear();
            if (reader.HasRows)
                while (reader.Read())
                    cbOrigen.Items.Add(reader.GetString("CodSucursal"));


            String query2 = String.Format("SELECT CodSucursal FROM sucursal", cbDestino.Text);
            MySqlCommand comando2 = new MySqlCommand(query2, BDcomun.ObtenerConexion());
            MySqlDataReader reader2 = comando2.ExecuteReader();
            cbDestino.Items.Clear();
            if (reader2.HasRows)
                while (reader2.Read())
                    cbDestino.Items.Add(reader2.GetString("CodSucursal"));



            String _query = String.Format("SELECT CodProducto FROM producto", cbProducto.Text);
            MySqlCommand _comando = new MySqlCommand(_query, BDcomun.ObtenerConexion());
            MySqlDataReader _reader = _comando.ExecuteReader();
            cbProducto.Items.Clear();
            if (_reader.HasRows)
                while (_reader.Read())
                    cbProducto.Items.Add(_reader.GetString("CodProducto"));
        }
        void Limpiar()
        {
            cbOrigen.Items.Clear();
            cbDestino.Items.Clear();
            cbProducto.Items.Clear();
            tbCantidad.Clear();
            dtFecha.ResetText();
        }
        private void FPedidos_Load(object sender, EventArgs e)
        {
            dgvPedido.AllowUserToAddRows = false;
        }

        private void bAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbOrigen.Text) || string.IsNullOrWhiteSpace(cbDestino.Text) || string.IsNullOrWhiteSpace(cbProducto.Text) || string.IsNullOrWhiteSpace(tbCantidad.Text) || string.IsNullOrWhiteSpace(dtFecha.Text))

                MessageBox.Show("Hay Uno o mas Campos Vacios!", "Campos Vacios!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
               

                dtFecha.Format = DateTimePickerFormat.Custom;
                dtFecha.CustomFormat = "yyyy/MM/dd";

                dgvPedido.Rows.Add(cbOrigen.Text, cbDestino.Text, cbProducto.Text, tbCantidad.Text, dtFecha.Text);

                cbOrigen.Text = "";
                cbDestino.Text = "";
                cbProducto.Text = "";
                tbCantidad.Text = "";
                dtFecha.Text = "";
            }
        }
        public int fila { get; set; }

        private void bEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                dgvPedido.Rows.RemoveAt(fila); //borrando todos los datos de la fila seleccionada de acuerdo al valor de "fila"
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("No hay ninguna columna seleccionada"); //Cuando se intenta borrar una fila que no se seleccionó
            }
        }

        private void bRealizarPedido_Click(object sender, EventArgs e)
        {
            MySqlConnection conexion = BDcomun.ObtenerConexion();
            MySqlCommand comando;

            try
            {
                foreach (DataGridViewRow row in dgvPedido.Rows)
                {
                    comando = new MySqlCommand("Insert into envio values (?CdOrigen, ?CdDestino, ?CdProducto, ?CantidadPedido, ?FechaPedido) ", BDcomun.ObtenerConexion());

                    comando.Parameters.Add("?CdOrigen", MySqlDbType.VarChar).Value = Convert.ToString(row.Cells["origen"].Value);
                    comando.Parameters.Add("?CdDestino", MySqlDbType.VarChar).Value = Convert.ToString(row.Cells["destino"].Value);
                    comando.Parameters.Add("?CdProducto", MySqlDbType.VarChar).Value = Convert.ToString(row.Cells["producto"].Value);
                    comando.Parameters.Add("?CantidadPedido", MySqlDbType.Int16).Value = Convert.ToInt16(row.Cells["cantidad"].Value);
                    comando.Parameters.Add("?FechaPedido", MySqlDbType.Date).Value = Convert.ToDateTime(row.Cells["fecha"].Value);

                    comando.ExecuteNonQuery();

                }

                MessageBox.Show("Datos Registrados");

                dgvPedido.Rows.Clear();
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void bVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvPedido_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPedido.SelectedRows.Count == 1)
            {
                string fila = dgvPedido.CurrentRow.Cells[0].Value.ToString();
            }
            else
                MessageBox.Show("debe de seleccionar una fila");
        }
    }
}
