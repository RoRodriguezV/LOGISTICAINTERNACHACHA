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
            this.cbxReceta.Location = new System.Drawing.Point(95, 106);
            this.cbxReceta.Margin = new System.Windows.Forms.Padding(4);
            this.cbxReceta.Name = "cbxReceta";
            this.cbxReceta.Size = new System.Drawing.Size(160, 24);
            this.cbxReceta.TabIndex = 0;
            this.cbxReceta.SelectedIndexChanged += new System.EventHandler(this.cbxReceta_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 110);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "RECETA:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(120, 174);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 2;
            this.button1.Text = "BUSCAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvBuscarReceta
            // 
            this.dgvBuscarReceta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuscarReceta.Location = new System.Drawing.Point(315, 17);
            this.dgvBuscarReceta.Margin = new System.Windows.Forms.Padding(4);
            this.dgvBuscarReceta.Name = "dgvBuscarReceta";
            this.dgvBuscarReceta.Size = new System.Drawing.Size(448, 276);
            this.dgvBuscarReceta.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(648, 301);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "VOLVER";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FBuscarReceta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 346);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dgvBuscarReceta);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxReceta);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FBuscarReceta";
            this.Text = "FBuscarReceta";
            this.Load += new System.EventHandler(this.FBuscarReceta_Load);
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