namespace PROYECTO_FINAL
{
    partial class MENU_BORRARSUCURSAL
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.bt_msucurales = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 148);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(760, 367);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "CODIGO SUCURSAL";
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(175, 47);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(131, 22);
            this.txtcodigo.TabIndex = 3;
            // 
            // bt_msucurales
            // 
            this.bt_msucurales.Location = new System.Drawing.Point(452, 47);
            this.bt_msucurales.Name = "bt_msucurales";
            this.bt_msucurales.Size = new System.Drawing.Size(278, 68);
            this.bt_msucurales.TabIndex = 2;
            this.bt_msucurales.Text = "MOSTRAR TODAS LAS SUCURALES";
            this.bt_msucurales.UseVisualStyleBackColor = true;
            this.bt_msucurales.Click += new System.EventHandler(this.bt_msucurales_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(175, 82);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(131, 33);
            this.button3.TabIndex = 2;
            this.button3.Text = "BUSCAR";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // MENU_BORRARSUCURSAL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 555);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.bt_msucurales);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MENU_BORRARSUCURSAL";
            this.Text = "MENU_BORRARSUCURSAL";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Button bt_msucurales;
        private System.Windows.Forms.Button button3;
    }
}