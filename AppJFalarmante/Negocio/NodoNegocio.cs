using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidad;

namespace Negocio
{
    public static class NodoNegocio
    {
        public static async Task<List<NodoEntidad>> DevolverNodos()
        {
            return  await NodoDatos.DevolverNodosAsync();
        }

        public static async Task<NodoEntidad> AgregarNodo(NodoEntidad nodo)
        {
            if (nodo.Id != -7)
            {
                return await NodoDatos.ActualizarNodo(nodo);
            }
            else
            {
                return await NodoDatos.AgregarNodo(nodo);
            }
        }

        public static async Task<NodoEntidad> EliminarNodo(NodoEntidad nodo)
        {
            return await NodoDatos.EliminarNodo(nodo);
        }
    }
}
