namespace PROYECTO_FINAL
{
    partial class MENU_ASIGNACION
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MENU_ASIGNACION));
            this.bt_asignar = new System.Windows.Forms.Button();
            this.bt_reporte = new System.Windows.Forms.Button();
            this.bt_volver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_asignar
            // 
            this.bt_asignar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bt_asignar.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_asignar.ForeColor = System.Drawing.Color.White;
            this.bt_asignar.Location = new System.Drawing.Point(131, 107);
            this.bt_asignar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.bt_asignar.Name = "bt_asignar";
            this.bt_asignar.Size = new System.Drawing.Size(198, 55);
            this.bt_asignar.TabIndex = 0;
            this.bt_asignar.Text = "ASIGNAR ENVIOS";
            this.bt_asignar.UseVisualStyleBackColor = false;
            this.bt_asignar.Click += new System.EventHandler(this.bt_asignar_Click);
            // 
            // bt_reporte
            // 
            this.bt_reporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bt_reporte.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_reporte.ForeColor = System.Drawing.Color.White;
            this.bt_reporte.Location = new System.Drawing.Point(131, 211);
            this.bt_reporte.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.bt_reporte.Name = "bt_reporte";
            this.bt_reporte.Size = new System.Drawing.Size(198, 55);
            this.bt_reporte.TabIndex = 0;
            this.bt_reporte.Text = "REPORTE ENVIOS";
            this.bt_reporte.UseVisualStyleBackColor = false;
            this.bt_reporte.Click += new System.EventHandler(this.bt_reporte_Click);
            // 
            // bt_volver
            // 
            this.bt_volver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bt_volver.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_volver.ForeColor = System.Drawing.Color.White;
            this.bt_volver.Location = new System.Drawing.Point(350, 302);
            this.bt_volver.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.bt_volver.Name = "bt_volver";
            this.bt_volver.Size = new System.Drawing.Size(94, 23);
            this.bt_volver.TabIndex = 0;
            this.bt_volver.Text = "VOLVER";
            this.bt_volver.UseVisualStyleBackColor = false;
            this.bt_volver.Click += new System.EventHandler(this.bt_volver_Click);
            // 
            // MENU_ASIGNACION
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(455, 337);
            this.Controls.Add(this.bt_volver);
            this.Controls.Add(this.bt_reporte);
            this.Controls.Add(this.bt_asignar);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "MENU_ASIGNACION";
            this.Text = "MENU ASIGNACION";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_asignar;
        private System.Windows.Forms.Button bt_reporte;
        private System.Windows.Forms.Button bt_volver;
    }
}