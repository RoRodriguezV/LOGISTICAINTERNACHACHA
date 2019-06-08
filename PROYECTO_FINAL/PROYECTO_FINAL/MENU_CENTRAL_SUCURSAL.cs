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
    public partial class MENU_CENTRAL_SUCURSAL : Form
    {
        public MENU_CENTRAL_SUCURSAL()
        {
            InitializeComponent();

            textBox1.Text = ControlDeMerma.CodSucursal;
        }

        private void MENU_CENTRAL_SUCURSAL_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
