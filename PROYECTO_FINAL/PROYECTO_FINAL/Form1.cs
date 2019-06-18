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
    public partial class ControlDeMerma : Form
    {
        public ControlDeMerma()
        {
            InitializeComponent();
        }

        public roles RolSelecionado { get; set; }
        public static string CodSucursal;
        private void bt_verificar_Click(object sender, EventArgs e)
        {
            try
            {
                bool verificar = false;
                persona pers = new persona (tb_usuario.Text, tb_pass.Text);
                verificar = BDconsultas.LogInAdmi(pers.CodigoPersona, pers.PassPersona);
                if (verificar == true)
                {
                    RolSelecionado = BDconsultas.ObtenerCodigo(tb_usuario.Text);
                    
                   

                     if(RolSelecionado != null)
                      {
                        string rolselec = RolSelecionado.CodRoles;
                        if(rolselec == "01")
                        {
                            MessageBox.Show("BIENVENIDO DE NUEVO ", "ADMINISTRADOR DE CENTRAL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            MENU_CENTRAL menu_central = new MENU_CENTRAL();
                            menu_central.Show();
                            this.Hide();
                        }
                        else
                        {
                            CodSucursal = RolSelecionado.CodRoles;
                            MessageBox.Show("BIENVENIDO DE NUEVO ADMINISTRADOR", "ADMINISTRADOR DE SUCURSAL N°" + CodSucursal, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            MENU_SUCURSALES menu_sucursal = new MENU_SUCURSALES();
                            menu_sucursal.Show();
                            this.Hide();
                        }

                    }
                      

                }
                else
                {
                    MessageBox.Show("CÓDIGO O CONTRASEÑA INCORRECTA", "ERROR AL VERIFICAR", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch
            {
                MessageBox.Show("VUELVA A INTENTARLO", "ERROR CON LA BASE DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ControlDeMerma_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
