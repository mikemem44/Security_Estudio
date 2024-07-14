using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using EL;

namespace BL
{
    public static class BL_Roles
    {
        public static Roles Insert(Roles Entidad)
        {
            return DAL_Roles.Insert(Entidad);
        }
        public static bool Update(Roles Entidad)
        {
            return DAL_Roles.Update(Entidad);
        }
        public static bool Anular(Roles Entidad)
        {
            return DAL_Roles.Anular(Entidad);
        }
        public static bool Existe(Roles Entidad)
        {
            return DAL_Roles.Existe(Entidad);
        }
        public static Roles Registro(Roles Entidad)
        {
            return DAL_Roles.Registro(Entidad);
        }
        public static List<Roles> Lista(bool Activo = true)
        {
            return DAL_Roles.Lista(Activo);
        }

    }
}
