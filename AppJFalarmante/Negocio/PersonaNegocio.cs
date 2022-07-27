using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidad;

namespace Negocio
{
    public static class PersonaNegocio
    {
        public static async Task<List<PersonaEntidad>> administrador()
        {
            return await PersonaDatos.administrador();
        }
    }
}
