namespace PROYECTO_FINAL
{
    partial class MENU_SUCURSALES
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MENU_SUCURSALES));
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.bt_volver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button2.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(139, 164);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(184, 58);
            this.button2.TabIndex = 3;
            this.button2.Text = "ENVIO";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(139, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 65);
            this.button1.TabIndex = 2;
            this.button1.Text = "PEDIDO";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button3.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(139, 255);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(184, 77);
            this.button3.TabIndex = 4;
            this.button3.Text = "PEDIDOS PENDIENTES";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // bt_volver
            // 
            this.bt_volver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bt_volver.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_volver.ForeColor = System.Drawing.Color.White;
            this.bt_volver.Location = new System.Drawing.Point(384, 370);
            this.bt_volver.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_volver.Name = "bt_volver";
            this.bt_volver.Size = new System.Drawing.Size(81, 24);
            this.bt_volver.TabIndex = 5;
            this.bt_volver.Text = "VOLVER";
            this.bt_volver.UseVisualStyleBackColor = false;
            this.bt_volver.Click += new System.EventHandler(this.bt_volver_Click);
            // 
            // MENU_SUCURSALES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(467, 394);
            this.Controls.Add(this.bt_volver);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MENU_SUCURSALES";
            this.Text = "MENU SUCURSALES";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button bt_volver;
    }
}