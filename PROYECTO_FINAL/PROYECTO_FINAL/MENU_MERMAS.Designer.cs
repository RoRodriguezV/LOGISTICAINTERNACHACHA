namespace PROYECTO_FINAL
{
    partial class MENU_MERMAS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MENU_MERMAS));
            this.bt_cantidades = new System.Windows.Forms.Button();
            this.bt_mapa = new System.Windows.Forms.Button();
            this.bt_volver = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_cantidades
            // 
            this.bt_cantidades.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bt_cantidades.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cantidades.ForeColor = System.Drawing.Color.White;
            this.bt_cantidades.Location = new System.Drawing.Point(125, 238);
            this.bt_cantidades.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_cantidades.Name = "bt_cantidades";
            this.bt_cantidades.Size = new System.Drawing.Size(218, 78);
            this.bt_cantidades.TabIndex = 0;
            this.bt_cantidades.Text = "CANTIDAD DE INGREDIENTES PERDIDOS";
            this.bt_cantidades.UseVisualStyleBackColor = false;
            this.bt_cantidades.Click += new System.EventHandler(this.bt_cantidades_Click);
            // 
            // bt_mapa
            // 
            this.bt_mapa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bt_mapa.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_mapa.ForeColor = System.Drawing.Color.White;
            this.bt_mapa.Location = new System.Drawing.Point(125, 80);
            this.bt_mapa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_mapa.Name = "bt_mapa";
            this.bt_mapa.Size = new System.Drawing.Size(218, 66);
            this.bt_mapa.TabIndex = 0;
            this.bt_mapa.Text = "MAPA DE MERMAS";
            this.bt_mapa.UseVisualStyleBackColor = false;
            this.bt_mapa.Click += new System.EventHandler(this.bt_mapa_Click);
            // 
            // bt_volver
            // 
            this.bt_volver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bt_volver.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_volver.ForeColor = System.Drawing.Color.White;
            this.bt_volver.Location = new System.Drawing.Point(329, 333);
            this.bt_volver.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_volver.Name = "bt_volver";
            this.bt_volver.Size = new System.Drawing.Size(97, 29);
            this.bt_volver.TabIndex = 1;
            this.bt_volver.Text = "VOLVER";
            this.bt_volver.UseVisualStyleBackColor = false;
            this.bt_volver.Click += new System.EventHandler(this.bt_volver_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(125, 163);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(218, 59);
            this.button1.TabIndex = 2;
            this.button1.Text = "REGISTRO DE MERMAS";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MENU_MERMAS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(431, 362);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bt_volver);
            this.Controls.Add(this.bt_mapa);
            this.Controls.Add(this.bt_cantidades);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MENU_MERMAS";
            this.Text = "MENU_MERMAS";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_cantidades;
        private System.Windows.Forms.Button bt_mapa;
        private System.Windows.Forms.Button bt_volver;
        private System.Windows.Forms.Button button1;
    }
}