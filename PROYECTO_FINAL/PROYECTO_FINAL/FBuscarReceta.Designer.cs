namespace PROYECTO_FINAL
{
    partial class FBuscarReceta
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
            this.cbxReceta = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvBuscarReceta = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarReceta)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxReceta
            // 
            this.cbxReceta.Location = new System.Drawing.Point(165, 134);
            this.cbxReceta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxReceta.Name = "cbxReceta";
            this.cbxReceta.Size = new System.Drawing.Size(180, 28);
            this.cbxReceta.TabIndex = 0;
            this.cbxReceta.SelectedIndexChanged += new System.EventHandler(this.cbxReceta_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 137);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "RECETA:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(106, 382);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 77);
            this.button1.TabIndex = 2;
            this.button1.Text = "BUSCAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvBuscarReceta
            // 
            this.dgvBuscarReceta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuscarReceta.Location = new System.Drawing.Point(374, 25);
            this.dgvBuscarReceta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvBuscarReceta.Name = "dgvBuscarReceta";
            this.dgvBuscarReceta.Size = new System.Drawing.Size(504, 345);
            this.dgvBuscarReceta.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button2.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(729, 411);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 48);
            this.button2.TabIndex = 4;
            this.button2.Text = "VOLVER";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FBuscarReceta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(892, 477);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dgvBuscarReceta);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxReceta);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FBuscarReceta";
            this.Text = "BUSCAR RECETA";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarReceta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxReceta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvBuscarReceta;
        private System.Windows.Forms.Button button2;
    }
}