﻿using System;
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
    public partial class REGISTRO_PERSONAL : Form
    {
        public REGISTRO_PERSONAL()
        {
            InitializeComponent();
            dataGridView1.DataSource = BDconsultas.BuscarPersonas();

        }

        private void REGISTRO_PERSONAL_Load(object sender, EventArgs e)
        {

        }

        private void bt_registrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_codigo.Text) || string.IsNullOrWhiteSpace(tb_nombre.Text) || string.IsNullOrWhiteSpace(tb_apellido.Text) || string.IsNullOrWhiteSpace(tb_telefono.Text) || string.IsNullOrWhiteSpace(tb_pass.Text))

                MessageBox.Show("Hay Uno o mas Campos Vacios!", "Campos Vacios!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            else
            {
                persona ppersona = new persona();
                ppersona.CodigoPersona = tb_codigo.Text;
                ppersona.NombrePersona = tb_nombre.Text;
                ppersona.ApellidoPersona = tb_apellido.Text;
                ppersona.TelefonoPersona = tb_telefono.Text;
                ppersona.PassPersona = tb_pass.Text;


                int resultado = BDconsultas.AgregarPersona(ppersona);
                if (resultado > 0)
                {
                    MessageBox.Show("Persona Guardada Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();

                }
                else
                {
                    MessageBox.Show("No se pudo guardar la persona - El codigo ya existe", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void bt_buscar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BDconsultas.BuscarPersonas();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public persona personaactual { get; set; }

        private void bt_seleccionar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                string id = Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value);
                personaactual = BDconsultas.ObtenerPersona(id);


            }
            else
                MessageBox.Show("Debe de seleccionar una fila");
            if (personaactual != null)
            {

                tb_codigo.Text = Convert.ToString(personaactual.CodigoPersona);
                tb_nombre.Text = Convert.ToString(personaactual.NombrePersona);
                tb_apellido.Text = Convert.ToString(personaactual.ApellidoPersona);
                tb_telefono.Text = Convert.ToString(personaactual.TelefonoPersona);
                tb_pass.Text = Convert.ToString(personaactual.PassPersona);

            }
        }

        private void bt_volver_Click(object sender, EventArgs e)
        {
          
            MENU_PERSONAL mensuc = new MENU_PERSONAL();
            mensuc.Show();
            this.Hide();
        }

        private void bt_actualizar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_codigo.Text) || string.IsNullOrWhiteSpace(tb_nombre.Text) || string.IsNullOrWhiteSpace(tb_apellido.Text) || string.IsNullOrWhiteSpace(tb_telefono.Text) || string.IsNullOrWhiteSpace(tb_pass.Text))

                MessageBox.Show("Hay Uno o mas Campos Vacios!", "Campos Vacios!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            else
            {
                persona ppersona = new persona();
                ppersona.CodigoPersona = tb_codigo.Text;
                ppersona.NombrePersona = tb_nombre.Text;
                ppersona.ApellidoPersona = tb_apellido.Text;
                ppersona.TelefonoPersona = tb_telefono.Text;
                ppersona.PassPersona = tb_pass.Text;


                int resultado = BDconsultas.ActualizarPersona(ppersona);
                if (resultado > 0)
                {
                    MessageBox.Show("Persona Actualizada Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();

                }
                else
                {
                    MessageBox.Show("No se pudo actualizar la persona", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void bt_eliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta Seguro que desea eliminar la persona Actual", "Estas Seguro??", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

            {
                if (BDconsultas.EliminarPersona(personaactual.CodigoPersona) > 0)

                {
                    MessageBox.Show("Persona Eliminada Correctamente!", "Persona Eliminada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();

                }

                else

                {
                    MessageBox.Show("No se pudo eliminar la persona", "Persona No Eliminada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

            else

                MessageBox.Show("Se cancelo la eliminación", "Eliminación Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        void Limpiar()
        {
            tb_codigo.Clear();
            tb_nombre.Clear();
            tb_apellido.Clear();
            tb_telefono.Clear();
            tb_pass.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tb_codigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tb_codigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                if (char.IsControl(e.KeyChar))

            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void tb_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void tb_apellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void tb_telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros mayores a 0", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void tb_pass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros mayores a 0", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

    }
}
