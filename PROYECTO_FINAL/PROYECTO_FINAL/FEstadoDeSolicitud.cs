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
    public partial class FEstadoDeSolicitud : Form
    {
        public FEstadoDeSolicitud()
        {
            InitializeComponent();
        }

        private void FEstadoDeSolicitud_Load(object sender, EventArgs e)
        {
            dgv_stock.AllowUserToAddRows = false;
            TablaPedidos(dgv_stock);
        }
        public void TablaPedidos(DataGridView dvg)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand(String.Format("SELECT CodOrigen, CodDestino, CodProducto, CantidadPedido, Fecha , Estado  FROM pedidos "), BDcomun.ObtenerConexion());
                MySqlDataAdapter ds = new MySqlDataAdapter(comando);
                DataTable dr = new DataTable();
                ds.Fill(dr);
                dvg.DataSource = dr;
            }

            catch
            {
                MessageBox.Show("ERROR");
            }
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            
            if (dgv_stock.SelectedRows.Count == 1)
            {
                FAsignaciones asignaciones = new FAsignaciones();
                asignaciones.cbxOrigen.Text = dgv_stock.CurrentRow.Cells[0].Value.ToString();
                asignaciones.cbxDestino.Text = dgv_stock.CurrentRow.Cells[1].Value.ToString();
                asignaciones.cbxProducto.Text = dgv_stock.CurrentRow.Cells[2].Value.ToString();
                asignaciones.txtCantidad.Text = dgv_stock.CurrentRow.Cells[3].Value.ToString();
                asignaciones.Show();
            }
            else
                MessageBox.Show("debe de seleccionar una fila");
        }

        private void dgv_stock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_stock.SelectedRows.Count == 1)
            {
                string fila = dgv_stock.CurrentRow.Cells[0].Value.ToString();
            }
            else
                MessageBox.Show("debe de seleccionar una fila");
        }
        public int fila { get; set; }
        private void btRechazar_Click(object sender, EventArgs e)
        {
            if (dgv_stock.SelectedRows.Count == 1)
            {
                /*pedido pPedido = new pedido();
                pPedido.Codigo_Origen = dgv_stock.CurrentRow.Cells[0].Value.ToString();
                pPedido.Codigo_Destino = dgv_stock.CurrentRow.Cells[1].Value.ToString();
                pPedido.Codigo_Producto = dgv_stock.CurrentRow.Cells[2].Value.ToString();
                pPedido.Cantidad = dgv_stock.CurrentRow.Cells[3].Value.ToString();

                MySqlConnection conexion = BDcomun.ObtenerConexion();
                MySqlCommand comando;

               
                        comando = new MySqlCommand(string.Format("Update pedidos set Estado='Rechazado' where CodOrigen='{0}' and CodDestino ='{1}' and CodProducto '{2}' ",
                        pPedido.Codigo_Origen, pPedido.Codigo_Destino, pPedido.Codigo_Producto), conexion);
                        comando.ExecuteNonQuery();

                    MessageBox.Show("Datos Registrados");*/

                    dgv_stock.Rows.RemoveAt(fila);

            }
            else
                MessageBox.Show("debe de seleccionar una fila");

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
