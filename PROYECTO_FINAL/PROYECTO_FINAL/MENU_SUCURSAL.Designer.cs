namespace PROYECTO_FINAL
{
    partial class MENU_SUCURSAL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MENU_SUCURSAL));
            this.bt_registrar = new System.Windows.Forms.Button();
            this.bt_volver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_registrar
            // 
            this.bt_registrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bt_registrar.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_registrar.ForeColor = System.Drawing.Color.White;
            this.bt_registrar.Location = new System.Drawing.Point(161, 177);
            this.bt_registrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_registrar.Name = "bt_registrar";
            this.bt_registrar.Size = new System.Drawing.Size(279, 103);
            this.bt_registrar.TabIndex = 0;
            this.bt_registrar.Text = "REGISTRAR - ACTUALIZAR SUCURSAL";
            this.bt_registrar.UseVisualStyleBackColor = false;
            this.bt_registrar.Click += new System.EventHandler(this.bt_registrar_Click);
            // 
            // bt_volver
            // 
            this.bt_volver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bt_volver.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_volver.ForeColor = System.Drawing.Color.White;
            this.bt_volver.Location = new System.Drawing.Point(456, 379);
            this.bt_volver.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_volver.Name = "bt_volver";
            this.bt_volver.Size = new System.Drawing.Size(119, 31);
            this.bt_volver.TabIndex = 0;
            this.bt_volver.Text = "VOLVER";
            this.bt_volver.UseVisualStyleBackColor = false;
            this.bt_volver.Click += new System.EventHandler(this.bt_volver_Click);
            // 
            // MENU_SUCURSAL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(587, 439);
            this.Controls.Add(this.bt_volver);
            this.Controls.Add(this.bt_registrar);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MENU_SUCURSAL";
            this.Text = "MENU SUCURSAL";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_registrar;
        private System.Windows.Forms.Button bt_volver;
    }
}