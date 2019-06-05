using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_FINAL
{
    public partial class FEstadoDeSolicitud : Form
    {
        public FEstadoDeSolicitud()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FAsignaciones f2 = new FAsignaciones();
            f2.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btRechazar_Click(object sender, EventArgs e)
        {

        }

        private void dgv_stock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgv_stock.Columns.Add("origen","Origen");
            dgv_stock.Columns.Add("destino", "Destino");
            dgv_stock.Columns.Add("producto", "Producto");
            dgv_stock.Columns.Add("cantidad", "Cantidad");
        }

        private void FEstadoDeSolicitud_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            dgv_stock.Rows.Add();
        }
    }
}
