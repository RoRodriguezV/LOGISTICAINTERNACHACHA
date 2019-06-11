﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

namespace PROYECTO_FINAL
{
    public partial class MENU_CENTRAL_SUCURSAL : Form
    {
        GMarkerGoogle marker;
        GMapOverlay markerOverlay;
        DataTable dt;
        double LatInicial;
        double LngInicial;
        public sucursal LatSelec { get; set; }
        public MENU_CENTRAL_SUCURSAL()
        {
            InitializeComponent();

            label2.Text = ControlDeMerma.CodSucursal;

            dataGridView1.DataSource = BDconsultas.BuscarSucursales();
        }

        private void MENU_CENTRAL_SUCURSAL_Load(object sender, EventArgs e)
        {
            LatSelec = BDconsultas.ObtenerLat(label2.Text);
            LatInicial = LatSelec.Latitud;
            LngInicial = LatSelec.Longitud;
            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.CanDragMap = true;
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
            gMapControl1.Position = new PointLatLng(LatInicial, LngInicial);
            gMapControl1.MinZoom = 0;
            gMapControl1.MaxZoom = 24;
            gMapControl1.Zoom = 9;
            gMapControl1.AutoScroll = true;
            dataGridView1.Columns.Add("Distancia", "DISTANCIA");

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count == 1)
                {


                    string CodSucursal = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    string NombreSucursal = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    string DireccionSucursal = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                    LatInicial = Convert.ToDouble(dataGridView1.CurrentRow.Cells[3].Value);
                    LngInicial = Convert.ToDouble(dataGridView1.CurrentRow.Cells[4].Value);
                    markerOverlay = new GMapOverlay("Marcador");
                    marker = new GMarkerGoogle(new PointLatLng(LatInicial, LngInicial), GMarkerGoogleType.red);
                    markerOverlay.Markers.Add(marker);
                    marker.ToolTipMode = MarkerTooltipMode.Always;
                    marker.ToolTipText = String.Format("SUCURSAL:{0} \n DIRECCIÓN:{1} ", NombreSucursal, DireccionSucursal);
                    gMapControl1.Overlays.Add(markerOverlay);

                }
                else
                    MessageBox.Show("Debe de seleccionar una fila");
            }
            catch
            {
                MessageBox.Show("ERROR");
            }
        }
        
        private void button1_Click_1(object sender, EventArgs e)
        {
            ControlDeMerma contro = new ControlDeMerma();
            contro.Show();
            this.Hide();
        }

        private void btdistancias_Click(object sender, EventArgs e)
        {

            //Empezamos la formula de distancia entre dos puntos d(P1, P2)=raiz((x2-x1)^2 + (y2-y1)^2)
            double resultado = Math.Sqrt((Math.Pow(((Convert.ToDouble(dataGridView1.CurrentRow.Cells[3].Value) - LatInicial)), 2))+ (Math.Pow(((Convert.ToDouble(dataGridView1.CurrentRow.Cells[4].Value) - LngInicial)), 2)));
            dataGridView1.CurrentRow.Cells[6].Value = Convert.ToString(resultado);
        }
    }
}
