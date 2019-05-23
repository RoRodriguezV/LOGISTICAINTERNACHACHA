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
            this.bt_asignar = new System.Windows.Forms.Button();
            this.bt_reporte = new System.Windows.Forms.Button();
            this.bt_volver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_asignar
            // 
            this.bt_asignar.Location = new System.Drawing.Point(177, 58);
            this.bt_asignar.Name = "bt_asignar";
            this.bt_asignar.Size = new System.Drawing.Size(264, 67);
            this.bt_asignar.TabIndex = 0;
            this.bt_asignar.Text = "ASIGNAR ENVIOS";
            this.bt_asignar.UseVisualStyleBackColor = true;
            // 
            // bt_reporte
            // 
            this.bt_reporte.Location = new System.Drawing.Point(177, 190);
            this.bt_reporte.Name = "bt_reporte";
            this.bt_reporte.Size = new System.Drawing.Size(264, 67);
            this.bt_reporte.TabIndex = 0;
            this.bt_reporte.Text = "REPORTE ENVIOS";
            this.bt_reporte.UseVisualStyleBackColor = true;
            // 
            // bt_volver
            // 
            this.bt_volver.Location = new System.Drawing.Point(448, 333);
            this.bt_volver.Name = "bt_volver";
            this.bt_volver.Size = new System.Drawing.Size(147, 29);
            this.bt_volver.TabIndex = 0;
            this.bt_volver.Text = "VOLVER";
            this.bt_volver.UseVisualStyleBackColor = true;
            this.bt_volver.Click += new System.EventHandler(this.bt_volver_Click);
            // 
            // MENU_ASIGNACION
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 374);
            this.Controls.Add(this.bt_volver);
            this.Controls.Add(this.bt_reporte);
            this.Controls.Add(this.bt_asignar);
            this.Name = "MENU_ASIGNACION";
            this.Text = "MENU_ASIGNACION";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_asignar;
        private System.Windows.Forms.Button bt_reporte;
        private System.Windows.Forms.Button bt_volver;
    }
}