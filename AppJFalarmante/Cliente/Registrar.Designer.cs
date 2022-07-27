
namespace Cliente
{
    partial class Registrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registrar));
            this.panel1 = new System.Windows.Forms.Panel();
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.txtContraseña = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel8 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtUsuario = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtTelefono = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtLongitud = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.txtLatitud = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.txtApellido = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.txtNombre = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.txtNodo = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.txtId = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblId = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnAccion = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.imgIcon = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnCerrar = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.panel1.Controls.Add(this.gMapControl1);
            this.panel1.Controls.Add(this.txtContraseña);
            this.panel1.Controls.Add(this.bunifuCustomLabel8);
            this.panel1.Controls.Add(this.txtUsuario);
            this.panel1.Controls.Add(this.bunifuCustomLabel7);
            this.panel1.Controls.Add(this.txtTelefono);
            this.panel1.Controls.Add(this.bunifuCustomLabel6);
            this.panel1.Controls.Add(this.txtLongitud);
            this.panel1.Controls.Add(this.txtLatitud);
            this.panel1.Controls.Add(this.txtApellido);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.txtNodo);
            this.panel1.Controls.Add(this.txtId);
            this.panel1.Controls.Add(this.bunifuCustomLabel5);
            this.panel1.Controls.Add(this.bunifuCustomLabel4);
            this.panel1.Controls.Add(this.bunifuCustomLabel3);
            this.panel1.Controls.Add(this.bunifuCustomLabel2);
            this.panel1.Controls.Add(this.bunifuCustomLabel1);
            this.panel1.Controls.Add(this.lblId);
            this.panel1.Controls.Add(this.btnAccion);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 550);
            this.panel1.TabIndex = 0;
            // 
            // gMapControl1
            // 
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.LevelsKeepInMemmory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(273, 94);
            this.gMapControl1.MarkersEnabled = true;
            this.gMapControl1.MaxZoom = 2;
            this.gMapControl1.MinZoom = 2;
            this.gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl1.Name = "gMapControl1";
            this.gMapControl1.NegativeMode = false;
            this.gMapControl1.PolygonsEnabled = true;
            this.gMapControl1.RetryLoadTile = 0;
            this.gMapControl1.RoutesEnabled = true;
            this.gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl1.ShowTileGridLines = false;
            this.gMapControl1.Size = new System.Drawing.Size(415, 311);
            this.gMapControl1.TabIndex = 21;
            this.gMapControl1.Zoom = 0D;
            this.gMapControl1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gMapControl1_DoubleClick);
            // 
            // txtContraseña
            // 
            this.txtContraseña.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtContraseña.Location = new System.Drawing.Point(161, 464);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.Size = new System.Drawing.Size(155, 22);
            this.txtContraseña.TabIndex = 19;
            // 
            // bunifuCustomLabel8
            // 
            this.bunifuCustomLabel8.AutoSize = true;
            this.bunifuCustomLabel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel8.ForeColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel8.Location = new System.Drawing.Point(12, 460);
            this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
            this.bunifuCustomLabel8.Size = new System.Drawing.Size(143, 25);
            this.bunifuCustomLabel8.TabIndex = 18;
            this.bunifuCustomLabel8.Text = "Contraseña : ";
            this.bunifuCustomLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtUsuario
            // 
            this.txtUsuario.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtUsuario.Location = new System.Drawing.Point(161, 424);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(155, 22);
            this.txtUsuario.TabIndex = 17;
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel7.ForeColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(16, 424);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(105, 25);
            this.bunifuCustomLabel7.TabIndex = 16;
            this.bunifuCustomLabel7.Text = "Usuario : ";
            this.bunifuCustomLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTelefono
            // 
            this.txtTelefono.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtTelefono.Location = new System.Drawing.Point(132, 290);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(100, 22);
            this.txtTelefono.TabIndex = 15;
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.ForeColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(12, 290);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(116, 25);
            this.bunifuCustomLabel6.TabIndex = 14;
            this.bunifuCustomLabel6.Text = "Telefono : ";
            this.bunifuCustomLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtLongitud
            // 
            this.txtLongitud.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtLongitud.Enabled = false;
            this.txtLongitud.Location = new System.Drawing.Point(132, 258);
            this.txtLongitud.Name = "txtLongitud";
            this.txtLongitud.Size = new System.Drawing.Size(100, 22);
            this.txtLongitud.TabIndex = 13;
            // 
            // txtLatitud
            // 
            this.txtLatitud.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtLatitud.Enabled = false;
            this.txtLatitud.Location = new System.Drawing.Point(132, 225);
            this.txtLatitud.Name = "txtLatitud";
            this.txtLatitud.Size = new System.Drawing.Size(100, 22);
            this.txtLatitud.TabIndex = 12;
            // 
            // txtApellido
            // 
            this.txtApellido.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtApellido.Location = new System.Drawing.Point(132, 192);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 22);
            this.txtApellido.TabIndex = 11;
            // 
            // txtNombre
            // 
            this.txtNombre.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtNombre.Location = new System.Drawing.Point(132, 159);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 22);
            this.txtNombre.TabIndex = 10;
            // 
            // txtNodo
            // 
            this.txtNodo.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtNodo.Location = new System.Drawing.Point(132, 126);
            this.txtNodo.Name = "txtNodo";
            this.txtNodo.Size = new System.Drawing.Size(100, 22);
            this.txtNodo.TabIndex = 9;
            // 
            // txtId
            // 
            this.txtId.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(132, 93);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 22);
            this.txtId.TabIndex = 8;
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(12, 258);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(114, 25);
            this.bunifuCustomLabel5.TabIndex = 7;
            this.bunifuCustomLabel5.Text = "Longitud : ";
            this.bunifuCustomLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(12, 225);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(96, 25);
            this.bunifuCustomLabel4.TabIndex = 6;
            this.bunifuCustomLabel4.Text = "Latitud : ";
            this.bunifuCustomLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(12, 192);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(109, 25);
            this.bunifuCustomLabel3.TabIndex = 5;
            this.bunifuCustomLabel3.Text = "Apellido : ";
            this.bunifuCustomLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(12, 159);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(106, 25);
            this.bunifuCustomLabel2.TabIndex = 4;
            this.bunifuCustomLabel2.Text = "Nombre : ";
            this.bunifuCustomLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(12, 126);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(82, 25);
            this.bunifuCustomLabel1.TabIndex = 3;
            this.bunifuCustomLabel1.Text = "Nodo : ";
            this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.ForeColor = System.Drawing.Color.Transparent;
            this.lblId.Location = new System.Drawing.Point(12, 93);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(52, 25);
            this.lblId.TabIndex = 2;
            this.lblId.Text = "ID : ";
            this.lblId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAccion
            // 
            this.btnAccion.ActiveBorderThickness = 1;
            this.btnAccion.ActiveCornerRadius = 20;
            this.btnAccion.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnAccion.ActiveForecolor = System.Drawing.Color.White;
            this.btnAccion.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnAccion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.btnAccion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAccion.BackgroundImage")));
            this.btnAccion.ButtonText = "Registrarse";
            this.btnAccion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAccion.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccion.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnAccion.IdleBorderThickness = 1;
            this.btnAccion.IdleCornerRadius = 20;
            this.btnAccion.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnAccion.IdleForecolor = System.Drawing.Color.Transparent;
            this.btnAccion.IdleLineColor = System.Drawing.Color.White;
            this.btnAccion.Location = new System.Drawing.Point(185, 489);
            this.btnAccion.Margin = new System.Windows.Forms.Padding(5);
            this.btnAccion.Name = "btnAccion";
            this.btnAccion.Size = new System.Drawing.Size(352, 47);
            this.btnAccion.TabIndex = 1;
            this.btnAccion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAccion.Click += new System.EventHandler(this.btnAccion_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.panel2.Controls.Add(this.lblTitulo);
            this.panel2.Controls.Add(this.imgIcon);
            this.panel2.Controls.Add(this.btnCerrar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(700, 80);
            this.panel2.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("MS PGothic", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(266, 12);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(209, 38);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Registrarse";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imgIcon
            // 
            this.imgIcon.BackColor = System.Drawing.Color.Transparent;
            this.imgIcon.Image = ((System.Drawing.Image)(resources.GetObject("imgIcon.Image")));
            this.imgIcon.ImageActive = null;
            this.imgIcon.InitialImage = ((System.Drawing.Image)(resources.GetObject("imgIcon.InitialImage")));
            this.imgIcon.Location = new System.Drawing.Point(12, 12);
            this.imgIcon.Name = "imgIcon";
            this.imgIcon.Size = new System.Drawing.Size(70, 50);
            this.imgIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgIcon.TabIndex = 1;
            this.imgIcon.TabStop = false;
            this.imgIcon.Zoom = 10;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.ImageActive = null;
            this.btnCerrar.Location = new System.Drawing.Point(643, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(45, 45);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Zoom = 10;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel2;
            this.bunifuDragControl1.Vertical = true;
            // 
            // Registrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 550);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(700, 550);
            this.Name = "Registrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Registrar";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuImageButton btnCerrar;
        private System.Windows.Forms.Label lblTitulo;
        private Bunifu.Framework.UI.BunifuImageButton imgIcon;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAccion;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtNodo;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtId;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel lblId;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtTelefono;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtLongitud;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtLatitud;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtApellido;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtNombre;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtContraseña;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel8;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtUsuario;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private GMap.NET.WindowsForms.GMapControl gMapControl1;
    }
}