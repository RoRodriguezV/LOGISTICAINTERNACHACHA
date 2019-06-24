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
    public partial class MenuSucursales : Form
    {
        public MenuSucursales()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            FPedidos pedid = new FPedidos();
            pedid.Show();
            this.Hide();
        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }
    }
}
