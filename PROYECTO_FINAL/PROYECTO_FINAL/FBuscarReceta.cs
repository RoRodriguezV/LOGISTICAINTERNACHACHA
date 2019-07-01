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
    public partial class FBuscarReceta : Form
    {
        public FBuscarReceta()
        {
            InitializeComponent();
            cbxReceta.KeyPress += cbxReceta_KeyPress;

            String _query2 = String.Format("SELECT CodProducto FROM receta", cbxReceta.Text);
            MySqlCommand _comando2 = new MySqlCommand(_query2, BDcomun.ObtenerConexion());
            MySqlDataReader _reader2 = _comando2.ExecuteReader();
            cbxReceta.Items.Clear();
            if (_reader2.HasRows)
                while (_reader2.Read())
                    cbxReceta.Items.Add(_reader2.GetString("CodProducto"));

            dgvBuscarReceta.DataSource = BDconsultas.BuscarRecetas();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgvBuscarReceta.DataSource = BDconsultas.BuscarReceta(cbxReceta.Text);
        }

        private void cbxReceta_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MENU_RECETA menrec = new MENU_RECETA();
            menrec.Show();
            this.Hide();
        }

        private void cbxReceta_KeyPress(object sender, KeyPressEventArgs e)
        {
            cbxReceta.DropDownStyle = ComboBoxStyle.DropDownList;
        }

    }
}
