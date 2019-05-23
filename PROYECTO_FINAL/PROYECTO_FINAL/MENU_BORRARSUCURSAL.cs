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
    public partial class MENU_BORRARSUCURSAL : Form
    {
        public MENU_BORRARSUCURSAL()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BDconsultas.BuscarSucursal(txtcodigo.Text);

        }

        private void bt_msucurales_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BDconsultas.BuscarSucursales();
        }

        private void bt_borrar_Click(object sender, EventArgs e)
        {

        }
    }
}
