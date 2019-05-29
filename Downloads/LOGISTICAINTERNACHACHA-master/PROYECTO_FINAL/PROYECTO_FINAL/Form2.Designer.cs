namespace PROYECTO_FINAL
{
    partial class Form2
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxCantidad = new System.Windows.Forms.TextBox();
            this.txtBoxMedida = new System.Windows.Forms.TextBox();
            this.btnAgregar1 = new System.Windows.Forms.Button();
            this.btnEliminar2 = new System.Windows.Forms.Button();
            this.dg_datos = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ComboBoxIngrediente = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg_datos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHACHA:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Medida:";
            // 
            // txtBoxCantidad
            // 
            this.txtBoxCantidad.Location = new System.Drawing.Point(29, 176);
            this.txtBoxCantidad.Name = "txtBoxCantidad";
            this.txtBoxCantidad.Size = new System.Drawing.Size(96, 20);
            this.txtBoxCantidad.TabIndex = 2;
            this.txtBoxCantidad.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtBoxMedida
            // 
            this.txtBoxMedida.Location = new System.Drawing.Point(143, 176);
            this.txtBoxMedida.Name = "txtBoxMedida";
            this.txtBoxMedida.Size = new System.Drawing.Size(71, 20);
            this.txtBoxMedida.TabIndex = 3;
            this.txtBoxMedida.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnAgregar1
            // 
            this.btnAgregar1.Location = new System.Drawing.Point(236, 160);
            this.btnAgregar1.Name = "btnAgregar1";
            this.btnAgregar1.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar1.TabIndex = 4;
            this.btnAgregar1.Text = "AGREGAR";
            this.btnAgregar1.UseVisualStyleBackColor = true;
            this.btnAgregar1.Click += new System.EventHandler(this.btnAgregar1_Click);
            // 
            // btnEliminar2
            // 
            this.btnEliminar2.Location = new System.Drawing.Point(236, 201);
            this.btnEliminar2.Name = "btnEliminar2";
            this.btnEliminar2.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar2.TabIndex = 5;
            this.btnEliminar2.Text = "ELIMINAR";
            this.btnEliminar2.UseVisualStyleBackColor = true;
            this.btnEliminar2.Click += new System.EventHandler(this.btnEliminar2_Click);
            // 
            // dg_datos
            // 
            this.dg_datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_datos.Location = new System.Drawing.Point(328, 27);
            this.dg_datos.Name = "dg_datos";
            this.dg_datos.Size = new System.Drawing.Size(389, 261);
            this.dg_datos.TabIndex = 6;
            this.dg_datos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_datos_CellClick);
            this.dg_datos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_datos_CellContentClick);
            this.dg_datos.Click += new System.EventHandler(this.dg_datos_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(90, 27);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(124, 21);
            this.comboBox1.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "INGREDIENTE:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // ComboBoxIngrediente
            // 
            this.ComboBoxIngrediente.FormattingEnabled = true;
            this.ComboBoxIngrediente.Location = new System.Drawing.Point(90, 95);
            this.ComboBoxIngrediente.Name = "ComboBoxIngrediente";
            this.ComboBoxIngrediente.Size = new System.Drawing.Size(124, 21);
            this.ComboBoxIngrediente.TabIndex = 11;
            this.ComboBoxIngrediente.SelectedIndexChanged += new System.EventHandler(this.ComboBoxIngrediente_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Cantidad:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(149, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 13;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Monospac821 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(104, 249);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(145, 55);
            this.btnGuardar.TabIndex = 14;
            this.btnGuardar.Text = "GUARDAR INFORMACION\r\n";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 316);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ComboBoxIngrediente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dg_datos);
            this.Controls.Add(this.btnEliminar2);
            this.Controls.Add(this.btnAgregar1);
            this.Controls.Add(this.txtBoxMedida);
            this.Controls.Add(this.txtBoxCantidad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_datos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxCantidad;
        private System.Windows.Forms.TextBox txtBoxMedida;
        private System.Windows.Forms.Button btnAgregar1;
        private System.Windows.Forms.Button btnEliminar2;
        private System.Windows.Forms.DataGridView dg_datos;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ComboBoxIngrediente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnGuardar;
    }
}