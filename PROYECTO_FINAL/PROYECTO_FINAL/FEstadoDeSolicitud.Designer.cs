namespace PROYECTO_FINAL
{
    partial class FEstadoDeSolicitud
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.btRechazar = new System.Windows.Forms.Button();
            this.btAceptar = new System.Windows.Forms.Button();
            this.dgv_stock = new System.Windows.Forms.DataGridView();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_stock)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(181, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 31);
            this.label1.TabIndex = 7;
            this.label1.Text = "ESTADO DE PEDIDO";
            // 
            // btRechazar
            // 
            this.btRechazar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btRechazar.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRechazar.ForeColor = System.Drawing.Color.White;
            this.btRechazar.Location = new System.Drawing.Point(444, 307);
            this.btRechazar.Name = "btRechazar";
            this.btRechazar.Size = new System.Drawing.Size(118, 47);
            this.btRechazar.TabIndex = 6;
            this.btRechazar.Text = "RECHAZAR";
            this.btRechazar.UseVisualStyleBackColor = false;
            this.btRechazar.Click += new System.EventHandler(this.btRechazar_Click);
            // 
            // btAceptar
            // 
            this.btAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btAceptar.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAceptar.ForeColor = System.Drawing.Color.White;
            this.btAceptar.Location = new System.Drawing.Point(108, 307);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(118, 44);
            this.btAceptar.TabIndex = 5;
            this.btAceptar.Text = "ACEPTAR";
            this.btAceptar.UseVisualStyleBackColor = false;
            this.btAceptar.Click += new System.EventHandler(this.btAceptar_Click);
            // 
            // dgv_stock
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Green;
            this.dgv_stock.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_stock.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_stock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_stock.Location = new System.Drawing.Point(108, 59);
            this.dgv_stock.Name = "dgv_stock";
            this.dgv_stock.ReadOnly = true;
            this.dgv_stock.Size = new System.Drawing.Size(454, 225);
            this.dgv_stock.TabIndex = 4;
            this.dgv_stock.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_stock_CellContentClick);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnVolver.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.Color.White;
            this.btnVolver.Location = new System.Drawing.Point(573, 385);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(106, 31);
            this.btnVolver.TabIndex = 49;
            this.btnVolver.Text = "VOLVER";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // FEstadoDeSolicitud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(678, 415);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btRechazar);
            this.Controls.Add(this.btAceptar);
            this.Controls.Add(this.dgv_stock);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FEstadoDeSolicitud";
            this.Text = "Estado De Solicitud";
            this.Load += new System.EventHandler(this.FEstadoDeSolicitud_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_stock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btRechazar;
        public System.Windows.Forms.Button btAceptar;
        public System.Windows.Forms.DataGridView dgv_stock;
        private System.Windows.Forms.Button btnVolver;
    }
}