using EL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class DAL_Permisos
    {
        public static Permisos Insert(Permisos Entidad)
        {
            using (BDInformaticSecuriy bd = new BDInformaticSecuriy())
            {
                Entidad.Activo = true;
                Entidad.FechaRegistro = DateTime.Now;
                bd.Permisos.Add(Entidad);
                bd.SaveChanges();
                return Entidad;
            }
        }
        public static bool Update(Permisos Entidad)
        {
            using (BDInformaticSecuriy bd = new BDInformaticSecuriy())
            {
                var Registro = bd.Permisos.Find(Entidad.IdPermiso);
                Registro.NombrePermiso = Entidad.NombrePermiso;
                Registro.IdUsuarioActualiza = Entidad.IdUsuarioActualiza;
                Registro.FechaActualizacion = Entidad.FechaActualizacion;
                return bd.SaveChanges() > 0;
            }
        }
        public static bool Anular(Permisos Entidad)
        {
            using (BDInformaticSecuriy bd = new BDInformaticSecuriy())
            {
                var Registro = bd.Permisos.Find(Entidad.IdPermiso);
                Registro.Activo = Entidad.Activo;
                Registro.IdUsuarioActualiza = Entidad.IdUsuarioActualiza;
                Registro.FechaActualizacion = Entidad.FechaActualizacion;
                return bd.SaveChanges() > 0;
            }
        }
        public static bool Existe(Permisos Entidad)
        {
            using (BDInformaticSecuriy bd = new BDInformaticSecuriy())
            {
                return bd.Permisos.Where(a => a.IdPermiso == Entidad.IdPermiso).Count() > 0;
            }
        }
        public static Permisos Registro(Permisos Entidad)
        {
            using (BDInformaticSecuriy bd = new BDInformaticSecuriy())
            {
                return bd.Permisos.Where(a => a.IdPermiso == Entidad.IdPermiso).SingleOrDefault();
            }
        }
        public static List<Permisos> Lista(bool Activo = true)
        {
            using (BDInformaticSecuriy bd = new BDInformaticSecuriy())
            {
                return bd.Permisos.Where(a => a.Activo == Activo).ToList();
            }
        }

    }
}
