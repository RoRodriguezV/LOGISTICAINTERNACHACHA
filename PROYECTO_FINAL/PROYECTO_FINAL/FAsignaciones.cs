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
    public partial class FAsignaciones : Form
    {
        public FAsignaciones()
        {
            InitializeComponent();
            dgvAsignaciones.Columns.Add("CodOrigen", "ORIGEN");
            dgvAsignaciones.Columns.Add("CodDestino", "DESTINO");
            dgvAsignaciones.Columns.Add("CodProducto", "PRODUCTO");
            dgvAsignaciones.Columns.Add("CantidadEnvio", "CANTIDAD");
            dgvAsignaciones.Columns.Add("FechaHora", "FECHA");
        }


        void Combobox()
        {
            String query = String.Format("SELECT NombreSucursal FROM sucursal", cbxOrigen.Text);
            MySqlCommand comando = new MySqlCommand(query, BDcomun.ObtenerConexion());
            MySqlDataReader reader = comando.ExecuteReader();
            cbxOrigen.Items.Clear();
            if (reader.HasRows)
                while (reader.Read())
                    cbxOrigen.Items.Add(reader.GetString("NombreSucursal"));

            String query2 = String.Format("SELECT NombreSucursal FROM sucursal", cbxDestino.Text);
            MySqlCommand comando2 = new MySqlCommand(query2, BDcomun.ObtenerConexion());
            MySqlDataReader reader2 = comando2.ExecuteReader();
            cbxDestino.Items.Clear();
            if (reader2.HasRows)
                while (reader2.Read())
                    cbxDestino.Items.Add(reader2.GetString("NombreSucursal"));



            String _query = String.Format("SELECT NombreProducto FROM producto", cbxProducto.Text);
            MySqlCommand _comando = new MySqlCommand(_query, BDcomun.ObtenerConexion());
            MySqlDataReader _reader = _comando.ExecuteReader();
            cbxProducto.Items.Clear();
            if (_reader.HasRows)
                while (_reader.Read())
                    cbxProducto.Items.Add(_reader.GetString("NombreProducto"));
        }

        void Limpiar()
        {
            cbxOrigen.Items.Clear();
            cbxDestino.Items.Clear();
            cbxProducto.Items.Clear();
            txtCantidad.Clear();
            dtpFecha.ResetText();
        }


        void Habilitar()
        {
            cbxOrigen.Enabled = true;
            cbxDestino.Enabled = true;
            cbxProducto.Enabled = true;
            txtCantidad.Enabled = true;
            dtpFecha.Enabled = true;
            btnRegistrar.Enabled = true;
            btnAgregar.Enabled = true;
            btnEliminar.Enabled = true;
        }


        void Deshabilitar()
        {
            cbxOrigen.Enabled = false;
            cbxDestino.Enabled = false;
            cbxProducto.Enabled = false;
            txtCantidad.Enabled = false;
            dtpFecha.Enabled = false;
            btnRegistrar.Enabled = false;
            btnAgregar.Enabled = false;
            btnEliminar.Enabled = false;

            btnNuevo.Enabled = true;
        }

        private void FAsignaciones_Load(object sender, EventArgs e)
        {
            dgvAsignaciones.AllowUserToAddRows = false;
            Deshabilitar();
        }

        public int fila;
        private void dgvAsignaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAsignaciones.SelectedRows.Count == 1)
            {
                int fila = Convert.ToInt32(dgvAsignaciones.CurrentRow.Cells[0].Value);
            }
            else
                MessageBox.Show("debe de seleccionar una fila");
        }

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            Limpiar();
            Habilitar();
            Combobox();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbxOrigen.Text) || string.IsNullOrWhiteSpace(cbxDestino.Text) || string.IsNullOrWhiteSpace(cbxProducto.Text) || string.IsNullOrWhiteSpace(txtCantidad.Text) || string.IsNullOrWhiteSpace(dtpFecha.Text))

                MessageBox.Show("Hay Uno o mas Campos Vacios!", "Campos Vacios!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                Asigaciones pAsignaciones = new Asigaciones();

                pAsignaciones.Fecha = dtpFecha.Value.Year + "/" + dtpFecha.Value.Month + "/" + dtpFecha.Value.Day;
                dgvAsignaciones.Rows.Add(cbxOrigen.Text, cbxDestino.Text, cbxProducto.Text, txtCantidad.Text, dtpFecha.Text);

                cbxOrigen.Text = "";
                cbxDestino.Text = "";
                cbxProducto.Text = "";
                txtCantidad.Text = "";
                dtpFecha.Text = pAsignaciones.Fecha;
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                dgvAsignaciones.Rows.RemoveAt(fila); //borrando todos los datos de la fila seleccionada de acuerdo al valor de "fila"
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("No hay ninguna columna seleccionada"); //Cuando se intenta borrar una fila que no se seleccionó
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Asigaciones pAsignaciones = new Asigaciones();
            MySqlCommand comando = new MySqlCommand(string.Format("Insert into envio (CodOrigen, CodDestino, CodProducto, CantidadEnvio, FechaHora) values ('{0}', '{1}', '{2}', '{3}', '{4}' )",
            pAsignaciones.Codigo_Origen, pAsignaciones.Codigo_Destino, pAsignaciones.Producto, pAsignaciones.Cantidad, pAsignaciones.Fecha), BDcomun.ObtenerConexion());

            try
            {
                foreach (DataGridViewRow row in dgvAsignaciones.Rows)
                {
                    comando.Parameters.Clear();
                    comando.Parameters.AddWithValue("@CodOrigen", Convert.ToString(row.Cells["ORIGEN"].Value));
                    comando.Parameters.AddWithValue("@CodDestino", Convert.ToString(row.Cells["DESTINO"].Value));
                    comando.Parameters.AddWithValue("@CodProducto", Convert.ToString(row.Cells["PRODUCTO"].Value));
                    comando.Parameters.AddWithValue("@CantidadEnvio", Convert.ToString(row.Cells["CANTIDAD"].Value));
                    comando.Parameters.AddWithValue("@FechaHora", Convert.ToString(row.Cells["FECHA"].Value));

                    comando.ExecuteNonQuery();
                }
                MessageBox.Show("Datos agregados");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar");
            }

        }
    }
}
