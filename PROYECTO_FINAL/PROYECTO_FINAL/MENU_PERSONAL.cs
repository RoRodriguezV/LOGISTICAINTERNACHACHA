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
    public partial class MENU_PERSONAL : Form
    {
        public MENU_PERSONAL()
        {
            InitializeComponent();
        }

        private void bt_volver_Click(object sender, EventArgs e)
        {
            MENU_CENTRAL central = new MENU_CENTRAL();
            central.Show();
            this.Hide();
        }
    }
}
