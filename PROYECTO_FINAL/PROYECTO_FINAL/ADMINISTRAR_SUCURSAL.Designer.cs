namespace PROYECTO_FINAL
{
    partial class ADMINISTRAR_SUCURSAL
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtLatitud = new System.Windows.Forms.TextBox();
            this.txtLongitud = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.bt_guardar = new System.Windows.Forms.Button();
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.bt_buscar = new System.Windows.Forms.Button();
            this.bt_volver = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.trackZoom = new System.Windows.Forms.TrackBar();
            this.label9 = new System.Windows.Forms.Label();
            this.bt_satelital = new System.Windows.Forms.Button();
            this.bt_normal = new System.Windows.Forms.Button();
            this.bt_relieve = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.bt_eliminar = new System.Windows.Forms.Button();
            this.bt_actualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackZoom)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(395, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADMINISTRAR SUCURSALES";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.Location = new System.Drawing.Point(44, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "CÓDIGO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label3.Location = new System.Drawing.Point(40, 103);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "NOMBRE:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label4.Location = new System.Drawing.Point(32, 134);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "TELÉFONO:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label5.Location = new System.Drawing.Point(40, 164);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "LATITUD:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label6.Location = new System.Drawing.Point(32, 192);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "LONGITUD:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label7.Location = new System.Drawing.Point(28, 221);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "DIRECCIÓN:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(121, 73);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(162, 20);
            this.txtCodigo.TabIndex = 2;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(121, 99);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(162, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(121, 131);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(162, 20);
            this.txtTelefono.TabIndex = 2;
            // 
            // txtLatitud
            // 
            this.txtLatitud.Location = new System.Drawing.Point(121, 160);
            this.txtLatitud.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLatitud.Name = "txtLatitud";
            this.txtLatitud.Size = new System.Drawing.Size(162, 20);
            this.txtLatitud.TabIndex = 2;
            // 
            // txtLongitud
            // 
            this.txtLongitud.Location = new System.Drawing.Point(121, 191);
            this.txtLongitud.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLongitud.Name = "txtLongitud";
            this.txtLongitud.Size = new System.Drawing.Size(162, 20);
            this.txtLongitud.TabIndex = 2;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(121, 217);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(162, 20);
            this.txtDireccion.TabIndex = 2;
            // 
            // bt_guardar
            // 
            this.bt_guardar.Location = new System.Drawing.Point(92, 270);
            this.bt_guardar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_guardar.Name = "bt_guardar";
            this.bt_guardar.Size = new System.Drawing.Size(144, 60);
            this.bt_guardar.TabIndex = 3;
            this.bt_guardar.Text = "GUARDAR";
            this.bt_guardar.UseVisualStyleBackColor = true;
            this.bt_guardar.Click += new System.EventHandler(this.bt_guardar_Click);
            // 
            // gMapControl1
            // 
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.LevelsKeepInMemmory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(436, 10);
            this.gMapControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gMapControl1.MarkersEnabled = true;
            this.gMapControl1.MaxZoom = 2;
            this.gMapControl1.MinZoom = 2;
            this.gMapControl1.MouseWheelZoomEnabled = true;
            this.gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl1.Name = "gMapControl1";
            this.gMapControl1.NegativeMode = false;
            this.gMapControl1.PolygonsEnabled = true;
            this.gMapControl1.RetryLoadTile = 0;
            this.gMapControl1.RoutesEnabled = true;
            this.gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl1.ShowTileGridLines = false;
            this.gMapControl1.Size = new System.Drawing.Size(402, 524);
            this.gMapControl1.TabIndex = 5;
            this.gMapControl1.Zoom = 0D;
            this.gMapControl1.Load += new System.EventHandler(this.gMapControl1_Load);
            this.gMapControl1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gMapControl1_MouseDoubleClick_1);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(776, 10);
            this.webBrowser1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(15, 16);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(619, 617);
            this.webBrowser1.TabIndex = 6;
            // 
            // bt_buscar
            // 
            this.bt_buscar.Location = new System.Drawing.Point(295, 217);
            this.bt_buscar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_buscar.Name = "bt_buscar";
            this.bt_buscar.Size = new System.Drawing.Size(48, 19);
            this.bt_buscar.TabIndex = 7;
            this.bt_buscar.Text = "Buscar en mapa";
            this.bt_buscar.UseVisualStyleBackColor = true;
            this.bt_buscar.Click += new System.EventHandler(this.bt_buscar_Click);
            // 
            // bt_volver
            // 
            this.bt_volver.Location = new System.Drawing.Point(9, 608);
            this.bt_volver.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_volver.Name = "bt_volver";
            this.bt_volver.Size = new System.Drawing.Size(92, 19);
            this.bt_volver.TabIndex = 3;
            this.bt_volver.Text = "VOLVER";
            this.bt_volver.UseVisualStyleBackColor = true;
            this.bt_volver.Click += new System.EventHandler(this.bt_volver_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // trackZoom
            // 
            this.trackZoom.Location = new System.Drawing.Point(454, 557);
            this.trackZoom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.trackZoom.Maximum = 20;
            this.trackZoom.Name = "trackZoom";
            this.trackZoom.Size = new System.Drawing.Size(256, 45);
            this.trackZoom.TabIndex = 16;
            this.trackZoom.Value = 10;
            this.trackZoom.ValueChanged += new System.EventHandler(this.trackZoom_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(405, 566);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "ZOOM";
            // 
            // bt_satelital
            // 
            this.bt_satelital.Location = new System.Drawing.Point(530, 608);
            this.bt_satelital.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_satelital.Name = "bt_satelital";
            this.bt_satelital.Size = new System.Drawing.Size(78, 19);
            this.bt_satelital.TabIndex = 19;
            this.bt_satelital.Text = "SATELITAL";
            this.bt_satelital.UseVisualStyleBackColor = true;
            this.bt_satelital.Click += new System.EventHandler(this.bt_satelital_Click);
            // 
            // bt_normal
            // 
            this.bt_normal.Location = new System.Drawing.Point(407, 608);
            this.bt_normal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_normal.Name = "bt_normal";
            this.bt_normal.Size = new System.Drawing.Size(78, 19);
            this.bt_normal.TabIndex = 19;
            this.bt_normal.Text = "NORMAL";
            this.bt_normal.UseVisualStyleBackColor = true;
            this.bt_normal.Click += new System.EventHandler(this.bt_normal_Click);
            // 
            // bt_relieve
            // 
            this.bt_relieve.Location = new System.Drawing.Point(644, 608);
            this.bt_relieve.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_relieve.Name = "bt_relieve";
            this.bt_relieve.Size = new System.Drawing.Size(78, 19);
            this.bt_relieve.TabIndex = 19;
            this.bt_relieve.Text = "RELIEVE";
            this.bt_relieve.UseVisualStyleBackColor = true;
            this.bt_relieve.Click += new System.EventHandler(this.bt_relieve_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(92, 359);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 56);
            this.button1.TabIndex = 20;
            this.button1.Text = "BUSCAR SUCURSAL";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bt_eliminar
            // 
            this.bt_eliminar.Location = new System.Drawing.Point(92, 519);
            this.bt_eliminar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_eliminar.Name = "bt_eliminar";
            this.bt_eliminar.Size = new System.Drawing.Size(144, 60);
            this.bt_eliminar.TabIndex = 21;
            this.bt_eliminar.Text = "ELIMINAR";
            this.bt_eliminar.UseVisualStyleBackColor = true;
            this.bt_eliminar.Click += new System.EventHandler(this.bt_eliminar_Click);
            // 
            // bt_actualizar
            // 
            this.bt_actualizar.Location = new System.Drawing.Point(92, 437);
            this.bt_actualizar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_actualizar.Name = "bt_actualizar";
            this.bt_actualizar.Size = new System.Drawing.Size(144, 63);
            this.bt_actualizar.TabIndex = 22;
            this.bt_actualizar.Text = "ACTUALIZAR";
            this.bt_actualizar.UseVisualStyleBackColor = true;
            this.bt_actualizar.Click += new System.EventHandler(this.bt_actualizar_Click);
            // 
            // ADMINISTRAR_SUCURSAL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 602);
            this.Controls.Add(this.bt_actualizar);
            this.Controls.Add(this.bt_eliminar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bt_relieve);
            this.Controls.Add(this.bt_normal);
            this.Controls.Add(this.bt_satelital);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.trackZoom);
            this.Controls.Add(this.bt_buscar);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.gMapControl1);
            this.Controls.Add(this.bt_volver);
            this.Controls.Add(this.bt_guardar);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtLongitud);
            this.Controls.Add(this.txtLatitud);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ADMINISTRAR_SUCURSAL";
            this.Text = "ADMINISTRAR SUCURSALES";
            this.Load += new System.EventHandler(this.ADMINISTRAR_SUCURSAL_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackZoom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtLatitud;
        private System.Windows.Forms.TextBox txtLongitud;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Button bt_guardar;
        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button bt_buscar;
        private System.Windows.Forms.Button bt_volver;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TrackBar trackZoom;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button bt_satelital;
        private System.Windows.Forms.Button bt_normal;
        private System.Windows.Forms.Button bt_relieve;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bt_eliminar;
        private System.Windows.Forms.Button bt_actualizar;
    }
}