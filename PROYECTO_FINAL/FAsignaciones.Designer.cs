namespace PROYECTO_FINAL
{
    partial class FAsignaciones
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
            this.btnVolver = new System.Windows.Forms.Button();
            this.cbxOrigen = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dgvAsignaciones = new System.Windows.Forms.DataGridView();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.cbxProducto = new System.Windows.Forms.ComboBox();
            this.cbxDestino = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvStockActual = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsignaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockActual)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnVolver.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(647, 371);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(93, 31);
            this.btnVolver.TabIndex = 48;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // cbxOrigen
            // 
            this.cbxOrigen.FormattingEnabled = true;
            this.cbxOrigen.Location = new System.Drawing.Point(85, 57);
            this.cbxOrigen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxOrigen.Name = "cbxOrigen";
            this.cbxOrigen.Size = new System.Drawing.Size(220, 21);
            this.cbxOrigen.TabIndex = 47;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(19, 59);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 18);
            this.label5.TabIndex = 46;
            this.label5.Text = "Origen: ";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnEliminar.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(211, 283);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(94, 35);
            this.btnEliminar.TabIndex = 45;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnRegistrar.Font = new System.Drawing.Font("Lucida Sans", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(88, 350);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(171, 52);
            this.btnRegistrar.TabIndex = 44;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAgregar.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(50, 284);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(90, 35);
            this.btnAgregar.TabIndex = 43;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dgvAsignaciones
            // 
            this.dgvAsignaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAsignaciones.Location = new System.Drawing.Point(348, 197);
            this.dgvAsignaciones.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvAsignaciones.Name = "dgvAsignaciones";
            this.dgvAsignaciones.RowTemplate.Height = 28;
            this.dgvAsignaciones.Size = new System.Drawing.Size(392, 127);
            this.dgvAsignaciones.TabIndex = 42;
            this.dgvAsignaciones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAsignaciones_CellContentClick_1);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(85, 232);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(220, 20);
            this.dtpFecha.TabIndex = 41;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(188, 179);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(117, 20);
            this.txtCantidad.TabIndex = 40;
            // 
            // cbxProducto
            // 
            this.cbxProducto.FormattingEnabled = true;
            this.cbxProducto.Location = new System.Drawing.Point(186, 136);
            this.cbxProducto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxProducto.Name = "cbxProducto";
            this.cbxProducto.Size = new System.Drawing.Size(119, 21);
            this.cbxProducto.TabIndex = 39;
            // 
            // cbxDestino
            // 
            this.cbxDestino.FormattingEnabled = true;
            this.cbxDestino.Location = new System.Drawing.Point(85, 98);
            this.cbxDestino.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxDestino.Name = "cbxDestino";
            this.cbxDestino.Size = new System.Drawing.Size(220, 21);
            this.cbxDestino.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(19, 234);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 18);
            this.label4.TabIndex = 37;
            this.label4.Text = "Fecha:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(82, 178);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 18);
            this.label3.TabIndex = 36;
            this.label3.Text = "Cantidad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(82, 139);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 18);
            this.label2.TabIndex = 35;
            this.label2.Text = "Producto:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 100);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 18);
            this.label1.TabIndex = 34;
            this.label1.Text = "Destino: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(448, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(179, 23);
            this.label6.TabIndex = 52;
            this.label6.Text = "STOCK ACTUAL";
            // 
            // dgvStockActual
            // 
            this.dgvStockActual.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStockActual.Location = new System.Drawing.Point(348, 55);
            this.dgvStockActual.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvStockActual.Name = "dgvStockActual";
            this.dgvStockActual.ReadOnly = true;
            this.dgvStockActual.RowTemplate.Height = 28;
            this.dgvStockActual.Size = new System.Drawing.Size(392, 118);
            this.dgvStockActual.TabIndex = 51;
          
            // 
            // FAsignaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(761, 422);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvStockActual);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.cbxOrigen);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvAsignaciones);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.cbxProducto);
            this.Controls.Add(this.cbxDestino);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FAsignaciones";
            this.Text = "Asignaciones";
            this.Load += new System.EventHandler(this.FAsignaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsignaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockActual)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dgvAsignaciones;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvStockActual;
        public System.Windows.Forms.ComboBox cbxOrigen;
        public System.Windows.Forms.DateTimePicker dtpFecha;
        public System.Windows.Forms.TextBox txtCantidad;
        public System.Windows.Forms.ComboBox cbxProducto;
        public System.Windows.Forms.ComboBox cbxDestino;
    }
}