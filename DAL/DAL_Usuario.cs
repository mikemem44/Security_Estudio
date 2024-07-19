using EL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class DAL_Usuario
    {
        public static Usuarios Insert(Usuarios Entidad)
        {
            using (BDInformaticSecuriy bd = new BDInformaticSecuriy())
            {
                Entidad.Activo = true;
                Entidad.FechaRegistro = DateTime.Now;
                bd.Usuarios.Add(Entidad);
                bd.SaveChanges();
                return Entidad;
            }
        }
        public static bool Update(Usuarios Entidad)
        {
            using (BDInformaticSecuriy bd = new BDInformaticSecuriy())
            {
                var Registro = bd.Usuarios.Find(Entidad.IdUsuario);
                Registro.NombreCompleto = Entidad.NombreCompleto;
                Registro.NombreUsuario = Entidad.NombreUsuario;
                Registro.Contrasena = Entidad.Contrasena;
                Registro.IdRol = Entidad.IdRol;
                Registro.IdUsuarioActualiza = Entidad.IdUsuarioActualiza;
                Registro.FechaActualizacion = Entidad.FechaActualizacion;
                return bd.SaveChanges() > 0;
            }
        }
        public static bool Anular(Usuarios Entidad)
        {
            using (BDInformaticSecuriy bd = new BDInformaticSecuriy())
            {
                var Registro = bd.Usuarios.Find(Entidad.IdUsuario);
                Registro.Activo = Entidad.Activo;
                Registro.IdUsuarioActualiza = Entidad.IdUsuarioActualiza;
                Registro.FechaActualizacion = Entidad.FechaActualizacion;
                return bd.SaveChanges() > 0;
            }
        }


        public static List<Usuarios> Lista (bool Activo = true)
        {
            using (BDInformaticSecuriy bd = new BDInformaticSecuriy())
            {
                return bd.Usuarios.Where(a => a.Activo == Activo).ToList();
            }
        }

        public static bool Existe(Usuarios Entidad)
        {
            using (BDInformaticSecuriy bd = new BDInformaticSecuriy())
            {
                return bd.Usuarios.Where(a => a.IdUsuario == Entidad.IdUsuario).Count() > 0;
            }
        }

        public static int ObtenerIDUsuario(string username)
        {
            using (BDInformaticSecuriy bd = new BDInformaticSecuriy())
            {
                var Registro = bd.Usuarios.FirstOrDefault(a => a.NombreUsuario == username);

                return Registro?.IdUsuario ?? -1;

            }
        }

        public static bool ValidarCredenciales(Usuarios Entidad) 
        {
            using (BDInformaticSecuriy bd = new BDInformaticSecuriy())
            {
                var Registro = bd.Usuarios.Find(Entidad.IdUsuario);
                return bd.Usuarios.Where(
                        a=>a.NombreUsuario == Entidad.NombreUsuario &&
                        a.Contrasena == Entidad.Contrasena)
                    .Count() > 0;
            }
        }

        public static byte[] Sha256(string input)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                return sha256.ComputeHash(UTF8Encoding.UTF8.GetBytes(input));
            }
        }
    }
}
