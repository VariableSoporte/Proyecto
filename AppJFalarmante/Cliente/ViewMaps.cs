using System;
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
using Entidad;

namespace Cliente
{
    public partial class ViewMaps : Form
    {
        GMarkerGoogle marker;
        GMapOverlay markerOverlay;
        DataTable dt;

        //Ruta automatizada(direccion)
        bool trazarRuta = false;
        int ConntadorIndicadoresRuta = 0;
        PointLatLng inicio;
        PointLatLng final;

        int filaSeleccionada = 0;
        double latInicial = -0.241698501901652;
        double lngInicial = -78.42041015625;
        public ViewMaps()
        {
            InitializeComponent();
            mostrarMap();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        public void mostrarMap()
        {
            //GMAP
            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.CanDragMap = true;
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
            gMapControl1.Position = new PointLatLng(latInicial, lngInicial);
            gMapControl1.MinZoom = 0;
            gMapControl1.MaxZoom = 24;
            gMapControl1.Zoom = 10;
            gMapControl1.AutoScroll = true;
            
        }

        public void llenarPuntosMapas(List<NodoEntidad> listaNodos)
        {
            foreach (var item in listaNodos)
            {
                if (item != null)
                {
                //Marcador 
                markerOverlay = new GMapOverlay("Marcador");
                marker = new GMarkerGoogle(new PointLatLng(Convert.ToDouble(item.Latitud), Convert.ToDouble(item.Longitud)), GMarkerGoogleType.red_big_stop);
                markerOverlay.Markers.Add(marker); //agregamos mapa

                //texto al marcador
                marker.ToolTipMode = MarkerTooltipMode.OnMouseOver;
                marker.ToolTipText = String.Format("{2}: \n Latitud: {0}\n Longitud: {1}\nEmergencia: {3}", item.Latitud, item.Longitud, item.Nodo, item.Telefono);

                //agregar al mapa
                gMapControl1.Overlays.Add(markerOverlay);
                }
            }
        }

        public void mostrarNodo(NodoEntidad nodo)
        {
            //Marcador 
            markerOverlay = new GMapOverlay("Marcador");
            marker = new GMarkerGoogle(new PointLatLng(Convert.ToDouble(nodo.Latitud), Convert.ToDouble(nodo.Longitud)), GMarkerGoogleType.red_big_stop);
            markerOverlay.Markers.Add(marker); //agregamos mapa

            //texto al marcador
            marker.ToolTipMode = MarkerTooltipMode.OnMouseOver;
            marker.ToolTipText = String.Format("{2}: \n Latitud: {0}\n Longitud: {1}\nEmergencia: {3}", nodo.Latitud, nodo.Longitud, nodo.Nodo, nodo.Telefono);

            //agregar al mapa
            gMapControl1.Overlays.Add(markerOverlay);
        }

        internal void unNodo(NodoEntidad nodo)
        {
            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.CanDragMap = true;
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
            gMapControl1.Position = new PointLatLng(Convert.ToDouble(nodo.Latitud), Convert.ToDouble(nodo.Longitud));
            gMapControl1.MinZoom = 0;
            gMapControl1.MaxZoom = 24;
            gMapControl1.Zoom = 14;
            gMapControl1.AutoScroll = true;
        }
    }
}
