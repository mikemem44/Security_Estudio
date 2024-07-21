using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class DAL_RoPermiso
    {
        public static RolPermiso Insert(RolPermiso Entidad)
        {
            using (BDInformaticSecuriy bd = new BDInformaticSecuriy())
            {
                Entidad.Activo = true;
                Entidad.FechaRegistro = DateTime.Now;
                bd.RolPermiso.Add(Entidad);
                bd.SaveChanges();
                return Entidad;
            }
        }
        public static bool Update(RolPermiso Entidad)
        {
            using (BDInformaticSecuriy bd = new BDInformaticSecuriy())
            {
                var Registro = bd.RolPermiso.Find(Entidad.IdRolPermiso);
                Registro.NombreRol = Entidad.NombreRol;
                Registro.IdUsuarioActualiza = Entidad.IdUsuarioActualiza;
                Registro.FechaActualizacion = Entidad.FechaActualizacion;
                return bd.SaveChanges() > 0;
            }
        }
        public static bool Anular(RolPermiso Entidad)
        {
            using (BDInformaticSecuriy bd = new BDInformaticSecuriy())
            {
                var Registro = bd.RolPermiso.Find(Entidad.IdRolPermiso);
                Registro.Activo = Entidad.Activo;
                Registro.IdUsuarioActualiza = Entidad.IdUsuarioActualiza;
                Registro.FechaActualizacion = Entidad.FechaActualizacion;
                return bd.SaveChanges() > 0;
            }
        }
        public static bool Existe(RolPermiso Entidad)
        {
            using (BDInformaticSecuriy bd = new BDInformaticSecuriy())
            {
                return bd.RolPermiso.Where(a => a.IdRolPermiso == Entidad.IdRolPermiso).Count() > 0;
            }
        }
        public static RolPermiso Registro(RolPermiso Entidad)
        {
            using (BDInformaticSecuriy bd = new BDInformaticSecuriy())
            {
                return bd.RolPermiso.Where(a => a.IdRolPermiso == Entidad.IdRolFormulario).SingleOrDefault();
            }
        }
        public static List<RolPermiso> Lista(bool Activo = true)
        {
            using (BDInformaticSecuriy bd = new BDInformaticSecuriy())
            {
                return bd.RolPermiso.Where(a => a.Activo == Activo).ToList();
            }
        }
    }
}
