using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Entidad;


namespace Cliente
{
    public partial class Form1 : Form
    {
        int lx, ly;
        int sw, sh;

        private const int tamañoGrid = 10;
        private const int areaMouse = 132;
        private const int botonIzquierdo = 17;
        private Rectangle rectanguloGrid;

        private List<Bunifu.Framework.UI.BunifuCards> listaCards = new List<Bunifu.Framework.UI.BunifuCards>();
        private List<NodoEntidad> listaNodos = new List<NodoEntidad>();


        protected override void OnSizeChanged (EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, ClientRectangle.Width, ClientRectangle.Height));
            rectanguloGrid = new Rectangle(ClientRectangle.Width - tamañoGrid, ClientRectangle.Height - tamañoGrid, tamañoGrid, tamañoGrid);
            region.Exclude(rectanguloGrid);
            panel1.Region = region;
            Invalidate();
            
        }

        protected override void WndProc(ref Message sms)
        {
            switch (sms.Msg)
            {
                case areaMouse:
                    base.WndProc(ref sms);
                    var RefPoint = PointToClient(new Point(sms.LParam.ToInt32() & 0xffff, sms.LParam.ToInt32() >> 16));
                    if ( !rectanguloGrid.Contains(RefPoint))
                    {
                        break;
                    }
                    sms.Result = new IntPtr(botonIzquierdo);
                    break;
                default:
                    base.WndProc(ref sms);
                    break;
            }
        }


        private void btnMaxMin_Click(object sender, EventArgs e)
        {
            Size = new Size(sw, sh);
            Location = new Point(lx, ly);

            btnMaxMin.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;            
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estas seguro que quieres cerrar el programa?", "¡Alerta!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
                
        }



        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            lx = Location.X;
            ly = Location.Y;
            sw = Size.Width;
            sh = Size.Height;

            Size = Screen.PrimaryScreen.WorkingArea.Size;
            Location = Screen.PrimaryScreen.WorkingArea.Location;

            btnMaxMin.Visible = true;
            btnMaximizar.Visible = false;
        }

        public Form1()
        {
            InitializeComponent();

            cargarNodos();
            
        }

        public async Task<Boolean> cargarNodos()
        {
            flowLayoutPanel1.Controls.Clear();
            crdNodo.Visible = false;
            flowLayoutPanel1.AutoScroll = true;
            List<NodoEntidad> obj = await NodoNegocio.DevolverNodos();
            Console.WriteLine("antes del obj");
            listaNodos.Clear();
            listaNodos = obj;

            foreach (var nodo in obj)
            {
                if (nodo !=null)
                {
                flowLayoutPanel1.Controls.Add(crearContenedorCardView(nodo.Nodo,nodo.Nombre,nodo.Apellido,
                                                                        nodo.Latitud,nodo.Longitud, nodo.Id, nodo));
                }
                
            }
            return true;

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Registrar vntRegistrar = new Registrar();
            vntRegistrar.formularioObtenido(this);
            vntRegistrar.Show();
        }

        public Bunifu.Framework.UI.BunifuCards crearContenedorCardView(string nodo, string nombre, string apellido,
                                                                        string latitud, string longitud, int nodoId, NodoEntidad Usuario)
        {
            //creacion de componentes
            Bunifu.Framework.UI.BunifuCards crdNodo = new Bunifu.Framework.UI.BunifuCards();
            Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel8 = new Bunifu.Framework.UI.BunifuCustomLabel();
            Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel9 = new Bunifu.Framework.UI.BunifuCustomLabel();
            Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();

            Bunifu.Framework.UI.BunifuFlatButton btnEditar = new Bunifu.Framework.UI.BunifuFlatButton();
            Bunifu.Framework.UI.BunifuFlatButton btnEliminar = new Bunifu.Framework.UI.BunifuFlatButton();

            // 
            // bunifuCustomLabel5
            // 
            bunifuCustomLabel5.AutoSize = true;
            bunifuCustomLabel5.Location = new System.Drawing.Point(23, 90);
            bunifuCustomLabel5.Size = new System.Drawing.Size(75, 17);
            bunifuCustomLabel5.TabIndex = 5;
            bunifuCustomLabel5.Text = "Longitud : ";
            // 
            // bunifuCustomLabel4
            // 
            bunifuCustomLabel4.AutoSize = true;
            bunifuCustomLabel4.Location = new System.Drawing.Point(23, 70);
            bunifuCustomLabel4.Size = new System.Drawing.Size(63, 17);
            bunifuCustomLabel4.TabIndex = 4;
            bunifuCustomLabel4.Text = "Latitud : ";
            // 
            // bunifuCustomLabel3
            // 
            bunifuCustomLabel3.AutoSize = true;
            bunifuCustomLabel3.Location = new System.Drawing.Point(23, 50);
            bunifuCustomLabel3.Size = new System.Drawing.Size(70, 17);
            bunifuCustomLabel3.TabIndex = 3;
            bunifuCustomLabel3.Text = "Apellido : ";
            // 
            // bunifuCustomLabel2
            // 
            bunifuCustomLabel2.AutoSize = true;
            bunifuCustomLabel2.Location = new System.Drawing.Point(23, 30);
            bunifuCustomLabel2.Size = new System.Drawing.Size(70, 17);
            bunifuCustomLabel2.TabIndex = 2;
            bunifuCustomLabel2.Text = "Nombre : ";
            // 
            // bunifuCustomLabel1
            // 
            bunifuCustomLabel1.AutoSize = true;
            bunifuCustomLabel1.Location = new System.Drawing.Point(118, 11);
            bunifuCustomLabel1.Size = new System.Drawing.Size(42, 17);
            bunifuCustomLabel1.TabIndex = 1;
            bunifuCustomLabel1.Text = nodo;
            // 
            // bunifuCustomLabel9
            // 
            bunifuCustomLabel9.AutoSize = true;
            bunifuCustomLabel9.Location = new System.Drawing.Point(99, 70);
            bunifuCustomLabel9.Size = new System.Drawing.Size(117, 17);
            bunifuCustomLabel9.TabIndex = 10;
            bunifuCustomLabel9.Text = latitud;
            // 
            // bunifuCustomLabel8
            // 
            bunifuCustomLabel8.AutoSize = true;
            bunifuCustomLabel8.Location = new System.Drawing.Point(99, 90);
            bunifuCustomLabel8.Size = new System.Drawing.Size(105, 17);
            bunifuCustomLabel8.TabIndex = 9;
            bunifuCustomLabel8.Text = longitud;
            // 
            // bunifuCustomLabel7
            // 
            bunifuCustomLabel7.AutoSize = true;
            bunifuCustomLabel7.Location = new System.Drawing.Point(99, 51);
            bunifuCustomLabel7.Size = new System.Drawing.Size(112, 17);
            bunifuCustomLabel7.TabIndex = 8;
            bunifuCustomLabel7.Text = apellido;
            // 
            // bunifuCustomLabel6
            // 
            bunifuCustomLabel6.AutoSize = true;
            bunifuCustomLabel6.Location = new System.Drawing.Point(99, 30);
            bunifuCustomLabel6.Size = new System.Drawing.Size(112, 17);
            bunifuCustomLabel6.TabIndex = 7;
            bunifuCustomLabel6.Text = nombre;
            // 
            // bunifuFlatButton1
            // 
            bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            bunifuFlatButton1.BorderRadius = 15;
            bunifuFlatButton1.ButtonText = "Ver En Mapa";
            bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            bunifuFlatButton1.Iconimage_right = null;
            bunifuFlatButton1.Iconimage_right_Selected = null;
            bunifuFlatButton1.Iconimage_Selected = null;
            bunifuFlatButton1.IconMarginLeft = 0;
            bunifuFlatButton1.IconMarginRight = 0;
            bunifuFlatButton1.IconRightVisible = true;
            bunifuFlatButton1.IconRightZoom = 0D;
            bunifuFlatButton1.IconVisible = true;
            bunifuFlatButton1.IconZoom = 90D;
            bunifuFlatButton1.IsTab = false;
            bunifuFlatButton1.Location = new System.Drawing.Point(49, 119);
            bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            bunifuFlatButton1.selected = false;
            bunifuFlatButton1.Size = new System.Drawing.Size(190, 49);
            bunifuFlatButton1.TabIndex = 6;
            bunifuFlatButton1.Text = "Ver En Mapa";
            bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            bunifuFlatButton1.Click += (sendr, EventArgs) => { verEnMapa(sendr, EventArgs, Usuario); };

            // 
            // btnEditar
            // 
            btnEditar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnEditar.BorderRadius = 0;
            btnEditar.ButtonText = "Editar";
            btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            btnEditar.DisabledColor = System.Drawing.Color.Gray;
            btnEditar.Iconcolor = System.Drawing.Color.Transparent;
            btnEditar.Iconimage = null;
            btnEditar.Iconimage_right = null;
            btnEditar.Iconimage_right_Selected = null;
            btnEditar.Iconimage_Selected = null;
            btnEditar.IconMarginLeft = 0;
            btnEditar.IconMarginRight = 0;
            btnEditar.IconRightVisible = true;
            btnEditar.IconRightZoom = 0D;
            btnEditar.IconVisible = true;
            btnEditar.IconZoom = 90D;
            btnEditar.IsTab = false;
            btnEditar.Location = new System.Drawing.Point(49, 176);
            btnEditar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            btnEditar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            btnEditar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            btnEditar.OnHoverTextColor = System.Drawing.Color.White;
            btnEditar.selected = false;
            btnEditar.Size = new System.Drawing.Size(90, 49);
            btnEditar.TabIndex = 11;
            btnEditar.Text = "Editar";
            btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            btnEditar.Textcolor = System.Drawing.Color.White;
            btnEditar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnEditar.Click += (sendr, EventArgs) => { editarNodo(sendr, EventArgs, Usuario); };
            // 
            // btnEliminar
            // 
            btnEliminar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnEliminar.BorderRadius = 0;
            btnEliminar.ButtonText = "Eliminar";
            btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            btnEliminar.DisabledColor = System.Drawing.Color.Gray;
            btnEliminar.Iconcolor = System.Drawing.Color.Transparent;
            btnEliminar.Iconimage = null;
            btnEliminar.Iconimage_right = null;
            btnEliminar.Iconimage_right_Selected = null;
            btnEliminar.Iconimage_Selected = null;
            btnEliminar.IconMarginLeft = 0;
            btnEliminar.IconMarginRight = 0;
            btnEliminar.IconRightVisible = true;
            btnEliminar.IconRightZoom = 0D;
            btnEliminar.IconVisible = true;
            btnEliminar.IconZoom = 90D;
            btnEliminar.IsTab = false;
            btnEliminar.Location = new System.Drawing.Point(147, 176);
            btnEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            btnEliminar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            btnEliminar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            btnEliminar.OnHoverTextColor = System.Drawing.Color.White;
            btnEliminar.selected = false;
            btnEliminar.Size = new System.Drawing.Size(90, 49);
            btnEliminar.TabIndex = 12;
            btnEliminar.Text = "Eliminar";
            btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            btnEliminar.Textcolor = System.Drawing.Color.White;
            btnEliminar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnEliminar.Click += (sendr, EventArgs) => { eliminarNodo(sendr, EventArgs, Usuario); };


            //damos formato al card
            crdNodo.BackColor = System.Drawing.Color.White;
            crdNodo.BorderRadius = 5;
            crdNodo.BottomSahddow = true;
            listaCards.Add(crdNodo);

            //añadimos labels al card
            crdNodo.Controls.Add(btnEliminar);
            crdNodo.Controls.Add(btnEditar);
            crdNodo.Controls.Add(bunifuFlatButton1);
            crdNodo.Controls.Add(bunifuCustomLabel9);
            crdNodo.Controls.Add(bunifuCustomLabel8);
            crdNodo.Controls.Add(bunifuCustomLabel7);
            crdNodo.Controls.Add(bunifuCustomLabel6);
            crdNodo.Controls.Add(bunifuCustomLabel5);
            crdNodo.Controls.Add(bunifuCustomLabel4);
            crdNodo.Controls.Add(bunifuCustomLabel3);
            crdNodo.Controls.Add(bunifuCustomLabel2);
            crdNodo.Controls.Add(bunifuCustomLabel1);


            crdNodo.LeftSahddow = false;
            crdNodo.RightSahddow = true;
            crdNodo.ShadowDepth = 20;
            crdNodo.Size = new System.Drawing.Size(279, 234);
            return crdNodo;
        }

        private void eliminarNodo(object sendr, EventArgs eventArgs, NodoEntidad usuario)
        {
            if (MessageBox.Show($"¿Estas seguro que quieres eliminar el Nodo: {usuario.Nodo}?", "¡Alerta!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                NodoNegocio.EliminarNodo(usuario);                
                Console.WriteLine(usuario.Nombre+" Eliminado");
                cargarNodos();
            }
        }

        private void btnMapas_Click(object sender, EventArgs e)
        {
            ViewMaps vntMaps = new ViewMaps();
            vntMaps.llenarPuntosMapas(listaNodos);
            vntMaps.Show();
        }

        private void editarNodo(object sendr, EventArgs eventArgs, NodoEntidad usuario)
        {
            Registrar vntRegistrar = new Registrar();
            vntRegistrar.formularioObtenido(this);
            vntRegistrar.actualizarNodo(usuario);
            vntRegistrar.Show();
            Console.WriteLine(usuario.Nombre+" Editado");            
        }



        private void verEnMapa(object sender, EventArgs e, NodoEntidad nodo)
        {
            ViewMaps vntMaps = new ViewMaps();
            vntMaps.mostrarNodo(nodo);
            vntMaps.unNodo(nodo);
            vntMaps.Show();
        }

    }
}
