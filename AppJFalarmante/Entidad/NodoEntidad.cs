using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class NodoEntidad
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Usuario { get; set; }
        public string Contraseña { get; set; }
        public string Latitud { get; set; }
        public string Longitud { get; set; }
        public string Telefono { get; set; }
        public string Nodo { get; set; }
        public NodoEntidad()
        {

        }

        public NodoEntidad(int id, string nombre, string apellido, string usuario, 
                            string contraseña, string latitud, string longitud, string telefono, string nodo)
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
            Usuario = usuario;
            Contraseña = contraseña;
            Latitud = latitud;
            Longitud = longitud;
            Telefono = telefono;
            Nodo = nodo;
        }
    }
}
