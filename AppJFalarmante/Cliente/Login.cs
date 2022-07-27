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


namespace Cliente
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estas seguro que quieres cerrar el programa?", "¡Alerta!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void valorContraseña()
        {
            txtContraseña.isPassword = true;
        }
        private async void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if ( txtUsuario.Text.Replace(" ","").Length < 12 &&
                 txtContraseña.Text.Length < 12 &&
                 txtContraseña.Text.Length > 0 &&
                 txtUsuario.Text.Replace(" ","").Length > 0)
            {
                if (await ingresoSistema(txtUsuario.Text.Replace(" ",""), txtContraseña.Text.Replace(" ", ""))){
                    Form1 vtnForm = new Form1();
                    this.Visible = false;
                    vtnForm.Show();
                    

                }else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos", "¡Alerta!", MessageBoxButtons.OK);
                    txtUsuario.Text = "";
                    txtContraseña.Text = "asd";

                }
            } else
            {
                MessageBox.Show("Los campos deben tener un maximo de 12 caracteres sin estar vacios", "¡Alerta!", MessageBoxButtons.OK);
                txtUsuario.Text = "";
                txtContraseña.Text = "asd";
                txtContraseña.isPassword = true;
            }
        }

        public async Task<Boolean> ingresoSistema(string usuario, string password)
        {
            List<PersonaEntidad> obj = await PersonaNegocio.administrador();
            Boolean acces = false;
            foreach (var item in obj)
            {
                if ( item != null)
                {
                    if ( item.usuario == usuario && item.contraseña == password)
                    {
                        acces = true;
                    }
                }
            }
            return acces;
        }
    }
}
