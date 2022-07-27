using Entidad;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public static class PersonaDatos
    {
        static IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "5mGJiJMVRl07l2LPIBGMVnaYWitmlh9q9vbyGwkc",
            BasePath = "https://proyectodistribuidojf-default-rtdb.firebaseio.com/"
        };
        static IFirebaseClient client = new FireSharp.FirebaseClient(config);

        public static async Task<List<PersonaEntidad>> administrador()
        {

            List<PersonaEntidad> listado = new List<PersonaEntidad>();

            try
            {
                FirebaseResponse response = await client.GetAsync("Administrador/");
                listado = response.ResultAs<List<PersonaEntidad>>();

            }
            catch (Exception)
            {
                throw;
            }

            return listado;
        }
    }
}
