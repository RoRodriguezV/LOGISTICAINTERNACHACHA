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
    public partial class MENU_MERMAS : Form
    {
        public MENU_MERMAS()
        {
            InitializeComponent();
        }

        private void bt_volver_Click(object sender, EventArgs e)
        {
            MENU_CENTRAL mcentral = new MENU_CENTRAL();
            mcentral.Show();
            this.Hide();
        }
    }
}
