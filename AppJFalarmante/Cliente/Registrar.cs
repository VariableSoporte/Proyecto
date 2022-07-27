using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidad;
using Negocio;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;


namespace Cliente
{
    public partial class Registrar : Form
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
        double latInicial = -0.228502144670955;
        double lngInicial = -78.4527897834778;

        Form1 formulario;
        public Registrar()
        {
            InitializeComponent();
            cargarMapaVacio();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnAccion_Click(object sender, EventArgs e)
        {
            if (txtApellido.Text.Replace(" ", "").Length != 0 && 
                txtContraseña.Text.Replace(" ","").Length != 0 &&
                txtLatitud.Text.Replace(" ","").Length != 0 &&
                txtLongitud.Text.Replace(" ","").Length != 0 &&
                txtNodo.Text.Replace(" ","").Length != 0 &&
                txtNombre.Text.Replace(" ","").Length != 0 &&
                txtTelefono.Text.Replace(" ","").Length != 0 &&
                txtUsuario.Text.Replace(" ","").Length != 0)
            {
                int id = (txtId.Text != "") ? Convert.ToInt32(txtId.Text) : -7 ;
                string nombre = txtNombre.Text.Replace(" ", "").Substring(0,1).ToUpper()+txtNombre.Text.Substring(1,txtNombre.Text.Length-1);
                string apellido = txtApellido.Text.Replace(" ", "").Substring(0, 1).ToUpper() + txtApellido.Text.Substring(1, txtApellido.Text.Length-1);
                string latitud = txtLatitud.Text.Replace(" ", "");
                string longitud = txtLongitud.Text.Replace(" ", "");
                string nodo = txtNodo.Text.Replace(" ", "").Substring(0, 1).ToUpper() + txtNodo.Text.Substring(1, txtNodo.Text.Length - 1);
                string usuario = txtUsuario.Text.Replace(" ", "");
                string contraseña = txtContraseña.Text.Replace(" ", "");
                string telefono = txtTelefono.Text.Replace(" ", "");

                NodoEntidad obj = new NodoEntidad(id,nombre,apellido,usuario,contraseña,latitud,longitud,telefono,nodo);
                obj = await agregarNodo(obj);

                await this.formulario.cargarNodos();

                this.Close();
            }else
            {
                MessageBox.Show("Deve llenar todos los campos anteriores", "¡Alerta!", MessageBoxButtons.OK);
            }
        }

        public void formularioObtenido(Form1 formulario)
        {
            this.formulario = formulario;
        }

        public async Task<NodoEntidad> agregarNodo(NodoEntidad nodo)
        {
            
            return await NodoNegocio.AgregarNodo(nodo);
        }

        internal void actualizarNodo(NodoEntidad usuario)
        {
            lblTitulo.Text = "Actualizar";
            txtApellido.Text = usuario.Apellido;
            txtContraseña.Text = usuario.Contraseña;
            txtId.Text = usuario.Id.ToString();
            txtLatitud.Text = usuario.Latitud;
            txtLongitud.Text = usuario.Longitud;
            txtNodo.Text = usuario.Nodo;
            txtNombre.Text = usuario.Nombre;
            txtTelefono.Text = usuario.Telefono;
            txtUsuario.Text = usuario.Usuario;
            btnAccion.ButtonText = "Actualizar";

            //GMAP
            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.CanDragMap = true;
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
            gMapControl1.Position = new PointLatLng(Convert.ToDouble(usuario.Latitud), Convert.ToDouble(usuario.Longitud));
            gMapControl1.MinZoom = 0;
            gMapControl1.MaxZoom = 24;
            gMapControl1.Zoom = 18;
            gMapControl1.AutoScroll = true;

            //Marcador 
            markerOverlay = new GMapOverlay("Marcador");
            marker = new GMarkerGoogle(new PointLatLng(Convert.ToDouble(usuario.Latitud), Convert.ToDouble(usuario.Longitud)), GMarkerGoogleType.green);
            markerOverlay.Markers.Add(marker); //agregamos mapa

            //texto al marcador
            marker.ToolTipMode = MarkerTooltipMode.OnMouseOver;
            marker.ToolTipText = String.Format("{2}: \n Latitud: {0}\n Longitud: {1}", usuario.Latitud, usuario.Longitud, txtNodo.Text);

            //agregar al mapa
            gMapControl1.Overlays.Add(markerOverlay);


        }

        public void cargarMapaVacio()
        {
            //GMAP
            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.CanDragMap = true;
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
            gMapControl1.Position = new PointLatLng(latInicial, lngInicial);
            gMapControl1.MinZoom = 0;
            gMapControl1.MaxZoom = 24;
            gMapControl1.Zoom = 18;
            gMapControl1.AutoScroll = true;

            //Marcador 
            markerOverlay = new GMapOverlay("Marcador");
            marker = new GMarkerGoogle(new PointLatLng(latInicial, lngInicial), GMarkerGoogleType.green);
            markerOverlay.Markers.Add(marker); //agregamos mapa

            //texto al marcador
            marker.ToolTipMode = MarkerTooltipMode.OnMouseOver;
            marker.ToolTipText = String.Format("Nuevo Nodo: \n Latitud: {0}\n Longitud: {1}", latInicial, lngInicial);

            //agregar al mapa
            gMapControl1.Overlays.Add(markerOverlay);
        }
        private void gMapControl1_DoubleClick(object sender, MouseEventArgs e)
        {
            double lat = gMapControl1.FromLocalToLatLng(e.X, e.Y).Lat;
            double lng = gMapControl1.FromLocalToLatLng(e.X, e.Y).Lng;

            txtLatitud.Text = lat.ToString();
            txtLongitud.Text = lng.ToString();

            marker.Position = new PointLatLng(lat, lng);

            marker.ToolTipText = string.Format("{0}:\nLatitud: {1}\nLongitud: {2}", txtNodo.Text, lat, lng);
        }
    }
}
