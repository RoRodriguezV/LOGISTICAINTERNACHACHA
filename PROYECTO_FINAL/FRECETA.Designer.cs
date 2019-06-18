namespace PROYECTO_FINAL
{
    partial class FRECETA
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ComboBoxIngrediente = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.bteliminar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dg_datos = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.btactualizar = new System.Windows.Forms.Button();
            this.btrefrescar = new System.Windows.Forms.Button();
            this.btseleccionar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dg_datos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(72, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHACHA:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(180, 105);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(157, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(34, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "INGREDIENTE:";
            // 
            // ComboBoxIngrediente
            // 
            this.ComboBoxIngrediente.FormattingEnabled = true;
            this.ComboBoxIngrediente.Location = new System.Drawing.Point(180, 171);
            this.ComboBoxIngrediente.Name = "ComboBoxIngrediente";
            this.ComboBoxIngrediente.Size = new System.Drawing.Size(157, 21);
            this.ComboBoxIngrediente.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(60, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "CANTIDAD:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtcantidad
            // 
            this.txtcantidad.Location = new System.Drawing.Point(180, 235);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(157, 20);
            this.txtcantidad.TabIndex = 6;
            // 
            // bteliminar
            // 
            this.bteliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bteliminar.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bteliminar.ForeColor = System.Drawing.Color.White;
            this.bteliminar.Location = new System.Drawing.Point(59, 346);
            this.bteliminar.Name = "bteliminar";
            this.bteliminar.Size = new System.Drawing.Size(121, 43);
            this.bteliminar.TabIndex = 9;
            this.bteliminar.Text = "ELIMINAR";
            this.bteliminar.UseVisualStyleBackColor = false;
            this.bteliminar.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button3.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(108, 291);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(229, 40);
            this.button3.TabIndex = 10;
            this.button3.Text = "GUARDAR INFORMACION";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dg_datos
            // 
            this.dg_datos.AccessibleDescription = "dg_datos";
            this.dg_datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_datos.Location = new System.Drawing.Point(415, 44);
            this.dg_datos.Name = "dg_datos";
            this.dg_datos.Size = new System.Drawing.Size(344, 275);
            this.dg_datos.TabIndex = 11;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button4.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(688, 392);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(95, 26);
            this.button4.TabIndex = 12;
            this.button4.Text = "VOLVER";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btactualizar
            // 
            this.btactualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btactualizar.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btactualizar.ForeColor = System.Drawing.Color.White;
            this.btactualizar.Location = new System.Drawing.Point(262, 346);
            this.btactualizar.Margin = new System.Windows.Forms.Padding(2);
            this.btactualizar.Name = "btactualizar";
            this.btactualizar.Size = new System.Drawing.Size(126, 43);
            this.btactualizar.TabIndex = 13;
            this.btactualizar.Text = "ACTUALIZAR";
            this.btactualizar.UseVisualStyleBackColor = false;
            // 
            // btrefrescar
            // 
            this.btrefrescar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btrefrescar.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btrefrescar.ForeColor = System.Drawing.Color.White;
            this.btrefrescar.Location = new System.Drawing.Point(415, 293);
            this.btrefrescar.Margin = new System.Windows.Forms.Padding(2);
            this.btrefrescar.Name = "btrefrescar";
            this.btrefrescar.Size = new System.Drawing.Size(100, 26);
            this.btrefrescar.TabIndex = 14;
            this.btrefrescar.Text = "REFRESCAR";
            this.btrefrescar.UseVisualStyleBackColor = false;
            // 
            // btseleccionar
            // 
            this.btseleccionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btseleccionar.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btseleccionar.ForeColor = System.Drawing.Color.White;
            this.btseleccionar.Location = new System.Drawing.Point(527, 346);
            this.btseleccionar.Margin = new System.Windows.Forms.Padding(2);
            this.btseleccionar.Name = "btseleccionar";
            this.btseleccionar.Size = new System.Drawing.Size(142, 43);
            this.btseleccionar.TabIndex = 15;
            this.btseleccionar.Text = "SELECCIONAR";
            this.btseleccionar.UseVisualStyleBackColor = false;
            this.btseleccionar.Click += new System.EventHandler(this.btseleccionar_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(174, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(451, 31);
            this.label4.TabIndex = 17;
            this.label4.Text = "ADMINISTRACIÓN DE RECETAS";
            // 
            // FRECETA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(780, 416);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btseleccionar);
            this.Controls.Add(this.btrefrescar);
            this.Controls.Add(this.btactualizar);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dg_datos);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.bteliminar);
            this.Controls.Add(this.txtcantidad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ComboBoxIngrediente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Name = "FRECETA";
            this.Text = "RECETA";
            this.Load += new System.EventHandler(this.FRECETA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_datos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ComboBoxIngrediente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.Button bteliminar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dg_datos;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btactualizar;
        private System.Windows.Forms.Button btrefrescar;
        private System.Windows.Forms.Button btseleccionar;
        private System.Windows.Forms.Label label4;
    }
}