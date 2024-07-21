using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EL;

namespace DAL
{
    public static class DAL_Usuarios
    {
        public static bool ValidarUserName(string UserName)
        {
            using (BDInformaticSecuriy bd = new BDInformaticSecuriy())
            {
                return bd.Usuarios.Where(a => a.NombreUsuario == UserName).Count() > 0;
            }
        }
        public static bool ValidarPassword(byte[] Password)
        {
            using (BDInformaticSecuriy bd = new BDInformaticSecuriy())
            {
                return bd.Usuarios.Where(a => a.Contrasena == Password).Count() > 0;

            }
        }
        public static Usuarios Login(string UserName, byte[] Password)
        {
            using (BDInformaticSecuriy bd = new BDInformaticSecuriy())
            {
                return bd.Usuarios.Where(a => a.NombreUsuario == UserName && a.Contrasena == Password).SingleOrDefault();
            }
        }

    }
}
