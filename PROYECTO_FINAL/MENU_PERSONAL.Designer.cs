namespace PROYECTO_FINAL
{
    partial class MENU_PERSONAL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MENU_PERSONAL));
            this.button1 = new System.Windows.Forms.Button();
            this.bt_volver = new System.Windows.Forms.Button();
            this.bt_asig = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(144, 41);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 80);
            this.button1.TabIndex = 0;
            this.button1.Text = "REGISTRAR - ACTUALIZAR A PERSONAL";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bt_volver
            // 
            this.bt_volver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bt_volver.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_volver.ForeColor = System.Drawing.Color.White;
            this.bt_volver.Location = new System.Drawing.Point(388, 295);
            this.bt_volver.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_volver.Name = "bt_volver";
            this.bt_volver.Size = new System.Drawing.Size(91, 23);
            this.bt_volver.TabIndex = 0;
            this.bt_volver.Text = "VOLVER";
            this.bt_volver.UseVisualStyleBackColor = false;
            this.bt_volver.Click += new System.EventHandler(this.bt_volver_Click);
            // 
            // bt_asig
            // 
            this.bt_asig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bt_asig.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_asig.ForeColor = System.Drawing.Color.White;
            this.bt_asig.Location = new System.Drawing.Point(144, 183);
            this.bt_asig.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_asig.Name = "bt_asig";
            this.bt_asig.Size = new System.Drawing.Size(196, 87);
            this.bt_asig.TabIndex = 1;
            this.bt_asig.Text = "ASIGNAR ROLES";
            this.bt_asig.UseVisualStyleBackColor = false;
            this.bt_asig.Click += new System.EventHandler(this.bt_asig_Click);
            // 
            // MENU_PERSONAL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(490, 319);
            this.Controls.Add(this.bt_asig);
            this.Controls.Add(this.bt_volver);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MENU_PERSONAL";
            this.Text = "MENU PERSONAL";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bt_volver;
        private System.Windows.Forms.Button bt_asig;
    }
}