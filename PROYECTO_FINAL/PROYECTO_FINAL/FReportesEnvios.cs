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
    public partial class FReportesEnvios : Form
    {
        public FReportesEnvios()
        {
            InitializeComponent();
        }
        public void LlenarDatosEnvios(DataGridView dvg)
        {
            try
            {
                FechaBusqueda.Format = DateTimePickerFormat.Custom;
                FechaBusqueda.CustomFormat = "yyyy/MM/dd";
                String fecha1 = FechaBusqueda.Value.Date.ToString("yyyy/MM/dd");

                MySqlCommand comando = new MySqlCommand(String.Format("SELECT CodOrigen, CodDestino, CodProducto, CantidadEnvio, FechaHora FROM envio WHERE FechaHora = '{0}'", fecha1), BDcomun.ObtenerConexion());
                MySqlDataAdapter da = new MySqlDataAdapter(comando);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dvg.DataSource = dt;

            }
            catch
            {
                MessageBox.Show("ERROR");
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            LlenarDatosEnvios(dgvEnvios);
            dgvEnvios.Update();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
