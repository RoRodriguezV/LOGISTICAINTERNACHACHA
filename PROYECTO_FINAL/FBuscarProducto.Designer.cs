namespace PROYECTO_FINAL
{
    partial class FBuscarProducto
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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxProducto = new System.Windows.Forms.ComboBox();
            this.dgvBuscarProducto = new System.Windows.Forms.DataGridView();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnBuscar.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(620, 23);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(111, 38);
            this.btnBuscar.TabIndex = 14;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(123, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = "NOMBRE DEL PRODUCTO:";
            // 
            // cbxProducto
            // 
            this.cbxProducto.FormattingEnabled = true;
            this.cbxProducto.Location = new System.Drawing.Point(338, 33);
            this.cbxProducto.Margin = new System.Windows.Forms.Padding(2);
            this.cbxProducto.Name = "cbxProducto";
            this.cbxProducto.Size = new System.Drawing.Size(244, 21);
            this.cbxProducto.TabIndex = 15;
            // 
            // dgvBuscarProducto
            // 
            this.dgvBuscarProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuscarProducto.Location = new System.Drawing.Point(17, 88);
            this.dgvBuscarProducto.Margin = new System.Windows.Forms.Padding(2);
            this.dgvBuscarProducto.Name = "dgvBuscarProducto";
            this.dgvBuscarProducto.RowTemplate.Height = 24;
            this.dgvBuscarProducto.Size = new System.Drawing.Size(861, 175);
            this.dgvBuscarProducto.TabIndex = 16;
            this.dgvBuscarProducto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBuscar_CellContentClick);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCancelar.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(600, 281);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(131, 47);
            this.btnCancelar.TabIndex = 18;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAceptar.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.Location = new System.Drawing.Point(201, 281);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(131, 47);
            this.btnAceptar.TabIndex = 19;
            this.btnAceptar.Text = "ACEPTAR";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // FBuscarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(888, 357);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.dgvBuscarProducto);
            this.Controls.Add(this.cbxProducto);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FBuscarProducto";
            this.Text = "Buscar Producto";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxProducto;
        private System.Windows.Forms.DataGridView dgvBuscarProducto;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
    }
}