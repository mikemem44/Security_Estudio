using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public static bool Anular(int IdRol)
        { 
            return DAL_Roles.Anular(IdRol);
        }

    }
}
