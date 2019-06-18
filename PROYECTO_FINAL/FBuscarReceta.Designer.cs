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
            this.cbxReceta.FormattingEnabled = true;
            this.cbxReceta.Location = new System.Drawing.Point(110, 87);
            this.cbxReceta.Name = "cbxReceta";
            this.cbxReceta.Size = new System.Drawing.Size(121, 21);
            this.cbxReceta.TabIndex = 0;
            this.cbxReceta.SelectedIndexChanged += new System.EventHandler(this.cbxReceta_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "RECETA:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(71, 248);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 50);
            this.button1.TabIndex = 2;
            this.button1.Text = "BUSCAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvBuscarReceta
            // 
            this.dgvBuscarReceta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuscarReceta.Location = new System.Drawing.Point(249, 16);
            this.dgvBuscarReceta.Name = "dgvBuscarReceta";
            this.dgvBuscarReceta.Size = new System.Drawing.Size(336, 224);
            this.dgvBuscarReceta.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button2.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(486, 267);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 31);
            this.button2.TabIndex = 4;
            this.button2.Text = "VOLVER";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FBuscarReceta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(595, 310);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dgvBuscarReceta);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxReceta);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "FBuscarReceta";
            this.Text = "Buscar Receta";
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