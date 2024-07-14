using EL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class DAL_Roles
    {
        public static Roles Insert(Roles Entidad)
        {
            using (BDInformaticSecuriy bd = new BDInformaticSecuriy())
            {
                Entidad.Activo = true;
                Entidad.FechaRegistro = DateTime.Now;
                bd.Roles.Add(Entidad);
                bd.SaveChanges();
                return Entidad;
            }
        }
        public static bool Update(Roles Entidad)
        {
            using (BDInformaticSecuriy bd = new BDInformaticSecuriy())
            {
                var Registro = bd.Roles.Find(Entidad.IdRol);
                Registro.NombreRol = Entidad.NombreRol;
                Registro.IdUsuarioActualiza = Entidad.IdUsuarioActualiza;
                Registro.FechaActualizacion = Entidad.FechaActualizacion;
                return bd.SaveChanges() > 0;
            }
        }
        public static bool Anular(Roles Entidad)
        {
            using (BDInformaticSecuriy bd = new BDInformaticSecuriy())
            {
                var Registro = bd.Roles.Find(Entidad.IdRol);
                Registro.Activo = Entidad.Activo;
                Registro.IdUsuarioActualiza = Entidad.IdUsuarioActualiza;
                Registro.FechaActualizacion = Entidad.FechaActualizacion;
                return bd.SaveChanges() > 0;
            }
        }
        public static bool Existe(Roles Entidad)
        {
            using (BDInformaticSecuriy bd = new BDInformaticSecuriy())
            {
                return bd.Roles.Where(a => a.IdRol == Entidad.IdRol).Count() > 0;
            }
        }
        public static Roles Registro(Roles Entidad)
        {
            using (BDInformaticSecuriy bd = new BDInformaticSecuriy())
            {
                return bd.Roles.Where(a => a.IdRol == Entidad.IdRol).SingleOrDefault();
            }
        }
        public static List<Roles> Lista(bool Activo = true)
        {
            using (BDInformaticSecuriy bd = new BDInformaticSecuriy())
            {
                return bd.Roles.Where(a => a.Activo == Activo).ToList();
            }
        }
    }
}

