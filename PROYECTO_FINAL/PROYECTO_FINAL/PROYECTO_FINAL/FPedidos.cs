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
            dgvPedido.Columns.Add("estado", "ESTADO");
            cbOrigen.Text = ControlDeMerma.CodSucursal;
            tbCantidad.KeyPress += tbCantidad_KeyPress;
            cbDestino.KeyPress += cbDestino_KeyPress;
            cbProducto.KeyPress += cbProducto_KeyPress;

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

                dgvPedido.Rows.Add(cbOrigen.Text, cbDestino.Text, cbProducto.Text, tbCantidad.Text, dtFecha.Text, "Pendiente");

                cbOrigen.Text = "";
                cbDestino.Text = "";
                cbProducto.Text = "";
                tbCantidad.Text = "";
                dtFecha.Text = "";
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
                    comando = new MySqlCommand("Insert into pedidos values (?CodOrigen, ?CodDestino, ?CodProducto, ?CantidadPedido, ?Fecha, ?Estado) ", BDcomun.ObtenerConexion());

                    comando.Parameters.Add("?CodOrigen", MySqlDbType.VarChar).Value = Convert.ToString(row.Cells["origen"].Value);
                    comando.Parameters.Add("?CodDestino", MySqlDbType.VarChar).Value = Convert.ToString(row.Cells["destino"].Value);
                    comando.Parameters.Add("?CodProducto", MySqlDbType.VarChar).Value = Convert.ToString(row.Cells["producto"].Value);
                    comando.Parameters.Add("?CantidadPedido", MySqlDbType.Int16).Value = Convert.ToInt16(row.Cells["cantidad"].Value);
                    comando.Parameters.Add("?Fecha", MySqlDbType.Date).Value = Convert.ToDateTime(row.Cells["fecha"].Value);
                    comando.Parameters.Add("?Estado", MySqlDbType.VarChar).Value = Convert.ToString(row.Cells["estado"].Value);

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

        private void tbCantidad_KeyPress(object sender, KeyPressEventArgs e)
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

        private void cbDestino_KeyPress(object sender, KeyPressEventArgs e)
        {
            cbDestino.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void cbProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            cbProducto.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
}
