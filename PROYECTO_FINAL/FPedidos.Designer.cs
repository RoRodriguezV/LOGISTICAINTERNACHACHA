namespace PROYECTO_FINAL
{
    partial class FPedidos
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
            this.dgvPedido = new System.Windows.Forms.DataGridView();
            this.bVolver = new System.Windows.Forms.Button();
            this.bRealizarPedido = new System.Windows.Forms.Button();
            this.bEliminar = new System.Windows.Forms.Button();
            this.bAgregar = new System.Windows.Forms.Button();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbCantidad = new System.Windows.Forms.TextBox();
            this.cbProducto = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbDestino = new System.Windows.Forms.ComboBox();
            this.cbOrigen = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPedido
            // 
            this.dgvPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedido.Location = new System.Drawing.Point(316, 45);
            this.dgvPedido.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPedido.Name = "dgvPedido";
            this.dgvPedido.Size = new System.Drawing.Size(364, 250);
            this.dgvPedido.TabIndex = 29;
            this.dgvPedido.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPedido_CellContentClick);
            // 
            // bVolver
            // 
            this.bVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bVolver.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bVolver.ForeColor = System.Drawing.Color.White;
            this.bVolver.Location = new System.Drawing.Point(606, 360);
            this.bVolver.Margin = new System.Windows.Forms.Padding(2);
            this.bVolver.Name = "bVolver";
            this.bVolver.Size = new System.Drawing.Size(79, 32);
            this.bVolver.TabIndex = 28;
            this.bVolver.Text = "VOLVER";
            this.bVolver.UseVisualStyleBackColor = false;
            this.bVolver.Click += new System.EventHandler(this.bVolver_Click);
            // 
            // bRealizarPedido
            // 
            this.bRealizarPedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bRealizarPedido.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bRealizarPedido.ForeColor = System.Drawing.Color.White;
            this.bRealizarPedido.Location = new System.Drawing.Point(423, 322);
            this.bRealizarPedido.Margin = new System.Windows.Forms.Padding(2);
            this.bRealizarPedido.Name = "bRealizarPedido";
            this.bRealizarPedido.Size = new System.Drawing.Size(179, 37);
            this.bRealizarPedido.TabIndex = 27;
            this.bRealizarPedido.Text = "REALIZAR PEDIDO";
            this.bRealizarPedido.UseVisualStyleBackColor = false;
            this.bRealizarPedido.Click += new System.EventHandler(this.bRealizarPedido_Click);
            // 
            // bEliminar
            // 
            this.bEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bEliminar.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bEliminar.ForeColor = System.Drawing.Color.White;
            this.bEliminar.Location = new System.Drawing.Point(188, 322);
            this.bEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.bEliminar.Name = "bEliminar";
            this.bEliminar.Size = new System.Drawing.Size(113, 37);
            this.bEliminar.TabIndex = 26;
            this.bEliminar.Text = "ELIMINAR";
            this.bEliminar.UseVisualStyleBackColor = false;
            this.bEliminar.Click += new System.EventHandler(this.bEliminar_Click);
            // 
            // bAgregar
            // 
            this.bAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bAgregar.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAgregar.ForeColor = System.Drawing.Color.White;
            this.bAgregar.Location = new System.Drawing.Point(26, 322);
            this.bAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.bAgregar.Name = "bAgregar";
            this.bAgregar.Size = new System.Drawing.Size(113, 37);
            this.bAgregar.TabIndex = 25;
            this.bAgregar.Text = "AGREGAR";
            this.bAgregar.UseVisualStyleBackColor = false;
            this.bAgregar.Click += new System.EventHandler(this.bAgregar_Click);
            // 
            // dtFecha
            // 
            this.dtFecha.Location = new System.Drawing.Point(91, 255);
            this.dtFecha.Margin = new System.Windows.Forms.Padding(2);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(204, 20);
            this.dtFecha.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(29, 257);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 15);
            this.label10.TabIndex = 23;
            this.label10.Text = "FECHA:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(40, 214);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 15);
            this.label9.TabIndex = 22;
            this.label9.Text = "CANTIDAD:";
            // 
            // tbCantidad
            // 
            this.tbCantidad.Location = new System.Drawing.Point(132, 214);
            this.tbCantidad.Margin = new System.Windows.Forms.Padding(2);
            this.tbCantidad.Name = "tbCantidad";
            this.tbCantidad.Size = new System.Drawing.Size(163, 20);
            this.tbCantidad.TabIndex = 21;
            // 
            // cbProducto
            // 
            this.cbProducto.FormattingEnabled = true;
            this.cbProducto.Location = new System.Drawing.Point(132, 170);
            this.cbProducto.Margin = new System.Windows.Forms.Padding(2);
            this.cbProducto.Name = "cbProducto";
            this.cbProducto.Size = new System.Drawing.Size(163, 21);
            this.cbProducto.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(35, 173);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 15);
            this.label8.TabIndex = 19;
            this.label8.Text = "PRODUCTO:";
            // 
            // cbDestino
            // 
            this.cbDestino.FormattingEnabled = true;
            this.cbDestino.Location = new System.Drawing.Point(99, 125);
            this.cbDestino.Margin = new System.Windows.Forms.Padding(2);
            this.cbDestino.Name = "cbDestino";
            this.cbDestino.Size = new System.Drawing.Size(196, 21);
            this.cbDestino.TabIndex = 18;
            // 
            // cbOrigen
            // 
            this.cbOrigen.Enabled = false;
            this.cbOrigen.FormattingEnabled = true;
            this.cbOrigen.Location = new System.Drawing.Point(99, 75);
            this.cbOrigen.Margin = new System.Windows.Forms.Padding(2);
            this.cbOrigen.Name = "cbOrigen";
            this.cbOrigen.Size = new System.Drawing.Size(196, 21);
            this.cbOrigen.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(17, 128);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 15);
            this.label7.TabIndex = 16;
            this.label7.Text = "DESTINO:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(23, 75);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "ORIGEN:";
            // 
            // FPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(696, 392);
            this.Controls.Add(this.dgvPedido);
            this.Controls.Add(this.bVolver);
            this.Controls.Add(this.bRealizarPedido);
            this.Controls.Add(this.bEliminar);
            this.Controls.Add(this.bAgregar);
            this.Controls.Add(this.dtFecha);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbCantidad);
            this.Controls.Add(this.cbProducto);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbDestino);
            this.Controls.Add(this.cbOrigen);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FPedidos";
            this.Text = "FPedidos";
            this.Load += new System.EventHandler(this.FPedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPedido;
        private System.Windows.Forms.Button bVolver;
        private System.Windows.Forms.Button bRealizarPedido;
        private System.Windows.Forms.Button bEliminar;
        private System.Windows.Forms.Button bAgregar;
        private System.Windows.Forms.DateTimePicker dtFecha;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbCantidad;
        private System.Windows.Forms.ComboBox cbProducto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbDestino;
        private System.Windows.Forms.ComboBox cbOrigen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}