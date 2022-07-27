using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;
using System.Text.Json;
using System.Net.Http;
using FireSharp.Interfaces;
using FireSharp.Config;
using FireSharp.Response;

namespace Datos
{

    public static class NodoDatos
    {


        static IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "5mGJiJMVRl07l2LPIBGMVnaYWitmlh9q9vbyGwkc",
            BasePath = "https://proyectodistribuidojf-default-rtdb.firebaseio.com/"
        };

        static IFirebaseClient client = new FireSharp.FirebaseClient(config);

        /*
        public static async Task<List<NodoEntidad>> DevolverNodosAsync()
        {
            bool siguiente = true;
            int i = -1;
            List<NodoEntidad> listado = new List<NodoEntidad>();
            while (siguiente)
            {
                i++;
                try
                {
                    FirebaseResponse response = await client.GetAsync("Usuario/"+i);
                    NodoEntidad obj = response.ResultAs<NodoEntidad>();
                    if (obj == null)
                    {
                        siguiente = false;
                    }else
                    {
                        listado.Add(obj);
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
            return listado;
        }*/

        public static async Task<List<NodoEntidad>> DevolverNodosAsync()
        {

            List<NodoEntidad> listado = new List<NodoEntidad>();

                try
                {
                    FirebaseResponse response = await client.GetAsync("Usuario/");
                    listado = response.ResultAs<List<NodoEntidad>>();

                }
                catch (Exception)
                {
                    throw;
                }

            return listado;
        }
        public static async Task<NodoEntidad> AgregarNodo(NodoEntidad nodo)
        {
            bool siguiente = true;
            int i = -1;
            while (siguiente)
            {
                i++;
                try
                {
                    FirebaseResponse response = await client.GetAsync("Usuario/" + i);
                    NodoEntidad obj = response.ResultAs<NodoEntidad>();
                    if (obj == null)
                    {
                        siguiente = false;
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
            nodo.Id = i;
            FirebaseResponse response1 = await client.SetAsync("Usuario/" + i,nodo);
            NodoEntidad resultado = response1.ResultAs<NodoEntidad>();

            return resultado;
        }
        public static async Task<NodoEntidad> ActualizarNodo(NodoEntidad nodo)
        {

            FirebaseResponse response1 = await client.SetAsync("Usuario/" + nodo.Id.ToString(), nodo);
            NodoEntidad resultado = response1.ResultAs<NodoEntidad>();

            return resultado;
        }
        public static async Task<NodoEntidad> EliminarNodo(NodoEntidad nodo)
        {

            try
            {
                    FirebaseResponse response = client.Delete("Usuario/" + nodo.Id.ToString());
                    NodoEntidad obj = response.ResultAs<NodoEntidad>();
                    return obj;
            }
            catch (Exception)
            {

                throw;
            }
            
        }
    }
}
