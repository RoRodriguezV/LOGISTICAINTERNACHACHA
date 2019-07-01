namespace PROYECTO_FINAL
{
    partial class REGISTRO_PERSONAL
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.bt_registrar = new System.Windows.Forms.Button();
            this.bt_actualizar = new System.Windows.Forms.Button();
            this.bt_eliminar = new System.Windows.Forms.Button();
            this.bt_seleccionar = new System.Windows.Forms.Button();
            this.bt_volver = new System.Windows.Forms.Button();
            this.bt_buscar = new System.Windows.Forms.Button();
            this.tb_codigo = new System.Windows.Forms.TextBox();
            this.tb_nombre = new System.Windows.Forms.TextBox();
            this.tb_apellido = new System.Windows.Forms.TextBox();
            this.tb_telefono = new System.Windows.Forms.TextBox();
            this.tb_pass = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(541, 140);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(717, 446);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(107, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "CÓDIGO:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(100, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "NOMBRE:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(89, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 27);
            this.label3.TabIndex = 1;
            this.label3.Text = "APELLIDO:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(80, 349);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 27);
            this.label4.TabIndex = 1;
            this.label4.Text = "TELÉFONO:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(39, 415);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(187, 27);
            this.label5.TabIndex = 1;
            this.label5.Text = "CONTRASEÑA:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Sans", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(377, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(557, 46);
            this.label6.TabIndex = 1;
            this.label6.Text = "ADMINISTRAR PERSONAL";
            // 
            // bt_registrar
            // 
            this.bt_registrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bt_registrar.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_registrar.ForeColor = System.Drawing.Color.White;
            this.bt_registrar.Location = new System.Drawing.Point(44, 531);
            this.bt_registrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_registrar.Name = "bt_registrar";
            this.bt_registrar.Size = new System.Drawing.Size(163, 55);
            this.bt_registrar.TabIndex = 2;
            this.bt_registrar.Text = "REGISTRAR";
            this.bt_registrar.UseVisualStyleBackColor = false;
            this.bt_registrar.Click += new System.EventHandler(this.bt_registrar_Click);
            // 
            // bt_actualizar
            // 
            this.bt_actualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bt_actualizar.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_actualizar.ForeColor = System.Drawing.Color.White;
            this.bt_actualizar.Location = new System.Drawing.Point(300, 531);
            this.bt_actualizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_actualizar.Name = "bt_actualizar";
            this.bt_actualizar.Size = new System.Drawing.Size(176, 55);
            this.bt_actualizar.TabIndex = 2;
            this.bt_actualizar.Text = "ACTUALIZAR";
            this.bt_actualizar.UseVisualStyleBackColor = false;
            this.bt_actualizar.Click += new System.EventHandler(this.bt_actualizar_Click);
            // 
            // bt_eliminar
            // 
            this.bt_eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bt_eliminar.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_eliminar.ForeColor = System.Drawing.Color.White;
            this.bt_eliminar.Location = new System.Drawing.Point(166, 619);
            this.bt_eliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_eliminar.Name = "bt_eliminar";
            this.bt_eliminar.Size = new System.Drawing.Size(154, 58);
            this.bt_eliminar.TabIndex = 2;
            this.bt_eliminar.Text = "ELIMINAR";
            this.bt_eliminar.UseVisualStyleBackColor = false;
            this.bt_eliminar.Click += new System.EventHandler(this.bt_eliminar_Click);
            // 
            // bt_seleccionar
            // 
            this.bt_seleccionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bt_seleccionar.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_seleccionar.ForeColor = System.Drawing.Color.White;
            this.bt_seleccionar.Location = new System.Drawing.Point(789, 602);
            this.bt_seleccionar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_seleccionar.Name = "bt_seleccionar";
            this.bt_seleccionar.Size = new System.Drawing.Size(201, 72);
            this.bt_seleccionar.TabIndex = 2;
            this.bt_seleccionar.Text = "SELECCIONAR";
            this.bt_seleccionar.UseVisualStyleBackColor = false;
            this.bt_seleccionar.Click += new System.EventHandler(this.bt_seleccionar_Click);
            // 
            // bt_volver
            // 
            this.bt_volver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bt_volver.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_volver.ForeColor = System.Drawing.Color.White;
            this.bt_volver.Location = new System.Drawing.Point(1143, 659);
            this.bt_volver.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_volver.Name = "bt_volver";
            this.bt_volver.Size = new System.Drawing.Size(134, 35);
            this.bt_volver.TabIndex = 2;
            this.bt_volver.Text = "VOLVER";
            this.bt_volver.UseVisualStyleBackColor = false;
            this.bt_volver.Click += new System.EventHandler(this.bt_volver_Click);
            // 
            // bt_buscar
            // 
            this.bt_buscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bt_buscar.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_buscar.ForeColor = System.Drawing.Color.White;
            this.bt_buscar.Location = new System.Drawing.Point(541, 542);
            this.bt_buscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_buscar.Name = "bt_buscar";
            this.bt_buscar.Size = new System.Drawing.Size(150, 42);
            this.bt_buscar.TabIndex = 2;
            this.bt_buscar.Text = "REFRESCAR";
            this.bt_buscar.UseVisualStyleBackColor = false;
            this.bt_buscar.Click += new System.EventHandler(this.bt_buscar_Click);
            // 
            // tb_codigo
            // 
            this.tb_codigo.Location = new System.Drawing.Point(228, 142);
            this.tb_codigo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_codigo.Name = "tb_codigo";
            this.tb_codigo.Size = new System.Drawing.Size(232, 26);
            this.tb_codigo.TabIndex = 3;
            this.tb_codigo.TextChanged += new System.EventHandler(this.tb_codigo_TextChanged);
            this.tb_codigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_codigo_KeyPress);
            // 
            // tb_nombre
            // 
            this.tb_nombre.Location = new System.Drawing.Point(228, 206);
            this.tb_nombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_nombre.Name = "tb_nombre";
            this.tb_nombre.Size = new System.Drawing.Size(232, 26);
            this.tb_nombre.TabIndex = 4;
            this.tb_nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_nombre_KeyPress);
            // 
            // tb_apellido
            // 
            this.tb_apellido.Location = new System.Drawing.Point(228, 285);
            this.tb_apellido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_apellido.Name = "tb_apellido";
            this.tb_apellido.Size = new System.Drawing.Size(232, 26);
            this.tb_apellido.TabIndex = 5;
            this.tb_apellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_apellido_KeyPress);
            // 
            // tb_telefono
            // 
            this.tb_telefono.Location = new System.Drawing.Point(228, 346);
            this.tb_telefono.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_telefono.Name = "tb_telefono";
            this.tb_telefono.Size = new System.Drawing.Size(232, 26);
            this.tb_telefono.TabIndex = 6;
            this.tb_telefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_telefono_KeyPress);
            // 
            // tb_pass
            // 
            this.tb_pass.Location = new System.Drawing.Point(228, 411);
            this.tb_pass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_pass.Name = "tb_pass";
            this.tb_pass.Size = new System.Drawing.Size(232, 26);
            this.tb_pass.TabIndex = 7;
            this.tb_pass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_pass_KeyPress);
            // 
            // REGISTRO_PERSONAL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1275, 692);
            this.Controls.Add(this.tb_pass);
            this.Controls.Add(this.tb_telefono);
            this.Controls.Add(this.tb_apellido);
            this.Controls.Add(this.tb_nombre);
            this.Controls.Add(this.tb_codigo);
            this.Controls.Add(this.bt_volver);
            this.Controls.Add(this.bt_buscar);
            this.Controls.Add(this.bt_seleccionar);
            this.Controls.Add(this.bt_eliminar);
            this.Controls.Add(this.bt_actualizar);
            this.Controls.Add(this.bt_registrar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "REGISTRO_PERSONAL";
            this.Text = "REGISTRO_PERSONAL";
            this.Load += new System.EventHandler(this.REGISTRO_PERSONAL_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bt_registrar;
        private System.Windows.Forms.Button bt_actualizar;
        private System.Windows.Forms.Button bt_eliminar;
        private System.Windows.Forms.Button bt_seleccionar;
        private System.Windows.Forms.Button bt_volver;
        private System.Windows.Forms.Button bt_buscar;
        private System.Windows.Forms.TextBox tb_codigo;
        private System.Windows.Forms.TextBox tb_nombre;
        private System.Windows.Forms.TextBox tb_apellido;
        private System.Windows.Forms.TextBox tb_telefono;
        private System.Windows.Forms.TextBox tb_pass;
    }
}