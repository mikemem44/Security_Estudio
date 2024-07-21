using DAL;
using EL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public static class BL_Usuario
    {
        public static Usuarios Insert(Usuarios Entidad)
        {
            return DAL_Usuario.Insert(Entidad);
        }

        public static bool Update(Usuarios Entidad)
        {
            return DAL_Usuario.Update(Entidad);
        }

        public static bool Anular(Usuarios Entidad)
        {
            return DAL_Usuario.Anular(Entidad);
        }

        public static List<Usuarios> Lista(bool Activo = true)
        {
            return DAL_Usuario.Lista();
        }

        public static bool Existe(Usuarios Entidad)
        {
            return DAL_Usuario.Existe(Entidad);
        }

        public static int ObtenerIDUsuario(string username)
        {
            return DAL_Usuario.ObtenerIDUsuario(username);
        }

        public static bool ValidarCredenciales(Usuarios Entidad)
        {
            return DAL_Usuario.ValidarCredenciales(Entidad);
        }

        public static byte[] Sha256(string input)
        {
            return DAL_Usuario.Sha256(input);
        }
    }
}
