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
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(397, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 33);
            this.label1.TabIndex = 7;
            this.label1.Text = "ESTADO DE PEDIDO";
            // 
            // btRechazar
            // 
            this.btRechazar.Location = new System.Drawing.Point(101, 267);
            this.btRechazar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btRechazar.Name = "btRechazar";
            this.btRechazar.Size = new System.Drawing.Size(158, 72);
            this.btRechazar.TabIndex = 6;
            this.btRechazar.Text = "RECHAZAR";
            this.btRechazar.UseVisualStyleBackColor = true;
            this.btRechazar.Click += new System.EventHandler(this.btRechazar_Click);
            // 
            // btAceptar
            // 
            this.btAceptar.Location = new System.Drawing.Point(101, 170);
            this.btAceptar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(158, 68);
            this.btAceptar.TabIndex = 5;
            this.btAceptar.Text = "ACEPTAR";
            this.btAceptar.UseVisualStyleBackColor = true;
            this.btAceptar.Click += new System.EventHandler(this.btAceptar_Click);
            // 
            // dgv_stock
            // 
            this.dgv_stock.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_stock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_stock.Location = new System.Drawing.Point(301, 122);
            this.dgv_stock.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgv_stock.Name = "dgv_stock";
            this.dgv_stock.Size = new System.Drawing.Size(615, 325);
            this.dgv_stock.TabIndex = 4;
            this.dgv_stock.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_stock_CellContentClick);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(887, 478);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(139, 48);
            this.btnVolver.TabIndex = 49;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // FEstadoDeSolicitud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 559);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btRechazar);
            this.Controls.Add(this.btAceptar);
            this.Controls.Add(this.dgv_stock);
            this.Name = "FEstadoDeSolicitud";
            this.Text = "FEstadoDeSolicitud";
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