namespace PROYECTO_FINAL
{
    partial class ForMermas
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.bt_eliminar = new System.Windows.Forms.Button();
            this.bt_registrar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comBoxCodSucur = new System.Windows.Forms.ComboBox();
            this.comBoxCodPro = new System.Windows.Forms.ComboBox();
            this.textBoxCantMer = new System.Windows.Forms.TextBox();
            this.REGISTRAR = new System.Windows.Forms.Button();
            this.VOLVER = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "FECHA INICIO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "CANTIDAD MERMA:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "CODIGO PRODUCTO:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label5.Location = new System.Drawing.Point(47, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "CÓDIGO SUCURSAL:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(206, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(378, 36);
            this.label6.TabIndex = 7;
            this.label6.Text = "REGISTRO DE MERMAS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 304);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "FECHA FINAL:";
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Location = new System.Drawing.Point(212, 264);
            this.dtpFechaInicio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(345, 22);
            this.dtpFechaInicio.TabIndex = 42;
            // 
            // dtpFechaFinal
            // 
            this.dtpFechaFinal.Location = new System.Drawing.Point(212, 304);
            this.dtpFechaFinal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpFechaFinal.Name = "dtpFechaFinal";
            this.dtpFechaFinal.Size = new System.Drawing.Size(345, 22);
            this.dtpFechaFinal.TabIndex = 43;
            // 
            // bt_eliminar
            // 
            this.bt_eliminar.Location = new System.Drawing.Point(423, 358);
            this.bt_eliminar.Name = "bt_eliminar";
            this.bt_eliminar.Size = new System.Drawing.Size(134, 56);
            this.bt_eliminar.TabIndex = 44;
            this.bt_eliminar.Text = "ELIMINAR";
            this.bt_eliminar.UseVisualStyleBackColor = true;
            this.bt_eliminar.Click += new System.EventHandler(this.bt_eliminar_Click);
            // 
            // bt_registrar
            // 
            this.bt_registrar.Location = new System.Drawing.Point(213, 358);
            this.bt_registrar.Name = "bt_registrar";
            this.bt_registrar.Size = new System.Drawing.Size(122, 56);
            this.bt_registrar.TabIndex = 46;
            this.bt_registrar.Text = "AGREGAR";
            this.bt_registrar.UseVisualStyleBackColor = true;
            this.bt_registrar.Click += new System.EventHandler(this.bt_registrar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(619, 95);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(462, 287);
            this.dataGridView1.TabIndex = 47;
            // 
            // comBoxCodSucur
            // 
            this.comBoxCodSucur.FormattingEnabled = true;
            this.comBoxCodSucur.Location = new System.Drawing.Point(212, 95);
            this.comBoxCodSucur.Name = "comBoxCodSucur";
            this.comBoxCodSucur.Size = new System.Drawing.Size(345, 24);
            this.comBoxCodSucur.TabIndex = 48;
            // 
            // comBoxCodPro
            // 
            this.comBoxCodPro.FormattingEnabled = true;
            this.comBoxCodPro.Location = new System.Drawing.Point(212, 148);
            this.comBoxCodPro.Name = "comBoxCodPro";
            this.comBoxCodPro.Size = new System.Drawing.Size(345, 24);
            this.comBoxCodPro.TabIndex = 49;
            // 
            // textBoxCantMer
            // 
            this.textBoxCantMer.Location = new System.Drawing.Point(212, 208);
            this.textBoxCantMer.Name = "textBoxCantMer";
            this.textBoxCantMer.Size = new System.Drawing.Size(345, 22);
            this.textBoxCantMer.TabIndex = 50;
            // 
            // REGISTRAR
            // 
            this.REGISTRAR.Location = new System.Drawing.Point(661, 415);
            this.REGISTRAR.Name = "REGISTRAR";
            this.REGISTRAR.Size = new System.Drawing.Size(113, 51);
            this.REGISTRAR.TabIndex = 51;
            this.REGISTRAR.Text = "REGISTRAR";
            this.REGISTRAR.UseVisualStyleBackColor = true;
            this.REGISTRAR.Click += new System.EventHandler(this.REGISTRAR_Click);
            // 
            // VOLVER
            // 
            this.VOLVER.Location = new System.Drawing.Point(908, 415);
            this.VOLVER.Name = "VOLVER";
            this.VOLVER.Size = new System.Drawing.Size(101, 51);
            this.VOLVER.TabIndex = 52;
            this.VOLVER.Text = "VOLVER";
            this.VOLVER.UseVisualStyleBackColor = true;
            this.VOLVER.Click += new System.EventHandler(this.VOLVER_Click);
            // 
            // ForMermas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 499);
            this.Controls.Add(this.VOLVER);
            this.Controls.Add(this.REGISTRAR);
            this.Controls.Add(this.textBoxCantMer);
            this.Controls.Add(this.comBoxCodPro);
            this.Controls.Add(this.comBoxCodSucur);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bt_eliminar);
            this.Controls.Add(this.bt_registrar);
            this.Controls.Add(this.dtpFechaFinal);
            this.Controls.Add(this.dtpFechaInicio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Name = "ForMermas";
            this.Text = "ForMermas";
            this.Load += new System.EventHandler(this.ForMermas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.DateTimePicker dtpFechaFinal;
        private System.Windows.Forms.Button bt_eliminar;
        private System.Windows.Forms.Button bt_registrar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comBoxCodSucur;
        private System.Windows.Forms.ComboBox comBoxCodPro;
        private System.Windows.Forms.TextBox textBoxCantMer;
        private System.Windows.Forms.Button REGISTRAR;
        private System.Windows.Forms.Button VOLVER;
    }
}